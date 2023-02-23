using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.Models
{
    public class RaporListHastaHayvanModel
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Detay { get; set; }

        public int HastaHayvanId { get; set; }
    }
}
