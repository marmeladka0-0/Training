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
        //Parametrs of character
        public int characterID { get; set; }
        public string name { get; set; } = "";
        public string description { get; set; } = "";
        public ushort age { get; set; }
        public char gender { get; set; }
        public string status { get; set; } = "";
        public int comicID { get; set; }


        //Return character as a string
        public string CharacterToString()
        {
            string characterInfo = "";
            characterInfo += characterID + "|";
            characterInfo += name + "|";
            characterInfo += description + "|";
            characterInfo += age + "|";
            characterInfo += gender + "|";
            characterInfo += status + "|";
            characterInfo += comicID;
            return characterInfo;
        }


        //Check if the character has the search row in his title and others
        public bool HasIn(string srch, string column)
        {   
            //11111|AbobaName|AbobaDescription|Age|gender|comicID
            string element = "";
            if (column == "name") element = name;
            if (column == "description") element = description.ToString();
            if (column == "age") element = age.ToString();
            if (column == "gender") element = gender.ToString();
            if (column == "status") element = status.ToString();

            return element.ToLower().Contains(srch.ToLower());

        }
    }
}
