#pragma checksum "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84998d5a048791865bd3139cbf7cf84d2f532f1d"
// <auto-generated/>
#pragma warning disable 1591
namespace CodelabProjem.Pages.CoursePages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using CodelabProjem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using CodelabProjem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"
using Codelab.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"
using Codelab.BLL.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/courselist")]
    public partial class CourseList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-3");
            __builder.AddMarkupContent(2, "<h5>Kurs Listesi</h5>\r\n    <br>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(3);
            __builder.AddAttribute(4, "href", "course/createorupdate");
            __builder.AddAttribute(5, "class", "btn btn-success");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(7, "Kurs Ekle");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row mt-4");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-12");
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table");
            __builder.AddMarkupContent(15, @"<thead class=""thead-dark""><tr><th scope=""col"">??sim</th>
                    <th scope=""col"">Fiyat</th>
                    <th scope=""col"">A????klamas??</th>
                    <th scope=""col"">Ba??l??k</th>
                    <th scope=""col"">Aktif Mi</th></tr></thead>
            ");
            __builder.OpenElement(16, "tbody");
#nullable restore
#line 31 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"
                 if (CourseModelList.Any())
                {
                    foreach (var course in CourseModelList)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "tr");
            __builder.OpenElement(18, "th");
            __builder.AddContent(19, 
#nullable restore
#line 36 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"
                                 course.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 37 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"
                                 course.CoursePrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                            ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 38 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"
                                 course.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 39 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"
                                 course.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"
                             if (course.IsActive)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<td>\r\n                                    Aktif\r\n                                </td>");
#nullable restore
#line 45 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<td>\r\n                                    Pasif\r\n                                </td>");
#nullable restore
#line 51 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(32);
            __builder.AddAttribute(33, "href", 
#nullable restore
#line 53 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"
                                                 $"/course/edit/{course.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "class", "btn btn-primary");
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, " G??ncelle");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "tr");
            __builder.OpenElement(38, "td");
            __builder.AddAttribute(39, "colspan", "6");
            __builder.AddContent(40, 
#nullable restore
#line 62 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"
                                         ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"

                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\CourseList.razor"
       

    private IEnumerable<CourseDto> CourseModelList { get; set; } = new List<CourseDto>();
    private IEnumerable<CourseDto> courseList = Enumerable.Empty<CourseDto>();

    public string ErrorMessage { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var data = await _courseRepository.GetAllCourse();
        if (!data.IsSuccess)
            ErrorMessage = data.Message;
        else
            CourseModelList = data.Data;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICourseRepository _courseRepository { get; set; }
    }
}
#pragma warning restore 1591
