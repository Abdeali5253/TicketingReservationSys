using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketingReservationSys
{
    public partial class WhatsOn : Form
    {
        public WhatsOn()
        {
            InitializeComponent();

        }

        private void WhatsOn_Load(object sender, EventArgs e)
        {





        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {

            if(Searchtxt.Text!=null)
            {
                panel1.Visible = true;
                searchedpic.Visible = true;


            }
            if(Searchtxt.Text==string.Empty)
            {
                panel1.Visible = false;
               

            }

            if (Searchtxt.Text.Equals("Joker", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\Joker.jpg");

            }

            if (Searchtxt.Text.Equals("The Conjouring 2", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Conjouring", StringComparison.CurrentCultureIgnoreCase)|| Searchtxt.Text.Equals("Conjouring 2", StringComparison.CurrentCultureIgnoreCase)|| Searchtxt.Text.Equals("The Conjouring", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\TC2.jpg");
            }

            if (Searchtxt.Text.Equals("Star wars", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Star", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Wars", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("War", StringComparison.CurrentCultureIgnoreCase)|| Searchtxt.Text.Equals("starwars", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\Star Wars.jpg");

            }

            if (Searchtxt.Text.Equals("12 Monkeys", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("12", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("monkeys", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("12 monkeys", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\12 Monkeys.jpg");

            }

            if (Searchtxt.Text.Equals("Black Widow", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Black", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("widow", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("black", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\Black Widow.jpg");

            }

            if (Searchtxt.Text.Equals("BladeRunner", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Blade", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("runner", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("bladerunner", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\BladeRunner.jpg");
            }

            if (Searchtxt.Text.Equals("Deadpool", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Dead", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("dead", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("deadpool", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\Deadpool.jpg");
            }

            if (Searchtxt.Text.Equals("Avengers : EndGame", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("a", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("endgame", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Avenger", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Endgame", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("e", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\Endgame.jpg");
            }

            if (Searchtxt.Text.Equals("Fallout", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("fallout", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("fall", StringComparison.CurrentCultureIgnoreCase) )
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\Fallout.jpg");
            }

            if (Searchtxt.Text.Equals("FlatLiners", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("flatliners", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("flat", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("liners", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\FlatLiners.jpg");
            }

            if (Searchtxt.Text.Equals("Rambo", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("R", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("r", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("rambo", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\Rambo.jpg");
            }

            if (Searchtxt.Text.Equals("Shadow Hunter", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("shadow", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Shadow", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("hunter", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\Shadow Hunter.jpg");
            }

            if (Searchtxt.Text.Equals("Skyfall", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("sky", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("skyfall", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("fall", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\Skyfall.jpg");
            }

            if (Searchtxt.Text.Equals("TheMist", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Mist", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("mist", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("the mist", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\TheMist.jpg");
            }

            if (Searchtxt.Text.Equals("TheSleeper", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Sleeper", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("sleeper", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\TheSleeper.jpg");
            }

            if (Searchtxt.Text.Equals("TomRaider", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Tom", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("tom", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("tomraider", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("raider", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\TomRaider.jpg");
            }

            if (Searchtxt.Text.Equals("Us", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("us", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("u", StringComparison.CurrentCultureIgnoreCase))
            {
                Resultlbl.Visible = false;
                searchedpic.Image = Image.FromFile(@"G:\Us.jpg");
            }

            if (!(Searchtxt.Text.Equals("Star wars", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Star", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Wars", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("War", StringComparison.CurrentCultureIgnoreCase)
                || Searchtxt.Text.Equals("The Conjouring 2", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Conjouring", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Conjouring 2", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("The Conjouring", StringComparison.CurrentCultureIgnoreCase)
                || Searchtxt.Text.Equals("Joker", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("starwars", StringComparison.CurrentCultureIgnoreCase) 
                || Searchtxt.Text.Equals("12 Monkeys", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("12", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("monkeys", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("12 monkeys", StringComparison.CurrentCultureIgnoreCase) 
                || Searchtxt.Text.Equals("BladeRunner", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Blade", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("runner", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("bladerunner", StringComparison.CurrentCultureIgnoreCase)
                || Searchtxt.Text.Equals("Deadpool", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Dead", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("dead", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("deadpool", StringComparison.CurrentCultureIgnoreCase)
                || Searchtxt.Text.Equals("Avengers : EndGame", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("avenger", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("endgame", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Avengers", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Endgame", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("e", StringComparison.CurrentCultureIgnoreCase)
                || Searchtxt.Text.Equals("Fallout", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("fallout", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("fall", StringComparison.CurrentCultureIgnoreCase)
                || Searchtxt.Text.Equals("FlatLiners", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("flatliners", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("flat", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("liners", StringComparison.CurrentCultureIgnoreCase)
                || Searchtxt.Text.Equals("Rambo", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("R", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("r", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("rambo", StringComparison.CurrentCultureIgnoreCase)
                || Searchtxt.Text.Equals("Shadow Hunter", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("shadow", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Shadow", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("hunter", StringComparison.CurrentCultureIgnoreCase)
                || Searchtxt.Text.Equals("Skyfall", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("sky", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("skyfall", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("fall", StringComparison.CurrentCultureIgnoreCase)
                || Searchtxt.Text.Equals("TheMist", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Mist", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("mist", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("the mist", StringComparison.CurrentCultureIgnoreCase)
                || Searchtxt.Text.Equals("TheSleeper", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Sleeper", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("sleeper", StringComparison.CurrentCultureIgnoreCase)
                || Searchtxt.Text.Equals("TomRaider", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Tom", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("tom", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("tomraider", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("raider", StringComparison.CurrentCultureIgnoreCase)
                || Searchtxt.Text.Equals("Us", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("us", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("u", StringComparison.CurrentCultureIgnoreCase)))
            {
                searchedpic.Visible = false;
                Resultlbl.Visible = true;
            }

            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchedpic_Click(object sender, EventArgs e)
        {
            if (Searchtxt.Text.Equals("Joker", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "Joker";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("The Conjouring 2", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Conjouring", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Conjouring 2", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("The Conjouring", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "Conjuring 2";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("Star wars", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Star", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Wars", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("War", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("starwars", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "StarWars";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("12 Monkeys", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("12", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("monkeys", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("12 monkeys", StringComparison.CurrentCultureIgnoreCase)) 
            {
                Properties.Settings.Default.Movie = "12 Monkeys";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("Black Widow", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Black", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("widow", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("black", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "Black Widow";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("BladeRunner", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Blade", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("runner", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("bladerunner", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "Bladerunner";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("Deadpool", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Dead", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("dead", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("deadpool", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "Deadpool";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("Avengers : EndGame", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("a", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("endgame", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Avenger", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Endgame", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("e", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "Avengers: Endgame";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("Fallout", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("fallout", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("fall", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "Mission Impossible : Fallout";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("FlatLiners", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("flatliners", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("flat", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("liners", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "Flatliners";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("Rambo", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("R", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("r", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("rambo", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "Rambo";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("Shadow Hunter", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("shadow", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Shadow", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("hunter", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "Shadow Hunter";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("Skyfall", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("sky", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("skyfall", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("fall", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "Skyfall";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("TheMist", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Mist", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("mist", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("the mist", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "The Mist";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("TheSleeper", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Sleeper", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("sleeper", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "The Sleeper";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("TomRaider", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("Tom", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("tom", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("tomraider", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("raider", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "Tom Raider";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }

            else if (Searchtxt.Text.Equals("Us", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("us", StringComparison.CurrentCultureIgnoreCase) || Searchtxt.Text.Equals("u", StringComparison.CurrentCultureIgnoreCase))
            {
                Properties.Settings.Default.Movie = "Us";
                LocationANDTiming LAT = new LocationANDTiming();
                this.Hide();
                LAT.Show();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Movie = "Joker";
            LocationANDTiming LAT = new LocationANDTiming();
            this.Hide();
            LAT.Show();
        }
        private void StarWars_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Movie = "StarWars";
            LocationANDTiming LAT = new LocationANDTiming();
            this.Hide();
            LAT.Show();
        }

        private void SkyFall_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Movie = "Skyfall";
            LocationANDTiming LAT = new LocationANDTiming();
            this.Hide();
            LAT.Show();
        }

        private void Avengers_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Movie = "Avengers: Endgame";
            LocationANDTiming LAT = new LocationANDTiming();
            this.Hide();
            LAT.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Movie = "Bladerunner";
            LocationANDTiming LAT = new LocationANDTiming();
            this.Hide();
            LAT.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Movie = "Mission Impossible : Fallout";
            LocationANDTiming LAT = new LocationANDTiming();
            this.Hide();
            LAT.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Movie = "Us";
            LocationANDTiming LAT = new LocationANDTiming();
            this.Hide();
            LAT.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Movie = "The sleeper";
            LocationANDTiming LAT = new LocationANDTiming();
            this.Hide();
            LAT.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Movie = "The Mist";
            LocationANDTiming LAT = new LocationANDTiming();
            this.Hide();
            LAT.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Movie = "House on haunted hill";
            LocationANDTiming LAT = new LocationANDTiming();
            this.Hide();
            LAT.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Movie = "Conjuring 2";
            LocationANDTiming LAT = new LocationANDTiming();
            this.Hide();
            LAT.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Movie = "Flatliners";
            LocationANDTiming LAT = new LocationANDTiming();
            this.Hide();
            LAT.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
        }
    }
}
