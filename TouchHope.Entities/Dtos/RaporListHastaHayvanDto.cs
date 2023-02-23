using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchHope.Entities.Dtos
{
    public class RaporListHastaHayvanDto
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Detay { get; set; }

        public int HastaHayvanId { get; set; }
    }
}
