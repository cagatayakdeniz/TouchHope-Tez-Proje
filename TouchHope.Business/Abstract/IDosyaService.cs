using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchHope.Business.Abstract
{
    public interface IDosyaService
    {
        string AktarPdf<T>(List<T> list);
        byte[] AktarExcel<T>(List<T> list);
    }
}
