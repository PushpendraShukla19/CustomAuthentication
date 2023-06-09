// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServerApp.Pages.LoginPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\_Imports.razor"
using CuriousDriveRazorLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\Pages\LoginPages\Login.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\Pages\LoginPages\Login.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\Pages\LoginPages\Login.razor"
using BlazorServerApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\Pages\LoginPages\Login.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CenteredCardLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\pushp\Source\Repos\CustomAuthentication\BlazorServerApp\BlazorServerApp\Pages\LoginPages\Login.razor"
       

    private User user;
    public string LoginMesssage { get; set; }
    ClaimsPrincipal claimsPrincipal;

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    protected async override Task OnInitializedAsync()
    {
        user = new User();

        claimsPrincipal = (await authenticationStateTask).User;

        if (claimsPrincipal.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo("/index");
        }
        {
            user.EmailAddress = "philip.cramer@gmail.com";
            user.Password = "philip.cramer";
        }

    }

    private async Task<bool> ValidateUser()
    {
        //assume that user is valid
        //call an API

        var returnedUser = await userService.LoginAsync(user);

        if (returnedUser.EmailAddress != null)
        {
            await ((CustomAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsAuthenticated(returnedUser);
            NavigationManager.NavigateTo("/index");
        }
        else
        {
            LoginMesssage = "Invalid username or password";
        }

        return await Task.FromResult(true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRunTime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
