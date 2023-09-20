using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Area
    {
        //----------------------Metodo select *-------------

        public static ML.Result AreaGetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {
                    var tablaArea = context.AreaGetAll().ToList();
                    result.Objects = new List<object>();

                    if (tablaArea != null)
                    {
                        

                        foreach (var obj in tablaArea)
                        {
                            ML.Area area = new ML.Area();
                            
                            area.IdArea = obj.IdArea;
                            area.Nombre = obj.Nombre;
                

                            result.Objects.Add(area);
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
