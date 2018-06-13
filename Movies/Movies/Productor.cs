using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]

    public class Productor :Persona
    {
        public Productor(string nombre, string apellido, string biografia, DateTime fechaNacimiento) : base(nombre, apellido, biografia, fechaNacimiento)
        {
            this.Tipo = "productor";
        }
    }
}
