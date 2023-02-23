﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.Entities.Dtos
{
    public class SahiplendirilecekHayvanListDto
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string FotografUrl { get; set; }
        public int Yas { get; set; }
        public string TelefonNo { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturulmaTarih { get; set; }

        public int IlId { get; set; }
        public IlListDto Il { get; set; }

        public int TurId { get; set; }
        public TurListDto Tur { get; set; }
    }
}
