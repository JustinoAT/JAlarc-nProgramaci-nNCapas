using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using ML;
using System.Runtime.Remoting.Contexts;
using System.Xml.XPath;
using DL_EF;
using System.Security.Cryptography;
using System.Data.Entity.Infrastructure;
using System.Data.OleDb;

namespace BL
{
    public class Usuario
    {

        //En este metodo add se encuentran los metodos normales y los sp pero estan comentados

        //--------------------Metodo add--------------------------------------------------------------
        //public static ML.Result Add(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "INSERT INTO USUARIO VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @EstaturaEnCentimetros, @Genero, @FechaDeNacimiento)";

        //            SqlCommand cmd = new SqlCommand(query, context);
        //            //Se crearan parametros de SQL
        //            //Con esto se insertaran los valores
        //            SqlParameter[] collection = new SqlParameter[7];

        //            collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[0].Value = usuario.Nombre;

        //            collection[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[1].Value = usuario.ApellidoPaterno;

        //            collection[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoMaterno;

        //            collection[3] = new SqlParameter("@EstaturaEnCentimetros", SqlDbType.Decimal);
        //            collection[3].Value = usuario.EstaturaEnCentimetros;

        //            collection[4] = new SqlParameter("@Genero", SqlDbType.VarChar);
        //            collection[4].Value = usuario.Genero;

        //            collection[5] = new SqlParameter("@FechaDeNacimiento", SqlDbType.Date);
        //            collection[5].Value = usuario.FechaDeNacimiento;

        //            collection[6] = new SqlParameter("@IdRol", SqlDbType.Date);
        //            collection[6].Value = usuario.Rol.IdRol;

        //            //Lo siguiente es pasarle el parametro
        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasAfectadas = cmd.ExecuteNonQuery();
        //            if (filasAfectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Exception = ex;
        //    }
        //    return result;
        //}

        ////----------------------Metodo Update-------------

        //public static ML.Result Update(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UPDATE USUARIO SET Nombre = @Nombre, ApellidoPaterno = @ApellidoPaterno, ApellidoMaterno = @ApellidoMaterno, EstaturaEnCentimetros = @EstaturaEnCentimetros, Genero = @Genero, FechaDeNacimiento = @FechaDeNacimiento WHERE IdUsuario = @IdUsuario";

        //            SqlCommand cmd = new SqlCommand(query, context);
        //            //Se crearan parametros de SQL
        //            //Con esto se insertaran los valores
        //            SqlParameter[] collection = new SqlParameter[7];

        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;

        //            collection[1] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[1].Value = usuario.Nombre;

        //            collection[2] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoPaterno;

        //            collection[3] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[3].Value = usuario.ApellidoMaterno;

        //            collection[4] = new SqlParameter("@EstaturaEnCentimetros", SqlDbType.Decimal);
        //            collection[4].Value = usuario.EstaturaEnCentimetros;

        //            collection[5] = new SqlParameter("@Genero", SqlDbType.VarChar);
        //            collection[5].Value = usuario.Genero;

        //            collection[6] = new SqlParameter("@FechaDeNacimiento", SqlDbType.Date);
        //            collection[6].Value = usuario.FechaDeNacimiento;


        //            //Lo siguiente es pasarle el parametro
        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasAfectadas = cmd.ExecuteNonQuery();
        //            if (filasAfectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Exception = ex;
        //    }
        //    return result;

        //}



        ////----------------------Metodo Borrar-------------

        //public static ML.Result Delete(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "DELETE FROM USUARIO WHERE IdUsuario = @IdUsuario";

        //            SqlCommand cmd = new SqlCommand(query, context);
        //            //Se crearan parametros de SQL
        //            //Con esto se insertaran los valores
        //            SqlParameter[] collection = new SqlParameter[1];

        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;


        //            //Lo siguiente es pasarle el parametro
        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasAfectadas = cmd.ExecuteNonQuery();
        //            if (filasAfectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Exception = ex;
        //    }
        //    return result;

        //}


        ////----------------------Metodo select *-------------

        //public static ML.Result GetAll()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "SELECT IdUsuario,Nombre,ApellidoPaterno,ApellidoMaterno,EstaturaEnCentimetros,Genero,FechaDeNacimiento FROM USUARIO";

        //            SqlCommand cmd = new SqlCommand(query, context);
        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataTable tablaUsuario = new DataTable();
        //            adapter.Fill(tablaUsuario);




        //            if (tablaUsuario.Rows.Count > 0)
        //            {
        //                result.Objects = new List<object>();
        //                foreach (DataRow row in tablaUsuario.Rows)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();
        //                    usuario.IdUsuario = int.Parse(row[0].ToString());
        //                    usuario.Nombre = row[1].ToString();
        //                    usuario.ApellidoPaterno = row[2].ToString();
        //                    usuario.ApellidoMaterno = row[3].ToString();
        //                    usuario.EstaturaEnCentimetros = decimal.Parse(row[4].ToString());
        //                    usuario.Genero = row[5].ToString();
        //                    usuario.FechaDeNacimiento = DateTime.Parse(row[6].ToString());
        //                    result.Objects.Add(usuario);
        //                }

        //                result.Correct = true;

        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "La tabla usuario no contiene registros";
        //            }

        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Exception = ex;
        //    }
        //    return result;

        //}

        ////----------------------Metodo select by ID-------------

        //public static ML.Result GetById(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "SELECT IdUsuario,Nombre,ApellidoPaterno,ApellidoMaterno,EstaturaEnCentimetros,Genero,FechaDeNacimiento FROM USUARIO WHERE IdUsuario = @IdUsuario";

        //            SqlCommand cmd = new SqlCommand(query, context);
        //            SqlParameter[] collection = new SqlParameter[1];

        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;
        //            cmd.Parameters.AddRange(collection);
                

        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataTable tablaUsuario = new DataTable();
        //            adapter.Fill(tablaUsuario);

        //            //Lo siguiente es pasarle el parametro

        //            if (tablaUsuario.Rows.Count > 0){
        //                DataRow row = tablaUsuario.Rows[0];

         
        //                usuario.IdUsuario = int.Parse(row[0].ToString());
        //                usuario.Nombre = row[1].ToString();
        //                usuario.ApellidoPaterno = row[2].ToString();
        //                usuario.ApellidoMaterno = row[3].ToString();
        //                usuario.EstaturaEnCentimetros = decimal.Parse(row[4].ToString());
        //                usuario.Genero = row[5].ToString();
        //                usuario.FechaDeNacimiento = DateTime.Parse(row[6].ToString());
        //                result.Object = usuario;
        //                result.Correct = true;
                    
                    

        //            }else{
        //        result.Correct = false;
        //        result.ErrorMessage = "No existe el registro";
        //            }
        //     }
        //        }
        //        catch (Exception ex)
        //        {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Exception = ex;
        //        }
        //        return result;

        //}



        ////Metodos utilizando procedimientos almacenados
        ////--------------------Metodo add--------------------------------------------------------------
        //public static ML.Result AddSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            SqlCommand cmd = new SqlCommand("UsuarioAdd", context);
        //            cmd.CommandType = CommandType.StoredProcedure;
                    
        //            SqlParameter[] collection = new SqlParameter[7];

        //            collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[0].Value = usuario.Nombre;

        //            collection[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[1].Value = usuario.ApellidoPaterno;

        //            collection[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoPaterno;

        //            collection[3] = new SqlParameter("@EstaturaEnCentimetros", SqlDbType.Decimal);
        //            collection[3].Value = usuario.EstaturaEnCentimetros;

        //            collection[4] = new SqlParameter("@Genero", SqlDbType.VarChar);
        //            collection[4].Value = usuario.Genero;

        //            collection[5] = new SqlParameter("@FechaDeNacimiento", SqlDbType.Date);
        //            collection[5].Value = usuario.FechaDeNacimiento;

        //            collection[6] = new SqlParameter("@IdRol", SqlDbType.Int);
        //            collection[6].Value = usuario.Rol.IdRol;


        //            //Lo siguiente es pasarle el parametro
        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasAfectadas = cmd.ExecuteNonQuery();
        //            if (filasAfectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Exception = ex;
        //    }
        //    return result;
        //}

        ////----------------------Metodo Borrar-------------

        //public static ML.Result DeleteSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            SqlCommand cmd = new SqlCommand("UsuarioDelete", context);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            //Se crearan parametros de SQL
        //            //Con esto se insertaran los valores
        //            SqlParameter[] collection = new SqlParameter[1];

        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;


        //            //Lo siguiente es pasarle el parametro
        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasAfectadas = cmd.ExecuteNonQuery();
        //            if (filasAfectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Exception = ex;
        //    }
        //    return result;

        //}


        ////----------------------Metodo Update-------------

        //public static ML.Result UpdateSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            SqlCommand cmd = new SqlCommand("UsuarioUpdate", context);
        //            cmd.CommandType = CommandType.StoredProcedure;


        //            SqlParameter[] collection = new SqlParameter[8];

        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;

        //            collection[1] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[1].Value = usuario.Nombre;

        //            collection[2] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoPaterno;

        //            collection[3] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[3].Value = usuario.ApellidoMaterno;

        //            collection[4] = new SqlParameter("@EstaturaEnCentimetros", SqlDbType.Decimal);
        //            collection[4].Value = usuario.EstaturaEnCentimetros;

        //            collection[5] = new SqlParameter("@Genero", SqlDbType.VarChar);
        //            collection[5].Value = usuario.Genero;

        //            collection[6] = new SqlParameter("@FechaDeNacimiento", SqlDbType.Date);
        //            collection[6].Value = usuario.FechaDeNacimiento;

        //            collection[7] = new SqlParameter("@IdRol", SqlDbType.Int);
        //            collection[7].Value = usuario.Rol.IdRol;


        //            //Lo siguiente es pasarle el parametro
        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasAfectadas = cmd.ExecuteNonQuery();
        //            if (filasAfectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Exception = ex;
        //    }
        //    return result;

        //}

        ////----------------------Metodo select *-------------

        //public static ML.Result GetAllSP()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
                   
        //            SqlCommand cmd = new SqlCommand("UsuarioGetAll", context);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataTable tablaUsuario = new DataTable();
        //            adapter.Fill(tablaUsuario);




        //            if (tablaUsuario.Rows.Count > 0)
        //            {
        //                result.Objects = new List<object>();
        //                foreach (DataRow row in tablaUsuario.Rows)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();
        //                    usuario.IdUsuario = int.Parse(row[0].ToString());
        //                    usuario.Nombre = row[1].ToString();
        //                    usuario.ApellidoPaterno = row[2].ToString();
        //                    usuario.ApellidoMaterno = row[3].ToString();
        //                    usuario.EstaturaEnCentimetros = decimal.Parse(row[4].ToString());
        //                    usuario.Genero = row[5].ToString();
        //                    usuario.FechaDeNacimiento = DateTime.Parse(row[6].ToString());
        //                    usuario.Rol = new ML.Rol();
        //                    usuario.Rol.Nombre = (row[7].ToString());
        //                    result.Objects.Add(usuario);
        //                }

        //                result.Correct = true;

        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "La tabla usuario no contiene registros";
        //            }

        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Exception = ex;
        //    }
        //    return result;

        //}

        ////----------------------Metodo select by ID-------------

        //public static ML.Result GetByIdSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {

        //            SqlCommand cmd = new SqlCommand("UsuarioGetById", context);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            SqlParameter[] collection = new SqlParameter[1];

        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;
        //            cmd.Parameters.AddRange(collection);


        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataTable tablaUsuario = new DataTable();
        //            adapter.Fill(tablaUsuario);

        //            //Lo siguiente es pasarle el parametro

        //            if (tablaUsuario.Rows.Count > 0)
        //            {
        //                DataRow row = tablaUsuario.Rows[0];


        //                usuario.IdUsuario = int.Parse(row[0].ToString());
        //                usuario.Nombre = row[1].ToString();
        //                usuario.ApellidoPaterno = row[2].ToString();
        //                usuario.ApellidoMaterno = row[3].ToString();
        //                usuario.EstaturaEnCentimetros = decimal.Parse(row[4].ToString());
        //                usuario.Genero = row[5].ToString();
        //                usuario.FechaDeNacimiento = DateTime.Parse(row[6].ToString());
        //                usuario.Rol = new ML.Rol();
        //                usuario.Rol.Nombre = (row[7].ToString());
        //                result.Object = usuario;
        //                result.Correct = true;



        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "No existe el registro";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Exception = ex;
        //    }
        //    return result;

        //}


        //Metodos utilizando Entity Framework
        //--------------------Metodo add--------------------------------------------------------------
        public static ML.Result AddEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {


                    int rowAffected = context.UsuarioAdd(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.FechaNacimiento, usuario.Rol.IdRol, usuario.UserName, usuario.Email, usuario.password, usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.CURP,usuario.Direccion.Calle,usuario.Direccion.NumeroInterior, usuario.Direccion.NumeroExterior, usuario.Direccion.Colonia.IdColonia, usuario.Imagen);
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

        public static ML.Result UpdateEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {

                    int rowAffected = context.UsuarioUpdate(usuario.IdUsuario, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.FechaNacimiento,
                        usuario.Rol.IdRol, usuario.UserName, usuario.Email, usuario.password, usuario.Sexo, usuario.Telefono, usuario.Celular,
                        usuario.CURP,usuario.Direccion.Calle, usuario.Direccion.NumeroInterior,
                        usuario.Direccion.NumeroExterior, usuario.Direccion.Colonia.IdColonia,usuario.Imagen);
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

        public static ML.Result DeleteEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {
                    int rowAffected = context.UsuarioDelete(IdUsuario);
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

        public static ML.Result GetAllEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {
                    var tablaUsuarios = context.UsuarioGetAll(usuario.Nombre, usuario.ApellidoPaterno).ToList();
                    result.Objects = new List<object>();

                    if (tablaUsuarios != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var obj in tablaUsuarios)
                        {
                            ML.Usuario usuario1 = new ML.Usuario();
                            usuario1.Direccion = new ML.Direccion();
                            usuario1.Direccion.Colonia = new ML.Colonia();
                            usuario1.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuario1.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuario1.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                            usuario1.Status = obj.Status;
                            usuario1.Imagen = obj.Imagen;
                            usuario1.IdUsuario = obj.IdUsuario;
                            usuario1.Nombre = obj.NombreUsuario;
                            usuario1.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario1.ApellidoMaterno = obj.ApellidoMaterno;
                            usuario1.FechaNacimiento = obj.FechaNacimiento;
                            usuario1.Rol = new ML.Rol();
                            usuario1.Rol.IdRol = obj.IdRol.Value;
                            usuario1.UserName = obj.UserName;
                            usuario1.Email = obj.Email;
                            usuario1.password = obj.password;
                            usuario1.Sexo = obj.Sexo;    
                            usuario1.Telefono = obj.Telefono;   
                            usuario1.Celular = obj.Celular;
                            usuario1.Rol.Nombre = obj.NombreRol;
                            usuario1.CURP = obj.CURP;
                            usuario1.Direccion.IdDireccion = obj.IdDireccion;
                            usuario1.Direccion.Calle = obj.Calle;
                            usuario1.Direccion.NumeroInterior = obj.NumeroInterior;
                            usuario1.Direccion.NumeroExterior = obj.NumeroExterior;
                            usuario1.Direccion.Colonia.IdColonia = obj.IdColonia;
                            usuario1.Direccion.Colonia.Nombre = obj.NombreColonia;
                            usuario1.Direccion.Colonia.Municipio.IdMunicipio = obj.IdMunicipio;
                            usuario1.Direccion.Colonia.Municipio.Nombre = obj.NombreMunicipio;
                            usuario1.Direccion.Colonia.Municipio.Estado.IdEstado = obj.IdEstado;
                            usuario1.Direccion.Colonia.Municipio.Estado.Nombre = obj.NombreEstado;
                            usuario1.Direccion.Colonia.Municipio.Estado.Pais.IdPais = obj.IdPais;
                            usuario1.Direccion.Colonia.Municipio.Estado.Pais.Nombre = obj.NombrePais;
                            
                            result.Objects.Add(usuario1);
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

           //----------------------Metodo select by ID-------------

        public static ML.Result GetByIdEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {

                    var tablaUsuariosID = context.UsuarioGetById(IdUsuario).FirstOrDefault();


                    //                    result.Objects = new List<object>();    No se ocupa por que solo nos regresara 1 dato


                    if (tablaUsuariosID != null)
                    {
                     
    
                        ML.Usuario usuario1 = new ML.Usuario();
                        usuario1.Direccion = new ML.Direccion();
                        usuario1.Direccion.Colonia = new ML.Colonia();
                        usuario1.Direccion.Colonia.Municipio = new ML.Municipio();
                        usuario1.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                        usuario1.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

                        usuario1.IdUsuario = tablaUsuariosID.IdUsuario;
                        usuario1.Nombre = tablaUsuariosID.NombreUsuario;
                        usuario1.ApellidoPaterno = tablaUsuariosID.ApellidoPaterno;
                        usuario1.ApellidoMaterno = tablaUsuariosID.ApellidoMaterno;
                        usuario1.FechaNacimiento = tablaUsuariosID.FechaNacimiento;
                        usuario1.Rol = new ML.Rol();
                        usuario1.Rol.IdRol = tablaUsuariosID.IdRol.Value;
                        usuario1.UserName = tablaUsuariosID.UserName;
                        usuario1.Email = tablaUsuariosID.Email;
                        usuario1.password = tablaUsuariosID.password;
                        usuario1.Sexo = tablaUsuariosID.Sexo;
                        usuario1.Telefono = tablaUsuariosID.Telefono;
                        usuario1.Celular = tablaUsuariosID.Celular;
                        usuario1.Rol.Nombre = tablaUsuariosID.NombreRol;
                        usuario1.CURP = tablaUsuariosID.CURP;
                        usuario1.Rol.Nombre = tablaUsuariosID.NombreRol;
                        usuario1.Direccion.IdDireccion = tablaUsuariosID.IdDireccion;
                        usuario1.Direccion.Calle = tablaUsuariosID.Calle;
                        usuario1.Direccion.NumeroInterior = tablaUsuariosID.NumeroInterior;
                        usuario1.Direccion.NumeroExterior = tablaUsuariosID.NumeroExterior;
                        usuario1.Direccion.Colonia.IdColonia = tablaUsuariosID.IdColonia;
                        usuario1.Direccion.Colonia.Nombre = tablaUsuariosID.NombreColonia;
                        usuario1.Direccion.Colonia.Municipio.IdMunicipio = tablaUsuariosID.IdMunicipio;
                        usuario1.Direccion.Colonia.Municipio.Nombre = tablaUsuariosID.NombreMunicipio;
                        usuario1.Direccion.Colonia.Municipio.Estado.IdEstado = tablaUsuariosID.IdEstado;
                        usuario1.Direccion.Colonia.Municipio.Estado.Nombre = tablaUsuariosID.NombreEstado;
                        usuario1.Direccion.Colonia.Municipio.Estado.Pais.IdPais = tablaUsuariosID.IdPais;
                        usuario1.Direccion.Colonia.Municipio.Estado.Pais.Nombre = tablaUsuariosID.NombrePais;
                        usuario1.Imagen = tablaUsuariosID.Imagen;


                        result.Object = usuario1;


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

        //----Metodo cambiar status 
        

        public static ML.Result ChangeStatus(int IdUsuario, bool Status)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {

                    int rowAffected = context.UsuarioChangeStatus(IdUsuario, Status);
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



        //Metodo para validar el login

        public static ML.Result UsuarioGetByEmail(string email)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {
                    var registro = context.UsuarioGetByIdEmail(email).FirstOrDefault();
                    if (registro != null)
                    {

                        ML.Usuario usuario = new ML.Usuario();
                        usuario.Email = registro.Email;
                        usuario.password = registro.password;
                        result.Object = usuario;

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
                result.ErrorMessage = ex.Message;
            }
            return result;

        }

        //----------------------Metodos para leer excel-------------
        public static ML.Result LeerExcel(string connectionString)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (OleDbConnection context = new OleDbConnection(connectionString))
                {
                    string query = "SELECT * FROM [Sheet1$]";
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;

                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = cmd;

                        DataTable tableUsuario = new DataTable();

                        da.Fill(tableUsuario);

                        if (tableUsuario.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();

                            foreach (DataRow row in tableUsuario.Rows)
                            {
                                ML.Usuario usuario = new ML.Usuario();
                                usuario.Direccion = new ML.Direccion();
                                usuario.Direccion.Colonia = new ML.Colonia();
                                usuario.Nombre = row[0].ToString();
                                usuario.ApellidoPaterno = row[1].ToString();
                                usuario.ApellidoMaterno = row[2].ToString();
                                usuario.FechaNacimiento = DateTime.Parse(row[3].ToString());
                                usuario.Rol = new ML.Rol();
                                usuario.Rol.IdRol = int.Parse(row[4].ToString());
                                usuario.UserName = row[5].ToString();
                                usuario.Email = row[6].ToString();  
                                usuario.password = row[7].ToString();   
                                usuario.Sexo = row[8].ToString();   
                                usuario.Telefono = row[9].ToString();
                                usuario.Celular = row[10].ToString();
                                usuario.CURP = row[11].ToString();
                                usuario.Direccion.Colonia.IdColonia = int.Parse(row[12].ToString());
                                usuario.Direccion.Calle = row[13].ToString();
                                usuario.Direccion.NumeroInterior = row[14].ToString();
                                usuario.Direccion.NumeroExterior = row[15].ToString();

                                result.Objects.Add(usuario);
                            }
                            result.Correct = true;

                        }

                        result.Object = tableUsuario;

                        if (tableUsuario.Rows.Count > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "No existen registros en el excel";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }

            return result;

        }
        public static ML.Result ValidarExcel(List<object> usuarios)
        {
            ML.Result result = new ML.Result();

            try
            {
                result.Objects = new List<object>(); //almacena los registros incompletos
                int i = 1; //guarda el numero de la fila
                foreach (ML.Usuario usuario in usuarios)
                {
                    ML.ErrorExcel error = new ML.ErrorExcel();
                    error.IdRegistro = i++;

                    if (usuario.Nombre == "")
                    {
                        error.Mensaje += "Ingresar el nombre  ";
                    }
                    if (usuario.ApellidoPaterno == "")
                    {
                        error.Mensaje += "Ingresar el Apellido paterno  ";
                    }
                    if (usuario.ApellidoMaterno == "")
                    {
                        error.Mensaje += "Ingresar el Apellido materno  ";
                    }
                    if (usuario.FechaNacimiento == null)
                    {
                        error.Mensaje += "Ingresa la fecha de nacimiento ";
                    }
                    if (usuario.Rol.IdRol == null)
                    {
                        error.Mensaje += "Ingresa el IdRol ";
                    }
                    if (usuario.UserName == null)
                    {
                        error.Mensaje += "Ingresa el nombre de usuario ";
                    }
                    if (usuario.Email == null)
                    {
                        error.Mensaje += "Ingresa el email ";
                    }
                    if (usuario.password == null)
                    {
                        error.Mensaje += "Ingresa la contraseña ";
                    }
                    if (usuario.Sexo == null)
                    {
                        error.Mensaje += "Ingresa el sexo ";
                    }
                    if (usuario.Telefono == null)
                    {
                        error.Mensaje += "Ingresa el telefono ";
                    }
                    if (usuario.Celular == null)
                    {
                        error.Mensaje += "Ingresa el celular ";
                    }
                    if (usuario.CURP == null)
                    {
                        error.Mensaje += "Ingresa la CURP";
                    }
                    if (usuario.Direccion.Colonia.IdColonia == null)
                    {
                        error.Mensaje += "Ingresa el IdColonia ";
                    }
                    if (usuario.Direccion.Calle == null)
                    {
                        error.Mensaje += "Ingresa la calle ";
                    }
                    if (usuario.Direccion.NumeroInterior == null)
                    {
                        error.Mensaje += "Ingresa el numero interior ";
                    }
                    if (usuario.Direccion.NumeroExterior == null)
                    {
                        error.Mensaje += "Ingresa el numero exterior";
                    }

                    if (error.Mensaje != null)
                    {
                        result.Objects.Add(error);
                    }


                }
                result.Correct = true;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }

            return result;
        }



























//Metodos utilizando LINQ
//----------------------Metodo ADD-------------

public static ML.Result AddLINQ(ML.Usuario usuario)
        {
            Result result = new Result();
            try
            {
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {

                    DL_EF.USUARIO usuario1 = new DL_EF.USUARIO();

                    usuario1.Nombre = usuario.Nombre;
                    usuario1.ApellidoPaterno = usuario.ApellidoPaterno;
                    usuario1.ApellidoMaterno = usuario.ApellidoMaterno;
                    usuario1.FechaNacimiento = usuario.FechaNacimiento;
                    usuario1.IdRol = usuario.Rol.IdRol;
                    usuario1.UserName = usuario.UserName;
                    usuario1.Email = usuario.Email;
                    usuario1.password = usuario.password;
                    usuario1.Sexo = usuario.Sexo;
                    usuario1.Telefono = usuario.Telefono;
                    usuario1.Celular = usuario.Celular;
                    usuario1.CURP = usuario.CURP;   
                    
                    context.USUARIOs.Add(usuario1);
                   
                    context.SaveChanges();
                    result.Correct = true;
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
        public static ML.Result UpdateLINQ(ML.Usuario usuario)
        {
            Result result = new Result();

            try
            {
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {
                    var query = (from a in context.USUARIOs
                                 where a.IdUsuario == usuario.IdUsuario
                                 select a).SingleOrDefault();

                    if (query != null)
                    {
                        query.Nombre = usuario.Nombre;
                        query.ApellidoPaterno = usuario.ApellidoPaterno;
                        query.ApellidoMaterno = usuario.ApellidoMaterno;
                        query.FechaNacimiento = usuario.FechaNacimiento;
                        query.IdRol = usuario.Rol.IdRol;
                        query.UserName = usuario.UserName;
                        query.Email = usuario.Email;
                        query.password = usuario.password;
                        query.Sexo = usuario.Sexo;
                        query.Telefono = usuario.Telefono;
                        query.Celular = usuario.Celular;
                        query.CURP = usuario.CURP;




                        context.SaveChanges();

                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontró el usuario";
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

        public static ML.Result DeleteLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {
                    var query = (from a in context.USUARIOs
                                 where a.IdUsuario == usuario.IdUsuario
                                 select a).First();

                    context.USUARIOs.Remove(query);
                    context.SaveChanges();
                }
                result.Correct = true;


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

        public static ML.Result GetAllLINQ()
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {
                    var usuariosLINQ = (from objUsuario in context.USUARIOs join Rol in context.Rols on objUsuario.IdRol equals Rol.IdRol 
                                        select new { IdUsuario = objUsuario.IdUsuario,
                                        NombreUsuario = objUsuario.Nombre,
                                        ApellidoPaterno = objUsuario.ApellidoPaterno,
                                        ApellidoMaterno = objUsuario.ApellidoMaterno,
                                        FechaNacimineto = objUsuario.FechaNacimiento,
                                        IdRol = Rol.IdRol,
                                        NombreRol = Rol.Nombre,
                                        UserName = objUsuario.UserName,
                                        Email = objUsuario.Email,
                                        contraseña = objUsuario.password,
                                        Sexo = objUsuario.Sexo,
                                        Telefono = objUsuario.Telefono,
                                        Celular = objUsuario.Celular,
                                            CURP = objUsuario.CURP}).ToList();

                    result.Objects = new List<object>();
                    if (usuariosLINQ != null && usuariosLINQ.ToList().Count > 0)
                    {

                        foreach (var obj in usuariosLINQ)
                        {
                            ML.Usuario usuario1 = new ML.Usuario();
                        

                            usuario1.Nombre = obj.NombreUsuario;
                            usuario1.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario1.ApellidoMaterno = obj.ApellidoMaterno;
                            usuario1.FechaNacimiento = obj.FechaNacimineto;
                            usuario1.Rol = new ML.Rol();
                            usuario1.Rol.IdRol = obj.IdRol;
                            usuario1.Rol.Nombre = obj.NombreRol;
                            usuario1.UserName = obj.UserName;
                            usuario1.Email = obj.Email;
                            usuario1.password = obj.contraseña;
                            usuario1.Sexo = obj.Sexo;
                            usuario1.Telefono = obj.Telefono;
                            usuario1.Celular = obj.Celular;
                            usuario1.CURP = obj.CURP;
                            result.Objects.Add(usuario1);
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


        //----------------------Metodo select By Id-------------

        public static ML.Result GetByIdLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.JAlarconProgramacionNCapasEntities context = new DL_EF.JAlarconProgramacionNCapasEntities())
                {
                    var usuariosLINQ = (from objUsuario in context.USUARIOs
                                        join Rol in context.Rols on objUsuario.IdRol equals Rol.IdRol
                                        where objUsuario.IdUsuario == usuario.IdUsuario
                                        select new
                                        {
                                            IdUsuario = objUsuario.IdUsuario,
                                            NombreUsuario = objUsuario.Nombre,
                                            ApellidoPaterno = objUsuario.ApellidoPaterno,
                                            ApellidoMaterno = objUsuario.ApellidoMaterno,
                                            FechaNacimineto = objUsuario.FechaNacimiento,
                                            IdRol = Rol.IdRol,
                                            NombreRol = Rol.Nombre,
                                            UserName = objUsuario.UserName,
                                            Email = objUsuario.Email,
                                            contraseña = objUsuario.password,
                                            Sexo = objUsuario.Sexo,
                                            Telefono = objUsuario.Telefono,
                                            Celular = objUsuario.Celular,
                                            CURP = objUsuario.CURP
                                        }).Single();

                    result.Objects = new List<object>();
                    if (usuariosLINQ != null)
                    {


                             ML.Usuario usuario1 = new ML.Usuario();
                            usuario1.Nombre = usuariosLINQ.NombreUsuario;
                            usuario1.ApellidoPaterno = usuariosLINQ.ApellidoPaterno;
                            usuario1.ApellidoMaterno = usuariosLINQ.ApellidoMaterno;
                            usuario1.FechaNacimiento = usuariosLINQ.FechaNacimineto;
                            usuario1.Rol = new ML.Rol();
                            usuario1.Rol.IdRol = usuariosLINQ.IdRol;
                            usuario1.Rol.Nombre = usuariosLINQ.NombreRol;
                            usuario1.UserName = usuariosLINQ.UserName;
                            usuario1.Email = usuariosLINQ.Email;
                            usuario1.password = usuariosLINQ.contraseña;
                            usuario1.Sexo = usuariosLINQ.Sexo;
                            usuario1.Telefono = usuariosLINQ.Telefono;
                            usuario1.Celular = usuariosLINQ.Celular;
                            usuario1.CURP = usuariosLINQ.CURP;
                        result.Object = usuario1;

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
