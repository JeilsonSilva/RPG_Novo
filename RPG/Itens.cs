using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Itens
    {
        List<string> itens = new List<string>();
        Random rand = new Random();
        int showitem;
        int tamanhoLista;

        public Itens()
        {
            int tamanhoLista = 4;
            itens.Add("Adaga");
            itens.Add("Poção de cura");
            itens.Add("Algemas");
            itens.Add("Lamparina");
            itens.Add("Chave dourada");

        }


        public void AcharItens()
        {
            
            

            showitem = rand.Next(0,11);

            if(showitem > tamanhoLista )
            {
                Console.WriteLine("Não há itens na sala");
            }

            else
            {
              
                
                    Console.WriteLine($"Você achou um(a){itens[showitem]}");
                    itens.RemoveAt(showitem);
                    if (tamanhoLista >= 1) { tamanhoLista--; }
                    Console.WriteLine();

                    foreach (var i in itens)
                    {

                        Console.WriteLine(i);
                    }



                 
                
            }
            

        }
    }
}
