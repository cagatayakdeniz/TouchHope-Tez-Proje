using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.Models
{
    public class KayipAddModel
    {
        //public int Id { get; set; }
        public string FotografUrl { get; set; }
        [Required(ErrorMessage ="Açıklama alanı boş geçilemez")]
        public string Aciklama { get; set; }
        [Required(ErrorMessage = "TelefonNo alanı boş geçilemez")]
        public string TelefonNo { get; set; }

        [Required(ErrorMessage = "İl alanı boş geçilemez")]
        public int IlId { get; set; }

        [Required(ErrorMessage = "Tür alanı boş geçilemez")]
        public int TurId { get; set; }

        public IFormFile Fotograf { get; set; }
    }
}
