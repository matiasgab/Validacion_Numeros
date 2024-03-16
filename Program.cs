using System;

namespace TPFinal_Lico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero.
            // A partir de dichos datos informar:

            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            int n1, mayorPar = 0, contadorImpar = 0, min = 0, contPrimo = 0;
            
            System.Console.WriteLine("Ingresar un numero: ");
            System.Console.WriteLine("Bienvenido a la validación de números");
            n1 = int.Parse(Console.ReadLine());

            while (n1 != 0)
            {   
                primoOno(n1);
                if (primoOno(n1) == true)
                {   
                    contPrimo++;
                    if (contPrimo == 1)
                    {
                        min = n1;
                    }
                    else if(n1 < min){
                        min = n1;    
                    }
                }
                if (n1 % 2 == 0){ //Evalua si es Par...
                    if (n1 > mayorPar){
                        mayorPar = n1;
                    }
                }
                else if(n1 % 2 != 0){ //Evalua si es Impar...
                    contadorImpar++;
                }             
        
            System.Console.WriteLine("Ingresar un numero: ");
            n1 = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("El mayor numero par ingresado es: " + mayorPar);
            System.Console.WriteLine("La cantidad ingresada de numeros impares es: " + contadorImpar);
            System.Console.WriteLine("El menor de los numeros primos ingresados es: " + min );
        }

        // Funcion que evalua si el numero es primo o no...
        static bool primoOno(int a){ 

            int contadorPrimo = 0;

                for (int x = 1; x <= a; x++)
                {
                    if(a % x == 0){
                    contadorPrimo++;}
                }

                if (contadorPrimo == 2){  
                    return true;  
                }else
                    return false;      
        }
    }
}
 