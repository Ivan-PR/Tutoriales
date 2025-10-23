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

            PropertyInfo[] properties = sample.GetType().GetProperties();
            properties[0].SetValue(sample, "Jose Manuel");
            properties[0].GetValue(sample);

            MethodInfo[] methods = sample.GetType().GetMethods();
            MethodInfo doSomething = methods.FirstOrDefault(x => x.Name=="DoSomething");

            if (doSomething!=null)
            {
                doSomething.Invoke(sample, null);
            }

            //Similar like GetProperty and PropertyInfo
            sample.GetType().GetFields();

            Assembly assembly = Assembly.GetExecutingAssembly();
        }
    }
}