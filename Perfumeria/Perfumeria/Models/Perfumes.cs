using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfumeria.Models
{
     //Herencia e Interface
    class Perfumes : Producto, IProductosH
    {
        public int Hombre { get; set; }

        public void MaxStock()
        {
            Console.WriteLine("El máximo stock de perfumes para hombres es de 100");
        }

        public Perfumes(int Stock, string Nombre = "Perfume")
            : base(Nombre, Stock)
        {
            
        }

        
    }
}
