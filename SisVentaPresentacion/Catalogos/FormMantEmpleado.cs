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
    public partial class FormMantEmpleado : Form
    {
        private DatosDAO oDatosDAO = new DatosDAO();
        private EmpleadoDAO oEmpleadoDAO = new EmpleadoDAO();
        private bool NuevoRegistro = false;

        public FormMantEmpleado()
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Datos oDatos;
            oDatos = oDatosDAO.Buscar(TxtCodigoDatos.Text.Trim());

            if (oDatos != null)
            {
                NuevoRegistro = false;
                TxtIdDatos.Text = oDatos.IdDatos.ToString().Trim();
                //TxtCodigoP.Text = oDatos.Codigo.Trim();
                TxtCodigoDatos.ReadOnly = true;
                MessageBox.Show("Datos Econtrados", "Exito", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Datos NO EXIste", "ERROR", MessageBoxButtons.OK);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCodigoP.Text == "" || TxtIdentificacion.Text == "" || TxtCorreo.Text == "")
                {
                    MessageBox.Show("Los campos estan vacios", "llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (NuevoRegistro == true)
                    {

                        Empleado oEmpleado = new Empleado();
                        oEmpleado.Codigo = TxtCodigoP.Text.Trim();
                        oEmpleado.Identificacion = TxtIdentificacion.Text.Trim();
                        oEmpleado.Correo = TxtCorreo.Text.Trim();
                        oEmpleado.DatosIdDatos = int.Parse(TxtIdDatos.Text.Trim());

                        if (oEmpleadoDAO.Agregar(oEmpleado) == false)
                        {
                            MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtCodigoP.Text = "";
                            TxtCodigoDatos.ReadOnly = false;
                            //TxtDescripcion.Text = "";
                            BtnEliminar.Enabled = false;
                            BtnGuardar.Enabled = false;
                            //TxtCodigo.Focus();

                            return;
                        }
                    }
                    else
                    {
                        Empleado oProveedor = oEmpleadoDAO.Buscar(TxtCodigoP.Text.Trim());
                        //oProveedor.Codigo = TxtCodigoP.Text.Trim();
                        oProveedor.Identificacion = TxtIdentificacion.Text.Trim();
                        oProveedor.Correo = TxtCorreo.Text.Trim();
                        //oProveedor.DatosIdDatos = int.Parse(TxtIdDatos.Text.Trim());

                        if (oEmpleadoDAO.Modificar(oProveedor) == false)
                        {
                            MessageBox.Show("El Registro no fue Modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtCodigoP.Text = "";
                            TxtIdentificacion.Text = "";
                            TxtCorreo.Text = "";
                            TxtCodigoDatos.Text = "";
                            BtnEliminar.Enabled = false;
                            BtnGuardar.Enabled = false;
                            TxtCodigoP.Focus();
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
                Empleado oEmpleado = oEmpleadoDAO.Buscar(TxtCodigoP.Text.Trim());
                if (TxtCodigoP.Text == "" || TxtIdentificacion.Text == "" || TxtCorreo.Text == "")
                {
                    MessageBox.Show("Los campos estan vacios", "llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (oEmpleadoDAO.Eliminar(oEmpleado) == false)
                    {
                        MessageBox.Show("El registro no puede ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("El registro eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtCodigoP.Text = "";
                        TxtIdentificacion.Text = "";
                        TxtCorreo.Text = "";
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

        private void TxtCodigoP_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Empleado oEmpleado;
                oEmpleado = oEmpleadoDAO.Buscar(TxtCodigoP.Text.Trim());
                if (oEmpleado != null)
                {
                    NuevoRegistro = false;
                    TxtCodigoP.Text = oEmpleado.Codigo.Trim();
                    TxtIdentificacion.Text = oEmpleado.Identificacion.Trim();
                    TxtCorreo.Text = oEmpleado.Correo.Trim();
                    BtnGuardar.Enabled = true;
                    BtnEliminar.Enabled = true;
                }
                else
                {
                    //TxtCodigoP.Text = "";
                    TxtIdentificacion.Text = "";
                    TxtCorreo.Text = "";
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
