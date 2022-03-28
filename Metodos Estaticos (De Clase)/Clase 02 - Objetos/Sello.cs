using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02___Objetos_
{
    public class Seal // Clase, en este caso Seal [SOLO CONTIENE LOGICA]
    {
        /// <Modificadores de clases>
        /// abstract (No se puede instanciar)
        /// internal (Accesible en todo el proyecto [Assembly]
        /// public (Accesible desde ¡CUALQUIER! Proyecto)
        /// private (Accesor por defecto)
        /// sealed (No se podrá heredar)
        /// </summary>

        // Atributos

        public static string message; //<-- Atributo | Modificador [public] | tipo [string] | identificador [message]

        public static ConsoleColor color;

        // Atributos

        // Métodos

        public static string Print() // <-- Método | Modificador [public] | tipo [string] si return o void | identificador [Print()]
        {
            return ArmarFormatoMensaje();
        }

        public static void Delete()
        {
            Seal.message = "";
        }

        public static void PrintInColor()
        {
            Console.ForegroundColor = Seal.color;
            Console.WriteLine(Seal.Print());
            Console.ResetColor();
            
        }

        private static string ArmarFormatoMensaje() // <-- Método | Modificador [private] solo visible para su clase | tipo [string] si return o void; 
        {
            string messageSealFormat = "";

            for(int i = 0; i < Seal.message.Length+2; i++)
            {
                messageSealFormat = messageSealFormat + "*";
            }

            messageSealFormat += "\n*" + Seal.message + "*\n" + messageSealFormat + "\n";

            return messageSealFormat;
        }
        /*
        private static bool TryParse(string stringToParse,string stringToBeParced)
        {
            bool isAString = false;

            for(int i = 0; i < stringToParse.Length; i++)
            {
                if (stringToParse.Length == 0 && (stringToParse[i] == 1
                                                ||stringToParse[i] == 2
                                                ||stringToParse[i] == 3
                                                ||stringToParse[i] == 4
                                                ||stringToParse[i] == 5
                                                ||stringToParse[i] == 6
                                                ||stringToParse[i] == 7
                                                ||stringToParse[i] == 8
                                                ||stringToParse[i] == 9))
                {
                    return isAString;
                }
                else
                {
                    stringToBeParced = stringToParse;
                    isAString = true;
                    return isAString;
                }
            }

           

           
        }
        */
        // Métodos 
    }
}
