#pragma checksum "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3745ba9c90b7c5ce41f1e4c1e4bdc1d109241a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HastaHayvan_IyilesenHayvan), @"mvc.1.0.view", @"/Areas/Admin/Views/HastaHayvan/IyilesenHayvan.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3745ba9c90b7c5ce41f1e4c1e4bdc1d109241a0", @"/Areas/Admin/Views/HastaHayvan/IyilesenHayvan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9873208247ad4470939f874bdafaa4f257cc8943", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HastaHayvan_IyilesenHayvan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HastaHayvanListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetirRaporlar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-icon icon-left btn-info text-center font-15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::TouchHope.WebUI.TagHelpers.ResimHastaHayvanTagHelper __TouchHope_WebUI_TagHelpers_ResimHastaHayvanTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
  
    ViewData["Title"] = "IyilesenHayvan";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section"">
    <div class=""section-body"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""text-center mt-2"">
                        <h4 class=""font-27"" style=""color:red"">İyileşen Hayvan Listesi</h4>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <div id=""table-1_wrapper"" class=""container-fluid dt-bootstrap4 no-footer"">
                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <table class=""table table-striped dataTable no-footer"" id=""table-1"" role=""grid"" aria-describedby=""table-1_info"">
                                            <thead>
                                                <tr role=""row"">
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-control");
            WriteLiteral(@"s=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""
                              #
                            : activate to sort column ascending"" style=""width: 61.6562px;"">
                                                        #
                                                    </th>
                                                    <th class=""sorting_desc font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""Soyad: activate to sort column ascending"" aria-sort=""descending"">Açıklama</th>
                                                    <th class=""sorting_desc font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""Soyad: activate to sort column ascending"" aria-sort=""descending"">Resim</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""E-mail: activate to sort column ascending"">Açık Adres</th>
                                            ");
            WriteLiteral(@"        <th class=""sorting_desc font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""Soyad: activate to sort column ascending"" aria-sort=""descending"">Olusturulma Tarihi</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""Il: activate to sort column ascending"">İl</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""TelefonNo: activate to sort column ascending"">Aciliyet</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""KullaniciAd: activate to sort column ascending"">Tür</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""KullaniciAd: activate to sort column asce");
            WriteLiteral(@"nding"">Görevli Gönüllü</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""KullaniciAd: activate to sort column ascending"">Raporlar</th>
                                                </tr>
                                            </thead>
                                            <tbody class=""mb-3"">

");
#nullable restore
#line 42 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                 foreach (var item in Model)
                                                {
                                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr role=\"row\" class=\"odd\">\r\n                                                    <td class=\"font-14\">");
#nullable restore
#line 46 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"font-14\">");
#nullable restore
#line 47 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                                   Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"font-14\">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getirHastaHayvanResim", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3745ba9c90b7c5ce41f1e4c1e4bdc1d109241a09435", async() => {
            }
            );
            __TouchHope_WebUI_TagHelpers_ResimHastaHayvanTagHelper = CreateTagHelper<global::TouchHope.WebUI.TagHelpers.ResimHastaHayvanTagHelper>();
            __tagHelperExecutionContext.Add(__TouchHope_WebUI_TagHelpers_ResimHastaHayvanTagHelper);
#nullable restore
#line 49 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
__TouchHope_WebUI_TagHelpers_ResimHastaHayvanTagHelper.Id = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __TouchHope_WebUI_TagHelpers_ResimHastaHayvanTagHelper.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td class=\"font-14\">");
#nullable restore
#line 51 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                                   Write(item.AcikAdres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"font-14\">");
#nullable restore
#line 52 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                                   Write(item.OlusturulmaTarih.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"font-14\">");
#nullable restore
#line 53 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                                   Write(item.Il.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>\r\n");
#nullable restore
#line 55 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                         if (item.Aciliyet.Tanim == "Çok Hafif" || item.Aciliyet.Tanim == "Hafif")
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <span class=\"badge badge-warning font-15\">");
#nullable restore
#line 57 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                                                                 Write(item.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 58 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                        }
                                                        else if (item.Aciliyet.Tanim == "Normal")
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <span class=\"badge badge-warning font-15\">");
#nullable restore
#line 61 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                                                                 Write(item.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 62 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <span class=\"badge badge-danger font-15\">");
#nullable restore
#line 65 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                                                                Write(item.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 66 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </td>\r\n                                                    <td class=\"font-14\">\r\n");
#nullable restore
#line 69 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                         if (item.Tur == null)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <h6>Tür belirtilmemiş.</h6>\r\n");
#nullable restore
#line 72 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <h6>");
#nullable restore
#line 75 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                           Write(item.Tur.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 76 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </td>\r\n                                                    <td class=\"font-16\">");
#nullable restore
#line 78 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                                   Write(item.Kullanici.KullaniciAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3745ba9c90b7c5ce41f1e4c1e4bdc1d109241a017454", async() => {
                WriteLiteral("\r\n                                                            <i class=\"fas fa-info-circle\"></i>Raporlar\r\n                                                            <span class=\"badge badge-dark\" style=\"color:black;background-color:yellow\">");
#nullable restore
#line 82 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                                                                                                  Write(item.Raporlar.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 86 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\IyilesenHayvan.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HastaHayvanListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
