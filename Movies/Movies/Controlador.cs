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
    public class Controlador
    {
        public BindingList<string> buscar(string texto, BaseDeDatos bdd)
        {
            BindingList<string> lista = new BindingList<string>();
            texto = texto.ToLower();
            foreach (Pelicula pelicula in bdd.peliculas)
            {
                if (lista.Count == 50) { return lista; }
                try
                {
                    if (pelicula.Nombre.ToLower().Contains(texto) || pelicula.Descripcion.ToLower().Contains(texto))
                    {
                        lista.Add("PELICULA  - " + pelicula.Nombre + " " + pelicula.Descripcion);
                    }
                }
                catch { }
            }
            foreach (Estudio estudio in bdd.estudios)
            {
                if (lista.Count == 50) { return lista; }
                try
                {
                    if (estudio.Nombre.ToLower().Contains(texto) || estudio.Direccion.ToLower().Contains(texto))
                    {
                        lista.Add("ESTUDIO  - " + estudio.Nombre + " " + estudio.Direccion);
                    }

                }
                catch { }
            }
            foreach (Persona persona in bdd.personas)
            {
                if (lista.Count == 50) { return lista; }
                try
                {
                    if (persona.Nombre.ToLower().Contains(texto) || persona.Apellido.ToLower().Contains(texto))
                    {
                        lista.Add("PERSONA  - " + persona.Nombre + " " + persona.Apellido);
                    }

                }
                catch { }
            }
            return lista;


        }
        public BindingList<Critica> devolverCriticas(BaseDeDatos bdd, string pelicula)
        {
            BindingList<Critica> lista = new BindingList<Critica>();
            foreach (Critica critica in bdd.criticas)
            {
                if (critica.Pelicula.Nombre == pelicula)
                {
                    lista.Add(critica);

                }
            }
            return lista;
        }











        ////// NO ERA NECESARIA ESTA PARTE, PERO IGUAL LA DEJO

        //foreach (char letra in pelicula.Nombre.ToLower())
        //{
        //    foreach (char letraTexto in texto)
        //    {
        //        if (letra == letraTexto)
        //        {
        //            lista.Add(pelicula.Nombre); goto BREAKPEL;
        //        }
        //    }
        //    //if (pelicula.Nombre.ToLower() == texto || pelicula.Descripcion.ToLower() == texto || pelicula.Presupuesto == Convert.ToInt32(texto))
        //    //{
        //    //    lista.Add(pelicula.Nombre);
        //    //}
        //}
        //BREAKPEL:;

        //if (estudio.Nombre.ToLower() == texto || estudio.Direccion.ToLower() == texto)
        //{ lista.Add(estudio.Nombre + " " + estudio.Direccion); }

        //if (persona.Nombre.ToLower() == texto || persona.Apellido.ToLower() == texto)
        //{ lista.Add(persona.Nombre + " " + persona.Apellido); }

        //foreach (PeliculaActor actor in bdd.peliculasActor)
        //{
        //    try
        //    {
        //        if (actor.Actor.Apellido.ToLower()== texto || actor.Actor.Biografia.ToLower() == texto || actor.Actor.FechaNacimiento == Convert.ToDateTime(texto) || actor.Actor.Nombre.ToLower() == texto)
        //        { lista.Add(actor.Actor.Nombre+" " + actor.Actor.Apellido); }
        //    }
        //    catch { }
        //}
        //foreach (PeliculaProductor productor in bdd.peliculasProductor)
        //{
        //    try
        //    {
        //        if (productor.Persona.Nombre.ToLower() == texto || productor.Persona.Apellido.ToLower() == texto)
        //        { lista.Add(productor.Persona.Nombre+" " + productor.Persona.Apellido); }
        //    }
        //    catch { }
        //}
    }

}
