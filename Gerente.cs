using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGit2023
{
     class Gerente:Empleado
    {
        private const double BONO_GERENTE = 0.15;
        public Gerente()
        {

        }
        public Gerente(string tipoEmpleado, string nombre, double salario)
        {
            Salario = salario;
            Nombre = nombre;
            TipoEmpleado = tipoEmpleado;
        }
        public override double CalcularSalario()
        {
            double BonoIncentivo = Salario * 0.05;
            double BonoGerente = Salario * BONO_GERENTE;
            return Salario + BonoIncentivo + BonoGerente;
        }

    }
}
