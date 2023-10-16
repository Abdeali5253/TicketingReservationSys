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


namespace TicketingReservationSys
{
    public partial class ConfirmPayment : Form
    {
        static double Total=0;

        public ConfirmPayment(int strdseat, int vipseat)
        {
            InitializeComponent();

            button1.Enabled = false;

            const string filePathStrdseats = @"G:\standardseat.txt";
            string line;

            StreamReader Stseat = new StreamReader(filePathStrdseats);
            line = Stseat.ReadToEnd();
            Seatnostrdlbl.Text = line;
            Stseat.Close();

            const string FilePathVipsteats = @"G:\vipseat.txt";
            string line2;

            StreamReader vpseat = new StreamReader(FilePathVipsteats);
            line2 = vpseat.ReadToEnd();
            seatnoviplbl.Text = line2;
            vpseat.Close();

            Typelbl.Text = Properties.Settings.Default.Type;
            Locationlbl.Text = Properties.Settings.Default.Location;
            Datelbl.Text = Properties.Settings.Default.Date;
            Timinglbl.Text = Properties.Settings.Default.Timing;
            Movielbl.Text = Properties.Settings.Default.Movie;

            if (Typelbl.Text.Equals("Platinum"))
            {
                int Totalseats = Properties.Settings.Default.Stdseats + Properties.Settings.Default.Vipseats;
                Total = (Properties.Settings.Default.Stdseats * 500) + (Properties.Settings.Default.Vipseats * 1500) + (Totalseats * 100);
                Properties.Settings.Default.Total = Total;
                Totallbl.Text = Properties.Settings.Default.Total + " PKR";
            }

            else
            {

                Total = (Properties.Settings.Default.Stdseats * 500) + (Properties.Settings.Default.Vipseats * 1500);
                Properties.Settings.Default.Total = Total;
                Totallbl.Text = Properties.Settings.Default.Total + " PKR";

            }

            if (Properties.Settings.Default.Stdseats == 0)
            {
                Seatnostrdlbl.Text = "N/A";
            }

            if (Properties.Settings.Default.Vipseats == 0)
            {
                seatnoviplbl.Text = "N/A";
            }

            if(Total != 0)
            {
                button1.Enabled = true;
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pay P = new Pay();
            this.Hide();
            P.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeatBooking sb = new SeatBooking();
            this.Hide();
            sb.ShowDialog();
        }
    }

     
    
}


