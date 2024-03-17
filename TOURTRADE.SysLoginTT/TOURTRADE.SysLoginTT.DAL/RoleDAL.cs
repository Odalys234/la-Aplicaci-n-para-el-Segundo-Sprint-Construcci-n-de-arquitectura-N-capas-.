using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TOURTRADE.SysLoginTT.DAL.ComunDB;
using Microsoft.EntityFrameworkCore;
using TOURTRADE.SysLoginTT.EN;

namespace TOURTRADE.SysLoginTT.DAL
{
    public class RoleDAL
    {

        public static async Task<Role> GetById(Role pRole)
        {
            var role = new Role();
            using (var dbContext = new ComunDB())
            {
                role = await dbContext.Roles.FirstOrDefaultAsync(s => s.Id == pRole.Id);
            }
            return role;

        }
    }
}
