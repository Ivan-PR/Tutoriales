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
            List<string> titles = new List<string>();

            foreach (Song song in mediaList)
            {
                titles.Add(song.Title);
            }

            return titles;
        }
    }
}