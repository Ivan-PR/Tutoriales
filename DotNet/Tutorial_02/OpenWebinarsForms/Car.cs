using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWebinarsForms
{
    internal class Car
    {
        public string Name { get; set; }
        public string Maker { get; set; }

        public override string ToString()
        {
            return $"{Name} {Maker}";
        }
    }
}