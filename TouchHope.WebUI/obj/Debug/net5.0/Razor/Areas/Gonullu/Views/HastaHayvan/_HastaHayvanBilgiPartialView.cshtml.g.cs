#pragma checksum "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\HastaHayvan\_HastaHayvanBilgiPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efb668e0f80dd9959b04c88c7249310ff1d98681"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Gonullu_Views_HastaHayvan__HastaHayvanBilgiPartialView), @"mvc.1.0.view", @"/Areas/Gonullu/Views/HastaHayvan/_HastaHayvanBilgiPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efb668e0f80dd9959b04c88c7249310ff1d98681", @"/Areas/Gonullu/Views/HastaHayvan/_HastaHayvanBilgiPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e451376d7072963e54773d0d26b9a31c641fba6f", @"/Areas/Gonullu/Views/_ViewImports.cshtml")]
    public class Areas_Gonullu_Views_HastaHayvan__HastaHayvanBilgiPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HastaHayvanListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-left:70px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Tamamlandi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::TouchHope.WebUI.TagHelpers.GetirResimDetayGonullu __TouchHope_WebUI_TagHelpers_GetirResimDetayGonullu;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card author-box\">\r\n    <h4 class=\"text-center lead pt-2 font-27\" style=\"font:bold;color:red;font-size:28px\">Hasta Hayvan Bilgileri</h4>\r\n    <div class=\"card-body\">\r\n        <div class=\"author-box-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getirDetayResimBuyukGonullu", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efb668e0f80dd9959b04c88c7249310ff1d986814566", async() => {
            }
            );
            __TouchHope_WebUI_TagHelpers_GetirResimDetayGonullu = CreateTagHelper<global::TouchHope.WebUI.TagHelpers.GetirResimDetayGonullu>();
            __tagHelperExecutionContext.Add(__TouchHope_WebUI_TagHelpers_GetirResimDetayGonullu);
#nullable restore
#line 7 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\HastaHayvan\_HastaHayvanBilgiPartialView.cshtml"
__TouchHope_WebUI_TagHelpers_GetirResimDetayGonullu.Id = Model.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __TouchHope_WebUI_TagHelpers_GetirResimDetayGonullu.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("        <div class=\"card-body\">\r\n            <div class=\"card-text\" style=\"padding-top:20px;padding-left:115px\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efb668e0f80dd9959b04c88c7249310ff1d986816244", async() => {
                WriteLiteral("Tamamlandı Olarak İşaretle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\HastaHayvan\_HastaHayvanBilgiPartialView.cshtml"
                                                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <strong style=\"color:blue;font-size:18px\" class=\"font-16\">Aciliyet Durumu: </strong> <span class=\"badge badge-danger\" style=\"font-size:large;background-color:red\">");
#nullable restore
#line 14 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\HastaHayvan\_HastaHayvanBilgiPartialView.cshtml"
                                                                                                                                                                          Write(Model.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <br />\r\n            <br />\r\n            <strong style=\"color:blue;font-size:18px\" class=\"font-16\">Oluşturulma Tarihi: </strong> <small style=\"font-size:large;color:black\" class=\"font-16\">");
#nullable restore
#line 17 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\HastaHayvan\_HastaHayvanBilgiPartialView.cshtml"
                                                                                                                                                          Write(Model.OlusturulmaTarih.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n            <br />\r\n            <br />\r\n            <p class=\"card-text\">\r\n                <strong style=\"color:blue;font-size:18px\" class=\"font-16\">Açıklama: </strong> <strong class=\"font-16\" style=\"font-size:16px\">");
#nullable restore
#line 21 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\HastaHayvan\_HastaHayvanBilgiPartialView.cshtml"
                                                                                                                                        Write(Model.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </p>\r\n            <p class=\"card-text\">\r\n                <strong style=\"color:blue;font-size:18px\">Açık Adres: </strong> <strong class=\"font-16\" style=\"font-size:16px\">");
#nullable restore
#line 24 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\HastaHayvan\_HastaHayvanBilgiPartialView.cshtml"
                                                                                                                          Write(Model.AcikAdres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </p>\r\n            <p class=\"card-text\">\r\n                <strong style=\"color:blue;font-size:18px\" class=\"font-16\">İl: </strong> <strong class=\"font-16\" style=\"font-size:16px\">");
#nullable restore
#line 27 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\HastaHayvan\_HastaHayvanBilgiPartialView.cshtml"
                                                                                                                                  Write(Model.Il.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </p>\r\n            <p class=\"card-text\">\r\n                <strong style=\"color:blue;font-size:18px\" class=\"font-16\">Tür: </strong>\r\n");
#nullable restore
#line 31 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\HastaHayvan\_HastaHayvanBilgiPartialView.cshtml"
                 if (Model.Tur == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <strong class=\"font-16\" style=\"font-size:16px\">Tür Belirtilmemiş</strong>\r\n");
#nullable restore
#line 34 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\HastaHayvan\_HastaHayvanBilgiPartialView.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <strong class=\"font-16\" style=\"font-size:16px\">");
#nullable restore
#line 37 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\HastaHayvan\_HastaHayvanBilgiPartialView.cshtml"
                                                              Write(Model.Tur.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 38 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\HastaHayvan\_HastaHayvanBilgiPartialView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </p>\r\n            <p class=\"card-text\">\r\n                <strong style=\"color:blue;font-size:18px\">Sorumlu Gönüllü: </strong> <strong class=\"font-16\" style=\"font-size:16px\">");
#nullable restore
#line 41 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\HastaHayvan\_HastaHayvanBilgiPartialView.cshtml"
                                                                                                                               Write(Model.Kullanici.KullaniciAd);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 41 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\HastaHayvan\_HastaHayvanBilgiPartialView.cshtml"
                                                                                                                                                            Write(Model.Kullanici.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </p>\r\n        </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HastaHayvanListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591