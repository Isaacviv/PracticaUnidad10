using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Unidad10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string nombre = tNombre.Text;
            string apellidos = tApellidos.Text;
            string telefono = tTelefono.Text;
            string socio = nombre + " " + apellidos + " " + telefono;
            tListaSocios.Text += socio + "\r\n";
        }

        private void tNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void tListaSocios_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
