#pragma checksum "c:\Projects\Korea\Korea\Pages\Goods copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "964e15464c3ff34300ed74c2c6611fe628efab32"
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
#line 4 "c:\Projects\Korea\Korea\Pages\Goods copy.razor"
using Korea.Shared.Models;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Goods_copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 24 "c:\Projects\Korea\Korea\Pages\Goods copy.razor"
 
	protected List<Good> goods = new List<Good>();
	protected override async Task OnInitializedAsync()
	{
		goods = await Http.GetJsonAsync<List<Good>>("sample-data/goods.json");
	}

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
