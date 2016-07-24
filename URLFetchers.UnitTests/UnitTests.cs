using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using URLFetchers.Library;

/**
 * @see https://msdn.microsoft.com/en-us/library/microsoft.visualstudio.testtools.unittesting.classinitializeattribute.aspx
 * @see http://stackoverflow.com/questions/6193744/what-would-be-an-alternate-to-setup-and-teardown-in-mstest
 * 
 * @see http://stackoverflow.com/questions/541954/how-would-you-count-occurrences-of-a-string-within-a-string
 */
namespace URLFetchers.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        private string codegen_url = "http://localhost/bimal/com/shouldrule/subdomains/com/shouldrule/code/public_html/generate.php";
        private string lorem_url = "http://localhost/bimal/com/shouldrule/subdomains/com/shouldrule/code/public_html/generate.php";

        [TestMethod]
        [TestCategory("URLFetcher")]
        public void CodeGeneratorLength()
        {
            URLFetcher uf = new URLFetcher();
            string codegen = uf.fetch(codegen_url);

            // 20160724155619547291573
            Assert.AreEqual(codegen.Length, 23);
        }

        [TestMethod]
        [TestCategory("URLFetcher")]
        public void BrowseURL()
        {
            URLFetcher uf = new URLFetcher();
            string lorem = "";
            lorem = uf.fetch(lorem_url);

            Assert.IsNotNull(lorem);
        }

        [TestMethod]
        [TestCategory("URLFetcher")]
        public void FetchEmptyURL()
        {
            URLFetcher uf = new URLFetcher();

            string invalid_url = "";
            string invalid_data = uf.fetch(invalid_url);

            Assert.IsNotNull(invalid_data);
            Assert.AreEqual(invalid_data, "");
            //Console.WriteLine("Invalid data: "+ invalid_data);
        }
        
    }
}
