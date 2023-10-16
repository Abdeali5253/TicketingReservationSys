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
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace TicketingReservationSys
{
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();

        }

        private void CardNumber_Validated(object sender, EventArgs e)
        {

            if (CardNumber.Text.Substring(1) == "4")
            {
                CardTypelbl.Text = "Visa";
            }

            if (CardNumber.Text.Substring(1) == "5")
            {
                CardTypelbl.Text = "MasterCard";
            }

            if (CardNumber.Text.Substring(1) == "3")
            {
                CardTypelbl.Text = "American Express Card";
            }




        }








       
        private void button1_Click(object sender, EventArgs e)
        {
            string useremail = "";
            bool val1 = false;
            bool val2 = false;
            bool val3 = false;
            


            if (!(CardNumber.MaskCompleted))
            {
                CardTypelbl.Text = "Invalid";
                CardTypelbl.ForeColor = Color.Red;
                val1 = false;

            }
            else
            {
                CardTypelbl.Text = "Success";
                CardTypelbl.ForeColor = Color.Green;
                val1 = true;

            }

           if(MonthCB.SelectedItem==null && YearCB.SelectedItem == null)
            {
                Expirelbl.Text = "Month/Year not Selected!";
                Expirelbl.ForeColor = Color.Red;
                val2 = false;

            }

           else
            {
                Expirelbl.Text = "Success!";
                Expirelbl.ForeColor = Color.Green;
                val2 = true;


            }
            Regex r = new Regex("^[a-zA-Z ]+$");
            if (NameOnCardtxt.Text == String.Empty)
            {
                NOClbl.Text = "Feild Required!";
                NOClbl.ForeColor = Color.Red;
                val3 = false;
            }

            else if(r.IsMatch(NameOnCardtxt.Text))
            {
                NOClbl.Text = "Success!";
                NOClbl.ForeColor = Color.Green;
                val3 = true;
            }

            else
            {
                NOClbl.Text = "Invalid Input!";
                NOClbl.ForeColor = Color.Red;
                val3 = false;
            }
            

           if(val1&&val2&&val3)
            {
                const string FilePath1 = @"G:\Email.txt";
                StreamReader RecieveEmail= new StreamReader(FilePath1);

                
                int i = 0;//counter

                for (i = 0; i < Properties.Settings.Default.Linenumber; i++)
                    RecieveEmail.ReadLine();

                useremail = RecieveEmail.ReadLine();

                

               

                MailMessage mm = new MailMessage("abdeali.hazari@gmail.com", useremail);
                mm.Subject = "Booking receipt";
                mm.Body = "Thankyou! Your Payment have been confirmed. Please show this email to the cash counter when you reach the cinema for your physical tickets.\n\n" + "Movie: " + Properties.Settings.Default.Movie + "\n" + "Theatre type: " + Properties.Settings.Default.Type + "\n" + "Location: " + Properties.Settings.Default.Location + "\n" +"Standards Seat number : " + Properties.Settings.Default.Stdseats +"\n" +"Vip Seats Number: " + Properties.Settings.Default.Vipseats+"\n" + "Date: " + Properties.Settings.Default.Date + "\n" + "Timing: " + Properties.Settings.Default.Timing + "\n"; ;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                NetworkCredential nc = new NetworkCredential("abdeali.hazari@gmail.com", "786515253");
                smtp.Credentials = nc;
                smtp.EnableSsl = true;
                smtp.Send(mm);

                
                MessageBox.Show("Check Your Email " + useremail);

                smtp.Dispose();

                this.Hide();
                MessageBox.Show("Thank you for your Purchase!");
                //ConfirmPayment CP = new ConfirmPayment();

                Home h = new Home();
                h.ShowDialog();
                
            }





            }
        }
    }

