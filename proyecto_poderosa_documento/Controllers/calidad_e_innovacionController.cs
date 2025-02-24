using System.Web.Mvc;
namespace proyecto_poderosa_documento.Controllers
{

    public class calidad_e_innovacionController : Controller
    {
        // GET: Home

        public ActionResult mejora_continua(string accion)
        {
            // Determinar la vista a devolver en función del parámetro
            switch (accion?.ToLower())
            {
                case "metodologia-de-solucion-de-problemas":
                    return View("~/Views/calidad_e_innovacion/mejora_continua/metodologia-de-solucion-de-problemas.cshtml");
                case "trabajo-en-equipo-para-la-excelencia":
                    return View("~/Views/calidad_e_innovacion/mejora_continua/trabajo-en-equipo-para-la-excelencia.cshtml");
                case "programa-de-mejora-continua":
                    return View("~/Views/calidad_e_innovacion/mejora_continua/programa-de-mejora-continua.cshtml");
                default:
                    return HttpNotFound(); // Si no coincide, retornar 404
            }
        }

        public ActionResult gestion_de_calidad(string accion)
        {
            // Determinar la vista a devolver en función del parámetro
            switch (accion?.ToLower())
            {
                case "semana-de-la-calidad-poderosa":
                    return View("~/Views/calidad_e_innovacion/gestion_de_calidad/semana-de-la-calidad-poderosa.cshtml");
                case "semana-de-la-calidad-sociedad-nacional-de-industrias":
                    return View("~/Views/calidad_e_innovacion/gestion_de_calidad/semana-de-la-calidad-sociedad-nacional-de-industrias.cshtml");
                case "premio-nacional-a-la-calidad-reconocimiento-mas-importante-en-peru":
                    return View("~/Views/calidad_e_innovacion/gestion_de_calidad/premio-nacional-a-la-calidad-reconocimiento-mas-importante-en-peru.cshtml");
                case "gestion-de-las-isos":
                    return View("~/Views/calidad_e_innovacion/gestion_de_calidad/gestion-de-las-isos.cshtml");
                case "introduccion":
                    return View("~/Views/calidad_e_innovacion/gestion_de_calidad/introduccion.cshtml");
                default:
                    return HttpNotFound(); // Si no coincide, retornar 404
            }
        }

        public ActionResult colpa_5s(string accion)
        {
            // Determinar la vista a devolver en función del parámetro
            switch (accion?.ToLower())
            {
                case "estandar-colpa":
                    return View("~/Views/calidad_e_innovacion/colpa_5s/estandar-colpa.cshtml");
                case "premio-nacional-kaizen-5s":
                    return View("~/Views/calidad_e_innovacion/colpa_5s/premio-nacional-kaizen-5s.cshtml");
                case "colpa-5s":
                    return View("~/Views/calidad_e_innovacion/colpa_5s/colpa-5s.cshtml");
                default:
                    return HttpNotFound(); // Si no coincide, retornar 404
            }
        }


        public ActionResult calidad_total(string accion)
        {
            // Determinar la vista a devolver en función del parámetro
            switch (accion?.ToLower())
            {
                case "calidad-en-la-vida-de-las-personas":
                    return View("~/Views/calidad_e_innovacion/calidad_total/calidad-en-la-vida-de-las-personas.cshtml");
                case "calidad-en-los-procesos":
                    return View("~/Views/calidad_e_innovacion/calidad_total/calidad-en-los-procesos.cshtml");
                case "introduccion":
                    return View("~/Views/calidad_e_innovacion/calidad_total/introduccion.cshtml");
                default:
                    return HttpNotFound(); // Si no coincide, retornar 404
            }
        }

        public ActionResult innovacion(string accion)
        {
            // Determinar la vista a devolver en función del parámetro
            switch (accion?.ToLower())
            {
                case "introduccion":
                    return View("~/Views/calidad_e_innovacion/innovacion/introduccion.cshtml");
                case "estrategias-para-el-cambio":
                    return View("~/Views/calidad_e_innovacion/innovacion/estrategias-para-el-cambio.cshtml");
                case "nuestras-principales-iniciativas-en-innovacion":
                    return View("~/Views/calidad_e_innovacion/innovacion/nuestras-principales-iniciativas-en-innovacion.cshtml");
                case "ecosistema-de-innovacion":
                    return View("~/Views/calidad_e_innovacion/innovacion/ecosistema-de-innovacion.cshtml");
                default:
                    return HttpNotFound(); // Si no coincide, retornar 404
            }
        }

    }
}