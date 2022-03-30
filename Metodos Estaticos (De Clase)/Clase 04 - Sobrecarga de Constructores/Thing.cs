using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04___Sobrecarga_de_Constructores_
{
    class Thing
    {
        // SI ES STATIC NO ES INSTANCIA
        // THIS INSTANCIA
        // CLASE ESTATICO

        private int entero; // TODOS PRIVADOS Y TODOS DE INSTANCIA
        private string cadena;
        private DateTime fecha;

        public void EstablecerValor(int valor1)
        {
            this.entero = valor1;
        }
        public void EstablecerValor(string texto)
        {
            this.cadena = texto;
        }
        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public static string Mostrar(Thing c)
        {
            return c.Mostrar();
        }

        private string Mostrar()
        {
            return "Entero: " + this.entero + "Cadena: " + this.cadena +
                "Fecha: " + this.fecha.ToShortDateString();
        }
    }
}
