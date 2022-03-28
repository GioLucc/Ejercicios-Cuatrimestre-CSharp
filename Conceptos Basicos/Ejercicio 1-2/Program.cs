using System;

namespace Ejercicio_1_2_

// Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
{
    class Program
    {
        static void Main(string[] args)
        {
            int enteredNumber;

            Console.Write("Enter a number greater than 0: ");
            enteredNumber = int.Parse(Console.ReadLine());

            while(enteredNumber < 1)
            {
                Console.WriteLine("ERROR. !Re-enter the number");
                enteredNumber = int.Parse(Console.ReadLine());
            }

            double enteredNumberSquared = Math.Pow(enteredNumber, 2);
            double enteredNumberCubed = Math.Pow(enteredNumber, 3);

            Console.WriteLine("\nThe Squared number you have entered is {0}! & the Cubed {1}!",enteredNumberSquared,enteredNumberCubed);

            Console.ReadKey();



        }
    }
}
