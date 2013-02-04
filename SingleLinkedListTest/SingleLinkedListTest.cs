using LinkedLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SingleLinkedListTest
{
    
    
    /// <summary>
    ///This is a test class for SingleLinkedListTest and is intended
    ///to contain all SingleLinkedListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SingleLinkedListTest
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
        ///A test for SingleLinkedList Constructor
        ///</summary>
        [TestMethod()]
        public void SingleLinkedListConstructorTest()
        {
            string n = "New Linked List"; // TODO: Initialize to an appropriate value
            SingleLinkedList target = new SingleLinkedList(n);
            Assert.IsTrue(target.head.Name == "New Linked List");
            Assert.IsTrue(target.Length == 1);
            Assert.IsNull(target.head.next);
        }

        /// <summary>
        ///A test for SingleLinkedList Constructor
        ///</summary>
        [TestMethod()]
        public void SingleLinkedListConstructorTest1()
        {
            SingleLinkedList target = new SingleLinkedList();
            Assert.IsNull(target.head.Name);
            Assert.IsNull(target.head.next);
            Assert.IsTrue(target.Length == 1);
        }

        /// <summary>
        ///A test for AddNewNode
        ///</summary>
        [TestMethod()]
        public void AddNewNodeTest()
        {
            SingleLinkedList target = new SingleLinkedList();
            string n = "Arthur";
            target.AddNewNode(n);
            Assert.AreEqual(n, target.head.next.Name);
        }

        /// <summary>
        ///A test for FindNode
        ///</summary>
        [TestMethod()]
        public void FindNodeTest()
        {
            SingleLinkedList target = new SingleLinkedList();
            string n = "Arthur";
            bool expected = true;
            bool actual;
            target.AddNewNode(n);
            actual = target.FindNode(n);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for RemoveNode
        ///</summary>
        [TestMethod()]
        public void RemoveNodeTest()
        {
            SingleLinkedList target = new SingleLinkedList();
            string n = "Arthur";
            target.AddNewNode(n);
            target.RemoveNode(n);
            Assert.IsNull(target.head.next);
        }
    }
}
