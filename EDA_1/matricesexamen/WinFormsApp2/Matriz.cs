using System;

public class Matriz
{
    private double[,] matriz;

    public Matriz(int filas, int columnas)
    {
        matriz = GenerarMatrizAleatoria(filas, columnas);
    }

    private double[,] GenerarMatrizAleatoria(int filas, int columnas)
    {
        Random rand = new Random();
        double[,] matriz = new double[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = rand.Next(1, 10); // Números aleatorios entre 1 y 9
            }
        }

        return matriz;
    }

    public double[,] ObtenerMatriz()
    {
        return matriz;
    }

    public double[] CalcularSumaColumnas()
    {
        int columnas = matriz.GetLength(1);
        double[] sumaColumnas = new double[columnas];

        for (int j = 0; j < columnas; j++)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                sumaColumnas[j] += matriz[i, j];
            }
        }

        return sumaColumnas;
    }

    public double[] CalcularPromedioColumnas()
    {
        int columnas = matriz.GetLength(1);
        double[] promedioColumnas = new double[columnas];

        for (int j = 0; j < columnas; j++)
        {
            promedioColumnas[j] = CalcularSumaColumna(j) / matriz.GetLength(0);
        }

        return promedioColumnas;
    }

    private double CalcularSumaColumna(int columna)
    {
        double suma = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            suma += matriz[i, columna];
        }

        return suma;
    }

    public double[] CalcularSumaFilas()
    {
        int filas = matriz.GetLength(0);
        double[] sumaFilas = new double[filas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                sumaFilas[i] += matriz[i, j];
            }
        }

        return sumaFilas;
    }
}
