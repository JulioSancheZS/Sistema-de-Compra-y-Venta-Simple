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


namespace SisVentaPresentacion.Catalogos
{
    public partial class FormMantProducto : Form
    {
        private CategoriaDAO oCategoriaDAO = new CategoriaDAO();
        private MarcaDAO oMarcaDAO = new MarcaDAO();
        private ModeloDAO oModeloDAO = new ModeloDAO();
        private ProductosDAO oProductosDAO = new ProductosDAO();
        private bool NuevoRegistro = false;



        public FormMantProducto()
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

        private void DesactivaControles(bool EstadoCtrl)
        {
            TxtDescripcion.Enabled = !EstadoCtrl;
            TxtPrecioCompra.Enabled = !EstadoCtrl;
            TxtPrecioVenta.Enabled = !EstadoCtrl;
            TxtStock.Enabled = !EstadoCtrl;
            CbxCategoria.Enabled = !EstadoCtrl;
            CbxMarca.Enabled = !EstadoCtrl;
            CbxModelo.Enabled = !EstadoCtrl;
            BtnGuardar.Enabled = !EstadoCtrl;
            BtnEliminar.Enabled = !EstadoCtrl;
        }//fin del método desactivar controles

        private void LimpiarControles()
        {
            TxtDescripcion.Text = "";
            TxtPrecioCompra.Text = "";
            TxtPrecioVenta.Text = "";
            TxtStock.Text = "";
            CbxCategoria.SelectedIndex = -1;
            CbxMarca.SelectedIndex = -1;
            CbxModelo.SelectedIndex = -1;   //no hay nada seleccionado
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
            ListarCategorias();
            ListarMarca();
            ListarModelo();
        }

        private void ListarCategorias()
        {
            CbxCategoria.DataSource = oCategoriaDAO.listar();
            CbxCategoria.DisplayMember = "Descripcion";
            CbxCategoria.ValueMember = "IdCategoria";
            CbxCategoria.SelectedIndex = -1;

        }

        private void ListarMarca()
        {
            CbxMarca.DataSource = oMarcaDAO.listar();
            CbxMarca.DisplayMember = "Descripcion";
            CbxMarca.ValueMember = "IdMarca";
            CbxMarca.SelectedIndex = -1;
        }


        private void ListarModelo()
        {
            CbxModelo.DataSource = oModeloDAO.listar();
            CbxModelo.DisplayMember = "Descripcion";
            CbxModelo.ValueMember = "IdModelo";
            CbxModelo.SelectedIndex = -1;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCodigo.Text == "" || TxtDescripcion.Text == "" || TxtPrecioCompra.Text == "" || TxtPrecioVenta.Text == "" || TxtStock.Text=="")
                {
                    MessageBox.Show("Los campos estan vacios", "llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (NuevoRegistro == true)
                    {
                        Producto oProducto = new Producto();
                        oProducto.Codigo = TxtCodigo.Text.Trim();
                        oProducto.Descripcion = TxtDescripcion.Text.Trim();
                        oProducto.PrecioCompra = Convert.ToDecimal(TxtPrecioCompra.Text.Trim());
                        oProducto.PrecioVenta = Convert.ToDecimal(TxtPrecioVenta.Text.Trim());
                        oProducto.Stock = Convert.ToInt32(TxtStock.Text.Trim());
                        oProducto.CategoriaIdCategoria = (int)CbxCategoria.SelectedValue;
                        oProducto.MarcaIdMarca = (int)CbxMarca.SelectedValue;
                        oProducto.ModeloIdModelo = (int)CbxModelo.SelectedValue;

                        if (oProductosDAO.Agregar(oProducto) == false)
                        {
                            MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    else
                    {
                        Producto oProducto = oProductosDAO.Buscar(TxtCodigo.Text.Trim());
                        oProducto.Descripcion = TxtDescripcion.Text.Trim();
                        oProducto.PrecioCompra = Convert.ToDecimal(TxtPrecioCompra.Text.Trim());
                        oProducto.PrecioVenta = Convert.ToDecimal(TxtPrecioVenta.Text.Trim());
                        oProducto.Stock = Convert.ToInt32(TxtStock.Text.Trim());
                        oProducto.CategoriaIdCategoria = (int)CbxCategoria.SelectedValue;
                        oProducto.MarcaIdMarca = (int)CbxMarca.SelectedValue;
                        oProducto.ModeloIdModelo = (int)CbxModelo.SelectedValue;

                        if (oProductosDAO.Modificar(oProducto) == false)
                        {
                            MessageBox.Show("El Registro no fue Modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                            //LimpiarControles();
                            //DesactivaControles(true);
                            //TxtCodigo.Text = "";
                            //TxtCodigo.Focus();
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
            Producto oProducto = oProductosDAO.Buscar(TxtCodigo.Text.Trim());
            try
            {
                if (TxtCodigo.Text == "" || TxtDescripcion.Text == "" || TxtPrecioCompra.Text == "" || TxtPrecioVenta.Text == "" || TxtStock.Text == "")
                {
                    MessageBox.Show("Los campos estan vacios", "llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (oProductosDAO.Eliminar(oProducto) == false)
                    {
                        MessageBox.Show("El registro no puede ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("El registro eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                        //DesactivaControles(true);
                        TxtCodigo.Text = "";
                        TxtCodigo.Focus();
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
            //DesactivaControles(true);
            //LimpiarControles();
            Producto oProducto;
            try
            {
                oProducto = oProductosDAO.Buscar(TxtCodigo.Text.Trim());
                if (oProducto != null)
                {
                    NuevoRegistro = false;
                    TxtDescripcion.Text = oProducto.Descripcion.Trim();
                    TxtPrecioCompra.Text = oProducto.PrecioCompra.ToString();
                    TxtPrecioVenta.Text = oProducto.PrecioVenta.ToString();
                    TxtStock.Text = oProducto.Stock.ToString();
                    CbxCategoria.SelectedValue = oProducto.CategoriaIdCategoria;
                    CbxMarca.SelectedValue = oProducto.MarcaIdMarca;
                    CbxModelo.SelectedValue = oProducto.ModeloIdModelo;
                    DesactivaControles(false);
                }
                else
                {
                    NuevoRegistro = true;
                    DesactivaControles(false);
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
