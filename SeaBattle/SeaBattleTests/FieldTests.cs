using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeaBattle;

namespace SeaBattleTests
{
    [TestClass]
    public class FieldTests
    {
        [TestMethod]
        public void TestGetCell()
        {
            Field field = new Field();
            Cell cell = field.getCell(5, 3);
            Assert.AreEqual(5, cell.getX());
        }

        [TestMethod]
        public void TestSetShip()
        {
            Field field = new Field();
            field.setShip(1, 3, 5, 3, 5);
            Assert.AreEqual(Cell.CELL_WELL, field.getCell(3, 5).getState());
        }

        [TestMethod]
        public void TestSetShip1()
        {
            Field field = new Field();
            field.setShip(1, 3, 5, 3, 5);
            Assert.AreEqual(Cell.CELL_BORDER, field.getCell(3, 6).getState());
        }

        [TestMethod]
        public void TestSetShip2()
        {
            Field field = new Field();
            field.setShip(1, 3, 5, 3, 5);
            Assert.AreEqual(Cell.CELL_WATER, field.getCell(3, 7).getState());
        }

        [TestMethod]
        public void TestCountLiveShips()
        {
            Field field = new Field();
            field.setShip(2, 3, 5, 3, 6);

            Assert.AreEqual(1, field.getCountLiveShips());
        }

        [TestMethod]
        public void TestCountLiveShips2()
        {
            Field field = new Field();
            field.setShip(1, 0, 0, 0, 0);
            field.setShip(1, 0, 0, 0, 0);
            Assert.AreEqual(1, field.getCountLiveShips());
        }

        [TestMethod]
        public void TestCountLiveShips3()
        {
            Field field = new Field();
            field.setShip(1, 0, 0, 0, 0);
            field.setShip(1, 0, 1, 0, 1);
            Assert.AreEqual(1, field.getCountLiveShips());
        }

        [TestMethod]
        public void TestCountLiveShips4()
        {
            Field field = new Field();
            field.setShip(1, 0, 0, 0, 0);
            field.setShip(1, 0, 2, 0, 2);
            field.setShip(1, 2, 0, 2, 0);
            Assert.AreEqual(3, field.getCountLiveShips());
        }

        [TestMethod]
        public void TestFieldDoShot()
        {
            Field field = new Field();
            field.setShip(4, 4, 5, 7, 5);
            Assert.AreEqual(Field.SHOT_INJURED, field.doShot(5, 5));
        }

        [TestMethod]
        public void TestFieldDoShot1()
        {
            Field field = new Field();
            field.setShip(1, 0, 0, 0, 0);
            field.setShip(4, 4, 5, 7, 5);
            field.doShot(4, 5);
            field.doShot(5, 5);
            field.doShot(6, 5);
            Assert.AreEqual(Field.SHOT_KILLED, field.doShot(7, 5));
        }

        [TestMethod]
        public void TestFieldDoShot2()
        {
            Field field = new Field();
            field.setShip(4, 4, 5, 7, 5);
            field.doShot(4, 5);
            field.doShot(5, 5);
            field.doShot(6, 5);
            Assert.AreEqual(Field.SHOT_WIN, field.doShot(7, 5));
        }
    }
}
