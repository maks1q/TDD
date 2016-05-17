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

                panelSetShips.Visible = true;
                //currentField.setShip(2, 1, 1, 2, 1);
                //currentField.setShip(2, 5, 1, 6, 1);
                drawField(playerOneField);
            }
        }

        private void dataGridViewPlayer_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = dataGridViewPlayer.CurrentCell.RowIndex;
            int columnIndex = dataGridViewPlayer.CurrentCell.ColumnIndex;
            int resultShot = playerOneField.doShot(columnIndex, rowIndex) ;
            if (resultShot == Field.SHOT_INJURED)
            {
                dataGridViewPlayer.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.Red;
            }
            else if(resultShot == Field.SHOT_MISSED)
            {
                dataGridViewPlayer.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.Gray;
            }
            else if(resultShot == Field.SHOT_KILLED)
            {
                drawField(playerOneField);
            }
            else if(resultShot == Field.SHOT_WIN)
            {
                drawField(playerOneField);
                MessageBox.Show("Игрок " + game.getCurrentPlayer().ToString() + " победил", "Конец");
            }
        }

        public void drawField(Field field)
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
                }
            }
        }

        public int getNumber(string letter)
        {
            switch(letter)
            {
                case "А": return 0;
                case "Б": return 1;
                case "В": return 2;
                case "Г": return 3;
                case "Д": return 4;
                case "Е": return 5;
                case "Ж": return 6;
                case "З": return 7;
                case "И": return 8;
                case "К": return 9;
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
                    drawField(playerOneField);
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
                    drawField(playerOneField);
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
                    drawField(playerOneField);
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
                    drawField(playerOneField);
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
            game.setCurrentPlayer(Game.PLAYER_TWO);
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
            }
        }
    }
}
