
using Korea.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Korea.Shared.Pages
{
	
	public abstract class Page : ComponentBase
	{
		[CascadingParameter]
		protected IBasePage basePage { get; set; }

		protected override void OnInitialized()
		{			
			Breadcrumbs();
		}

		protected abstract void Breadcrumbs();

	}
}