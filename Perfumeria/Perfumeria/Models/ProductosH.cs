using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfumeria.Models
{
    //Implementación de interface producto perfume para hombres
    public interface IProductosH
    {
         int Hombre { get; set; }

         void MaxStock();
    }
}
