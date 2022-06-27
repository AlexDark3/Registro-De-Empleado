using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeEmpleado
{
    internal class clsCotizacion
    {
        public static string cliente;
        public static string telefono;
        public static string email;
        public static string codigo;
        public static double cantidad;
        public static string descripcion;
        public static double precio;
        public static double subtotal;
        public static double descuento;
        public static double itebis;
        public static double totalpagar;

        public static string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public static string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public static string Email
        {
            get { return email; }
            set { email = value; }
        }
        public static string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public static double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public static string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public static double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public static double SubTotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        public static double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public static double ITEBIS
        {
            get { return itebis; }
            set { itebis = value; }
        }
        public static double TotalPagar
        {
            get { return totalpagar; }
            set { totalpagar = value; }
        }

    }
}
