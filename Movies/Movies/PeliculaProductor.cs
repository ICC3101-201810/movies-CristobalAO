using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]

    public class PeliculaProductor
    {
        private Pelicula pelicula;
        private Productor persona;

        public Pelicula Pelicula { get => pelicula; set => pelicula = value; }
        public Productor Persona { get => persona; set => persona = value; }

        public PeliculaProductor(Pelicula pelicula, Productor persona)
        {
            this.Pelicula = pelicula;
            this.Persona = persona;
        }
    }
}
