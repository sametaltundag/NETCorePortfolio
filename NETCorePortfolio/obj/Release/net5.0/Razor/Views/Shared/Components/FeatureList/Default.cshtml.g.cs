#pragma checksum "D:\NETCorePortfolio\NETCorePortfolio\Views\Shared\Components\FeatureList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5389b002ac819ed70fbda9ef25d51209606c6b4d1bc15338301e7ac86284c5ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FeatureList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FeatureList/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\NETCorePortfolio\NETCorePortfolio\Views\_ViewImports.cshtml"
using NETCorePortfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NETCorePortfolio\NETCorePortfolio\Views\_ViewImports.cshtml"
using NETCorePortfolio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\NETCorePortfolio\NETCorePortfolio\Views\Shared\Components\FeatureList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5389b002ac819ed70fbda9ef25d51209606c6b4d1bc15338301e7ac86284c5ce", @"/Views/Shared/Components/FeatureList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d1eff688a01f71a47eda37782a8476c6020b9c570c04b73a5ee07c4294ed3396", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_FeatureList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Feature>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/images/illustrations/hello3.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("hello"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<header>\r\n    <div class=\"cover bg-light\">\r\n        <div class=\"container px-3\">\r\n            <div class=\"row text-center\">\r\n                <div class=\"col-lg-6 p-2\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5389b002ac819ed70fbda9ef25d51209606c6b4d1bc15338301e7ac86284c5ce4819", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                <div class=\"col-lg-6\">\r\n");
#nullable restore
#line 10 "D:\NETCorePortfolio\NETCorePortfolio\Views\Shared\Components\FeatureList\Default.cshtml"
                     foreach(var i in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"mt-5\">\r\n                            <p class=\"lead text-uppercase mb-1\">");
#nullable restore
#line 13 "D:\NETCorePortfolio\NETCorePortfolio\Views\Shared\Components\FeatureList\Default.cshtml"
                                                           Write(i.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <h1 class=\"intro-title marker\" data-aos=\"fade-left\" data-aos-delay=\"50\">");
#nullable restore
#line 14 "D:\NETCorePortfolio\NETCorePortfolio\Views\Shared\Components\FeatureList\Default.cshtml"
                                                                                               Write(i.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <p class=\"lead fw-normal mt-3\" data-aos=\"fade-up\" data-aos-delay=\"100\">");
#nullable restore
#line 15 "D:\NETCorePortfolio\NETCorePortfolio\Views\Shared\Components\FeatureList\Default.cshtml"
                                                                                              Write(i.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <div class=""social-nav"" data-aos=""fade-up"" data-aos-delay=""200"">
                                <nav role=""navigation"">
                                    <ul class=""nav justify-content-center"">
                                        <li class=""nav-item""><a class=""nav-link"" target=""_blank"" href=""https://www.instagram.com/sametxaltundag"" title=""Instagram""><i class=""fab fa-instagram""></i><span class=""menu-title sr-only"">Instagram</span></a></li>
                                        <li class=""nav-item""><a class=""nav-link"" target=""_blank"" href=""https://www.linkedin.com/in/sametaltundag"" title=""LinkedIn""><i class=""fab fa-linkedin""></i><span class=""menu-title sr-only"">LinkedIn</span></a></li>
                                        <li class=""nav-item""><a class=""nav-link"" target=""_blank"" href=""https://www.github.com/sametaltundag"" title=""GitHub""><i class=""fab fa-github""></i><span class=""menu-title sr-only"">LinkedIn</span></a></li>
                                    </");
            WriteLiteral(@"ul>
                                </nav>
                            </div>
                            <div class=""mt-3"" data-aos=""fade-up"" data-aos-delay=""200""><a class=""btn btn-primary shadow-sm mt-1 hover-effect"" href=""#contact"">Bana Ulaş<i class=""fas fa-arrow-right""></i></a></div>
                        </div>
");
#nullable restore
#line 27 "D:\NETCorePortfolio\NETCorePortfolio\Views\Shared\Components\FeatureList\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"wave-bg\"></div>\r\n</header>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Feature>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
