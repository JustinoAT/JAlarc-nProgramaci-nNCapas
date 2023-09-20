﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Rol
    {

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {
                    var tablaRoles = context.RolGetAll().ToList();
                    result.Objects = new List<object>();

                    if (tablaRoles != null)
                    {
                    
                        foreach (var obj in tablaRoles)
                        {
                            ML.Rol rol = new ML.Rol();
                            rol.IdRol = obj.IdRol;
                            rol.Nombre = obj.Nombre;
                            result.Objects.Add(rol);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "La tabla usuario no contiene registros";
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
