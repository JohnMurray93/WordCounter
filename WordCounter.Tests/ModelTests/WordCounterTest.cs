using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.TestTools {

    [TestClass]
    public class RepeatCounterTest {
        [TestMethod]
        public void appearsThrice () {
            WordCount count = new WordCount ("Law", "There is no law except the law that there is no law.");
            int correctCount = 3;
            int returnCount = count.GetCount ();
            Assert.AreEqual (correctCount, returnCount);
        }
    }
}