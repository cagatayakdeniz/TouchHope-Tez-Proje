using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.Models
{
    public class RaporUpdateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Başlık alanı boş geçilemez.")]
        public string Baslik { get; set; }
        [Required(ErrorMessage = "Detay alanı boş geçilemez.")]
        public string Detay { get; set; }

        public int HastaHayvanId { get; set; }
    }
}
