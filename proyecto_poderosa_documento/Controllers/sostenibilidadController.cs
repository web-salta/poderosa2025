using System.Web.Mvc;
namespace proyecto_poderosa_documento.Controllers
{
    public class sostenibilidadController : Controller
    {
        // GET: Home


        /*  public ActionResult introduccion()
          {
              return View("~/Views/sostenibilidad/gestion_ambiental/introduccion.cshtml");
          }*/

        public ActionResult gestion_ambiental(string accion)
        {
            // Determinar la vista a devolver en función del parámetro
            switch (accion?.ToLower())
            {
                case "introduccion":
                    return View("~/Views/sostenibilidad/gestion_ambiental/introduccion.cshtml");
                case "uso-responsable-del-agua":
                    return View("~/Views/sostenibilidad/gestion_ambiental/uso-responsable-del-agua.cshtml");
                case "manejo-de-residuos":
                    return View("~/Views/sostenibilidad/gestion_ambiental/manejo-de-residuos.cshtml");
                case "monitoreo-ambiental":
                    return View("~/Views/sostenibilidad/gestion_ambiental/monitoreo-ambiental.cshtml");
                case "forestacion":
                    return View("~/Views/sostenibilidad/gestion_ambiental/forestacion.cshtml");
                case "cierre-de-minas":
                    return View("~/Views/sostenibilidad/gestion_ambiental/cierre-de-minas.cshtml");
                case "compromiso-de-cero-emisiones":
                    return View("~/Views/sostenibilidad/gestion_ambiental/compromiso-de-cero-emisiones.cshtml");
                case "nuestro-aporte":
                    return View("~/Views/sostenibilidad/gestion_ambiental/nuestro-aporte.cshtml");
                default:
                    return HttpNotFound(); // Si no coincide, retornar 404
            }
        }

        public ActionResult gestion_de_la_energia(string accion)
        {
            // Determinar la vista a devolver en función del parámetro
            switch (accion?.ToLower())
            {
                case "introduccion":
                    return View("~/Views/sostenibilidad/gestion_de_la_energia/introduccion.cshtml");
                case "matriz-electrica-de-poderosa-2023-al-2030":
                    return View("~/Views/sostenibilidad/gestion_de_la_energia/matriz-electrica-de-poderosa-2023-al-2030.cshtml");
                case "nuestros-avances-con-energias-limpias":
                    return View("~/Views/sostenibilidad/gestion_de_la_energia/nuestros-avances-con-energias-limpias.cshtml");
                default:
                    return HttpNotFound(); // Si no coincide, retornar 404
            }
        }

        public ActionResult gestion_de_cumplimiento(string accion)
        {
            // Determinar la vista a devolver en función del parámetro
            switch (accion?.ToLower())
            {
                case "introduccion":
                    return View("~/Views/sostenibilidad/gestion_de_cumplimiento/introduccion.cshtml");
                case "componentes-del-sistema-de-gestion-de-cumplimiento":
                    return View("~/Views/sostenibilidad/gestion_de_cumplimiento/componentes-del-sistema-de-gestion-de-cumplimiento.cshtml");
                case "canal-de-etica":
                    return View("~/Views/sostenibilidad/gestion_de_cumplimiento/canal-de-etica.cshtml");
                case "canal-de-consultas":
                    return View("~/Views/sostenibilidad/gestion_de_gestion_de_cumplimiento/canal-de-consultas.cshtml");
                case "procedimientos-internos":
                    return View("~/Views/sostenibilidad/gestion_de_cumplimiento/procedimientos-internos.cshtml");
                default:
                    return HttpNotFound(); // Si no coincide, retornar 404
            }
        }

        public ActionResult gestion_de_talento(string accion)
        {
            // Determinar la vista a devolver en función del parámetro
            switch (accion?.ToLower())
            {
                case "introduccion":
                    return View("~/Views/sostenibilidad/gestion_de_talento/introduccion.cshtml");
                case "certificado-de-buen-empleador":
                    return View("~/Views/sostenibilidad/gestion_de_talento/certificado-de-buen-empleador.cshtml");
                case "diversidad-y-inclusion":
                    return View("~/Views/sostenibilidad/gestion_de_talento/diversidad-e-inclusion.cshtml");
                case "derechos-humanos":
                    return View("~/Views/sostenibilidad/gestion_de_talento/derechos-humanos.cshtml");
                case "capacitacion":
                    return View("~/Views/sostenibilidad/gestion_de_talento/capacitacion.cshtml");
                case "reclutamiento-y-seleccion":
                    return View("~/Views/sostenibilidad/gestion_de_talento/reclutamiento-y-seleccion.cshtml");
                case "programa-de-practicas-talentos-de-oro-poderosa":
                    return View("~/Views/sostenibilidad/gestion_de_talento/programa-de-practicas-talentos-de-oro-poderosa.cshtml");
                default:
                    return HttpNotFound(); // Si no coincide, retornar 404
            }
        }



    }
}