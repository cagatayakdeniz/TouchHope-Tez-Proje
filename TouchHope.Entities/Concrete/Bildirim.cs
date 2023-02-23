using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Abstract;

namespace TouchHope.Entities.Concrete
{
    public class Bildirim: IEntity
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Mesaj { get; set; }
        public bool Durum { get; set; } = false;

        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
