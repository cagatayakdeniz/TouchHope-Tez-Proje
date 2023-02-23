using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.Models
{
    public class BildirimListModel
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Mesaj { get; set; }
        public bool Durum { get; set; }

        public int KullaniciId { get; set; }
    }
}
