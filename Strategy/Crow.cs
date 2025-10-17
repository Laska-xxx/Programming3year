using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Crow : ITameable
    {
        public void MakeSound()
        {
            Console.WriteLine("Кар-кар");
        }
    }
}
