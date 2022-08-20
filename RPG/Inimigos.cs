using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Inimigos
    {
        public int vida;

        public void Esqueleto()
        {
            
           Random rand = new Random();
            int jogador1;
            int jogador2 = rand.Next(1, 4);


            Console.WriteLine("=======JoKenPo=====\n" +
                             "Escolha as opções a seguir\n" +
                                "1-Pedra\n" +
                                "2-Papel\n" +
                                "3-Tesoura");


            jogador1 = int.Parse(Console.ReadLine());

            Console.WriteLine(jogador2);

            if (jogador1 == jogador2)
            {
                Console.WriteLine("Empate");
            }

            else if (jogador1 == 1 && jogador2 == 2) { Console.WriteLine("Jogador 2 venceu"); }
            else if (jogador1 == 1 && jogador2 == 3) { Console.WriteLine("Jogador 1 venceu"); }

            else if (jogador1 == 2 && jogador2 == 1) { Console.WriteLine("Jogador 1 venceu"); }
            else if (jogador1 == 2 && jogador2 == 3) { Console.WriteLine("Jogador 2 venceu"); }

            else if (jogador1 == 3 && jogador2 == 1) { Console.WriteLine("Jogador 2 venceu"); }
            else if (jogador1 == 3 && jogador2 == 2) { Console.WriteLine("Jogador 1 venceu"); }

            Console.ReadLine();
        } 

        public void Salamandra()
        {
            
        }

        public void Troll()
        {
            
        }

        public void Dragão_Gigante()
        {
            vida = 100;

        }
    }
}
