#pragma checksum "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\AnaSayfa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26f07f9e45140c6e258a55d01e961b891123417e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Gonullu_Views_AnaSayfa_Index), @"mvc.1.0.view", @"/Areas/Gonullu/Views/AnaSayfa/Index.cshtml")]
namespace AspNetCore
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
#line 4 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\_ViewImports.cshtml"
using TouchHope.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26f07f9e45140c6e258a55d01e961b891123417e", @"/Areas/Gonullu/Views/AnaSayfa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e451376d7072963e54773d0d26b9a31c641fba6f", @"/Areas/Gonullu/Views/_ViewImports.cshtml")]
    public class Areas_Gonullu_Views_AnaSayfa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/site/assets/img/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("140"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("145"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\AnaSayfa\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Gonullu/Views/Shared/_GonulluPanelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section"" style=""padding-top:50px"">
    <div class=""row "">
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"" style=""padding-left: 300px; padding-right: 100px; padding-top:40px"">
            <div class=""card"" style=""box-shadow:5px 5px gray"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                            <a href=""Gonullu/HastaHayvan"">
                                <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                    <div class=""card-content"">
                                        <h4 class=""font-20"">Aktif Hayvan Sayısı</h4>
                                        <br />
                                        <br />
                                        <h1 class=""mb-3 font-26 text-center"" style=""color:red"">");
#nullable restore
#line 20 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\AnaSayfa\Index.cshtml"
                                                                                          Write(ViewBag.AktifHastaHayvanSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                    </div>

                                </div>
                                <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                    <div class=""banner-img"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26f07f9e45140c6e258a55d01e961b891123417e6395", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"" style=""padding-right: 400px;padding-top:40px"">
            <div class=""card"" style=""box-shadow:5px 5px gray"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                            <a href=""Gonullu/HastaHayvan/IyilestirilenHayvanlar"">
                                <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                    <div class=""card-content"">
                                        <h4 class=""font-20"">İyileştirdiğim Hayvan Sayısı</h4>
                                        <br />
                                        <h1 class=""m");
            WriteLiteral("b-3 font-26 text-center\" style=\"color:red\">");
#nullable restore
#line 45 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\AnaSayfa\Index.cshtml"
                                                                                          Write(ViewBag.IyilestirdigimHastaHayvanSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                    </div>
                                </div>
                                <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                    <div class=""banner-img"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26f07f9e45140c6e258a55d01e961b891123417e9448", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"" style=""padding-left:300px;padding-right:100px;padding-top:40px"">
            <div class=""card"" style=""box-shadow:5px 5px gray"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                            <a href=""Gonullu/Bildirim"">
                                <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                    <div class=""card-content"">
                                        <h4 class=""font-20"">Bildirim Sayısı</h4>
                                        <br />
                                        <br />
                         ");
            WriteLiteral("               <h1 class=\"mb-3 font-26 text-center\" style=\"color:red\">");
#nullable restore
#line 70 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\AnaSayfa\Index.cshtml"
                                                                                          Write(ViewBag.BildirimSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                    </div>
                                </div>
                                <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                    <div class=""banner-img"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26f07f9e45140c6e258a55d01e961b891123417e12511", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"" style=""padding-right:400px;padding-top:40px"">
            <div class=""card"" style=""box-shadow:5px 5px gray"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                                <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                    <div class=""card-content"">
                                        <h4 class=""font-20"">Yazdığım Rapor Sayısı</h4>
                                        <br />
                                        <br />
                                        <h1 class=""mb-3 font-26 text-center"" style=""color:red"">");
#nullable restore
#line 94 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\AnaSayfa\Index.cshtml"
                                                                                          Write(ViewBag.YazdigimToplamRaporSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                    </div>
                                </div>
                                <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                    <div class=""banner-img"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26f07f9e45140c6e258a55d01e961b891123417e15483", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591