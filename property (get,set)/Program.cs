using System;
namespace CsharpIntermediateLevel
{

    class program
    {
        public static void Main(String[] args)
        {
            StudentAge s = new StudentAge();
            s.BirthDay = new DateTime(1947, 6, 26);
            Console.WriteLine(s.Age);

   
        }
    }
}
