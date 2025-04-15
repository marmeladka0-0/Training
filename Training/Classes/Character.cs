using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCOloredModernUI.Classes
{
    public class Character
    {
        public int characterID { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public ushort age { get; set; }
        public char gender { get; set; }

        public void GetInfo()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Name:" + name);
            Console.WriteLine("About:" + description);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Gender:" + gender);
            Console.WriteLine("======================");
        }



    }
}
