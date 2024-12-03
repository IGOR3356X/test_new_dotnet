using System.Collections;
using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;
internal class Program
{
    private static void Main(string[] args)
    {
        Person Bob = new(15, 45.43, "Bob");
        Bob.GG();
        SqlDateTime sqlDateTime = new SqlDateTime(DateTime.Now);
        Console.WriteLine(sqlDateTime);
        DateOnly sqlDateTime2 = new(21,10,10);
        Bobus amogus = new Bobus(10, 25, "Amogus");
        Bobus.KaefStruct booba = new();
        var name = booba.name = "Nigga";
        var id = booba.id = 1;
        Console.WriteLine($"Его имя = {name},его id = {id}");

        Console.WriteLine(Bob.ToString());

        int[] masGG =[1, 2, 3, 4];
        masGG = [1,2,3,4,5,6];
        for (int i = 0; i < masGG.Length; i++)
        {
            Console.Write(masGG[i]);
        }


    }
    
}
public class Person
{
    private int _age;
    private double _veight;
    private string _name;
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
    }
}