namespace ProyectoGit2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio del Proyecto");
            Console.WriteLine("Proyeccto para la administracion de empleados");
            Console.WriteLine("------------------MENU-----------------------");
            Console.WriteLine("\t 1) Agregar Empleado: ");
            Console.WriteLine("\t 2) Listado de Empleados: ");
            Console.WriteLine("\t 3) Salir: ");
            Console.WriteLine("Seleccione una Opcion: ");
            char Opcion = Char.Parse(Console.ReadLine());
            switch(Opcion)
            {
                case '1':
                    Console.WriteLine("------------Agregar Empleado--------------");
                    break;
                case '2':
                    Console.WriteLine("------------Listado Empleados--------------");
                    break;
                case '3':
                    Console.WriteLine("------------Saliendo, Adios--------------");
                    break;
                default: 
                    Console.WriteLine("Opcion invalida");
                    break;
            }

        }
    }
}