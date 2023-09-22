using System;

class matrices
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Calcula la suma de las matrices  ");
            Console.WriteLine("2. Calcular la resta de las matrices");
            Console.WriteLine("3. Calcular el producto de las matrices");
            Console.WriteLine("4. Calcula la division de las matrices");
            Console.WriteLine("5. Salir");


            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 5)
            {
                break; 
            }


            float[,] matriz1 = new float[2, 2];
            float[,] matriz2 = new float[2, 2];


            Console.Clear();


            Console.WriteLine("Ingrese los valores de la primera matriz (2x2):");
            leermatriz(matriz1);

            Console.WriteLine("Ingrese los valores de la segunda matriz (2x2):");
            leermatriz(matriz2);
            Console.Clear();


            Console.WriteLine("\nMatriz 1:");
            Mostrarmatriz(matriz1);

            Console.WriteLine("\nMatriz 2:");
            Mostrarmatriz(matriz2);


            switch (opcion)
            {
                

                case 1:

                    float[,] suma = SumarMatrices(matriz1, matriz2);
                    Console.WriteLine("\nSuma de las matrices:");
                    Mostrarmatriz(suma);
                    break;

                case 2:
                    float[,] resta = Restarmatrices(matriz1, matriz2);
                    Console.WriteLine("\nResta de las matrices:");
                    Mostrarmatriz(resta);
                    break;

                case 3:
                    float[,] producto = productomatrices(matriz1, matriz2);
                    Console.WriteLine("\nProducto de las matrices:");
                    Mostrarmatriz(producto);
                    break;

                case 4:
                    float[,] division = divisiondematriz(matriz1, matriz2);
                    Console.WriteLine("\nDivisión de las matrices:");
                    Mostrarmatriz(division);
                    break;

            }
        }
    }

    
   static void leermatriz(float[,] matriz)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Elemento [{i + 0},{j + 0}]: ");
                string input = Console.ReadLine();


                if (input.Contains(","))
                {
                    Console.WriteLine("¡Error! Por favor, ingresa valores válidos.");
                    j--; 
                    continue;
                }

                matriz[i, j] = float.Parse(input);
            }
        }
    }


    static void Mostrarmatriz(float[,] matriz)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }



    static float[,] SumarMatrices(float[,] matriz1, float[,] matriz2)
    {
        float[,] suma = new float[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                suma[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        return suma;
    }

    static float[,] Restarmatrices(float[,] matriz1, float[,] matriz2)
    {
        float[,] resta = new float[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                resta[i, j] = matriz1[i, j] - matriz2[i, j];
            }
        }

        return resta;
    }


    static float[,] productomatrices(float[,] matriz1, float[,] matriz2)
    {
        float[,] producto = new float[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                producto[i, j] = matriz1[i, j] * matriz2[i, j];
            }
        }

        return producto;
    }

    static float[,] divisiondematriz(float[,] matriz1, float[,] matriz2)
    {
        float[,] division = new float[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                division[i, j] = matriz1[i, j] / matriz2[i, j];
            }
        }

        return division;
    }
}
