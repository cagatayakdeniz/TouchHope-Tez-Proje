using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.ApiServices.Abstract;

namespace TouchHope.WebUI.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("getirDetayResimBuyuk")]
    public class ResimDetayTagHelper : TagHelper
    {
        private IResimApiService _resimApiService;
        public ResimDetayTagHelper(IResimApiService resimApiService)
        {
            _resimApiService = resimApiService;
        }

        public int Id { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var resim = await _resimApiService.GetirHastaHayvanResimById(Id);

            string html = string.Empty;

            if (resim != null)
            {
                html = $"<img src='{resim}' width='380' height='300'>";
                output.Content.SetHtmlContent(html);
            }
        }
    }
}
