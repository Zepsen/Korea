#pragma checksum "c:\Projects\Korea\Korea\Korea\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73e5c56c0e5da2bb5ea350facdcc8c38ce8ad71e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Korea.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
#line 1 "c:\Projects\Korea\Korea\Korea\Shared\MainLayout.razor"
using Korea.Shared.Models;

#line default
#line hidden
    public class MainLayout : LayoutComponentBase, IBasePage
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 46 "c:\Projects\Korea\Korea\Korea\Shared\MainLayout.razor"
 
	private List<Breadcrumb> breads = new List<Breadcrumb> { new Breadcrumb { Name = "Home"} };
	
	public void AddBreadcrump(List<Breadcrumb> breadcrumbs)
	{
		breads = breadcrumbs;
		StateHasChanged();
	}

	public bool HasHeader { get; set;} = true;
	

#line default
#line hidden
    }
}
#pragma warning restore 1591
