using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Dog : ITameable
    {
        public void MakeSound()
        {
            Console.WriteLine("Гав-гав");
        }
    }
}
