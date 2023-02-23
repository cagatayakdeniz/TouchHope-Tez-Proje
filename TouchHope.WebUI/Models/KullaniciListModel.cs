using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.WebUI.Models
{
    public class KullaniciListModel
    {
        public int Id { get; set; }
        public string KullaniciAd { get; set; }
        public string Email { get; set; }
        public string TelefonNo { get; set; }
        public DateTime DogumTarih { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public int CinsiyetId { get; set; }
        public Cinsiyet Cinsiyet { get; set; }

        public int IlId { get; set; }
        public Il Il { get; set; }
    }
}
