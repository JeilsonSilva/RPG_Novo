using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RPG
{
    internal class Status
    {
        int tempo = 1;
        public int Vida = 100;
        public int Menos_Vida;
        public int Vida_Atual;

        public int energia = 100;
        public int Menos_Energia;
        public int Energia_Atual;


        public void vida()
        {
            Vida_Atual = Vida - Menos_Vida;





            Console.Write("Vida:    ");
            for (int i = 0; i < Vida_Atual; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Thread.Sleep(tempo);
                Console.Write('*');


            }
             Console.ResetColor();
            if (Menos_Vida > 0)
            {
                
                for (int i = 0; i < Menos_Vida; i++)
                {


                    Thread.Sleep(tempo);
                    Console.Write('*');


                }
            }
            Console.WriteLine();


        }

        public void Energia()
        {
            
            Energia_Atual = energia - Menos_Energia;


            Console.Write("Energia: ");
            for (int i = 0; i < Energia_Atual; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Thread.Sleep(tempo);
                Console.Write('*');


            } 

            Console.ResetColor();

            if (Menos_Energia > 0)
            {
               
                for (int i = 0; i < Menos_Energia; i++)
                {


                    Thread.Sleep(tempo);
                    Console.Write('*');


                }
            }
            Console.WriteLine();
            Console.WriteLine();

        }



        public void vidaparada()
        {


           
            Vida_Atual = Vida - Menos_Vida;



            Console.Write("Vida:    ");
            for (int i = 0; i < Vida_Atual; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;


                Console.Write('*');


            }

            Console.ResetColor();

            if (Menos_Vida > 0)
            {
                
                for (int i = 0; i < Menos_Vida; i++)
                {



                    Console.Write('*');


                }
            }
            Console.WriteLine();


        }

        public void Energiaparada()
        {


          
            Energia_Atual = energia - Menos_Energia;


            Console.Write("Energia: ");
            for (int i = 0; i < Energia_Atual; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;


                Console.Write('*');


            }

            Console.ResetColor();

            if (Menos_Energia > 0)
            {
               
                for (int i = 0; i < Menos_Energia; i++)
                {



                    Console.Write('*');


                }
            }
            Console.WriteLine();
            Console.WriteLine();

        }






    }
}
