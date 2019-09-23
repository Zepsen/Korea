#pragma checksum "C:\Projects\Korea\Korea\Shared\Components\GoodCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80b4a8ec69f1d00a9a82ac55e8d3412012854aa0"
// <auto-generated/>
#pragma warning disable 1591
namespace Korea.Shared.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Projects\Korea\Korea\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Projects\Korea\Korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Projects\Korea\Korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Projects\Korea\Korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Projects\Korea\Korea\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Projects\Korea\Korea\_Imports.razor"
using Korea;

#line default
#line hidden
#line 7 "C:\Projects\Korea\Korea\_Imports.razor"
using Korea.Core;

#line default
#line hidden
#line 8 "C:\Projects\Korea\Korea\_Imports.razor"
using Korea.Shared;

#line default
#line hidden
#line 9 "C:\Projects\Korea\Korea\_Imports.razor"
using Korea.Shared.Components;

#line default
#line hidden
#line 10 "C:\Projects\Korea\Korea\_Imports.razor"
using Korea.Shared.Models;

#line default
#line hidden
    public class GoodCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-sm-12 col-md-6 col-lg-3 p-1");
            __builder.AddMarkupContent(2, "\r\n\t");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card shadow-sm pointer");
            __builder.AddMarkupContent(5, "\r\n\t\t");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", 
#line 4 "C:\Projects\Korea\Korea\Shared\Components\GoodCard.razor"
                   Model.Image

#line default
#line hidden
            );
            __builder.AddAttribute(8, "class", "card-img-top");
            __builder.AddAttribute(9, "alt", 
#line 4 "C:\Projects\Korea\Korea\Shared\Components\GoodCard.razor"
                                                           Model.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\t\t");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n\t\t\t");
            __builder.OpenElement(14, "h5");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, 
#line 6 "C:\Projects\Korea\Korea\Shared\Components\GoodCard.razor"
                                    Model.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\t\t\t");
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "class", "card-text");
            __builder.AddContent(20, 
#line 7 "C:\Projects\Korea\Korea\Shared\Components\GoodCard.razor"
                                  Model.Description

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\t\t\t");
            __builder.OpenElement(22, "h2");
            __builder.OpenElement(23, "span");
            __builder.AddAttribute(24, "class", "badge badge-secondary");
            __builder.AddContent(25, 
#line 8 "C:\Projects\Korea\Korea\Shared\Components\GoodCard.razor"
                                                     Model.Price

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\t\t\t");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", 
#line 9 "C:\Projects\Korea\Korea\Shared\Components\GoodCard.razor"
                      GetUrl(Model.Id)

#line default
#line hidden
            );
            __builder.AddAttribute(29, "class", "btn btn-default");
            __builder.AddContent(30, "Go to ");
            __builder.AddContent(31, 
#line 9 "C:\Projects\Korea\Korea\Shared\Components\GoodCard.razor"
                                                                       Model.Id

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 15 "C:\Projects\Korea\Korea\Shared\Components\GoodCard.razor"
 
	[Parameter]
	public Good Model { get; set; }	

	private string GetUrl(int id) => $"good/{Model.CategoryId}/{Model.Id}";

#line default
#line hidden
    }
}
#pragma warning restore 1591
