using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmSplash vsp = new frmSplash();
            if(vsp.ShowDialog()==DialogResult.OK)
            {
                Application.Run(new frmLogin());
            }
            //Application.Run(new frmSplash());
        }
    }
}
