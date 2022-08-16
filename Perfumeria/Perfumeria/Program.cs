using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perfumeria.Models;

namespace Perfumeria
{   
    //A continuación se realizaron distintos métodos para mostrar en consola la operación hecha en el proyecto

    class Program
    {
        static void Main(string[] args)
        //Metodo sencillo para crear nuevos productos:
        //{
        //    Perfumes perfume = new Perfumes(10, "Perfumes Paco Rabanne");
        //    perfume.Venta(4);
        //    Console.WriteLine();
        //}
        //Creacion de productos con Listas:
        //{
        //    List<Perfumes> perfumes = new List<Perfumes>() { new Perfumes(10, "Perfumes Paco Rabanne") };
        //    perfumes.Add(new Perfumes(15));
        //    Perfumes Dior = new Perfumes(12,"Perfume Dior");
        //    perfumes.Add(Dior);
        //    Console.WriteLine();

        //    foreach(var perfume in perfumes)
        //    {
        //        Console.WriteLine("perfume: " + perfume.Nombre);
        //        Console.WriteLine();
        //    }
        //}
        // Implementación del producto Desodorante utilizando la interface ProductosH
        //En lugar de Desodorantes puede ir Perfumes y me trae el máximo Stock del producto.
        {
            var productoH = new Desodorantes(500);
            MostrarMaxStock(productoH);
        }

        static void MostrarMaxStock(IProductosH producto)
        {
            producto.MaxStock();
            Console.WriteLine();
        }
    }
}
