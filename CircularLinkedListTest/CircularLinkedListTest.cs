using CircularList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CircularLinkedListTest
{
    
    
    /// <summary>
    ///This is a test class for CircularLinkedListTest and is intended
    ///to contain all CircularLinkedListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CircularLinkedListTest
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
        ///A test for CircularLinkedList Constructor
        ///</summary>
        [TestMethod()]
        public void CircularLinkedListConstructorTest()
        {
            string n = "Arthur";
            CircularLinkedList target = new CircularLinkedList(n);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CircularLinkedList Constructor
        ///</summary>
        [TestMethod()]
        public void CircularLinkedListConstructorTest1()
        {
            CircularLinkedList target = new CircularLinkedList();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AddNode
        ///</summary>
        [TestMethod()]
        public void AddNodeTest()
        {
            CircularLinkedList target = new CircularLinkedList();
            string n = "Arthur";
            target.AddNode(n);
            Assert.AreEqual(n, target.head.next.Name);
            Assert.AreEqual(target.head.next, target.head);
        }

        /// <summary>
        ///A test for FindNodes
        ///</summary>
        [TestMethod()]
        public void FindNodesTest()
        {
            CircularLinkedList target = new CircularLinkedList();
            string n = string.Empty;
            bool expected = false;
            bool actual;
            actual = target.FindNodes(n);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PrintNodes
        ///</summary>
        [TestMethod()]
        public void PrintNodesTest()
        {
            CircularLinkedList target = new CircularLinkedList();
            target.PrintNodes();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RemoveNode
        ///</summary>
        [TestMethod()]
        public void RemoveNodeTest()
        {
            CircularLinkedList target = new CircularLinkedList();
            string n = string.Empty;
            bool expected = false;
            bool actual;
            actual = target.RemoveNode(n);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
