using MultiCOloredModernUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MultiCOloredModernUI.Forms
{
    public partial class FormComicInfo : Form
    {
        public FormComicInfo(Comic comic, List<Character> characters)
        {
            InitializeComponent();
            labelComicId.Text = Convert.ToString(comic.comicID);
            labelTitle.Text = comic.title;
            labelAuthor.Text = comic.author;
            labelYear.Text = Convert.ToString(comic.releaseYear);
            labelType.Text = comic.type;
            labelGenre.Text = comic.genre;
            labelStatus.Text = comic.status;

            if (comic.comicCover != null)
            {
                //pictureBoxCover.Dock = DockStyle.Fill;
                pictureBoxCover.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxCover.Image = comic.comicCover;
            }

            List<Character> selectedCharacters = new List<Character>();

            foreach (Character character in characters)
            {
                if (character.comicID == comic.comicID)
                {
                    selectedCharacters.Add(character);
                }
            }
            //dataGridViewCharacters = new DataGridView();
            dataGridViewCharacters.DataSource = null;
            dataGridViewCharacters.DataSource = selectedCharacters;
            dataGridViewCharacters.Columns["characterId"].Visible = false;
            dataGridViewCharacters.Columns["comicId"].Visible = false;
            dataGridViewCharacters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
