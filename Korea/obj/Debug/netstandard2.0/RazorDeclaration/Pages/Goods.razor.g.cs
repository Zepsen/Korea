#pragma checksum "c:\Projects\Korea\Korea\Korea\Pages\Goods.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "427c382413f7dd408970622f9b0fce70c3a11c09"
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
#line 2 "c:\Projects\Korea\Korea\Korea\Pages\Goods.razor"
using Korea.Shared.Models;

#line default
#line hidden
#line 3 "c:\Projects\Korea\Korea\Korea\Pages\Goods.razor"
using Korea.Shared.Pages;

#line default
#line hidden
#line 4 "c:\Projects\Korea\Korea\Korea\Pages\Goods.razor"
using System.Linq;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/category/{Id:int}")]
    public class Goods : Page
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 27 "c:\Projects\Korea\Korea\Korea\Pages\Goods.razor"
 	
	[Parameter]
    public int Id { get; set; }
	
	protected override void Breadcrumbs()
	{
		basePage.AddBreadcrump(new List<Breadcrumb> 
		{ 
			new Breadcrumb { Name = "Categories", Route = "/" },
			new Breadcrumb { Name = Crumb(), Active = true }
		});
	}
	
	protected List<Good> goods = new List<Good>();
	protected override async Task OnInitializedAsync()
	{
		var res = await Http.GetJsonAsync<List<Good>>("sample-data/goods.json");
		goods = res.Where(i => i.CategoryId == Id).ToList();
	}

	protected string Crumb() 
	{
		switch(Id) 
		{
			case 1: return "Shampoon";
			case 2: return "Masks";
			case 3: return "Test";
			case 4: return "Test2";
			case 5: return "Test3";			
		}

		return null;
	}


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
