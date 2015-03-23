using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using RestSharp;
using SiteManager.Business.Models.Common;
using SiteManager.Business.Models.RawActivityData;
using SiteManager.Controllers;
using SiteManager.PresentationLayer.Progress;

namespace SiteManager.PresentationLayer.Reports.RawData
{
	public sealed partial class ContainerControl : UserControl, IReportControl
	{
		private List<RawActivityModel> _data = new List<RawActivityModel>();

		public ContainerControl()
		{
			InitializeComponent();
			Dock = DockStyle.Fill;
		}

		public Control ViewControl
		{
			get { return this; }
		}

		public IEnumerable<Control> FilterControls
		{
			get { return new Control[] { }; }
		}

		public void LoadData(DateTime dateBegin, DateTime dateEnd)
		{
			gridControlData.DataSource = null;
			_data.Clear();

			var isSuccessful = false;
			FormProgress.RunProcessWithProgress("Loading Data...", MainController.Instance.MainForm, () =>
			{
				try
				{
					var client = new RestClient(MainController.SiteUrl);
					var request = new RestRequest("activity/list", Method.GET);
					request.AddParameter("dateBegin", dateBegin);
					request.AddParameter("dateEnd", dateEnd);
					var response = ResponeModel.Deserialize(client.Execute(request).Content);
					isSuccessful = response.IsSuccess;
					if (isSuccessful)
						_data.AddRange(response.GetData<RawActivityModel[]>());
				}
				catch (Exception)
				{
					isSuccessful = false;
				}
			});

			if (isSuccessful)
			{
				gridControlData.DataSource = _data;
				gridViewData.RefreshData();
			}
			else
				MainController.Instance.PopupMessages.ShowWarning("Error occured while loading data");

		}
	}
}
