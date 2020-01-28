using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIsEDM.Modelo;
using SIsEDM;
using SisVentaDAO;

namespace SisVentaPresentacion.Operaciones
{
    public partial class frmDetalleVenta : Form
    {
        EmpleadoDAO oEmpleadoDAO = new EmpleadoDAO();
        ProductosDAO oProductoDAO = new ProductosDAO();
        ClienteDAO oClienteDAO = new ClienteDAO();
        public frmDetalleVenta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            Consultas.FormFindCliente frm = new Consultas.FormFindCliente();
            AddOwnedForm(frm);
            frm.Show();
            
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            Consultas.FormFindProducto frm = new Consultas.FormFindProducto();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void TxtCodgoEmpleado_Validating(object sender, CancelEventArgs e)
        {
            Empleado oEmpleado;

            oEmpleado = oEmpleadoDAO.Buscar(TxtCodgoEmpleado.Text.Trim());
            if (oEmpleado != null)
            {
                //TxtCodigo.Text = oDatos.Codigo.Trim();
                TxtIdEmpleado.Text = oEmpleado.IdEmpleado.ToString().Trim();
                //TxtNombreEmpleado.Text = oEmpleado.n.Trim();
            }
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            if (TxtDescripProducto.Text =="" || TxtCodigoVenta.Text == "" || TxtCantidadP.Text=="")
            {
                MessageBox.Show("Tiene los campos vacios", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string descripcion = TxtDescripProducto.Text.Trim();
                string precio = TxtPrecioVenta.Text.Trim();
                string cantidad = TxtCantidadP.Text.Trim();
                string importe = (decimal.Parse(cantidad) * decimal.Parse(precio)).ToString();
                string idproducto = TxtIdProducto.Text.Trim();

                DgvDetalleVenta.Rows.Add(new object[]
                {
                descripcion,precio,cantidad, importe, idproducto,"Eliminar"
                });

                TxtDescripProducto.Text = "";
                TxtIdProducto.Text = "";
                TxtCodigoProducto.Text = "";
                TxtPrecioVenta.Text = "";
                TxtCantidadP.Text = "";


				CalcularTotal();
				BtnBuscarProducto_Click(null, null);
			}
           

        }

        private void DgvDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // si ha selecionado una celda diferente del Boton "Op"
            if (e.RowIndex < 0 || e.ColumnIndex != DgvDetalleVenta.Columns["Op"].Index)
            {
                return;
            }
            DgvDetalleVenta.Rows.RemoveAt(e.RowIndex);
            CalcularTotal();
        }

        public void CalcularTotal()
        {
            decimal TOTAL = 0;
            foreach (DataGridViewRow item in DgvDetalleVenta.Rows)
            {
                decimal importe = decimal.Parse(item.Cells[3].Value.ToString());
                TOTAL += importe;
            }

            LblTotal.Text = TOTAL.ToString();
        }

        private void BtnGenerarVenta_Click(object sender, EventArgs e)
        {
            using (DBVentaContainer db = new DBVentaContainer())
            {
                using (var transaccion = db.Database.BeginTransaction())
                {
                    try
                    {   
                        Venta oVenta = new Venta();
                        oVenta.Codigo = TxtCodigoVenta.Text.Trim();
                        oVenta.FechaVenta = DateTime.Now;
                        oVenta.EmpleadoIdEmpleado = int.Parse(TxtIdEmpleado.Text.ToString().Trim());
                        oVenta.ClienteIdCliente = int.Parse(txtIdCliente.Text.ToString().Trim());
                        db.Venta.Add(oVenta);

                        db.SaveChanges();

                        foreach (DataGridViewRow item in DgvDetalleVenta.Rows)
                        {      
                            DetalleVenta oDetalleVenta = new DetalleVenta();
                            oDetalleVenta.Precio = decimal.Parse(item.Cells[1].Value.ToString());
                            oDetalleVenta.Cantidad = int.Parse(item.Cells[2].Value.ToString());
                            //oDetalleVenta.IdDetalleVenta = int.Parse(item.Cells[0].Value.ToString());
                            oDetalleVenta.ProductoIdProducto = int.Parse(item.Cells[4].Value.ToString());
                            //oDetalleVenta.Importe = decimal.Parse(item.Cells[3].Value.ToString());
                            oDetalleVenta.VentaIdVenta = oVenta.IdVenta;
                            db.DetalleVenta.Add(oDetalleVenta);
                        }
						//DetalleVenta detalleVenta = new DetalleVenta();
						//detalleVenta.ProductoIdProducto = int.Parse(TxtIdProducto.Text.ToString());
						//db.DetalleVenta.Add(detalleVenta);
						db.SaveChanges();
                        transaccion.Commit();
                        transaccion.Dispose();
                        this.Close();
                        TxtCodgoEmpleado.Text = "";
                        TxtCodigoCliente.Text = "";         
                        TxtCodigoVenta.Text = "";
                        TxtCodgoEmpleado.Text = "";
                        TxtCodigoCliente.Text = "";
                        TxtNombreCliente.Text = "";
                        TxtNombreEmpleado.Text = "";
						// Aqui llamas al reporte

						var reporte = new Informes.frmReporteUltimaVenta();
						reporte.ShowDialog();
					}
                    catch (Exception ex)
                    {
                        transaccion.Rollback(); //regresar la base de datos como estaba                   
                    }
                }
            }
		}

        private void TxtCodigoCliente_Validating(object sender, CancelEventArgs e)
        {
            Cliente oCliente;

            oCliente = oClienteDAO.Buscar(TxtCodigoCliente.Text.Trim());
            if (oCliente != null)
            {
                //TxtCodigo.Text = oDatos.Codigo.Trim();
                txtIdCliente.Text = oCliente.IdCliente.ToString().Trim();
                //TxtNombreEmpleado.Text = oEmpleado.n.Trim();
            }
        }

        private void TxtCodigoProducto_Validating(object sender, CancelEventArgs e)
        {
            Producto oProducto;

            oProducto = oProductoDAO.Buscar(TxtCodigoProducto.Text.Trim());
            if (oProducto != null)
            {
                //TxtCodigo.Text = oDatos.Codigo.Trim();
                TxtIdProducto.Text = oProducto.IdProducto.ToString().Trim();
                TxtDescripProducto.Text = oProducto.Descripcion.Trim();
                TxtPrecioVenta.Text = oProducto.PrecioVenta.ToString().Trim();
                //TxtNombreEmpleado.Text = oEmpleado.n.Trim();
            }
        }

        private void TxtCantidadP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultas.FormFindEmpledo frm = new Consultas.FormFindEmpledo();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void TxtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
           
        }
    }
}
