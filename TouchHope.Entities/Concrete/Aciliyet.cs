using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Abstract;

namespace TouchHope.Entities.Concrete
{
    public class Aciliyet: IEntity
    {
        public int Id { get; set; }
        public string Tanim { get; set; }

        public List<HastaHayvan> HastaHayvanlar { get; set; }
        public List<Ihbar> Ihbarlar { get; set; }
    }
}
