using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2._1Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        DepartamentoVehicular miDepartamento = new DepartamentoVehicular();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            formRegistro registrarPersona = new formRegistro();

            
            if (registrarPersona.ShowDialog() == DialogResult.OK)
            {
                int dni = Convert.ToInt32(registrarPersona.tbDni.Text);
                string nombre = registrarPersona.tbNombre.Text;
                Persona nueva = new Persona(dni,nombre);
                
                miDepartamento.RegistrarVehicular(nueva);
            } 
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (RegistroVehicular r in miDepartamento.listar() )
            {
                listBox2.Items.Add(r.verDetalle());
            }
        }
    }
}
