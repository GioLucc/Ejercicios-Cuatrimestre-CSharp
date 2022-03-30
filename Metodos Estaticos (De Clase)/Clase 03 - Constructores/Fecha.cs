using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03___Constructores
{
    class Fecha
    {
        #region atributos

        private int aaaa;
        private int mm;
        private int dd;

        public static int estatico;
        public int no_estatico;



        public static void MostrarEstatico()
        {
            Console.WriteLine(Fecha.estatico);
        }

        public void MostrarNoEstatico()
        {
            // this.no_estatico;  This no es valido, no va en estatico.
            Console.WriteLine(this.no_estatico);
        }

        public void MostrarTodos()
        {
            Fecha.MostrarEstatico();
            this.MostrarNoEstatico();
        }

        public Fecha()
        {
            Fecha cuando = new Fecha();
            // Se pueden inicializar dentro del constructor no fijo, pero al ya haberlos hecho, todos salen con esos datos
            this.aaaa = 2018;
            this.mm = 12;
            this.dd = 9;

        }

        public Fecha (int anio, int mes, int dia)
        {
            this.aaaa = anio;
            this.mm = mes;
            this.dd = dia;
        }

        Fecha cuando = new Fecha(2018, 12, 9); // Parametrizado
    }
}
