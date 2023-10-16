using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketingReservationSys  //
{
    public partial class Form1 : Form
    {
        public Form1() //constructor
        {
            InitializeComponent(); //this function is initialted when form is created and creates instances of  all the things you create.
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm lgf = new LoginForm();
            this.Hide();
            lgf.ShowDialog();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            SignupForm suf = new SignupForm();
            this.Hide();
            suf.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
