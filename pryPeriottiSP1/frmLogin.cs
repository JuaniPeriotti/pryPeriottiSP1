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

namespace pryPeriottiSP1
{
    public partial class frmLogin : Form
    {
        int intentos;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblContrasena_Click(object sender, EventArgs e)
        {

        }

        private void mrcIniciarSesion_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            string modulo = lstModulo.Text;
            frmBienvenido bienvenido = new frmBienvenido();
            if (usuario == "Adm")
            {
                if (contrasena == "@1a" && (modulo == "ADM" || modulo == "COM" || modulo == "VTA"))
                {
                    this.Hide();
                    bienvenido.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Los datos ingresados son incorrectos, intente nuevamente.");
                    intentos++;
                }
            }
            else
            {
                if (usuario == "John")
                {
                    if (contrasena == "*2b" && (modulo == "SIST"))
                    {
                        this.Hide();
                        bienvenido.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Los datos ingresados son incorrectos, intente nuevamente.");
                        intentos++;
                    }
                }
            if (usuario == "Ceci")
            {
                if (contrasena == "*@3c" && (modulo == "ADM" || modulo == "VTA"))
                {
                    this.Hide() ;
                    bienvenido.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Los datos ingresados son incorrectos, intente nuevamente.");
                    intentos++;
                }
            }
            else
            {
                if(usuario =="God")
                    {
                        if (contrasena == "*@#4d" && (modulo == "ADM" || modulo == "COM" || modulo == "VTA" || modulo == "SIST"))
                        {
                            this.Hide();
                            bienvenido.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Los datos ingresados son incorrectos, intente nuevamente.");
                            intentos++;
                        }
                    }
            }
            if (intentos == 2)
            {
                MessageBox.Show("Demadiados intentos erroneos. Vuelva a ejecutar el programa");
                this.Close();
            }
            }
        }
    }
}
