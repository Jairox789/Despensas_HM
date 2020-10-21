using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text=="")
            {
                MessageBox.Show("Escriba una contraseña");
            }
            else
            {
                if(txtPassword.Text=="ISC")
                {
                    Form1 inicial = new Form1();
                    inicial.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    txtPassword.Clear();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
