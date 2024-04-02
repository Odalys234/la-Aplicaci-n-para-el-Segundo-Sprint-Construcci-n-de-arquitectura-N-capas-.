using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TOURTRADE.SysLoginTT.BL;
using TOURTRADE.SysLoginTT.EN;

namespace TOURTRADE.SysLoginTT.AppWeb.Controllers
{
    public class RoleController : Controller
    {
        // GET: RoleController
        public async Task<ActionResult>Index()
        {
            var roles = await RoleBL.GetAll();
            return View(roles);
        }

        // GET: RoleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult>Create(Role pRole)
        {
            try
            {
                var result = RoleBL.Create(pRole);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoleController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var role = await RoleBL.GetById(new Role { Id = id }); // Obtener el rol por su Id
            if (role == null)
            {
                return NotFound(); // Otra acción en caso de que el rol no se encuentre
            }
            return View(role); // Pasar el rol como modelo a la vista
        }

        // POST: RoleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Role pRole)
        {
            try
            {
                var roleToUpdate = await RoleBL.GetById(new Role { Id = id }); // Obtener el rol por su Id
                if (roleToUpdate == null)
                {
                    return NotFound(); // Otra acción en caso de que el rol no se encuentre
                }

                // Actualizar los datos del rol con los datos del modelo recibido en el POST
                roleToUpdate.Name = pRole.Name;

                // Realizar la actualización en la base de datos
                var result = await RoleBL.Update(roleToUpdate);

                // Redireccionar al usuario a la página de índice después de la edición exitosa
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: RoleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete( Role pRole)
        {
            try
            {
                var result = await RoleBL.Delete(pRole);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
