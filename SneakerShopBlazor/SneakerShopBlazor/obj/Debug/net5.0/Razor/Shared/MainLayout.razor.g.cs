#pragma checksum "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "658a77ba1cbdf9dd83818c64caf832248707e20c"
// <auto-generated/>
#pragma warning disable 1591
namespace SneakerShopBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\_Imports.razor"
using SneakerShopBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\_Imports.razor"
using SneakerShopBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\Shared\MainLayout.razor"
using SneakerShopBlazor.Pages.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\Shared\MainLayout.razor"
using SneakerShopBlazor.Pages.Header;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "b-002mdqg20j");
            __builder.OpenComponent<SneakerShopBlazor.Pages.Header.HeaderBar>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<SneakerShopBlazor.Pages.Home.MenuBar>(5);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.AddContent(7, 
#nullable restore
#line 8 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\Shared\MainLayout.razor"
 Body

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
