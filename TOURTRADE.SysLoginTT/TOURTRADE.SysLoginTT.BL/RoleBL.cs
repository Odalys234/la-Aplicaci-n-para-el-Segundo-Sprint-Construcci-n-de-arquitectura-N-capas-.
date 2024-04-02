using Microsoft.EntityFrameworkCore;
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
        public static async Task<int> Create(Role pRole)
        {
            return await RoleDAL.Create(pRole);
        }
        public static async Task<int> Update(Role pRole)
        {
            return await RoleDAL.Update(pRole);
        }

        public static async Task<int> Delete(Role pRole)
        {
            return await RoleDAL.Delete(pRole);
           
        }
        public static async Task<List<Role>> GetAll()
        {
            return await RoleDAL.GetAll();
        }
    }
}

  
