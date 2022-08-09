// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 4 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\Createorupdate.razor"
using Codelab.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\Createorupdate.razor"
using Codelab.BLL.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\Createorupdate.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/course/createorupdate")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/course/edit/{Id:int}")]
    public partial class Createorupdate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Pages\CoursePages\Createorupdate.razor"
       

    [CascadingParameter]
    public Task<AuthenticationState> State { get; set; }
    [Parameter]
    public int? Id { get; set; }

    private string Title { get; set; }
    private CourseDto courseModel { get; set; } = new CourseDto();
    protected override async Task OnInitializedAsync()


    {
        var authState = await State;
        if (!authState.User.Identity.IsAuthenticated)
        {
            var url = new Uri(_navigationManger.Uri);
            _navigationManger.NavigateTo($"/Identity/account/login?returnUrl={url.LocalPath}");
        }


        if (Id != null)
        {
            Title = "Update";
            var data = await _courseRepository.GetCourse((int)Id);
            courseModel = data.Data;
        }
        else
        {
            //create
        }
    }
    private async Task CourseCreateOrUpdate()
    {
        try
        {
            if (Id != null)
            {
                var updateData = await _courseRepository.UpdateCourse((int)Id, courseModel);
                if (updateData.IsSuccess)
                    await _jsRuntime.ToastrSuccess(updateData.Message);
                else
                    await _jsRuntime.ToastrError(updateData.Message);
            }
            else
            {
                var created = await _courseRepository.CreateCourse(courseModel);
                if (created.IsSuccess)
                    await _jsRuntime.ToastrSuccess(created.Message);
                else
                    await _jsRuntime.ToastrError(created.Message);
            }
        }
        catch (Exception ex)
        {
            await _jsRuntime.ToastrError(ex.Message.ToString());
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICourseRepository _courseRepository { get; set; }
    }
}
#pragma warning restore 1591
