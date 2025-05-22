using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCOloredModernUI.Classes
{
    public class Comic
    {
        public int comicID { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int releaseYear { get; set; }
        public string type { get; set; }
        public string genre { get; set; }
        public string status { get; set; }
        public Character[]? characters { get; set; }

        public string ToString()
        {
            string comicInfo = "";
            comicInfo += comicID + "|";
            comicInfo += title + "|";
            comicInfo += author + "|";
            comicInfo += releaseYear + "|";
            comicInfo += type + "|";
            comicInfo += genre + "|";
            comicInfo += status + "|";
            if (characters == null)
            {
                comicInfo += "-";
            }
            return comicInfo;
        }

        public bool HasInTitle(string srch)
        {
            int j = 0;
            if (srch == "") return true;
            for (int i = 0; i < title.Length; i++)
            {
                char a = char.ToLower(title[i]);
                char b = char.ToLower(srch[j]);
                if (a != b)
                {
                    j = 0;
                    continue;
                }
                if (a == b)
                {
                    j++;
                }
                if (j+1 == srch.Length)
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasIn(string srch, string column)
        {
            string element = "";
            if (column == "title") element = title;
            if (column == "author") element = author;
            if (column == "releaseyear") element = releaseYear.ToString();
            if (column == "type") element = type;
            if (column == "genre") element = genre;
            if (column == "status") element = status;

            return element.ToLower().Contains(srch.ToLower());


            //int j = 0;

            //if (srch == "") return true;
            //for (int i = 0; i < element.Length; i++)
            //{
            //    char a = char.ToLower(element[i]);
            //    char b = char.ToLower(srch[j]);
            //    if (a != b)
            //    {
            //        j = 0;
            //        continue;
            //    }
            //    if (a == b)
            //    {
            //        j++;
            //    }
            //    if (j + 1 == srch.Length)
            //    {
            //        return true;
            //    }
            //}


            //return false;
        }
        //11111|AbobaTitle|AbobaAuthor|2023|manhva|fantasy|InProgress|-
    }
}
