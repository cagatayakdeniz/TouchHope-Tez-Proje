using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.Models
{
    public class KullaniciUpdateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Kullanıcı Adı Boş Geçilemez")]
        public string KullaniciAd { get; set; }
        //public string Sifre { get; set; }
        [Required(ErrorMessage = "Email Boş Geçilemez")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon No Boş Geçilemez")]
        public string TelefonNo { get; set; }
        //public DateTime DogumTarih { get; set; }
        [Required(ErrorMessage = "Ad Boş Geçilemez")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Soyad Boş Geçilemez")]
        public string Soyad { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Lütfen Cinsiyet Durumunu Seçiniz")]
        public int CinsiyetId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Lütfen İl Seçiniz")]
        public int IlId { get; set; }
    }
}
