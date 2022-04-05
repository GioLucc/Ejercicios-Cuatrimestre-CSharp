using System;
using ClassLibrary;
using Clase_02___Objetos_;

namespace Ejercicio_3_2_
{
    class Program
    {
        /*
         * Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

            Deberá tener los atributos:

            nombre
            fechaDeNacimiento
            dni
            Deberá tener un constructor que inicialice todos los atributos.

            Construir los siguientes métodos para la clase:

            Setter y getter para cada uno de los atributos.
            CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
            Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
            EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
            Instanciar 3 objetos de tipo Persona en el método Main.
            Mostrar quiénes son mayores de edad y quiénes no.

        */
        static void Main(string[] args)
        {
            //double añosSegunNacimiento;

            Persona silvia = new Persona("Silvia","08/08/1962",19898234);
            Persona carlos = new Persona("Carlos", "05/10/2010", 19898234);
            Persona horacio = new Persona("Horacio", "01/04/1958", 19754756);
            Persona eride = new Persona("Eride", "25/09/1935", 19754756);

            /*
            Console.ForegroundColor = ConsoleColor.Magenta;
            añosSegunNacimiento = silvia.CalcularEdad(silvia.fechaDeNacimiento);
            Console.WriteLine(silvia.nombre + " Tiene " + añosSegunNacimiento + " años!");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            añosSegunNacimiento = carlos.CalcularEdad(carlos.fechaDeNacimiento);
            Console.WriteLine(carlos.nombre + " Tiene " + añosSegunNacimiento + " años!");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            añosSegunNacimiento = carlos.CalcularEdad(eride.fechaDeNacimiento);
            Console.WriteLine(eride.nombre + " Tiene " + añosSegunNacimiento + " años!");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            añosSegunNacimiento = horacio.CalcularEdad(horacio.fechaDeNacimiento);
            Console.WriteLine(horacio.nombre + " Tiene " + añosSegunNacimiento + " años!");
            Console.ResetColor();
            Console.ReadKey();
            */

            Console.WriteLine(silvia.Mostrar());
            Console.WriteLine(carlos.Mostrar());
            Console.WriteLine(eride.Mostrar());
            Console.WriteLine(horacio.Mostrar());

            Console.WriteLine(horacio.EsMayorDeEdad());
            Console.WriteLine(carlos.EsMayorDeEdad());


            Console.ReadKey();

        }
    }
}
