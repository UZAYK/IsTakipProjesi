using IsTakip.Business.Interfaces;
using IsTakip.Entities.Concrete;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsTakip.Web.TagHalpers
{
    [HtmlTargetElement("getirGorevAppUserId")]
    public class GorevAppUserIdTagHelper : TagHelper
    {
        private readonly IGorevService _gorevService;
        public GorevAppUserIdTagHelper(IGorevService gorevService)
        {
            _gorevService = gorevService;
        }
        public int AppUserId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            List<Gorev> gorevler = _gorevService.GetirAppUserId(AppUserId);
            int tamamlananGorevSayisi = gorevler.Where(I => I.Durum).Count();
            int ustundeCalistigiGorevSayisi = gorevler.Where(I => !I.Durum).Count();
            string htmlString = 
                $"Tamamladığı görev sayısı :{tamamlananGorevSayisi}" +
                $"<br>Üzerinde çalıştığı görev sayısı :{ustundeCalistigiGorevSayisi}";

            output.Content.SetHtmlContent(htmlString);
        }
    }
}
