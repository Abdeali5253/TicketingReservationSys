using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketingReservationSys;

namespace TicketingReservationSys
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }



        int count = 0;
        private void tmrImgChng_Tick(object sender, EventArgs e)
        {
            if (count < 18)
            {
                pictureBox1.Image = posters.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }
        private bool isCollapsed;
 
        private void timerDropDown_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel1.Height += 10;

                if (panel1.Size == panel1.MaximumSize)
                {
                    timerDropDown.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel1.Height -= 10;

                if (panel1.Size == panel1.MinimumSize)
                {
                    timerDropDown.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerDropDown.Start();

        }

        private void poster1_MouseHover(object sender, EventArgs e)
        {

        }
       

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void slideshow_Click(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConfirmPayment CP = new ConfirmPayment(0,0);
            this.Hide();
            CP.Show();
        }

        private void WhatsonBtn(object sender, EventArgs e)
        {
            WhatsOn wo = new WhatsOn();
            this.Hide();
            wo.ShowDialog();
        }
    }
}
