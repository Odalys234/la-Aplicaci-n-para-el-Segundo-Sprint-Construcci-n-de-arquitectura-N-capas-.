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
        public static async Task<int> Create(Role pRole)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {
                dbContext.Add(pRole);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Update(Role pRole)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {

                var role = await dbContext.Roles.FirstOrDefaultAsync(r => r.Id == pRole.Id);
                role.Name = pRole.Name;
                dbContext.Update(role);
                result = await dbContext.SaveChangesAsync();
            }
            return result;

        }
        public static async Task<int> Delete(Role pRole)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {

                var role = await dbContext.Roles.FirstOrDefaultAsync(r => r.Id == pRole.Id);
                dbContext.Remove(role);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<List<Role>> GetAll()
        {
            var roles = new List<Role>();
            int result = 0;
            using (var dbContext = new ComunDB())
            {

                roles = await dbContext.Roles.ToListAsync();
            }
            return roles;
        }

    }
}