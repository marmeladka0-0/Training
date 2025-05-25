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
        public List<Comic> comics = new List<Comic>();
        public List<Comic> selectedComics = new List<Comic>();
        public List<Character> characters = new List<Character>();
        public List<Character> selectedCharacters = new List<Character>();
        public bool isComicSelected = true;
        public Comic? selectedC = null;


        public void FillWithTestData()
        {
            comics.Clear();
            characters.Clear();

            string[] lineComics = { "10016|Kill Blue|Tadatoshi Fujimaki|2023|manga|action|Ongoing|-",
                                    "10017|The 100th Regression of the Max-Level Player|Unknown|2023|manga|action|Ongoing|-",
                                    "10018|The Extra’s Academy Survival Guide|Unknown|2023|manga|action|Ongoing|-",
                                    "10019|The Top Dungeon Farmer|Unknown|2023|webtoon|action|Ongoing|-",
                                    "10020|Killer Peter|Unknown|2023|webtoon|action|Ongoing|-",
                                    "10021|Operation: True Love|kkokkalee|2023|manhwa|romance|Ongoing|-",
                                    "10022|Couple Breaker|Maenggi Ki, Taegeon|2023|manhwa|romance|Ongoing|-",
                                    "10023|The Player Hides His Past|Bethes, Binukki|2023|manhwa|drama|Ongoing|-",
                                    "10024|Villains Are Destined to Die|Gyeoeul Gwon, SUOL|2023|manhwa|romance|Ongoing|-",
                                    "10025|A Killer Paradox|Kim Da-min|2024|webtoon|thriller|Ongoing|-",
                                    "10026|Peculiar Dream|Nan Nan|2024|webtoon|thriller|Ongoing|-",
                                    "10027|The Guy Upstairs|Hanza Art|2024|webtoon|thriller|Ongoing|-",
                                    "10028|Devil Among Us|Nemo Nullus|2024|webtoon|thriller|Ongoing|-",
                                    "10029|Third Shift Society|Meredith Moriarty|2019|webtoon|mystery|Ongoing|-",
                                    "10030|Revenge of the Baskerville Bloodhound|Unknown|2023|manga|action|Ongoing|-",
                                    "10031|JoJo's Bizarre Adventure: The JOJOLands|Hirohiko Araki|2023|manga|action|Ongoing|-",
                                    "10032|Gachiakuta|Kei Urana|2022|manga|fantasy|Ongoing|-",
                                    "10033|Sakamoto Days|Yuto Suzuki|2022|manga|action|Ongoing|-",
                                    "10034|Fabricant 100|Daisuke Enoshima|2023|manga|horror|Completed|-",
                                    "10035|Hell's Paradise|Yuji Kaku|2023|manga|action|Completed|-",
                                    "10036|Vagabond|Takehiko Inoue|1998|manga|historical|Paused|-",
                                    "10037|One Piece|Eiichiro Oda|1997|manga|action|Paused|-",
                                    "10038|Go! Go! Loser Ranger!|Negi Haruba|2023|manga|action|Paused|-",
                                    "10039|Hunter x Hunter|Yoshihiro Togashi|1998|manga|action|Paused|-",
                                    "10040|Cursed Princess Club|LambCat|2019|webtoon|fantasy|Completed|-",
                                    "10041|Our Paradise|greeneer|2018|manhwa|drama|Completed|-",
                                    "10042|Tiger Coming In|Cafe92|2020|manhwa|comedy|Completed|-",
                                    "10043|No Home|Wanan|2018|manhwa|drama|Completed|-",
                                    "10044|Seasons of Blossom|Hongduck|2020|manhwa|drama|Completed|-"};

            string[] lineCharacters = { "20001|Elric|Time traveler|27|M|alive|10017",
                                        "20002|Mira|Combat strategist|25|F|alive|10017",
                                        "20003|Noah|Reluctant hero|19|M|alive|10018",
                                        "20004|Selene|Mystic mentor|60|F|alive|10018",
                                        "20005|Jin|Farmer turned fighter|22|M|alive|10019",
                                        "20006|Tara|Dungeon guide|24|F|alive|10019",
                                        "20007|Peter|Cursed warrior|29|M|dead|10020",
                                        "20008|Elena|Rebel leader|33|F|alive|10020",
                                        "20009|Yumi|Hopeless romantic|18|F|alive|10021",
                                        "20010|Minho|Stubborn classmate|19|M|alive|10021",
                                        "20011|Hana|Popular influencer|21|F|alive|10022",
                                        "20012|Dae|Protective brother|23|M|alive|10022",
                                        "20013|Jisoo|Masked vigilante|28|M|alive|10023",
                                        "20014|Ara|Healer with a secret|26|F|alive|10023",
                                        "20015|Penelope|Royal villainess|25|F|alive|10024",
                                        "20016|Reynard|Knight in disguise|27|M|alive|10024",
                                        "20017|Joon|Quiet student|20|M|alive|10025",
                                        "20018|Mihee|Forensic analyst|32|F|alive|10025",
                                        "20019|Ren|Dream walker|21|M|alive|10026",
                                        "20020|Cleo|Mysterious roommate|23|F|alive|10027",
                                        "20021|Lucian|Demon host|35|M|dead|10028",
                                        "20022|Ellie|Ghost medium|19|F|alive|10029",
                                        "20023|Jolyne|Bold fighter|24|F|alive|10031",
                                        "20024|Jodio Joestar|Ruthless protagonist|18|M|alive|10031",
                                        "20025|Rudo|Trashland survivor|16|M|alive|10032",
                                        "20026|Chiyo|Wanderer|20|F|alive|10032",
                                        "20027|Sakamoto|Hitman turned dad|40|M|alive|10033",
                                        "20028|Shin|Telepathic assistant|25|M|alive|10033",
                                        "20029|Ashibi|Immortal ninja|30|M|dead|10035",
                                        "20030|Sagiri|Executioner|24|F|alive|10035",
                                        "20031|Musashi|Samurai legend|28|M|alive|10036",
                                        "20032|Otsu|Woman of vengeance|21|F|alive|10036",
                                        "20033|Gon|Adventurous boy|13|M|alive|10039",
                                        "20034|Killua|Assassin prodigy|14|M|alive|10039",
                                        "20035|Princess Gwendolyn|Fairy tale rebel|20|F|alive|10040",
                                        "20036|Blossom|Shy poet|18|F|alive|10044",
                                        "20037|Jay|Troubled teen|19|M|dead|10044",
                                        "20038|Aris|Cold-hearted mage|121|F|alive|10017",
                                        "20039|Duran|Old guildmaster|63|M|dead|10017",
                                        "20040|Sylvia|Sword prodigy|20|F|alive|10017",
                                        "20041|Gorrak|Berserker from the North|35|M|alive|10017",
                                        "20042|Lina|Potion alchemist|28|F|alive|10017",
                                        "20043|Zeke|The cursed prince|32|M|alive|10017",
                                        "20044|Mara|Assassin from the Red Fang|26|F|dead|10017",
                                        "20045|Fenrir|Guardian beast|500|M|alive|10017",
                                        "20046|Kain|Blacksmith of dimensions|54|M|alive|10017",
                                        "20047|Eira|Oracle of the Flame|18|F|alive|10017"};

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
