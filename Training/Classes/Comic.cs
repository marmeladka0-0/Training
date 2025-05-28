using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCOloredModernUI.Classes
{
    public class Comic
    {
        //Parametrs of comic
        public int comicID { get; set; }
        public string title { get; set; } = "";
        public string author { get; set; } = "";
        public int releaseYear { get; set; }
        public string type { get; set; } = "";
        public string genre { get; set; } = "";
        public string status { get; set; } = "";
        public Image? comicCover { get; set; }
        public string? coverPath { get; set; }


        //Return comic as a string
        public string ComicToString()
        {
            string comicInfo = "";
            comicInfo += comicID + "|";
            comicInfo += title + "|";
            comicInfo += author + "|";
            comicInfo += releaseYear + "|";
            comicInfo += type + "|";
            comicInfo += genre + "|";
            comicInfo += status + "|";
            if (coverPath != null)
            {
                comicInfo += coverPath;
            } else
            {
                comicInfo += "-";
            }
            return comicInfo;
        }

        
        //Check if the comic has the search row in his title and others
        public bool HasIn(string srch, string column)
        {
            //11111|AbobaTitle|AbobaAuthor|2023|manhva|fantasy|InProgress|-
            string element = "";
            if (column == "title") element = title;
            if (column == "author") element = author;
            if (column == "releaseyear") element = releaseYear.ToString();
            if (column == "type") element = type;
            if (column == "genre") element = genre;
            if (column == "status") element = status;

            return element.ToLower().Contains(srch.ToLower());
        }
    }
}
