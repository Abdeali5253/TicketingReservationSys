
namespace TicketingReservationSys
{
    partial class Pay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameOnCardtxt = new System.Windows.Forms.TextBox();
            this.MonthCB = new System.Windows.Forms.ComboBox();
            this.YearCB = new System.Windows.Forms.ComboBox();
            this.CardNumber = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CardTypelbl = new System.Windows.Forms.Label();
            this.Expirelbl = new System.Windows.Forms.Label();
            this.NOClbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credit Card Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expiration Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name on the Card: ";
            // 
            // NameOnCardtxt
            // 
            this.NameOnCardtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOnCardtxt.Location = new System.Drawing.Point(360, 250);
            this.NameOnCardtxt.Name = "NameOnCardtxt";
            this.NameOnCardtxt.Size = new System.Drawing.Size(273, 31);
            this.NameOnCardtxt.TabIndex = 7;
            // 
            // MonthCB
            // 
            this.MonthCB.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthCB.FormattingEnabled = true;
            this.MonthCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.MonthCB.Location = new System.Drawing.Point(360, 163);
            this.MonthCB.MaxDropDownItems = 12;
            this.MonthCB.Name = "MonthCB";
            this.MonthCB.Size = new System.Drawing.Size(121, 35);
            this.MonthCB.TabIndex = 8;
            this.MonthCB.Text = "Month";
            // 
            // YearCB
            // 
            this.YearCB.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearCB.FormattingEnabled = true;
            this.YearCB.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041"});
            this.YearCB.Location = new System.Drawing.Point(487, 163);
            this.YearCB.MaxDropDownItems = 12;
            this.YearCB.Name = "YearCB";
            this.YearCB.Size = new System.Drawing.Size(121, 35);
            this.YearCB.TabIndex = 9;
            this.YearCB.Text = "Year";
            // 
            // CardNumber
            // 
            this.CardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumber.Location = new System.Drawing.Point(360, 65);
            this.CardNumber.Mask = "0000-0000-0000-0000";
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(248, 31);
            this.CardNumber.TabIndex = 10;
            this.CardNumber.Validated += new System.EventHandler(this.CardNumber_Validated);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(645, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Confirm and Pay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CardTypelbl
            // 
            this.CardTypelbl.AutoSize = true;
            this.CardTypelbl.Location = new System.Drawing.Point(614, 77);
            this.CardTypelbl.Name = "CardTypelbl";
            this.CardTypelbl.Size = new System.Drawing.Size(35, 13);
            this.CardTypelbl.TabIndex = 12;
            this.CardTypelbl.Text = "label1";
            // 
            // Expirelbl
            // 
            this.Expirelbl.AutoSize = true;
            this.Expirelbl.Location = new System.Drawing.Point(614, 175);
            this.Expirelbl.Name = "Expirelbl";
            this.Expirelbl.Size = new System.Drawing.Size(35, 13);
            this.Expirelbl.TabIndex = 13;
            this.Expirelbl.Text = "label1";
            // 
            // NOClbl
            // 
            this.NOClbl.AutoSize = true;
            this.NOClbl.Location = new System.Drawing.Point(639, 262);
            this.NOClbl.Name = "NOClbl";
            this.NOClbl.Size = new System.Drawing.Size(35, 13);
            this.NOClbl.TabIndex = 14;
            this.NOClbl.Text = "label1";
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 381);
            this.Controls.Add(this.NOClbl);
            this.Controls.Add(this.Expirelbl);
            this.Controls.Add(this.CardTypelbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CardNumber);
            this.Controls.Add(this.YearCB);
            this.Controls.Add(this.MonthCB);
            this.Controls.Add(this.NameOnCardtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameOnCardtxt;
        private System.Windows.Forms.ComboBox MonthCB;
        private System.Windows.Forms.ComboBox YearCB;
        private System.Windows.Forms.MaskedTextBox CardNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CardTypelbl;
        private System.Windows.Forms.Label Expirelbl;
        private System.Windows.Forms.Label NOClbl;
    }
}