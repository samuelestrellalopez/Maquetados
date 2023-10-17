using System;
using System.Collections.Generic;
using System.Linq;

public class Practica2
{
    public List<int> GenerarNumerosAleatorios(int cantidad)
    {
        Random random = new Random();
        List<int> numeros = new List<int>();

        for (int i = 0; i < cantidad; i++)
        {
            numeros.Add(random.Next(1, 101)); // Números aleatorios entre 1 y 100
        }

        return numeros;
    }

    public Tuple<List<int>, List<int>> SepararParesImpares(List<int> numeros)
    {
        List<int> pares = new List<int>();
        List<int> impares = new List<int>();

        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
                pares.Add(numero);
            else
                impares.Add(numero);
        }

        return Tuple.Create(pares, impares);
    }
}
