using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA_Tarea1
{
    public class Circulo : Figura
    {
        private double radio;
        public Circulo()
        {

        }
        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }
        public override double area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        public override double perimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}