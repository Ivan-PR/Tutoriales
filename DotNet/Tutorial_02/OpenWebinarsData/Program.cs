using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenWebinarsData
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Actor actor = new Actor();
            actor.Age = 20;
            actor.Theatre = false;
            actor.Name = "Fulanito";

            string json = JsonConvert.SerializeObject(actor);
        }
    }
}