using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Abstract;

namespace TouchHope.Entities.Concrete
{
    public class Kullanici: IEntity
    {
        public int Id { get; set; }
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
        public string Email { get; set; }
        public string TelefonNo { get; set; }
        public DateTime DogumTarih { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public int CinsiyetId { get; set; }
        public Cinsiyet Cinsiyet { get; set; }

        public int IlId { get; set; }
        public Il Il { get; set; }

        public List<Bildirim> Bildirimler { get; set; }
        public List<KullaniciRol> KullaniciRoller { get; set; }
        public List<HastaHayvan> HastaHayvanlar { get; set; }
    }
}
