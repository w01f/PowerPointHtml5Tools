using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SiteManager.PresentationLayer.Reports
{
	interface IReportControl
	{
		Control ViewControl { get; }
		IEnumerable<Control> FilterControls { get; }
		void LoadData(DateTime dateBegin, DateTime dateEnd);
	}
}
