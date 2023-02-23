using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchHope.Entities.Dtos
{
    public class IhbarAddDto
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
