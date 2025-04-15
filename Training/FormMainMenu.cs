using MultiCOloredModernUI;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using MultiCOloredModernUI.Classes;

namespace Training
{
    public partial class FormMainMenu : Form
    {
        int[] matrix;
        Library library = new Library();

        public FormMainMenu()
        {
            // робить кнопку невидимою
            
            InitializeComponent();
            button1.Visible = false;    
            button1.Enabled = false;
            button2.Visible = false;
            button2.Enabled = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            textBox1.Visible = false;
            textBox1.Enabled = false;
            textBox2.Visible = false;
            textBox2.Enabled = false;
            library.WriteInfo();
            library.ReadInfo();

            dataGridView1.DataSource = library.comics;
            dataGridView1.Columns["comicId"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //label3.Text = library.comics[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            matrix = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                matrix[i] = rand.Next(100);
                textBox2.Text += matrix[i] + "  ";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int minIdx = 0;
            for (int i = 1; i < matrix.Length; i++)
                if (matrix[minIdx] > matrix[i])
                    minIdx = i;
            label2.Text = " Мінімальне значення " +
                matrix[minIdx] + "(номер " + minIdx + ")";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string s = textBox3.Text;
            //label3.Text = "*А тут будуть списком комікси*";
            List<Comic> selectedComics = [];
            foreach (Comic comic in library.comics) 
            {
                if (comic.HasInTitle(s))
                {
                    selectedComics.Add(comic);
                }
            }
            dataGridView1.DataSource = selectedComics;
            dataGridView1.Columns["comicId"].Visible = false;
        }

        
    }
}
