using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOURTRADE.SysLoginTT.DAL;
using TOURTRADE.SysLoginTT.EN;

namespace TOURTRADE.SysLoginTT.BL
{
    public class CategoriaBL
    {
        public static async Task<Categoria> GetById (Categoria pCategoria)
        {
            return await CategoriaDAL.GetById(pCategoria);
        } 
        public static async Task<int> Create (Categoria pCategoria)
        {
            return await CategoriaDAL.Create(pCategoria);
        }
        public static async Task<int> Update (Categoria pCategoria)
        {
            return await CategoriaDAL.Update(pCategoria);
        }
        public static async Task<int> Delete(Categoria pCategoria)
        {
            return await CategoriaDAL.Delete(pCategoria);
        }
        public static async Task<List<Categoria>> GetAll()
        {
            return await CategoriaDAL.GetAll();
        }
    }
}
