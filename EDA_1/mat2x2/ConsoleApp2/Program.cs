using System;
using System.Collections.Generic;

class EDA5
{
    static void Main()
    {
        Pantalla mostrar;
        mostrar = new Pantalla();
    }
}

class Pantalla
{
    // Lista que almacena mi matriz 3x3
    List<int[,]> matrices = new List<int[,]>();

    public Pantalla()
    {
        matrices.Add(new int[3, 3]);
        inicio();
    }

    public void inicio()
    {
        while (true)
        {
            Console.WriteLine("----Selecciona una opcion:---- ");
            Console.WriteLine("1. Calcular ceros");
            Console.WriteLine("2. matriz cuadrada de números enteros");
            Console.WriteLine("3. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("----Selecciona una opcion parea calcular ceros en filas:---- ");
                    Console.WriteLine("a. Calcular Matriz predeterminada ");
                    Console.WriteLine("b. Ingresar valores de la matriz 5X5");
                    Console.WriteLine("c. salir");

                    string opcion2 = Console.ReadLine();
                    Console.Clear();

                    switch (opcion2)
                    {
                        case "a":

                            int[,] matrizp = new int[,] {
                                {0, 2, 5, 7, 6},
                                {0, 0, 0, 3, 8},
                                {2, 9, 6, 3, 4},
                                {1, 5, 6, 1, 4},
                                {0, 9, 2, 5, 0}
                            };
                            Console.WriteLine("\nMatriz:");
                            Mostrarmatriz(matrizp);
                            for (int i = 0; i < matrizp.GetLength(0); i++)
                            {
                                int cerosEnFila = ContarCerosEnFila(matrizp, i);
                                Console.WriteLine($"En la fila {i + 1} hay {cerosEnFila} ceros.");
                            }
                            break;

                        case "b":

                            Console.Clear();
                            int[,] matriz = new int[5, 5];
                            Console.WriteLine("Ingrese los valores de la  matriz (5x5):");
                            leermatriz(matriz);
                            Console.WriteLine("\nMatriz:");
                            Mostrarmatriz(matriz);

                            for (int i = 0; i < matriz.GetLength(0); i++)
                            {
                                int cerosEnFila = ContarCerosEnFila(matriz, i);
                                Console.WriteLine($"En el renglón {i + 1} hay {cerosEnFila} ceros.");
                            }
                            break;

                        case "c":
                            if (opcion2 == "c")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                            }
                            break;
                    }
                    break;

                case 2:
                    for (int fila = 0; fila < 3; fila++)
                    {
                        for (int columna = 0; columna < 3; columna++)
                        {
                            while (true)
                            {
                                Console.WriteLine($"Ingresa el valor para ({fila} {columna}): ");
                                if (fila == columna)
                                {
                                    if (int.TryParse(Console.ReadLine(), out int valor) && valor > 0)
                                    {
                                        agregar(fila, columna, valor, 0);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero de la diagonal debe ser mayor que 0");
                                    }

                                }
                                else
                                {
                                    if (int.TryParse(Console.ReadLine(), out int valor))
                                    {
                                        agregar(fila, columna, valor, 0);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Eso no es un numero");
                                    }
                                }
                            }
                        }
                    }
                    Console.Clear();

                    Console.WriteLine("Matriz original");
                    soloMostrar(0, 3);
                    cerodiagonal();
                    break;

                case 3:
                    return;
            }
        }
    }

    static void leermatriz(int[,] matrizes)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Elemento [{i + 0},{j + 0}]: ");
                string input = Console.ReadLine();

                if (input.Contains(","))
                {
                    Console.WriteLine("¡Error! Por favor, ingresa valores válidos.");
                    j--;
                    continue;
                }

                matrizes[i, j] = int.Parse(input);
            }
        }
    }

    static void Mostrarmatriz(int[,] matrizes)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matrizes[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Método para contar ceros en una fila de la matriz
    static int ContarCerosEnFila(int[,] matriz, int fila)
    {
        int contador = 0;
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            if (matriz[fila, j] == 0)
            {
                contador++;
            }
        }
        return contador;
    }




    public void agregar(int fila, int columna, int valor, int idMatriz)
    {
        matrices[idMatriz][fila, columna] = valor;
    }


    public void soloMostrar(int idMatriz, int dimension)
    {
        for (int fila = 0; fila < dimension; fila++)
        {
            Console.Write("[ ");
            for (int columna = 0; columna < dimension; columna++)
            {
                Console.Write(matrices[idMatriz][fila, columna] + "  ");
            }
            Console.WriteLine("]");
        }
    }




        

    public void cerodiagonal()
    {
        for (int fila = 0; fila < 3; fila++)
        {
            // Paso 1: Obtener el pivote de la fila actual
            int pivote = matrices[0][fila, fila];

            if (pivote == 0)
            {
                Console.WriteLine("Error: El pivote es cero. La matriz es singular.");
                return; 
            }

            // Paso 2: Dividir todos los elementos de la fila por el pivote
            for (int columna = 0; columna < 3; columna++)
            {
                matrices[0][fila, columna] /= pivote;
            }

            // Paso 3: Hacer ceros en otras filas
            for (int filas = 0; filas < 3; filas++)
            {
                // Salta la fila actual
                if (filas != fila)
                {
                    int factor = matrices[0][filas, fila];

                    for (int columna = 0; columna < 3; columna++)
                    {
                        matrices[0][filas, columna] -= factor * matrices[0][fila, columna];
                    }
                }
            }

            Console.WriteLine($"Paso {fila + 1}:");
            soloMostrar(0, 3);
        }
    }
    //------
}
