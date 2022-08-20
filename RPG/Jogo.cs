﻿using System;

namespace RPG
{
    internal class Jogo
    {
        Mapa map = new Mapa();
        Status st = new Status();
        Itens its = new Itens();
        Random rand = new Random();
        Combate comb = new Combate();   
        

        public String posição = "Sala 1";
        int escolha;       
        bool parada = false;
        bool procurar = false;

        public Jogo()
        {
          
            Sala1();

        }

        private void Sala1()
        {
        volta:
            posição = "Sala 1";
            Console.Clear();
            map.Mapa1();

                if (parada == false)
                {
                    st.vida();
                    st.Energia();
                    parada = true;
                }
                    else
                    {
                        st.vidaparada();
                        st.Energiaparada();
                    }

            Console.WriteLine($"Você se encontra na(o) {posição}");
            Console.WriteLine();
            Console.WriteLine("Para onde você deseja ir a seguir\n[1] Salão Principal\n[2] Sala 2\n[3] Sala 3\n[4] Sala 4\n[5] Escadas");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:

                    Salao_Principal();

                    break;

                case 2:

                    Sala2();

                    break;

                case 3:

                    Sala3();

                    break;

                case 4:


                    Sala4();

                    break;

                case 5:


                    Escadas();

                    break;

                default:
                    posição = "Sala 1";
                    goto volta;
            }

        }

        private void Salao_Principal()
        {
        erro:

            if (procurar == false)
            {
                Console.Clear();
                posição = "Salão Principal";
                map.Mapa1();
                st.vidaparada();
                st.Energiaparada();
                Console.WriteLine($"Você está na(o) {posição}");
                Console.WriteLine();
                Console.WriteLine("Para onde você deseja ir a seguir\n[1]Sala 1\n[2]Procurar por itens\n[3]Listar itens");
                if (escolha == 1) { procurar = false; Sala1(); }
                if (escolha == 2) { procurar = true; its.AcharItens(); Console.ReadLine(); goto erro; }
                if (escolha == 3) { its.ListarItens(); Console.ReadLine(); goto erro; }

                else { goto erro; }

            }

            else if(true)
            {
                Console.Clear();
                posição = "Salão Principal";
                map.Mapa1();
                st.vidaparada();
                st.Energiaparada();
                Console.WriteLine($"Você está na(o) {posição}");
                Console.WriteLine();
                Console.WriteLine("Para onde você deseja ir a seguir\n[1]Sala 1\n[2]Listar itens");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1) { procurar = false; Sala1(); }
                if (escolha == 2) { its.ListarItens(); Console.ReadLine(); goto erro; }

                else { goto erro; }
            }
            
        }

        private void Sala2()
        {
        erro:

            if (procurar == false)
            {
                Console.Clear();
                posição = "Sala 2";
                map.Mapa1();
                st.vidaparada();
                st.Energiaparada();
                Console.WriteLine($"Você está na(o) {posição}");
                Console.WriteLine();
                Console.WriteLine("Para onde você deseja ir a seguir\n[1]Sala 1\n[2]Procurar por itens\n[3]Listar itens");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1) { procurar = false; Sala1(); }
                if (escolha == 2) { procurar = true; its.AcharItens(); Console.ReadLine(); goto erro; }
                if (escolha == 3) { its.ListarItens(); Console.ReadLine(); goto erro; }

                else { goto erro; }
            }

            else if (procurar == true)
            {
                Console.Clear();
                posição = "Sala 2";
                map.Mapa1();
                st.vidaparada();

                st.Energiaparada();
                Console.WriteLine($"Você está na(o) {posição}");
                Console.WriteLine();
                Console.WriteLine("Para onde você deseja ir a seguir\n[1]Sala 1\n[2]Listar itens");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1) { procurar = false; Sala1(); }
                if (escolha == 2) { its.ListarItens(); Console.ReadLine(); goto erro; }

                else { goto erro; }

            }
        }

        private void Sala3()
        {
        erro:
            Console.Clear();
            posição = "Sala 3";
            map.Mapa1();
            st.vidaparada();
            st.Energiaparada();
            Console.WriteLine($"Você está na(o) {posição}");
            Console.WriteLine();
            Console.WriteLine("Para onde você deseja ir a seguir\n[1]Sala 1\n[2]Sala 4");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1) { Sala1(); }
            if (escolha == 2) { Sala4(); }

            else { goto erro; }
        }

        private void Sala4()
        {
        erro:
            if (procurar == false)
            {
                Console.Clear();
                posição = "Sala 4";
                map.Mapa1();
                st.vidaparada();
                st.Energiaparada();
                Console.WriteLine($"Você está na(o) {posição}");
                Console.WriteLine();
                Console.WriteLine("Para onde você deseja ir a seguir\n[1]Sala 1\n[2]Sala 3\n[3]Procurar por itens\n[4]Listar itens");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1) { procurar = false; Sala1(); }
                if (escolha == 2) { procurar = false; Sala3(); }
                if (escolha == 3) { procurar = true; its.AcharItens(); Console.ReadLine(); goto erro; }
                if (escolha == 4) { its.ListarItens(); Console.ReadLine(); goto erro; }

                else { goto erro; }
            }

            else if(procurar == true)
            {
                Console.Clear();
                posição = "Sala 4";
                map.Mapa1();
                st.vidaparada();
                st.Energiaparada();
                Console.WriteLine($"Você está na(o) {posição}");
                Console.WriteLine();
                Console.WriteLine("Para onde você deseja ir a seguir\n[1]Sala 1\n[2]Sala 3\n[3]Listar itens");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1) { procurar = false; Sala1(); }
                if (escolha == 2) { procurar = false; Sala3(); }
                if (escolha == 3) { its.ListarItens(); Console.ReadLine(); goto erro; }

                else { goto erro; }
            }
        }

        private void Escadas()
        {
        erro:

            Console.Clear();
            posição = "Escadas";
            map.Mapa1();
            st.vidaparada();
            st.Energiaparada();
            Console.WriteLine($"Você está na(o) {posição}");
            Console.WriteLine();
            Console.WriteLine("Para onde você deseja ir a seguir\n[1]Sala 1\n[2]Segundo andar");
            comb.Batalha(posição);
            escolha = int.Parse(Console.ReadLine());
            

            if (escolha == 1) { Sala1(); }
            if (escolha == 2) { Segundo_Andar(); }

            else { goto erro; }
        }

        private void Segundo_Andar()
        {
            posição = "Corredor do segundo Andar";

        volta:

            Console.Clear();
            map.Mapa2();
            st.vidaparada();
            st.Energiaparada();
            Console.WriteLine($"Você está na(o) {posição}");
            Console.WriteLine();
            Console.WriteLine("Para onde você deseja ir a seguir\n[1]Escadas\n[2]Sala 5\n[3]Sala 6\n[4]Sala 7\n[5]Sala 8");
            escolha = int.Parse(Console.ReadLine());


            switch (escolha)
            {
                case 1:

                    Escadas();

                    break;

                case 2:

                    Sala5();

                    break;

                case 3:

                    Sala6();

                    break;

                case 4:


                    Sala7();

                    break;

                case 5:


                    Sala8();

                    break;

                default:
                    posição = "Corredor do segundo andar";
                    goto volta;
            }

        }

        private void Sala5()
        {
        erro:

            Console.Clear();
            posição = "Sala 5";
            map.Mapa2();
            st.vidaparada();
            st.Energiaparada();
            Console.WriteLine($"Você está na(o) {posição}");
            Console.WriteLine();
            Console.WriteLine("Para onde você deseja ir a seguir\n[1]Corredor");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1) { Segundo_Andar(); }

            else { goto erro; }
        }

        private void Sala6()
        {
        erro:
            if (procurar == false)
            {
                Console.Clear();
                posição = "Sala 6";
                map.Mapa2();
                st.vidaparada();
                st.Energiaparada();
                Console.WriteLine($"Você está na(o) {posição}");
                Console.WriteLine();
                Console.WriteLine("Para onde você deseja ir a seguir\n[1]Corredor\n[2]Procurar por itens\n[3]Listar itens");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1) { procurar = false; Segundo_Andar(); }
                if (escolha == 2) { procurar = true; its.AcharItens(); Console.ReadLine(); goto erro; }
                if (escolha == 3) { its.ListarItens(); Console.ReadLine(); goto erro; }


                else { goto erro; }
            }
            

            else if (procurar == true)
            {
                Console.Clear();
                posição = "Sala 6";
                map.Mapa2();
                st.vidaparada();
                st.Energiaparada();
                Console.WriteLine($"Você está na(o) {posição}");
                Console.WriteLine();
                Console.WriteLine("Para onde você deseja ir a seguir\n[1]Corredor\n[2]Listar itens");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1) { procurar = false; Segundo_Andar(); }
                if (escolha == 2) { its.ListarItens(); Console.ReadLine(); goto erro; }


                else { goto erro; }
            }
        }

        private void Sala7()
        {
        erro:

            if (procurar == false)
            {
                Console.Clear();
                posição = "Sala 7";
                map.Mapa2();
                st.vidaparada();
                st.Energiaparada();
                Console.WriteLine($"Você está na(o) {posição}");
                Console.WriteLine();
                Console.WriteLine("Para onde você deseja ir a seguir\n[1]Corredor\n[2]Procurar por itens\n[3]Listar itens");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1) { procurar = false; Segundo_Andar(); }
                if (escolha == 2) { procurar = true; its.AcharItens(); Console.ReadLine(); goto erro; }
                if (escolha == 3) { its.ListarItens(); Console.ReadLine(); goto erro; }


                else { goto erro; }
            }


            else if (procurar == true)
            {
                Console.Clear();
                posição = "Sala 7";
                map.Mapa2();
                st.vidaparada();
                st.Energiaparada();
                Console.WriteLine($"Você está na(o) {posição}");
                Console.WriteLine();
                Console.WriteLine("Para onde você deseja ir a seguir\n[1]Corredor\n[2]Listar itens");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1) { procurar = false; Segundo_Andar(); }
                if (escolha == 2) { its.ListarItens(); Console.ReadLine(); goto erro; }


                else { goto erro; }
            }
        }

        private void Sala8()
        {
        erro:

            st.Menos_Vida = rand.Next(0, 100);
            st.Menos_Energia = rand.Next(0, 100);

            Console.Clear();
            posição = "Sala 8";
            map.Mapa2();
            st.vidaparada();
            st.Energiaparada();
            Console.WriteLine($"Você está na(o) {posição}");
            Console.WriteLine();
            Console.WriteLine("Para onde você deseja ir a seguir\n[1]Corredor");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1) { Segundo_Andar(); }

            else { goto erro; }
        }






    }
}
