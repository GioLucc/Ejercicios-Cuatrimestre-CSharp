using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_02___Objetos_;

namespace Ejercicio_2_1_
{
    class Validator
    {
        public static int errorCounter;

        public static bool Validate(int value, int min, int max)
        {
            bool validator = false;
            int errorCounter = 0;

            while (value < min || value > max)
            {
                errorCounter++;

                if(errorCounter == 3)
                {
                    Seal.color = ConsoleColor.Red;
                    Seal.message = "You have exceeded the limits of tries - Exiting Program after the next key is pressed";
                    Seal.PrintInColor();
                    Console.ReadKey();
                    break;
                }

                return validator;
            }

            return validator = true;
        }

        public static bool ValidateWithTries(int value, int min, int max, int errorCounter)
        {
            bool validator = false;

            while (value < min || value > max)
            {
                if (errorCounter == 3)
                {
                    Seal.color = ConsoleColor.Red;
                    Seal.message = "\nYou have exceeded the limits of tries - Exiting Program after the next key is pressed";
                    Seal.PrintInColor();
                    Console.ReadKey();

                    if(errorCounter == 3)
                    {
                        break;
                    }
                }

                return validator;
            }

            return validator = true;
        }

    }
}
