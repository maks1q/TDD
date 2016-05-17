using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeaBattle;

namespace SeaBattleTests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void TestGameStartMethod()
        {
            Game game = new Game();
            Assert.AreEqual(Game.PLAYER_ONE, game.getCurrentPlayer());
        }

        [TestMethod]
        public void TestGameMethod2()
        {
            Game game = new Game();
            game.setCurrentPlayer(Game.PLAYER_TWO);
            Assert.AreEqual(Game.PLAYER_TWO, game.getCurrentPlayer());
        }
    }
}
