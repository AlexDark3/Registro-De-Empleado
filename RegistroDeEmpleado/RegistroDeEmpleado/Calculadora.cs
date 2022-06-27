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

namespace ControlDeUsuario
{
    public partial class FrmCalculadora : Form
    {
        bool inicio = true;
        double primero;
        double segundo;
        double resultado;
        string operador;
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Clases.ClsOperaciones obj5 = new Clases.ClsOperaciones();

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimi_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Txtpantalla.Text);
            double sum;
            double res;
            double mult;
            double div;

            segundo = double.Parse(Txtpantalla.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = obj5.suma((primero), (segundo));
                    tbxPrevio.Text = tbxPrevio.Text + Txtpantalla.Text;
                    Txtpantalla.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj5.resta((primero), (segundo));
                    tbxPrevio.Text = tbxPrevio.Text + Txtpantalla.Text;
                    Txtpantalla.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj5.multiplicacion((primero), (segundo));
                    tbxPrevio.Text = tbxPrevio.Text + Txtpantalla.Text;
                    Txtpantalla.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj5.division((primero), (segundo));
                    tbxPrevio.Text = tbxPrevio.Text + Txtpantalla.Text;
                    Txtpantalla.Text = Div.ToString();
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "2";
                inicio = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "2";
                inicio = false;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(Txtpantalla.Text == "0")
            {
                return;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "0";
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "1";
                inicio = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "1";
                inicio=false;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "3";
                inicio = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "3";
                inicio = false;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "4";
                inicio = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "4";
                inicio = false;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "5";
                inicio = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "5";
                inicio = false;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "6";
                inicio = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "6";
                inicio = false;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "7";
                inicio = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "7";
                inicio = false;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "8";
                inicio = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "8";
                inicio = false;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "9";
                inicio = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "9";
                inicio = false;
            }
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(Txtpantalla.Text);
            tbxPrevio.Text = tbxPrevio.Text + Txtpantalla.Text + "+";
            Txtpantalla.Clear();
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Txtpantalla.Text);
            tbxPrevio.Text = tbxPrevio.Text + Txtpantalla.Text + "-";
            Txtpantalla.Clear();
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(Txtpantalla.Text);
            tbxPrevio.Text = tbxPrevio.Text + Txtpantalla.Text + "×";
            Txtpantalla.Clear();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(Txtpantalla.Text);
            tbxPrevio.Text = tbxPrevio.Text + Txtpantalla.Text + "÷";
            Txtpantalla.Clear();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtpantalla.Clear();
            tbxPrevio.Clear();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (Txtpantalla.Text.Length == 1)
                Txtpantalla.Text = "0";
            else
                Txtpantalla.Text = Txtpantalla.Text.Substring(0, Txtpantalla.Text.Length - 1);
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (Txtpantalla.Text.Contains(""))
            {

            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + ".";
            }
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void Txtpantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            primero = double.Parse(Txtpantalla.Text);
            resultado = primero;
            tbxPrevio.Text = "√" + tbxPrevio.Text + Txtpantalla.Text;
            Txtpantalla.Text = Math.Sqrt(primero).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            primero = double.Parse(Txtpantalla.Text);
            resultado = primero;
            tbxPrevio.Text = tbxPrevio.Text + Txtpantalla.Text + "^2";
            Txtpantalla.Text = Math.Pow(primero, 2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            primero = double.Parse(Txtpantalla.Text);
            resultado = primero;
            tbxPrevio.Text = "sinh (" + tbxPrevio.Text + Txtpantalla.Text + ")";
            Txtpantalla.Text = Math.Sinh(primero).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            primero = double.Parse(Txtpantalla.Text);
            resultado = primero;
            tbxPrevio.Text = "cos (" + tbxPrevio.Text + Txtpantalla.Text + ")";
            Txtpantalla.Text = Math.Cos(primero).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            primero = double.Parse(Txtpantalla.Text);
            resultado = primero;
            tbxPrevio.Text = "cosh (" + tbxPrevio.Text + Txtpantalla.Text + ")";
            Txtpantalla.Text = Math.Cosh(primero).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            primero = double.Parse(Txtpantalla.Text);
            resultado = primero;
            tbxPrevio.Text = "sin (" + tbxPrevio.Text + Txtpantalla.Text + ")";
            Txtpantalla.Text = Math.Sin(primero).ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            primero = double.Parse(Txtpantalla.Text);
            resultado = primero;
            tbxPrevio.Text = "tan (" + tbxPrevio.Text + Txtpantalla.Text + ")";
            Txtpantalla.Text = Math.Tan(primero).ToString();
        }

        private void buttom8_Click(object sender, EventArgs e)
        {
            primero = double.Parse(Txtpantalla.Text);
            resultado = primero;
            tbxPrevio.Text = "tanh (" + tbxPrevio.Text + Txtpantalla.Text + ")";
            Txtpantalla.Text = Math.Tanh(primero).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            primero = double.Parse(Txtpantalla.Text);
            resultado = primero;
            tbxPrevio.Text = "exp (" + tbxPrevio.Text + Txtpantalla.Text + ")";
            Txtpantalla.Text = Math.Exp(primero).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            primero = double.Parse(Txtpantalla.Text);
            resultado = primero;
            tbxPrevio.Text = "cosh (" + tbxPrevio.Text + Txtpantalla.Text + ")";
            Txtpantalla.Text = Math.Cosh(primero).ToString();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    
    }
}
