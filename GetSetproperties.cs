using System;
namespace CsharpIntermediateLevel
{
    class Car
    {
        private string name = "bmw";//field
        public string Name //class prpertiy
        {
            get{ return name; }
            set{ name = value; }
        }
       
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine(c.Name);
            c.Name = "royal";
            Console.WriteLine(c.Name);

        }
    }
}
