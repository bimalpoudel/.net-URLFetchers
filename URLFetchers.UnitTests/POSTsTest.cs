using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using URLFetchers.Library;
using System.Collections.Specialized;

namespace URLFetchers.UnitTests
{
    /// <summary>
    /// Summary description for POSTsTest
    /// </summary>
    [TestClass]
    public class POSTsTest
    {
        public POSTsTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        [TestCategory("POST")]
        public void PipeSeparatedPOST()
        {
            URLFetcher uf = new URLFetcher();
            string request_url = "http://localhost/api/post.php";
            // echo implode('|', $_POST);

            NameValueCollection data = new NameValueCollection();
            data["username"] = "username";
            data["password"] = "password";

            string response = uf.post(request_url, data);
            Assert.AreEqual(response, String.Format("{0}|{1}", data["username"], data["password"]));
        }

        [TestMethod]
        [TestCategory("POST")]
        public void ComplexDataPOST()
        {
            URLFetcher uf = new URLFetcher();
            string request_url = "http://localhost/api/post-complex.php";
            string response = "";
            // echo json_encode($_POST);

            NameValueCollection data = new NameValueCollection();
            data["login[username]"] = "username";
            data["login[password]"] = "password";
            data["token"] = "xyz";

            response = uf.post(request_url, data);

            Assert.IsTrue(response.Contains("token"));
            Assert.IsTrue(response.Contains("complex"));

            // System.FormatException: Input string was not in a correct format.
            //Assert.AreEqual(response, String.Format("{\"login\":{\"username\":\"{0}\",\"password\":\"{1}\"},\"token\":\"{2}\"}", data["login[username]"], data["login[password]"], data["token"]));
        }
    }
}
