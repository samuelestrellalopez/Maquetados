using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA_Tarea1
{
    public class Triangulo : Figura
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }

        public double LadoA
        {
            get { return ladoA; }
            set { ladoA = value; }
        }

        public double LadoB
        {
            get { return ladoB; }
            set { ladoB = value; }
        }

        public double LadoC
        {
            get { return ladoC; }
            set { ladoC = value; }
        }

        public override double area()
        {
            double s = (ladoA + ladoB + ladoC) / 2;
            return Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));
        }

        public override double perimetro()
        {
            return ladoA + ladoB + ladoC;
        }
    }
}
