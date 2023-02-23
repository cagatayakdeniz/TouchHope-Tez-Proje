using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.Entities.Dtos
{
    public class HastaHayvanListDto
    {
        public int Id { get; set; }
        public string FotografUrl { get; set; }
        public string Aciklama { get; set; }
        public string AcikAdres { get; set; }
        public DateTime OlusturulmaTarih { get; set; }

        public int? KullaniciId { get; set; }
        public KullaniciListHastaHayvanDto Kullanici { get; set; }

        public int IlId { get; set; }
        public IlListDto Il { get; set; }

        public int AciliyetId { get; set; }
        public AciliyetListDto Aciliyet { get; set; }

        public int? TurId { get; set; }
        public TurListDto Tur { get; set; }

        public List<RaporListHastaHayvanDto> Raporlar { get; set; }
    }
}
