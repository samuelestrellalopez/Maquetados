using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA_Tarea1
{
    public class Cuadrado : Figura
    {
        private double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double area()
        {
            return lado * lado;
        }

        public override double perimetro()
        {
            return 4 * lado;
        }
    }
}
