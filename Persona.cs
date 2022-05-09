using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampPoo2Eje4Y5
{
    class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public Persona(string nombre)
        {

            Nombre = nombre;


        }
        public Persona()
        {

        }

        public void Saludar()
        {

            Console.WriteLine(" Hola !!! Buen dia ");

        }
        public void SetEdad(int INTedad)
        {
            Edad = INTedad;


        }

        public override string ToString()
        {
            return " mi nombre es :  " + Nombre;
        }



    }
}