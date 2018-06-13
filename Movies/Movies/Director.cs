﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]

    public class Director : Persona
    {
        public Director(string nombre, string apellido, string biografia, DateTime fechaNacimiento) : base(nombre, apellido, biografia, fechaNacimiento)
        {
            this.Tipo = "director";
        }
    }
}
