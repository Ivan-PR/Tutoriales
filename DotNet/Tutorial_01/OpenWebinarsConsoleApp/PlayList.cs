using System;
using System.Linq;
using System.Collections.Generic;

namespace OpenWebinarsConsoleApp
{
    public class PlayList
    {
        private List<Song> mediaList = new List<Song>();

        public void Add(Song media)
        {
            mediaList.Add(media);
        }

        public void PlayAll()
        {
            foreach (Song media in mediaList)
            {
                Console.WriteLine(media);
            }
        }

        public void Preview()
        {
            if (mediaList.Count>0)
            {
                Console.WriteLine(mediaList[0]);
            }
        }

        public List<Song> SearchForCategory(string category)
        {
            var songs = mediaList.Where(x => x.Category==category);

            return songs.ToList();
        }

        public List<Song> SearchForTitle(string title)
        {
            var songs = mediaList.Where(x => x.Title.Contains(title));

            return songs.ToList();
        }

        public List<string> GimmeTitlesFromSongs()
        {
            var titles = mediaList.Select(x => x.Title);

            return titles.ToList();
        }

        public List<string> GimmeNamesOfArtist()
        {
            var namesOfArtists = mediaList.SelectMany(x => x.Artists).Select(x => x.Name);

            return namesOfArtists.ToList();
        }

        public bool HaveATitle(string title)
        {
            return mediaList.Any(x => x.Title==title);
        }

        public Song GetFirstSongWithLess1Minute()
        {
            var song = mediaList.FirstOrDefault(x => x.Seconds<60);
            return song;
        }

        public Song GetLastSongWithLess1Minute()
        {
            var song = mediaList.LastOrDefault(x => x.Seconds<60);
            return song;
        }

        public List<Song> Top10()
        {
            return mediaList.Take(10).ToList();
        }

        public List<Song> Skip10Top20()
        {
            return mediaList.Skip(10).Take(10).ToList();
        }
    }
}