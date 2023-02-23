using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Abstract;

namespace TouchHope.Entities.Concrete
{
    public class HastaHayvan: IEntity
    {
        public int Id { get; set; }
        public string FotografUrl { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturulmaTarih { get; set; } = DateTime.Now;
        public bool Durum { get; set; } = false;
        public string AcikAdres { get; set; }

        public int? KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }

        public int AciliyetId { get; set; }
        public Aciliyet Aciliyet { get; set; }

        public int IlId { get; set; }
        public Il Il { get; set; }

        public int? TurId { get; set; }
        public Tur Tur { get; set; }

        public List<Rapor> Raporlar { get; set; }
    }
}
