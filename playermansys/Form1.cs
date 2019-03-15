/***********************************************************
CSCI 473 - Assignment 2 - Spring 19

Progammer: Jacob Bonnan, Tyler Trull, Alex Quatrini 

Date Due: 2/14/2019

Purpose: To introduce us to forms, similar function to assign 1.
************************************************************/
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

namespace NETAssign2
{
    public enum Race { Orc, Troll, Tauren, Forsaken };

    public enum Class { Warrior, Mage, Druid, Priest, Warlock, Rogue, Paladin, Hunter, Shaman };

    public enum Role { Tank, Healer, DPS };

    public partial class Form1 : Form
    {
        List<Guild> guildsarray = new List<Guild>();
        string formatedtext;
        int selectedindex = -1;
        int selectedplayerindex = -1;
        string[] splitplayers;
        List<Player> playerList = new List<Player>();
        string players;
        public Form1()
        {
            InitializeComponent();
            serverComboBox.Items.Add("Beta4Azeroth");
            serverComboBox.Items.Add("TKWasASetback");
            serverComboBox.Items.Add("ZappyBoi");
            typeComboBox.Items.Add("Causal");
            typeComboBox.Items.Add("Questing");
            typeComboBox.Items.Add("Mythic+");
            typeComboBox.Items.Add("Raiding");
            typeComboBox.Items.Add("PVP");
            raceComboBox.Items.Add("Orc");
            raceComboBox.Items.Add("Troll");
            raceComboBox.Items.Add("Tauren");
            raceComboBox.Items.Add("Forsaken");
            classComboBox.Items.Add("Warrior");
            classComboBox.Items.Add("Mage");
            classComboBox.Items.Add("Druid");
            classComboBox.Items.Add("Priest");
            classComboBox.Items.Add("Warlock");
            classComboBox.Items.Add("Rogue");
            classComboBox.Items.Add("Paladin");
            classComboBox.Items.Add("Hunter");
            classComboBox.Items.Add("Shaman");

            using (StreamReader inFile = new StreamReader("players.txt"))
            {
                players = inFile.ReadLine();// reads file makes player

                for (int i = 0; players != null; i++)
                {
                    splitplayers = players.Split('\t');

                    Race foo = (Race)Enum.Parse(typeof(Race), splitplayers[2]);
                    Class bar = (Class)Enum.Parse(typeof(Class), splitplayers[3]);

                    Player newPlayer = new Player(Convert.ToUInt32(splitplayers[0]), splitplayers[1], foo, bar, Convert.ToUInt32(splitplayers[4]), Convert.ToUInt32(splitplayers[5]), Convert.ToUInt32(splitplayers[6]));
                    playerList.Insert(i, newPlayer);
                    playersListBox.Items.Add(newPlayer.ToString());
                    players = inFile.ReadLine();
                }
            }


            using (StreamReader inFile = new StreamReader("guilds.txt"))
            {
                string guildtext = inFile.ReadLine();
                int counter = 0;
                for (int i = 0; guildtext != null; i++)
                {
                    string[] splitguildtext = guildtext.Split('\t');
                    string[] splitguildtext2 = splitguildtext[1].Split('-');

                    guildsarray.Insert(i, new Guild(Convert.ToUInt32(splitguildtext[0]), splitguildtext2[0], splitguildtext2[1]));
                    guildtext = inFile.ReadLine();
                    formatedtext = String.Format("{0, -25} {1,15}", guildsarray[i].Name, guildsarray[i].Server);
                    listBox1.Items.Add(formatedtext);
                    counter++;
                }
            }

        }


        private void playersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedplayerindex = playersListBox.SelectedIndex;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedindex = listBox1.SelectedIndex;
        }
        /***************************************************************
        add guild 

        Use: makes a new guild with info
        Parameters: sender object and event args
        ***************************************************************/
        private void addGuildButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int myRandomNo = rnd.Next(10000000, 99999999);
            if (GuildName.Text.CompareTo("") == 1 && typeComboBox.Text.CompareTo("") == 1 && serverComboBox.Text.CompareTo("") == 1)
            {
                guildsarray.Add(new Guild(Convert.ToUInt32(myRandomNo), GuildName.Text, serverComboBox.Text));
                formatedtext = String.Format("{0, -25} {1,15}", guildsarray[guildsarray.Count() - 1].Name, guildsarray[guildsarray.Count() - 1].Server);
                listBox1.Items.Add(formatedtext);
            }
            else
            {
                richTextBox1.Text = "Please Make sure all fields are filled out before creating a new guild!";
            }
        }
        /***************************************************************
disbands guild

Use: disband guild
Parameters: sender object and event args
***************************************************************/
        private void disbandGuild_Click(object sender, EventArgs e)
        {
            if (selectedindex != -1)
            {
                guildsarray.Remove(guildsarray[selectedindex]);
                listBox1.Items.RemoveAt(selectedindex);
                selectedindex = -1;
            }
        }
        /***************************************************************
        print guild roster

        Use:prints out the roster for a givin guild
        Parameters: sender object and event args
        ***************************************************************/
        private void printGuildRoster_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (selectedindex != -1)
            {
                for (int i = 0; i < playerList.Count(); i++)
                {
                    if (playerList[i].GuildID == guildsarray[selectedindex].ID)
                    {
                        richTextBox1.AppendText(playerList[i].Name + '\t' + playerList[i].Level + '\t' + playerList[i].Race + '\n');
                    }
                }
            }
        }
        /***************************************************************
        join guild

        Use: Adds player to guild
        Parameters: sender object and event args
        ***************************************************************/
        private void joinGuild_Click(object sender, EventArgs e)
        {
            if (selectedplayerindex != -1 && selectedindex != -1)
            {
                if (playerList[selectedplayerindex].GuildID == 0)
                {
                    playerList[selectedplayerindex].GuildID = guildsarray[selectedindex].ID;
                    richTextBox1.Text = "Succesfully joined guild " + guildsarray[selectedindex].Name + " As player " + playerList[selectedplayerindex].Name;
                }
                else
                {
                    richTextBox1.Text = "Already in a guild, please leave to join.";
                }
            }
            else
            {
                richTextBox1.Text = "Please make sure a player and guild is selected and then try again! ";
            }
        }
        /***************************************************************
        leaves guild

        Use: removes guild from player
        Parameters: sender object and event args
        ***************************************************************/
        private void leaveGuild_Click(object sender, EventArgs e)
        {
            if (selectedplayerindex != -1)
            {
                if (playerList[selectedplayerindex].GuildID != 0)
                {
                    playerList[selectedplayerindex].GuildID = 0;
                    richTextBox1.Text = playerList[selectedplayerindex].Name + " Succesfully left their guild ";
                }
                else
                {
                    richTextBox1.Text = "Currently not in a guild. Please join one so you can leave one lol ";
                }
            }
            else
            {
                richTextBox1.Text = "Please select a player from the list";
            }
        }
        /***************************************************************
        addplayer

        Use: adds a player to game
        Parameters: sender object and event args
        ***************************************************************/

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            if (newPlayerName.Text == "" || raceComboBox.SelectedIndex == -1 || classComboBox.SelectedIndex == -1 || RoleComboBox.SelectedIndex == -1)
            {
                richTextBox1.Text = "Please fill in all the appropriate fields to add a player.";
                return;
            }

            Random rnd = new Random();
            uint myRandomNo = Convert.ToUInt32(rnd.Next(10000000, 99999999));

            Player newPlayer = new Player(myRandomNo, newPlayerName.Text, (Race)raceComboBox.SelectedIndex, (Class)classComboBox.SelectedIndex, 1, 0, 0);
            playersListBox.Items.Add(newPlayer.ToString());
            playerList.Add(newPlayer);

            richTextBox1.Text = "Player successfully added!";
        }
/***************************************************************
apply search criteria

Use: as the name states
Parameters: sender object and event args
***************************************************************/

        private void applySearchCriteria_Click(object sender, EventArgs e)
        {
            if (playerSearch.Text == "" && guildSearch.Text == "")
            {
                playersListBox.Items.Clear();
                foreach (Player player in playerList)
                {
                    playersListBox.Items.Add(player.ToString());
                }

                listBox1.Items.Clear();
                foreach (Guild guild in guildsarray)
                {
                    listBox1.Items.Add(String.Format("{0, -25} {1,15}", guild.Name, guild.Server));
                }

                richTextBox1.Text = "Reset guild and players list boxes.";
            }
            if (playerSearch.Text != "")
            {
                playersListBox.Items.Clear();

                foreach (Player player in playerList)
                {
                    if (player.Name.StartsWith(playerSearch.Text))
                    {
                        playersListBox.Items.Add(player.ToString());
                    }
                }
            }

            if (guildSearch.Text != "")
            {
                listBox1.Items.Clear();

                foreach (Guild guild in guildsarray)
                {
                    if (guild.Name.StartsWith(guildSearch.Text))
                    {
                        listBox1.Items.Add(String.Format("{0, -25} {1,15}", guild.Name, guild.Server));
                    }
                }
            }
        }
/***************************************************************
class combo

Use: gives player appropriate ability
Parameters: guild id, name, and server name
***************************************************************/
        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoleComboBox.Items.Clear();
            RoleComboBox.SelectedIndex = -1;

            switch (classComboBox.SelectedIndex)
            {
                case 0:
                    RoleComboBox.Items.Add("Tank");
                    RoleComboBox.Items.Add("DPS");
                    break;
                case 1:
                    RoleComboBox.Items.Add("DPS");
                    RoleComboBox.SelectedIndex = 0;
                    break;
                case 2:
                    RoleComboBox.Items.Add("Tank");
                    RoleComboBox.Items.Add("Healer");
                    RoleComboBox.Items.Add("DPS");
                    break;
                case 3:
                    RoleComboBox.Items.Add("Healer");
                    RoleComboBox.Items.Add("DPS");
                    break;
                case 4:
                    RoleComboBox.Items.Add("DPS");
                    RoleComboBox.SelectedIndex = 0;
                    break;
                case 5:
                    RoleComboBox.Items.Add("DPS");
                    RoleComboBox.SelectedIndex = 0;
                    break;
                case 6:
                    RoleComboBox.Items.Add("Tank");
                    RoleComboBox.Items.Add("Healer");
                    RoleComboBox.Items.Add("DPS");
                    break;
                case 7:
                    RoleComboBox.Items.Add("DPS");
                    RoleComboBox.SelectedIndex = 0;
                    break;
                case 8:
                    RoleComboBox.Items.Add("Healer");
                    RoleComboBox.Items.Add("DPS");
                    break;
            }
        }
    }
 /***************************************************************
  player class

  Use: holds all info and builds a player object
  ***************************************************************/

    public class Player
    {
        private readonly uint id;
        private readonly string name;
        private readonly Race race;
        private readonly Class playerClass;
        private readonly Role playerRoles;
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
 /***************************************************************
 constructers 

 Use: builds player
 Parameters: id, name, racem class, level, exper, guildid key
 ***************************************************************/
        public Player()
        {
            id = 0;
            name = "";
            race = 0;
            level = 0;
            guildID = 0;
        }

      
        public Player(uint newID, string newName, Race newRace, Class newClass, uint newLevel, uint newExp, uint newGuildID)
        {
            id = newID;
            name = newName;
            race = newRace;
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

    /***************************************************************
    Guild

    Use: constructs and holds guild information 
    ***************************************************************/
    class Guild
    {
        private uint id;
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
/***************************************************************
sort 

Use: Sorts an array of integers in ascending order using
the selection sort algorithm 

Parameters: 1. ar: an array of integers to be sorted.
            2. numItems: the number of items to be sorted. 

Returns: nothing
***************************************************************/
        public string Server
        {
            get { return server; }
        }
/***************************************************************
constructers 

Use: builds the guilds 
Parameters: guild id, name, and server name
***************************************************************/
        public Guild(uint guildid, string guildname, string servername)
        {
            id = guildid;
            name = guildname;
            server = servername;
        }
        public Guild()
        {
            id = 0;
            name = "";
            server = "";
        }
    }
}
