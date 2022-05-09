using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace BootcampPoo2Eje4Y5
{
    class Program

    {

        static void Main(string[] args)
        {
            Console.WriteLine(" Indique el numero de ejercicio que desea Ver ");
            Console.WriteLine( " Ejercicios Disponibles : \n 1-Clase Operacion con herencia Resta y Suma \n 2-Clase persona y herencia \n 3-Objeto:  CargaLista, Ordenamiento y Eliminacion \n 4-Clase Interfaz \n 5-Clase Abstracta \n 6- Album de Fotos ");
            int opc = 0;
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:

                    bool flag = false;
                    Suma suma1 = new Suma();
                    do
                    {
                        try
                        {
                            Console.WriteLine(" ingrese el primer valor para la suma");
                            suma1.Valor1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("ingrese el segundo valor para la suma ");
                            suma1.Valor2 = int.Parse(Console.ReadLine());
                            suma1.Operar();
                            Console.WriteLine("La suma de " + suma1.Valor1 + " y " +
                              suma1.Valor2 + " es " + suma1.Resultado);
                            flag = true;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message, " Se pide numero entero para la operacion, vuelva a intentar ");


                        }
                    } while (flag == false);

                    flag = false;
                    do
                    {
                        try
                        {
                            Resta resta1 = new Resta();
                            Console.WriteLine(" ingrese el primer valor para la resta");
                            resta1.Valor1 = int.Parse(Console.ReadLine());
                            Console.WriteLine(" ingrese els egundo valor para la resta ");
                            resta1.Valor2 = int.Parse(Console.ReadLine());
                            resta1.Operar();
                            Console.WriteLine("La diferencia de " + resta1.Valor1 +
                              " y " + resta1.Valor2 + " es " + resta1.Resultado);
                            flag = true;
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message, " Se pide numero entero para la operacion, vuelva a intentar ");

                        }
                    } while (flag == false);


                    break;
                case 2:

                    Persona Damian = new Persona();
                    Estudiante Lautaro = new Estudiante();
                    Profesor Teacher = new Profesor();
                    Persona[] arrPers = new Persona[3];

                    Damian.Saludar();
                    Lautaro.Saludar();
                    Lautaro.verEdad();
                    Teacher.SetEdad(45);
                    Teacher.Saludar();
                    Teacher.Explicando();
                    for (int i = 0; i < arrPers.Length; i++)
                    {
                        Estudiante Est2 = new Estudiante();
                        if (i == 0)
                        {
                            Teacher.Nombre = (Console.ReadLine());

                            Teacher.Edad = int.Parse(Console.ReadLine());
                            arrPers[i] = Teacher;
                        }
                        else
                        {

                            Est2.Nombre = Console.ReadLine();
                            Est2.Edad = int.Parse(Console.ReadLine());
                            arrPers[i] = Est2;



                        }

                    }


                    for (int i = 0; i < arrPers.Length; i++)
                    {

                        Console.WriteLine(arrPers[i].Edad);
                        Console.WriteLine(arrPers[i].Nombre);

                    }


            break;
                case 3:

                    Eiffel Clase = new Eiffel();
                    List<int> Lista = new List<int>();


                    Clase.insertarElem(Lista);
                    Clase.Verlista(Lista);
                    Clase.BuscarElemento(Lista);
                    Clase.Poda(Lista);
                    Clase.Verlista(Lista);




                    break;
                case 4:

                    Coche Vehiculo = new Coche(0);

                    Vehiculo.cargaNafta(45);
                    Vehiculo.conducir();
                    break;




                case 5:
            Console.WriteLine(" Indique el nombre del perro ");
            string nombre = Console.ReadLine();
            Perro Leire = new Perro(nombre);

            Leire.Comer();
                    break;

                case 6: AlbumTest Album1 = new AlbumTest();

                    Album1.MostarAlbumDefault();
                    Album1.AlbumGrande();
                    Album1.albumUsuario();

                    break;
             
        }
            Console.ReadKey();


        }
    }
}
