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
    public partial class FormMantDatos : Form
    {
        private DatosDAO oDatosDAO = new DatosDAO();
        private bool NuevoRegistro = false;

        public FormMantDatos()
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCodigo.Text == "" || TxtNombre.Text == "" || TxtApellido.Text == "" || TxtDireccion.Text == "" || TxtTelefono.Text == "")
                {
                    MessageBox.Show("Los campos estan vacios", "llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (NuevoRegistro == true)
                    {
                        Datos oDatos = new Datos();
                        oDatos.Codigo = TxtCodigo.Text.Trim();
                        oDatos.Nombre = TxtNombre.Text.Trim();
                        oDatos.Apellido = TxtApellido.Text.Trim();
                        oDatos.Direccion = TxtDireccion.Text.Trim();
                        oDatos.Telefono = TxtTelefono.Text.Trim();

                        if (oDatosDAO.Agregar(oDatos) == false)
                        {
                            MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtCodigo.Text = "";
                            TxtApellido.Text = "";
                            TxtDireccion.Text = "";
                            TxtNombre.Text = "";
                            TxtTelefono.Text = "";
                            BtnEliminar.Enabled = false;
                            BtnGuardar.Enabled = false;
                            TxtCodigo.Focus();

                            return;
                        }
                    }
                    else
                    {
                        Datos oDatos = oDatosDAO.Buscar(TxtCodigo.Text.Trim());

                        oDatos.Nombre = TxtNombre.Text.Trim();
                        oDatos.Apellido = TxtApellido.Text.Trim();
                        oDatos.Direccion = TxtDireccion.Text.Trim();
                        oDatos.Telefono = TxtTelefono.Text.Trim();

                        if (oDatosDAO.Modificar(oDatos) == false)
                        {
                            MessageBox.Show("El Registro no fue Modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtCodigo.Text = "";
                            //TxtDescripcion.Text = "";
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
                Datos oMarca = oDatosDAO.Buscar(TxtCodigo.Text.Trim());
                if (TxtCodigo.Text == "" || TxtNombre.Text == "" || TxtApellido.Text == "" || TxtDireccion.Text == "" || TxtTelefono.Text == "")
                {
                    MessageBox.Show("Los campos estan vacios", "llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (oDatosDAO.Eliminar(oMarca) == false)
                    {
                        MessageBox.Show("El registro no puede ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("El registro eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtCodigo.Text = "";
                        TxtNombre.Text = "";
                        TxtApellido.Text = "";
                        TxtDireccion.Text = "";
                        TxtTelefono.Text = "";
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
            Datos oDato;
            try
            {
                oDato = oDatosDAO.Buscar(TxtCodigo.Text.Trim());
                if (oDato != null)
                {
                    NuevoRegistro = false;
                    TxtNombre.Text = oDato.Nombre.Trim();
                    TxtApellido.Text = oDato.Apellido.Trim();
                    TxtDireccion.Text = oDato.Direccion.Trim();
                    TxtTelefono.Text = oDato.Telefono.Trim();
                    BtnGuardar.Enabled = true;
                    BtnEliminar.Enabled = true;
                }
                else
                {
                    TxtNombre.Text = "";
                    TxtApellido.Text = "";
                    TxtDireccion.Text = "";
                    TxtTelefono.Text = "";
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
