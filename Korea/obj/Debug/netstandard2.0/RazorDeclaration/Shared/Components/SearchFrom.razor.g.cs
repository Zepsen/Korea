#pragma checksum "C:\Projects\Korea\Korea\Shared\Components\SearchFrom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49b7f0010300a7f82fc9e62719d1ee22d27d8efe"
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
    public class SearchFrom : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 8 "C:\Projects\Korea\Korea\Shared\Components\SearchFrom.razor"
 
	[Parameter]
	public EventCallback<string> OnChanged { get; set; }

	private void CheckChanged(ChangeEventArgs e)
	{
		var str = e.Value.ToString();
		if(string.IsNullOrEmpty(str)) return;

		OnChanged.InvokeAsync(str);
	}    

#line default
#line hidden
    }
}
#pragma warning restore 1591
