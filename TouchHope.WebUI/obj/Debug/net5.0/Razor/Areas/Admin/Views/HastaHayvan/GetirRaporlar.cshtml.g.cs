#pragma checksum "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2cfa8983b6fe51c6fe036d049d95e9458d6d6f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HastaHayvan_GetirRaporlar), @"mvc.1.0.view", @"/Areas/Admin/Views/HastaHayvan/GetirRaporlar.cshtml")]
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
#line 4 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using TouchHope.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2cfa8983b6fe51c6fe036d049d95e9458d6d6f2", @"/Areas/Admin/Views/HastaHayvan/GetirRaporlar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9873208247ad4470939f874bdafaa4f257cc8943", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HastaHayvan_GetirRaporlar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HayvanRaporDetayModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HayvanGonullu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetirExcel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-icon btn-lg icon-left btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetirPdf", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-icon btn-lg icon-left btn-primary ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::TouchHope.WebUI.TagHelpers.ResimDetayTagHelper __TouchHope_WebUI_TagHelpers_ResimDetayTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
  
    ViewData["Title"] = "GetirRaporlar";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section"">
    <div class=""section-body"">
        <div class=""row mt-sm-4"">
            <div class=""col-12 col-md-12 col-lg-4"">
                <div class=""card author-box"">
                    <h4 class=""text-center lead pt-2 font-27"" style=""font:bold;color:red"">Hasta Hayvan Bilgileri</h4>
                    <div class=""card-body"">
                        <div class=""author-box-center"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getirDetayResimBuyuk", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2cfa8983b6fe51c6fe036d049d95e9458d6d6f25676", async() => {
            }
            );
            __TouchHope_WebUI_TagHelpers_ResimDetayTagHelper = CreateTagHelper<global::TouchHope.WebUI.TagHelpers.ResimDetayTagHelper>();
            __tagHelperExecutionContext.Add(__TouchHope_WebUI_TagHelpers_ResimDetayTagHelper);
#nullable restore
#line 16 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
__TouchHope_WebUI_TagHelpers_ResimDetayTagHelper.Id = Model.HastaHayvan.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __TouchHope_WebUI_TagHelpers_ResimDetayTagHelper.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                            <div class=\"card-body\">\r\n                                <strong style=\"color:blue\" class=\"font-16\">Aciliyet Durumu: </strong> <span class=\"badge badge-danger\" style=\"font-size:large\">");
#nullable restore
#line 19 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                                                                                                                                          Write(Model.HastaHayvan.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <br />\r\n                                <br />\r\n                                <strong style=\"color:blue\" class=\"font-16\">Oluşturulma Tarihi: </strong> <small style=\"font-size:large;color:black\" class=\"font-16\">");
#nullable restore
#line 22 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                                                                                                                                               Write(Model.HastaHayvan.OlusturulmaTarih.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                                <br />
                                <br />
                                <p class=""card-text"">
                                    <strong style=""color:blue"" class=""font-16"">Açıklama: </strong> <strong class=""font-16"">");
#nullable restore
#line 26 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                                                                                                      Write(Model.HastaHayvan.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                </p>\r\n                                <p class=\"card-text\">\r\n                                    <strong style=\"color:blue\" class=\"font-16\">Açık Adres: </strong> <strong class=\"font-16\">");
#nullable restore
#line 29 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                                                                                                        Write(Model.HastaHayvan.AcikAdres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                </p>\r\n                                <p class=\"card-text\">\r\n                                    <strong style=\"color:blue\" class=\"font-16\">İl: </strong> <strong class=\"font-16\">");
#nullable restore
#line 32 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                                                                                                Write(Model.HastaHayvan.Il.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                </p>\r\n                                <p class=\"card-text\">\r\n                                    <strong style=\"color:blue\" class=\"font-16\">Tür: </strong>\r\n");
#nullable restore
#line 36 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                     if (Model.HastaHayvan.Tur == null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <strong class=\"font-16\">Tür Belirtilmemiş</strong>\r\n");
#nullable restore
#line 39 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <strong class=\"font-16\">");
#nullable restore
#line 42 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                                           Write(Model.HastaHayvan.Tur.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 43 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </p>\r\n                                <p class=\"card-text\">\r\n                                    <strong style=\"color:blue\" class=\"font-16\">Sorumlu Gönüllü: </strong> <strong class=\"font-16\">");
#nullable restore
#line 46 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                                                                                                             Write(Model.HastaHayvan.Kullanici.KullaniciAd);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 46 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                                                                                                                                                      Write(Model.HastaHayvan.Kullanici.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-12 col-lg-8"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2cfa8983b6fe51c6fe036d049d95e9458d6d6f213376", async() => {
                WriteLiteral("<i class=\"fas fa-file-excel font-25\"></i>EXCEL İndir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                                                            WriteLiteral(Model.HastaHayvan.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2cfa8983b6fe51c6fe036d049d95e9458d6d6f215966", async() => {
                WriteLiteral("<i class=\"fas fa-file-pdf font-25\"></i>PDF İndir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                                                          WriteLiteral(Model.HastaHayvan.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""card mt-3"">
                    <div class=""card-header"">
                        <h4 class=""font-20"" style=""color:green"">Hayvan Hakkında Yazılan Raporlar</h4>
                    </div>
                    <div class=""card-body"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th scope=""col"">#</th>
                                    <th scope=""col"" class=""font-18"" style=""color:blue"">BASLİK</th>
                                    <th scope=""col"" class=""font-18"" style=""color:blue"">DETAY</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 70 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                 foreach (var item in Model.Raporlar)
                                {
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr role=\"row\" class=\"odd\">\r\n                                        <td class=\"font-15\">");
#nullable restore
#line 74 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"font-15\">");
#nullable restore
#line 75 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                                       Write(item.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"font-15\">");
#nullable restore
#line 76 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                                       Write(item.Detay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 78 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\GetirRaporlar.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HayvanRaporDetayModel> Html { get; private set; }
    }
}
#pragma warning restore 1591