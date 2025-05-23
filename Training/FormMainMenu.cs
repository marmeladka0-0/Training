using MultiCOloredModernUI;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using MultiCOloredModernUI.Classes;

namespace Training
{
    public partial class FormMainMenu : Form
    {
        Library library = new Library();

        public FormMainMenu()
        {
            // робить кнопку невидимою

            InitializeComponent();
            //button1.Visible = false;
            //button1.Enabled = false;
            //button2.Visible = false;
            //button2.Enabled = false;

            //label1.Visible = false;
            //label2.Visible = false;
            //label3.Visible = false;

            //textBox1.Visible = false;
            //textBox1.Enabled = false;
            //textBox2.Visible = false;
            //textBox2.Enabled = false;


            //library.WriteInfo();
            library.ReadInfo();

            comboBoxSearchBy.SelectedIndex = 0;

            dataGridView1.DataSource = library.comics;
            dataGridView1.Columns["comicId"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void btnSearch_Click(object sender, EventArgs e)
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
                dataGridView1.Columns["comicId"].Visible = false;
            }

        }

        void ChangeFields()
        {
            comboBoxSearchBy.Items.Clear();

            if (library.isComicSelected)
            {
                comboBoxSearchBy.Items.AddRange(new string[] {
                    "Title", "Author", "ReleaseYear", "Type", "Genre", "Status"
                    });
                dataGridView1.DataSource = library.comics;
                dataGridView1.Columns["comicId"].Visible = false;
            }
            else
            {
                comboBoxSearchBy.Items.AddRange(new string[] {
                     "Name", "Age", "Genre"
                     });
                dataGridView1.DataSource = library.characters;
                dataGridView1.Columns["characterId"].Visible = false;
                dataGridView1.Columns["description"].Visible = false;
            }

            comboBoxSearchBy.SelectedIndex = 0; // вибрати перше поле
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
               "Are you sure you want to start a new catalog?\n All unsaved data will be lost.",
               "Confirmation",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
             );

            if (result == DialogResult.Yes)
            {
                library = new Library();
                if (library.isComicSelected)
                {
                    dataGridView1.DataSource = library.comics;
                    dataGridView1.Columns["comicId"].Visible = false;
                }
                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = library.characters;
                    dataGridView1.Columns["comicId"].Visible = false;
                    dataGridView1.Columns["description"].Visible = false;
                }
            }

        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library.ReadInfo();
            //MessageBox.Show($"isComicSelected = {library.isComicSelected}");
            if (library.isComicSelected)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = library.comics;
                dataGridView1.Columns["comicId"].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = library.characters;
                dataGridView1.Columns["comicId"].Visible = false;
                dataGridView1.Columns["description"].Visible = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library.WriteNewInfo();
        }

        private void comicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library.isComicSelected = true;
            ChangeFields();
        }

        private void charactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library.isComicSelected = false;
            ChangeFields();
        }

        private void buttonAddComic_Click(object sender, EventArgs e)
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

        private void buttonDeleteComics_Click(object sender, EventArgs e)
        {
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

        private void buttonEditComic_Click(object sender, EventArgs e)
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
    }
}
