#pragma checksum "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2af22e1220cbb7b99864bd074c56f4e1369f3d3e"
// <auto-generated/>
#pragma warning disable 1591
namespace Shop.Admin.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\_Imports.razor"
using Shop.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\_Imports.razor"
using Shop.Admin.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-zh0xq5yj6q");
#nullable restore
#line 5 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\Shared\MainLayout.razor"
     if (IsAdminloggedIn)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-zh0xq5yj6q");
            __builder.OpenComponent<Shop.Admin.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\Shared\MainLayout.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "main");
            __builder.AddAttribute(9, "b-zh0xq5yj6q");
#nullable restore
#line 14 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\Shared\MainLayout.razor"
     if (IsAdminloggedIn)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "top-row px-4");
            __builder.AddAttribute(12, "b-zh0xq5yj6q");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "href", "#");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\Shared\MainLayout.razor"
                              Logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "b-zh0xq5yj6q");
            __builder.AddContent(17, "Logout");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\Shared\MainLayout.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "content px-4");
            __builder.AddAttribute(20, "b-zh0xq5yj6q");
#nullable restore
#line 23 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\Shared\MainLayout.razor"
__builder.AddContent(21, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\asingh727\source\repos\ShoppingCart\Shop.Admin\Shared\MainLayout.razor"
      
    public bool IsAdminloggedIn = false;
    public void Logout()
        {
        navManager.NavigateTo("/login");
        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
    }
}
#pragma warning restore 1591
