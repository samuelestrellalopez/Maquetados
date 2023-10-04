using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

using System;

namespace WinFormsApp2
{
    public class MatrizAleatoria
    {
        public static double[,] GenerarMatrizAleatoria(int filas, int columnas)
        {
            double[,] matriz = new double[filas, columnas];
            Random random = new Random();

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = random.Next(1, 10);
                }
            }

            return matriz;
        }
    }
}
