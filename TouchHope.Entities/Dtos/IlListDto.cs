using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Abstract;

namespace TouchHope.Entities.Dtos
{
    public class IlListDto: IDto
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }
}
