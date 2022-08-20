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
        

    
        public void Batalha(string posi)
        {
            
            
            Console.ReadLine();

            switch (posi)
            { 
                case "Escadas":

                    inim.Esqueleto();
                    Console.ReadLine();
                    
                    break;
            
            }
            

        }
    }
}
