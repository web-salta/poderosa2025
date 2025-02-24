using System.Web.Mvc;

namespace proyecto_poderosa_documento.Controllers
{
    public class comunidadController : Controller
    {
        // GET: comunidad
        public ActionResult poblaciones_vecinas()
        {
            return View();
        }
        public ActionResult desarrollo_social()
        {
            return View();
        }
        public ActionResult asociacion_pataz()
        {
            return View();
        }
    }
}