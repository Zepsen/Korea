#pragma checksum "C:\Projects\Korea\korea\Pages\ActiveGood.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5745356f467d6a8b42c45df57df0751f8406b516"
// <auto-generated/>
#pragma warning disable 1591
namespace Korea.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "C:\Projects\Korea\korea\Pages\ActiveGood.razor"
using Korea.Shared.Models;

#line default
#line hidden
#line 3 "C:\Projects\Korea\korea\Pages\ActiveGood.razor"
using Korea.Core;

#line default
#line hidden
#line 4 "C:\Projects\Korea\korea\Pages\ActiveGood.razor"
using System.Linq;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/good/{CategoryId:int}/{Id:int}")]
    public class ActiveGood : Page
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n\tasdf ");
            __builder.AddContent(3, 
#line 10 "C:\Projects\Korea\korea\Pages\ActiveGood.razor"
          CategoryId

#line default
#line hidden
            );
            __builder.AddMarkupContent(4, " \r\n\tasdfad ");
            __builder.AddContent(5, 
#line 11 "C:\Projects\Korea\korea\Pages\ActiveGood.razor"
            Id

#line default
#line hidden
            );
            __builder.AddMarkupContent(6, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 15 "C:\Projects\Korea\korea\Pages\ActiveGood.razor"
 	
	[Parameter]
    public int Id { get; set; }

	[Parameter]
    public int CategoryId { get; set; }
	
	protected override void Breadcrumbs()
	{
		BasePage.AddBreadcrump(new List<Breadcrumb> 
		{ 
			new Breadcrumb { Name = "Categories", Route = "/" },
			new Breadcrumb { Name = Category.Crumb(CategoryId), Route = $"/category/{this.CategoryId}" },
			new Breadcrumb { Name = Id.ToString(), Active = true }
		});
	}
	
	protected Good good = new Good();
	protected override async Task OnInitializedAsync()
	{
		var res = await Http.GetJsonAsync<List<Good>>("sample-data/goods.json");
		good = res.FirstOrDefault(i => i.Id == Id);
	}

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591