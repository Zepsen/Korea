#pragma checksum "C:\Projects\Korea\korea\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2acdf7532055e313a3d3daae28ee8ccd322d688"
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
#line 1 "C:\Projects\Korea\korea\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Projects\Korea\korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Projects\Korea\korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Projects\Korea\korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Projects\Korea\korea\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Projects\Korea\korea\_Imports.razor"
using Korea;

#line default
#line hidden
#line 7 "C:\Projects\Korea\korea\_Imports.razor"
using Korea.Shared;

#line default
#line hidden
#line 4 "C:\Projects\Korea\korea\Pages\Home.razor"
using Korea.Shared.Models;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav aria-label=\"breadcrumb\">\r\n  <ol class=\"breadcrumb\">\r\n    <li class=\"breadcrumb-item active\">Home</li>    \r\n  </ol>\r\n</nav>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n");
#line 13 "C:\Projects\Korea\korea\Pages\Home.razor"
     foreach (var category in categories)
	{

#line default
#line hidden
            __builder.AddMarkupContent(4, "\t\t");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12 col-md-6 col-lg-3 p-1");
            __builder.AddMarkupContent(7, "\r\n\t\t\t");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card");
            __builder.AddMarkupContent(10, "\r\n\t\t\t\t");
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "src", 
#line 17 "C:\Projects\Korea\korea\Pages\Home.razor"
                           category.Image

#line default
#line hidden
            );
            __builder.AddAttribute(13, "class", "card-img-top");
            __builder.AddAttribute(14, "alt", 
#line 17 "C:\Projects\Korea\korea\Pages\Home.razor"
                                                                      category.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\t\t\t\t");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card-body");
            __builder.AddMarkupContent(18, "\r\n\t\t\t\t\t");
            __builder.OpenElement(19, "h5");
            __builder.AddAttribute(20, "class", "card-title");
            __builder.AddContent(21, 
#line 19 "C:\Projects\Korea\korea\Pages\Home.razor"
                                            category.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\t\t\t\t\t");
            __builder.OpenElement(23, "p");
            __builder.AddAttribute(24, "class", "card-text");
            __builder.AddContent(25, 
#line 20 "C:\Projects\Korea\korea\Pages\Home.razor"
                                          category.Description

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\t\t\t\t\t\r\n\t\t\t\t\t");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(27);
            __builder.AddAttribute(28, "class", "btn btn-outline-info");
            __builder.AddAttribute(29, "href", 
#line 21 "C:\Projects\Korea\korea\Pages\Home.razor"
                                                                 GetUrl(category.Id)

#line default
#line hidden
            );
            __builder.AddAttribute(30, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#line 21 "C:\Projects\Korea\korea\Pages\Home.razor"
                                                                                             NavLinkMatch.All

#line default
#line hidden
            ));
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(32, "\r\n                \t\tGo to\r\n            \t\t");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n\t\t\t\t\t\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#line 28 "C:\Projects\Korea\korea\Pages\Home.razor"
	}

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 32 "C:\Projects\Korea\korea\Pages\Home.razor"
 
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