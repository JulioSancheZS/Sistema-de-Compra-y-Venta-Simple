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
using SIsEDM;
using SIsEDM.Modelo;
using SisVentaDAO;

namespace SisVentaPresentacion.Catalogos
{
    public partial class FormMantCategoria : Form
    {
        private CategoriaDAO oCategoriaDAO = new CategoriaDAO();
        private bool NuevoRegistro = false;

        public FormMantCategoria()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMantCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCodigo.Text == "" && TxtDescripcion.Text == "")
                {
                    MessageBox.Show("Los campos estan vacios", "llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (NuevoRegistro == true)
                    {
                        Categoria oCategoria = new Categoria();
                        oCategoria.Codigo = TxtCodigo.Text.Trim();
                        oCategoria.Descripcion = TxtDescripcion.Text.Trim();


                        if (oCategoriaDAO.Agregar(oCategoria) == false)
                        {
                            MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtCodigo.Text = "";
                            TxtDescripcion.Text = "";
                            BtnEliminar.Enabled = false;
                            BtnGuardar.Enabled = false;
                            TxtCodigo.Focus();

                            return;
                        }
                    }
                    else
                    {
                        Categoria oCategoria = oCategoriaDAO.Buscar(TxtCodigo.Text.Trim());
                        oCategoria.Descripcion = TxtDescripcion.Text.Trim();

                        if (oCategoriaDAO.Modificar(oCategoria) == false)
                        {
                            MessageBox.Show("El Registro no fue Modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtCodigo.Text = "";
                            TxtDescripcion.Text = "";
                            BtnEliminar.Enabled = false;
                            BtnGuardar.Enabled = false;
                            TxtCodigo.Focus();
                            return;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hola exepcion", ex.Message);
                throw;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria oCategoria = oCategoriaDAO.Buscar(TxtCodigo.Text.Trim());
                if (TxtCodigo.Text == "" && TxtDescripcion.Text == "")
                {
                    MessageBox.Show("Los campos estan vacios", "llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (oCategoriaDAO.Eliminar(oCategoria) == false)
                    {
                        MessageBox.Show("El registro no puede ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    else
                    {
                        MessageBox.Show("El registro eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtCodigo.Text = "";
                        TxtDescripcion.Text = "";
                        return;

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hola exepcion", ex.Message);
                throw;
            }       
        }

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            Categoria oCategoria;
            try
            {
                oCategoria = oCategoriaDAO.Buscar(TxtCodigo.Text.Trim());
                if (oCategoria != null)
                {
                    NuevoRegistro = false;
                    TxtDescripcion.Text = oCategoria.Descripcion.Trim();
                    BtnGuardar.Enabled = true;
                    BtnEliminar.Enabled = true;
                }
                else
                {
                    TxtDescripcion.Text = "";
                    NuevoRegistro = true;
                    BtnGuardar.Enabled = true;
                    BtnEliminar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hola exepcion", ex.Message);
                throw;
            }    
        }
    }
}
