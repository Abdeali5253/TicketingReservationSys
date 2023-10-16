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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void UNtxt_TextChanged(object sender, EventArgs e)
        {
            const string FilePath = @"D:\Semester 2\OOP Lab\Cinema reservation system\TicketingReservationSys\TicketingReservationSys\TicketingReservationSys\Username.txt ";
            

            StreamReader RecieveUsername = new StreamReader(FilePath);

            string line;

            while((line = RecieveUsername.ReadLine())!=null)
            {
                if(UNtxt.Text==line)
                {
                    UNstatuslbl.Text = "Success!";
                    UNstatuslbl.ForeColor = Color.Green;
                    break;
                }
                
                
            }

            if(!(UNtxt.Text == line))
            {
                UNstatuslbl.Text = "Username Does not Exist!";
                UNstatuslbl.ForeColor = Color.Red;
            }

            RecieveUsername.Close();
           


        }

       

        int LineNo = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            LineNo = 0;
            const string FilePath = @"G:\Username.txt ";

            StreamReader RecieveUsername = new StreamReader(FilePath);

            string line;

            while ((line = RecieveUsername.ReadLine()) != null)
            {
                if (UNtxt.Text == line)
                {
                    Properties.Settings.Default.Linenumber = LineNo;
                    break;
                }
                LineNo++;

            }

            if (!(UNtxt.Text == line))
            {
                /////
            }

            RecieveUsername.Close();


            ///////////////////////
            const string FilePath1 = @"G:\Password.txt";
            StreamReader RecievePassword = new StreamReader(FilePath1);

            string line1;
            int i = 0;//counter

            for (i = 0; i < LineNo;i++)
                RecievePassword.ReadLine();

            line1 = RecievePassword.ReadLine();
            
                if (PWtxt.Text == line1)
                {
                    PWstatuslbl.Text = "Success!";
                    PWstatuslbl.ForeColor = Color.Green;
                    RecievePassword.Close();
                    RecieveUsername.Close();
                    Home hp = new Home();
                    this.Hide();
                    hp.ShowDialog();

            }

                      
            if (!(PWtxt.Text == line1))
            {
                PWstatuslbl.Text = "Password Doesnt Match the Username!";
                PWstatuslbl.ForeColor = Color.Red;
                MessageBox.Show("Password Does not match the Username!");
            }
            RecievePassword.Close();
            RecieveUsername.Close();

           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm suf = new SignupForm();
            this.Hide();
            suf.ShowDialog();
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(PWtxt.UseSystemPasswordChar == true)
            {
                PWtxt.UseSystemPasswordChar = false;
            }
            if(PWtxt.UseSystemPasswordChar == false)
            {
                PWtxt.UseSystemPasswordChar = true;
            }
        }
    }

    
    
}
