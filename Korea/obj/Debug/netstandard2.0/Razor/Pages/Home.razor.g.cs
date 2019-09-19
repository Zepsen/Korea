#pragma checksum "C:\Projects\Korea\korea\korea\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92925900d93f9c077f1ade326305ab17daa4e5b0"
// <auto-generated/>
#pragma warning disable 1591
namespace Korea.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
#line 1 "C:\Projects\Korea\korea\korea\Pages\Home.razor"
using Korea.Shared.Models;

#line default
#line hidden
#line 2 "C:\Projects\Korea\korea\korea\Pages\Home.razor"
using Korea.Core;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Home : Page
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n");
#line 9 "C:\Projects\Korea\korea\korea\Pages\Home.razor"
     foreach (var category in categories)
	{

#line default
#line hidden
            __builder.AddMarkupContent(3, "\t\t");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-12 col-md-6 col-lg-3 p-1");
            __builder.AddMarkupContent(6, "\r\n\t\t\t");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddMarkupContent(9, "\r\n\t\t\t\t");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", 
#line 13 "C:\Projects\Korea\korea\korea\Pages\Home.razor"
                           category.Image

#line default
#line hidden
            );
            __builder.AddAttribute(12, "class", "card-img-top");
            __builder.AddAttribute(13, "alt", 
#line 13 "C:\Projects\Korea\korea\korea\Pages\Home.razor"
                                                                      category.Name

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
#line 15 "C:\Projects\Korea\korea\korea\Pages\Home.razor"
                                            category.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\t\t\t\t\t");
            __builder.OpenElement(22, "p");
            __builder.AddAttribute(23, "class", "card-text");
            __builder.AddContent(24, 
#line 16 "C:\Projects\Korea\korea\korea\Pages\Home.razor"
                                          category.Description

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\t\t\t\t\t\r\n\t\t\t\t\t");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "class", "btn btn-outline-info");
            __builder.AddAttribute(28, "href", 
#line 17 "C:\Projects\Korea\korea\korea\Pages\Home.razor"
                                                                 GetUrl(category.Id)

#line default
#line hidden
            );
            __builder.AddAttribute(29, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#line 17 "C:\Projects\Korea\korea\korea\Pages\Home.razor"
                                                                                             NavLinkMatch.All

#line default
#line hidden
            ));
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(31, "\r\n                \t\tGo to\r\n            \t\t");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n\t\t\t\t\t\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#line 24 "C:\Projects\Korea\korea\korea\Pages\Home.razor"
	}

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 28 "C:\Projects\Korea\korea\korea\Pages\Home.razor"
 
	protected override void Breadcrumbs()
	{
		BasePage.AddBreadcrump(new List<Breadcrumb> 
		{ 
			new Breadcrumb { Name = "Categories", Active = true } , 			
		});
	}

	protected List<Category> categories = new List<Category>();
	protected override async Task OnInitializedAsync()
	{
		categories = await Http.GetJsonAsync<List<Category>>("sample-data/categories.json");			
	}

	protected string GetUrl(int id) 
	{
		return "category/" + id;
	}


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
