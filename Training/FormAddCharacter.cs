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
using System.Windows.Forms.VisualStyles;

namespace MultiCOloredModernUI
{
    public partial class FormAddCharacter : Form
    {
        Comic selectedComic;
        public Character? NewCharacter { get; set; }

        public bool OpenCharacters = false;
        public FormAddCharacter(Comic SelectedComic)
        {
            InitializeComponent();
            selectedComic = SelectedComic;
            labelComicTitle.Text = selectedComic.title;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescription.Text) ||
                comboBoxGender.SelectedItem == null ||
                numericUpDownAge.Value == 0)
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question
                );
                return;
            }

            NewCharacter = new Character();
            NewCharacter.comicID = selectedComic.comicID;

            NewCharacter.name = textBoxName.Text;
            NewCharacter.description = textBoxDescription.Text;
            NewCharacter.age = Convert.ToUInt16(numericUpDownAge.Value);
            NewCharacter.gender = comboBoxGender.SelectedItem.ToString()[0];
            NewCharacter.status = comboBoxStatus.SelectedItem.ToString();

            OpenCharacters = checkBoxCharactersOpen.Checked;

            this.Close();

        }
        public FormAddCharacter(Character selectedCharacter)
        {
            InitializeComponent();
            this.Text = "EditCharacter";
            checkBoxCharactersOpen.Visible = false;
            checkBoxCharactersOpen.Enabled = false;
            this.Height = 362;
            panel1.Height = 78;

            labelComicTitle.Text = selectedCharacter.comicID.ToString(); //FIX

            textBoxName.Text = selectedCharacter.name;
            textBoxDescription.Text = selectedCharacter.description;
            numericUpDownAge.Value = selectedCharacter.age;
            comboBoxStatus.SelectedItem = selectedCharacter.status.ToString();
            if (selectedCharacter.gender.ToString() == "M")
            {
                comboBoxGender.SelectedItem = selectedCharacter.gender.ToString() + " - Male";
            } else
            {
                comboBoxGender.SelectedItem = selectedCharacter.gender.ToString() + " - Female";
            }
            

            NewCharacter = selectedCharacter;
        }
    }

}
