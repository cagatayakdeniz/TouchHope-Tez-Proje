using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.Models
{
    public class IhbarAddModel
    {
        public string FotografUrl { get; set; }
        public string Aciklama { get; set; }
        public string AcikAdres { get; set; }

        public int IlId { get; set; }

        public int AciliyetId { get; set; }

        public int TurId { get; set; }

        public IFormFile Fotograf { get; set; }
    }
}
