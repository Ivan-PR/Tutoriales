using System;
using System.Collections.Generic;

namespace OpenWebinarsConsoleApp
{
    public class PlayList<T>
    {
        List<T> mediaList = new List<T>();

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
    }
}