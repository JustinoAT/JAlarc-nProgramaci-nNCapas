using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Departamento
    {

        public int IdDepartamento { get; set; } //int
        public string Nombre { get; set; } //varchar
        public int IdArea { get; set; } //int
        public List<object> Departamentos { get; set; }
        public ML.Area Area { get; set; }

    }
}
