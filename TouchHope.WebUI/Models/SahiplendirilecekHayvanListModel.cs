using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.WebUI.Models
{
    public class SahiplendirilecekHayvanListModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string FotografUrl { get; set; }
        public int Yas { get; set; }
        public string TelefonNo { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturulmaTarih { get; set; }

        public int IlId { get; set; }
        public IlListModel Il { get; set; }

        public int TurId { get; set; }
        public TurListModel Tur { get; set; }
    }
}
