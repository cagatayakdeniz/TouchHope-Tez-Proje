﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Abstract
{
    public interface IAciliyetApiService
    {
        Task<List<AciliyetListModel>> GetirHepsi();
    }
}
