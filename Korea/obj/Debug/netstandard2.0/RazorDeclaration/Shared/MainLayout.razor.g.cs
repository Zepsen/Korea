#pragma checksum "C:\Projects\Korea\Korea\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60cc303335fe1fc75c0a1582ca41b9b8cbe9db9c"
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
#line 8 "C:\Projects\Korea\Korea\_Imports.razor"
using Korea.Shared;

#line default
#line hidden
#line 9 "C:\Projects\Korea\Korea\_Imports.razor"
using Korea.Shared.Components;

#line default
#line hidden
#line 1 "C:\Projects\Korea\Korea\Shared\MainLayout.razor"
using Korea.Core;

#line default
#line hidden
#line 2 "C:\Projects\Korea\Korea\Shared\MainLayout.razor"
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
#line 44 "C:\Projects\Korea\Korea\Shared\MainLayout.razor"
 
	private List<Breadcrumb> breads = new List<Breadcrumb> { new Breadcrumb { Name = "Home"} };
	
	public void AddBreadcrump(List<Breadcrumb> breadcrumbs)
	{
		breads = breadcrumbs;
		StateHasChanged();
	}

	public bool HasHeader { get; set;} = true;

	private string Theme => DarkTheme ? "darktheme" : null;
	private bool DarkTheme { get; set; } = true;
	
	private void ToggleTheme()
	{
		DarkTheme = !DarkTheme;
	} 

#line default
#line hidden
    }
}
#pragma warning restore 1591
