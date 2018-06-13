using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]

    public abstract class Persona
    {
        private string tipo;
        private DateTime fechaNacimiento;
        private string nombre;
        private string apellido;
        private string biografia;

        public Persona(string nombre, string apellido, string biografia, DateTime fechaNacimiento)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Biografia = biografia;
            this.FechaNacimiento = fechaNacimiento;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Biografia { get => biografia; set => biografia = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public static implicit operator string(Persona v)
        {
            throw new NotImplementedException();
        }
    }
}
