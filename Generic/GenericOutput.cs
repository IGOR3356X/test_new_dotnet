using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generic
{
    internal static class GenericOutput
    {
        internal static void ConsolePisat()
        {
            GenericTestManager<string> genericTest = new GenericTestManager<string>();
            genericTest.Add("123");
            genericTest.Add("323232");
            genericTest.Add("12313");
            genericTest.Add("32323");
            //genericTest.Remove(1);

            for (int i = 0; i < genericTest.GetLenght(); i++)
            {
                Console.Write(genericTest.GetItem(i) + " ");
            }
        }
    }
}
