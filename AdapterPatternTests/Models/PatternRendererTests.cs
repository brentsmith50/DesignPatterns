using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdapterPattern.Models;
using System.Linq;

namespace AdapterPatternTests.Models
{
    [TestClass]
    public class PatternRendererTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var renderer = new PatternRenderer();

            var patternList = new List<Pattern>
            {
                new Pattern {Id = 1, Name = "Pattern One", Description = "Pattern One Description"},
                new Pattern {Id = 2, Name = "Pattern Two", Description = "Pattern Two Description"}
            };

            string result = renderer.ListPatterns(patternList);
            int totalCharacterCount = result.Count();
            
            // THIS IS some the worst logic I can imagine .... WHY  are we countin newlines???? who cares...
            int columnCount = result.Count(c => c == '\n');
            Assert.AreEqual(patternList.Count + 2, columnCount);
        }
    }
}
