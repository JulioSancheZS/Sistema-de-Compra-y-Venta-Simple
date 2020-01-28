using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisVentaDAO;
using SIsEDM;
using SIsEDM.Modelo;

namespace SisVentaPresentacion.Listados
{
    public partial class FromListaEmpleado : Form
    {
        private EmpleadoDAO oEmpleadoDAO = new EmpleadoDAO();

        public FromListaEmpleado()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FromListaEmpleado_Load(object sender, EventArgs e)
        {
			//DgvListaEmpleado.DataSource = oEmpleadoDAO.ListaEmpleado();
			DgvListaEmpleado.DataSource = oEmpleadoDAO.ListaEmpleados();
		}
	}
}
