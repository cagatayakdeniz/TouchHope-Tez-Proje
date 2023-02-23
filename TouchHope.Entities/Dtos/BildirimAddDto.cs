using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchHope.Entities.Dtos
{
    public class BildirimAddDto
    {
        public string Mesaj { get; set; }
        public string Baslik { get; set; }
        public bool Durum { get; set; } = false;

        public int KullaniciId { get; set; }
    }
}
