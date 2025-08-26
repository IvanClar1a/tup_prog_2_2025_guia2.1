using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2._1Ejercicio1
{
    internal class Persona
    {
        public int dni {  get; set; }
        public string nombre { get; set; }

        public Persona(int dni, string nombre) { 
            
            this.dni = dni;
            this.nombre = nombre;
        }

    }
}
