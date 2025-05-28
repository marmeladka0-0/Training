using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MultiCOloredModernUI;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using static System.Windows.Forms.LinkLabel;
using System.Data.Common;

namespace MultiCOloredModernUI.Classes
{
    public class Library
    {
        //List of all comics
        public List<Comic> comics = new List<Comic>();

        //List of comics after search
        public List<Comic> selectedComics = new List<Comic>();

        //List of all characters
        public List<Character> characters = new List<Character>();

        //List of characters after search
        public List<Character> selectedCharacters = new List<Character>();

        //To choose what view it will be, and change if necessary
        public bool isComicSelected = true;

        //To select comic in characters filter
        public Comic? selectedC = null;



        //To add test data
        public void FillWithTestData()
        {
            comics.Clear();
            characters.Clear();
            var reader = new StreamReader("Input_Data/TestData.txt");
            string? line;

            while (((line = reader.ReadLine()) != "***") &&
                    (line != null))
            {
                string[] addinfo = line.Split('|');
                Comic newComic = new Comic();
                newComic.comicID = Convert.ToInt32(addinfo[0]);
                newComic.title = addinfo[1];
                newComic.author = addinfo[2];
                newComic.releaseYear = Convert.ToInt32(addinfo[3]);
                newComic.type = addinfo[4];
                newComic.genre = addinfo[5];
                newComic.status = addinfo[6];
                if (addinfo[7] != "-")
                {
                    newComic.coverPath = Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory, 
                        addinfo[7]
                    );
                    newComic.comicCover = Image.FromFile(newComic.coverPath);
                }
                comics.Add(newComic);
            }

            while ((line = reader.ReadLine()) != null)
            {
                string[] addinfo = line.Split('|');
                Character newCharacter = new Character();
                newCharacter.characterID = Convert.ToInt32(addinfo[0]);
                newCharacter.name = addinfo[1];
                newCharacter.description = addinfo[2];
                newCharacter.age = Convert.ToUInt16(addinfo[3]);
                newCharacter.gender = Convert.ToChar(addinfo[4]);
                newCharacter.status = addinfo[5];
                newCharacter.comicID = Convert.ToInt32(addinfo[6]);
                characters.Add(newCharacter);
            }

            reader.Close();
        }


        //To read info from txt file
        public void ReadInfo()
        {
            comics.Clear();
            characters.Clear();
            var reader = new StreamReader("Input_Data/LibraryInfo.txt");
            string? line;
            while (((line = reader.ReadLine()) != "***") &&
                    (line != null))
            {
                //11111|AbobaTitle|AbobaAuthor|2023|manhva|fantasy|InProgress|-
                string[] addinfo = line.Split('|');
                Comic newComic = new Comic();
                newComic.comicID = Convert.ToInt32(addinfo[0]);
                newComic.title = addinfo[1];
                newComic.author = addinfo[2];
                newComic.releaseYear = Convert.ToInt32(addinfo[3]);
                newComic.type = addinfo[4];
                newComic.genre = addinfo[5];
                newComic.status = addinfo[6];
                if (addinfo[7] != "-")
                {
                    newComic.coverPath = addinfo[7];
                    newComic.comicCover = Image.FromFile(addinfo[7]);
                }
                comics.Add(newComic);
            }
            while ((line = reader.ReadLine()) != null)
            {
                string[] addinfo = line.Split('|');
                Character newCharacter = new Character();
                newCharacter.characterID = Convert.ToInt32(addinfo[0]);
                newCharacter.name = addinfo[1];
                newCharacter.description = addinfo[2];
                newCharacter.age = Convert.ToUInt16(addinfo[3]);
                newCharacter.gender = Convert.ToChar(addinfo[4]);
                newCharacter.status = addinfo[5];
                newCharacter.comicID = Convert.ToInt32(addinfo[6]);
                characters.Add(newCharacter);
            }
            reader.Close();
        }


        //To save data in a file
        public void WriteNewInfo()
        {
            var writer = new StreamWriter("Input_Data/LibraryInfo.txt");

            foreach (Comic newcomic in comics)
            {
                string line = "";
                line = newcomic.ComicToString();
                writer.WriteLine(line);
            }

            writer.WriteLine("***");

            foreach (Character newCharacter in characters)
            {
                string line;
                line = newCharacter.CharacterToString();
                writer.WriteLine(line);
            }
            writer.Close();
        }


        //To search comics by search row
        public List<Comic> SearchComics(string str, string column)
        {
            selectedComics = new List<Comic>();

            foreach (Comic comic in comics)
            {
                if (comic.HasIn(str, column))
                {
                    selectedComics.Add(comic);
                }
            }

            return selectedComics;
        }


        //To search characters by search row
        public List<Character> SearchCharacters(string str, string column)
        {
            selectedCharacters = new List<Character>(); ;

            foreach (Character character in characters)
            {
                if (character.HasIn(str, column))
                {
                    selectedCharacters.Add(character);
                }
            }

            return selectedCharacters;
        }
    }
}
