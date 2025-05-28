using MultiCOloredModernUI;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using MultiCOloredModernUI.Classes;
using System.Windows.Forms;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MultiCOloredModernUI.Forms;

namespace Training
{
    public partial class FormMainMenu : Form
    {
        Library library = new Library();


        //Constructor of main form
        public FormMainMenu()//CONSTRUCTOR
        {
            InitializeComponent();
            library.ReadInfo();

            comboBoxSearchBy.SelectedIndex = 0;

            dataGridView1.DataSource = library.comics;
            dataGridView1.Columns["comicId"].Visible = false;
            dataGridView1.Columns["comicCover"].Visible = false;
            dataGridView1.Columns["coverPath"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode
                                                .Fill;

            this.FormClosing += MainMenuClosing;

            radioButtonNone.Visible = false;
            buttonSelect.Enabled = false;
            buttonSelect.Visible = false;
            buttonSC.Enabled = false;
            buttonSC.Visible = false;
            buttonCancel.Enabled = false;
            buttonCancel.Visible = false;
            panel5.Visible = false;
            label7.Text = "";
            label8.Text = "";
        }


        //If user want to search for some information
        private void btnSearch_Click(object sender, EventArgs e)//SEARCH
        {
            string s = textBox3.Text;
            string selectedField = comboBoxSearchBy.SelectedItem
                                   .ToString().ToLower();

            if (library.isComicSelected)
            {
                dataGridView1.DataSource = library
                                           .SearchComics(s, selectedField);
                dataGridView1.Columns["comicId"].Visible = false;
                dataGridView1.Columns["comicCover"].Visible = false;
                buttonFilter.PerformClick();
            }
            else
            {
                dataGridView1.DataSource = library
                                           .SearchCharacters(s, selectedField);
                dataGridView1.Columns["characterId"].Visible = false;
                buttonFilter.PerformClick();
            }

        }


        //To create a new list of comics and also for characters
        //NEW
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
               "Are you sure you want to start a new catalog?\n" +
               "All unsaved data will be lost.",
               "Confirmation",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
             );

            if (result == DialogResult.Yes)
            {
                if (library.isComicSelected)
                {
                    library = new Library();
                    library.isComicSelected = true;
                    ChangeFields();
                }
                else
                {
                    library = new Library();
                    library.isComicSelected = false;
                    ChangeFields();
                }
            }

        }


        //To download the saved data from the txt file
        //DOWNLOAD
        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (library.isComicSelected)
            {
                library.ReadInfo();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = library.comics;
                dataGridView1.Columns["comicId"].Visible = false;
                dataGridView1.Columns["comicCover"].Visible = false;
                dataGridView1.Columns["coverPath"].Visible = false;

            }
            else
            {
                library.ReadInfo();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = library.characters;
                dataGridView1.Columns["characterID"].Visible = false;
                dataGridView1.Columns["comicId"].Visible = false;
            }
        }


        //To save changed data to txt file
        //SAVE
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library.WriteNewInfo();
        }


        //To change view to comics
        //SWITCH_COMIC
        private void comicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library.isComicSelected = true;
            ChangeFields();
        }


        //To change view to characters
        //SWITCH_CH
        private void charactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library.isComicSelected = false;
            ChangeFields();
        }


        //To change view between comics and characters, help function
        //SW_HELP_F
        private void ChangeFields()
        {
            comboBoxSearchBy.Items.Clear();
            comboBoxType.Items.Clear();
            comboBoxGenre.Items.Clear();

            if (library.isComicSelected)
            {
                comboBoxSearchBy.Items.AddRange(new string[] {
                    "Title", "Author"
                    });

                dataGridView1.DataSource = library.comics;
                dataGridView1.Columns["comicId"].Visible = false;
                dataGridView1.Columns["comicCover"].Visible = false;
                dataGridView1.Columns["coverPath"].Visible = false;

                comboBoxType.Items.AddRange(new string[] {
                    "Manga", "Manhwa", "Webtoon", "Comic book", "Manhua"
                    });
                comboBoxGenre.Items.AddRange(new string[] {
                    "Action", "Adventure", "Comedy", "Crime",
                    "Drama", "Historical", "Horror", "Mystery",
                    "Romance", "Thriller", "Fantasy"
                    });

                buttonAddCharacter.Enabled = true;
                buttonAddCharacter.Visible = true;
                label1.Text = "Released Year";
                label2.Text = "Type";
                label3.Text = "Genre";
                label4.Text = "Status";
                groupBox1.Enabled = true;
                groupBox1.Visible = true;
                buttonSC.Enabled = false;
                buttonSC.Visible = false;
                panel5.Visible = false;
                label7.Text = "";
                label8.Text = "";
                library.selectedC = null;
                textBox3.Text = "";
            }
            else
            {
                comboBoxSearchBy.Items.AddRange(new string[] {
                     "Name", "Description"
                     });

                dataGridView1.DataSource = library.characters;
                dataGridView1.Columns["characterId"].Visible = false;
                dataGridView1.Columns["comicId"].Visible = false;

                comboBoxType.Items.AddRange(new string[] {
                    "F", "M"
                    });
                label3.Text = "Status";
                comboBoxGenre.Items.AddRange(new string[] {
                    "Dead", "Alive"
                    });

                buttonAddCharacter.Enabled = false;
                buttonAddCharacter.Visible = false;
                label1.Text = "Age";
                label2.Text = "Gender";
                label4.Text = "Comic";
                groupBox1.Enabled = false;
                groupBox1.Visible = false;
                buttonSC.Enabled = true;
                buttonSC.Visible = true;
                textBox3.Text = "";
            }

            comboBoxSearchBy.SelectedIndex = 0;
        }


        //Function to add new comic or to help user with navigation
        //ADD
        private void buttonAddComic_Click(object sender, EventArgs e)
        {


            if (library.isComicSelected)
            {
                FormAddComic form = new FormAddComic();
                form.ShowDialog();

                if (form.NewComic == null) return;
                if (library.comics.Count == 0) 
                {
                    library = new Library();
                    form.NewComic.comicID = 10000;
                }
                else
                {
                    form.NewComic.comicID = library.comics.Last().comicID + 1;
                }
                library.comics.Add(form.NewComic);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = library.comics;
                dataGridView1.Columns["comicId"].Visible = false;
                dataGridView1.Columns["comicCover"].Visible = false;
                dataGridView1.Columns["coverPath"].Visible = false;
            }
            else
            {
                MessageBox.Show(
                        "You can add characters only on the " +
                        "page with comics.\n"+
                        "Please choose the comic.\n" +
                        "And then push the 'Add Character' button.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                library.isComicSelected = true;
                ChangeFields();
            }
        }


        //Function to delete a comic or a character, related to a choosed view
        //DELETE
        private void buttonDeleteComics_Click(object sender, EventArgs e)
        {
            if (library.isComicSelected)
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please add new comic before.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                    return;
                }

                var result = MessageBox.Show(
                   "Are you sure you want to delete this comic?",
                   "Confirmation",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question
                   );

                if (result == DialogResult.Yes)
                {

                    Comic selectedComic = (Comic)dataGridView1
                                          .SelectedRows[0]
                                          .DataBoundItem;

                    library.comics.Remove(selectedComic);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = library.comics;
                    dataGridView1.Columns["comicID"].Visible = false;
                    dataGridView1.Columns["comicCover"].Visible = false;
                    dataGridView1.Columns["coverPath"].Visible = false;
                }
            }
            else
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please add new character before.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                    return;
                }

                var result = MessageBox.Show(
                   "Are you sure you want to delete this character?",
                   "Confirmation",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question
                   );

                if (result == DialogResult.Yes)
                {

                    Character selectedCharacter = (Character)dataGridView1
                                                  .SelectedRows[0]
                                                  .DataBoundItem;

                    library.characters.Remove(selectedCharacter);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = library.characters;
                    dataGridView1.Columns["characterID"].Visible = false;
                    dataGridView1.Columns["comicID"].Visible = false;
                }
            }
        }


        //Function to edit selected comic or selected character
        //EDIT
        private void buttonEditComic_Click(object sender, EventArgs e)
        {
            if (library.isComicSelected)
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please add new comic before.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                    return;
                }

                Comic selectedComic = (Comic)dataGridView1
                                      .SelectedRows[0].DataBoundItem;

                FormAddComic editForm = new FormAddComic(selectedComic);
                editForm.ShowDialog();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = library.comics;
                dataGridView1.Columns["comicID"].Visible = false;
                dataGridView1.Columns["comicCover"].Visible = false;
                dataGridView1.Columns["coverPath"].Visible = false;
            }
            else
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please add new character before.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                    return;
                }

                Character selectedCharacter = (Character)dataGridView1
                                              .SelectedRows[0]
                                              .DataBoundItem;

                FormAddCharacter editForm = new FormAddCharacter(selectedCharacter);
                editForm.ShowDialog();

                ChangeFields();
            }
        }


        //Function to Add a character
        //ADD_CHARACTER
        private void buttonAddCharacter_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please add new comic before.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                return;
            }

            Comic selectedComic = (Comic)dataGridView1
                                        .SelectedRows[0]
                                        .DataBoundItem;
            FormAddCharacter form = new FormAddCharacter(selectedComic);
            form.ShowDialog();

            if (form.NewCharacter == null) return;
            if (library.characters.Count == 0) 
            { 
                form.NewCharacter.characterID = 20000; 
            }
            else
            {
                form.NewCharacter.characterID = library
                                                .characters.Last()
                                                .characterID + 1;
            }

            library.characters.Add(form.NewCharacter);

            if (form.OpenCharacters)
            {
                library.isComicSelected = false;
                ChangeFields();
            }
            else
            {
                library.isComicSelected = true;
                ChangeFields();
            }
        }


        //A question before user close the main window
        //IS_ALL_SAVED
        public void MainMenuClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(
               "Do you want to save your data before.\n" +
               "All unsaved data will be lost.",
               "Confirmation",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Question
             );

            if (result == DialogResult.Yes)
            {
                library.WriteNewInfo();
            }
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }


        //To import test data, without images
        //TEST_DATA
        private void importTestDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library = new Library();
            library.FillWithTestData();
            dataGridView1.DataSource = null;
            ChangeFields();
        }


        //To filter data
        //FILTER
        private void button1_Click(object sender, EventArgs e)
        {
            if (library.isComicSelected)
            {
                List<Comic> newComicList = new List<Comic>();
                List<Comic> ComicListBefore = library.selectedComics;

                if (ComicListBefore.Count == 0)
                {
                    ComicListBefore = library.comics;
                }

                int? fromYear = null;
                int? toYear = null;
                string? type = null;
                string? genre = null;
                string? status = null;

                if (numericUpDownFrom.Value != 0)
                {
                    fromYear = Convert.ToInt32(numericUpDownFrom.Value);
                }
                if (numericUpDownTo.Value != 0)
                {
                    toYear = Convert.ToInt32(numericUpDownTo.Value);
                }
                if (comboBoxType.Text != "")
                {
                    type = comboBoxType.Text;
                }
                if (comboBoxGenre.Text != "")
                {
                    genre = comboBoxGenre.Text;
                }

                if (radioButton1.Checked)
                    status = radioButton1.Text;
                else if (radioButton2.Checked)
                    status = radioButton2.Text;
                else if (radioButton3.Checked)
                    status = radioButton3.Text;

                foreach (Comic item in ComicListBefore)
                {
                    bool checker = true;
                    if (fromYear != null && fromYear > item.releaseYear) 
                        checker = false;
                    if (toYear != null && toYear < item.releaseYear) 
                        checker = false;
                    if (type != null && type.ToLower() != item.type) 
                        checker = false;
                    if (genre != null && genre.ToLower() != item.genre) 
                        checker = false;
                    if (status != null && status != item.status) 
                        checker = false;
                    if (checker == true) 
                        newComicList.Add(item);
                }

                dataGridView1.DataSource = newComicList;
            }
            else
            {
                List<Character> newComicList = new List<Character>();
                List<Character> ComicListBefore = library.selectedCharacters;

                if (ComicListBefore.Count == 0)
                {
                    ComicListBefore = library.characters;
                }

                int? fromYear = null;
                int? toYear = null;
                char? gender = null;
                string? status = null;
                Comic? comic = library.selectedC;

                if (numericUpDownFrom.Value != 0)
                {
                    fromYear = Convert.ToInt32(numericUpDownFrom.Value);
                }
                if (numericUpDownTo.Value != 0)
                {
                    toYear = Convert.ToInt32(numericUpDownTo.Value);
                }
                if (comboBoxType.Text != "")
                {
                    gender = comboBoxType.Text[0];
                }
                if (comboBoxGenre.Text != "")
                {
                    status = comboBoxGenre.Text;
                }


                foreach (Character item in ComicListBefore)
                {
                    bool checker = true;
                    if (fromYear != null && fromYear > item.age) 
                        checker = false;
                    if (toYear != null && toYear < item.age) 
                        checker = false;
                    if (gender != null && gender != item.gender) 
                        checker = false;
                    if (status != null && status.ToLower() != item.status) 
                        checker = false;
                    if (comic != null && comic.comicID != item.comicID) 
                        checker = false;
                    if (checker == true) 
                        newComicList.Add(item);
                }

                dataGridView1.DataSource = newComicList;
            }


        }


        //To clear filter
        //CLEAR_FILTER
        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (library.isComicSelected)
            {
                numericUpDownFrom.Value = 0;
                numericUpDownTo.Value = 0;

                comboBoxType.SelectedIndex = -1;
                comboBoxGenre.SelectedIndex = -1;
                radioButtonNone.Checked = true;

                if (library.selectedComics.Count == 0)
                {
                    dataGridView1.DataSource = library.comics;
                }
                else
                {
                    dataGridView1.DataSource = library.selectedComics;
                }
            }
            else
            {
                numericUpDownFrom.Value = 0;
                numericUpDownTo.Value = 0;

                comboBoxType.SelectedIndex = -1;
                comboBoxGenre.SelectedIndex = -1;
                library.selectedC = null;
                panel5.Visible = false;
                label7.Text = "";
                label8.Text = "";

                if (library.selectedCharacters.Count == 0)
                {
                    dataGridView1.DataSource = library.characters;
                }
                else
                {
                    dataGridView1.DataSource = library.selectedCharacters;
                }
            }
            btnSearch.PerformClick();
        }


        //To add selected comic in filter for characters
        //ADD_SELECT_COMIC
        private void buttonSC_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please add new comic or character before.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                return;
            }

            library.isComicSelected = true;
            ChangeFields();
            buttonSelect.Enabled = true;
            buttonSelect.Visible = true;
            buttonCancel.Enabled = true;
            buttonCancel.Visible = true;

            buttonAddComic.Enabled = false;
            buttonAddComic.Visible = false;
            buttonDeleteComics.Enabled = false;
            buttonDeleteComics.Visible = false;
            buttonEditComic.Enabled = false;
            buttonEditComic.Visible = false;
            buttonDetails.Enabled = false;
            buttonDetails.Visible = false;
            buttonAddCharacter.Enabled = false;
            buttonAddCharacter.Visible = false;
            menuStrip1.Enabled = false;
            menuStrip1.Visible = false;
        }


        //To select comic in the comic view
        //SELECT_COMIC
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            library.selectedC = (Comic)dataGridView1
                                .SelectedRows[0].DataBoundItem;
            buttonSelect.Enabled = false;
            buttonSelect.Visible = false;
            buttonCancel.Enabled = false;
            buttonCancel.Visible = false;

            buttonAddComic.Enabled = true;
            buttonAddComic.Visible = true;
            buttonDeleteComics.Enabled = true;
            buttonDeleteComics.Visible = true;
            buttonEditComic.Enabled = true;
            buttonEditComic.Visible = true;
            buttonDetails.Enabled = true;
            buttonDetails.Visible = true;
            buttonAddCharacter.Enabled = true;
            buttonAddCharacter.Visible = true;
            library.isComicSelected = false;
            ChangeFields();
            label8.Text = "Selected comic:";
            label7.Text = library.selectedC.title;
            panel5.Visible = true;
            menuStrip1.Enabled = true;
            menuStrip1.Visible = true;
        }


        //To cancel selecting
        //CANCEL_SELECTING_COMIC
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonSelect.Enabled = false;
            buttonSelect.Visible = false;
            buttonCancel.Enabled = false;
            buttonCancel.Visible = false;

            buttonAddComic.Enabled = true;
            buttonAddComic.Visible = true;
            buttonDeleteComics.Enabled = true;
            buttonDeleteComics.Visible = true;
            buttonEditComic.Enabled = true;
            buttonEditComic.Visible = true;
            buttonDetails.Enabled = true;
            buttonDetails.Visible = true;
            buttonAddCharacter.Enabled = true;
            buttonAddCharacter.Visible = true;
            library.isComicSelected = false;
            menuStrip1.Enabled = true;
            menuStrip1.Visible = true;
            ChangeFields();
        }


        //To see information about program and developer
        //ABOUT
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Program: ComicCatalog\n" +
                     "Version: 1.0.0\n" +
                     "Developer: Mariia Mazurova\n" +
                     "Group: PZPI-24-1\n" +
                     "Description: Application for managing " +
                     "comics collections.\n" +
                     "\nFeatures:\n" +
                     "- Add and manage comics\n" +
                     "- Track characters\n" +
                     "- Filter by different parameters\n" +
                     "- Designed for developers, artists and hobby collectors";

            MessageBox.Show(
                message, 
                "About", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Question);
        }


        //To see details about comic or character
        //DETAILS
        private void buttonDetails_Click(object sender, EventArgs e)
        {
            if (library.isComicSelected)
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please add new comic before.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                    return;
                }

                Comic selectedComic = (Comic)dataGridView1
                                      .SelectedRows[0]
                                      .DataBoundItem;
                FormComicInfo form = 
                    new FormComicInfo(selectedComic, library.characters);
                form.ShowDialog();
            }
            else
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please add new character before.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                    return;
                }

                Character selectedCharacter = (Character)dataGridView1
                                              .SelectedRows[0]
                                              .DataBoundItem;

                string message = $"Character ID:" +
                 $" {selectedCharacter.characterID}\n" +
                 $"Name: {selectedCharacter.name}\n" +
                 $"Description: {selectedCharacter.description}\n" +
                 $"Age: {selectedCharacter.age}\n" +
                 $"Gender: {selectedCharacter.gender}\n" +
                 $"Status: {selectedCharacter.status}\n" +
                 $"Comic ID: {selectedCharacter.comicID}";
                MessageBox.Show(
                    message,
                    "Details about character",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Question);
            }
            
        }
    }
}
