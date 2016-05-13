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
    }
}
