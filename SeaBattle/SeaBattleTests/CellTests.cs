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

        [TestMethod]
        public void TestDoShot()
        {
            Field field = new Field();
            field.setShip(1, 0, 0, 0, 0); 
            field.getCell(1, 1).doShot();
            Assert.AreEqual(Cell.CELL_MISSED, field.getCell(1, 1).getState());
        }

        [TestMethod]
        public void TestDoShot1()
        {
            Field field = new Field();
            field.setShip(2, 0, 0, 1, 0);
            field.getCell(0, 0).doShot();
            Assert.AreEqual(Cell.CELL_INJURED, field.getCell(0, 0).getState());
        }

        [TestMethod]
        public void TestDoShot2()
        {
            Field field = new Field();
            field.setShip(1, 0, 0, 0, 0);
            field.getCell(0, 0).doShot();
            Assert.AreEqual(Cell.CELL_KILLED, field.getCell(0, 0).getState());
        }

        [TestMethod]
        public void TestDoShot3()
        {
            Field field = new Field();
            field.setShip(3, 0, 0, 0, 2);
            field.getCell(5, 7).doShot();
            Assert.AreEqual(Cell.CELL_MISSED, field.getCell(5, 7).getState());
        }

        [TestMethod]
        public void TestDoShot4()
        {
            Field field = new Field();
            field.setShip(1, 0, 0, 0, 0);
            field.getCell(0, 0).doShot();
            Assert.AreEqual(Cell.CELL_WATER, field.getCell(7, 2).getState());
        }
    }
}
