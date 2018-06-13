using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]

    public class PeliculaActor
    {
        private Pelicula pelicula;
        private Actor actor;

        public Pelicula Pelicula { get => pelicula; set => pelicula = value; }
        public Actor Actor { get => actor; set => actor = value; }

        public PeliculaActor(Pelicula pelicula, Actor actor)
        {
            this.Pelicula = pelicula;
            this.Actor = actor;
        }
    }
}
