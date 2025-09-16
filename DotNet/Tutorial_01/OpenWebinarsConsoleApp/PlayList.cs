using System;

namespace OpenWebinarsConsoleApp
{
    public class PlayList<T, V, Z> { }

    public class PlayList<T>
    {
        T[] medialist = new T[] { };

        public void Add(T media)
        {
        }

        public void PlayAll()
        {
            foreach (T media in medialist)
            {
                Console.WriteLine(media);
            }
        }
    }
}