using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Cat : ITameable
    {
        public void MakeSound()
        {
            Console.WriteLine("Мяу-мяу");
        }
    }
}
