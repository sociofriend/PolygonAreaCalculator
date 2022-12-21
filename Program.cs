using System;
namespace Homework_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Polygon obj = new Polygon();
            int res = obj.AreaFinder(3);
            Console.WriteLine(res);
        }
    }
}

