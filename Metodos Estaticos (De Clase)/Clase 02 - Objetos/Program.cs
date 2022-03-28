using System;

namespace Clase_02___Objetos_
{
    class Program
    {
        static void Main(string[] args)
        {
            Seal.message = "¡Hello World!";
            Console.WriteLine(Seal.Print());
            Seal.Delete();

            Seal.message = "\n¡I am extremely obese!";
            Seal.color = ConsoleColor.DarkMagenta;
            Seal.PrintInColor();

            Seal.Delete();
            Seal.message = "\nI'm coding in C#";
            Seal.color = ConsoleColor.DarkYellow;
            Seal.PrintInColor();
            Seal.Delete();

            Seal.color = ConsoleColor.DarkMagenta;
            Seal.message = "\nAnd I'm pretty noob in it";
            Seal.color = ConsoleColor.Red;
            Seal.PrintInColor();
         

            Console.ReadKey();
        }
    }
}
