using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfumeria.Models
{
    //Clase Desodorantes con la herencia y la interface incluidas.
    class Desodorantes : Producto, IProductosH
    { 
       public int Hombre { get; set; }

       public void MaxStock()
       {
            Console.WriteLine("El máximo stock de desodorantes para hombres es de 500");
       }

       public Desodorantes(int Stock, string Nombre = "Desodorante")
             : base(Nombre, Stock)
       {

       }
        
    }
}
