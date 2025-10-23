using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWebinarsConsoleApp
{
    public class Media
    {
        private int parentRate = 18;

        public string Title { get; set; }

        public virtual void Play()
        {
            Console.WriteLine($"Playing {Title}");
        }

        protected bool ThisContentIsCorrectForThisAge(int age)
        {
            if (age>=parentRate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj==null||obj.GetType()!=typeof(Media))
                return false;

            var mediaObj = (Media)obj;
            return mediaObj.Title==this.Title;
        }

        public override int GetHashCode()
        {
            return Title!=null ? Title.GetHashCode() : 0;
        }
    }
}