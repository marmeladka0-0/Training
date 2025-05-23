﻿using System;
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
        public List<Comic> comics = new List<Comic>();
        public List<Comic> selectedComics = new List<Comic>();
        public List<Character> characters = new List<Character>();
        public List<Character> selectedCharacters = new List<Character>();
        public bool isComicSelected = true;
        public Comic? selectedC = null;
        //public Comic[]? comics {  get; set; }
        //public Character[]? characters { get; set; }

        //public void WriteInfo(string[]lines)
        public void WriteInfo()
        {
            string[] lineComics = {  "10001|Shadow Hunters|Liam Wong|2021|manga|action|Completed|-",
                                "10002|Moonlight Kiss|Yuna Kim|2022|manhwa|romance|InProgress|-",
                                "10003|Cyber Dreams|Alex Chen|2020|webtoon|sci-fi|Hiatus|-",
                                "10004|Dragon Scroll|Takeshi Ito|2019|manga|fantasy|Completed|-",
                                "10005|Love Algorithm|Emily Ray|2024|manhwa|comedy|InProgress|-",
                                "10006|Neon Prophecy|Ivan Petrov|2023|webtoon|thriller|Ongoing|-",
                                "10007|Eclipse City|Sara Lee|2025|manhwa|drama|InProgress|-",
                                "10008|Zero Signal|Mark Vega|2021|manga|mystery|Completed|-",
                                "10009|Winds of Yore|Naoko Sato|2022|manga|historical|Hiatus|-",
                                "10010|Pixel Heart|Chris Tan|2023|webtoon|slice of life|InProgress|-",
                                "10011|Shadow Reborn|Kai Takahashi|2024|manhwa|action|InProgress|-",
                                "10012|Love in Eclipse City|Nina Cho|2025|webtoon|romance|Ongoing|-",
                                "10013|Heart of the Moonlight|Daniel Lee|2023|manga|drama|Completed|-",
                                "10014|Scroll of Shadows|Mei Tanaka|2022|manga|fantasy|Hiatus|-",
                                "10015|Cyber Heart|Anna Petrova|2021|webtoon|sci-fi|InProgress|-"};

            string[] lineCharacters = { "20001|Kaida|Skilled assassin|23|F|alive|10001",
                                        "20002|Ryo|Team leader|30|M|alive|10001",
                                        "20003|Hana|Moon goddess|19|F|alive|10002",
                                        "20005|Nova|AI companion|5|F|alive|10003",
                                        "20006|Kenta|Dragon warrior|17|M|alive|10003",
                                        "20007|Ella|Scientist|26|F|alive|10004",
                                        "20008|Leo|Detective|35|M|dead|10004",
                                        "20009|Soojin|Mayor’s daughter|20|F|alive|10005",
                                        "20010|Akira|Silent observer|40|M|alive|10005"};


            //var writer = new StreamWriter("Input_Data/LibraryInfo.txt");
            //foreach (var line in lines)
            //{
            //    writer.WriteLine(line);
            //}
            //writer.Close();

            //using open this only for this block
            using (var writer = new StreamWriter("Input_Data/LibraryInfo.txt"))
            {
                foreach (var line in lineComics)
                {
                    writer.WriteLine(line);
                }
                writer.WriteLine("***");
                foreach (var line in lineCharacters)
                {
                    writer.WriteLine(line);
                }
            }

        }

        public void FillWithTestData()
        {
            comics.Clear();
            characters.Clear();

            string[] lineComics = {  "10001|Shadow Hunters|Liam Wong|2021|manga|action|Completed|-",
                                "10002|Moonlight Kiss|Yuna Kim|2022|manhwa|romance|InProgress|-",
                                "10003|Cyber Dreams|Alex Chen|2020|webtoon|sci-fi|Hiatus|-",
                                "10004|Dragon Scroll|Takeshi Ito|2019|manga|fantasy|Completed|-",
                                "10005|Love Algorithm|Emily Ray|2024|manhwa|comedy|InProgress|-",
                                "10006|Neon Prophecy|Ivan Petrov|2023|webtoon|thriller|Ongoing|-",
                                "10007|Eclipse City|Sara Lee|2025|manhwa|drama|InProgress|-",
                                "10008|Zero Signal|Mark Vega|2021|manga|mystery|Completed|-",
                                "10009|Winds of Yore|Naoko Sato|2022|manga|historical|Hiatus|-",
                                "10010|Pixel Heart|Chris Tan|2023|webtoon|slice of life|InProgress|-",
                                "10011|Shadow Reborn|Kai Takahashi|2024|manhwa|action|InProgress|-",
                                "10012|Love in Eclipse City|Nina Cho|2025|webtoon|romance|Ongoing|-",
                                "10013|Heart of the Moonlight|Daniel Lee|2023|manga|drama|Completed|-",
                                "10014|Scroll of Shadows|Mei Tanaka|2022|manga|fantasy|Hiatus|-",
                                "10015|Cyber Heart|Anna Petrova|2021|webtoon|sci-fi|InProgress|-"};

            string[] lineCharacters = { "20001|Kaida|Skilled assassin|23|F|alive|10001",
                                        "20002|Ryo|Team leader|30|M|alive|10001",
                                        "20003|Hana|Moon goddess|19|F|alive|10002",
                                        "20005|Nova|AI companion|5|F|alive|10003",
                                        "20006|Kenta|Dragon warrior|17|M|alive|10003",
                                        "20007|Ella|Scientist|26|F|alive|10004",
                                        "20008|Leo|Detective|35|M|dead|10004",
                                        "20009|Soojin|Mayor’s daughter|20|F|alive|10005",
                                        "20010|Akira|Silent observer|40|M|alive|10005"};



            foreach (string line in lineComics)
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
                comics.Add(newComic);
            }
            foreach (string line in lineCharacters)
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
        }

        public void ReadInfo()
        {
            comics.Clear();
            characters.Clear();
            var reader = new StreamReader("Input_Data/LibraryInfo.txt");
            //D:\\Masha\\CPP\\Training\\Training\\Input_Data\\LibraryInfo.txt
            string? line;
            while ((line = reader.ReadLine()) != "***")
            {
                //11111|AbobaTitle|AbobaAuthor|2023|manhva|fantasy|InProgress|-
                //Console.WriteLine(line);
                //label3.Text = line;
                string[] addinfo = line.Split('|');
                Comic newComic = new Comic();
                newComic.comicID = Convert.ToInt32(addinfo[0]);
                newComic.title = addinfo[1];
                newComic.author = addinfo[2];
                newComic.releaseYear = Convert.ToInt32(addinfo[3]);
                newComic.type = addinfo[4];
                newComic.genre = addinfo[5];
                newComic.status = addinfo[6];
                comics.Add(newComic);
            }
            while ((line = reader.ReadLine()) != null)
            {
                //11111|AbobaTitle|AbobaAuthor|2023|manhva|fantasy|InProgress|-
                //Console.WriteLine(line);
                //label3.Text = line;
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

        public void WriteNewInfo()
        {
            var writer = new StreamWriter("Input_Data/LibraryInfo.txt");

            foreach (Comic newcomic in comics)
            {
                string line = "";
                //line += newcomic.comicID + "|";
                //line += newcomic.title + "|";
                //line += newcomic.author + "|";
                //line += newcomic.releaseYear + "|";
                //line += newcomic.type + "|";
                //line += newcomic.genre + "|";
                //line += newcomic.status + "|";
                //line += "-";
                line = newcomic.ToString();
                writer.WriteLine(line);
            }

            writer.WriteLine("***");

            foreach (Character newCharacter in characters)
            {
                string line;
                line = newCharacter.ToString();
                writer.WriteLine(line);
            }
            writer.Close();
        }

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
