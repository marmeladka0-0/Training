namespace MultiCOloredModernUI
{
    partial class FormAddComic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonCancelAddComic = new Button();
            buttonSaveComic = new Button();
            panel2 = new Panel();
            labelStatus = new Label();
            labelGenre = new Label();
            labelType = new Label();
            labelReleaseYear = new Label();
            labelAuthor = new Label();
            labelTitle = new Label();
            textBoxTitle = new TextBox();
            textBoxAuthor = new TextBox();
            numericUpDownYear = new NumericUpDown();
            comboBoxType = new ComboBox();
            comboBoxGenre = new ComboBox();
            comboBoxStatus = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(buttonCancelAddComic);
            panel1.Controls.Add(buttonSaveComic);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 231);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 86);
            panel1.TabIndex = 0;
            // 
            // buttonCancelAddComic
            // 
            buttonCancelAddComic.Cursor = Cursors.Hand;
            buttonCancelAddComic.Location = new Point(306, 30);
            buttonCancelAddComic.Name = "buttonCancelAddComic";
            buttonCancelAddComic.Size = new Size(146, 34);
            buttonCancelAddComic.TabIndex = 1;
            buttonCancelAddComic.Text = "Cancel";
            buttonCancelAddComic.UseVisualStyleBackColor = true;
            buttonCancelAddComic.Click += buttonCancelAddComic_Click;
            // 
            // buttonSaveComic
            // 
            buttonSaveComic.Cursor = Cursors.Hand;
            buttonSaveComic.Location = new Point(33, 30);
            buttonSaveComic.Name = "buttonSaveComic";
            buttonSaveComic.Size = new Size(146, 35);
            buttonSaveComic.TabIndex = 0;
            buttonSaveComic.Text = "Save";
            buttonSaveComic.UseVisualStyleBackColor = true;
            buttonSaveComic.Click += buttonSaveComic_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(labelStatus);
            panel2.Controls.Add(labelGenre);
            panel2.Controls.Add(labelType);
            panel2.Controls.Add(labelReleaseYear);
            panel2.Controls.Add(labelAuthor);
            panel2.Controls.Add(labelTitle);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 231);
            panel2.TabIndex = 1;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.ImageAlign = ContentAlignment.TopLeft;
            labelStatus.Location = new Point(12, 192);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(49, 20);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "Status";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.ImageAlign = ContentAlignment.TopLeft;
            labelGenre.Location = new Point(12, 156);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(48, 20);
            labelGenre.TabIndex = 4;
            labelGenre.Text = "Genre";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.ImageAlign = ContentAlignment.TopLeft;
            labelType.Location = new Point(12, 120);
            labelType.Name = "labelType";
            labelType.Size = new Size(40, 20);
            labelType.TabIndex = 3;
            labelType.Text = "Type";
            // 
            // labelReleaseYear
            // 
            labelReleaseYear.AutoSize = true;
            labelReleaseYear.ImageAlign = ContentAlignment.TopLeft;
            labelReleaseYear.Location = new Point(12, 84);
            labelReleaseYear.Name = "labelReleaseYear";
            labelReleaseYear.Size = new Size(92, 20);
            labelReleaseYear.TabIndex = 2;
            labelReleaseYear.Text = "Release Year";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.ImageAlign = ContentAlignment.TopLeft;
            labelAuthor.Location = new Point(12, 48);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(54, 20);
            labelAuthor.TabIndex = 1;
            labelAuthor.Text = "Author";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.ImageAlign = ContentAlignment.TopLeft;
            labelTitle.Location = new Point(12, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.RightToLeft = RightToLeft.No;
            labelTitle.Size = new Size(38, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(156, 12);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(312, 27);
            textBoxTitle.TabIndex = 2;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(156, 48);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(312, 27);
            textBoxAuthor.TabIndex = 3;
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Location = new Point(156, 84);
            numericUpDownYear.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(312, 27);
            numericUpDownYear.TabIndex = 4;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Manga", "Manhwa", "Webtoon", "Comic book", "Manhua" });
            comboBoxType.Location = new Point(156, 120);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(312, 28);
            comboBoxType.TabIndex = 5;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Items.AddRange(new object[] { "Action", "Adventure", "Comedy", "Crime", "Drama", "Historical", "Horror", "Mystery", "Romance", "Thriller", "Fantasy" });
            comboBoxGenre.Location = new Point(156, 156);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(312, 28);
            comboBoxGenre.TabIndex = 6;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Completed", "Ongoing", "Paused" });
            comboBoxStatus.Location = new Point(156, 192);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(312, 28);
            comboBoxStatus.TabIndex = 7;
            // 
            // FormAddComic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 317);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxGenre);
            Controls.Add(comboBoxType);
            Controls.Add(numericUpDownYear);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxTitle);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAddComic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddComic";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonSaveComic;
        private Button buttonCancelAddComic;
        private Panel panel2;
        private Label labelTitle;
        private Label labelAuthor;
        private Label labelReleaseYear;
        private Label labelStatus;
        private Label labelGenre;
        private Label labelType;
        private TextBox textBoxTitle;
        private TextBox textBoxAuthor;
        private NumericUpDown numericUpDownYear;
        private ComboBox comboBoxType;
        private ComboBox comboBoxGenre;
        private ComboBox comboBoxStatus;
    }
}