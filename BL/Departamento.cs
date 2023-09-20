using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Departamento
    {

        //Metodo agregar departamento
        public static ML.Result DepartamentoAddEF(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {
                    int rowAffected = context.DepartamentoAdd(departamento.Nombre, departamento.Area.IdArea);
                    if (rowAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
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

        //----------------------Metodo Update-------------

        public static ML.Result DepartamentoUpdateEF(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {

                    int rowAffected = context.DepartamentoUpdate(departamento.IdDepartamento, departamento.Nombre, departamento.Area.IdArea);
                    if (rowAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
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
        //----------------------Metodo Borrar-------------

        public static ML.Result DepartamentoDeleteEF(int IdDepartamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {
                    int rowAffected = context.DepartamentoDelete(IdDepartamento);
                    if (rowAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
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
        //----------------------Metodo select *-------------

        public static ML.Result DepartamentoGetAllEF(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {
                    var tablaDepartamentos = context.DepartamentoGetAll(departamento.Nombre, departamento.Area.IdArea).ToList();
                    result.Objects = new List<object>();

                    if (tablaDepartamentos != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var obj in tablaDepartamentos)
                        {
                            ML.Departamento departamento1 = new ML.Departamento();
                            departamento1.Area = new ML.Area();

                            departamento1.IdDepartamento = obj.IdDepartamento;
                            departamento1.Nombre = obj.Nombre;
                            departamento1.Area.IdArea = obj.IdArea.Value;
                            departamento1.Area.Nombre = obj.NombreArea;


                            result.Objects.Add(departamento1);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "La tabla departamento no contiene registros";
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

        //----------------------Metodo select by ID-------------

        public static ML.Result DepartamentoGetByIdEF(int IdDepartamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {

                    var tablaDepartamentoID = context.DepartamentoGetById(IdDepartamento).FirstOrDefault();

                    //                    result.Objects = new List<object>();    No se ocupa por que solo nos regresara 1 dato

                    if (tablaDepartamentoID != null)
                    {

                        ML.Departamento departamento = new ML.Departamento();

                        departamento.Area = new ML.Area();


                        departamento.IdDepartamento = tablaDepartamentoID.IdDepartamento;
                        departamento.Nombre = tablaDepartamentoID.Nombre;
                        departamento.Area.IdArea = tablaDepartamentoID.IdArea.Value;
                        departamento.Area.Nombre = tablaDepartamentoID.Nombre;
                    
                       



                        result.Object = departamento;


                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "La tabla departamento no contiene registros";
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

