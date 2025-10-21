using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWebinarsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            song.Title = "Dark side of moon";
            song.Seconds = 500;
            song.Position = new ShelvePosition(0, 0);

            Song song2 = new Song();
            song2.Title = "Dark side of moon";
            song2.Seconds = 500;
            song2.Position = new ShelvePosition(1, 0);

            PlayList<Song> playListSongs = new PlayList<Song>();

            playListSongs.Add(song);
            playListSongs.Add(song2);

            WriteLineSpecial<Song>(song, "Start with", "enjoy");

            Console.WriteLine(song2.ToString());

            Tuple<int, string, Song> Tuple = new Tuple<int, string, Song>(0, "Hola", song);

            ListExplanation();
            StackExplanation();
            QueueExplanation();
            DictionaryExplanation();


            Console.ReadKey();
        }

        private static void ListExplanation()
        { 
            List<int> numbers = new List<int>();

            numbers.Add(0);
            numbers.Add(1);
            // numbers.Count
        }

        private static void StackExplanation()
        { 
            Stack<Song> salesSongs = new Stack<Song>();

            salesSongs.Push(new Song());
            salesSongs.Push(new Song());

            Song song = salesSongs.Pop();
        }

        private static void QueueExplanation()
        {
            Queue<int> queueNumbers = new Queue<int>();
            
            queueNumbers.Enqueue(1);
            int number = queueNumbers.Dequeue();
        }

        private static void DictionaryExplanation()
        {
            Dictionary<string, Client> clients = new Dictionary<string, Client>();

            clients.Add("00000000D", new Client() { Name = "Jose Manuel" });


            if (!clients.ContainsKey("00000000D")) 
            {
                clients.Add("00000000D", new Client() { Name = "Jose Manuel" });
            }

            clients["00000000D"] = new Client();

            Client myClient = clients["00000000D"];

            var elements = new List<KeyValuePair<string, Client>>();
            elements.Add(new KeyValuePair<string, Client>("0001", new Client()));
            elements.Add(new KeyValuePair<string, Client>("0002", new Client()));

            // Utils.AddRangeDictionary(clients, elements);
            clients.AddRange(elements);
        }

        static void WriteLineSpecial<T>(T data, string prefix, string suffix)
        {
            Console.WriteLine($"{prefix} {data} {suffix}");
        }

        static void Declarations()
        {
            int number = 0;
            double numberDecimals = 0.0d;
            bool yayOrNay = true;
            string helloWorld = string.Empty;
        }

        static void Conditions()
        {
            int number = 0;
            number += 2;
            //number => 2

            number -= 2;
            //number => 0

            //Si
            if (number == 0)
            {
                //Hacer algo
            }
            //Sino Si
            else if (number > 0)
            {
                //Hacer otra cosa
            }
            //Sino
            else
            {
                //Hacer otra cosa
            }
        }

        static void Loops()
        {
            //== (igual)
            //!= (no igual)
            //>= (mayor o igual)
            //<= (menor o igual)
            //> (mayor que)
            //< (menor que)
            //&& (AND)
            //|| (OR)

            int number = 0;

            for (int i = 0; i < 10; i++)
            {
                // Hacer algo 10 veces
            }

            while (number != 10)
            {
                number++;
            }

            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            foreach (int num in numbers)
            {
            }
        }

        static void Switch()
        {
            int number = 0;

            switch (number)
            {
                case 0:
                    //Hacer algo
                    break;

                case 10:
                    //Hacer otra cosa
                    break;

                default:
                    //Hacer otra cosa
                    break;
            }
        }
    }
}