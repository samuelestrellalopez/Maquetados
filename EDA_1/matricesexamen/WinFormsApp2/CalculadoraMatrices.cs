using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public class CalculadoraMatrices
    {

        public double[] CalcularPromediosPorFila(double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            double[] promedios = new double[filas];

            for (int i = 0; i < filas; i++)
            {
                double sumaFila = 0;

                for (int j = 0; j < columnas; j++)
                {
                    sumaFila += matriz[i, j];
                }

                promedios[i] = Math.Round(sumaFila / columnas, 1); 
            }

            return promedios;
        }
        private double[,] GenerarMatrizAleatoria(int filas, int columnas)
        {
            Random random = new Random();
            double[,] matriz = new double[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = Math.Min(10, random.Next(1, 11)); 
                }
            }

            return matriz;
        }



        public double[] CalcularPromediosPorColumna(double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            double[] promedios = new double[columnas];

            for (int j = 0; j < columnas; j++)
            {
                double sumaColumna = 0;

                for (int i = 0; i < filas; i++)
                {
                    sumaColumna += matriz[i, j];
                }

                promedios[j] = Math.Round(sumaColumna / filas, 1);
            }

            return promedios;
        }
       


        public double CalcularPromedioMasAlto(double[] promedios)
        {
            return promedios.Max();
        }

        public double CalcularPromedioMasBajo(double[] promedios)
        {
            return promedios.Min();
        }

        public int ContarAlumnosMenosDe7(double[,] matriz)
        {
            int contador = 0;
            foreach (var calificacion in matriz)
            {
                if (calificacion < 7)
                {
                    contador++;
                }
            }
            return contador;
        }

        public double[,] CalcularRango(double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            double[,] rangos = new double[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    rangos[i, j] = CalcularRangoFila(matriz, i, j);
                }
            }

            return rangos;
        }

        private double CalcularRangoFila(double[,] matriz, int fila, int columna)
        {
            double calificacion = matriz[fila, columna];
            double minimo = calificacion;
            double maximo = calificacion;

            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                if (i != columna)
                {
                    double valor = matriz[fila, i];
                    if (valor < minimo)
                    {
                        minimo = valor;
                    }
                    if (valor > maximo)
                    {
                        maximo = valor;
                    }
                }
            }

            return maximo - minimo;
        }
    }



}
