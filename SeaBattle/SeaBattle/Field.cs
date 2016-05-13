﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeaBattle
{
    public class Field
    {
        private Cell[][] cells;
        private List<Ship> ships = new List<Ship>();
        private int width = 10;
        private int height = 10;
        //private int maxShip;
        private int countOneShips = 4;
        private int countTwoShips = 3;
        private int countThreeShips = 2;
        private int countFourShips = 1;
        private int numLiveShips = 0;
        
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

        public int getHeight()
        {
            return this.height;
        }

        public int getWidth()
        {
            return this.width;
        }

        public void setShip(int size, int x, int y, int dx, int dy)
        {
            Ship ship = new Ship(this, size, x, y, dx, dy);
            ships.Add(ship);
        }

        public Cell getCell(int x, int y)
        {
            return cells[y][x];
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
                case 1: return countOneShips; break;
                case 2: return countTwoShips; break;
                case 3: return countThreeShips; break;
                case 4: return countFourShips; break;
                default: return 0;
            }
        }

    }
}