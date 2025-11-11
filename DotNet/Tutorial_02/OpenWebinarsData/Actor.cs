using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenWebinarsData
{
    public class Actor
    {
        [JsonProperty("Nombre")]
        public string Name { get; set; }

        [JsonIgnore]
        public bool Theatre { get; set; }

        public int Age { get; set; }
    }
}