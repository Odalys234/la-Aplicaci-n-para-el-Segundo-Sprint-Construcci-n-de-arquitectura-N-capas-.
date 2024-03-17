using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOURTRADE.SysLoginTT.DAL;
using TOURTRADE.SysLoginTT.EN;

namespace TOURTRADE.SysLoginTT.BL
{
    public class RoleBL
    {

        public static async Task<Role> GetById(Role pRole)
        {
            return await RoleDAL.GetById(pRole);
        }
    }
}
