using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ControlDeUsuario;


namespace RegistroDeEmpleado
{
    public partial class FrmPrincipal : Form
    {


        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void agregar()
        {
            //Agrega los datos del cliente a la clase
            clsCotizacion.Cliente = txtCliente.Text;
            clsCotizacion.Telefono = txtTelefono.Text;
            clsCotizacion.Email = txtEmail.Text;

            //Agrega los datos del articulo a la clase
            clsCotizacion.Codigo = txtCodigo.Text;
            double cant = double.Parse(txtCantidad.Text);
            clsCotizacion.Cantidad = cant;
            clsCotizacion.Descripcion = txtDescripcion.Text;
            double pre = double.Parse(txtPrecioUnidad.Text);
            clsCotizacion.Precio = pre;
            double st = cant * pre;
            clsCotizacion.SubTotal = st;
            double descuent = double.Parse(txtDescuento.Text);
            clsCotizacion.Descuento = descuent;
            double ite = double.Parse(txtITEBIS.Text);
            clsCotizacion.ITEBIS = ite;
            double topa = double.Parse(txtTotalPagar.Text);
            clsCotizacion.TotalPagar = topa;

            //Agrega los datos del articulo al dataGridView
            dataGridView1.Rows.Add(clsCotizacion.Codigo, clsCotizacion.Cantidad, clsCotizacion.Descripcion, clsCotizacion.Precio,
                clsCotizacion.SubTotal, clsCotizacion.Descuento, clsCotizacion.ITEBIS, clsCotizacion.TotalPagar);

            //Limpia los TextBox
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtPrecioUnidad.Text = "";
            txtSubTotal.Text = "";
            txtDescuento.Text = "";
            txtITEBIS.Text = "";
            txtTotalPagar.Text = "";
            txtCodigo.Focus();//Coloca el cursor en el TextBox txtCodigo
        }

        private void calcular()
        {
            //Convierte los datos de los textbox en double
            double cant = double.Parse(txtCantidad.Text);
            double pre = double.Parse(txtPrecioUnidad.Text);

            double st = cant * pre;
            this.txtSubTotal.Text = st.ToString();//Convierte los datos de double a string

            double it = st * 0.18;
            this.txtITEBIS.Text = it.ToString();//Convierte los datos de double a string

            if (!string.IsNullOrEmpty(txtDescuento.Text))
            {
                double desc = double.Parse(txtDescuento.Text);//Convierte los datos de los textbox en double
                desc = (desc / 100) * st;
                double tp = st - desc;
                this.txtTotalPagar.Text = tp.ToString();//Convierte los datos de double a string
            }
            else
            {
                double tp = st;
                txtDescuento.Text = "0";
                this.txtTotalPagar.Text = tp.ToString();//Convierte los datos de double a string
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 llama = new();
            llama.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e, clsCotizacion clsCotizacion, string descuento, string subt)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text) &&
                !string.IsNullOrEmpty(txtCantidad.Text) &&
                !string.IsNullOrEmpty(txtDescripcion.Text) &&
                !string.IsNullOrEmpty(txtPrecioUnidad.Text) &&
                !string.IsNullOrEmpty(txtSubTotal.Text) &&
                !string.IsNullOrEmpty(txtDescuento.Text) &&
                !string.IsNullOrEmpty(txtITEBIS.Text) &&
                !string.IsNullOrEmpty(txtTotalPagar.Text))
            {
                agregar();
            }
            else
            {
                MessageBox.Show("No pueden quedar campos vacios", "Aviso");
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text) &&
                !string.IsNullOrEmpty(txtCantidad.Text) &&
                !string.IsNullOrEmpty(txtDescripcion.Text) &&
                !string.IsNullOrEmpty(txtPrecioUnidad.Text) &&
                !string.IsNullOrEmpty(txtSubTotal.Text) &&
                !string.IsNullOrEmpty(txtDescuento.Text) &&
                !string.IsNullOrEmpty(txtITEBIS.Text) &&
                !string.IsNullOrEmpty(txtTotalPagar.Text))
            {
                agregar();
            }
            else
            {
                MessageBox.Show("No pueden quedar campos vacios", "Aviso");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);//Elimina los articulos seleccionados en el dataGridView
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void nuevo()
        {
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtPrecioUnidad.Text = "";
            txtSubTotal.Text = "";
            txtDescuento.Text = "";
            txtITEBIS.Text = "";
            txtTotalPagar.Text = "";
            dataGridView1.Rows.Clear();
            txtCodigo.Focus();
        }

        private void btnCalcualarProducto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCantidad.Text) &&
                !string.IsNullOrEmpty(txtPrecioUnidad.Text))
            {
                calcular();
            }
            else
            {
                MessageBox.Show("No puede quedar vacio el campo Cantidad o Precio/Unidad", "Aviso");
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculadora llama = new();
            llama.Show();
        }
    }
}
