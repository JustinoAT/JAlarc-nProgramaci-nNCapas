using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese el numero de la opcion correspondiente");
            Console.WriteLine("1. metodo agregar");
            Console.WriteLine("2. metodo actualizar usuario");
            Console.WriteLine("3. metodo borrar usuario");
            Console.WriteLine("4. seleccionar todos los registros");
            Console.WriteLine("5. seleccionar registro por id");
            Console.WriteLine("6. salir");


            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("metodo agregar usuario");
                    Usuario.Add();
                    break;
                case 2:
                    Console.WriteLine("metodo actualizar usuario");
                    Usuario.Update();
                    break;
                case 3:
                    Console.WriteLine("metodo borrar usuario");
                    Usuario.Delete();
                    break;
                case 4:
                    Console.WriteLine("metodo seleccionar todo");
                    Usuario.GetAll();
                    break;
                case 5:
                    Console.WriteLine("metodo seleccionar por id");
                    Usuario.GetById();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("el valor ingresado no existe");
                    break;

            }


            Console.ReadKey();  
        }
    }
}
