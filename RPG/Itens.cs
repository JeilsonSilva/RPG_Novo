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
        List<String> itens_jogador = new List<String>();
        Random rand = new Random();

        int showitem;
        int tamanhoLista;
        bool listavazia = true;

        public Itens()
        {
            tamanhoLista = 5;
            itens.Add("Adaga");
            itens.Add("Poção de cura");
            itens.Add("Poção de energia");
            itens.Add("Par de algemas");
            itens.Add("Lamparina");
            itens.Add("Chave dourada");

        }


        public void AcharItens()
        {



            showitem = rand.Next(0, 11);

            if (showitem > tamanhoLista)
            {
                Console.WriteLine("Você não conseguiu encontrar nenhum item");
            }

            else
            {
                listavazia = false;
                Console.WriteLine($"Você achou um(a){itens[showitem]}");
                itens_jogador.Add(itens[showitem]);
                itens.RemoveAt(showitem);

                if (tamanhoLista >= 1) { tamanhoLista--; }// ajustar quando acabam os itens
                Console.WriteLine();
            }


        }

        public void ListarItens()
        {
            if(listavazia == true)
            {
                Console.WriteLine("Sua lista de itens se encontra vazia");
            }

            else
            {
                foreach (var i in itens_jogador)
                {

                    Console.WriteLine(i);

                }
            }

            
        }
    }
}
