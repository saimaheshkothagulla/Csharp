using System;
namespace WithOutIndexer
{

    class program
    {
        public static void Main(String[] args)
        {

            var cookie = new HttpCookie();
            cookie.SetItem("name", "saimahesh");
            Console.WriteLine(cookie.GetItem("name"));
   
        }
    }
}
