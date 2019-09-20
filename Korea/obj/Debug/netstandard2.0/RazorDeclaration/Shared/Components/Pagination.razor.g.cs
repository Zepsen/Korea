#pragma checksum "c:\Projects\Korea\Korea\Shared\Components\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c338e8b960a2c8e79baf15aae2f5aeba6eed7748"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Korea.Shared.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "c:\Projects\Korea\Korea\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "c:\Projects\Korea\Korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "c:\Projects\Korea\Korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "c:\Projects\Korea\Korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "c:\Projects\Korea\Korea\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "c:\Projects\Korea\Korea\_Imports.razor"
using Korea;

#line default
#line hidden
#line 7 "c:\Projects\Korea\Korea\_Imports.razor"
using Korea.Shared;

#line default
#line hidden
#line 1 "c:\Projects\Korea\Korea\Shared\Components\Pagination.razor"
using Korea.Shared.Models;

#line default
#line hidden
    public class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 11 "c:\Projects\Korea\Korea\Shared\Components\Pagination.razor"
 
	[Parameter]
	public PaginationModel Model { get; set; }

	[Parameter]
    public EventCallback<int> OnChange { get; set; }

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

#line default
#line hidden
    }
}
#pragma warning restore 1591
