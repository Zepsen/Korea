#pragma checksum "c:\Projects\Korea\Korea\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcceb57e2a5b8302f1c5cb475c480d4419c733df"
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
#line 8 "c:\Projects\Korea\Korea\_Imports.razor"
using Korea.Shared.Components;

#line default
#line hidden
#line 1 "c:\Projects\Korea\Korea\Pages\Home.razor"
using Korea.Shared.Models;

#line default
#line hidden
#line 2 "c:\Projects\Korea\Korea\Pages\Home.razor"
using Korea.Core;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Home : Page
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 28 "c:\Projects\Korea\Korea\Pages\Home.razor"
 
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
