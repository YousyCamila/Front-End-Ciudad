using Fron_End_Ciudad.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fron_End_Ciudad.Controllers
{
    public class CiudadController : Controller
    {
       
        public IActionResult Crear()
        {
           
            ViewBag.Departamentos = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Departamento Distrito Capital" },
            new SelectListItem { Value = "2", Text = "Departamento Cundinamarca" },
            new SelectListItem { Value = "3", Text = "Departamento Antioquia" },
            new SelectListItem { Value = "4", Text = "Departamento Choco" }

        };

            return View();
        }

       
        [HttpPost]
        public IActionResult Crear(Ciudad ciudad)
        {
            if (ModelState.IsValid)
            {
                return View("Mostrar", ciudad);
            }

           
            ViewBag.Departamentos = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Departamento Distrito Capital" },
            new SelectListItem { Value = "2", Text = "Departamento Cundinamarca" },
            new SelectListItem { Value = "3", Text = "Departamento Antioquia" },
            new SelectListItem { Value = "4", Text = "Departamento Choco" }
        };
            return View(ciudad);
        }
    }

}
