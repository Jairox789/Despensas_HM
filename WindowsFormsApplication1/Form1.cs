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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Salida del menú
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Evento load
        private void Form1_Load(object sender, EventArgs e)
        {
            tssOpcion.Text = "Ventana Principal";
            tssFecha.Text = DateTime.Now.ToLongDateString();
           
        }
        //Menú hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            tssHora.Text = DateTime.Now.ToLongTimeString();
        }
        //Acerca De
        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcerdaDe acercaD = new frmAcerdaDe();
            acercaD.MdiParent = this;
            acercaD.Show();
        }
        //Entrar a solicitar
        private void solicitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Solicitar Iniciar = new Solicitar();
            Iniciar.MdiParent = this;
            Iniciar.Show();
        }
        //Entrar a registro
        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros Iniciar = new Registros();
            Iniciar.MdiParent = this;
            Iniciar.Show();
        }
    }
}
