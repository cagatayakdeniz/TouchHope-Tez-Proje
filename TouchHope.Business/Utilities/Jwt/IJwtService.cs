using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.Business.Utilities.Jwt
{
    public interface IJwtService
    {
        JwtToken GenerateToken(Kullanici kullanici, List<Rol> roller);
    }
}
