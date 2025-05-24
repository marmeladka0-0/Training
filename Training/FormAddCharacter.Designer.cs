namespace MultiCOloredModernUI
{
    partial class FormAddCharacter
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
            checkBoxCharactersOpen = new CheckBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            panel2 = new Panel();
            label1 = new Label();
            labelGender = new Label();
            labelAge = new Label();
            labelDescription = new Label();
            labelName = new Label();
            labelComic = new Label();
            labelComicTitle = new Label();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            numericUpDownAge = new NumericUpDown();
            comboBoxGender = new ComboBox();
            comboBoxStatus = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(checkBoxCharactersOpen);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 237);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 102);
            panel1.TabIndex = 0;
            // 
            // checkBoxCharactersOpen
            // 
            checkBoxCharactersOpen.AutoSize = true;
            checkBoxCharactersOpen.Cursor = Cursors.Hand;
            checkBoxCharactersOpen.Location = new Point(40, 59);
            checkBoxCharactersOpen.Name = "checkBoxCharactersOpen";
            checkBoxCharactersOpen.Size = new Size(365, 24);
            checkBoxCharactersOpen.TabIndex = 2;
            checkBoxCharactersOpen.Text = "I want to see the table with characters, after saving";
            checkBoxCharactersOpen.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.Location = new Point(263, 25);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(157, 29);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.Location = new Point(40, 24);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(157, 29);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(labelGender);
            panel2.Controls.Add(labelAge);
            panel2.Controls.Add(labelDescription);
            panel2.Controls.Add(labelName);
            panel2.Controls.Add(labelComic);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 237);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 192);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Status";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(12, 156);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(57, 20);
            labelGender.TabIndex = 4;
            labelGender.Text = "Gender";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(12, 120);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(36, 20);
            labelAge.TabIndex = 3;
            labelAge.Text = "Age";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(12, 84);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 20);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "Description";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 48);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labelComic
            // 
            labelComic.AutoSize = true;
            labelComic.Location = new Point(12, 12);
            labelComic.Name = "labelComic";
            labelComic.Size = new Size(51, 20);
            labelComic.TabIndex = 0;
            labelComic.Text = "Comic";
            // 
            // labelComicTitle
            // 
            labelComicTitle.AutoSize = true;
            labelComicTitle.Location = new Point(156, 12);
            labelComicTitle.Name = "labelComicTitle";
            labelComicTitle.Size = new Size(91, 20);
            labelComicTitle.TabIndex = 2;
            labelComicTitle.Text = "ComicName";
            // 
            // textBoxName
            // 
            textBoxName.Cursor = Cursors.IBeam;
            textBoxName.Location = new Point(156, 48);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(312, 27);
            textBoxName.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Cursor = Cursors.IBeam;
            textBoxDescription.Location = new Point(156, 84);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(312, 27);
            textBoxDescription.TabIndex = 4;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(156, 120);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(312, 27);
            numericUpDownAge.TabIndex = 5;
            // 
            // comboBoxGender
            // 
            comboBoxGender.Cursor = Cursors.Hand;
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "M - Male", "F - Female" });
            comboBoxGender.Location = new Point(156, 156);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(312, 28);
            comboBoxGender.TabIndex = 6;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "dead", "alive" });
            comboBoxStatus.Location = new Point(156, 192);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(312, 28);
            comboBoxStatus.TabIndex = 7;
            // 
            // FormAddCharacter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 339);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxGender);
            Controls.Add(numericUpDownAge);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(labelComicTitle);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAddCharacter";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddCharacter";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button buttonCancel;
        private Button buttonSave;
        private Label labelComic;
        private Label labelGender;
        private Label labelAge;
        private Label labelDescription;
        private Label labelName;
        private Label labelComicTitle;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private NumericUpDown numericUpDownAge;
        private ComboBox comboBoxGender;
        private CheckBox checkBoxCharactersOpen;
        private Label label1;
        private ComboBox comboBoxStatus;
    }
}