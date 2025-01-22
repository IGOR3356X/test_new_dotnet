using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Nasledovanie_Struct
{
    public class Person
    {
        private int _age;
        private double _veight;
        private string _name;

        public Person(int age, double veight) : this(age, veight, "Undefied")
        {

        }

        public Person(int age, double veight, string name)
        {
            _age = age;
            _veight = veight;
            _name = name;

        }
        public override string ToString()
        {
            return $"name = {_name}, вес = {_veight} , возраст = {_age}";
        }
        public void GG()
        {
            Console.WriteLine();
        }
    }

    public class Bobus : Person
    {
        public Bobus(int age, double veight, string name) : base(age, veight, name)
        {

        }
        public struct KaefStruct
        {
            public int id { get; set; }
            public string name;

            public KaefStruct(int id, string name)
            {
                this.id = id;
                this.name = name;
            }
            public KaefStruct(int id) : this(id, "Name") { }
        }
    }
}
