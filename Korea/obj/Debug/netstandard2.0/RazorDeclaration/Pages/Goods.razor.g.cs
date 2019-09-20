#pragma checksum "c:\Projects\Korea\Korea\Korea\Pages\Goods.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f74961cae6b5c1f0059d226c8f57c3653d53129"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Korea.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "c:\Projects\Korea\Korea\Korea\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "c:\Projects\Korea\Korea\Korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "c:\Projects\Korea\Korea\Korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "c:\Projects\Korea\Korea\Korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "c:\Projects\Korea\Korea\Korea\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "c:\Projects\Korea\Korea\Korea\_Imports.razor"
using Korea;

#line default
#line hidden
#line 7 "c:\Projects\Korea\Korea\Korea\_Imports.razor"
using Korea.Shared;

#line default
#line hidden
#line 2 "c:\Projects\Korea\Korea\Korea\Pages\Goods.razor"
using Korea.Shared.Models;

#line default
#line hidden
#line 3 "c:\Projects\Korea\Korea\Korea\Pages\Goods.razor"
using Korea.Core;

#line default
#line hidden
#line 4 "c:\Projects\Korea\Korea\Korea\Pages\Goods.razor"
using Korea.Shared.Components;

#line default
#line hidden
#line 5 "c:\Projects\Korea\Korea\Korea\Pages\Goods.razor"
using System.Linq;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/category/{Id:int}")]
    public class Goods : Page
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 33 "c:\Projects\Korea\Korea\Korea\Pages\Goods.razor"
 	
	[Parameter]
    public int Id { get; set; }

	private PaginationModel pagination = new PaginationModel();
	private Result<Good> goods = new Result<Good>();
	private FilterModel filter = new FilterModel();
    		

	protected override void Breadcrumbs()
	{
		BasePage.AddBreadcrump(new List<Breadcrumb> 
		{ 
			new Breadcrumb { Name = "Categories", Route = "/" },
			new Breadcrumb { Name = Category.Crumb(Id), Active = true }
		});
	}

	protected override async Task OnInitializedAsync()
	{
		goods = await GetGoods(filter);
	}

	private async Task<Result<Good>> GetGoods(FilterModel filter)
	{
		var res = await Http.GetJsonAsync<List<Good>>("sample-data/goods.json");
			res = res.Where(i => i.CategoryId == Id).ToList();
				
		pagination.LastPage = res.Count / filter.Take + 1;

		return new Result<Good> 
		{
			Data = res.Skip((filter.Page - 1) * filter.Take).Take(filter.Take).ToList(),
			Total = res.Count
		};		
	}

	private string GetUrl(int id) => $"good/{Id}/{id}";

	private async Task OnChangePage(int page)
	{
		filter.Page = page;
		pagination.Page = page;
		goods = await GetGoods(filter);
	}

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
