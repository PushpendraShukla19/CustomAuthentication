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
#line 1 "C:\Users\pushp\OneDrive\Desktop\BookStores-master\BlazorServerApp\BlazorServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pushp\OneDrive\Desktop\BookStores-master\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pushp\OneDrive\Desktop\BookStores-master\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pushp\OneDrive\Desktop\BookStores-master\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pushp\OneDrive\Desktop\BookStores-master\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pushp\OneDrive\Desktop\BookStores-master\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pushp\OneDrive\Desktop\BookStores-master\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pushp\OneDrive\Desktop\BookStores-master\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pushp\OneDrive\Desktop\BookStores-master\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\pushp\OneDrive\Desktop\BookStores-master\BlazorServerApp\BlazorServerApp\_Imports.razor"
using CuriousDriveRazorLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\pushp\OneDrive\Desktop\BookStores-master\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pushp\OneDrive\Desktop\BookStores-master\BlazorServerApp\BlazorServerApp\Pages\LoginPages\SignUp.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pushp\OneDrive\Desktop\BookStores-master\BlazorServerApp\BlazorServerApp\Pages\LoginPages\SignUp.razor"
using BlazorServerApp.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CenteredCardLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/signup")]
    public partial class SignUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\pushp\OneDrive\Desktop\BookStores-master\BlazorServerApp\BlazorServerApp\Pages\LoginPages\SignUp.razor"
       

    private User user;
    public string LoginMesssage { get; set; }

    protected override Task OnInitializedAsync()
    {
        user = new User();
        return base.OnInitializedAsync();
    }

    private async Task<bool> RegisterUser()
    {
        //assume that user is valid
        user.Source = "APPC";
        var returnedUser = await userService.RegisterUserAsync(user);

        if(returnedUser.EmailAddress != null)
        {   
            ((CustomAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsAuthenticated(returnedUser);
            NavigationManager.NavigateTo("/");
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
