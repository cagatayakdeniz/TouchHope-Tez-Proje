using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchHope.Entities.Dtos
{
    public class SahiplendirilecekHayvanAddDto
    {
        public string Ad { get; set; }
        public string FotografUrl { get; set; }
        public int Yas { get; set; }
        public string TelefonNo { get; set; }
        public string Aciklama { get; set; }

        public int IlId { get; set; }

        public int TurId { get; set; }

        public IFormFile Fotograf { get; set; }
    }
}
