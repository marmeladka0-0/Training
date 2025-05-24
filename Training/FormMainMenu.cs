using MultiCOloredModernUI;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using MultiCOloredModernUI.Classes;
using System.Windows.Forms;

namespace Training
{
    public partial class FormMainMenu : Form
    {
        Library library = new Library();


        public FormMainMenu()//CONSTRUCTOR
        {
            // робить кнопку невидимою

            InitializeComponent();
            //button1.Visible = false;
            //button1.Enabled = false;

            //library.WriteInfo();
            library.ReadInfo();

            comboBoxSearchBy.SelectedIndex = 0;

            dataGridView1.DataSource = library.comics;
            dataGridView1.Columns["comicId"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.FormClosing += MainMenuClosing;
            radioButtonNone.Visible = false;
            //label3.Text = library.comics[0].ToString();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    textBox2.Clear();
        //    int n = Convert.ToInt32(textBox1.Text);
        //    matrix = new int[n];
        //    Random rand = new Random();
        //    for (int i = 0; i < n; i++)
        //    {
        //        matrix[i] = rand.Next(100);
        //        textBox2.Text += matrix[i] + "  ";
        //    }

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    int minIdx = 0;
        //    for (int i = 1; i < matrix.Length; i++)
        //        if (matrix[minIdx] > matrix[i])
        //            minIdx = i;
        //    label2.Text = " Мінімальне значення " +
        //        matrix[minIdx] + "(номер " + minIdx + ")";
        //}

        private void btnSearch_Click(object sender, EventArgs e)//SEARCH
        {
            string s = textBox3.Text;
            string selectedField = comboBoxSearchBy.SelectedItem.ToString().ToLower();
            //MessageBox.Show($"selectedField = {selectedField}");
            //label3.Text = "*А тут будуть списком комікси*";

            //List<Comic> selectedComics = [];
            //foreach (Comic comic in library.comics)
            //{
            //    if (comic.HasInTitle(s))
            //    {
            //        selectedComics.Add(comic);
            //    }
            //}
            if (library.isComicSelected)
            {
                dataGridView1.DataSource = library.SearchComics(s, selectedField);
                dataGridView1.Columns["comicId"].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = library.SearchCharacters(s, selectedField);
                dataGridView1.Columns["characterId"].Visible = false;
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)//NEW
        {
            var result = MessageBox.Show(
               "Are you sure you want to start a new catalog?\n All unsaved data will be lost.",
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
                    //dataGridView1.DataSource = null;
                    //dataGridView1.DataSource = library.characters;
                    //dataGridView1.Columns["characterID"].Visible = false;
                    //dataGridView1.Columns["comicId"].Visible = false;
                    //dataGridView1.Columns["description"].Visible = false;
                }
            }

        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)//DOWNLOAD
        {
            //MessageBox.Show($"isComicSelected = {library.isComicSelected}");
            if (library.isComicSelected)
            {
                library.ReadInfo();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = library.comics;
                dataGridView1.Columns["comicId"].Visible = false;
            }
            else
            {
                library.ReadInfo();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = library.characters;
                dataGridView1.Columns["characterID"].Visible = false;
                dataGridView1.Columns["comicId"].Visible = false;
                //dataGridView1.Columns["description"].Visible = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)//SAVE
        {
            library.WriteNewInfo();
        }

        private void comicsToolStripMenuItem_Click(object sender, EventArgs e)//SWITCH_COMIC
        {
            library.isComicSelected = true;
            ChangeFields();
        }

        private void charactersToolStripMenuItem_Click(object sender, EventArgs e)//SWITCH_CH
        {
            library.isComicSelected = false;
            ChangeFields();
        }
        private void ChangeFields()//SW_HELP_F
        {
            comboBoxSearchBy.Items.Clear();

            if (library.isComicSelected)
            {
                comboBoxSearchBy.Items.AddRange(new string[] {
                    "Title", "Author", "ReleaseYear", "Type", "Genre", "Status"
                    });
                dataGridView1.DataSource = library.comics;
                dataGridView1.Columns["comicId"].Visible = false;
                buttonAddCharacter.Enabled = true;
                buttonAddCharacter.Visible = true;
            }
            else
            {
                comboBoxSearchBy.Items.AddRange(new string[] {
                     "Name", "Description", "Age", "Gender", "Status"
                     });
                dataGridView1.DataSource = library.characters;
                dataGridView1.Columns["characterId"].Visible = false;
                dataGridView1.Columns["comicId"].Visible = false;
                buttonAddCharacter.Enabled = false;
                buttonAddCharacter.Visible = false;
                //dataGridView1.Columns["description"].Visible = false;
            }

            comboBoxSearchBy.SelectedIndex = 0; // вибрати перше поле
        }

        private void buttonAddComic_Click(object sender, EventArgs e)//ADD
        {
            if (library.isComicSelected)
            {
                FormAddComic form = new FormAddComic();
                form.ShowDialog();

                if (form.NewComic == null) { return; }
                if (library.comics.Count == 0) { form.NewComic.comicID = 10000; }
                else
                {
                    form.NewComic.comicID = library.comics.Last().comicID + 1;
                }
                library.comics.Add(form.NewComic);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = library.comics;
                dataGridView1.Columns["comicId"].Visible = false;
            }
            else
            {
                MessageBox.Show(
                        "You can add characters only on the page with comics.\n" +
                        "Please choose the comic.\n" +
                        "And then push the 'Add Character' button.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                library.isComicSelected = true;
                ChangeFields();
            }
        }

        private void buttonDeleteComics_Click(object sender, EventArgs e)//DELETE
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

                    Comic selectedComic = (Comic)dataGridView1.SelectedRows[0].DataBoundItem;

                    library.comics.Remove(selectedComic);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = library.comics;
                    dataGridView1.Columns["comicID"].Visible = false;
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

                    Character selectedCharacter = (Character)dataGridView1.SelectedRows[0].DataBoundItem;

                    library.characters.Remove(selectedCharacter);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = library.characters;
                    dataGridView1.Columns["characterID"].Visible = false;
                    dataGridView1.Columns["comicID"].Visible = false;
                }
            }
        }

        private void buttonEditComic_Click(object sender, EventArgs e)//EDIT
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

                Comic selectedComic = (Comic)dataGridView1.SelectedRows[0].DataBoundItem;

                FormAddComic editForm = new FormAddComic(selectedComic);
                editForm.ShowDialog();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = library.comics;
                dataGridView1.Columns["comicID"].Visible = false;
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

                Character selectedCharacter = (Character)dataGridView1.SelectedRows[0].DataBoundItem;

                FormAddCharacter editForm = new FormAddCharacter(selectedCharacter);
                editForm.ShowDialog();

                ChangeFields();
            }
        }

        private void buttonAddCharacter_Click(object sender, EventArgs e)//ADD_CHARACTER
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

            Comic selectedComic = (Comic)dataGridView1.SelectedRows[0].DataBoundItem;
            FormAddCharacter form = new FormAddCharacter(selectedComic);
            form.ShowDialog();

            if (form.NewCharacter == null) { return; }
            if (library.characters.Count == 0) { form.NewCharacter.characterID = 20000; }
            else
            {
                form.NewCharacter.characterID = library.characters.Last().characterID + 1;
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

        public void MainMenuClosing(object sender, FormClosingEventArgs e)//IS_ALL_SAVED
        {
            var result = MessageBox.Show(
               "Do you want to save your data before.\n All unsaved data will be lost.",
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

        private void importTestDataToolStripMenuItem_Click(object sender, EventArgs e)//TEST_DATA
        {
            library.FillWithTestData();
        }

        private void button1_Click(object sender, EventArgs e)//FILTER_COMICS
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
                if (fromYear != null && fromYear > item.releaseYear) { checker = false; }
                if (toYear != null && toYear < item.releaseYear) { checker = false; }
                if (type != null && type.ToLower() != item.type) { checker = false; }
                if (genre != null && genre.ToLower() != item.genre) { checker = false; }
                if (status != null && status != item.status) { checker = false; }
                if (checker == true) { newComicList.Add(item); }
            }

            dataGridView1.DataSource = newComicList;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            numericUpDownFrom.Value = 0;
            numericUpDownTo.Value = 0;

            comboBoxType.SelectedIndex = -1;
            comboBoxGenre.SelectedIndex = -1;
            radioButtonNone.Checked = true;
        }
    }
}
