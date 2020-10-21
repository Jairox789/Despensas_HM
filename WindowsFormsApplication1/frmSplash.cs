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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            tmrTiempo.Interval = 3000;

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            tmrTiempo.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
