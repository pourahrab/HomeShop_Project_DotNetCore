#pragma checksum "G:\PROJECT\.net core\HomeShop_Project_Folder\Code\HomeShop\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e70ea318083a479d8b4aa41b4341fd9264f4b1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Slide.Pages_Shared_Components_Slide_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Slide/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Slide
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "G:\PROJECT\.net core\HomeShop_Project_Folder\Code\HomeShop\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e70ea318083a479d8b4aa41b4341fd9264f4b1a", @"/Pages/Shared/Components/Slide/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Slide_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_HomeShopQuery.Contracts.Slide.SlideQueryModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""hero-slider-area section-space"">
    <div class=""container wide"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <!--=======  hero slider wrapper  =======-->

                <div class=""hero-slider-wrapper"">
                    <div class=""ht-slick-slider"" data-slick-setting='{
                        ""slidesToShow"": 1,
                        ""slidesToScroll"": 1,
                        ""arrows"": true,5
                        ""dots"": true,
                        ""autoplay"": true,
                        ""autoplaySpeed"": 5000,
                        ""speed"": 1000,
                        ""fade"": true,
                        ""infinite"": true,
                        ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                        ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                    }' data-slick-responsive='[
                        {""breakpoint"":1501, ""setting");
            WriteLiteral(@"s"": {""slidesToShow"": 1} },
                        {""breakpoint"":1199, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":991, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":767, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":575, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                    ]'>

                        <!--=======  single slider item  =======-->
");
#nullable restore
#line 32 "G:\PROJECT\.net core\HomeShop_Project_Folder\Code\HomeShop\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-slider-item\">\r\n                                <div class=\"hero-slider-item-wrapper \">\r\n                                    <div class=\"container\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 2013, "\"", 2032, 1);
#nullable restore
#line 37 "G:\PROJECT\.net core\HomeShop_Project_Folder\Code\HomeShop\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 2019, item.Picture, 2019, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2033, "\"", 2056, 2);
#nullable restore
#line 37 "G:\PROJECT\.net core\HomeShop_Project_Folder\Code\HomeShop\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 2039, item.PictureAlt, 2039, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2055, "", 2056, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2057, "\"", 2083, 1);
#nullable restore
#line 37 "G:\PROJECT\.net core\HomeShop_Project_Folder\Code\HomeShop\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 2065, item.PictureTitle, 2065, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <div class=""container"">
                                            <div class=""row"">
                                                <div class=""col-lg-12"">
                                                    <div class=""hero-slider-content hero-slider-content--left-space"">
                                                        <p class=""slider-title slider-title--big-light"">");
#nullable restore
#line 42 "G:\PROJECT\.net core\HomeShop_Project_Folder\Code\HomeShop\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                                                                   Write(item.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        <p class=\"slider-title slider-title--big-bold\">");
#nullable restore
#line 43 "G:\PROJECT\.net core\HomeShop_Project_Folder\Code\HomeShop\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        <p class=\"slider-title slider-title--small\">\r\n                                                            ");
#nullable restore
#line 45 "G:\PROJECT\.net core\HomeShop_Project_Folder\Code\HomeShop\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                       Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </p>\r\n                                                        <a class=\"hero-slider-button\"");
            BeginWriteAttribute("href", " href=\"", 2973, "\"", 2990, 1);
#nullable restore
#line 47 "G:\PROJECT\.net core\HomeShop_Project_Folder\Code\HomeShop\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 2980, item.Link, 2980, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            ");
#nullable restore
#line 48 "G:\PROJECT\.net core\HomeShop_Project_Folder\Code\HomeShop\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                       Write(item.BtnText);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""ion-ios-plus-empty""></i>
                                                        </a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 57 "G:\PROJECT\.net core\HomeShop_Project_Folder\Code\HomeShop\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                       

                        <!--=======  End of single slider item  =======-->
          

                    </div>
                </div>

                <!--=======  End of hero slider wrapper  =======-->
            </div>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_HomeShopQuery.Contracts.Slide.SlideQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591