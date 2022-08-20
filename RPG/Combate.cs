using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Combate { 

        Random rand = new Random();
        Inimigos inim = new Inimigos();
        Jogo jog = new Jogo();

    
        public void Batalha()
        {
            Console.WriteLine("passou");
            Console.WriteLine(jog.posição);
            Console.ReadLine();

            /*switch (jog.posição)
            { 
                case "Escadas":
                    inim.Esqueleto();
                    Console.ReadLine();
                    Console.WriteLine("passou");
                    break;
            
            }
            */

        }
    }
}
