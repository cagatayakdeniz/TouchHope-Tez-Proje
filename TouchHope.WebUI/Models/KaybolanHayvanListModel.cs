using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.WebUI.Models
{
    public class KaybolanHayvanListModel
    {
        public int Id { get; set; }
        public string FotografUrl { get; set; }
        public string Aciklama { get; set; }
        public string TelefonNo { get; set; }
        public DateTime OlusturulmaTarih { get; set; }

        public int IlId { get; set; }
        public IlListModel Il { get; set; }

        public int TurId { get; set; }
        public TurListModel Tur { get; set; }
    }
}
