using System;
using System.Collections.Generic;
using System.Text;

namespace StaticLearning
{
    class DataBaseConnected
    {
        private static string url;

        static DataBaseConnected()
        {
            DataBaseUrl connectDB = new DataBaseUrl();
            url = connectDB.Url;
        }

        public DataBaseConnected()
        {

        }

        public void PrintUrlHash() 
        {
            Console.WriteLine(url.GetHashCode());
        }


    }

    class DataBaseUrl
    {
        private string url = "localhost";
        public string Url { get { return url; } }
    }
}
