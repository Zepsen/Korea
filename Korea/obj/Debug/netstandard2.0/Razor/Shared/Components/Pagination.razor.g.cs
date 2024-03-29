#pragma checksum "C:\Projects\Korea\Korea\Shared\Components\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "830445b7b0fc5ee7022f2aa75a34d26b0457569b"
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
#line 1 "C:\Projects\Korea\Korea\Shared\Components\Pagination.razor"
using Korea.Shared.Models;

#line default
#line hidden
    public class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "Page navigation example");
            __builder.AddMarkupContent(2, "\r\n\t");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pagination");
            __builder.AddMarkupContent(5, "\r\n\t\t");
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "class", "page-item" + " " + (
#line 5 "C:\Projects\Korea\Korea\Shared\Components\Pagination.razor"
                               Model.EnabledPrev ? null : "disabled"

#line default
#line hidden
            ));
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "class", "page-link");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 5 "C:\Projects\Korea\Korea\Shared\Components\Pagination.razor"
                                                                                                      Prev

#line default
#line hidden
            ));
            __builder.AddContent(11, "Previous");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\t\r\n");
#line 6 "C:\Projects\Korea\Korea\Shared\Components\Pagination.razor"
         foreach (var item in Range)
		{

#line default
#line hidden
            __builder.AddMarkupContent(13, "\t\t\t");
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "class", "page-item" + " " + (
#line 8 "C:\Projects\Korea\Korea\Shared\Components\Pagination.razor"
                                   item == Model.Page ? "active" : null

#line default
#line hidden
            ));
            __builder.AddMarkupContent(16, "\r\n\t\t\t\t");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "class", "page-link");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 9 "C:\Projects\Korea\Korea\Shared\Components\Pagination.razor"
                                               async () => await GoTo(item)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(20, "\r\n\t\t\t\t\t");
            __builder.AddContent(21, 
#line 10 "C:\Projects\Korea\Korea\Shared\Components\Pagination.razor"
                     item

#line default
#line hidden
            );
            __builder.AddMarkupContent(22, "\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#line 13 "C:\Projects\Korea\Korea\Shared\Components\Pagination.razor"
		}

#line default
#line hidden
            __builder.AddMarkupContent(25, "\t\t");
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "page-item" + " " + (
#line 14 "C:\Projects\Korea\Korea\Shared\Components\Pagination.razor"
                               Model.EnabledNext ? null : "disabled"

#line default
#line hidden
            ));
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "class", "page-link");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\Projects\Korea\Korea\Shared\Components\Pagination.razor"
                                                                                                      Next

#line default
#line hidden
            ));
            __builder.AddContent(31, "Next");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\t\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 19 "C:\Projects\Korea\Korea\Shared\Components\Pagination.razor"
 
	[Parameter]
	public PaginationModel Model { get; set; }

	[Parameter]
    public EventCallback<int> OnChange { get; set; }

	private IEnumerable<int> Range { get; set;}

	protected override void OnParametersSet()
	{
		var start = Model.Page == 1 ? Model.Page : Model.Page - 1;
		var end = start + 5 < Model.LastPage ? start + 5 : Model.LastPage;
		Range = Enumerable.Range(start, end);
	}	

	private async Task Prev()
	{
		if(Model.EnabledPrev) 
		{			
			await OnChange.InvokeAsync(Model.Page - 1);
		}
	}

	private async Task Next()
	{			
		if(Model.EnabledNext)		
		{
			await OnChange.InvokeAsync(Model.Page + 1);
		}
	}	

	private async Task GoTo(int page)
	{			
		if(Model.Page != page) 
		{
			await OnChange.InvokeAsync(page);
		}
	}	

#line default
#line hidden
    }
}
#pragma warning restore 1591
