using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA_Tarea1
{
    public class Rectangulo : Figura
    {
        private double bases;
        private double altura;
        public Rectangulo()
        {

        }
        public double Bases
        {
            get { return bases; }
            set { bases = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public override double area()
        {
            return bases * altura;
        }
        public override double perimetro()
        {
            return (bases + altura) * 2;
        }
    }
}