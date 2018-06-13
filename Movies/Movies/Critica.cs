using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]
    public class Critica
    {
        private string critica;
        private Pelicula pelicula;
        private Persona persona;

        public string Criticaa { get => critica; set => critica = value; }
        public Pelicula Pelicula { get => pelicula; set => pelicula = value; }
        public Persona Persona { get => persona; set => persona = value; }

        public Critica(string critica, Pelicula pelicula, Persona persona)
        {
            this.Criticaa = critica;
            this.Pelicula = pelicula;
            this.Persona = persona;
        }
    }
}
