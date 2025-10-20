using System;
using System.Collections.Generic;

namespace OpenWebinarsConsoleApp
{

    public class PlayList<T>
    {
        List<T> mediaList = new List<T>(); 

        
        
        public void Add(T media)
        {
            list.Add(media);
        }

        public void PlayAll()
        {
            foreach (T media in list)
            {
                Console.WriteLine(media);
            }
        }

        public void Preview()
        {
            if (mediaList.count > 0)
            {
                Console.WriteLine(mediaList[0]);
            }
        }

    }
}