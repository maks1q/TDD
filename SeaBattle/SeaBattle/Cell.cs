using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeaBattle
{
    public class Cell
    {
        private int x;
        private int y;

        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
    }
}
