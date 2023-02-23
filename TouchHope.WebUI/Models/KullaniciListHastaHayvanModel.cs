using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.Models
{
    public class KullaniciListHastaHayvanModel
    {
        public int Id { get; set; }
        public string KullaniciAd { get; set; }
        public string Email { get; set; }
        public string TelefonNo { get; set; }
        public DateTime DogumTarih { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
