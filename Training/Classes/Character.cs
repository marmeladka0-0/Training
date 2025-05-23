using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultiCOloredModernUI.Classes
{
    public class Character
    {
        public int characterID { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public ushort age { get; set; }
        public char gender { get; set; }
        public int comicID { get; set; }

        //public void GetInfo()
        //{
        //    Console.WriteLine("======================");
        //    Console.WriteLine("Name:" + name);
        //    Console.WriteLine("About:" + description);
        //    Console.WriteLine("Age:" + age);
        //    Console.WriteLine("Gender:" + gender);
        //    Console.WriteLine("======================");
        //}

        public string ToString()
        {
            string characterInfo = "";
            characterInfo += characterID + "|";
            characterInfo += name + "|";
            characterInfo += description + "|";
            characterInfo += age + "|";
            characterInfo += gender + "|";
            characterInfo += comicID;
            return characterInfo;
        }

        public bool HasIn(string srch, string column)
        {
            string element = "";
            if (column == "name") element = name;
            if (column == "description") element = description.ToString();
            if (column == "age") element = age.ToString();
            if (column == "gender") element = gender.ToString();
            
            return element.ToLower().Contains(srch.ToLower());

        }

        //11111|AbobaName|AbobaDescription|Age|gender|comicID

    }
}
