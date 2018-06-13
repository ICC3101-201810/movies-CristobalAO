using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]

    public class Estudio
    {
        private string direccion;
        private DateTime fechaApertura;
        private string nombre;

        public Estudio(string nombre, string direccion, DateTime fechaApertura)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.FechaApertura = fechaApertura;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaApertura { get => fechaApertura; set => fechaApertura = value; }
    }
}
