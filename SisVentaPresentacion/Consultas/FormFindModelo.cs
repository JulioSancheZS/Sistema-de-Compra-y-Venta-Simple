using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisVentaDAO;
using SIsEDM;
using SIsEDM.Modelo;

namespace SisVentaPresentacion.Consultas
{
    public partial class FormFindModelo : Form
    {
        ModeloDAO oModeloDAO = new ModeloDAO();

        public FormFindModelo()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            DgvFindModelo.DataSource = oModeloDAO.BusquedaModelo(TxtNombre.Text);
        }

        private void FormFindModelo_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
