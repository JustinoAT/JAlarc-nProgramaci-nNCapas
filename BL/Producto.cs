using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Producto
    {
        public static ML.Result GetAll(int IdArea)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {
                    var tablaProducto = context.ProductoGetByIdArea(IdArea).ToList();
                    result.Objects = new List<object>();

                    if (tablaProducto != null)
                    {


                        foreach (var obj in tablaProducto)
                        {
                            ML.Producto producto = new ML.Producto();

                            producto.IdProducto = obj.IdProducto;
                            producto.Nombre = obj.Nombre;
                            producto.PrecioUnitario = obj.PrecioUnitario;
                            producto.Stock = obj.Stock;
                            producto.Descripcion = obj.Descripcion;
                            producto.Imagen = obj.Imagen;
                            producto.Departamento = new ML.Departamento();
                            producto.Departamento.Nombre = obj.NombreDepartamento;
                            producto.Departamento.Area = new ML.Area();
                            producto.Departamento.Area.Nombre = obj.NombreArea;
                            result.Objects.Add(producto);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "La tabla area no contiene registros";
                    }

                }


            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Exception = ex;
            }
            return result;

        }
        public static ML.Result GetAllTodo()
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {
                    var tablaProducto = context.ProductoGetAll().ToList();
                    result.Objects = new List<object>();

                    if (tablaProducto != null)
                    {


                        foreach (var obj in tablaProducto)
                        {
                            ML.Producto producto = new ML.Producto();

                            producto.IdProducto = obj.IdProducto;
                            producto.Nombre = obj.Nombre;
                            producto.PrecioUnitario = obj.PrecioUnitario;
                            producto.Stock = obj.Stock;
                            producto.Descripcion = obj.Descripcion;
                            producto.Imagen = obj.Imagen;
                            result.Objects.Add(producto);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "La tabla area no contiene registros";
                    }

                }


            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Exception = ex;
            }
            return result;

        }
    }
}
