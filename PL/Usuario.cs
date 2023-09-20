using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PL
{
    public class Usuario
    {
        public static void Add()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el nombre del nuevo usuario");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el apellido paterno");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa el apellido materno");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa la fecha de nacimiento");
            usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el rol del usuario");
            usuario.Rol = new ML.Rol();
            usuario.Rol.IdRol = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el User name del usuario");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingresa el Email del usuario");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingresa la contraseña del usuario");
            usuario.password = Console.ReadLine();

            Console.WriteLine("Ingresa el sexo del usuario");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingresa el telefono del usuario");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingresa el celular del usuario");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("Ingresa la CURP del usuario");
            usuario.CURP = Console.ReadLine();

            ML.Result result = BL.Usuario.AddLINQ(usuario); 

            if (result.Correct){
                Console.WriteLine("Usuario agregado exitosamente");
            }else{
                Console.WriteLine("Usuario no agregado" + result.ErrorMessage);
            }
          
        }


        public static void Update()
        {
            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Actualizar usuario");

            Console.WriteLine("Ingresa el nuevo ID del usuario");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el nombre del nuevo usuario");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el apellido paterno");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa el apellido materno");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa la fecha de nacimiento");
            usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el rol del usuario");
            usuario.Rol = new ML.Rol();
            usuario.Rol.IdRol = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el User name del usuario");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingresa el Email del usuario");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingresa la contraseña del usuario");
            usuario.password = Console.ReadLine();

            Console.WriteLine("Ingresa el sexo del usuario");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingresa el telefono del usuario");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingresa el celular del usuario");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("Ingresa la CURP del usuario");
            usuario.CURP = Console.ReadLine();

            ML.Result result = BL.Usuario.UpdateLINQ(usuario);

            if (result.Correct)
            {
                Console.WriteLine("Usuario actualizado exitosamente");
            }
            else
            {
                Console.WriteLine("Usuario no actualizado" + result.ErrorMessage);
            }

        }



        public static void Delete()
        {
            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Borrar usuario");

            Console.WriteLine("Ingresa el ID del usuario que desea borrar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.DeleteLINQ(usuario);

            if (result.Correct)
            {
                Console.WriteLine("Usuario borrado correctamente");
            }
            else
            {
                Console.WriteLine("Error al borrar usuario" + result.ErrorMessage);
            }

        }


        public static void GetAll()
        {
            ML.Result result = BL.Usuario.GetAllLINQ();

            Console.WriteLine("Select * ");


            if (result.Correct)
            {

                foreach (ML.Usuario usuario1 in result.Objects)
                {
                    

                    Console.WriteLine("El nombre del usuario es: " + usuario1.Nombre);
                    Console.WriteLine("El apellido paterno del usuario es: " + usuario1.ApellidoPaterno);
                    Console.WriteLine("El apellido materno del usuario es: " + usuario1.ApellidoMaterno);
                    Console.WriteLine("La estatura del usuario es: " + usuario1.FechaNacimiento);
                    Console.WriteLine("El rol del usuario es: " + usuario1.Rol.IdRol);
                    Console.WriteLine("El UserName del usuraio es: " + usuario1.UserName);
                    Console.WriteLine("El Email del usuraio es: " + usuario1.Email);
                    Console.WriteLine("La contraseña del usuario es: " + usuario1.password);
                    Console.WriteLine("El sexo del usuario es: " + usuario1.Sexo);
                    Console.WriteLine("El telefono del usuario es: " + usuario1.Telefono);
                    Console.WriteLine("El celular del usuario es: " + usuario1.Celular);
                    Console.WriteLine("La CURP del usuario es: " + usuario1.CURP);
                    Console.WriteLine("El nombre del rol es: " + usuario1.Rol.Nombre);
                    Console.WriteLine("---------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine("Error al mostrar" + result.ErrorMessage);
            }

        }

        public static void GetById()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el ID del usuario para buscarlo");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.GetByIdLINQ(usuario);



            if (result.Correct)
            {

                ML.Usuario usuario1 = (ML.Usuario)result.Object;  //unboxing
                Console.WriteLine("El nombre del usuario es: " + usuario1.Nombre);
                Console.WriteLine("El apellido paterno del usuario es: " + usuario1.ApellidoPaterno);
                Console.WriteLine("El apellido materno del usuario es: " + usuario1.ApellidoMaterno);
                Console.WriteLine("La estatura del usuario es: " + usuario1.FechaNacimiento);
                Console.WriteLine("El rol del usuario es: " + usuario1.Rol.IdRol);
                Console.WriteLine("El UserName del usuraio es: " + usuario1.UserName);
                Console.WriteLine("El Email del usuraio es: " + usuario1.Email);
                Console.WriteLine("La contraseña del usuario es: " + usuario1.password);
                Console.WriteLine("El sexo del usuario es: " + usuario1.Sexo);
                Console.WriteLine("El telefono del usuario es: " + usuario1.Telefono);
                Console.WriteLine("El celular del usuario es: " + usuario1.Celular);
                Console.WriteLine("La CURP del usuario es: " + usuario1.CURP);
                Console.WriteLine("El nombre del rol es: " + usuario1.Rol.Nombre);
                Console.WriteLine("---------------------------------------------------------------------");


            }
            else
            {
                Console.WriteLine("Error al mostrar" + result.ErrorMessage);
            }

        }






    }
}
