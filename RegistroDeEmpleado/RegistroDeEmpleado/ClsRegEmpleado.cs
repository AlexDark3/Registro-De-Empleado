using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeEmpleado
{
    public class ClsRegEmpleado
    {
      
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public DateTime Fecha { get; set; } = new DateTime(1990, 1, 1);
            public string Edad { get; set; }
            public string Cargo { get; set; }
            public string Sueldo { get; set; }
            public string Tipo { get; set; }

    }
}