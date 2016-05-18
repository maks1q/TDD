using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeaBattle;

namespace SeaBattleGame
{
    public partial class Form1 : Form
    {
        Game game;
        Field playerOneField;
        Field playerTwoField;

        int countOneShips;
        int countTwoShips;
        int countThreeShips;
        int countFourShips;
        int countAllShips;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string name = "АБВГДЕЖЗИК";
            for (int i = 0; i < 10; i++)
            {
                dataGridViewPlayer.Rows.Add();
                dataGridViewPlayer.Rows[i].HeaderCell.Value = name[i].ToString();
                dataGridViewOpponent.Rows.Add();
                dataGridViewOpponent.Rows[i].HeaderCell.Value = name[i].ToString();
            }
            dataGridViewPlayer.CurrentCell = null;
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Начать новую игру?!","Новая игра",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                game = new Game();
                playerOneField = game.getPlayerOneField();
                playerTwoField = game.getPlayerTwoField();
                countOneShips = playerOneField.getCountShips(1);
                countTwoShips = playerOneField.getCountShips(2);
                countThreeShips = playerOneField.getCountShips(3);
                countFourShips = playerOneField.getCountShips(4); 
                countAllShips = countOneShips + countTwoShips + countThreeShips + countFourShips;
                labelOneCount.Text = countOneShips.ToString();
                labelTwoCount.Text = countTwoShips.ToString();
                labelThreeCount.Text = countThreeShips.ToString();
                labelFourCount.Text = countFourShips.ToString();
                dataGridViewPlayer.Enabled = true;
                dataGridViewOpponent.Enabled = true;
                //panelSetShips.Visible = true;
                //currentField.setShip(2, 1, 1, 2, 1);
                //currentField.setShip(2, 5, 1, 6, 1);
                //ставим корабли 1 игрока
                playerOneField.setShip(1, 0, 0, 0, 0);
                playerOneField.setShip(1, 2, 0, 2, 0);
                playerOneField.setShip(1, 4, 0, 4, 0);
                playerOneField.setShip(1, 6, 0, 6, 0);
                playerOneField.setShip(2, 2, 2, 3, 2);
                playerOneField.setShip(2, 5, 2, 6, 2);
                playerOneField.setShip(2, 8, 2, 9, 2);
                playerOneField.setShip(3, 0, 5, 2, 5);
                playerOneField.setShip(3, 4, 5, 6, 5);
                playerOneField.setShip(4, 0, 7, 3, 7);
                //ставим корабли 2 игрока
                playerTwoField.setShip(1, 0, 0, 0, 0);
                playerTwoField.setShip(1, 0, 2, 0, 2);
                playerTwoField.setShip(1, 0, 4, 0, 4);
                playerTwoField.setShip(1, 0, 6, 0, 6);
                playerTwoField.setShip(2, 0, 8, 0, 9);
                playerTwoField.setShip(2, 2, 0, 2, 1);
                playerTwoField.setShip(2, 2, 3, 2, 4);
                playerTwoField.setShip(3, 2, 6, 2, 8);
                playerTwoField.setShip(3, 4, 0, 4, 2);
                playerTwoField.setShip(4, 4, 4, 4, 7);

                drawPlayerField(playerOneField);
            }
        }

        private void dataGridViewOpponent_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = dataGridViewOpponent.CurrentCell.RowIndex;
            int columnIndex = dataGridViewOpponent.CurrentCell.ColumnIndex;
            int resultShot = 1;
            int statusCell = 1;
            if (game.getCurrentPlayer() == Game.PLAYER_ONE)
                statusCell = playerTwoField.getCell(columnIndex, rowIndex).getState();
            else if (game.getCurrentPlayer() == Game.PLAYER_TWO)
                statusCell = playerOneField.getCell(columnIndex, rowIndex).getState();
            if (statusCell == Cell.CELL_BORDER || statusCell == Cell.CELL_WATER || statusCell == Cell.CELL_WELL)
            {
                if (game.getCurrentPlayer() == Game.PLAYER_ONE)
                    resultShot = playerTwoField.doShot(columnIndex, rowIndex);
                else if (game.getCurrentPlayer() == Game.PLAYER_TWO)
                    resultShot = playerOneField.doShot(columnIndex, rowIndex);
                if (resultShot == Field.SHOT_INJURED)
                {
                    //dataGridViewOpponent.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.Red;
                    if (game.getCurrentPlayer() == Game.PLAYER_ONE)
                        drawOpponentField(playerTwoField);
                    else
                        drawOpponentField(playerOneField);
                }
                else if (resultShot == Field.SHOT_MISSED)
                {
                    dataGridViewOpponent.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.Gray;
                    if (game.getCurrentPlayer() == Game.PLAYER_ONE)
                    {
                        game.setCurrentPlayer(Game.PLAYER_TWO);
                        drawPlayerField(playerTwoField);
                        drawOpponentField(playerOneField);
                        labelStep.Text = "Ход игрока 2";
                    }
                    else if (game.getCurrentPlayer() == Game.PLAYER_TWO)
                    {
                        game.setCurrentPlayer(Game.PLAYER_ONE);
                        drawPlayerField(playerOneField);
                        drawOpponentField(playerTwoField);
                        labelStep.Text = "Ход игрока 1";
                    }
                }
                else if (resultShot == Field.SHOT_KILLED)
                {
                    if (game.getCurrentPlayer() == Game.PLAYER_ONE)
                        drawOpponentField(playerTwoField);
                    else if (game.getCurrentPlayer() == Game.PLAYER_TWO)
                        drawOpponentField(playerOneField);
                }
                else if (resultShot == Field.SHOT_WIN)
                {
                    if (game.getCurrentPlayer() == Game.PLAYER_ONE)
                        drawOpponentField(playerTwoField);
                    else if (game.getCurrentPlayer() == Game.PLAYER_TWO)
                        drawOpponentField(playerOneField);

                    MessageBox.Show("Игрок " + game.getCurrentPlayer().ToString() + " победил", "Конец");
                    clearTables();
                    dataGridViewPlayer.Enabled = false;
                    dataGridViewOpponent.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Вы стреляли сюда уже!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void clearTables()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    dataGridViewPlayer.Rows[i].Cells[j].Style.BackColor = Color.White;
                    dataGridViewOpponent.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        public void drawPlayerField(Field field)
        {
            Cell[][] cells = new Cell[10][];
            for (int i = 0; i < 10; i++)
            {
                cells[i] = new Cell[10];
            }
            cells = field.getFieldCells();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (cells[i][j].getState() == Cell.CELL_WELL)
                    {
                        dataGridViewPlayer.Rows[i].Cells[j].Style.BackColor = Color.Green;
                    }
                    else if (cells[i][j].getState() == Cell.CELL_INJURED)
                    {
                        dataGridViewPlayer.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }
                    else if (cells[i][j].getState() == Cell.CELL_KILLED)
                    {
                        dataGridViewPlayer.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    }
                    else if (cells[i][j].getState() == Cell.CELL_MISSED)
                    {
                        dataGridViewPlayer.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                    }
                    else if(cells[i][j].getState() == Cell.CELL_WATER || cells[i][j].getState() == Cell.CELL_BORDER)
                    {
                        dataGridViewPlayer.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }
            }
        }

        public void drawOpponentField(Field field)
        {
            Cell[][] cells = new Cell[10][];
            for (int i = 0; i < 10; i++)
            {
                cells[i] = new Cell[10];
            }
            cells = field.getFieldCells();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (cells[i][j].getState() == Cell.CELL_WELL)
                    {
                        dataGridViewOpponent.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                    else if (cells[i][j].getState() == Cell.CELL_INJURED)
                    {
                        dataGridViewOpponent.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }
                    else if (cells[i][j].getState() == Cell.CELL_KILLED)
                    {
                        dataGridViewOpponent.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    }
                    else if (cells[i][j].getState() == Cell.CELL_MISSED)
                    {
                        dataGridViewOpponent.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                    }
                    else if (cells[i][j].getState() == Cell.CELL_WATER || cells[i][j].getState() == Cell.CELL_BORDER)
                    {
                        dataGridViewOpponent.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }
            }
        }

        public int getNumber(string letter)
        {
            switch(letter)
            {
                case "А": case "а": return 0;
                case "Б": case "б": return 1;
                case "В": case "в": return 2;
                case "Г": case "г": return 3;
                case "Д": case "д": return 4;
                case "Е": case "е": return 5;
                case "Ж": case "ж": return 6;
                case "З": case "з": return 7;
                case "И": case "и": return 8;
                case "К": case "к": return 9;
                default: return 0;
            }
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (game.getCurrentPlayer() == Game.PLAYER_ONE)
            {
                int x = Convert.ToInt32(textBoxOneNum.Text) - 1;
                int y = getNumber(textBoxOneLetter.Text);
                int dx = Convert.ToInt32(textBoxOneNum2.Text) - 1;
                int dy = getNumber(textBoxOneLetter2.Text);
                if (playerOneField.setShip(1, x, y, dx, dy))
                {
                    countOneShips--;
                    if (countOneShips == 0)
                        buttonOne.Enabled = false;
                    countAllShips--;
                    if (countAllShips == 0)
                        buttonNext.Enabled = true;
                    drawPlayerField(playerOneField);
                    labelOneCount.Text = countOneShips.ToString();
                }
                else
                {
                    MessageBox.Show("Нельзя так ставить корабли", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if(game.getCurrentPlayer() == Game.PLAYER_TWO)
            {
                int x = Convert.ToInt32(textBoxOneNum.Text) - 1;
                int y = getNumber(textBoxOneLetter.Text);
                int dx = Convert.ToInt32(textBoxOneNum2.Text) - 1;
                int dy = getNumber(textBoxOneLetter2.Text);
                if (playerTwoField.setShip(1, x, y, dx, dy))
                {
                    countOneShips--;
                    if (countOneShips == 0)
                        buttonOne.Enabled = false;
                    countAllShips--;
                    if (countAllShips == 0)
                        buttonNext.Enabled = true;
                    drawPlayerField(playerTwoField);
                    labelOneCount.Text = countOneShips.ToString();
                }
                else
                {
                    MessageBox.Show("Нельзя так ставить корабли", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (game.getCurrentPlayer() == Game.PLAYER_ONE)
            {
                int x = Convert.ToInt32(textBoxTwoNum.Text) - 1;
                int y = getNumber(textBoxTwoLetter.Text);
                int dx = Convert.ToInt32(textBoxTwoNum2.Text) - 1;
                int dy = getNumber(textBoxTwoLetter2.Text);
                if (playerOneField.setShip(2, x, y, dx, dy))
                {
                    countTwoShips--;
                    if (countTwoShips == 0)
                        buttonTwo.Enabled = false;
                    countAllShips--;
                    if (countAllShips == 0)
                        buttonNext.Enabled = true;
                    drawPlayerField(playerOneField);
                    labelTwoCount.Text = countTwoShips.ToString();
                }
                else
                {
                    MessageBox.Show("Нельзя так ставить корабли", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (game.getCurrentPlayer() == Game.PLAYER_TWO)
            {
                int x = Convert.ToInt32(textBoxTwoNum.Text) - 1;
                int y = getNumber(textBoxTwoLetter.Text);
                int dx = Convert.ToInt32(textBoxTwoNum2.Text) - 1;
                int dy = getNumber(textBoxTwoLetter2.Text);
                if (playerTwoField.setShip(2, x, y, dx, dy))
                {
                    countTwoShips--;
                    if (countTwoShips == 0)
                        buttonTwo.Enabled = false;
                    countAllShips--;
                    if (countAllShips == 0)
                        buttonNext.Enabled = true;
                    drawPlayerField(playerTwoField);
                    labelTwoCount.Text = countTwoShips.ToString();
                }
                else
                {
                    MessageBox.Show("Нельзя так ставить корабли", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (game.getCurrentPlayer() == Game.PLAYER_ONE)
            {
                int x = Convert.ToInt32(textBoxThreeNum.Text) - 1;
                int y = getNumber(textBoxThreeLetter.Text);
                int dx = Convert.ToInt32(textBoxThreeNum2.Text) - 1;
                int dy = getNumber(textBoxThreeLetter2.Text);
                if (playerOneField.setShip(3, x, y, dx, dy))
                {
                    countThreeShips--;
                    if (countThreeShips == 0)
                        buttonThree.Enabled = false;
                    countAllShips--;
                    if (countAllShips == 0)
                        buttonNext.Enabled = true;
                    drawPlayerField(playerOneField);
                    labelThreeCount.Text = countThreeShips.ToString();
                }
                else
                {
                    MessageBox.Show("Нельзя так ставить корабли", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (game.getCurrentPlayer() == Game.PLAYER_TWO)
            {
                int x = Convert.ToInt32(textBoxThreeNum.Text) - 1;
                int y = getNumber(textBoxThreeLetter.Text);
                int dx = Convert.ToInt32(textBoxThreeNum2.Text) - 1;
                int dy = getNumber(textBoxThreeLetter2.Text);
                if (playerTwoField.setShip(3, x, y, dx, dy))
                {
                    countThreeShips--;
                    if (countThreeShips == 0)
                        buttonThree.Enabled = false;
                    countAllShips--;
                    if (countAllShips == 0)
                        buttonNext.Enabled = true;
                    drawPlayerField(playerTwoField);
                    labelThreeCount.Text = countThreeShips.ToString();
                }
                else
                {
                    MessageBox.Show("Нельзя так ставить корабли", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (game.getCurrentPlayer() == Game.PLAYER_ONE)
            {
                int x = Convert.ToInt32(textBoxFourNum.Text) - 1;
                int y = getNumber(textBoxFourLetter.Text);
                int dx = Convert.ToInt32(textBoxFourNum2.Text) - 1;
                int dy = getNumber(textBoxFourLetter2.Text);
                if (playerOneField.setShip(4, x, y, dx, dy))
                {
                    countFourShips--;
                    if (countFourShips == 0)
                        buttonFour.Enabled = false;
                    countAllShips--;
                    if (countAllShips == 0)
                        buttonNext.Enabled = true;
                    drawPlayerField(playerOneField);
                    labelFourCount.Text = countFourShips.ToString();
                }
                else
                {
                    MessageBox.Show("Нельзя так ставить корабли", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (game.getCurrentPlayer() == Game.PLAYER_TWO)
            {
                int x = Convert.ToInt32(textBoxFourNum.Text) - 1;
                int y = getNumber(textBoxFourLetter.Text);
                int dx = Convert.ToInt32(textBoxFourNum2.Text) - 1;
                int dy = getNumber(textBoxFourLetter2.Text);
                if (playerTwoField.setShip(4, x, y, dx, dy))
                {
                    countFourShips--;
                    if (countFourShips == 0)
                        buttonFour.Enabled = false;
                    countAllShips--;
                    if (countAllShips == 0)
                        buttonNext.Enabled = true;
                    drawPlayerField(playerTwoField);
                    labelFourCount.Text = countFourShips.ToString();
                }
                else
                {
                    MessageBox.Show("Нельзя так ставить корабли", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(game.getCurrentPlayer() == Game.PLAYER_ONE)
                game.setCurrentPlayer(Game.PLAYER_TWO);
            else
                game.setCurrentPlayer(Game.PLAYER_ONE);
            if (game.getCurrentPlayer() == Game.PLAYER_TWO)
            {
                buttonNext.Enabled = false;
                buttonNext.Text = "Начать игру";
                buttonOne.Enabled = true;
                buttonTwo.Enabled = true;
                buttonThree.Enabled = true;
                buttonFour.Enabled = true;
                countOneShips = playerTwoField.getCountShips(1);
                countTwoShips = playerTwoField.getCountShips(2);
                countThreeShips = playerTwoField.getCountShips(3);
                countFourShips = playerTwoField.getCountShips(4);
                countAllShips = countOneShips + countTwoShips + countThreeShips + countFourShips;
                labelOneCount.Text = countOneShips.ToString();
                labelTwoCount.Text = countTwoShips.ToString();
                labelThreeCount.Text = countThreeShips.ToString();
                labelFourCount.Text = countFourShips.ToString();
                labelStep.Text = "Ход игрока 2";
                nullTextBox();
            }
            else if(game.getCurrentPlayer() == Game.PLAYER_ONE)
            {
                buttonNext.Enabled = false;
                buttonNext.Text = "Поставить корабли второго игрока";
                buttonOne.Enabled = true;
                buttonTwo.Enabled = true;
                buttonThree.Enabled = true;
                buttonFour.Enabled = true;
                panelSetShips.Visible = false;
                dataGridViewPlayer.Enabled = true;
                dataGridViewOpponent.Enabled = true;
                labelStep.Text = "Ход игрока 1";
            }
        }

        public void nullTextBox()
        {
            textBoxOneLetter.Text = "";
            textBoxOneLetter2.Text = "";
            textBoxTwoLetter.Text = "";
            textBoxTwoLetter2.Text = "";
            textBoxThreeLetter.Text = "";
            textBoxThreeLetter2.Text = "";
            textBoxFourLetter.Text = "";
            textBoxFourLetter2.Text = "";
            textBoxOneNum.Text = "";
            textBoxOneNum2.Text = "";
            textBoxTwoNum.Text = "";
            textBoxTwoNum2.Text = "";
            textBoxThreeNum.Text = "";
            textBoxThreeNum2.Text = "";
            textBoxFourNum.Text = "";
            textBoxFourNum2.Text = "";
        }


    }
}
