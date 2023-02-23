using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Abstract;

namespace TouchHope.Entities.Concrete
{
    public class Rapor: IEntity
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Detay { get; set; }

        public int HastaHayvanId { get; set; }
        public HastaHayvan HastaHayvan { get; set; }
    }
}
