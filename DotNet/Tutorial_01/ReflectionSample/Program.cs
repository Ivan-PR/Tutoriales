using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new MySampleFromReflection();
        }

        private static void DoSomethingWithMyClass<T>() where T : new()
        {
            Activator.CreateInstance<T>();
        }

        private static void SampleWithAttributes()
        {
            MySampleFromReflection sample = new MySampleFromReflection();
            MyAttribute attr = (MyAttribute)sample.GetType().GetCustomAttributes(false).FirstOrDefault();
        }
    }
}