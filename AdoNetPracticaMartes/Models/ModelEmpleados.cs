using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNetPracticaMartes.Models
{
    public class ModelEmpleados
    {
        public List<string> Apellido { get; set; }
        public List<string> Especialidad { get; set; }
        public List<int> Salario { get; set; }
        public int SumaSalarial { get; set; }
        public int MediaSalarial { get; set; }
        public int Personas { get; set; }

        public ModelEmpleados()
        {
            this.Apellido = new List<string>();
            this.Especialidad = new List<string>();
            this.Salario = new List<int>();
        }

    }
}
