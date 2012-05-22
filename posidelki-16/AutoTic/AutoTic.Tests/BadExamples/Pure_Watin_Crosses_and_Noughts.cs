using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatiN.Core;

namespace AutoTic.Tests.BadExamples
{
    [TestClass]
    public class Pure_Watin_Crosses_and_Noughts
    {
        [TestMethod]
        public void PureWatiNTest()
        {
            IE ie = new IE(@"http://ostermiller.org/calc/tictactoe.html");

            ie.SelectList(Find.ByName("p1")).Select("Human");
            ie.SelectList(Find.ByName("p2")).Select("Human");
            
            ie.Button(Find.ByValue(@"New Game")).Click();
            ie.Button(Find.ByValue(@"Clear Stats")).Click();
            
            ie.Button(Find.ByName("c9")).Click();
            ie.Button(Find.ByName("c8")).Click();

            ie.Button(Find.ByName("c5")).Click();
            ie.Button(Find.ByName("c6")).Click();
            

            ie.Button(Find.ByName("c1")).Click();

            var btnPlayerXStats = ie.Button(Find.ByName("xWon"));

            Assert.AreEqual("1", btnPlayerXStats.Value);

        }
    }
}
