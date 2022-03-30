using System;
using Classes_Library;

namespace Ejercicio_2_4_
{
    /*
     *  Consigna
        Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
        Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
        Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.
        Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
        Este método devolverá true si el operando es distinto de cero.
        Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).
        El usuario decidirá cuándo finalizar el programa.
     */

    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            char mathematicalSymbol;
            int result;
            char continueCalculating;

            do
            {
                Console.WriteLine("Enter the first number to do a mathematical operation!");
                while (!int.TryParse(Console.ReadLine(), out firstNumber)) // !Validación de numeros || Validación de cadena
                {
                    Console.WriteLine("ERROR! You have entered something different than a number, RE-Enter it: ");
                }

                Console.WriteLine("Enter the second number to do a mathematical operation!");
                while (!int.TryParse(Console.ReadLine(), out secondNumber)) // !Validación de numeros || Validación de cadena
                {
                    Console.WriteLine("ERROR! You have entered something different than a number, RE-Enter it: ");
                }
                Console.WriteLine("Enter the symbol of which mathematical operation you want to do!");
                while (!char.TryParse(Console.ReadLine(), out mathematicalSymbol)) // !Validación de numeros || Validación de cadena
                {
                    Console.WriteLine("ERROR! You have entered something different than a mathemathical symbol, RE-Enter it: ");
                }

                result = Calculator.Calculate(firstNumber, secondNumber, mathematicalSymbol);

                Console.WriteLine("The result is {0}", result);

                Console.WriteLine("You want to keep making use of the calculator? S to continue or whatever to stop!");
                continueCalculating = char.Parse(Console.ReadLine());

            }while(Validator.ValidateAnswer(continueCalculating));

            
        }
    }
}
