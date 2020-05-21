using System;
using System.Collections.Generic;

namespace Base_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTRETENIMENTOS\n");
            Console.WriteLine("Selecione o tipo de entretenimento que você deseja listar:");
            Console.WriteLine("[1] p/ cinema");
            Console.WriteLine("[2] p/ música");
            Console.WriteLine("[3] p/ games");

            byte  resposta;
            bool respostaValida = byte.TryParse(Console.ReadLine(), out resposta);

            if (respostaValida && resposta <= 3)
            {
                Type[] tipos = { typeof(Cinema), typeof(Music), typeof(Games) };

                Console.Clear();
                foreach (Entertainment entertrainment in FillListOfEntertainment())
                {
                    if (entertrainment.GetType() == tipos[resposta - 1])
                    {
                        entertrainment.GetInfos();
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Resposta Inválida");
            }

            Console.ReadKey();
        }

        static List<Entertainment> FillListOfEntertainment()
        {
            List<Entertainment> lista = new List<Entertainment>();
            Cinema filme;
            Games game;
            Music music;

            // add filmes
            filme = new Cinema("Rocky I", "Luta", 12);
            lista.Add(filme);

            filme = new Cinema("Os 12 macacos", "Cyberpunk");
            lista.Add(filme);

            filme = new Cinema("Ponyo - uma amizade que veio do mar", "anime", 1, "Anime", "Jovens");
            lista.Add(filme);

            // add games -------------------------------------------
            game = new Games("GTA SA", true);
            game.Age_rating = 18;
            game.Genre = "Ação";
            lista.Add(game);

            game = new Games("Counter Strike", true, "FPS");
            game.Type = "FPS Game";
            game.Largest_audience = "FPS Gamers";
            lista.Add(game);

            // add musics -----------------------------------------
            music = new Music("Diana", "Paul Anka");
            lista.Add(music);

            music = new Music("Monster(DotExe Remix)", "DotExe", "Eletrônica", "Dubstep");
            lista.Add(music);

            music = new Music("All my loving", "The Beatles", "Rock'n Roll");
            lista.Add(music);

            return lista;
        }
    }
}
