﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.Entities.Dtos
{
    public class HastaHayvanAddDto 
    {
        public string FotografUrl { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturulmaTarih { get; set; }
        public bool Durum { get; set; } = false;
        public string AcikAdres { get; set; }

        public int? KullaniciId { get; set; }

        public int AciliyetId { get; set; }

        public int IlId { get; set; }

        public int TurId { get; set; }

        //public List<Rapor> Raporlar { get; set; }
    }
}
