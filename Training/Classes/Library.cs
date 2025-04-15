using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MultiCOloredModernUI;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace MultiCOloredModernUI.Classes
{
    public class Library
    {
        public List<Comic> comics = [];
        public List<Character> characters = [];

        //public Comic[]? comics {  get; set; }
        //public Character[]? characters { get; set; }

        //public void WriteInfo(string[]lines)
        public void WriteInfo()
        {
            string[] lines = {  "10001|Shadow Hunters|Liam Wong|2021|manga|action|Completed|-",
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

            var writer = new StreamWriter("Input_Data/LibraryInfo.txt");
            foreach (var line in lines)
            {
                writer.WriteLine(line);
            }
            writer.Close();
        }

        public void ReadInfo()
        {
            comics.Clear();
            characters.Clear();
            var reader = new StreamReader("Input_Data/LibraryInfo.txt");
            //D:\\Masha\\CPP\\Training\\Training\\Input_Data\\LibraryInfo.txt
            string? line;
            while ((line = reader.ReadLine()) != null)
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
            reader.Close();
        }
    }
}
