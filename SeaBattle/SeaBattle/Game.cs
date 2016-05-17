using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeaBattle
{
    public class Game
    {
        public const int PLAYER_ONE = 1;
        public const int PLAYER_TWO = 2;

        private Field playerOneField;
        private Field playerTwoField;
        private int currentPlayer;

        public Game()
        {
            this.currentPlayer = PLAYER_ONE;
            this.playerOneField = new Field();
            this.playerTwoField = new Field();
        }

        public void setCurrentPlayer(int player)
        {
            this.currentPlayer = player;
        }

        public int getCurrentPlayer()
        {
            return this.currentPlayer;
        }

        public Field getPlayerOneField()
        {
            return this.playerOneField;
        }

        public Field getPlayerTwoField() 
        {
            return this.playerTwoField;
        }
    }
}
