#pragma checksum "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\Bildirim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d69495770c949bcfa69c16e9e5cc707989bb1ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Bildirim_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Bildirim/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d69495770c949bcfa69c16e9e5cc707989bb1ad", @"/Areas/Admin/Views/Bildirim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9873208247ad4470939f874bdafaa4f257cc8943", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Bildirim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BildirimListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\Bildirim\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<section class=\"section\">\r\n    <div class=\"section-body\">\r\n        <div class=\"row\">\r\n            <div id=\"tablo\" class=\"col-12\">\r\n");
#nullable restore
#line 38 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\Bildirim\Index.cshtml"
                 if (Model.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"text-center mt-2\">\r\n                        <h4 class=\"font-28\" style=\"color:red;padding-bottom:15px\">Okunmamış Bildirimler</h4>\r\n                    </div>\r\n");
#nullable restore
#line 43 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\Bildirim\Index.cshtml"
                     foreach (var bildirim in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""alert alert-light alert-has-icon"">
                                    <div class=""alert-icon""><i class=""far fa-lightbulb""></i></div>
                                    <div class=""alert-body font-16"">
                                        <div class=""alert-title"">Konu: ");
#nullable restore
#line 50 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\Bildirim\Index.cshtml"
                                                                  Write(bildirim.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        Mesaj: ");
#nullable restore
#line 51 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\Bildirim\Index.cshtml"
                                          Write(bildirim.Mesaj);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2428, "\"", 2455, 3);
            WriteAttributeValue("", 2438, "sil(", 2438, 4, true);
#nullable restore
#line 53 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\Bildirim\Index.cshtml"
WriteAttributeValue("", 2442, bildirim.Id, 2442, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2454, ")", 2454, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"color:white;font-size:14px\" class=\"btn btn-primary float-right\">Okundu Olarak İşaretle</a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 57 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\Bildirim\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\Bildirim\Index.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"lead\">\r\n                        <h2 class=\"text-center p-4\" style=\"color:red\">Okunmamış bildiriminiz bulunmamaktadır.</h2>\r\n                    </p>\r\n");
#nullable restore
#line 64 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\Bildirim\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
            WriteLiteral("    </div>\r\n</section>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d69495770c949bcfa69c16e9e5cc707989bb1ad7623", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"
<script>
    function sil(id) {
        if (id != 0 && id != """") {
            swal({
                title: ""Başarılı!"",
                text: ""Okundu Olarak İşaretlendi!"",
                icon: ""success""
            }).then(function () {
                $.ajax({
                    url: ""/Admin/Bildirim/OkuBildirim/"",
                    type: ""POST"",
                    data: { id: id },
                    success: function (result) {
                        location.reload();
                    }
                })
            });
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BildirimListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
