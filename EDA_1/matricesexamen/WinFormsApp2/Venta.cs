using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Venta
    {
        public int[,] Datos { get; set; }

        public Venta(int[,] datos)
        {
            Datos = datos;
        }
    }

}
