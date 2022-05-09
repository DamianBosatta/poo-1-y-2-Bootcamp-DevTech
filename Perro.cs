using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampPoo2Eje4Y5
{
    class Perro:Animal
    {
        public Perro(string nombre)
        {
            this.Nombre = nombre;


        }

        public override void Comer()
        {


            Console.WriteLine(" el perro " + Nombre + " esta comiendo ");

        }
    }
}
