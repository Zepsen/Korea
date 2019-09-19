
using Korea.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Korea.Shared.Pages
{
	
	public abstract class Page : ComponentBase
	{
		[CascadingParameter]
		protected IBasePage basePage { get; set; }

		protected virtual bool HasHeader { get; set; } = true;
		protected virtual bool HasFooter { get; set; } = true;
		protected virtual bool HasBreadcrumbs { get; set; } = true;
	
		protected override void OnInitialized()
		{			
			basePage.HasHeader = HasHeader;
			Breadcrumbs();
		}

		protected abstract void Breadcrumbs();

	}
}