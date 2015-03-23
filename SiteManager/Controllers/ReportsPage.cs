using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using SiteManager.Business.Enums;
using SiteManager.Business.Interfaces;
using SiteManager.PresentationLayer.Reports;

namespace SiteManager.Controllers
{
	public sealed partial class ReportsPage : UserControl, IPageController
	{
		private ReportsEnum _activeReport;
		private readonly Dictionary<ReportsEnum, IReportControl> _tabPages = new Dictionary<ReportsEnum, IReportControl>();

		public bool IsActive { get; set; }

		public ReportsPage()
		{
			InitializeComponent();
			Dock = DockStyle.Fill;
		}

		public void Init()
		{
			_tabPages.Add(ReportsEnum.RawData, new PresentationLayer.Reports.RawData.ContainerControl());

			MainController.Instance.MainForm.barCheckItemReportsRawData.ItemClick += OnReportSelectorClick;
			MainController.Instance.MainForm.barCheckItemReportsRawData.CheckedChanged += OnReportSelectorCheckedChanged;

			var today = DateTime.Today;
			dateEditStart.DateTime = today;
			dateEditEnd.DateTime = today.AddDays(1);

			_activeReport = ReportsEnum.RawData;
		}

		public void ShowPage(TabPageEnum tabPage)
		{
			IsActive = true;
			ShowReport();
			if (!MainController.Instance.MainForm.pnContainer.Controls.Contains(this))
				MainController.Instance.MainForm.pnContainer.Controls.Add(this);
			BringToFront();
		}

		private void ShowReport(ReportsEnum reportType = ReportsEnum.None)
		{
			if (reportType != ReportsEnum.None)
				_activeReport = reportType;
			var activeReportControl = _tabPages[_activeReport];
			if (!splitContainerControl.Panel2.Controls.Contains(activeReportControl.ViewControl))
				splitContainerControl.Panel2.Controls.Add(activeReportControl.ViewControl);
			activeReportControl.ViewControl.BringToFront();

			if (activeReportControl.FilterControls.Any())
			{
				foreach (var filterControl in activeReportControl.FilterControls)
				{
					if (!pnCustomFilter.Controls.Contains(filterControl))
						pnCustomFilter.Controls.Add(filterControl);
					filterControl.BringToFront();
				}
			}
		}

		private void OnReportSelectorClick(object sender, ItemClickEventArgs e)
		{
			var reportSelector = (BarCheckItem)sender;
			if (reportSelector.Checked) return;
			MainController.Instance.MainForm.barCheckItemReportsRawData.Checked = false;
			reportSelector.Checked = true;
		}

		private void OnReportSelectorCheckedChanged(object sender, ItemClickEventArgs e)
		{
			var reportSelector = (BarCheckItem)sender;
			if (!reportSelector.Checked) return;
			var reportTag = reportSelector.Tag as String;
			if (reportTag == null)
				throw new ArgumentNullException("Report Type is not set for Report selector button");
			var reportType = (ReportsEnum)Enum.Parse(typeof(ReportsEnum), reportTag);
			ShowReport(reportType);
		}

		private void simpleButtonLoadData_Click(object sender, EventArgs e)
		{
			var activeReportControl = _tabPages[_activeReport];
			activeReportControl.LoadData(dateEditStart.DateTime, dateEditEnd.DateTime);
		}
	}
}
