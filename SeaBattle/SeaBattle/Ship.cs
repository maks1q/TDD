using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Ship
    {
        public const int SHIP_WELL = 1;
	    public const int SHIP_INJURED = 2;
	    public const int SHIP_KILLED = 3;

        private int x, y;
        private int dx, dy;
        private int size;
        private int health;
        private int state;
        private Field field;
        private List<Cell> listCells = new List<Cell>();
        private List<Cell> listBorders = new List<Cell>();
        
        public Ship(Field field, int size, int x, int y, int dx, int dy)
        {
            this.field = field;
            this.size = size;
            this.health = size;
            this.state = SHIP_WELL;
            this.x = x;
            this.y = y;
            this.dx = dx;
            this.dy = dy;
            for(int i = 0; i< size; i++)
            {
                Cell cell;
                if (y == dy)
                {
                    cell = field.getCell(x + i, y); //new Cell(x + i, y);
                    cell.setState(Cell.CELL_WELL);
                    listCells.Add(cell);
                    cell.setShip(this);
                }
                else if (x == dx)
                {
                    cell = field.getCell(x, y + i); //new Cell(x, y + i);
                    cell.setState(Cell.CELL_WELL);
                    listCells.Add(cell);
                    cell.setShip(this);
                }
            }
            for(int i = 0; i < size; i++)
            {
                int cx = listCells[i].getX();
                int cy = listCells[i].getY();
                Cell cell = field.getCell(cx, cy);
                if(cx - 1 >= 0 && cy - 1 >= 0)
                {
                    Cell c = field.getCell(cx - 1, cy - 1);
                    if(c.getState() != Cell.CELL_WELL && c.getState() != Cell.CELL_BORDER)
                    {
                        c.setState(Cell.CELL_BORDER);
                        listBorders.Add(c);
                    }
                }
                if(cx >= 0 && cy - 1 >= 0)
                {
                    Cell c = field.getCell(cx, cy - 1);
                    if (c.getState() != Cell.CELL_WELL && c.getState() != Cell.CELL_BORDER)
                    {
                        c.setState(Cell.CELL_BORDER);
                        listBorders.Add(c);
                    }
                }
                if (cx + 1 <= field.getWidth() - 1 && cy - 1 >= 0)
                {
                    Cell c = field.getCell(cx + 1, cy - 1);
                    if (c.getState() != Cell.CELL_WELL && c.getState() != Cell.CELL_BORDER)
                    {
                        c.setState(Cell.CELL_BORDER);
                        listBorders.Add(c);
                    }
                }
                if (cx + 1 <= field.getWidth() - 1 && cy >= 0)
                {
                    Cell c = field.getCell(cx + 1, cy);
                    if (c.getState() != Cell.CELL_WELL && c.getState() != Cell.CELL_BORDER)
                    {
                        c.setState(Cell.CELL_BORDER);
                        listBorders.Add(c);
                    }
                }
                if (cx + 1 <= field.getWidth() - 1 && cy + 1 <= field.getHeight() - 1)
                {
                    Cell c = field.getCell(cx + 1, cy + 1);
                    if (c.getState() != Cell.CELL_WELL && c.getState() != Cell.CELL_BORDER)
                    {
                        c.setState(Cell.CELL_BORDER);
                        listBorders.Add(c);
                    }
                }
                if (cx >= 0 && cy + 1 <= field.getHeight() - 1)
                {
                    Cell c = field.getCell(cx, cy + 1);
                    if (c.getState() != Cell.CELL_WELL && c.getState() != Cell.CELL_BORDER)
                    {
                        c.setState(Cell.CELL_BORDER);
                        listBorders.Add(c);
                    }
                }
                if (cx - 1 >= 0 && cy + 1 <= field.getHeight() - 1)
                {
                    Cell c = field.getCell(cx - 1, cy + 1);
                    if (c.getState() != Cell.CELL_WELL && c.getState() != Cell.CELL_BORDER)
                    {
                        c.setState(Cell.CELL_BORDER);
                        listBorders.Add(c);
                    }
                }
                if (cx - 1 >= 0 && cy >= 0)
                {
                    Cell c = field.getCell(cx - 1, cy);
                    if (c.getState() != Cell.CELL_WELL && c.getState() != Cell.CELL_BORDER)
                    {
                        c.setState(Cell.CELL_BORDER);
                        listBorders.Add(c);
                    }
                }
            }
        }

        public int doShot() 
        {
		    if (health != 0) 
            {
			    health--;
			    if (health == 0) 
                {
				    field.setCountLiveShips(field.getCountLiveShips() - 1);
				    state = Ship.SHIP_KILLED;
                    for(int i = 0; i < listCells.Count; i++)
                    {
                        listCells[i].setState(Cell.CELL_KILLED);
                    }
                    for(int i = 0; i < listBorders.Count; i++)
                    {
                        listBorders[i].setState(Cell.CELL_MISSED);
                        listBorders[i].setMark(true);
                    }
				    return Field.SHOT_KILLED;
			    } 
                else 
                {
				    state = SHIP_INJURED;
			    }
		    }
		    return Field.SHOT_INJURED;
	    }

        public int getHealth()
        {
            return this.health;
        }

        public int getState()
        {
            return this.state;
        }

        public List<Cell> getBorderCells()
        {
            return listBorders;
        }
    }
}
