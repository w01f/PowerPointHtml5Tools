using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using SiteManager.Business.Enums;
using SiteManager.Business.Interfaces;
using SiteManager.Business.Interops;
using SiteManager.Business.Services;
using SiteManager.PresentationLayer.Progress;

namespace SiteManager.Controllers
{
	class MainController
	{
		public const string SiteUrl = "http://clientweblink.com";//"http://192.168.133.1/ClientWebLinks"

		private static readonly MainController _instance = new MainController();

		private readonly Dictionary<TabPageEnum, IPageController> _tabPages = new Dictionary<TabPageEnum, IPageController>();
		private TabPageEnum _activeTab;

		public FormMain MainForm { get; private set; }
		public PopupMessageHelper PopupMessages { get; private set; }

		#region Tab Pages
		private ReportsPage _pageReports;
		#endregion

		public static MainController Instance
		{
			get { return _instance; }
		}

		private MainController()
		{
			MainForm = new FormMain();
			PopupMessages = new PopupMessageHelper("Site Manager");
		}

		public void RunApplication()
		{
			MainForm.Shown += (o, e) =>
			{
				var mainForm = (Form)o;
				FormProgress.RunProcessWithProgress("Loading Controls...", MainForm, () => mainForm.Invoke(new MethodInvoker(() =>
				{
					InitControllers();
					Application.DoEvents();
					ShowTab(TabPageEnum.Reports);
				})));
			};
			Application.Run(MainForm);
		}

		public void ActivateApplication()
		{
			var mainFormHandle = IntPtr.Zero;
			foreach (var process in Process.GetProcesses().Where(x => x.ProcessName.Contains("SiteManager")))
			{
				if (process.MainWindowHandle.ToInt32() == 0) continue;
				mainFormHandle = process.MainWindowHandle;
				break;
			}
			if (mainFormHandle.ToInt32() == 0) return;
			WinAPIHelper.ShowWindow(mainFormHandle, WindowShowStyle.ShowMaximized);
			WinAPIHelper.MakeTopMost(mainFormHandle); WinAPIHelper.MakeNormal(mainFormHandle);
			uint lpdwProcessId;
			WinAPIHelper.AttachThreadInput(WinAPIHelper.GetCurrentThreadId(), WinAPIHelper.GetWindowThreadProcessId(WinAPIHelper.GetForegroundWindow(), out lpdwProcessId), true);
			WinAPIHelper.SetForegroundWindow(mainFormHandle);
			WinAPIHelper.AttachThreadInput(WinAPIHelper.GetCurrentThreadId(), WinAPIHelper.GetWindowThreadProcessId(WinAPIHelper.GetForegroundWindow(), out lpdwProcessId), false);
		}

		public void ShowTab(TabPageEnum tabPage = TabPageEnum.Undefined)
		{
			MainForm.ribbonControl.Enabled = true;
			if (tabPage == TabPageEnum.Undefined)
				tabPage = _activeTab;

			foreach (var pageController in _tabPages.Where(pageController => pageController.Key == _activeTab))
				pageController.Value.IsActive = false;

			_activeTab = tabPage;
			if (!_tabPages.ContainsKey(tabPage)) return;
			_tabPages[tabPage].ShowPage(tabPage);
		}

		private void InitControllers()
		{
			_pageReports = new ReportsPage();
			_pageReports.Init();
			_tabPages.Add(TabPageEnum.Reports, _pageReports);
		}
	}
}
