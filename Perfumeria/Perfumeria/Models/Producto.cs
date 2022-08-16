using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfumeria.Models
{   
    //Creación de variables, lógica de operación de ventas de productos
    class Producto
    {
        public string Nombre { get; set; }

        public int Stock { get; set; }

        public Producto(string Nombre, int Stock)
        {
           this.Nombre = Nombre;
           this.Stock = Stock;
        }

        public void Venta(int CuantoVendio)
        {
            this.Stock -= CuantoVendio;
        }

    }
}
