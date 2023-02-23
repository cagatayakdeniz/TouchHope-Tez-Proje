using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.Models
{
    public class HayvanRaporDetayModel
    {
        public List<RaporListModel> Raporlar { get; set; }
        public HastaHayvanListModel HastaHayvan { get; set; }
    }
}
