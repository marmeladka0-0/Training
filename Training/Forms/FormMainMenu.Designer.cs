namespace Training
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonCancel = new Button();
            buttonSelect = new Button();
            buttonAddCharacter = new Button();
            buttonDetails = new Button();
            buttonEditComic = new Button();
            buttonDeleteComics = new Button();
            buttonAddComic = new Button();
            textBox3 = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            downloadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            importTestDataToolStripMenuItem = new ToolStripMenuItem();
            contentToolStripMenuItem = new ToolStripMenuItem();
            comicsToolStripMenuItem = new ToolStripMenuItem();
            charactersToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            comboBoxSearchBy = new ComboBox();
            panel2 = new Panel();
            panel5 = new Panel();
            label8 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            buttonSC = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            buttonClear = new Button();
            buttonFilter = new Button();
            comboBoxGenre = new ComboBox();
            comboBoxType = new ComboBox();
            numericUpDownTo = new NumericUpDown();
            numericUpDownFrom = new NumericUpDown();
            groupBox1 = new GroupBox();
            radioButtonNone = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFrom).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonSelect);
            panel1.Controls.Add(buttonAddCharacter);
            panel1.Controls.Add(buttonDetails);
            panel1.Controls.Add(buttonEditComic);
            panel1.Controls.Add(buttonDeleteComics);
            panel1.Controls.Add(buttonAddComic);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 618);
            panel1.TabIndex = 6;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(12, 576);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(180, 30);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(12, 495);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(180, 75);
            buttonSelect.TabIndex = 5;
            buttonSelect.Text = "Select Comic";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // buttonAddCharacter
            // 
            buttonAddCharacter.Cursor = Cursors.Hand;
            buttonAddCharacter.Location = new Point(12, 459);
            buttonAddCharacter.Name = "buttonAddCharacter";
            buttonAddCharacter.Size = new Size(180, 30);
            buttonAddCharacter.TabIndex = 4;
            buttonAddCharacter.Text = "Add Character";
            buttonAddCharacter.UseVisualStyleBackColor = true;
            buttonAddCharacter.Click += buttonAddCharacter_Click;
            // 
            // buttonDetails
            // 
            buttonDetails.Cursor = Cursors.Hand;
            buttonDetails.Location = new Point(12, 417);
            buttonDetails.Name = "buttonDetails";
            buttonDetails.Size = new Size(180, 30);
            buttonDetails.TabIndex = 3;
            buttonDetails.Text = "See More Details";
            buttonDetails.UseVisualStyleBackColor = true;
            buttonDetails.Click += buttonDetails_Click;
            // 
            // buttonEditComic
            // 
            buttonEditComic.Cursor = Cursors.Hand;
            buttonEditComic.Location = new Point(12, 375);
            buttonEditComic.Name = "buttonEditComic";
            buttonEditComic.Size = new Size(180, 30);
            buttonEditComic.TabIndex = 2;
            buttonEditComic.Text = "Edit Selected";
            buttonEditComic.UseVisualStyleBackColor = true;
            buttonEditComic.Click += buttonEditComic_Click;
            // 
            // buttonDeleteComics
            // 
            buttonDeleteComics.Cursor = Cursors.Hand;
            buttonDeleteComics.Location = new Point(12, 333);
            buttonDeleteComics.Name = "buttonDeleteComics";
            buttonDeleteComics.Size = new Size(180, 30);
            buttonDeleteComics.TabIndex = 1;
            buttonDeleteComics.Text = "Delete Selected";
            buttonDeleteComics.UseVisualStyleBackColor = true;
            buttonDeleteComics.Click += buttonDeleteComics_Click;
            // 
            // buttonAddComic
            // 
            buttonAddComic.Cursor = Cursors.Hand;
            buttonAddComic.Location = new Point(12, 291);
            buttonAddComic.Name = "buttonAddComic";
            buttonAddComic.Size = new Size(180, 30);
            buttonAddComic.TabIndex = 0;
            buttonAddComic.Text = "Add New";
            buttonAddComic.UseVisualStyleBackColor = true;
            buttonAddComic.Click += buttonAddComic_Click;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(224, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(580, 27);
            textBox3.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(967, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 28);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(224, 320);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(825, 314);
            dataGridView1.TabIndex = 10;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, contentToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1063, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, downloadToolStripMenuItem, saveToolStripMenuItem, importTestDataToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(203, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // downloadToolStripMenuItem
            // 
            downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            downloadToolStripMenuItem.Size = new Size(203, 26);
            downloadToolStripMenuItem.Text = "Download";
            downloadToolStripMenuItem.Click += downloadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(203, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // importTestDataToolStripMenuItem
            // 
            importTestDataToolStripMenuItem.Name = "importTestDataToolStripMenuItem";
            importTestDataToolStripMenuItem.Size = new Size(203, 26);
            importTestDataToolStripMenuItem.Text = "Import Test Data";
            importTestDataToolStripMenuItem.Click += importTestDataToolStripMenuItem_Click;
            // 
            // contentToolStripMenuItem
            // 
            contentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { comicsToolStripMenuItem, charactersToolStripMenuItem });
            contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            contentToolStripMenuItem.Size = new Size(75, 24);
            contentToolStripMenuItem.Text = "Content";
            // 
            // comicsToolStripMenuItem
            // 
            comicsToolStripMenuItem.Name = "comicsToolStripMenuItem";
            comicsToolStripMenuItem.Size = new Size(161, 26);
            comicsToolStripMenuItem.Text = "Comics";
            comicsToolStripMenuItem.Click += comicsToolStripMenuItem_Click;
            // 
            // charactersToolStripMenuItem
            // 
            charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            charactersToolStripMenuItem.Size = new Size(161, 26);
            charactersToolStripMenuItem.Text = "Characters";
            charactersToolStripMenuItem.Click += charactersToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // comboBoxSearchBy
            // 
            comboBoxSearchBy.Cursor = Cursors.Hand;
            comboBoxSearchBy.DisplayMember = "(none)";
            comboBoxSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchBy.FormattingEnabled = true;
            comboBoxSearchBy.Items.AddRange(new object[] { "Title", "Author" });
            comboBoxSearchBy.Location = new Point(810, 36);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(151, 28);
            comboBoxSearchBy.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(comboBoxGenre);
            panel2.Controls.Add(comboBoxType);
            panel2.Controls.Add(numericUpDownTo);
            panel2.Controls.Add(numericUpDownFrom);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(411, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 215);
            panel2.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(275, 49);
            panel5.Name = "panel5";
            panel5.Size = new Size(138, 62);
            panel5.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1, 4);
            label8.Name = "label8";
            label8.Size = new Size(18, 20);
            label8.TabIndex = 15;
            label8.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1, 38);
            label7.Name = "label7";
            label7.Size = new Size(18, 20);
            label7.TabIndex = 14;
            label7.Text = "...";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(buttonSC);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(125, 162);
            panel3.TabIndex = 8;
            // 
            // buttonSC
            // 
            buttonSC.Location = new Point(67, 122);
            buttonSC.Name = "buttonSC";
            buttonSC.Size = new Size(46, 29);
            buttonSC.TabIndex = 4;
            buttonSC.Text = "Add";
            buttonSC.UseVisualStyleBackColor = true;
            buttonSC.Click += buttonSC_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 126);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Genre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Released Year";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(buttonClear);
            panel4.Controls.Add(buttonFilter);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 162);
            panel4.Name = "panel4";
            panel4.Size = new Size(428, 53);
            panel4.TabIndex = 4;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(62, 12);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(141, 27);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "Clear Filter";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(230, 12);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(141, 27);
            buttonFilter.TabIndex = 0;
            buttonFilter.Text = "Filter";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += button1_Click;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Items.AddRange(new object[] { "Action", "Adventure", "Comedy", "Crime", "Drama", "Historical", "Horror", "Mystery", "Romance", "Thriller", "Fantasy" });
            comboBoxGenre.Location = new Point(137, 84);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(133, 28);
            comboBoxGenre.TabIndex = 7;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Manga", "Manhwa", "Webtoon", "Comic book", "Manhua" });
            comboBoxType.Location = new Point(137, 50);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(133, 28);
            comboBoxType.TabIndex = 6;
            // 
            // numericUpDownTo
            // 
            numericUpDownTo.Location = new Point(305, 12);
            numericUpDownTo.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericUpDownTo.Name = "numericUpDownTo";
            numericUpDownTo.Size = new Size(84, 27);
            numericUpDownTo.TabIndex = 5;
            // 
            // numericUpDownFrom
            // 
            numericUpDownFrom.Location = new Point(184, 12);
            numericUpDownFrom.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericUpDownFrom.Name = "numericUpDownFrom";
            numericUpDownFrom.Size = new Size(84, 27);
            numericUpDownFrom.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonNone);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(137, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 46);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // radioButtonNone
            // 
            radioButtonNone.AutoSize = true;
            radioButtonNone.Location = new Point(255, -14);
            radioButtonNone.Name = "radioButtonNone";
            radioButtonNone.Size = new Size(33, 24);
            radioButtonNone.TabIndex = 3;
            radioButtonNone.TabStop = true;
            radioButtonNone.Text = ".";
            radioButtonNone.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(204, 16);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(76, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Paused";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(110, 16);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(88, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ongoing";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 16);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Completed";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 12);
            label6.Name = "label6";
            label6.Size = new Size(23, 20);
            label6.TabIndex = 2;
            label6.Text = "to";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 12);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 1;
            label5.Text = "from";
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 646);
            Controls.Add(panel2);
            Controls.Add(comboBoxSearchBy);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(textBox3);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComicCatalog";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFrom).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox textBox3;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem downloadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem contentToolStripMenuItem;
        private ToolStripMenuItem comicsToolStripMenuItem;
        private ToolStripMenuItem charactersToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ComboBox comboBoxSearchBy;
        private Button buttonAddComic;
        private Button buttonDeleteComics;
        private Button buttonEditComic;
        private Button buttonAddCharacter;
        private Button buttonDetails;
        private Panel panel2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDownFrom;
        private NumericUpDown numericUpDownTo;
        private ComboBox comboBoxType;
        private ComboBox comboBoxGenre;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Button buttonFilter;
        private ToolStripMenuItem importTestDataToolStripMenuItem;
        private Button buttonClear;
        private RadioButton radioButtonNone;
        private Button buttonSelect;
        private Button buttonSC;
        private Button buttonCancel;
        private Label label7;
        private Label label8;
        private Panel panel5;
    }
}
