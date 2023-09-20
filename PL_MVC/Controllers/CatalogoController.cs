using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class CatalogoController : Controller
    {
        // GET: Catalogo
        public ActionResult Catalogo()
        {
            ML.Area area = new ML.Area();
            ML.Result result = BL.Area.AreaGetAllEF();
            area.Areas = result.Objects;

            if (result.Correct)
            {
                area.Areas = result.Objects;
            }
            else
            {
                ViewBag.Message = result.ErrorMessage;
            }
            return View(area);
        }


        [HttpGet]
        public ActionResult GetProductos(int? IdArea){
            ML.Result result = BL.Producto.GetAll(IdArea.Value);
            if (result.Correct)
            {
                ML.Producto producto = new ML.Producto();
                producto.Productos = result.Objects;
                return View(producto);
            }
            else
            {
                ViewBag.Message = "Error en la consulta";
                return PartialView("Modal");    

            }

        }

        [HttpGet]
        public ActionResult GetProductosTodo()
        {
            ML.Result result = BL.Producto.GetAllTodo();
            if (result.Correct)
            {
                ML.Producto producto = new ML.Producto();
                producto.Productos = result.Objects;
                return View(producto);
            }
            else
            {
                ViewBag.Message = "Error en la consulta";
                return PartialView("Modal");

            }

        }


    }
}