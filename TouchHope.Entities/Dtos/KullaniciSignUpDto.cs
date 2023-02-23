using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Abstract;

namespace TouchHope.Entities.Dtos
{
    public class KullaniciSignUpDto: IDto
    {
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
        public string Email { get; set; }
        public string TelefonNo { get; set; }
        public DateTime DogumTarih { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public int CinsiyetId { get; set; }

        public int IlId { get; set; }
    }
}
