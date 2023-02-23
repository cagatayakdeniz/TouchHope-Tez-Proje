using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.Models
{
    public class SahiplendirAddModel
    {
        public string Ad { get; set; }
        public string FotografUrl { get; set; }
        public string Yas { get; set; }
        public string TelefonNo { get; set; }
        public string Aciklama { get; set; }

        public int IlId { get; set; }

        public int TurId { get; set; }

        public IFormFile Fotograf { get; set; }
    }
}
