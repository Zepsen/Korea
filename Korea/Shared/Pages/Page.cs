
using Microsoft.AspNetCore.Components;

namespace Korea.Shared.Pages
{
	public abstract class Page : ComponentBase
	{

		protected override void OnInitialized()
		{
			Breadcrumbs();
		}

		protected abstract void Breadcrumbs();
	}
}