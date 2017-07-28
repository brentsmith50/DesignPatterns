using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdapterPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.Tests;
using System.IO;

namespace AdapterPattern.Models.Tests
{
    [TestClass()]
    public class DataRendererTests
    {
        [TestMethod]
        public void RenderOneRowStubDataAdapter()
        {
            var renderer = new DataRenderer(new StubDbAdapter());

            var writer = new StringWriter();
            renderer.Render(writer);

            string result = writer.ToString();
            Console.Write(result);
            int columnCount = result.Count(c => c == '\n');
            Assert.AreEqual(3, columnCount);
        }
    }
}