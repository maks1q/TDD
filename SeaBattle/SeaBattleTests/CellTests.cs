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

        [TestMethod]
        public void TestCellState()
        {
            Cell cell = new Cell(0, 0);
            cell.setState(Cell.CELL_WATER);
            Assert.AreEqual(Cell.CELL_WATER, cell.getState());
        }

        [TestMethod]
        public void TestCellMark()
        {
            Cell cell = new Cell(0, 0);
            Assert.AreEqual(false, cell.isMark());
        }

        [TestMethod]
        public void TestCellMark2()
        {
            Cell cell = new Cell(0, 0);
            cell.setMark(true);
            Assert.AreEqual(true, cell.isMark());
        }
    }
}
