using MultiCOloredModernUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultiCOloredModernUI
{
    public partial class FormAddComic : Form
    {
        public Comic? NewComic { get; set; }

        public FormAddComic()
        {
            InitializeComponent();
            this.Text = "AddComic";
        }

        private void buttonCancelAddComic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveComic_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text) ||
                string.IsNullOrWhiteSpace(textBoxAuthor.Text) ||
                comboBoxType.SelectedItem == null ||
                comboBoxGenre.SelectedItem == null ||
                comboBoxStatus.SelectedItem == null ||
                numericUpDownYear.Value == 0)
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question
                );
                return;
            }

            if (NewComic == null)
                NewComic = new Comic();

            NewComic.title = textBoxTitle.Text;
            NewComic.author = textBoxAuthor.Text;
            NewComic.releaseYear = Convert.ToInt32(numericUpDownYear.Value);
            NewComic.type = comboBoxType.SelectedItem.ToString().ToLower();
            NewComic.genre = comboBoxGenre.SelectedItem.ToString().ToLower();
            NewComic.status = comboBoxStatus.SelectedItem.ToString();
            
            this.Close();
        }

        public FormAddComic(Comic comicToEdit) : this()
        {
            this.Text = "EditComic";

            textBoxTitle.Text = comicToEdit.title;
            textBoxAuthor.Text = comicToEdit.author;
            numericUpDownYear.Value = comicToEdit.releaseYear;
            comboBoxType.SelectedItem = char.ToUpper(comicToEdit.type[0]) + comicToEdit.type.Substring(1);
            comboBoxGenre.SelectedItem = char.ToUpper(comicToEdit.genre[0]) + comicToEdit.genre.Substring(1);
            comboBoxStatus.SelectedItem = comicToEdit.status;

            NewComic = comicToEdit;
        }

    }
}
