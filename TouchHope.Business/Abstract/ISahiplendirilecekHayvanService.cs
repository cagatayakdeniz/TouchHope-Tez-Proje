﻿using BlogProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.Business.Abstract
{
    public interface ISahiplendirilecekHayvanService: IGenericService<SahiplendirilecekHayvan>
    {
        Task<int> GetirToplamSayi();
        Task<List<SahiplendirilecekHayvan>> GetirTumTablolarla();
        Task<List<SahiplendirilecekHayvan>> GetirSehireGore(int ilId);
    }
}
