using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeaBattle;
using System.Collections.Generic;

namespace SeaBattleTests
{
    [TestClass]
    public class ShipTests
    {
        [TestMethod]
        public void BorderCellsTest1()
        {
            Field field = new Field();
            Ship ship = new Ship(field, 1, 0, 0, 0, 0);
            List<Cell> cells = ship.getBorderCells();
            Assert.AreEqual(3, cells.Count);
        }

        [TestMethod]
        public void BorderCellsTest2()
        {
            Field field = new Field();
            Ship ship = new Ship(field, 3, 4, 5, 6, 5);
            List<Cell> cells = ship.getBorderCells();
            Assert.AreEqual(12, cells.Count);
        }

        [TestMethod]
        public void BorderCellsTest3()
        {
            Field field = new Field();
            Ship ship = new Ship(field, 4, 9, 6, 9, 9);
            List<Cell> cells = ship.getBorderCells();
            Assert.AreEqual(6, cells.Count);
        }

        [TestMethod]
        public void BorderCellsTest4()
        {
            Field field = new Field();
            Ship ship = new Ship(field, 2, 0, 8, 0, 9);
            List<Cell> cells = ship.getBorderCells();
            Assert.AreEqual(4, cells.Count);
        }

        [TestMethod]
        public void BorderCellsTest5()
        {
            Field field = new Field();
            Ship ship = new Ship(field, 4, 9, 0, 9, 3);
            List<Cell> cells = ship.getBorderCells();
            Assert.AreEqual(6, cells.Count);
        }

        [TestMethod]
        public void BorderCellsTest6()
        {
            Field field = new Field();
            Ship ship = new Ship(field, 3, 2, 0, 2, 2);
            List<Cell> cells = ship.getBorderCells();
            Assert.AreEqual(9, cells.Count);
        }

        [TestMethod]
        public void BorderCellsTest7()
        {
            Field field = new Field();
            Ship ship = new Ship(field, 2, 0, 4, 1, 4);
            List<Cell> cells = ship.getBorderCells();
            Assert.AreEqual(7, cells.Count);
        }

        [TestMethod]
        public void BorderCellsTest8()
        {
            Field field = new Field();
            Ship ship = new Ship(field, 1, 4, 9, 4, 9);
            List<Cell> cells = ship.getBorderCells();
            Assert.AreEqual(5, cells.Count);
        }

        [TestMethod]
        public void TestShipDoShot()
        {
            Field field = new Field();
            field.setShip(2, 0, 0, 1, 0);
            field.getCell(0, 0).doShot();
            field.getCell(1, 0).doShot();
            Assert.AreEqual(0, field.getCell(0, 0).getShip().getHealth());
        }

        [TestMethod]
        public void TestShipDoShot1()
        {
            Field field = new Field();
            field.setShip(2, 0, 0, 1, 0);
            field.getCell(0, 0).doShot();
            field.getCell(1, 0).doShot();
            Assert.AreEqual(Ship.SHIP_KILLED, field.getCell(0, 0).getShip().getState());
        }

        [TestMethod]
        public void TestShipDoShot2()
        {
            Field field = new Field();
            field.setShip(2, 0, 0, 1, 0);
            field.getCell(0, 0).doShot();
            Assert.AreEqual(Ship.SHIP_INJURED, field.getCell(0, 0).getShip().getState());
        }

        [TestMethod]
        public void TestShipDoShot3()
        {
            Field field = new Field();
            Ship ship = new Ship(field, 3, 4, 5, 6, 5);
            ship.doShot();
            ship.doShot();
            ship.doShot();
            Assert.AreEqual(Ship.SHIP_KILLED, ship.getState());
        }

        [TestMethod]
        public void TestShipDoShot4()
        {
            Field field = new Field();
            Ship ship = new Ship(field, 3, 4, 5, 6, 5);
            ship.doShot();
            ship.doShot();
            Assert.AreEqual(Ship.SHIP_INJURED, ship.getState());
        }

        [TestMethod]
        public void TestShipDoShot5()
        {
            Field field = new Field();
            Ship ship = new Ship(field, 3, 4, 5, 6, 5);
            ship.doShot();
            ship.doShot();
            Assert.AreEqual(Field.SHOT_KILLED, ship.doShot());
        }

        [TestMethod]
        public void TestShipDoShot6()
        {
            Field field = new Field();
            Ship ship = new Ship(field, 3, 4, 5, 6, 5);
            ship.doShot();
            Assert.AreEqual(Field.SHOT_INJURED, ship.doShot());
        }
    }
}
