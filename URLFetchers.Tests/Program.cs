using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URLFetchers.Library;

namespace URLFetchers.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.test();

            Console.ReadLine();
        }

        public void test()
        {
            URLFetcher uf = new URLFetcher();
            string lorem_url = "http://bimal.org.np/micro-services/lorem/lorem.php";
            string lorem = uf.fetch(lorem_url);
            Console.WriteLine(lorem);
        }
    }
}
