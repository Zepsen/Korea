#pragma checksum "C:\Projects\Korea\korea\korea\Pages\Goods.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d3bf7d98d5d9d0d9264fe0bf85955e59f31ee37"
// <auto-generated/>
#pragma warning disable 1591
namespace Korea.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Projects\Korea\korea\korea\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Projects\Korea\korea\korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Projects\Korea\korea\korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Projects\Korea\korea\korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Projects\Korea\korea\korea\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Projects\Korea\korea\korea\_Imports.razor"
using Korea;

#line default
#line hidden
#line 7 "C:\Projects\Korea\korea\korea\_Imports.razor"
using Korea.Shared;

#line default
#line hidden
#line 2 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
using Korea.Shared.Models;

#line default
#line hidden
#line 3 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
using Korea.Core;

#line default
#line hidden
#line 4 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
using Korea.Shared.Components;

#line default
#line hidden
#line 5 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
using System.Linq;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/category/{Id:int}")]
    public class Goods : Page
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n");
#line 11 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
     foreach (var good in goods.Data)
	{

#line default
#line hidden
            __builder.AddMarkupContent(3, "\t\t");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-12 col-md-6 col-lg-3 p-1");
            __builder.AddMarkupContent(6, "\r\n\t\t\t");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card shadow-sm pointer");
            __builder.AddMarkupContent(9, "\r\n\t\t\t\t");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", 
#line 15 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
                           good.Image

#line default
#line hidden
            );
            __builder.AddAttribute(12, "class", "card-img-top");
            __builder.AddAttribute(13, "alt", 
#line 15 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
                                                                  good.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\t\t\t\t");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-body");
            __builder.AddMarkupContent(17, "\r\n\t\t\t\t\t");
            __builder.OpenElement(18, "h5");
            __builder.AddAttribute(19, "class", "card-title");
            __builder.AddContent(20, 
#line 17 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
                                            good.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\t\t\t\t\t");
            __builder.OpenElement(22, "p");
            __builder.AddAttribute(23, "class", "card-text");
            __builder.AddContent(24, 
#line 18 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
                                          good.Description

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\t\t\t\t\t");
            __builder.OpenElement(26, "h2");
            __builder.OpenElement(27, "span");
            __builder.AddAttribute(28, "class", "badge badge-secondary");
            __builder.AddContent(29, 
#line 19 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
                                                             good.Price

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\t\t\t\t\t");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", 
#line 20 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
                              GetUrl(good.Id)

#line default
#line hidden
            );
            __builder.AddAttribute(33, "class", "btn btn-default");
            __builder.AddContent(34, "Go to ");
            __builder.AddContent(35, 
#line 20 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
                                                                              good.Id

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#line 24 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
	}	

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "row");
            __builder.AddMarkupContent(43, "\r\n\t");
            __builder.OpenComponent<Korea.Shared.Components.Pagination>(44);
            __builder.AddAttribute(45, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Korea.Shared.Models.PaginationModel>(
#line 28 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
                       pagination

#line default
#line hidden
            ));
            __builder.AddAttribute(46, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#line 28 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
                                             OnChangePage

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 33 "C:\Projects\Korea\korea\korea\Pages\Goods.razor"
 	
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
