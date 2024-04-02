using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TOURTRADE.SysLoginTT.BL;
using TOURTRADE.SysLoginTT.EN;

namespace TOURTRADE.SysLoginTT.AppWeb.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: CategoriaController
        public async Task<ActionResult> Index()
        {
            var categoria = await CategoriaBL.GetAll();
            return View(categoria);
        }

        // GET: CategoriaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Categoria pCategoria)
        {
            try
            {
                var result = CategoriaBL.Create(pCategoria);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriaController/Edit/5
        public async Task <ActionResult> Edit(int id)
        {
            var categoria = await CategoriaBL.GetById(new Categoria { CategoriaID = id });
            if (categoria == null)
            {
                return NotFound();

            }
            return View(categoria);
        }

        // POST: CategoriaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id,Categoria pCategoria)
        {
            try
            {
                var categoriaToUpdate = await CategoriaBL.GetById(new Categoria { CategoriaID = id });
                if(categoriaToUpdate == null) 
                { 
                    return NotFound();
                }
                categoriaToUpdate.NombreCategoria = pCategoria.NombreCategoria;
                categoriaToUpdate.DescripcionCategoria = pCategoria.DescripcionCategoria;
                var result = await CategoriaBL.Update(categoriaToUpdate);
                    

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Categoria pCategoria)
        {
            try
            {
                var result = await CategoriaBL.Delete(pCategoria);
                return RedirectToAction(nameof(Index));
            }
            catch 
            {
                return View();
            }
        }
    }
}
