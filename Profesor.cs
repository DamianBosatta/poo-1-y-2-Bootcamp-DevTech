using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampPoo2Eje4Y5
{
    class Profesor : Persona
    {

        public Profesor()
        {

        }
        public Profesor(string nombre) : base(nombre)
        {


        }

        public void Explicando()
        {

            Console.WriteLine(" Estoy explicando ");

        }

    }
}