using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace FFBatch
{    
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.        
        /// </summary>
        

        [STAThread]
        static void Main()
        {   
            using (Mutex mutex = new Mutex(false, "Global\\" + appGuid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show(Properties.Strings.app_err + " (already running)");
                    return;
                }

                Application.SetCompatibleTextRenderingDefault(false);
                //Application.EnableVisualStyles();
                //if (Environment.GetCommandLineArgs().Count() == 1)
                //{

                //}

                Application.Run(new Form1());
            }
        }

        private static string appGuid = "01c90e3d-419d-4bf5-9fcc-fcebe6b16840";
    }

    internal class SingleInstanceApp : WindowsFormsApplicationBase
    {
        public SingleInstanceApp()
            : base()
        {
            this.IsSingleInstance = true;
        }    

    }
}