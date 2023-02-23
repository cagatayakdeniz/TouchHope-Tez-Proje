using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.WebUI.Models
{
    public class IhbarListModel
    {
        public int Id { get; set; }
        public string FotografUrl { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturulmaTarih { get; set; }
        public string AcikAdres { get; set; }

        public int IlId { get; set; }
        public Il Il { get; set; }

        public int AciliyetId { get; set; }
        public Aciliyet Aciliyet { get; set; }

        public int TurId { get; set; }
        public Tur Tur { get; set; }
    }
}
