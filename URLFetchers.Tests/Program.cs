using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            p.testGET();
            p.testPOST();
            p.testComplexDataPOST();

            Console.ReadLine();
        }

        public void testGET()
        {
            URLFetcher uf = new URLFetcher();
            string lorem_url = "http://bimal.org.np/micro-services/lorem/lorem.php";
            string lorem = uf.fetch(lorem_url);
            Console.WriteLine(lorem);
        }

        public void testPOST()
        {
            URLFetcher uf = new URLFetcher();
            string request_url = "http://localhost/api/post.php";

            NameValueCollection data = new NameValueCollection();
            data["username"] = "username";
            data["password"] = "password";

            string response = uf.post(request_url, data);

            Console.WriteLine(response);
        }

        public void testComplexDataPOST()
        {
            URLFetcher uf = new URLFetcher();
            string request_url = "http://localhost/api/post-complex.php";
            // echo implode('|', $_POST);

            NameValueCollection data = new NameValueCollection();
            data["login[username]"] = "username";
            data["login[password]"] = "password";
            data["token"] = "xyz";

            string response = uf.post(request_url, data);
            Console.WriteLine(response);
        }
    }
}
