using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Departamento departamento = new ML.Departamento();
            departamento.Nombre = "";
            departamento.IdArea = 0;
            ML.Result result = BL.Departamento.DepartamentoGetAllEF(departamento);
            departamento.Area = new ML.Area();
            departamento.Departamentos = new List<object>();
            ML.Result resultArea = BL.Area.AreaGetAllEF();
            


            if (result.Correct)
            {
                
                departamento.Departamentos = result.Objects;
                departamento.Area.Areas = resultArea.Objects;
            }
            else
            {
                ViewBag.Message = result.ErrorMessage;
               
            }

            return View(departamento);
        }


        [HttpPost]
        public ActionResult GetAll(ML.Departamento departamento)
        {
            if (departamento.Nombre == null)
            {
                departamento.Nombre = "";
            }
            if (departamento.IdArea == null)
            {
                departamento.IdArea = 0;
            }
            
            ML.Result resultArea = BL.Area.AreaGetAllEF();
            departamento.Area.Areas = resultArea.Objects;

            ML.Result result = BL.Departamento.DepartamentoGetAllEF(departamento);
           
            departamento.Departamentos = result.Objects;

            return View(departamento);
        }






        [HttpGet]
        public ActionResult Form(int? IdDepartamento)
        {
            ML.Departamento departamento = new ML.Departamento();

            departamento.Area = new ML.Area();

            ML.Result Areas = BL.Area.AreaGetAllEF();
            departamento.Area.Areas = Areas.Objects;
           
            if (IdDepartamento != null)
            {
                ML.Result result = BL.Departamento.DepartamentoGetByIdEF(IdDepartamento.Value);

                if (result.Correct)
                {

                    departamento = (ML.Departamento)result.Object;
                    departamento.Area.Areas = Areas.Objects;
                    
                }

            }
            else
            {
                departamento.Area.Areas = Areas.Objects;
            }


            return View(departamento);
        }

        [HttpPost]
        public ActionResult Form(ML.Departamento departamento)
        {
            

            if (departamento.IdDepartamento == 0)
            {
                ML.Result result = BL.Departamento.DepartamentoAddEF(departamento);
                if (result.Correct)
                {
                    ViewBag.Mensaje = "Se ha completado el registro";
                }
                else
                {
                    ViewBag.Mensaje = "Error" + result.ErrorMessage;
                }

            }
            else
            {
                ML.Result result = BL.Departamento.DepartamentoUpdateEF(departamento);


                if (result.Correct)
                {

                    ViewBag.Mensaje = "Se ha completado la actualizacion";
                }
                else
                {
                    ViewBag.Mensaje = "Error" + result.ErrorMessage;
                }
            }


            return PartialView("Modal");
        }


        [HttpGet]
        public ActionResult Delete(int IdDepartamento)
        {
            ML.Result result = BL.Departamento.DepartamentoDeleteEF(IdDepartamento);
            if (result.Correct)
            {
                ViewBag.Mensaje = "Se ha eleiminado correctamente el departamento";

            }
            else
            {
                ViewBag.Mensaje = "No se ha podido eliminar el departamento" + result.ErrorMessage;
            }
            return PartialView("Modal");
        }


    

    }
}