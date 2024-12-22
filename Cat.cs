using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    sealed internal class Cat
    {
        readonly string _Name;

        public Cat(string Name)
        {
            _Name = Name;
        }

        public string Name { get ;}
    }
}
