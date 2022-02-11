using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] poderes = {{"Poderes", "Nivel", "Especificidad"}, {"Fuego", "2", "Quema al objetivo"}, {"Rayo", "1", "Electrocuta al objetivo"}, {"Paralizar", "5", "Paraliza al objetivo"}};

            //Filas
            for (int i=0; i<4; i++)
            {
                //Columnas
                for (int j=0; j<3; j++)
                {
                    //El if no sirve ya que los "case" tienen el control.
                    //if (j>0)
                    //{
                        switch (poderes[i,j])
                        {
                        //Primera Fila:

                        //Primera columna
                        case "Nivel":
                        {
                            for(int z=0; z<8; z++)
                            {
                                Console.Write(" ");
                            }
                            //Console.Write("Nivel");
                        }
                        break;

                        //Segunda columna
                        case "Especificidad":
                        {
                            for(int z=0; z<8; z++)
                            {
                                Console.Write(" ");
                            }
                            //Console.Write("Especificidad");
                        }
                        break;

                        //Segunda Fila:

                        //Primera columna
                        case "2":
                        {
                            for(int z=0; z<12; z++)
                            {
                                Console.Write(" ");
                            }
                            //Console.Write("2");
                        }
                        break;

                        //Segunda columna
                        case "Quema al objetivo":
                        {
                            for(int z=0; z<10; z++)
                            {
                                Console.Write(" ");
                            }
                            //Console.Write("Quema al objetivo");
                        }
                        break;

                        //Tercera Fila:

                        //Primera columna
                        case "1":
                        {
                            for(int z=0; z<13; z++)
                            {
                                Console.Write(" ");
                            }
                            //Console.Write("1");
                        }
                        break;

                        //Segunda columna
                        case "Electrocuta al objetivo":
                        {
                            for(int z=0; z<10; z++)
                            {
                                Console.Write(" ");
                            }
                            //Console.Write("Electrocuta al objetivo");
                        }
                        break;

                        //Cuarta Fila:

                        //Primera columna
                        case "5":
                        {
                            for(int z=0; z<8; z++)
                            {
                                Console.Write(" ");
                            }
                            //Console.Write("5");
                        }
                        break;

                        //Segunda columna
                        case "Paraliza al objetivo":
                        {
                            for(int z=0; z<10; z++)
                            {
                                Console.Write(" ");
                            }
                            //Console.Write("Paraliza al objetivo");
                        }
                        break;
                        }

                    //}
                    
                    //Escribe la primera columna
                    Console.Write(poderes[i,j]);
                }
                

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}