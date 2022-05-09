using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampPoo2Eje4Y5
{
    class Coche : Ivehiculo
    {
       private int cantComVehiculo;

        public int CantComVehiculo { get => cantComVehiculo; set => cantComVehiculo = value; }
        
        public Coche(int cantLiVehiculo)
        {

            this.CantComVehiculo = cantLiVehiculo;


        }

        

        public void conducir()
        {

            if (CantComVehiculo > 0)
            {

                Console.WriteLine(" El coche esta siendo conducido ");


            }


        }


        public bool cargaNafta(int gasAcargar)
        {


            this.cantComVehiculo = cantComVehiculo + gasAcargar;
            return true;




        }





    }
}
