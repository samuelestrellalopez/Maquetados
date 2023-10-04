using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    public class CuadradoMagico
    {


        public static bool EsCuadradoMagico(double[,] matriz)
        {
            int dimension = matriz.GetLength(0);

            double sumaDiagonal1 = 0, sumaDiagonal2 = 0;

            for (int i = 0; i < dimension; i++)
            {
                sumaDiagonal1 += matriz[i, i];
                sumaDiagonal2 += matriz[i, dimension - 1 - i];
            }

            if (sumaDiagonal1 != sumaDiagonal2)
            {
                return false;
            }

            double sumaFila = 0, sumaColumna = 0;
            for (int i = 0; i < dimension; i++)
            {
                sumaFila = 0;
                sumaColumna = 0;
                for (int j = 0; j < dimension; j++)
                {
                    sumaFila += matriz[i, j];
                    sumaColumna += matriz[j, i];
                }
                if (sumaFila != sumaDiagonal1 || sumaColumna != sumaDiagonal1)
                {
                    return false;
                }
            }

            return true;


        }
    }
    public class Calculo
    {
        public double[,] ObtenerMatrizDesdeDataGridView(DataGridView dataGridView)
        {
            int filas = dataGridView.Rows.Count;
            int columnas = dataGridView.Columns.Count;

            double[,] matriz = new double[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (!double.TryParse(dataGridView[j, i].Value.ToString(), out matriz[i, j]))
                    {
                        throw new Exception("Por favor ingresa valores numéricos en todas las celdas.");
                    }
                }
            }

            return matriz;
        }
    }
}


