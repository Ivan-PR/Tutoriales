using System;
using System.Linq;
using System.Collections.Generic;

namespace OpenWebinarsConsoleApp
{
    public class PlayList<T> where T : Song
    {
        private List<T> mediaList = new List<T>();

        public void Add(T media)
        {
            mediaList.Add(media);
        }

        public void PlayAll()
        {
            foreach (T media in mediaList)
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

        public List<T> SearchForCategory(string category)
        {
            var songs = mediaList.Where(x => x.Category==category);

            return songs.ToList();
        }

        public List<T> SearchForTitle(string title)
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

        public T GetFirstSongWithLess1Minute()
        {
            var song = mediaList.FirstOrDefault(x => x.Seconds<60);
            return song;
        }

        public T GetLastSongWithLess1Minute()
        {
            var song = mediaList.LastOrDefault(x => x.Seconds<60);
            return song;
        }

        public List<T> Top10()
        {
            return mediaList.OrderByDescending(x => x.Visits).Take(10).ToList();
        }

        public T[] Bottom10()
        {
            return mediaList.OrderBy(x => x.Visits).Take(10).ToArray();
        }

        public void GroupFromCategory()
        {
            mediaList.GroupBy(x => x.Category).ToDictionary(x => x.Key);
        }

        public List<T> Skip10Top20()
        {
            return mediaList.Skip(10).Take(10).ToList();
        }

        public List<Media> ToConvertMedia()
        {
            return mediaList.OfType<Media>().ToList();
        }
    }
}