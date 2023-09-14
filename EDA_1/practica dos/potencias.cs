using System;

class Calcularpotencia
{

    //calcular la potencia fiboncacci y torres de hanei


    //static double calculopotencia(double bnumero, int exponente)
    //{
    //if (exponente == 0) 

    //return 1;

    //return bnumero * calculopotencia(bnumero , exponente -1);

    //
    static double calculopotencia(double bnumero, int exponente)
    {
        const int limiteExponente = 10000;

        if (exponente > limiteExponente)
        {
            Console.WriteLine("Exponente incalculable");
            return 0;
        }


        if (exponente == 0)
            return 1;

        return bnumero * calculopotencia(bnumero, exponente - 1);
    }




    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Calcular potencia");
            Console.WriteLine("2. Calcular factorial");
            Console.WriteLine("3. Calcular Fibonacci");
            Console.WriteLine("4. Resolver Torres de Hanoi");
            Console.WriteLine("5. Calcular MCD");
            Console.WriteLine("0. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                
    
                case 1:
                    Console.Write("Introduce el número base: ");
                    double bnumero = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Introduce la potencia: ");
                    int exponente = Convert.ToInt32(Console.ReadLine());

                    double resultadoPotencia = calculopotencia(bnumero, exponente);

                    Console.WriteLine($"{bnumero} elevado a la {exponente} es igual a {resultadoPotencia}");
                    break;

                case 2:
                    Console.Write("Introduce un número para calcular su factorial: ");
                    double numeroFactorial = Convert.ToDouble(Console.ReadLine());

                    double resultadoFactorial = factorial(numeroFactorial);

                    Console.WriteLine($"Factorial de {numeroFactorial} es igual a {resultadoFactorial}");
                    break;

                case 3:
                    Console.Write("Introduce un número menor a 40: ");
                    int numFibonacci = Convert.ToInt32(Console.ReadLine());
                    const int limite = 40;

                    if (numFibonacci > limite)
                    {
                        Console.WriteLine(" Ingresa un numero menor a 40");
                    }
                    else
                    {
                        for (int i = 0; i < numFibonacci; i++)
                        {
                            Console.Write(Fibonacci(i) + ", ");
                        }

                    }
                   
                    Console.WriteLine();
                    break;

                case 4:
                    Console.Write("Introduce el número de discos para las Torres de Hanoi: ");
                    int discosHanoi = Convert.ToInt32(Console.ReadLine());
                    

                    Console.WriteLine($"\nSolución para Torres de Hanoi con {discosHanoi} discos:");
                    TorresDeHanoi(discosHanoi, 'A', 'C', 'B');
                    break;



                case 5:
                    Console.Write("Ingrese el primer número: ");
                    int numero1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Ingrese el segundo número: ");
                    int numero2 = Convert.ToInt32(Console.ReadLine());

                    if (numero1 == 1 || numero2 == 1)
                    {
                        Console.WriteLine("Uno de los números es igual a 1, por lo que no hay un máximo común divisor.");
                    }
                    else
                    {
                        int mcd = maxcd(numero1, numero2);

                        if (mcd == 1)
                        {
                            Console.WriteLine($"El MCD de {numero1} y {numero2} es 1, lo que significa que no tienen ningún múltiplo en común además de 1.");
                        }
                        else
                        {
                            Console.WriteLine($"El MCD de {numero1} y {numero2} es {mcd}");
                        }
                    }
                    break;


                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }

            Console.WriteLine(Environment.NewLine);
        }
    }

    //Factorial
    static double factorial(double bnumero)
    {
        const int limite = 10000;

        if (bnumero > limite)
        {
            Console.WriteLine("Exponente incalculable");
            return 0;
        }


        if ((bnumero == 0) || (bnumero == 1))
        {
            return 1;
        }
        else
        {
            return bnumero * factorial(bnumero - 1);
        }
    }

    //Fibonacci
    static int Fibonacci(int n)
    {
   
        if (n <= 0)
            return 0;

        if (n == 1)
            return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }



    //torresdehanoi
    static void TorresDeHanoi(int n, char origen, char destino, char auxiliar)
    {

        if (n == 1)
        {
            Console.WriteLine($"Mueve el disco 1 de la torre {origen} a la torre {destino}");
            return;
        }

        TorresDeHanoi(n - 1, origen, auxiliar, destino);
        Console.WriteLine($"Mueve el disco {n} de la torre {origen} a la torre {destino}");
        TorresDeHanoi(n - 1, auxiliar, destino, origen);
    }

    //mcd
    static int maxcd(int num1, int num2)
    {
        if (num2 == 0)
        {
            return num1;
        }
        else
        {
            return maxcd(num2, num1 % num2);
        }
    }


}