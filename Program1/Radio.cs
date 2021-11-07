using System;
using System.Collections.Generic;
using System.Linq;

namespace Program1
{
    public class Radio
    {
        public Queue<Song> PlayedSongs { get; set; }
        public List<Song> Songs { get; set; }
        public List<Song> NotPlayedSongs { get; set; }
        public Dictionary<int, Song> PlayedMusic { get; set; }
        
        public Radio(List<Song> songs)
        {
            Songs = songs;
            PlayedSongs = new Queue<Song>();
            NotPlayedSongs = Songs;
        }
        public Song GetMusicQueue()
        {
            foreach (Song song in NotPlayedSongs.ToList())
            {
                if (PlayedSongs.Contains(song))
                {
                    NotPlayedSongs.Remove(song);
                }
            }

            Song playingSong = NotPlayedSongs.ElementAt(new Random().Next(0, Songs.Count()));
            PlayedSongs.Enqueue(playingSong);

            if (PlayedSongs.Count == 4)
            {
                NotPlayedSongs.Add(PlayedSongs.Peek());
                PlayedSongs.Dequeue();
            }

            return playingSong;
        }
        public Song GetMusicDictionary(int i)
        {
            Song randomSong = Songs.Where(song => !PlayedMusic.ContainsValue(song)).ToList()
                .ElementAt(new Random().Next(0, Songs.Count()));
            PlayedMusic.Add(i, randomSong);

            if (PlayedMusic.Count() == 4)
            {
                PlayedMusic.Remove(0);

                foreach (Song song in PlayedMusic.Values)
                {
                    //PlayedMusic.Remove(Songs.IndexOf(song));

                }
            }

            return randomSong;
        }
            
        //всем элеметам с ключом 4 делаем ключ 0
        //всем элементам у которых ключ больше нуля, инкрементируем ключ
        //берём все элементы с ключом 0
        //берём случайный элемент из них
        //делаем проигранной песне ключ "её ключ + 1"
        //возвращаем этот элемент
    }
}
