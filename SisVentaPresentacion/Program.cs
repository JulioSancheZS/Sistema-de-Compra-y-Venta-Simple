using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentaPresentacion
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
			//Application.Run(new GestionarUsuario.Login());
		    Application.Run(new FrmMenuPrincipal());
			//Application.Run(new Operaciones.frmDetalleCompra());
			//Application.Run(new Informes.frmReporteUltimaVenta());
			//Application.Run(new Operaciones.frmDetalleCompra());
			//Application.Run(new Reportes.frmReporteUltimaCompra());
		}
    }
}
