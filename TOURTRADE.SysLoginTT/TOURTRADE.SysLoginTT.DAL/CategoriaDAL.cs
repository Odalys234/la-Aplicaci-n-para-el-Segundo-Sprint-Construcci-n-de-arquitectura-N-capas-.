using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOURTRADE.SysLoginTT.EN;

namespace TOURTRADE.SysLoginTT.DAL
{
    public class CategoriaDAL
    {
        public static async Task<Categoria> GetById(Categoria pCategoria)
        {
            var categoria = new Categoria();
            using (var dbContext = new ComunDB())
            {
                categoria = await dbContext.Categorias.FirstOrDefaultAsync(s=> s.CategoriaID == pCategoria.CategoriaID);

            }
            return categoria;
        }
        public static async Task<int> Create(Categoria pCategoria)
        {
            int result = 0;
            using(var dbContext = new ComunDB())
            {
                dbContext.Add(pCategoria);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Update (Categoria pCategoria)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {
                var categoria = await dbContext.Categorias.FirstOrDefaultAsync(r => r.CategoriaID == pCategoria.CategoriaID);
                categoria.NombreCategoria = pCategoria.NombreCategoria;
                categoria.DescripcionCategoria = pCategoria.DescripcionCategoria;
                dbContext.Update(categoria);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Delete(Categoria pCategoria)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {
                var categoria = await dbContext.Categorias.FirstOrDefaultAsync(r => r.CategoriaID==pCategoria.CategoriaID);
                dbContext.Remove(categoria);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<List<Categoria>> GetAll()
        {
            var categoria = new List<Categoria>();
            int result = 0; 
            using(var dbContext = new ComunDB())
            {
                categoria = await dbContext.Categorias.ToListAsync();
            }
            return categoria;
        }
    } 
}
