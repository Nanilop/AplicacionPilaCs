using AplicacionPilaCs.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionPilaCs
{
    public partial class Form1 : Form
    {
        Pila pila = new Pila();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            adverCorreo.Visible = false;
        }

        private void Fecha_ValueChanged(object sender, EventArgs e)
        {
            adverEdad.Visible = false;
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
           Contacto c = new Contacto();
            c.Nombre = txtNombre.Text;
            c.ApellidoPaterno = txtApPat.Text;
            c.ApellidoMaterno = txtApMat.Text;
            c.FechaNacimiento = Fecha.Value;
            c.Telefono = txtTel.Text;
            c.Correo = txtCorreo.Text;
            int no = 0;
            if (!c.IsValidEmail())
            {
                adverCorreo.Visible = true;
                no++;
            }
            if (c.Edad < 18)
            {
                adverEdad.Visible = true;
                no++;
            }
            if (no == 0)
            {
                pila.Push(c);
                no = 0;
                MessageBox.Show("Agregado Correctamente a la pila");
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            Contacto impresion=new Contacto();
            impresion=pila.Pop();
            try
            {
                MessageBox.Show(impresion.ToString());
            }
            catch {
                MessageBox.Show("No hay más contactos en la pila");
            }
        }
    }
}
