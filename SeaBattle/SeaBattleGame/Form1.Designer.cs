namespace SeaBattleGame
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewPlayer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelStep = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.panelSetShips = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.textBoxFourNum = new System.Windows.Forms.TextBox();
            this.textBoxThreeNum = new System.Windows.Forms.TextBox();
            this.textBoxTwoNum = new System.Windows.Forms.TextBox();
            this.textBoxOneNum = new System.Windows.Forms.TextBox();
            this.textBoxFourLetter = new System.Windows.Forms.TextBox();
            this.textBoxThreeLetter = new System.Windows.Forms.TextBox();
            this.textBoxTwoLetter = new System.Windows.Forms.TextBox();
            this.textBoxOneLetter = new System.Windows.Forms.TextBox();
            this.labelFourCount = new System.Windows.Forms.Label();
            this.labelFour = new System.Windows.Forms.Label();
            this.labelThreeCount = new System.Windows.Forms.Label();
            this.labelThree = new System.Windows.Forms.Label();
            this.labelTwoCount = new System.Windows.Forms.Label();
            this.labelTwo = new System.Windows.Forms.Label();
            this.labelOneCount = new System.Windows.Forms.Label();
            this.labelOne = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelShips = new System.Windows.Forms.Label();
            this.dataGridViewOpponent = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOneLetter2 = new System.Windows.Forms.TextBox();
            this.textBoxTwoLetter2 = new System.Windows.Forms.TextBox();
            this.textBoxThreeLetter2 = new System.Windows.Forms.TextBox();
            this.textBoxFourLetter2 = new System.Windows.Forms.TextBox();
            this.textBoxOneNum2 = new System.Windows.Forms.TextBox();
            this.textBoxTwoNum2 = new System.Windows.Forms.TextBox();
            this.textBoxThreeNum2 = new System.Windows.Forms.TextBox();
            this.textBoxFourNum2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).BeginInit();
            this.panelSetShips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpponent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlayer
            // 
            this.dataGridViewPlayer.AllowUserToAddRows = false;
            this.dataGridViewPlayer.AllowUserToDeleteRows = false;
            this.dataGridViewPlayer.AllowUserToResizeRows = false;
            this.dataGridViewPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridViewPlayer.Enabled = false;
            this.dataGridViewPlayer.Location = new System.Drawing.Point(26, 72);
            this.dataGridViewPlayer.MultiSelect = false;
            this.dataGridViewPlayer.Name = "dataGridViewPlayer";
            this.dataGridViewPlayer.RowHeadersWidth = 50;
            this.dataGridViewPlayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewPlayer.Size = new System.Drawing.Size(357, 243);
            this.dataGridViewPlayer.TabIndex = 0;
            this.dataGridViewPlayer.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPlayer_CellMouseUp);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 10F;
            this.Column1.HeaderText = "1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 10F;
            this.Column2.HeaderText = "2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 10F;
            this.Column3.HeaderText = "3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 10F;
            this.Column4.HeaderText = "4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 10F;
            this.Column5.HeaderText = "5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.FillWeight = 10F;
            this.Column6.HeaderText = "6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.FillWeight = 10F;
            this.Column7.HeaderText = "7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.FillWeight = 10F;
            this.Column8.HeaderText = "8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.FillWeight = 10F;
            this.Column9.HeaderText = "9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.FillWeight = 10F;
            this.Column10.HeaderText = "10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStep.Location = new System.Drawing.Point(352, 15);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(120, 20);
            this.labelStep.TabIndex = 1;
            this.labelStep.Text = "Ход игрока 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(130, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поле игрока";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(527, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Поле противника";
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewGame.Location = new System.Drawing.Point(26, 7);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(133, 28);
            this.buttonNewGame.TabIndex = 2;
            this.buttonNewGame.Text = "Новая игра";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // panelSetShips
            // 
            this.panelSetShips.Controls.Add(this.buttonNext);
            this.panelSetShips.Controls.Add(this.buttonFour);
            this.panelSetShips.Controls.Add(this.buttonThree);
            this.panelSetShips.Controls.Add(this.buttonTwo);
            this.panelSetShips.Controls.Add(this.buttonOne);
            this.panelSetShips.Controls.Add(this.textBoxFourNum2);
            this.panelSetShips.Controls.Add(this.textBoxFourNum);
            this.panelSetShips.Controls.Add(this.textBoxThreeNum2);
            this.panelSetShips.Controls.Add(this.textBoxThreeNum);
            this.panelSetShips.Controls.Add(this.textBoxTwoNum2);
            this.panelSetShips.Controls.Add(this.textBoxTwoNum);
            this.panelSetShips.Controls.Add(this.textBoxOneNum2);
            this.panelSetShips.Controls.Add(this.textBoxOneNum);
            this.panelSetShips.Controls.Add(this.textBoxFourLetter2);
            this.panelSetShips.Controls.Add(this.textBoxFourLetter);
            this.panelSetShips.Controls.Add(this.textBoxThreeLetter2);
            this.panelSetShips.Controls.Add(this.textBoxThreeLetter);
            this.panelSetShips.Controls.Add(this.textBoxTwoLetter2);
            this.panelSetShips.Controls.Add(this.textBoxTwoLetter);
            this.panelSetShips.Controls.Add(this.textBoxOneLetter2);
            this.panelSetShips.Controls.Add(this.textBoxOneLetter);
            this.panelSetShips.Controls.Add(this.labelFourCount);
            this.panelSetShips.Controls.Add(this.labelFour);
            this.panelSetShips.Controls.Add(this.labelThreeCount);
            this.panelSetShips.Controls.Add(this.labelThree);
            this.panelSetShips.Controls.Add(this.labelTwoCount);
            this.panelSetShips.Controls.Add(this.labelTwo);
            this.panelSetShips.Controls.Add(this.labelOneCount);
            this.panelSetShips.Controls.Add(this.labelOne);
            this.panelSetShips.Controls.Add(this.label6);
            this.panelSetShips.Controls.Add(this.label4);
            this.panelSetShips.Controls.Add(this.label5);
            this.panelSetShips.Controls.Add(this.label1);
            this.panelSetShips.Controls.Add(this.label8);
            this.panelSetShips.Controls.Add(this.label7);
            this.panelSetShips.Controls.Add(this.labelShips);
            this.panelSetShips.Location = new System.Drawing.Point(26, 321);
            this.panelSetShips.Name = "panelSetShips";
            this.panelSetShips.Size = new System.Drawing.Size(756, 191);
            this.panelSetShips.TabIndex = 3;
            this.panelSetShips.Visible = false;
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(634, 89);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(119, 58);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Поставить корабли второго игрока";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Location = new System.Drawing.Point(492, 156);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(100, 23);
            this.buttonFour.TabIndex = 3;
            this.buttonFour.Text = "Добавить";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Location = new System.Drawing.Point(492, 124);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(100, 23);
            this.buttonThree.TabIndex = 3;
            this.buttonThree.Text = "Добавить";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Location = new System.Drawing.Point(492, 93);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(100, 23);
            this.buttonTwo.TabIndex = 3;
            this.buttonTwo.Text = "Добавить";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(492, 61);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(100, 23);
            this.buttonOne.TabIndex = 3;
            this.buttonOne.Text = "Добавить";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // textBoxFourNum
            // 
            this.textBoxFourNum.Location = new System.Drawing.Point(264, 158);
            this.textBoxFourNum.Name = "textBoxFourNum";
            this.textBoxFourNum.Size = new System.Drawing.Size(31, 20);
            this.textBoxFourNum.TabIndex = 2;
            // 
            // textBoxThreeNum
            // 
            this.textBoxThreeNum.Location = new System.Drawing.Point(264, 126);
            this.textBoxThreeNum.Name = "textBoxThreeNum";
            this.textBoxThreeNum.Size = new System.Drawing.Size(31, 20);
            this.textBoxThreeNum.TabIndex = 2;
            // 
            // textBoxTwoNum
            // 
            this.textBoxTwoNum.Location = new System.Drawing.Point(264, 95);
            this.textBoxTwoNum.Name = "textBoxTwoNum";
            this.textBoxTwoNum.Size = new System.Drawing.Size(31, 20);
            this.textBoxTwoNum.TabIndex = 2;
            // 
            // textBoxOneNum
            // 
            this.textBoxOneNum.Location = new System.Drawing.Point(264, 63);
            this.textBoxOneNum.Name = "textBoxOneNum";
            this.textBoxOneNum.Size = new System.Drawing.Size(31, 20);
            this.textBoxOneNum.TabIndex = 2;
            // 
            // textBoxFourLetter
            // 
            this.textBoxFourLetter.Location = new System.Drawing.Point(197, 158);
            this.textBoxFourLetter.Name = "textBoxFourLetter";
            this.textBoxFourLetter.Size = new System.Drawing.Size(31, 20);
            this.textBoxFourLetter.TabIndex = 2;
            // 
            // textBoxThreeLetter
            // 
            this.textBoxThreeLetter.Location = new System.Drawing.Point(197, 126);
            this.textBoxThreeLetter.Name = "textBoxThreeLetter";
            this.textBoxThreeLetter.Size = new System.Drawing.Size(31, 20);
            this.textBoxThreeLetter.TabIndex = 2;
            // 
            // textBoxTwoLetter
            // 
            this.textBoxTwoLetter.Location = new System.Drawing.Point(197, 95);
            this.textBoxTwoLetter.Name = "textBoxTwoLetter";
            this.textBoxTwoLetter.Size = new System.Drawing.Size(31, 20);
            this.textBoxTwoLetter.TabIndex = 2;
            // 
            // textBoxOneLetter
            // 
            this.textBoxOneLetter.Location = new System.Drawing.Point(197, 63);
            this.textBoxOneLetter.Name = "textBoxOneLetter";
            this.textBoxOneLetter.Size = new System.Drawing.Size(31, 20);
            this.textBoxOneLetter.TabIndex = 2;
            // 
            // labelFourCount
            // 
            this.labelFourCount.AutoSize = true;
            this.labelFourCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFourCount.Location = new System.Drawing.Point(139, 156);
            this.labelFourCount.Name = "labelFourCount";
            this.labelFourCount.Size = new System.Drawing.Size(24, 20);
            this.labelFourCount.TabIndex = 1;
            this.labelFourCount.Text = "...";
            // 
            // labelFour
            // 
            this.labelFour.AutoSize = true;
            this.labelFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFour.Location = new System.Drawing.Point(16, 156);
            this.labelFour.Name = "labelFour";
            this.labelFour.Size = new System.Drawing.Size(114, 20);
            this.labelFour.TabIndex = 1;
            this.labelFour.Text = "4-хпалубные";
            // 
            // labelThreeCount
            // 
            this.labelThreeCount.AutoSize = true;
            this.labelThreeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThreeCount.Location = new System.Drawing.Point(139, 124);
            this.labelThreeCount.Name = "labelThreeCount";
            this.labelThreeCount.Size = new System.Drawing.Size(24, 20);
            this.labelThreeCount.TabIndex = 1;
            this.labelThreeCount.Text = "...";
            // 
            // labelThree
            // 
            this.labelThree.AutoSize = true;
            this.labelThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThree.Location = new System.Drawing.Point(16, 124);
            this.labelThree.Name = "labelThree";
            this.labelThree.Size = new System.Drawing.Size(106, 20);
            this.labelThree.TabIndex = 1;
            this.labelThree.Text = "3-палубные";
            // 
            // labelTwoCount
            // 
            this.labelTwoCount.AutoSize = true;
            this.labelTwoCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTwoCount.Location = new System.Drawing.Point(139, 93);
            this.labelTwoCount.Name = "labelTwoCount";
            this.labelTwoCount.Size = new System.Drawing.Size(24, 20);
            this.labelTwoCount.TabIndex = 1;
            this.labelTwoCount.Text = "...";
            // 
            // labelTwo
            // 
            this.labelTwo.AutoSize = true;
            this.labelTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTwo.Location = new System.Drawing.Point(16, 93);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(106, 20);
            this.labelTwo.TabIndex = 1;
            this.labelTwo.Text = "2-палубные";
            // 
            // labelOneCount
            // 
            this.labelOneCount.AutoSize = true;
            this.labelOneCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOneCount.Location = new System.Drawing.Point(139, 61);
            this.labelOneCount.Name = "labelOneCount";
            this.labelOneCount.Size = new System.Drawing.Size(24, 20);
            this.labelOneCount.TabIndex = 1;
            this.labelOneCount.Text = "...";
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOne.Location = new System.Drawing.Point(16, 61);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(106, 20);
            this.labelOne.TabIndex = 1;
            this.labelOne.Text = "1-палубные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(247, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Цифра";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(181, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Буква";
            // 
            // labelShips
            // 
            this.labelShips.AutoSize = true;
            this.labelShips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShips.Location = new System.Drawing.Point(3, 3);
            this.labelShips.Name = "labelShips";
            this.labelShips.Size = new System.Drawing.Size(158, 20);
            this.labelShips.TabIndex = 1;
            this.labelShips.Text = "Корабли игрока 1";
            // 
            // dataGridViewOpponent
            // 
            this.dataGridViewOpponent.AllowUserToAddRows = false;
            this.dataGridViewOpponent.AllowUserToDeleteRows = false;
            this.dataGridViewOpponent.AllowUserToResizeRows = false;
            this.dataGridViewOpponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOpponent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridViewOpponent.Enabled = false;
            this.dataGridViewOpponent.Location = new System.Drawing.Point(425, 72);
            this.dataGridViewOpponent.MultiSelect = false;
            this.dataGridViewOpponent.Name = "dataGridViewOpponent";
            this.dataGridViewOpponent.RowHeadersWidth = 50;
            this.dataGridViewOpponent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewOpponent.Size = new System.Drawing.Size(357, 243);
            this.dataGridViewOpponent.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 10F;
            this.dataGridViewTextBoxColumn1.HeaderText = "1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 10F;
            this.dataGridViewTextBoxColumn2.HeaderText = "2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 10F;
            this.dataGridViewTextBoxColumn3.HeaderText = "3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 10F;
            this.dataGridViewTextBoxColumn4.HeaderText = "4";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.FillWeight = 10F;
            this.dataGridViewTextBoxColumn5.HeaderText = "5";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.FillWeight = 10F;
            this.dataGridViewTextBoxColumn6.HeaderText = "6";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.FillWeight = 10F;
            this.dataGridViewTextBoxColumn7.HeaderText = "7";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.FillWeight = 10F;
            this.dataGridViewTextBoxColumn8.HeaderText = "8";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.FillWeight = 10F;
            this.dataGridViewTextBoxColumn9.HeaderText = "9";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.FillWeight = 10F;
            this.dataGridViewTextBoxColumn10.HeaderText = "10";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(345, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Буква";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(411, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Цифра";
            // 
            // textBoxOneLetter2
            // 
            this.textBoxOneLetter2.Location = new System.Drawing.Point(361, 63);
            this.textBoxOneLetter2.Name = "textBoxOneLetter2";
            this.textBoxOneLetter2.Size = new System.Drawing.Size(31, 20);
            this.textBoxOneLetter2.TabIndex = 2;
            // 
            // textBoxTwoLetter2
            // 
            this.textBoxTwoLetter2.Location = new System.Drawing.Point(361, 95);
            this.textBoxTwoLetter2.Name = "textBoxTwoLetter2";
            this.textBoxTwoLetter2.Size = new System.Drawing.Size(31, 20);
            this.textBoxTwoLetter2.TabIndex = 2;
            // 
            // textBoxThreeLetter2
            // 
            this.textBoxThreeLetter2.Location = new System.Drawing.Point(361, 126);
            this.textBoxThreeLetter2.Name = "textBoxThreeLetter2";
            this.textBoxThreeLetter2.Size = new System.Drawing.Size(31, 20);
            this.textBoxThreeLetter2.TabIndex = 2;
            // 
            // textBoxFourLetter2
            // 
            this.textBoxFourLetter2.Location = new System.Drawing.Point(361, 158);
            this.textBoxFourLetter2.Name = "textBoxFourLetter2";
            this.textBoxFourLetter2.Size = new System.Drawing.Size(31, 20);
            this.textBoxFourLetter2.TabIndex = 2;
            // 
            // textBoxOneNum2
            // 
            this.textBoxOneNum2.Location = new System.Drawing.Point(428, 63);
            this.textBoxOneNum2.Name = "textBoxOneNum2";
            this.textBoxOneNum2.Size = new System.Drawing.Size(31, 20);
            this.textBoxOneNum2.TabIndex = 2;
            // 
            // textBoxTwoNum2
            // 
            this.textBoxTwoNum2.Location = new System.Drawing.Point(428, 95);
            this.textBoxTwoNum2.Name = "textBoxTwoNum2";
            this.textBoxTwoNum2.Size = new System.Drawing.Size(31, 20);
            this.textBoxTwoNum2.TabIndex = 2;
            // 
            // textBoxThreeNum2
            // 
            this.textBoxThreeNum2.Location = new System.Drawing.Point(428, 126);
            this.textBoxThreeNum2.Name = "textBoxThreeNum2";
            this.textBoxThreeNum2.Size = new System.Drawing.Size(31, 20);
            this.textBoxThreeNum2.TabIndex = 2;
            // 
            // textBoxFourNum2
            // 
            this.textBoxFourNum2.Location = new System.Drawing.Point(428, 158);
            this.textBoxFourNum2.Name = "textBoxFourNum2";
            this.textBoxFourNum2.Size = new System.Drawing.Size(31, 20);
            this.textBoxFourNum2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(167, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Начальная клетка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(335, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Конечная клетка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 518);
            this.Controls.Add(this.panelSetShips);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelStep);
            this.Controls.Add(this.dataGridViewOpponent);
            this.Controls.Add(this.dataGridViewPlayer);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Морской бой";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).EndInit();
            this.panelSetShips.ResumeLayout(false);
            this.panelSetShips.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Panel panelSetShips;
        private System.Windows.Forms.DataGridView dataGridViewOpponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label labelFour;
        private System.Windows.Forms.Label labelThree;
        private System.Windows.Forms.Label labelTwo;
        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.Label labelShips;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.TextBox textBoxFourNum;
        private System.Windows.Forms.TextBox textBoxThreeNum;
        private System.Windows.Forms.TextBox textBoxTwoNum;
        private System.Windows.Forms.TextBox textBoxOneNum;
        private System.Windows.Forms.TextBox textBoxFourLetter;
        private System.Windows.Forms.TextBox textBoxThreeLetter;
        private System.Windows.Forms.TextBox textBoxTwoLetter;
        private System.Windows.Forms.TextBox textBoxOneLetter;
        private System.Windows.Forms.Label labelFourCount;
        private System.Windows.Forms.Label labelThreeCount;
        private System.Windows.Forms.Label labelTwoCount;
        private System.Windows.Forms.Label labelOneCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxFourNum2;
        private System.Windows.Forms.TextBox textBoxThreeNum2;
        private System.Windows.Forms.TextBox textBoxTwoNum2;
        private System.Windows.Forms.TextBox textBoxOneNum2;
        private System.Windows.Forms.TextBox textBoxFourLetter2;
        private System.Windows.Forms.TextBox textBoxThreeLetter2;
        private System.Windows.Forms.TextBox textBoxTwoLetter2;
        private System.Windows.Forms.TextBox textBoxOneLetter2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

