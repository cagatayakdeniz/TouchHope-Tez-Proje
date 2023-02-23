using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.Models
{
    public class KullaniciModel
    {
        public int Id { get; set; }
        public string KullaniciAd { get; set; }
        public string Ad { get; set; }

        public List<string> Roles { get; set; }
    }
}
