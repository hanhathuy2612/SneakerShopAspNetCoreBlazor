#pragma checksum "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\Pages\Header\HeaderBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d8de81524c54f58f8a7669004f37efd3d0d60d8"
// <auto-generated/>
#pragma warning disable 1591
namespace SneakerShopBlazor.Pages.Header
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
#line 1 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình web\BTL\SneakerShopBlazor\SneakerShopBlazor\Pages\Header\HeaderBar.razor"
using SneakerShopBlazor.Pages.Header.UserAccout;

#line default
#line hidden
#nullable disable
    public partial class HeaderBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "header");
            __builder.AddMarkupContent(2, "<div class=\"main-logo\"><img src>\r\n        <h1>Logo</h1></div>\r\n    ");
            __builder.OpenComponent<SneakerShopBlazor.Pages.Header.SearchBar>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<SneakerShopBlazor.Pages.Header.UserAccout.AccoutUser>(5);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591