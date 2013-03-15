using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4_3_16
{
    class Persona16
    {
        public Persona16(int altura, int peso, string colorOjos, string colorPelo)
        {
            this.altura16 = altura;
            this.colorOjos16 = colorOjos;
            this.colorPelo16 = colorPelo;
            this.peso16 = peso;
        }

        private int peso16;
        public int Peso16
        {
            get { return peso16; }
            set { peso16 = value; }
        }

        private int altura16;
       public int Altura16
        {
            get { return altura16; }
            set { altura16 = value; }
        }

        private string colorOjos16;
        public string ColorOjos16
        {
            get { return colorOjos16; }
            set { colorOjos16 = value; }
        }

        private string colorPelo16;
       public string ColorPelo16
        {
            get { return colorPelo16; }
            set { colorPelo16 = value; }
        }

        public void PonerLentillas16(string colorLentillas)
        {
            if (comprobarColor16(colorLentillas))
                this.ColorOjos16 = colorLentillas;
        }

        private static bool comprobarColor16(string colorLentillas)
        {
            return colorLentillas.Equals("azul") || colorLentillas.Equals("marrón") || colorLentillas.Equals("verde");
        }

        public void Engordar16(int cantidad)
        {
            int nuevo_peso = this.Peso16 + cantidad;
            if (nuevo_peso > 180)
            {
                Console.WriteLine("Cantidad incorrecta");
            }
            else
            {
                Console.WriteLine("Incrementando el peso en {0} kg", cantidad);
                this.Peso16 = nuevo_peso;
            }
        }

        public void Adelgazar16(int cantidad)
        {
            int nuevo_peso = this.Peso16 - cantidad;
            if (nuevo_peso < 40)
            {
                Console.WriteLine("Cantidad incorrecta");
            }
            else
            {
                Console.WriteLine("Reduciendo el peso en {0} kg", cantidad);
                this.Peso16 = nuevo_peso;
            }
        }
    }
}
