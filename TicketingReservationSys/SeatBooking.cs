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
    public partial class SeatBooking : Form
    {
        public SeatBooking()
        {
            InitializeComponent();

            Showtimelbl.Text = "ShowTime: "+Properties.Settings.Default.Timing;
        }

        int standardseats = 0;
        int vipseats = 0;

        private void S1btn_Click(object sender, EventArgs e)
        {
            if (S1btn.BackColor == Color.LightBlue)
            {
                S1btn.BackColor = Color.LightPink;
                standardseats++;
                standardsel.Visible = true;
                Standardlbl.Text = "X"+standardseats.ToString()+"Standard - 500 PKR per ticket";

            }

            else if (S1btn.BackColor == Color.LightPink)
            {

                S1btn.BackColor = Color.LightBlue;
                standardseats--;
             
                if (standardseats == 0)
                {
                    standardsel.Visible = false;
                    Standardlbl.Text = string.Empty;
                }
                else
                {
                    Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";
                }
            }
        }

        private void S2_Click(object sender, EventArgs e)
        {
            if (S2btn.BackColor == Color.LightBlue)
            {
                S2btn.BackColor = Color.LightPink;
                standardseats++;
                standardsel.Visible = true;
                Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";

            }

            else if (S2btn.BackColor == Color.LightPink)
            {

                S2btn.BackColor = Color.LightBlue;
                standardseats--;
               
                if (standardseats==0)
                {
                    standardsel.Visible = false;
                    Standardlbl.Text = string.Empty;
                }
                else
                {
                    Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";
                }
                                                   
             
            }


        }

        private void S3btn_Click(object sender, EventArgs e)
        {
            if (S3btn.BackColor == Color.LightBlue)
            {
                S3btn.BackColor = Color.LightPink;
                standardseats++;
                standardsel.Visible = true;
                Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";

            }

            else if (S3btn.BackColor == Color.LightPink)
            {

                S3btn.BackColor = Color.LightBlue;
                standardseats--;
                if (standardseats == 0)
                {
                    standardsel.Visible = false;
                    Standardlbl.Text = string.Empty;
                }
                else
                {
                    Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";
                }
            }
        }

        private void S4btn_Click(object sender, EventArgs e)
        {
            if (S4btn.BackColor == Color.LightBlue)
            {
                S4btn.BackColor = Color.LightPink;
                standardseats++;
                standardsel.Visible = true;
                Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";

            }

            else if (S4btn.BackColor == Color.LightPink)
            {

                S4btn.BackColor = Color.LightBlue;
                standardseats--;
                if (standardseats == 0)
                {
                    standardsel.Visible = false;
                    Standardlbl.Text = string.Empty;
                }
                else
                {
                    Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";
                }
            }

        }

        private void S6btn_Click(object sender, EventArgs e)
        {
            if (S6btn.BackColor == Color.LightBlue)
            {
                S6btn.BackColor = Color.LightPink;
                standardseats++;
                standardsel.Visible = true;
                Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";

            }

            else if (S6btn.BackColor == Color.LightPink)
            {

                S6btn.BackColor = Color.LightBlue;
                standardseats--;
                if (standardseats == 0)
                {
                    standardsel.Visible = false;
                    Standardlbl.Text = string.Empty;
                }
                else
                {
                    Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";
                }
            }


        }

        private void S7_Click(object sender, EventArgs e)
        {
            if (S7btn.BackColor == Color.LightBlue)
            {
                S7btn.BackColor = Color.LightPink;
                standardseats++;
                standardsel.Visible = true;
                Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";

            }

            else if (S7btn.BackColor == Color.LightPink)
            {

                S7btn.BackColor = Color.LightBlue;
                standardseats--;
                if (standardseats == 0)
                {
                    standardsel.Visible = false;
                    Standardlbl.Text = string.Empty;
                }
                else
                {
                    Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";
                }
            }


        }

        private void S8btn_Click(object sender, EventArgs e)
        {
            if (S8btn.BackColor == Color.LightBlue)
            {
                S8btn.BackColor = Color.LightPink;
                standardseats++;
                standardsel.Visible = true;
                Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";

            }

            else if (S8btn.BackColor == Color.LightPink)
            {

                S8btn.BackColor = Color.LightBlue;
                standardseats--;
                if (standardseats == 0)
                {
                    standardsel.Visible = false;
                    Standardlbl.Text = string.Empty;
                }
                else
                {
                    Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";
                }
            }









        }

        private void S9btn_Click(object sender, EventArgs e)
        {
            if (S9btn.BackColor == Color.LightBlue)
            {
                S9btn.BackColor = Color.LightPink;
                standardseats++;
                standardsel.Visible = true;
                Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";

            }

            else if (S9btn.BackColor == Color.LightPink)
            {

                S9btn.BackColor = Color.LightBlue;
                standardseats--;
                if (standardseats == 0)
                {
                    standardsel.Visible = false;
                    Standardlbl.Text = string.Empty;
                }
                else
                {
                    Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";
                }
            }






        }

        private void S10btn_Click(object sender, EventArgs e)
        {
            if (S10btn.BackColor == Color.LightBlue)
            {
                S10btn.BackColor = Color.LightPink;
                standardseats++;
                standardsel.Visible = true;
                Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";

            }

            else if (S10btn.BackColor == Color.LightPink)
            {

                S10btn.BackColor = Color.LightBlue;
                standardseats--;
                if (standardseats == 0)
                {
                    standardsel.Visible = false;
                    Standardlbl.Text = string.Empty;
                }
                else
                {
                    Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";
                }
            }


        }

        private void S13btn_Click(object sender, EventArgs e)
        {
            if (S13btn.BackColor == Color.LightBlue)
            {
                S13btn.BackColor = Color.LightPink;
                standardseats++;
                standardsel.Visible = true;
                Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";

            }

            else if (S13btn.BackColor == Color.LightPink)
            {

                S13btn.BackColor = Color.LightBlue;
                standardseats--;
                if (standardseats == 0)
                {
                    standardsel.Visible = false;
                    Standardlbl.Text = string.Empty;
                }
                else
                {
                    Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";
                }
            }

        }

        private void S16btn_Click(object sender, EventArgs e)
        {
            if (S16btn.BackColor == Color.LightBlue)
            {
                S16btn.BackColor = Color.LightPink;
                standardseats++;
                standardsel.Visible = true;
                Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";

            }

            else if (S16btn.BackColor == Color.LightPink)
            {

                S16btn.BackColor = Color.LightBlue;
                standardseats--;
                if (standardseats == 0)
                {
                    standardsel.Visible = false;
                    Standardlbl.Text = string.Empty;
                }
                else
                {
                    Standardlbl.Text = "X" + standardseats.ToString() + "Standard - 500 PKR per ticket";
                }
            }






        }

        private void V1btn_Click(object sender, EventArgs e)
        {
            if (V1btn.BackColor == Color.LightGreen)
            {
                V1btn.BackColor = Color.LightPink;
                vipseats++;
                vipsel.Visible = true;
                Viplbl.Text = "X" + vipseats.ToString() + "VIP - 1500 PKR per ticket";

            }

            else if (V1btn.BackColor == Color.LightPink)
            {

                V1btn.BackColor = Color.LightGreen;
                vipseats--;
                if (vipseats == 0)
                {
                    vipsel.Visible = false;
                    Viplbl.Text = string.Empty;
                }
                else
                {
                    Viplbl.Text = "X" + standardseats.ToString() + "Vip - 1500 PKR per ticket";
                }
            }





        }

        private void V2btn_Click(object sender, EventArgs e)
        {

            if (V2btn.BackColor == Color.LightGreen)
            {
                V2btn.BackColor = Color.LightPink;
                vipseats++;
                vipsel.Visible = true;
                Viplbl.Text = "X" + vipseats.ToString() + "VIP - 1500 PKR per ticket";

            }

            else if (V2btn.BackColor == Color.LightPink)
            {

                V2btn.BackColor = Color.LightGreen;
                vipseats--;
                if (vipseats == 0)
                {
                    vipsel.Visible = false;
                    Viplbl.Text = string.Empty;
                }
                else
                {
                    Viplbl.Text = "X" + standardseats.ToString() + "Vip - 1500 PKR per ticket";
                }
            }




        }

        private void V3btn_Click(object sender, EventArgs e)
        {
            if (V3btn.BackColor == Color.LightGreen)
            {
                V3btn.BackColor = Color.LightPink;
                vipseats++;
                vipsel.Visible = true;
                Viplbl.Text = "X" + vipseats.ToString() + "VIP - 1500 PKR per ticket";

            }

            else if (V3btn.BackColor == Color.LightPink)
            {

                V3btn.BackColor = Color.LightGreen;
                vipseats--;
                if (vipseats == 0)
                {
                    vipsel.Visible = false;
                    Viplbl.Text = string.Empty;
                }
                else
                {
                    Viplbl.Text = "X" + standardseats.ToString() + "Vip - 1500 PKR per ticket";
                }
            }








        }

        private void V4btn_Click(object sender, EventArgs e)
        {

            if (V4btn.BackColor == Color.LightGreen)
            {
                V4btn.BackColor = Color.LightPink;
                vipseats++;
                vipsel.Visible = true;
                Viplbl.Text = "X" + vipseats.ToString() + "VIP - 1500 PKR per ticket";

            }

            else if (V4btn.BackColor == Color.LightPink)
            {

                V4btn.BackColor = Color.LightGreen;
                vipseats--;
                if (vipseats == 0)
                {
                    vipsel.Visible = false;
                    Viplbl.Text = string.Empty;
                }
                else
                {
                    Viplbl.Text = "X" + standardseats.ToString() + "Vip - 1500 PKR per ticket";
                }
            }




        }

        private void V5btn_Click(object sender, EventArgs e)
        {
            if (V5btn.BackColor == Color.LightGreen)
            {
                V5btn.BackColor = Color.LightPink;
                vipseats++;
                vipsel.Visible = true;
                Viplbl.Text = "X" + vipseats.ToString() + "VIP - 1500 PKR per ticket";

            }

            else if (V5btn.BackColor == Color.LightPink)
            {

                V5btn.BackColor = Color.LightGreen;
                vipseats--;
                if (vipseats == 0)
                {
                    vipsel.Visible = false;
                    Viplbl.Text = string.Empty;
                }
                else
                {
                    Viplbl.Text = "X" + standardseats.ToString() + "Vip - 1500 PKR per ticket";
                }
            }





        }

        private void V6btn_Click(object sender, EventArgs e)
        {

            if (V6btn.BackColor == Color.LightGreen)
            {
                V6btn.BackColor = Color.LightPink;
                vipseats++;
                vipsel.Visible = true;
                Viplbl.Text = "X" + vipseats.ToString() + "VIP - 1500 PKR per ticket";

            }

            else if (V6btn.BackColor == Color.LightPink)
            {

                V6btn.BackColor = Color.LightGreen;
                vipseats--;
                if (vipseats == 0)
                {
                    vipsel.Visible = false;
                    Viplbl.Text = string.Empty;
                }
                else
                {
                    Viplbl.Text = "X" + standardseats.ToString() + "Vip - 1500 PKR per ticket";
                }
            }

        }

        private void V8btn_Click(object sender, EventArgs e)
        {
            if (V8btn.BackColor == Color.LightGreen)
            {
                V8btn.BackColor = Color.LightPink;
                vipseats++;
                vipsel.Visible = true;
                Viplbl.Text = "X" + vipseats.ToString() + "VIP - 1500 PKR per ticket";

            }

            else if (V8btn.BackColor == Color.LightPink)
            {

                V8btn.BackColor = Color.LightGreen;
                vipseats--;
                if (vipseats == 0)
                {
                    vipsel.Visible = false;
                    Viplbl.Text = string.Empty;
                }
                else
                {
                    Viplbl.Text = "X" + standardseats.ToString() + "Vip - 1500 PKR per ticket";
                }
            }

        }

        private void V10btn_Click(object sender, EventArgs e)
        {
            if (V10btn.BackColor == Color.LightGreen)
            {
                V10btn.BackColor = Color.LightPink;
                vipseats++;
                vipsel.Visible = true;
                Viplbl.Text = "X" + vipseats.ToString() + "VIP - 1500 PKR per ticket";

            }

            else if (V10btn.BackColor == Color.LightPink)
            {

                V10btn.BackColor = Color.LightGreen;
                vipseats--;
                if (vipseats == 0)
                {
                    vipsel.Visible = false;
                    Viplbl.Text = string.Empty;
                }
                else
                {
                    Viplbl.Text = "X" + standardseats.ToString() + "Vip - 1500 PKR per ticket";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(standardseats==0 && vipseats==0)
            {
                MessageBox.Show("You have not selected any seats!");
            }
            else
            {
                FileInfo file = new FileInfo(@"G:\standardseat.txt");

                StreamWriter standardseat = file.CreateText();

                //WRITE basically writes all text in single line and doesnt automatically put a line terminator
                //WRITELINE puts line terminator automatically

                if(S1btn.BackColor==Color.LightPink)
                {
                    standardseat.Write("S1, ");
                }
                if(S2btn.BackColor==Color.LightPink)
                {
                   standardseat.Write("S2, ");
                }
                if (S3btn.BackColor == Color.LightPink)
                {
                    standardseat.Write("S3, ");
                }
                if (S4btn.BackColor == Color.LightPink)
                {
                    standardseat.Write("S4, ");
                }
                if (S6btn.BackColor == Color.LightPink)
                {
                    standardseat.Write("S6, ");
                }
                if (S7btn.BackColor == Color.LightPink)
                {
                    standardseat.Write("S7, ");
                }
                if (S8btn.BackColor == Color.LightPink)
                {
                    standardseat.Write("S8, ");
                }

                standardseat.Flush();
                standardseat.Close();

                FileInfo file2 = new FileInfo(@"G:\vipseat.txt");
                StreamWriter vipseat = file2.CreateText();

                if (V1btn.BackColor == Color.LightPink)
                {
                    vipseat.Write("V1, ");
                }
                if (V2btn.BackColor == Color.LightPink)
                {
                    vipseat.Write("V2, ");
                }
                if (V3btn.BackColor == Color.LightPink)
                {
                    vipseat.Write("V3, ");
                }
                if (V4btn.BackColor == Color.LightPink)
                {
                    vipseat.Write("V4, ");
                }
                if (V5btn.BackColor == Color.LightPink)
                {
                    vipseat.Write("V5, ");
                }
                if (V6btn.BackColor == Color.LightPink)
                {
                    vipseat.Write("V6, ");
                }
                if (V8btn.BackColor == Color.LightPink)
                {
                    vipseat.Write("V7, ");
                }
                if (V10btn.BackColor == Color.LightPink)
                {
                    vipseat.Write("V8, ");
                }

                Properties.Settings.Default.Stdseats = standardseats;
                Properties.Settings.Default.Vipseats = vipseats;
                vipseat.Flush();
                vipseat.Close();

                ConfirmPayment CP = new ConfirmPayment(standardseats, vipseats);
                this.Hide();
                CP.ShowDialog();

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LocationANDTiming LAT = new LocationANDTiming();
            this.Hide();
            LAT.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LocationANDTiming LAT = new LocationANDTiming();
            this.Hide();
            LAT.ShowDialog();
        }
    }
}
