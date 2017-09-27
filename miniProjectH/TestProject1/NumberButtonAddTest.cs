using miniProjectH;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for NumberButtonAddTest and is intended
    ///to contain all NumberButtonAddTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NumberButtonAddTest
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
        ///A test for LoopCreateButton
        ///</summary>
        [TestMethod()]
        [DeploymentItem("miniProjectH.exe")]
        public void LoopCreateButtonTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            NumberButtonAdd_Accessor target = new NumberButtonAdd_Accessor(param0); // TODO: Initialize to an appropriate value
            int min = 0; // TODO: Initialize to an appropriate value
            int max = 0; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            target.LoopCreateButton(min, max, format);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GenarateButtonTwoUnit
        ///</summary>
        [TestMethod()]
        public void GenarateButtonTwoUnitTest()
        {
            Control cont = null; // TODO: Initialize to an appropriate value
            int min = 0; // TODO: Initialize to an appropriate value
            int max = 0; // TODO: Initialize to an appropriate value
            NumberButtonAdd target = new NumberButtonAdd(cont, min, max); // TODO: Initialize to an appropriate value
            target.GenarateButtonTwoUnit();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GenarateButtonThreeUnit
        ///</summary>
        [TestMethod()]
        public void GenarateButtonThreeUnitTest()
        {
            Control cont = null; // TODO: Initialize to an appropriate value
            int min = 0; // TODO: Initialize to an appropriate value
            int max = 0; // TODO: Initialize to an appropriate value
            NumberButtonAdd target = new NumberButtonAdd(cont, min, max); // TODO: Initialize to an appropriate value
            target.GenarateButtonThreeUnit();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GenarateButtonOneUnit
        ///</summary>
        [TestMethod()]
        public void GenarateButtonOneUnitTest()
        {
            Control cont = null; // TODO: Initialize to an appropriate value
            int min = 0; // TODO: Initialize to an appropriate value
            int max = 0; // TODO: Initialize to an appropriate value
            NumberButtonAdd target = new NumberButtonAdd(cont, min, max); // TODO: Initialize to an appropriate value
            target.GenarateButtonOneUnit();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for NumberButtonAdd Constructor
        ///</summary>
        [TestMethod()]
        public void NumberButtonAddConstructorTest()
        {
            Control cont = null; // TODO: Initialize to an appropriate value
            int min = 0; // TODO: Initialize to an appropriate value
            int max = 0; // TODO: Initialize to an appropriate value
            NumberButtonAdd target = new NumberButtonAdd(cont, min, max);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
