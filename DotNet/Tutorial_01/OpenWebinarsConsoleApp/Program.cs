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
            song.Title = "Dark side of the moon";
            song.Seconds = 500;
            song.Position = new ShelvePosition(0, 0);
            song.Play();

            Console.ReadKey();
        }

        static void Declarations()
        {
            int number = 0;
            double numberDecimals = 0.0d;
            bool yayOrNay = true;
            string helloWorld = string.Empty;
        }

        static void Conditions() {
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

        static void Loops() {
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

        static void Switch() {
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
