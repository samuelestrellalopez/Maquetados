using System;
using System.Collections.Generic;
using System.Text;

class Program{
    static void Main(){
        
        Console.WriteLine("************************************* PRACTICA DE PILAS *************************************");

        PilaLigada pilaNueva = new();
        int n;
        do{
            Console.Write("\nQué desea hacer:\n1) Agregar\n2) Sacar\n3) Ver el elemento de encima\n4) Imprimir la pila\n5) Buscar\n6) Salir\n\nSu opcion:");
            n = Convert.ToInt16(Console.ReadLine());
            switch (n)
            {
            case 1:
            Console.Write("\nIngresa el elemento: ");


            string elemento = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(elemento)) {
            pilaNueva.Agrega(elemento);
            } else {
            Console.WriteLine("No se permite ingresar elementos vacíos.");
            }
            Console.ReadKey();
            break;

                case 2:
                    Console.WriteLine("\nEl elemento extraido es: "+pilaNueva.Retira()+"\n");
                    Console.ReadKey();
                break;
                case 3:
                    Console.WriteLine("\nEl superior es: "+pilaNueva.Tope()+"\n");
                    Console.ReadKey();
                break;
                case 4:
                    pilaNueva.Imprime();
                    Console.ReadKey();
                break;
                case 5:
                    object dato;
                    Console.Write("\nIngresa el dato que deseas buscar: ");
                    dato = Console.ReadLine()!;
                    if ( pilaNueva.busqueda(dato) ){
                        Console.WriteLine("El elemento está en la pila");
                    }
                    else {
                        Console.WriteLine("El elemento no está en la pila");
                    }
                    Console.ReadKey();
                break;
                case 6:                    
                break;
                default:
                break;
            }
        } while ( n != 6 );
    }
}