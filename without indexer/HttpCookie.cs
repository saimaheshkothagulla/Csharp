using System;
using System.Collections.Generic;
namespace WithOutIndexer
{
   public  class HttpCookie
    {
        private Dictionary<string, string> _dict=new Dictionary<string, string>();
        public void SetItem(string key,string val)
        {
            _dict[key] = val;
        }
        public string GetItem(string key)
        {
            return _dict[key];
        }



    }
}
