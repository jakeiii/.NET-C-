using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public enum Class
    {
        Warrior, Mage, Druid, Priest, Warlock,
        Rogue, Paladin, Hunter, Shaman
    };

    public enum Role { Tank, Healer, Damage };

    public enum Race { Orc, Troll, Tauren, Forsaken };


    public partial class Form1 : Form
    {
        List<Guild> guildsarray = new List<Guild>();
        string formatedtext;
        int selectedindex = -1;

        string[] splitplayers;
        List<Player> playerList = new List<Player>();
        string players;
        public Form1()
        {

            InitializeComponent();

            foreach (var item in Enum.GetNames(typeof(Class)))
            {
                classBox.Items.Add(item);
            }

            using (StreamReader inFile = new StreamReader("Players.txt"))
            {
                players = inFile.ReadLine();

                for (int i = 0; players != null; i++)
                {
                    splitplayers = players.Split('\t');

                    Race foo = (Race)Enum.Parse(typeof(Race), splitplayers[2]);
                    Class bar = (Class)Enum.Parse(typeof(Class), splitplayers[3]);
                    Role bar2 = (Role)Enum.Parse(typeof(Role), splitplayers[4]);


                    Player newPlayer = new Player(Convert.ToUInt32(splitplayers[0]), splitplayers[1], foo, bar, bar2,Convert.ToUInt32(splitplayers[5]), Convert.ToUInt32(splitplayers[6]), Convert.ToUInt32(splitplayers[7]));
                    playerList.Insert(0, newPlayer);
                    players = inFile.ReadLine();
                }
            }
            using (StreamReader inFile = new StreamReader("Guilds.txt"))
            {
                string guildtext = inFile.ReadLine();
                int counter = 0;
                for (int i = 0; guildtext != null ; i++)
                {
                    string[] splitguildtext1 = guildtext.Split('\t');
                    
                    string[] splitguildtext3 = splitguildtext1[2].Split('-');

                    Guild newGuild = new Guild(Convert.ToUInt32(splitguildtext1[0]), Convert.ToUInt32(splitguildtext1[1]), splitguildtext3[0], splitguildtext3[1]);

                    guildsarray.Insert(i, newGuild);
                    guildtext = inFile.ReadLine();
                   formatedtext = String.Format("{0, -25} {1,15}", guildsarray[i].Name, guildsarray[i].Server);
                   serverBox.Items.Add(guildsarray[i].Server);
                    counter++;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void classBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serverBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void showResults_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("All "+classBox.Text+" from "+serverBox.Text);
            listBox1.Items.Add("------------------------------------------------------------------");
            List<Player> players = new List<Player>();
            List<uint> players2 = new List<uint>();
            if (classBox != null && serverBox != null)
            {

                var linqClassServer = from guild in guildsarray
                                      where guild.Server.Equals(serverBox.Text)
                                      select guild.ID;
                
                foreach (var i in linqClassServer)
                {
                    var LinqPlayer = from Player in playerList
                                     where Player.GuildID.Equals(i)
                                     select Player;
         
                    foreach (var j in LinqPlayer)
                    {
                        var linqfinal = from player in LinqPlayer
                                        where player.pClass.Equals(classBox.Text)
                                        select player;
                        foreach (var k in linqfinal)
                        {
                       
                            listBox1.Items.Add("Name: "+k.Name+"    ("+k.pClass+" - "+k.pRole+")\tRace: "+k.Race+"\tLevel: "+k.Level+"\t<" +
                                "");
                        
                        }

                    }
                    
                }

                listBox1.Items.Add("End Results");
                listBox1.Items.Add("-----------------------------------------------------------------");
            }

        }

        private void MinUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(MinUpDown.Value <= 1)
            {
                MinUpDown.Value = 1;
            }

            if(MinUpDown.Value >= 60)
            {
                MinUpDown.Value = 60;
            }

            if(MinUpDown.Value >= MaxUpDown.Value)
            {
                if(MaxUpDown.Value != 60)
                    MaxUpDown.Value++;
            }
        }

        private void MaxUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MaxUpDown.Value <= 1)
            {
                MaxUpDown.Value = 1;
            }

            if (MaxUpDown.Value >= 60)
            {
                MaxUpDown.Value = 60;
            }

            if (MaxUpDown.Value <= MinUpDown.Value)
            {
                if (MinUpDown.Value != 1)
                    MinUpDown.Value--;
            }
        }
    }
    public class Player
    {
        private readonly uint id;
        private readonly string name;
        private readonly Race race;
        private readonly Class playerClass;
        private readonly Role playerRole;
        private uint exp;
        private uint level;
        private uint guildID;

        public uint ID
        {
            get { return id; }
        }

        public String Name
        {
            get { return name; }
        }

        public Race Race
        {
            get { return race; }
        }
        public String pClass
        {
            get { return String.Format("{0, -15}", playerClass); }
        }
        public String pRole
        {
            get { return String.Format("{0, -15}", playerRole); }
        }

        public uint Level
        {
            get { return level; }

            set
            {
                if (value >= 0 && value <= 60)
                    level = value;

                else
                {
                    level = 0;
                }

            }
        }

        public uint Exp
        {
            get { return exp; }

            set
            {
                uint nextLevel = level * 1000;
                exp += value;
            }
        }

        public uint GuildID
        {
            get { return guildID; }

            set { guildID = value; }
        }

        public Player()
        {
            id = 0;
            name = "";
            race = 0;
            level = 0;
            guildID = 0;
        }

        public Player(uint newID, string newName, Race newRace, Class newClass, Role newRole, uint newLevel, uint newExp, uint newGuildID)
        {
            id = newID;
            name = newName;
            race = newRace;
            playerRole = newRole;
            level = newLevel;
            guildID = newGuildID;
            playerClass = newClass;
            exp = newExp;
        }

        public override string ToString()
        {
            return String.Format("{0, -25} {1, -15} {2, -2}", name, playerClass, level);
        }
    }
    class Guild
    {
        private uint id;
        private uint type;
        private string name;
        private string server;
       

        public uint ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public string Server
        {
            get { return server; }
        }
        public Guild(uint guildid, uint guildType, string guildname, string servername)
        {
            id = guildid;
            type = guildType;
            name = guildname;
            server = servername;
        }
        public Guild()
        {
            id = 0;
            type = 0;
            name = "";
            server = "";
        }
    }
}


