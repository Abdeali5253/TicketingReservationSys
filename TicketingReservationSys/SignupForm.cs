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
using System.Text.RegularExpressions;

namespace TicketingReservationSys
{


    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e) //Once submit button is Pressed, it validates and saves data in a file.
        {
            bool Eval = true;
            bool Pval = true;
            bool PPval = true;
            bool Fval = true;
            bool Lval = true;
            bool UNval = true;


            //First name Validating
            if ((FNtxt.Text == string.Empty))
            {
                MessageBox.Show("First name Field cannot be left empty!");
                Fval = false;
            }

            else
            {
                Fval = true;
            }


            //Last name Validating
            if ((LNtxt.Text == string.Empty))
            {
                MessageBox.Show("Last name Field cannot be left empty!");
                Lval = false;
            }
            else
            {
                Lval = true;
            }

            //Username Validating
            if (UNtxt.Text == string.Empty)
            {
                MessageBox.Show("Username Field Required");
                UNval = false;

            }

            else if (UNtxt.Text.Length > 0 && UNtxt.Text.Length < 7)
            {
                MessageBox.Show("Username needs to be Greater than 6 Characters.");
                UNval = false;
            }

            else if (UNtxt.Text.Length >= 30)
            {
                MessageBox.Show("Unsername needs to be Lower than 30 Characters");
                UNval = false;
            }

            //NOW ITS checking for username existance, if it does when username clicks SAVE, then messagebox Error is shown. 
            const string filePathUsername = @"G:\Username.txt";
            string line;

            StreamReader UNread = new StreamReader(filePathUsername);

            while ((line = UNread.ReadLine()) != null)
            {
                if (UNtxt.Text.Equals(line, StringComparison.OrdinalIgnoreCase) && UNtxt.Text.Length >= 7 && UNtxt.Text.Length <= 30)
                {
                    MessageBox.Show("Username Already Exist, Please try a new one!");
                    UNval = false;
                    break;
                }
            }

            if (!(UNtxt.Text.Equals(line, StringComparison.OrdinalIgnoreCase)) && UNtxt.Text.Length >= 7 && UNtxt.Text.Length < 30)
            {
                UNval = true;
            }

            UNread.Close();
           
            //password Validating

            if (string.IsNullOrEmpty(PWtxt.Text))
            {
                MessageBox.Show("Password Field is Required");
                PPval = false;
            }
            //Checking the Condition for Password
            else if (!Regex.IsMatch(PWtxt.Text, @"^(?=(.*\d){2})(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z\d]).{8,15}$"))
            {
                MessageBox.Show("Password Condtions Do not Match!");
                PPval = false;
            }

            else
            {
                PPval = true;
            }

            //checking Re-Password Condition.
            if ((Regex.IsMatch(PWtxt.Text, @"^(?=(.*\d){2})(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z\d]).{8,15}$")) && PWtxt.Text == RePWtxt.Text)
            {
                Pval = true;
            }
            if (!((Regex.IsMatch(PWtxt.Text, @"^(?=(.*\d){2})(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z\d]).{8,15}$")) && PWtxt.Text == RePWtxt.Text))
            {
                MessageBox.Show("Confirmation Password Doesnt Match!");
                Pval = false;
            }

            //Validating Email
            if (Regex.IsMatch(EMtxt.Text, @"^(?=.*[a-zA-Z\d]).{0,20}(@)((gmail)|(yahoo)|(rediff)|(hotmail))((.com) )"))
            {
                Eval = true;

            }

            if ((!Regex.IsMatch(EMtxt.Text, @"^(?=.*[a-zA-Z\d]).{0,20}(@)((gmail)|(yahoo)|(rediff)|(hotmail))((.com))")) || (EMtxt.Text == string.Empty))
            {

                Eval = false;
                MessageBox.Show("Email entered is Incorrect!");
            }

            //If all validating is true, then Data is saved in the File.
            if ((Eval == true)&&(Pval==true)&&(PPval==true)&&(Fval==true)&&(Lval==true)&&(UNval==true))
            {


                FileInfo file = new FileInfo(@"G:\UserDetails.txt");

                //file.Create();

                StreamWriter writer = file.AppendText();
                writer.WriteLine("Username: " + FNtxt.Text);
                writer.WriteLine("FirstName: " + LNtxt.Text);
                writer.WriteLine("LastName: " + UNtxt.Text);
                writer.WriteLine("Password: " + PWtxt.Text);
                if (Malebtn.Checked)
                {
                    writer.WriteLine("Gender: Male");

                }

                if (Femalebtn.Checked)
                {
                    writer.WriteLine("Gender: Female");
                }

                writer.WriteLine("Email: " + EMtxt.Text);
                Properties.Settings.Default.Email = EMtxt.Text; //SAVES email in setting to be used fuuther in thhe program!
                writer.WriteLine(" ");

                writer.Flush();
                writer.Close();

                //entering username and passwords to another txt file to be used for verification in the later stages.

                FileInfo fileusername = new FileInfo(@"G:\Username.txt");
                StreamWriter writeusername = fileusername.AppendText(); //tells that when ever you call Writeline() command, then append.
                writeusername.WriteLine(UNtxt.Text);
                writeusername.WriteLine(" ");

                FileInfo filepassword = new FileInfo(@"G:\Password.txt");
                StreamWriter writepassword = filepassword.AppendText();
                writepassword.WriteLine(PWtxt.Text);
                writepassword.WriteLine(" ");

                FileInfo fileemail = new FileInfo(@"G:\Email.txt");
                StreamWriter writeemail = fileemail.AppendText();
                writeemail.WriteLine(EMtxt.Text);
                writeemail.WriteLine(" ");

                writeusername.Flush();
                writeusername.Close();

                writepassword.Flush();
                writepassword.Close();

                writeemail.Close();

                MessageBox.Show("Success!");

                LoginForm lg = new LoginForm();
                this.Hide();
                lg.ShowDialog();

                //DONE!!!!


            }//ending if statement



        }

        private void SignupForm_Load(object sender, EventArgs e) //events loadout when form opens
        {
            if (statuslbl.ForeColor == Color.Green)
            {
                button1.Visible = true;
            }
        }

        private void FNtxt_TextChanged(object sender, EventArgs e)
        {
            if (FNtxt.Text == string.Empty)
            {
                statuslbl.Text = "*Field Required";
                statuslbl.ForeColor = Color.Red;
                //progress.Value = 0;
            }

            else
            {
                statuslbl.Text = "Success";
                statuslbl.ForeColor = Color.Green;
                //button1.Visible = true;
                //progress.Value =7;
            }

           
        }

        private void LNtxt_TextChanged(object sender, EventArgs e)
        {

            if (LNtxt.Text == string.Empty)
            {
                statuslbl2.Text = "*Field Required";
                statuslbl2.ForeColor = Color.Red;

            }

            else
            {
                statuslbl2.Text = "Success";
                statuslbl2.ForeColor = Color.Green;
            }

           

        }

        private void UNtxt_TextChanged(object sender, EventArgs e)
        {
            if (UNtxt.Text == string.Empty)
            {
                statuslbl3.Text = "*Field Required";
                statuslbl3.ForeColor = Color.Red;

            }

            else if (UNtxt.Text.Length > 0 && UNtxt.Text.Length < 7)
            {
                statuslbl3.Text = "Username needs to be Greater than 6 characters.";
                statuslbl3.ForeColor = Color.Red;
            }

            else if (UNtxt.Text.Length >= 30)
            {
                statuslbl3.Text = "Username needs to be Lower than 30 characters!";
                statuslbl3.ForeColor = Color.Red;
            }


            //Validating its Exsistance

            const string filePathUsername = @"D:\Semester 2\OOP Lab\Cinema reservation system\TicketingReservationSys\TicketingReservationSys\TicketingReservationSys\Username.txt";
            string line;

            StreamReader UNread = new StreamReader(filePathUsername);

            //line = UNread.ReadLine();
            while ((line = UNread.ReadLine()) != null)
            {
                if (UNtxt.Text.Equals(line, StringComparison.OrdinalIgnoreCase) && UNtxt.Text.Length >= 7 && UNtxt.Text.Length <= 30)
                {
                    statuslbl3.Text = "Username Already Exist!";
                    statuslbl3.ForeColor = Color.Red;
                    break;
                }
            }

            if (!(UNtxt.Text.Equals(line, StringComparison.OrdinalIgnoreCase)) && UNtxt.Text.Length >= 7 && UNtxt.Text.Length < 30)
            {
                statuslbl3.Text = "Success";
                statuslbl3.ForeColor = Color.Green;
            }

            UNread.Close();

            
        }

        private void PWtxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PWtxt.Text))
            {
                statuslbl4.Text = "*Field Required";
                statuslbl4.ForeColor = Color.Red;
            }
            //Checking the Condition
            else if (!Regex.IsMatch(PWtxt.Text, @"^(?=(.*\d){2})(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z\d]).{8,15}$"))
            {
                statuslbl4.Text = "Conditions Invalid.";
                statuslbl4.ForeColor = Color.Red;
            }
            else
            {
                statuslbl4.Text = "Success";
                statuslbl4.ForeColor = Color.Green;
            }

            //checking seperate conditions to highlight each condition.
            if (Regex.IsMatch(PWtxt.Text, @"^(?=(.*\d){2})"))
            {
                statusp1lbl.ForeColor = Color.Green;
            }
            else
            {
                statusp1lbl.ForeColor = Color.Red;
            }
            if (Regex.IsMatch(PWtxt.Text, @"(?=.*[a-z])"))
            {
                statusp3lbl.ForeColor = Color.Green;
            }
            else
            {
                statusp3lbl.ForeColor = Color.Red;
            }
            if (Regex.IsMatch(PWtxt.Text, @"(?=.*[A-Z])"))
            {
                statusp2lbl.ForeColor = Color.Green;
            }
            else
            {
                statusp2lbl.ForeColor = Color.Red;
            }
            if (Regex.IsMatch(PWtxt.Text, @"(?=.*[^a-zA-Z\d]).{8,15}$"))
            {
                statusp4lbl.ForeColor = Color.Green;
            }
            else
            {
                statusp4lbl.ForeColor = Color.Red;
            }
            if (PWtxt.Text.Length >= 8 && PWtxt.Text.Length <= 15)
            {
                statusp5lbl.ForeColor = Color.Green;
            }
            else
            {
                statusp5lbl.ForeColor = Color.Red;
            }
            //end of each condition highlighter.

            
        }

        private void RePW_TextChanged(object sender, EventArgs e)
        {

            if ((Regex.IsMatch(PWtxt.Text, @"^(?=(.*\d){2})(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z\d]).{8,15}$")) && PWtxt.Text == RePWtxt.Text)

            {
                statuslbl5.Text = "Password Matches";
                statuslbl5.ForeColor = Color.Green;

            }
            else
            {
                statuslbl5.Text = "Password Doesn't Match!";
                statuslbl5.ForeColor = Color.Red;
            }

            
        }

        private void EMtxt_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(EMtxt.Text, @"^(?=.*[a-zA-Z\d]).{0,20}(@)((gmail)|(yahoo)|(rediff)|(hotmail) )((.com)| (nu.edu.pk))"))
            {
                statuslbl6.Text = "Email is Correct.";
                statuslbl6.ForeColor = Color.Green;
               


            }

            if (!Regex.IsMatch(EMtxt.Text, @"^(?=.*[a-zA-Z\d]).{0,20}(@)((gmail)|(yahoo)|(rediff)|(hotmail) )((.com)| (nu.edu.pk))"))
            {

                statuslbl6.Text = "Email is InCorrect.";
                statuslbl6.ForeColor = Color.Red;
            }

            if (EMtxt.Text == string.Empty)
            {
                statuslbl6.Text = "*Field is Required";
                statuslbl6.ForeColor = Color.Red;
            }

            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lgf = new LoginForm();
            this.Hide();
            lgf.ShowDialog();
            
        }
    }
    }



    


