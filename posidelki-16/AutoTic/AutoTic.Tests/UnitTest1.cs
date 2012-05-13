using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using AutoTic.TestModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#region ====== NUnit / MSTest
#if !NUNIT
using Microsoft.VisualStudio.TestTools.UnitTesting;
#else
using NUnit.Framework;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
using ClassInitialize = NUnit.Framework.TestFixtureTearDownAttribute;
using ClassCleanup = NUnit.Framework.TestFixtureTearDownAttribute;
#endif
#endregion

namespace AutoTic.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
        


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
        public void TestMethod1()
        {
            GameBoardPage boardPage = new GameBoardPage();
            var gameConfig = new GameConfiguration()
                                 {
                                     CrossesMovesFirst = false,
                                     CrossesPlayerType = "Expert",
                                     NoughtsPlayerType = "Expert",
                                 };
            boardPage.Show();
            boardPage.Set(gameConfig);
            boardPage.ClearStats();


            for (var i = 1; i < 100; i++)
            {
                boardPage.StartNewGame();
                
            }

            
            gameConfig.UpdateFromCurrentStatus();


            Assert.AreEqual(0, gameConfig.NoughtsWinsCount);
            Assert.AreEqual(0, gameConfig.CrossesWinsCount);

        }

        [TestMethod]
        public void TestMethod2()
        {

            GameBoardPage boardPage = new GameBoardPage();
            boardPage.Show();

            GameBoard board = new GameBoard();
            board.AddRange(new string[] 
            { "x", "o", "x", 
              "", "x", "" ,
              "o", "", "" });
            board.Set();
        }

    }
}
