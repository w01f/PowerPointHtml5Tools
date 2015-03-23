using SiteManager.Business.Enums;

namespace SiteManager.Business.Interfaces
{
	interface IPageController
	{
		bool IsActive { get; set; }
		void Init();
		void ShowPage(TabPageEnum tabPage);
	}
}
