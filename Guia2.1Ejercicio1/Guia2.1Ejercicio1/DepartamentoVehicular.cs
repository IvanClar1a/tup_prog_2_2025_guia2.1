using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2._1Ejercicio1
{
    internal class DepartamentoVehicular
    {
        private ArrayList registro;
        public int cantidadRegistro {  get; set; }
        public int cantidadSerie { get; set; }
        
        public DepartamentoVehicular()
        {
            registro = new ArrayList();
            cantidadSerie = 0;
        }
        public RegistroVehicular RegistrarVehicular(Persona propietario) 
        {
            string patente = generarPatente();
            string serie = generarSerie();

            RegistroVehicular nuevo = new RegistroVehicular(patente,propietario,serie);
            registro.Add(nuevo);

            return nuevo;
        }
        private string generarPatente()
        {
            return "PAT" + (cantidadRegistro + 1).ToString("000");
        }
        private string generarSerie()
        {
            cantidadSerie++;
            return cantidadSerie.ToString("D9");
        }
        public RegistroVehicular verRegistro (int idx)
        {
            if (idx >= 0 && idx < registro.Count)
            {
                return (RegistroVehicular)registro[idx];
            }
            return null;
        }
        public ArrayList listar()
        {
            return registro;
        }
    }
}
