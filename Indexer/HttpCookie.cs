using System;
using System.Collections.Generic;

namespace Indexer
{
    public class HttpCookie
    {
       
        //Index is a way to access elements in a class that represents a list of values.
        //List of Object in Dictionary
        //HashTable
        //Generic class && generic parameters and specify the type of Dictionary - keys and values type in string!

        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        public DateTime Expiry { get; set; }

        public void SetItem(string key, string value)
        {

        }

        public static string GetItem(string key)
        {

        }

        public string this[string key]                
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

        public int MyProperty { get; set; }

    }
}
