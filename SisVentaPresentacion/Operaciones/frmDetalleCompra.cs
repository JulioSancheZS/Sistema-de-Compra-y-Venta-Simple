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
    public partial class frmDetalleCompra : Form
    {
        ProveedorDAO oEmpleadoDAO = new ProveedorDAO();
        ProductosDAO oProductoDAO = new ProductosDAO();
        ClienteDAO oClienteDAO = new ClienteDAO();

        public frmDetalleCompra()
        {
            InitializeComponent();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            Consultas.FormBEmpleado frm = new Consultas.FormBEmpleado();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void BtnBuscarProveedor_Click(object sender, EventArgs e)
        {
            Consultas.FormFindProveedor frm = new Consultas.FormFindProveedor();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            Consultas.FormBProducto frm = new Consultas.FormBProducto();
            AddOwnedForm(frm);
            frm.Show();
        }

        public void CalcularTotal()
        {
            decimal TOTAL = 0;
            foreach (DataGridViewRow item in DgvDetalleCompra.Rows)
            {
                decimal importe = decimal.Parse(item.Cells[3].Value.ToString());
                TOTAL += importe;
            }

            LblTotal.Text = TOTAL.ToString();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            if (TxtDescripProducto.Text == "" || TxtCodigoVenta.Text == "" )
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

                DgvDetalleCompra.Rows.Add(new object[]
                {
                descripcion,precio,cantidad, importe, idproducto,"Eliminar"
                });

                TxtDescripProducto.Text = "";
                TxtIdProducto.Text = "";
                TxtCodigoProducto.Text = "";
                TxtPrecioVenta.Text = "";
                TxtCantidadP.Text = "";
                          

            }

            CalcularTotal();
			BtnBuscarProducto_Click(null, null);
        }

        private void BtnGenerarCompra_Click(object sender, EventArgs e)
        {
            using (DBVentaContainer db = new DBVentaContainer())
            {
                using (var transaccion = db.Database.BeginTransaction())
                {
                    try
                    {
                        Compra oCompra = new Compra();
                        oCompra.Codigo = TxtCodigoVenta.Text.Trim();
                        oCompra.FechaCompra = DateTime.Now;
                        oCompra.EmpleadoIdEmpleado = int.Parse(TxtIdEmpleado.Text.ToString().Trim());
                        oCompra.ProveedorIdProveedor = int.Parse(txtIdProveedor.Text.ToString().Trim());
                        db.Compra.Add(oCompra);
                        db.SaveChanges();

                        foreach (DataGridViewRow item in DgvDetalleCompra.Rows)
                        {
                            DetalleCompra oDetalleCompra = new DetalleCompra();
                            oDetalleCompra.Precio = decimal.Parse(item.Cells[1].Value.ToString());
                            oDetalleCompra.Cantidad = int.Parse(item.Cells[2].Value.ToString());
                            //oDetalleVenta.IdDetalleVenta = int.Parse(item.Cells[0].Value.ToString());
                            oDetalleCompra.ProductoIdProducto = int.Parse(item.Cells[4].Value.ToString());
                            //oDetalleVenta.Importe = decimal.Parse(item.Cells[3].Value.ToString());
                            oDetalleCompra.CompraIdCompra = oCompra.IdCompra;
                            db.DetalleCompra.Add(oDetalleCompra);
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
                        txtIdProveedor.Text = "";
                        TxtIdEmpleado.Text = "";
                        TxtCodigoVenta.Text = "";
                        TxtCodgoEmpleado.Text = "";
                        TxtCodigoCliente.Text = "";
                        TxtNombreCliente.Text = "";
                        TxtNombreEmpleado.Text = "";

						var reporte = new Reportes.frmReporteUltimaCompra();
						reporte.ShowDialog();
					}
                    catch (Exception ex)
                    {
                        transaccion.Rollback(); //regresar la base de datos como estaba                   
                    }
                }
            }
        }

        private void DgvDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // si ha selecionado una celda diferente del Boton "Op"
            if (e.RowIndex < 0 || e.ColumnIndex != DgvDetalleCompra.Columns["Op"].Index)
            {
                return;
            }
            DgvDetalleCompra.Rows.RemoveAt(e.RowIndex);
            CalcularTotal();
        }

        private void TxtCantidadP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

	}
}
