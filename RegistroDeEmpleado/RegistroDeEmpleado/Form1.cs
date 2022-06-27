using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeEmpleado
{
    public partial class Form1 : Form
    {
        public ClsRegEmpleado Empleado { get; set; } = new();//Llama la clase asignandole el nombre Empleado
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Asigna los datos ingresados por el usuario a las propiedades de las clase clsRegEmp
            Empleado.Nombre = txtNombre.Text;
            Empleado.Apellido = txtApellido.Text;
            Empleado.Fecha = dateTimePicker1.Value;
            Empleado.Edad = txtEdad.Text;
            Empleado.Cargo = cboCargo.Text;
            Empleado.Sueldo = txtSueldo.Text;
            Empleado.Tipo = cboTipo.Text;

            //Muestra el empleado registrado en el listBox
            listBox1.Items.Add("------------------------------------");
            listBox1.Items.Add("Nombre: " + Empleado.Nombre);
            listBox1.Items.Add("------------------------------------");
            listBox1.Items.Add("Apellido: " + Empleado.Apellido);
            listBox1.Items.Add("------------------------------------");
            listBox1.Items.Add("Fecha: " + Empleado.Fecha);
            listBox1.Items.Add("------------------------------------");
            listBox1.Items.Add("Edad: " + Empleado.Edad);
            listBox1.Items.Add("------------------------------------");
            listBox1.Items.Add("Cargo: " + Empleado.Cargo);
            listBox1.Items.Add("------------------------------------");
            listBox1.Items.Add("Sueldo: " + Empleado.Sueldo);
            listBox1.Items.Add("------------------------------------");
            listBox1.Items.Add("Tipo: " + Empleado.Tipo);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Limpia los textbox y los combobox
            txtNombre.Text = "";
            txtApellido.Text = "";
            dateTimePicker1.Value = new DateTime(1990, 1, 1);
            txtEdad.Text = "";
            cboCargo.Text = "";
            txtSueldo.Text = "";
            cboTipo.Text = "";

            listBox1.Items.Clear();//Limpia el listbox
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}