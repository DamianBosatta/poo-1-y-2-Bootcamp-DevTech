using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampPoo2Eje4Y5
{



    class Estudiante : Persona
    {

        public Estudiante()
        {


        }
        public Estudiante(string nombre) : base(nombre)
        {


        }

        public void MensjEstudiando()
        {
            Console.WriteLine(" Estoy Estudiando ");
        }

        public void verEdad()
        {
            Console.WriteLine(" ingrese la edad del estudiante ");
            int auxEdad = int.Parse(Console.ReadLine());
            SetEdad(auxEdad);

            Console.WriteLine(" la edad del estudiante es : " + Edad);

        }



    }
}

