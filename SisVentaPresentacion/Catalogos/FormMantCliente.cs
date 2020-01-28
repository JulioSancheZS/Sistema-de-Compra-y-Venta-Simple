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
    public partial class FormMantCliente : Form
    {
        private DatosDAO oDatosDAO = new DatosDAO();
        private ClienteDAO oClienteDAO = new ClienteDAO();
        private bool NuevoRegistro = false;

        public FormMantCliente()
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente oCliente = oClienteDAO.Buscar(TxtCodigo.Text.Trim());
                if (TxtCodigo.Text == "")
                {
                    MessageBox.Show("Los campos estan vacios", "llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (oClienteDAO.Eliminar(oCliente) == false)
                    {
                        MessageBox.Show("El registro no puede ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("El registro eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtCodigo.Text = "";
                        TxtCodigoDatos.Text = "";
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCodigo.Text == "" || TxtCodigoDatos.Text == "")
                {
                    MessageBox.Show("Los campos estan vacios", "llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (NuevoRegistro == true)
                    {
                        Cliente oCliente = new Cliente();
                        oCliente.Codigo = TxtCodigo.Text.Trim();
                        oCliente.DatosIdDatos = int.Parse(TxtIdDatos.Text.Trim());

                        if (oClienteDAO.Agregar(oCliente) == false)
                        {
                            MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtCodigo.Text = "";
                            TxtCodigoDatos.ReadOnly = false;
                            BtnEliminar.Enabled = false;
                            BtnGuardar.Enabled = false;
                            TxtCodigo.Focus();

                            return;
                        }
                    }
                    else
                    {
                        Cliente oCliente = oClienteDAO.Buscar(TxtCodigo.Text.Trim());
                        
                        if (oClienteDAO.Modificar(oCliente) == false)
                        {
                            MessageBox.Show("El Registro no fue Modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //TxtCodigo.Text = "";
                            TxtCodigoDatos.Text = "";
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Datos oDatos;
            oDatos = oDatosDAO.Buscar(TxtCodigoDatos.Text.Trim());

            if (oDatos != null)
            {
                NuevoRegistro = false;
                TxtIdDatos.Text = oDatos.IdDatos.ToString().Trim();
                TxtCodigoDatos.ReadOnly = true;
                MessageBox.Show("Datos Econtrados", "Exito", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Datos NO EXIste", "ERROR", MessageBoxButtons.OK);
        }

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            Cliente oCliente;
           
            oCliente = oClienteDAO.Buscar(TxtCodigo.Text.Trim());
            if (oCliente != null)
            {
                NuevoRegistro = false;
                TxtCodigo.Text = oCliente.Codigo.Trim();
                BtnGuardar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            else
            {
                //TxtCodigo.Text = "";
                NuevoRegistro = true;
                BtnGuardar.Enabled = true;
                BtnEliminar.Enabled = false;
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtCodigoDatos_Validating(object sender, CancelEventArgs e)
        {
            Datos oDatos;
           
            oDatos = oDatosDAO.Buscar(TxtCodigoDatos.Text.Trim());
            if (oDatos != null)
            {
               
                //TxtCodigo.Text = oDatos.Codigo.Trim();
                TxtIdDatos.Text = oDatos.IdDatos.ToString().Trim();
                TxtNombre.Text = oDatos.Nombre.Trim();
                TxtApellido.Text = oDatos.Apellido.Trim();
                TxtDireccion.Text = oDatos.Direccion.Trim();
                TxtTelefono.Text = oDatos.Telefono.Trim();

            }          
        }
    }
}
