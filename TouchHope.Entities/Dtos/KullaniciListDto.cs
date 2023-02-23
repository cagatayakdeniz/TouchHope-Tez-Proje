using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.Entities.Dtos
{
    public class KullaniciListDto
    {
        public int Id { get; set; }
        public string KullaniciAd { get; set; }
        public string Email { get; set; }
        public string TelefonNo { get; set; }
        public DateTime DogumTarih { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public int CinsiyetId { get; set; }
        public CinsiyetListDto Cinsiyet { get; set; }

        public int IlId { get; set; }
        public IlListDto Il { get; set; }
    }
}
