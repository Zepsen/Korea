#pragma checksum "C:\Projects\Korea\korea\korea\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73e5c56c0e5da2bb5ea350facdcc8c38ce8ad71e"
// <auto-generated/>
#pragma warning disable 1591
namespace Korea.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Projects\Korea\korea\korea\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Projects\Korea\korea\korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Projects\Korea\korea\korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Projects\Korea\korea\korea\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Projects\Korea\korea\korea\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Projects\Korea\korea\korea\_Imports.razor"
using Korea;

#line default
#line hidden
#line 7 "C:\Projects\Korea\korea\korea\_Imports.razor"
using Korea.Shared;

#line default
#line hidden
#line 1 "C:\Projects\Korea\korea\korea\Shared\MainLayout.razor"
using Korea.Shared.Models;

#line default
#line hidden
    public class MainLayout : LayoutComponentBase, IBasePage
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Korea.Shared.MainLayout.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#line 10 "C:\Projects\Korea\korea\korea\Shared\MainLayout.razor"
                       this

#line default
#line hidden
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n\t");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "main");
                __builder2.AddAttribute(6, "style", "margin-top: 50px");
                __builder2.AddMarkupContent(7, "\r\n\r\n");
#line 13 "C:\Projects\Korea\korea\korea\Shared\MainLayout.razor"
         if(HasHeader)
		{

#line default
#line hidden
                __builder2.AddMarkupContent(8, "\t\t\t");
                __builder2.AddMarkupContent(9, "<nav class=\"navbar fixed-top navbar-dark bg-info\">\r\n\t\t\t\t<a class=\"navbar-brand\" href=\"/\">\r\n\t\t\t\t\t\r\n\t\t\t\t\tKorea\r\n\t\t\t\t</a>\r\n\t\t\t</nav>\r\n");
#line 21 "C:\Projects\Korea\korea\korea\Shared\MainLayout.razor"
		}

#line default
#line hidden
                __builder2.AddMarkupContent(10, "\r\n\t\t");
                __builder2.OpenElement(11, "nav");
                __builder2.AddAttribute(12, "aria-label", "breadcrumb");
                __builder2.AddMarkupContent(13, "\r\n\t\t\t");
                __builder2.OpenElement(14, "ol");
                __builder2.AddAttribute(15, "class", "breadcrumb");
                __builder2.AddMarkupContent(16, "\r\n");
#line 25 "C:\Projects\Korea\korea\korea\Shared\MainLayout.razor"
                 foreach (var bread in breads)
				{

#line default
#line hidden
                __builder2.AddMarkupContent(17, "\t\t\t\t\t");
                __builder2.OpenElement(18, "li");
                __builder2.AddAttribute(19, "class", "breadcrumb-item" + " " + (
#line 27 "C:\Projects\Korea\korea\korea\Shared\MainLayout.razor"
                                                 bread.Active ? "active" : null

#line default
#line hidden
                ));
                __builder2.AddMarkupContent(20, "\r\n");
#line 28 "C:\Projects\Korea\korea\korea\Shared\MainLayout.razor"
                         if(!bread.Active)
						{

#line default
#line hidden
                __builder2.AddMarkupContent(21, "\t\t\t\t\t\t\t");
                __builder2.OpenElement(22, "a");
                __builder2.AddAttribute(23, "href", 
#line 30 "C:\Projects\Korea\korea\korea\Shared\MainLayout.razor"
                                      bread.Route

#line default
#line hidden
                );
                __builder2.AddContent(24, 
#line 30 "C:\Projects\Korea\korea\korea\Shared\MainLayout.razor"
                                                    bread.Name

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n");
#line 31 "C:\Projects\Korea\korea\korea\Shared\MainLayout.razor"
						}
						else 
							

#line default
#line hidden
                __builder2.AddContent(26, 
#line 33 "C:\Projects\Korea\korea\korea\Shared\MainLayout.razor"
                             bread.Name

#line default
#line hidden
                );
                __builder2.AddMarkupContent(27, "\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n");
#line 35 "C:\Projects\Korea\korea\korea\Shared\MainLayout.razor"
				}				 

#line default
#line hidden
                __builder2.AddMarkupContent(29, "\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n\t\t\t\r\n\t\t");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "content px-4");
                __builder2.AddMarkupContent(34, "\r\n\t\t\t");
                __builder2.AddContent(35, 
#line 40 "C:\Projects\Korea\korea\korea\Shared\MainLayout.razor"
             Body

#line default
#line hidden
                );
                __builder2.AddMarkupContent(36, "\r\n\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n");
            }
            );
        }
        #pragma warning restore 1998
#line 46 "C:\Projects\Korea\korea\korea\Shared\MainLayout.razor"
 
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
namespace __Blazor.Korea.Shared.MainLayout
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
