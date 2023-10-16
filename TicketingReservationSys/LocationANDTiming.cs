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
    public partial class LocationANDTiming : Form
    {
        public LocationANDTiming()
        {
            InitializeComponent();

            DateTime date = DateTime.Now.AddDays(2);
            DATbtn.Text = date.ToString("dd/MM/yyyy");

            Properties.Settings.Default.Date = string.Empty;
            Properties.Settings.Default.Location = string.Empty;
            Properties.Settings.Default.Type = string.Empty;
            Properties.Settings.Default.Timing = string.Empty;

            

        }

        public void Randomizetime()
        {
            Random hour = new Random(DateTime.Now.Hour);
            Random min = new Random(DateTime.Now.Minute);
            button1.Text = (hour.Next(10, 24)).ToString() + ":" + (min.Next(10, 59)).ToString();
            button2.Text = (hour.Next(10, 24)).ToString() + ":" + (min.Next(10, 59)).ToString();
            button3.Text = (hour.Next(10, 24)).ToString() + ":" + (min.Next(10, 59)).ToString();
            button4.Text = (hour.Next(10, 24)).ToString() + ":" + (min.Next(10, 59)).ToString();
            button5.Text = (hour.Next(10, 24)).ToString() + ":" + (min.Next(10, 59)).ToString();
            button6.Text = (hour.Next(10, 24)).ToString() + ":" + (min.Next(10, 59)).ToString();
            button7.Text = (hour.Next(10, 24)).ToString() + ":" + (min.Next(10, 59)).ToString();
            button8.Text = (hour.Next(10, 24)).ToString() + ":" + (min.Next(10, 59)).ToString();
            button9.Text = (hour.Next(10, 24)).ToString() + ":" + (min.Next(10, 59)).ToString();
            button10.Text = (hour.Next(10, 24)).ToString() + ":" + (min.Next(10, 59)).ToString();
            button11.Text = (hour.Next(10, 24)).ToString() + ":" + (min.Next(10, 59)).ToString();
            button12.Text = (hour.Next(10, 24)).ToString() + ":" + (min.Next(10, 59)).ToString();
            button13.Text = (hour.Next(10, 24)).ToString() + ":" + (min.Next(10, 59)).ToString();

        }

        private void Todaybtn_Click(object sender, EventArgs e)
        {
            if(Todaybtn.BackColor==Color.LightBlue)
            {
                Todaybtn.BackColor = Color.LightPink;
                Tommorwbtn.BackColor = Color.LightBlue;
                DATbtn.BackColor = Color.LightBlue;

                groupBox1.Enabled = true;
                DateTime TD = DateTime.Now;
                //Properties.Settings.Default.Date = string.Empty;
                Properties.Settings.Default.Date = TD.ToString("dd/MM/yyyy");
                testlbl.Text = "Selected Date: " + Properties.Settings.Default.Date;

                Randomizetime();

            }
            
               
           



        }

        private void Tommorwbtn_Click(object sender, EventArgs e)
        {
            if (Tommorwbtn.BackColor == Color.LightBlue)
            {
                Tommorwbtn.BackColor = Color.LightPink;
                Todaybtn.BackColor = Color.LightBlue;
                DATbtn.BackColor = Color.LightBlue;

                groupBox1.Enabled = true;
                DateTime TOM = DateTime.Now.AddDays(1);
                // Properties.Settings.Default.Date = string.Empty;
                Properties.Settings.Default.Date = TOM.ToString("dd/MM/yyyy");
                testlbl.Text = "Selected Date: " + Properties.Settings.Default.Date;

                Randomizetime();
            }

            
        }

        private void DATbtn_Click(object sender, EventArgs e)
        {
            if (DATbtn.BackColor == Color.LightBlue)
            {

                DATbtn.BackColor = Color.LightPink;
                Tommorwbtn.BackColor = Color.LightBlue;
                Todaybtn.BackColor = Color.LightBlue;


                groupBox1.Enabled = true;
                DateTime DAT = DateTime.Now.AddDays(2);
                // Properties.Settings.Default.Date = string.Empty;
                Properties.Settings.Default.Date = DAT.ToString("dd/MM/yyyy");
                testlbl.Text ="Selected Date: "+ Properties.Settings.Default.Date;

                Randomizetime();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            


            if (button1.BackColor == Color.LightBlue && (Properties.Settings.Default.Location == string.Empty) && (Properties.Settings.Default.Type == string.Empty) && (Properties.Settings.Default.Timing == string.Empty))
            {

                button1.BackColor = Color.LightPink;
                Properties.Settings.Default.Location = "Dubai Mall";
                Properties.Settings.Default.Type = "Standard";
                Properties.Settings.Default.Timing = button1.Text;
                confirmbtn.Enabled = true;
                //label8.Text = Properties.Settings.Default.Timing;

            }

            else if (button1.BackColor == Color.LightPink)
            {

                button1.BackColor = Color.LightBlue;
                Properties.Settings.Default.Location = string.Empty;
                Properties.Settings.Default.Type = string.Empty;
                Properties.Settings.Default.Timing = string.Empty;
                confirmbtn.Enabled = false;
                //label8.Text = Properties.Settings.Default.Timing;
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            


            if (button2.BackColor == Color.LightBlue && (Properties.Settings.Default.Location == string.Empty) && (Properties.Settings.Default.Type == string.Empty) && (Properties.Settings.Default.Timing == string.Empty))
            {

                button2.BackColor = Color.LightPink;
                Properties.Settings.Default.Location = "Dubai Mall";
                Properties.Settings.Default.Type = "Standard";
                Properties.Settings.Default.Timing = button2.Text;
                confirmbtn.Enabled = true;
                //label8.Text = Properties.Settings.Default.Timing;

            }

            else if (button2.BackColor == Color.LightPink)
            {

                button2.BackColor = Color.LightBlue;
                Properties.Settings.Default.Location = string.Empty;
                Properties.Settings.Default.Type = string.Empty;
                Properties.Settings.Default.Timing = string.Empty;
                confirmbtn.Enabled = false;
                //label8.Text = Properties.Settings.Default.Timing;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.LightBlue && (Properties.Settings.Default.Location == string.Empty) && (Properties.Settings.Default.Type == string.Empty) && (Properties.Settings.Default.Timing == string.Empty))
            {

                button3.BackColor = Color.LightPink;
                Properties.Settings.Default.Location = "Dubai Mall";
                Properties.Settings.Default.Type = "Standard";
                Properties.Settings.Default.Timing = button3.Text;
                confirmbtn.Enabled = true;

            }

            else if (button3.BackColor == Color.LightPink)
            {

                button3.BackColor = Color.LightBlue;
                Properties.Settings.Default.Location = string.Empty;
                Properties.Settings.Default.Type = string.Empty;
                Properties.Settings.Default.Timing = string.Empty;
                confirmbtn.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.LightBlue && (Properties.Settings.Default.Location == string.Empty) && (Properties.Settings.Default.Type == string.Empty) && (Properties.Settings.Default.Timing == string.Empty))
            {

                button7.BackColor = Color.LightPink;
                Properties.Settings.Default.Location = "Dubai Mall";
                Properties.Settings.Default.Type = "Standard";
                Properties.Settings.Default.Timing = button7.Text;
                confirmbtn.Enabled = true;
            }

            else if (button7.BackColor == Color.LightPink)
            {

                button7.BackColor = Color.LightBlue;
                Properties.Settings.Default.Location = string.Empty;
                Properties.Settings.Default.Type = string.Empty;
                Properties.Settings.Default.Timing = string.Empty;
                confirmbtn.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.LightBlue && (Properties.Settings.Default.Location == string.Empty) && (Properties.Settings.Default.Type == string.Empty) && (Properties.Settings.Default.Timing == string.Empty))
            {
                button4.BackColor = Color.LightPink;
                Properties.Settings.Default.Location = "Dubai Mall";
                Properties.Settings.Default.Type = "Platinum";
                Properties.Settings.Default.Timing = button4.Text;
                confirmbtn.Enabled = true;
            }

            else if (button4.BackColor == Color.LightPink)
            {

                button4.BackColor = Color.LightBlue;
                Properties.Settings.Default.Location = string.Empty;
                Properties.Settings.Default.Type = string.Empty;
                Properties.Settings.Default.Timing = string.Empty;
                confirmbtn.Enabled = false;
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (button5.BackColor == Color.LightBlue && (Properties.Settings.Default.Location == string.Empty) && (Properties.Settings.Default.Type == string.Empty) && (Properties.Settings.Default.Timing == string.Empty))
            {
                button5.BackColor = Color.LightPink;
                Properties.Settings.Default.Location = "Dubai Mall";
                Properties.Settings.Default.Type = "Platinum";
                Properties.Settings.Default.Timing = button5.Text;
                confirmbtn.Enabled = true;
            }

            else if (button5.BackColor == Color.LightPink)
            {

                button5.BackColor = Color.LightBlue;
                Properties.Settings.Default.Location = string.Empty;
                Properties.Settings.Default.Type = string.Empty;
                Properties.Settings.Default.Timing = string.Empty;
                confirmbtn.Enabled = false;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (button6.BackColor == Color.LightBlue && (Properties.Settings.Default.Location == string.Empty) && (Properties.Settings.Default.Type == string.Empty) && (Properties.Settings.Default.Timing == string.Empty))
            {
                button6.BackColor = Color.LightPink;
                Properties.Settings.Default.Location = "Dubai Mall";
                Properties.Settings.Default.Type = "Platinum";
                Properties.Settings.Default.Timing = button6.Text;
                confirmbtn.Enabled = true;
            }

            else if (button6.BackColor == Color.LightPink)
            {

                button6.BackColor = Color.LightBlue;
                Properties.Settings.Default.Location = string.Empty;
                Properties.Settings.Default.Type = string.Empty;
                Properties.Settings.Default.Timing = string.Empty;
                confirmbtn.Enabled = false;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (button8.BackColor == Color.LightBlue && (Properties.Settings.Default.Location == string.Empty) && (Properties.Settings.Default.Type == string.Empty) && (Properties.Settings.Default.Timing == string.Empty))
            {
                button8.BackColor = Color.LightPink;
                Properties.Settings.Default.Location = "Emirates Mall";
                Properties.Settings.Default.Type = "Standard";
                Properties.Settings.Default.Timing = button8.Text;
                confirmbtn.Enabled = true;
            }

            else if (button8.BackColor == Color.LightPink)
            {

                button8.BackColor = Color.LightBlue;
                Properties.Settings.Default.Location = string.Empty;
                Properties.Settings.Default.Type = string.Empty;
                Properties.Settings.Default.Timing = string.Empty;
                confirmbtn.Enabled = false;
            }


           

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.LightBlue && (Properties.Settings.Default.Location == string.Empty) && (Properties.Settings.Default.Type == string.Empty) && (Properties.Settings.Default.Timing == string.Empty))
            {
                button9.BackColor = Color.LightPink;
                Properties.Settings.Default.Location = "Emirates Mall";
                Properties.Settings.Default.Type = "Standard";
                Properties.Settings.Default.Timing = button9.Text;
                confirmbtn.Enabled = true;
            }

            else if (button9.BackColor == Color.LightPink)
            {

                button9.BackColor = Color.LightBlue;
                Properties.Settings.Default.Location = string.Empty;
                Properties.Settings.Default.Type = string.Empty;
                Properties.Settings.Default.Timing = string.Empty;
                confirmbtn.Enabled = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.LightBlue && (Properties.Settings.Default.Location == string.Empty) && (Properties.Settings.Default.Type == string.Empty) && (Properties.Settings.Default.Timing == string.Empty))
            {
                button13.BackColor = Color.LightPink;
                Properties.Settings.Default.Location = "Emirates Mall";
                Properties.Settings.Default.Type = "Standard";
                Properties.Settings.Default.Timing = button13.Text;
                confirmbtn.Enabled = true;
            }

            else if (button13.BackColor == Color.LightPink)
            {

                button13.BackColor = Color.LightBlue;
                Properties.Settings.Default.Location = string.Empty;
                Properties.Settings.Default.Type = string.Empty;
                Properties.Settings.Default.Timing = string.Empty;
                confirmbtn.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.LightBlue && (Properties.Settings.Default.Location == string.Empty) && (Properties.Settings.Default.Type == string.Empty) && (Properties.Settings.Default.Timing == string.Empty))
            {
                button12.BackColor = Color.LightPink;
                Properties.Settings.Default.Location = "Emirates Mall";
                Properties.Settings.Default.Type = "Standard";
                Properties.Settings.Default.Timing = button12.Text;
                confirmbtn.Enabled = true;
            }

            else if (button12.BackColor == Color.LightPink)
            {

                button12.BackColor = Color.LightBlue;
                Properties.Settings.Default.Location = string.Empty;
                Properties.Settings.Default.Type = string.Empty;
                Properties.Settings.Default.Timing = string.Empty;
                confirmbtn.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.LightBlue && (Properties.Settings.Default.Location == string.Empty) && (Properties.Settings.Default.Type == string.Empty) && (Properties.Settings.Default.Timing == string.Empty))
            {
                button11.BackColor = Color.LightPink;
                Properties.Settings.Default.Location = "Emirates Mall";
                Properties.Settings.Default.Type = "Platinum";
                Properties.Settings.Default.Timing = button11.Text;
                confirmbtn.Enabled = true;
            }

            else if (button11.BackColor == Color.LightPink)
            {

                button11.BackColor = Color.LightBlue;
                Properties.Settings.Default.Location = string.Empty;
                Properties.Settings.Default.Type = string.Empty;
                Properties.Settings.Default.Timing = string.Empty;
                confirmbtn.Enabled = false;
            }



            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.LightBlue && (Properties.Settings.Default.Location == string.Empty) && (Properties.Settings.Default.Type == string.Empty) && (Properties.Settings.Default.Timing == string.Empty))
            {
                button10.BackColor = Color.LightPink;
                Properties.Settings.Default.Location = "Emirates Mall";
                Properties.Settings.Default.Type = "Platinum";
                Properties.Settings.Default.Timing = button10.Text;
                confirmbtn.Enabled = true;
            }

            else if (button10.BackColor == Color.LightPink)
            {

                button10.BackColor = Color.LightBlue;
                Properties.Settings.Default.Location = string.Empty;
                Properties.Settings.Default.Type = string.Empty;
                Properties.Settings.Default.Timing = string.Empty;

            }
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            SeatBooking SB = new SeatBooking();
            this.Hide();
            SB.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            WhatsOn wo = new WhatsOn();
            this.Hide();
            wo.ShowDialog();
        }
    }
}
