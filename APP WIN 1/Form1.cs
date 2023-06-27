using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APP_WIN_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.BackColor = Color.YellowGreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenidos a C#");

            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Chau... Chau...");
        }
 

        private void btnBoton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Clic, ATENCION!");
            //this.BackColor = Color.Blue;
            if (textBox1.Text == "")
                textBox1.BackColor = Color.Red;
            else
                textBox1.BackColor = System.Drawing.SystemColors.Control;

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //MouseEventArgs click = (MouseEventArgs)e;
            //if (click.Button == MouseButtons.Left)
            //    MessageBox.Show("Presiono el boton Isquierdo", "ATENCION");
            //else if (click.Button == MouseButtons.Right)
            //    MessageBox.Show("Preciono el boton Derecho", "ATENCION");
            //else if (click.Button == MouseButtons.Middle)
            //    MessageBox.Show("Preciono el boton del Medio", "ATENCION");
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //this.BackColor = Color.YellowGreen;
            this.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.SystemColors.Control;
            label1.Cursor = Cursors.Arrow;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + textBox2.Text.Length + " Caracteres");
        }
    }
}
