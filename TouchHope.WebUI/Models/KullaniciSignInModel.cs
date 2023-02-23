using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.Models
{
    public class KullaniciSignInModel
    {
        [Required(ErrorMessage ="Kullanıcı Adı boş geçilemez.")]
        public string KullaniciAd { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez.")]
        public string Sifre { get; set; }
    }
}
