using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyRoster
{
    public partial class MyRoster : Form
    {
        int i = 0;
        ImageList heroList = new ImageList();
        public static List<Hero> HeroesDB = new List<Hero>();
        public static List<HeroInfo> InfoDB = new List<HeroInfo>();
        public PictureBox [] pics = new PictureBox[12];
        public string[] picture = new string[10];

        public MyRoster()
        {
            InitializeComponent();
            Initialise_Heroes();
            Set_Images();
            Set_Up_Pictureboxes();
            Initialise_Hero_Info();
        }

        private void Set_Up_Pictureboxes()
        {
            pics[0] = pictureBox1;
            pics[1] = pictureBox2;
            pics[2] = pictureBox3;
            pics[3] = pictureBox4;
            pics[4] = pictureBox5;
            pics[5] = pictureBox6;
            pics[6] = pictureBox7;
            pics[7] = pictureBox8;
            pics[8] = pictureBox9;
            pics[9] = pictureBox10;
        }

        private void Initialise_Hero_Info()
        {
            InfoDB.Add(new HeroInfo
            {
                hero = "Alarak",
                D = "Passive: Alarak deals 100% more Ability damage versus enemy Heroes.",
                Q = "Discord Strike, 55 Mana Cooldown: 8 seconds. After a 0.5 second delay, enemies in front of Alarak take 175(+4 % per level) damage and are silenced for 1.5 seconds.",
                W = "Telekinesis, 30 Mana Cooldown: 12 seconds,Create a force, pushing yourself and all enemies hit from the targeted point towards the targeted direction.Deals 48(+4 % per level) damage to enemies.",
                E = "Lightning Surge, 30 Mana Cooldown: 6 seconds. Deal 100(+4 % per level) damage to an enemy and all enemies between you and the target. 75 % of the damage dealt to enemy Heroes is returned as health.",
                R1 = "Deadly Charge, 45 Mana Cooldown: 60 seconds. After channeling, Alarak charges forward dealing 200(+4 % per level) damage to all enemies in his path.Distance is increased based on the amount of time channeled,up to 1.625 seconds.Issuing a Move order while this is channeling will cancel it at no cost. Taking damage will interrupt the channeling.",
                R2 = "Counter-Strike, 50 Mana Cooldown: 30 seconds. Alarak becomes Protected and Unstoppable while channeling for 1 second.If an enemy Hero attacked Alarak during that time, Alarak sends a shockwave forward that deals 275(+4 % per level) damage."
            });
        }

        private void Initialise_Heroes()
        {
            HeroesDB.Add(new Hero { name = "Alarak", spec = "Assassin",location = -1 });
            HeroesDB.Add(new Hero { name = "Chromie", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Falstad", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Gall", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Greymane", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Gul'dan", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Illidan", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Jaina", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Kael'thas", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Kerrigan", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Li-Ming", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Lunara", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Nova", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Ragnaros", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Raynor", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Samuro", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "The Butcher", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Thrall", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Tracer", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Tychus", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Valeera", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Valla", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Zeratul", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Zul'jin", spec = "Assassin", location = -1 });
            HeroesDB.Add(new Hero { name = "Abathur", spec = "Specialist", location = -1 });
            HeroesDB.Add(new Hero { name = "Azmodan", spec = "Specialist", location = -1 });
            HeroesDB.Add(new Hero { name = "Gazlowe", spec = "Specialist", location = -1 });
            HeroesDB.Add(new Hero { name = "Medivh", spec = "Specialist", location = -1 });
            HeroesDB.Add(new Hero { name = "Murky", spec = "Specialist", location = -1 });
            HeroesDB.Add(new Hero { name = "Nazeebo", spec = "Specialist", location = -1 });
            HeroesDB.Add(new Hero { name = "Sgt Hammer", spec = "Specialist", location = -1 });
            HeroesDB.Add(new Hero { name = "Sylvanas", spec = "Specialist", location = -1 });
            HeroesDB.Add(new Hero { name = "Vikings", spec = "Specialist", location = -1 });
            HeroesDB.Add(new Hero { name = "Xul", spec = "Specialist", location = -1 });
            HeroesDB.Add(new Hero { name = "Zagara", spec = "Specialist", location = -1 });
            HeroesDB.Add(new Hero { name = "Anub'arak", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "Artanis", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "Arthas", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "Chen", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "Cho", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "Dehaka", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "Diablo", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "ETC", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "Johanna", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "Leoric", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "Muradin", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "Rexxar", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "Sonya", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "Stitches", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "Tyrael", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "Varian", spec = "Multi", location = -1 });
            HeroesDB.Add(new Hero { name = "Zarya", spec = "Warrior", location = -1 });
            HeroesDB.Add(new Hero { name = "Auriel", spec = "Support", location = -1 });
            HeroesDB.Add(new Hero { name = "Brightwing", spec = "Support", location = -1 });
            HeroesDB.Add(new Hero { name = "Kharazim", spec = "Support", location = -1 });
            HeroesDB.Add(new Hero { name = "Li Li", spec = "Support", location = -1 });
            HeroesDB.Add(new Hero { name = "Lt Morales", spec = "Support", location = -1 });
            HeroesDB.Add(new Hero { name = "Lucio", spec = "Support", location = -1 });
            HeroesDB.Add(new Hero { name = "Malfurion", spec = "Support", location = -1 });
            HeroesDB.Add(new Hero { name = "Rehgar", spec = "Support", location = -1 });
            HeroesDB.Add(new Hero { name = "Tassadar", spec = "Support", location = -1 });
            HeroesDB.Add(new Hero { name = "Tyrande", spec = "Support", location = -1 });
            HeroesDB.Add(new Hero { name = "Uther", spec = "Support", location = -1 });
        }

        private void Set_Images()
        {
            heroList.ImageSize = new Size(75, 75);
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Abathur_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Alarak_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Anub'arak_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Artanis_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Arthas_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Auriel_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Azmodan_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Brightwing_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Chen_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Cho_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Chromie_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Dehaka_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Diablo_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Falstad_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Gall_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Gazlowe_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Greymane_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Gul'dan_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Illidan_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Jaina_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Johanna_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Kael'thas_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Kerrigan_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Kharazim_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\L90ETC_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Leoric_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Li_li_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Li-Ming_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Lt-Morales_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Lucio_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Lunara_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Malfurion_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Medivh_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Muradin_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Murky_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Nazeebo_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Nova_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Ragnaros_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Raynor_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Rehgar_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Rexxar_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Samuro_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Sgt-Hammer_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Sonya_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Stitches_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Sylvanas_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Tassadar_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\The-Butcher_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Thrall_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Tracer_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Tychus_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Tyrael_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Tyrande_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Uther_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\valeera_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Valla_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Varian_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Vikings_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Zagara_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Zarya_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Zeratul_Icon.png"));
            heroList.Images.Add(Image.FromFile(@"C:\Users\Eugene\Pictures\Zuljin_Icon.png"));
        }

        private void AddHero_Click(object sender, EventArgs e)
        {

            // Get the currently selected item in the ListBox.
            string curItem = heroListbox.SelectedItem.ToString();
            // Find the string in heroListbox
            int index = heroListbox.FindString(curItem);
            //Check to see if we have reached the end of the list, go to start
            if(i == 10)
            {
                i = 0;

            }
            //Check to see if hero is in list then set the current hero location
            foreach (var h in HeroesDB)
            {
                if (curItem == h.name)
                {
                    //Check to see if hero already in roster
                    if(h.location > -1)
                    {
                        break;
                    }
                    //Set the hero location
                    h.location = i;
                    //Track the name of the hero in the picturebox
                    picture[i] = h.name;
                    //Set the image of the picturebox to the current hero
                    pics[i].Image = heroList.Images[index];
                    i++;
                }
            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void DelHero_Click(object sender, EventArgs e)
        {
            //Set each of the picturebox images to null to 'reset'
            for(int j = 0; j < 10; j++)
            {
                pics[j].Image = null;
                pics[j].BorderStyle = BorderStyle.None;
            }
            //Reset the locations of heroes
            foreach(var h in HeroesDB)
            {
                h.location = -1;
            }

            D_text.Text = null;
            Q_text.Text = null;
            W_text.Text = null;
            E_text.Text = null;
            R1_text.Text = null;
            R2_text.Text = null;
            //Reset the imagebox location
            i = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Check which hero is in the picturebox
            foreach(var h in InfoDB)
            {
                if (h.hero == picture[0])
                {
                    //Display the info in the textboxes
                    D_text.Text = h.D;
                    Q_text.Text = h.Q;
                    W_text.Text = h.W;
                    E_text.Text = h.E;
                    R1_text.Text = h.R1;
                    R2_text.Text = h.R2;
                }
            }

            //Set the url of the current hero
            string uri = "https://www.heroescounters.com/hero/" + picture[0];
            Form2 newForm = new Form2(uri);
            newForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Check which hero is in the picturebox
            foreach (var h in InfoDB)
            {
                if (h.hero == picture[1])
                {
                    //Display the info in the textboxes
                    D_text.Text = h.D;
                    Q_text.Text = h.Q;
                    W_text.Text = h.W;
                    E_text.Text = h.E;
                    R1_text.Text = h.R1;
                    R2_text.Text = h.R2;
                }
            }
            //Set the url of the current hero
            string uri = "https://www.heroescounters.com/hero/" + picture[1];
            Form2 newForm = new Form2(uri);
            newForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Check which hero is in the picturebox
            foreach (var h in InfoDB)
            {
                if (h.hero == picture[2])
                {
                    //Display the info in the textboxes
                    D_text.Text = h.D;
                    Q_text.Text = h.Q;
                    W_text.Text = h.W;
                    E_text.Text = h.E;
                    R1_text.Text = h.R1;
                    R2_text.Text = h.R2;
                }
            }
            //Set the url of the current hero
            string uri = "https://www.heroescounters.com/hero/" + picture[2];
            Form2 newForm = new Form2(uri);
            newForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Check which hero is in the picturebox
            foreach (var h in InfoDB)
            {
                if (h.hero == picture[3])
                {
                    //Display the info in the textboxes
                    D_text.Text = h.D;
                    Q_text.Text = h.Q;
                    W_text.Text = h.W;
                    E_text.Text = h.E;
                    R1_text.Text = h.R1;
                    R2_text.Text = h.R2;
                }
            }
            //Set the url of the current hero
            string uri = "https://www.heroescounters.com/hero/" + picture[3];
            Form2 newForm = new Form2(uri);
            newForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Check which hero is in the picturebox
            foreach (var h in InfoDB)
            {
                if (h.hero == picture[4])
                {
                    //Display the info in the textboxes
                    D_text.Text = h.D;
                    Q_text.Text = h.Q;
                    W_text.Text = h.W;
                    E_text.Text = h.E;
                    R1_text.Text = h.R1;
                    R2_text.Text = h.R2;
                }
            }
            //Set the url of the current hero
            string uri = "https://www.heroescounters.com/hero/" + picture[4];
            Form2 newForm = new Form2(uri);
            newForm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Check which hero is in the picturebox
            foreach (var h in InfoDB)
            {
                if (h.hero == picture[5])
                {
                    //Display the info in the textboxes
                    D_text.Text = h.D;
                    Q_text.Text = h.Q;
                    W_text.Text = h.W;
                    E_text.Text = h.E;
                    R1_text.Text = h.R1;
                    R2_text.Text = h.R2;
                }
            }
            //Set the url of the current hero
            string uri = "https://www.heroescounters.com/hero/" + picture[5];
            Form2 newForm = new Form2(uri);
            newForm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //Check which hero is in the picturebox
            foreach (var h in InfoDB)
            {
                if (h.hero == picture[6])
                {
                    //Display the info in the textboxes
                    D_text.Text = h.D;
                    Q_text.Text = h.Q;
                    W_text.Text = h.W;
                    E_text.Text = h.E;
                    R1_text.Text = h.R1;
                    R2_text.Text = h.R2;
                }
            }
            //Set the url of the current hero
            string uri = "https://www.heroescounters.com/hero/" + picture[6];
            Form2 newForm = new Form2(uri);
            newForm.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //Check which hero is in the picturebox
            foreach (var h in InfoDB)
            {
                if (h.hero == picture[7])
                {
                    //Display the info in the textboxes
                    D_text.Text = h.D;
                    Q_text.Text = h.Q;
                    W_text.Text = h.W;
                    E_text.Text = h.E;
                    R1_text.Text = h.R1;
                    R2_text.Text = h.R2;
                }
            }
            //Set the url of the current hero
            string uri = "https://www.heroescounters.com/hero/" + picture[7];
            Form2 newForm = new Form2(uri);
            newForm.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //Check which hero is in the picturebox
            foreach (var h in InfoDB)
            {
                if (h.hero == picture[8])
                {
                    //Display the info in the textboxes
                    D_text.Text = h.D;
                    Q_text.Text = h.Q;
                    W_text.Text = h.W;
                    E_text.Text = h.E;
                    R1_text.Text = h.R1;
                    R2_text.Text = h.R2;
                }
            }
            //Set the url of the current hero
            string uri = "https://www.heroescounters.com/hero/" + picture[8];
            Form2 newForm = new Form2(uri);
            newForm.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //Check which hero is in the picturebox
            foreach (var h in InfoDB)
            {
                if (h.hero == picture[9])
                {
                    //Display the info in the textboxes
                    D_text.Text = h.D;
                    Q_text.Text = h.Q;
                    W_text.Text = h.W;
                    E_text.Text = h.E;
                    R1_text.Text = h.R1;
                    R2_text.Text = h.R2;
                }
            }
            //Set the url of the current hero
            string uri = "https://www.heroescounters.com/hero/" + picture[9];
            Form2 newForm = new Form2(uri);
            newForm.Show();
        }

        private void heroListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void supp_CheckedChanged(object sender, EventArgs e)
        {
            //Check to if there are any support heroes and change their border
            foreach(var h in HeroesDB)
            {
                if(h.spec == "Support" && h.location > -1)
                {
                    if(supp.Checked == true)
                    {
                        pics[h.location].BorderStyle = BorderStyle.Fixed3D;
                    }
                    if(supp.Checked == false)
                    {
                        pics[h.location].BorderStyle = BorderStyle.None;
                    }
                }
            }
        }

        private void special_CheckedChanged(object sender, EventArgs e)
        {
            //Check to if there are any specialist heroes and change their border
            foreach (var h in HeroesDB)
            {
                if (h.spec == "Specialist" && h.location > -1)
                {
                    if (special.Checked == true)
                    {
                        pics[h.location].BorderStyle = BorderStyle.Fixed3D;
                    }
                    if (special.Checked == false)
                    {
                        pics[h.location].BorderStyle = BorderStyle.None;
                    }
                }
            }
        }

        private void assass_CheckedChanged(object sender, EventArgs e)
        {
            //Check to if there are any assassin heroes and change their border
            foreach (var h in HeroesDB)
            {
                if (h.spec == "Assassin" && h.location > -1)
                {
                    if (assass.Checked == true)
                    {
                        pics[h.location].BorderStyle = BorderStyle.Fixed3D;
                    }
                    if (assass.Checked == false)
                    {
                        pics[h.location].BorderStyle = BorderStyle.None;
                    }
                }
            }
        }

        private void warrior_CheckedChanged(object sender, EventArgs e)
        {
            //Check to if there are any warrior heroes and change their border
            foreach (var h in HeroesDB)
            {
                if (h.spec == "Warrior" && h.location > -1)
                {
                    if (warrior.Checked == true)
                    {
                        pics[h.location].BorderStyle = BorderStyle.Fixed3D;
                    }
                    if (warrior.Checked == false)
                    {
                        pics[h.location].BorderStyle = BorderStyle.None;
                    }
                }
            }
        }

        private void SaveList_Click(object sender, EventArgs e)
        {
            //Define the roster
            string[] roster = new string[10];
            //Save the name of each hero in its picturebox position
            for(int j = 0; j < 10; j++)
            {
                foreach(var h in HeroesDB)
                {
                    if(h.location == j)
                    {
                        roster[j] = h.name;
                    }
                }
            }
            //Save the file 
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save a List of Heroes";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Write the list of heroes to file
                File.WriteAllLines(saveFileDialog1.FileName, roster);
            }
            i = 0;
        }

        private void LoadList_Click(object sender, EventArgs e)
        {
            //Reset all hero locations
            foreach(var h in HeroesDB)
            {
                h.location = -1;
            }

            int counter = 0;
            string line;
            //Define the roster of heroes
            string[] roster = new string[10];
            //Open the file
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                //Write the lines of the file to the roster
                while ((line = sr.ReadLine()) != null)
                {
                    roster[counter] = line;
                    counter++;
                }

                sr.Close();
            }
            //Set the images for each of the heroes in the roster
            for (int j = 0; j < 10; j++)
            {
                int index = heroListbox.FindString(roster[j]);//Find the index of the hero
                pics[j].Image = heroList.Images[index];//Set the picture to the picturebox
                //Set the location of each hero
                foreach(var h in HeroesDB)
                {
                    if(h.name == roster[j])
                    {
                        h.location = j;
                    }
                }
            }
            i = 0;
        }
    }
}
