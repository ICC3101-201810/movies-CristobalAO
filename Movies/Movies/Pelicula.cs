using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]

    public class Pelicula
    {
        private string descripcion;
        private int presupuesto;
        Director Director;
        private DateTime fechaEstreno;
        private Estudio estudio;
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Presupuesto { get => presupuesto; set => presupuesto = value; }
        public Director Director1 { get => Director; set => Director = value; }
        public DateTime FechaEstreno { get => fechaEstreno; set => fechaEstreno = value; }
        public Estudio Estudio { get => estudio; set => estudio = value; }

        public Pelicula(string nombre, Director director, string descripcion, int presupuesto, DateTime fechaEstreno, Estudio estudio)
        {
            Nombre = nombre;
            Director1 = director;
            Descripcion = descripcion;
            Presupuesto = presupuesto;
            FechaEstreno = fechaEstreno;
            this.Estudio = estudio;
        }
    }
}
