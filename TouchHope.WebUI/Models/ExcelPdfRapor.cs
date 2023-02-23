using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.Models
{
    public class ExcelPdfRapor
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Detay { get; set; }

        public int HastaHayvanId { get; set; }
        public string Aciliyet { get; set; }
        public string Il { get; set; }
        public string Tur { get; set; }
        public string GorevliKullaniciAd { get; set; }
    }
}
