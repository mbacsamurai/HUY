using miniProjectH;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for CustomExtensionTest and is intended
    ///to contain all CustomExtensionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CustomExtensionTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetAllCtls
        ///</summary>
        [TestMethod()]
        public void GetAllCtlsTest()
        {
            Control control = null; // TODO: Initialize to an appropriate value
            Type type = null; // TODO: Initialize to an appropriate value
            IEnumerable<Control> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<Control> actual;
            actual = CustomExtension.GetAllCtls(control, type);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
