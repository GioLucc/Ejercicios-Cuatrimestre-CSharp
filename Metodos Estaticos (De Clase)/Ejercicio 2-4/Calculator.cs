using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_4_
{
    public class Calculator
    {
        public static int Calculate(int firstNumber, int secondNumber, char mathematicalOperationSymbol)
        {
            int operationResult;

            operationResult = 0;

            switch (mathematicalOperationSymbol)
            {
                case '+':
                    operationResult = firstNumber + secondNumber;
                    break;

                case '-':
                    operationResult = firstNumber - secondNumber;
                    break;

                case '*':
                    operationResult = firstNumber * secondNumber;
                    break;

                case '/':

                    while(!Validate(secondNumber))
                    {
                        Console.WriteLine("ERROR - You have to enter a number different than 0 to realize a division!");
                        secondNumber = int.Parse(Console.ReadLine());
                    }   

                    operationResult = firstNumber / secondNumber;
                    break;

            }

            return operationResult;
        }

        private static bool Validate(int secondNumber)
        {
            bool validation = false;

            if(secondNumber != 0)
            {
                validation = true;
            }

            return validation;
        }
    }
}
