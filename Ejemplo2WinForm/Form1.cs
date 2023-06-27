using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
            txtApellido.BackColor = Color.Red;
            txtNombre.BackColor = Color.Red;
            txtEdad.BackColor = Color.Red;
            txtDireccion.BackColor = Color.Red;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau... Chau...");
            this.BackColor = SystemColors.GrayText;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            string direccion = txtDireccion.Text;
   
            lwResultado.Items.Add("Apellido y Nombre: " + apellido + "  " + nombre);
            lwResultado.Items.Add("Edad: " + edad);
            lwResultado.Items.Add("Direccion: " + direccion);
            MessageBox.Show("CARGA EXITOSA");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            MessageBox.Show("GRACIAS POR USAR NUESTRA APP");
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            else
                txtEdad.BackColor = System.Drawing.SystemColors.ControlText;

            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.ControlText;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.ControlText;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;
            else
                txtDireccion.BackColor = System.Drawing.SystemColors.ControlText;
        }
    }
}
