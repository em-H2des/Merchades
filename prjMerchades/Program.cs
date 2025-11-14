using Merchades;
using prjMerchades.Formularios;
using prjMerchades.Formularios.Entrada;
using prjMerchades.Formularios.Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMerchades
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()  
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmRelFinanceiro());
        }
    }
}
