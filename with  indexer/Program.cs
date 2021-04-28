using System;
namespace WithIndexer
{

    public class Program
    {
        public static void Main(string[] args)
        {

            var cookie = new HttpCookie();
            cookie["name"] = "mahesh";
            Console.WriteLine(cookie["name"]);
        
   
        }
    }
}
