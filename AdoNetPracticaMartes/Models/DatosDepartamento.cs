using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNetPracticaMartes.Models
{
    public class DatosDepartamento
    {
        public int DeptNo { get; set; }
        public string NombreDepartamento { get; set; }

        public string Localidad { get; set; }

        public List<string> Empleados { get; set; }

        public DatosDepartamento()
        {
            this.Empleados = new List<string>();
        }
    }
}
