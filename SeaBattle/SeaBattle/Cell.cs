using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeaBattle
{
    public class Cell
    {
        public const int CELL_WATER = 1;
        public const int CELL_BORDER = 2;
	    public const int CELL_WELL = 3;
	    public const int CELL_INJURED = 4;
	    public const int CELL_KILLED = 5;
	    public const int CELL_MISSED = 6;

        private int x;
        private int y;
        private int state;
        private bool mark;
        private Ship ship;

        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.state = CELL_WATER;
            this.mark = false;
        }

        public void setShip(Ship ship)
        {
            this.ship = ship;
        }

        public Ship getShip()
        {
            return this.ship;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public void setState(int state)
        {
            this.state = state;
        }

        public int getState()
        {
            return this.state;
        }

        public bool isMark()
        {
            return this.mark;
        }

        public void setMark(bool mark)
        {
            this.mark = mark;
        }

        public int doShot()
        {
            setMark(true);
            if (state == CELL_WELL)
            {
                setState(CELL_INJURED);
                return ship.doShot();
            }
            else
            {
                if ((state == CELL_BORDER) || (state == CELL_WATER))
                {
                    setState(CELL_MISSED);
                }
            }
            return Field.SHOT_MISSED;
        }
    }
}
