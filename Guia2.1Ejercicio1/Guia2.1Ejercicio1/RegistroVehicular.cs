using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2._1Ejercicio1
{
    internal class RegistroVehicular
    {
        public string patente {  get; set; }
        public string serie { get; set; }
        public Persona propietario { get;  }
        public RegistroVehicular(string patente, Persona propietario, string serie)
        {
            this.patente = patente;
            this.propietario = propietario;
            this.serie = serie;
        }

        public string verDetalle(){

            return $" Patente {patente} - Serie: {serie} - Propietario:  - {propietario.nombre} - (DNI: {propietario.dni})";
        }
        
    }
}
