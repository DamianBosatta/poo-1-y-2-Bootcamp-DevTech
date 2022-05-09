using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampPoo2Eje4Y5
{
   

        class Eiffel
        {
            int elemento;


            private int Elemento { get => elemento; set => elemento = value; }

            public Eiffel()
            {

            }

            public void insertarElem(List<int> Lis)
            {
                int CantidadElem = 0;
                int Elem = 0;
                Console.WriteLine(" Cuantos numeros desea cargar ? ");
                CantidadElem = int.Parse(Console.ReadLine());
                Console.WriteLine(" Ingrese numero, no importa el orden ");
                Console.Write(" Nuestro sistema lo ordenara por usted ");


                for (int i = 0; i <= CantidadElem; i++)
                {

                    Console.WriteLine(" \n Ingrese Numero : " + i);
                    Elem = int.Parse(Console.ReadLine());
                    this.Elemento = Elem;
                    Lis.Add(Elemento);

                    Lis.Sort();

                }




            }

            public void Verlista(List<int> Lis)
            {
                for (int i = 0; i < Lis.Count; i++)
                {

                    Console.WriteLine(Lis[i]);


                }



            }

            public int cantElementosLista(List<int> Lis)
            {
                int contador = 0;
                for (int i = 0; i < Lis.Count; i++)
                {
                    contador = i;


                }
                if (contador == 0)
                {

                    Console.WriteLine(" La lista esta vacia " + contador);
                    return contador;
                }
                else
                    Console.WriteLine(" la carga total de la lista es : " + contador + " Elementos ");
                return contador;

            }
            public void BuscarElemento(List<int> Lis)
            {
                Console.WriteLine(" Que posicion esta su elemento ");
                int posicionAbuscar = int.Parse(Console.ReadLine());
                bool Flag = false;
                for (int i = 0; i < Lis.Count && Flag == false; i++)
                {
                    if (posicionAbuscar == i)
                    {
                        Flag = true;
                        Console.WriteLine(" posicion existente , el elemento en la posicion es : " + Lis[i]);

                    }





                }
                if (Flag == false)
                {

                    Console.WriteLine(" la posicion no existe ");

                }



            }
            public void Poda(List<int> Lis)
            {
                if (Lis != null)
                {
                    Lis.RemoveAt(0);

                    Console.WriteLine(" Posicion inicial Eliminada  ");
                }
                else
                    Console.WriteLine(" la lista no contiene datos");

            }



        }
    }
