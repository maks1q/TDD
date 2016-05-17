using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeaBattle
{
    public class Field
    {
        public const int SHOT_MISSED = 1; 
	    public const int SHOT_INJURED = 2; 
	    public const int SHOT_KILLED = 3; 
	    public const int SHOT_WIN = 4;

        private Cell[][] cells;
        private List<Ship> ships = new List<Ship>();
        private int width = 10;
        private int height = 10;
        //private int maxShip;
        private int countOneShips = 4;
        private int countTwoShips = 3;
        private int countThreeShips = 2;
        private int countFourShips = 1;
        private int countLiveShips = 0;
        
        public Field()
        {    
            cells = new Cell[height][];
            for (int i = 0; i < height; i++ )
            {
                cells[i] = new Cell[width];
            }
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    cells[y][x] = new Cell(x, y);
                }
        }

        public Cell[][] getFieldCells()
        {
            return cells;
        }

        public int getHeight()
        {
            return this.height;
        }

        public int getWidth()
        {
            return this.width;
        }

        public bool setShip(int size, int x, int y, int dx, int dy)
        {
            for(int i = 0; i < size; i++)
            {
                if (y == dy)
                {
                    if(cells[y][x + i].getState() == Cell.CELL_WELL || cells[y][x + i].getState() == Cell.CELL_BORDER)
                        return false;
                }
                else if (x == dx)
                {
                    if(cells[y + i][x].getState() == Cell.CELL_WELL || cells[y + i][x].getState() == Cell.CELL_BORDER)
                        return false;
                }
                else
                {
                    return false;
                }
            }
            Ship ship = new Ship(this, size, x, y, dx, dy);
            ships.Add(ship);
            countLiveShips++;
            return true;
        }

        public int getCountLiveShips()
        {
            return this.countLiveShips;
        }

        public void setCountLiveShips(int count)
        {
            this.countLiveShips = count;
        }

        public Cell getCell(int x, int y)
        {
            return cells[y][x];
        }

        public int doShot(int x, int y)
        {
            int shot = getCell(x, y).doShot();
            if (countLiveShips == 0)
                return SHOT_WIN;
            return shot;
        }

        //задать количество кораблей одного из типов
        public void setCountShips(int ship, int count)
        {
            switch (ship)
            {
                case 1: countOneShips = count; break;
                case 2: countTwoShips = count; break;
                case 3: countThreeShips = count; break;
                case 4: countFourShips = count; break;
            }
        }

        //получить количество кораблей одного из типов
        public int getCountShips(int ship)
        {
            switch (ship)
            {
                case 1: return countOneShips;
                case 2: return countTwoShips;
                case 3: return countThreeShips;
                case 4: return countFourShips;
                default: return 0;
            }
        }

    }
}
