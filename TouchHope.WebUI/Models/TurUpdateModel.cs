using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.Models
{
    public class TurUpdateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı gereklidir.")]
        public string Ad { get; set; }
    }
}
