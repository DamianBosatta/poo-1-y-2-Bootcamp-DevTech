using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampPoo2Eje4Y5
{
    class AlbumTest:AlbumFotos
    {
        
        
        public AlbumTest()
        {

        }

       public void MostarAlbumDefault()
        {
            AlbumFotos Album = new AlbumFotos();
            Console.WriteLine(" El Album por default tiene : " + this.NumPaginas + " Paginas ");



        }
        public void AlbumGrande()
        {
            SuperAlbumFotos bigalbum = new SuperAlbumFotos();
            Console.WriteLine(" el album grande tiene en total : " + bigalbum.NumPaginas + " Paginas ");


        }

        public void albumUsuario()
        {
            Console.WriteLine(" Cuantas paginas desea que tenga su album ?");
            int cantPaginas = int.Parse(Console.ReadLine());
            AlbumFotos cantUsuario = new AlbumFotos(cantPaginas);
            this.NumPaginas = cantPaginas;

            Console.WriteLine(" A preparado un album de : " + this.NumPaginas + " Paginas ");
        }

    }
}
