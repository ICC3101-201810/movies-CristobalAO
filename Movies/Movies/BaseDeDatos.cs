using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;
namespace Movies
{
    [Serializable]

    public class BaseDeDatos
    {
        public BindingList<Pelicula> peliculas;
        public BindingList<PeliculaActor> peliculasActor;
        public BindingList<PeliculaProductor> peliculasProductor;
        public BindingList<Persona> personas;
        public BindingList<Estudio> estudios;
        public BindingList<Critica> criticas;

        public BaseDeDatos()
        {
            peliculas = new BindingList<Pelicula>();
            peliculasActor = new BindingList<PeliculaActor>();
            peliculasProductor = new BindingList<PeliculaProductor>();
            personas = new BindingList<Persona>();
            estudios = new BindingList<Estudio>();
            criticas = new BindingList<Critica>();
        }
    }
}
