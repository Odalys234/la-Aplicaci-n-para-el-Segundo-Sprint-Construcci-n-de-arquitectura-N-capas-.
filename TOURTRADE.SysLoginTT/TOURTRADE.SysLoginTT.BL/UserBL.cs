using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOURTRADE.SysLoginTT.DAL;
using TOURTRADE.SysLoginTT.EN;
using Microsoft.EntityFrameworkCore;

namespace TOURTRADE.SysLoginTT.BL
{
    public class UserBL
    {

        public static async Task<User> Login(User pUser)
        {
            return await UserDAL.Login(pUser);
        }

    }
}
