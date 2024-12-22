using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generic
{
    internal class GenericTestManager<T>
    {
        private T[] universalMas;
        public GenericTestManager()
        {
            universalMas = Array.Empty<T>();
        }

        public void Add(T item)
        {
            T[] temp = new T[universalMas.Length + 1];

            for (int i = 0; i < universalMas.Length; i++)
            {
                temp[i] = universalMas[i];
            }

            temp[temp.Length - 1] = item;

            universalMas = temp;
        }

        public void Remove(int item)
        {
            T[] values = new T[universalMas.Length - 1];

            item--;
            bool plusOne = false;
            for (int i = 0; i < values.Length; i++)
            {
                if (i == item)
                {
                    values[i] = universalMas[i + 1];
                    plusOne = true;
                }
                else if (plusOne)
                {
                    values[i] = universalMas[i + 1];
                }
                else
                {
                    values[i] = universalMas[i];
                }
            }
            universalMas = values;
        }

        public T GetItem(int index)
        {
            return universalMas[index];
        }

        public int GetLenght()
        {
            return universalMas.Length;
        }
    }
}
