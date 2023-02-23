using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.WebUI.Models
{
    public class RaporListModel
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Detay { get; set; }

        public int HastaHayvanId { get; set; }
        public HastaHayvan HastaHayvan { get; set; }
    }
}
