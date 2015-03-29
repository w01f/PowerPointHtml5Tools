using System;
using DevExpress.XtraBars.Ribbon;

namespace DropBoxUploader
{
	public partial class FormSuccess : RibbonForm
	{
		public FormSuccess(string advertiserName)
		{
			InitializeComponent();
			labelControlDescription.Text = String.Format(labelControlDescription.Text, advertiserName);
		}
	}
}
