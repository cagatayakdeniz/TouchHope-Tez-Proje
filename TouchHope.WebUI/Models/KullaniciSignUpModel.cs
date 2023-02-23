using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.Models
{
    public class KullaniciSignUpModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı boş geçilemez")]
        public string KullaniciAd { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez")]
        public string Sifre { get; set; }
        [Required(ErrorMessage = "Email boş geçilemez")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon Numarası boş geçilemez")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Telefon Formatı Uyuşmadı, bitişik girin. Örnek: (545xxxxxxx)")]
        public string TelefonNo { get; set; }
        [Required(ErrorMessage = "Doğum tarihi gereklidir.")]
        public DateTime DogumTarih { get; set; }
        [Required(ErrorMessage = "Ad boş geçilemez")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Soyad boş geçilemez")]
        public string Soyad { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Lütfen Cinsiyet Durumunu Seçiniz")]
        public int CinsiyetId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Lütfen İl Seçiniz")]
        public int IlId { get; set; }
    }
}
