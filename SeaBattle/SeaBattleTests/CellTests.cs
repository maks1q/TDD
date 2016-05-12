using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeaBattle;

namespace SeaBattleTests
{
    [TestClass]
    public class CellTests
    {
        [TestMethod]
        public void TestCell1()
        {
            int x = 0;
            int y = 0;
            Cell cell = new Cell(x, y);
            Assert.AreEqual(0, cell.getX());
            Assert.AreEqual(0, cell.getY());          
        }
    }
}
