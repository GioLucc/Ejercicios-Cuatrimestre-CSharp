using System;
using Clase_02___Objetos_;

namespace Ejercicio_2_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtyOfNumbersEntered;
            int numberEntered;
            int minNumber = 0;
            int maxNumber = 0;

            Validator.errorCounter = 0;
            qtyOfNumbersEntered = 0;

            do
            {
                Seal.message = "Enter a number to validate it, we will add it to our system!\nWe need 10 numbers between -100 and 100!\n";
                Seal.color = ConsoleColor.DarkMagenta;
                Seal.PrintInColor();
                numberEntered = int.Parse(Console.ReadLine());


                while (!Validator.ValidateWithTries(numberEntered, -100, 100, Validator.errorCounter))
                {
                    Validator.errorCounter++;
                    Seal.message = ("ERROR el numero que puso fue erroneo! Reintente nuevamente poner un numero entre -100 y 100!\n");
                    Seal.color = ConsoleColor.Red;
                    Seal.PrintInColor();
                    numberEntered = int.Parse(Console.ReadLine());
                }

                if(numberEntered < minNumber)
                {
                    minNumber = numberEntered;
                }
                else
                {
                    if(numberEntered > maxNumber)
                    {
                        maxNumber = numberEntered;
                    }
                }

                if(Validator.errorCounter == 3)
                {
                    Validator.errorCounter = 0;
                    break;
                }

                qtyOfNumbersEntered++;

            } while (qtyOfNumbersEntered < 10);

         
           
        }

    }
}