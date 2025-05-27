namespace MultiCOloredModernUI.Forms
{
    partial class FormComicInfo
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
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridViewCharacters = new DataGridView();
            labelComicId = new Label();
            labelTitle = new Label();
            labelAuthor = new Label();
            labelYear = new Label();
            labelType = new Label();
            labelGenre = new Label();
            labelStatus = new Label();
            pictureBoxCover = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCharacters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 437);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 86);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 437);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 264);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 7;
            label8.Text = "Characters";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 228);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 6;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 192);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 5;
            label6.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 156);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 4;
            label5.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 120);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "ReleaseYear";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "ComicID";
            // 
            // dataGridViewCharacters
            // 
            dataGridViewCharacters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCharacters.Location = new Point(150, 264);
            dataGridViewCharacters.Name = "dataGridViewCharacters";
            dataGridViewCharacters.RowHeadersWidth = 51;
            dataGridViewCharacters.Size = new Size(643, 167);
            dataGridViewCharacters.TabIndex = 2;
            // 
            // labelComicId
            // 
            labelComicId.AutoSize = true;
            labelComicId.Location = new Point(156, 12);
            labelComicId.Name = "labelComicId";
            labelComicId.Size = new Size(50, 20);
            labelComicId.TabIndex = 3;
            labelComicId.Text = "label9";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(156, 48);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(50, 20);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "label9";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(156, 84);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(50, 20);
            labelAuthor.TabIndex = 5;
            labelAuthor.Text = "label9";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(156, 120);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(50, 20);
            labelYear.TabIndex = 6;
            labelYear.Text = "label9";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(156, 156);
            labelType.Name = "labelType";
            labelType.Size = new Size(50, 20);
            labelType.TabIndex = 7;
            labelType.Text = "label9";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(156, 192);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(50, 20);
            labelGenre.TabIndex = 8;
            labelGenre.Text = "label9";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(156, 228);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(50, 20);
            labelStatus.TabIndex = 9;
            labelStatus.Text = "label9";
            // 
            // pictureBoxCover
            // 
            pictureBoxCover.Location = new Point(587, 12);
            pictureBoxCover.Name = "pictureBoxCover";
            pictureBoxCover.Size = new Size(206, 236);
            pictureBoxCover.TabIndex = 10;
            pictureBoxCover.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(316, 29);
            button1.Name = "button1";
            button1.Size = new Size(170, 29);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormComicInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 523);
            Controls.Add(pictureBoxCover);
            Controls.Add(labelStatus);
            Controls.Add(labelGenre);
            Controls.Add(labelType);
            Controls.Add(labelYear);
            Controls.Add(labelAuthor);
            Controls.Add(labelTitle);
            Controls.Add(labelComicId);
            Controls.Add(dataGridViewCharacters);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormComicInfo";
            Text = "ComicInfo";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCharacters).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private DataGridView dataGridViewCharacters;
        private Label labelComicId;
        private Label labelTitle;
        private Label labelAuthor;
        private Label labelYear;
        private Label labelType;
        private Label labelGenre;
        private Label labelStatus;
        private PictureBox pictureBoxCover;
        private Button button1;
    }
}