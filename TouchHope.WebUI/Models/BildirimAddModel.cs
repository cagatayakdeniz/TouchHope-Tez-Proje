using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.Models
{
    public class BildirimAddModel
    {
        [Required(ErrorMessage = "Konu Alanını Doldurunuz")]
        public string Baslik { get; set; }
        [Required(ErrorMessage = "Mesaj Alanını Doldurunuz")]
        public string Mesaj { get; set; }
        public bool Durum { get; set; } = false;

        [Range(0, int.MaxValue, ErrorMessage = "Lütfen Gönüllü Seçiniz")]
        public int KullaniciId { get; set; }
    }
}
