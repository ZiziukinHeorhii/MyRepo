using System;
using System.Collections.Generic;

namespace Program1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Song> songs = AddSongs();

            Radio radio = new Radio(songs);

            Console.WriteLine("Напишите 1 чтобы включить песню или end чтобы выключить радио");
            for (int i = 0; i < 100; ++i)
            {
                string inputString = Console.ReadLine();

                if (inputString == "1")
                {
                    Console.Write("Сейчас играет: " + radio.GetMusicDictionary(i).Name + "\n");
                }
                else if (inputString == "end")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Клавиша " + inputString + " ничего не делает");
                }
            }
        }

        private static List<Song> AddSongs()
        {
            List<Song> songs = new List<Song>
            {
                new Song("Nirvana - Smells like teen spirit"),
                new Song("Nirvana - Aneurysm"),
                new Song("Nirvana - Lithium"),
                new Song("Nirvana - Dumb"),
                new Song("Nirvana - Come as you are"),

                new Song("Bring me the horizon - Doomed"),
                new Song("Bring me the horizon - MANTRA"),
                new Song("Bring me the horizon - Can you feel my heart"),
                new Song("Bring me the horizon - Sleepwalking"),
                new Song("Bring me the horizon - Throne"),

                new Song("Daft Punk - Something about us"),
                new Song("Daft Punk - Human after all"),
                new Song("Daft Punk - Around the world"),
                new Song("Daft Punk - One more time"),
                new Song("Daft Punk - Technologic"),

                new Song("Cavetown - Devil town"),
                new Song("Cavetown - Sweet tooth"),
                new Song("Cavetown - I miss my mum"),
                new Song("Cavetown - Boys will be bugs"),
                new Song("Cavetown - Guilty")
            };

            return songs;
        }
    }
}
