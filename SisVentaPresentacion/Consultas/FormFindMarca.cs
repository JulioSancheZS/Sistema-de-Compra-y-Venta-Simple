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
    public partial class FormFindMarca : Form
    {
        MarcaDAO oMarcaDao = new MarcaDAO();

        public FormFindMarca()
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
            DgvFindMarca.DataSource = oMarcaDao.BusquedaMarca(TxtNombre.Text);
        }

        private void FormFindMarca_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
