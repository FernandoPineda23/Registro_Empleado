using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_23CV.Entities
{
    public class Empleado
    {
        [Key]
        public int PKEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Correo { get; set; }


    }
}
