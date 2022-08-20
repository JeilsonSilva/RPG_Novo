using System;
using System.Threading;

namespace RPG
{
    internal class Historia
    {
        public string Nome_Jogo = "Pesadelo";
        public string jogador = "";
        public int escolha;
        public int opções;



        public Historia()
        {

            
        volta:
            Console.WriteLine("===============================");
            Console.WriteLine("=========Bem vindo ao==========");
            Console.WriteLine($"============{Nome_Jogo}===========");
            Console.WriteLine("===============================");
            Console.WriteLine();



            Console.WriteLine("Escolha uma opção a seguir:");
            Console.WriteLine("[1]Iniciar\n[2]Opções\n[3]Sair");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:

                    //Console.WriteLine("Qual é o seu nome?");
                    //jogador = Console.ReadLine();
                    
                    Console.Clear();
                    texto();

                    break;


                case 2:

                    Console.Clear();
                    Console.WriteLine("Escolha uma opção a seguir:");
                    Console.WriteLine("[1]Sem tempo irmão\n[2]Sair");
                    opções = int.Parse(Console.ReadLine());
                    Console.Clear();
                    goto volta;


                case 3:
                    goto sair;


                default:

                    Console.Clear();
                    Console.WriteLine("Erro 55");
                    Console.ReadLine();
                    Console.Clear();
                    goto volta;

            }


        sair: { }
        }


        private void texto()
        {

            //Console.Write($"{jogador} você acorda em uma masmorra e tudo está meio escuro.Você sente um de seus pulsos " +
            // "preso junto ao seu corpo e escuta fortes barulhos vindos do corredor. Seus olhos começam a pesar.");
            Console.Write(jogador);
            Texto_Dinamico();

            pontos(10);
            Console.WriteLine();
            Console.WriteLine();

            //Console.WriteLine("Você acorda no meio de uma sala quadrada e nela existem 4 portas, uma em cada parede.Seus pulsos agora estão livres");
            //Console.WriteLine("Pressione enter para continuar");
            Texto_Dinamico1();
            Console.ReadLine();
            Console.Clear();
            Jogo jog = new Jogo();


        }

        private void Texto_Dinamico()
        {
            string text = " você acorda em uma masmorra e tudo está meio escuro.Você sente um de seus pulsos preso junto ao seu corpo e escuta fortes barulhos vindos do corredor. Seus olhos começam a pesar.";

            foreach(var i in text)
            {
                Console.Write(i);
                Thread.Sleep(2);
            }
        }
        private void Texto_Dinamico1()
        {
            string text = "Você acorda no meio de uma sala quadrada e nela existem 4 portas, uma em cada parede.Seus pulsos agora estão livres";
            string text1 = "Pressione enter para continuar";
            foreach (var i in text)
            {
                Console.Write(i);
                Thread.Sleep(2);
            }

            Console.WriteLine();

            foreach (var i in text1)
            {
                Console.Write(i);
                Thread.Sleep(2);
            }

        }

        private void  pontos(int numpontos)
        {
            
            for (int i = 0; i < numpontos; i++)
            {
                Thread.Sleep(500);
                Console.Write('.');
            }

                Console.WriteLine(".");
  

        }
    }
}