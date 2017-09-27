using miniProjectH;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for ButtonHTest and is intended
    ///to contain all ButtonHTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ButtonHTest
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
        ///A test for StateClick
        ///</summary>
        [TestMethod()]
        public void StateClickTest()
        {
            ButtonH target = new ButtonH(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.StateClick = expected;
            actual = target.StateClick;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UnClick
        ///</summary>
        [TestMethod()]
        [DeploymentItem("miniProjectH.exe")]
        public void UnClickTest()
        {
            ButtonH_Accessor target = new ButtonH_Accessor(); // TODO: Initialize to an appropriate value
            target.UnClick();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnClick
        ///</summary>
        [TestMethod()]
        [DeploymentItem("miniProjectH.exe")]
        public void OnClickTest()
        {
            ButtonH_Accessor target = new ButtonH_Accessor(); // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.OnClick(e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Clicked
        ///</summary>
        [TestMethod()]
        [DeploymentItem("miniProjectH.exe")]
        public void ClickedTest()
        {
            ButtonH_Accessor target = new ButtonH_Accessor(); // TODO: Initialize to an appropriate value
            target.Clicked();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ButtonH Constructor
        ///</summary>
        [TestMethod()]
        public void ButtonHConstructorTest()
        {
            ButtonH target = new ButtonH();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
