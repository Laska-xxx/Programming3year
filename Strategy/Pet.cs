using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Pet
    {
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weigth { get; set; }
        public Pet(int age, int height, int weigth, ITameable tameable)
        {
            Age = age;
            Height = height;
            Weigth = weigth;
            Tameable = tameable;
        }
        public ITameable Tameable { get; set; }
        public void MakeSound()
        {
            Tameable.MakeSound();
        }
    }
}
