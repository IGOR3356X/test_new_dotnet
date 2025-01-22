using System.Runtime.InteropServices.JavaScript;
using System.Text;
using ConsoleApp1.Generic;

namespace ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        //using var input = new StreamReader(Console.OpenStandardInput());
        //using var output = new StreamWriter(Console.OpenStandardOutput());
        //StringBuilder sb = new StringBuilder();

        //var s = input.ReadLine();
        //for (int i = 0; i < int.Parse(s); i++)
        //{
        //    var answer = input.ReadLine();
        //    for (int j = 0; j < answer.Length; j++)
        //    {

        //    }
        //    sb.Append(answer + "\n");
        //}

        //Console.WriteLine(sb);

        //Object ob = "ggdgg";

        #region Тестим всякое говно

        //Person Bob = new(15, 45.43);
        //Bob.GG();
        //Console.WriteLine(Bob.ToString());

        //Bobus amogus = new Bobus(10, 25, "Amogus");

        //Bobus.KaefStruct booba = new();
        //var name = booba.name = "Nigga";
        //var id = booba.id = 1;
        //Console.WriteLine($"Его имя = {name},его id = {id}");

        //SqlDateTime sqlDateTime = new SqlDateTime(DateTime.Now);
        //Console.WriteLine(sqlDateTime);

        //DateOnly sqlDateTime2 = new(21, 10, 10);
        //int[] masGG =[1, 2, 3, 4];
        //masGG = [1,2,3,4,5,6];
        //for (int i = 0; i < masGG.Length; i++)
        //{
        //    Console.Write(masGG[i]);
        //}
        //Console.WriteLine();

        //Console.WriteLine(amogus.ToString());

        #endregion

        //GenericOutput.ConsolePisat();
        //Cat cat = new("GAY");
        //Console.WriteLine(cat.Name);
        //Person person = new(1, 1.2);
        //Console.WriteLine(person.ToString());
        //int[] mas = {1,2,3,4,5};
        //int[,] matrix = new int[2, 5];

        //for (int i = 0; i < mas.Length; i++)
        //{
        //    Console.Write(mas[i] + " ");
        //}
        //Console.WriteLine();
        //string gg = "dgdgdffb";
        //string[] input = Console.ReadLine().Split(' ');
        //Console.WriteLine(input);
        //for (int i = 0; i < matrix.GetLength(0); i++)
        //{
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        Console.Write(matrix[i, j]);
        //    }
        //    Console.WriteLine();
        //}
    }

}
    
public interface ILogger
{
    public void Info(string message)
    {
        Console.WriteLine(message);
    }
    
}