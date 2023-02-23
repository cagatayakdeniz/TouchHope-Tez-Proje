using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.ApiServices.Abstract;

namespace TouchHope.WebUI.TagHelpers
{
    [HtmlTargetElement("getirIhbarResim")]
    public class ResimIhbarTagHelper : TagHelper
    {
        private IResimApiService _resimApiService;
        public ResimIhbarTagHelper(IResimApiService resimApiService)
        {
            _resimApiService = resimApiService;
        }

        public int Id { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var resim = await _resimApiService.GetirIhbarResimById(Id);

            string html = string.Empty;

            if (resim != null)
            {
                    html = $"<img src='{resim}' width='175' height='175'>";
                    output.Content.SetHtmlContent(html);
            }
        }
    }
}
