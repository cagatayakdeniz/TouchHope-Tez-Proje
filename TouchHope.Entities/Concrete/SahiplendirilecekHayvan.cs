using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Abstract;

namespace TouchHope.Entities.Concrete
{
    public class SahiplendirilecekHayvan: IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string FotografUrl { get; set; }
        public int Yas { get; set; }
        public string TelefonNo { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturulmaTarih { get; set; } = DateTime.Now;

        public int IlId { get; set; }
        public Il Il { get; set; }

        public int TurId { get; set; }
        public Tur Tur { get; set; }
    }
}
