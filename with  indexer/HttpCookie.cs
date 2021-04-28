using System;
using System.Collections.Generic;
namespace WithIndexer
{
   public  class HttpCookie
    {
        private Dictionary<string, string> _dict;
        public HttpCookie()
        {
            _dict = new Dictionary<string, string>();
        }
        
        public string this[string key]
        {
            get { return _dict[key]; }
            set { _dict[key] = value; }
        }



    }
}
