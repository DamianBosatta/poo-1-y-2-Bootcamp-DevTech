using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampPoo2Eje4Y5
{
    class AlbumFotos
    {
        int numPaginas;

       public int NumPaginas { get => numPaginas; set => numPaginas = value; }


        public AlbumFotos()
        {

            this.NumPaginas = 16;
        }


        public AlbumFotos(int canPaginas)
        {
            this.numPaginas = canPaginas;
            Console.WriteLine( " Cantidad de paginas disponibles : " +   numPaginas   );

        }
    }
}
