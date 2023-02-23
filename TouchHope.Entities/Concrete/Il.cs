using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Abstract;

namespace TouchHope.Entities.Concrete
{
    public class Il: IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public List<Kullanici> Kullanicilar { get; set; }
        public List<HastaHayvan> HastaHayvanlar { get; set; }
        public List<Ihbar> Ihbarlar { get; set; }
        public List<KaybolanHayvan> KaybolanHayvanlar { get; set; }
        public List<SahiplendirilecekHayvan> SahiplendirilecekHayvanlar { get; set; }
    }
}
