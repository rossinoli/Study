using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateriaisParaConstrucao
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread novaThread = new Thread(new ThreadStart(novoFrmSplash));
            novaThread.Start();
            Thread.Sleep(5700);
            novaThread.Abort();

            frmLogin formularioLogin = new frmLogin();
            formularioLogin.ShowDialog();

            if (formularioLogin.DialogResult == DialogResult.OK)
            {
                Application.Run(new frmPrincipal(formularioLogin.idUsuario));
            }
            else
            {
                Application.Exit();
            }
        }

        static void novoFrmSplash()
        {
            Application.Run(new frmSplash());
        }
    }
}
