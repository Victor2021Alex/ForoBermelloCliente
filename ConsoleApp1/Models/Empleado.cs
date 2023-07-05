using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public string fechaNacimiento { get; set; }
        public Boolean estado { get; set; }

        public EmpleadoAddress EmpleadoAddress { get; set; }
    }
}
