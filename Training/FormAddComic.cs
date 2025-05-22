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

            Comic comic = new Comic();

            comic.title = textBoxTitle.Text;
            comic.author = textBoxAuthor.Text;
            comic.releaseYear = Convert.ToInt32(numericUpDownYear.Value);
            comic.type = comboBoxType.SelectedItem.ToString().ToLower();
            comic.genre = comboBoxGenre.SelectedItem.ToString().ToLower();
            comic.status = comboBoxType.SelectedItem.ToString();

            NewComic = comic;
            this.Close();
        }

    }
}
