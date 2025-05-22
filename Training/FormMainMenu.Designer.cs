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
            buttonAddComic = new Button();
            textBox3 = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            downloadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            contentToolStripMenuItem = new ToolStripMenuItem();
            comicsToolStripMenuItem = new ToolStripMenuItem();
            charactersToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            comboBoxSearchBy = new ComboBox();
            buttonDeleteComics = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(buttonDeleteComics);
            panel1.Controls.Add(buttonAddComic);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 618);
            panel1.TabIndex = 6;
            // 
            // buttonAddComic
            // 
            buttonAddComic.Cursor = Cursors.Hand;
            buttonAddComic.Location = new Point(12, 48);
            buttonAddComic.Name = "buttonAddComic";
            buttonAddComic.Size = new Size(179, 29);
            buttonAddComic.TabIndex = 0;
            buttonAddComic.Text = "Add new comic";
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
            dataGridView1.Location = new Point(224, 389);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(825, 245);
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, downloadToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(161, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // downloadToolStripMenuItem
            // 
            downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            downloadToolStripMenuItem.Size = new Size(161, 26);
            downloadToolStripMenuItem.Text = "Download";
            downloadToolStripMenuItem.Click += downloadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(161, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
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
            // 
            // comboBoxSearchBy
            // 
            comboBoxSearchBy.Cursor = Cursors.Hand;
            comboBoxSearchBy.DisplayMember = "(none)";
            comboBoxSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchBy.FormattingEnabled = true;
            comboBoxSearchBy.Items.AddRange(new object[] { "Title", "Author", "ReleaseYear", "Type", "Genre", "Status" });
            comboBoxSearchBy.Location = new Point(810, 36);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(151, 28);
            comboBoxSearchBy.TabIndex = 12;
            // 
            // buttonDeleteComics
            // 
            buttonDeleteComics.Location = new Point(16, 95);
            buttonDeleteComics.Name = "buttonDeleteComics";
            buttonDeleteComics.Size = new Size(177, 31);
            buttonDeleteComics.TabIndex = 1;
            buttonDeleteComics.Text = "Delete Selected Comic";
            buttonDeleteComics.UseVisualStyleBackColor = true;
            buttonDeleteComics.Click += buttonDeleteComics_Click;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 646);
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
    }
}
