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
                    Console.WriteLine("------------Agregar Nuevo Empleado--------------");
                    Console.WriteLine("Ingrese el Nombre del Empleado: ");
                    string Nombre=Console.ReadLine();
                    Console.WriteLine("Ingrese el genero del Empleado: ");
                    string Genero=Console.ReadLine();
                    Console.WriteLine("Ingrese el Salario Base del Empleado");
                    double Salario=double.Parse(Console.ReadLine());
                    Console.WriteLine("Seleccione el tipo del Empleado a Crear: ");
                    Console.WriteLine("\t 1) Gerente: ");
                    Console.WriteLine("\t 2) Vendedor: ");
                    Console.WriteLine("Tipo: ");
                    char TipoEmpleado=char.Parse(Console.ReadLine());
                    switch(TipoEmpleado)
                    {
                        case '1':
                            Console.WriteLine("Ingrese el puesto del Gerente: ");
                            string Puesto=Console.ReadLine();
                            Gerente gerente = new Gerente("Gerente: ",Nombre, Salario, Genero, Puesto);
                            Console.WriteLine("Hemos creado un nuevo Gerente");
                            Console.WriteLine("Deseas crear un nuevo empleado?");
                            break;
                        case '2':
                            
                            foreach (var ger in Gerente)
                            {
                                Console.Write(ger.Nombre);
                                Console.WriteLine(ger.TipoEmpleado);
                                Console.WriteLine(ger.PuestoGerente);
                                Console.WriteLine(ger.CalcularSalario());
                            }
                            break;
                        default:
                            Console.WriteLine("Tipo Invalido");
                            break;
                    }
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