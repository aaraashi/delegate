using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _300975376_Kim_ASS1
{
    public partial class Sub : Form
    {

        public Sub(Start f1, Publisher pub)
        {
            InitializeComponent();
            this.Text = "Subscribe Form";

        }

        private void Sub_Load(object sender, EventArgs e)
        {
            bool isEmpty = !Start.emailList.Any();
            if (isEmpty)
            {
                btnUnsub.Enabled = false;
            }
            else if (!isEmpty)
            {
                btnUnsub.Enabled = true;
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            // validate email input to subscribe
            if (checkEmail.Checked && this.textEmail.Text != "")
            {

                string email = this.textEmail.Text;


                {
                    if (this.textEmail.Text.LastIndexOf("@") > -1)
                    {
                      
                        if (!Start.emailList.Any(v => v.Email == email))
                        {
                            Start.emailList.Add(new SendViaEmail(email));
                            new SendViaEmail(email).Subscribe(Start.pub);
                            MessageBox.Show(email + " has been subscribed");
                            this.textEmail.Focus();
                            this.textEmail.Clear();
                            checkEmail.Checked = false;
                            lblValEmail.Text = "";
                            bool isEmptyEmail = !Start.emailList.Any();
                            if (isEmptyEmail)
                            {
                                btnUnsub.Enabled = false;
                            }
                            else if (!isEmptyEmail)
                            {
                                btnUnsub.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("The email address had been already subscribed");
                            this.textEmail.Focus();
                            this.textEmail.Clear();
                            checkEmail.Checked = false;

                        }

                    }

                    else
                    {
                        lblValEmail.Text = "Invalid format, please input valid email address format.";
                        this.textEmail.Focus();
                    }


                }

            }

            else if (!checkEmail.Checked && this.textEmail.Text != "ex) XXX@XXX.XXX")
            {
                MessageBox.Show("Please make sure that the check box is checked.");
            }

            // validate mobile input to subscribe
            if (checkMobile.Checked)
            {

                string mobile = this.textMobile.Text;

                Regex expr = new Regex(@"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$");

                if (expr.IsMatch(mobile) && textMobile.Text != "")
                {
                    if (!Start.mobileList.Contains(new SendViaMobile(mobile)))
                    {
                        Start.mobileList.Add(new SendViaMobile(mobile));
                        new SendViaMobile(mobile).Subscribe(Start.pub);
                        MessageBox.Show(mobile + " has been subscribed");
                        this.textMobile.Focus();
                        this.textMobile.Clear();
                        checkMobile.Checked = false;
                        lblValMobile.Text = "";
                        bool isEmptyMobile = !Start.mobileList.Any();
                        if (isEmptyMobile)
                        {
                            btnUnsub.Enabled = false;
                        }
                        else if (!isEmptyMobile)
                        {
                            btnUnsub.Enabled = true;
                        }
                    }
                    else if (Start.mobileList.Contains(new SendViaMobile(mobile)))
                    {
                        MessageBox.Show("The mobile number had been already subscribed");
                        this.textMobile.Focus();
                        this.textMobile.Clear();
                        checkMobile.Checked = false;

                    }
                }
                else
                {
                    lblValMobile.Text = "Invalid format, please input valid phone number format.";
                }

            }

            else if (!checkMobile.Checked && this.textMobile.Text != "ex) XXX-XXX-XXXX")
            {
                MessageBox.Show("Please make sure that the check box is checked.");
            }
        }
         
        // validate email input to unsubscribe
        // disabled when no subscribers
        private void btnUnsub_Click(object sender, EventArgs e) {
            
            
            if (checkEmail.Checked && this.textEmail.Text != "")
            {

                string email = this.textEmail.Text;


                {
                    if (this.textEmail.Text.LastIndexOf("@") > -1)
                    {
                        
                        if (Start.emailList.Any(v => v.Email == email))
                        {
                            Start.emailList.Add(new SendViaEmail(email));
                            new SendViaEmail(email).Unsubscribe(Start.pub);
                            MessageBox.Show(email + " has been unsubscribed");
                            this.textEmail.Focus();
                            this.textEmail.Clear();
                            checkEmail.Checked = false;
                            lblValEmail.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("The email address had been already unsubscribed");
                            this.textEmail.Focus();
                            this.textEmail.Clear();
                            checkEmail.Checked = false;
                        
                        }

                    }

                    else
                    {
                            lblValEmail.Text = "Invalid format, please input valid email address format.";
                            this.textEmail.Focus();
                    }


                }

            }

            else if (!checkEmail.Checked && this.textEmail.Text != "")
            {
                    MessageBox.Show("Please make sure that the check box is checked.");
            }
            
            // validate mobile input to unsubscribe
            if (checkMobile.Checked)
            {

                string mobile = this.textMobile.Text;

                Regex expr = new Regex(@"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$");

                if (expr.IsMatch(mobile) && textMobile.Text != "")
                {
                    if (Start.mobileList.Contains(new SendViaMobile(mobile)))
                    {
                        Start.mobileList.Add(new SendViaMobile(mobile));
                        new SendViaMobile(mobile).Unsubscribe(Start.pub);
                        MessageBox.Show(mobile + " has been unsubscribed");
                        this.textMobile.Focus();
                        this.textMobile.Clear();
                        checkMobile.Checked = false;
                        lblValMobile.Text = "";
                    }
                    else if (Start.mobileList.Contains(new SendViaMobile(mobile)))
                    {
                        MessageBox.Show("The mobile number had been already unsubscribed");
                        this.textMobile.Focus();
                        this.textMobile.Clear();
                        checkMobile.Checked = false;

                    }
                }
                else
                {
                    lblValMobile.Text = "Invalid format, please input valid phone number format.";
                }

            }

            else if (!checkMobile.Checked && this.textMobile.Text != "")
            {
                    MessageBox.Show("Please make sure that the check box is checked.");
            }
    }
    
    // cancel button event handler to go back to the first form 
    private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
            Start.f1.Show();
            Start.btnPub.Enabled = true;
            Start.btnSub.Enabled = false; 

        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "ex) XXX@XXX.XXX")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.Black;
            }
        }

        private void textMobile_Enter(object sender, EventArgs e)
        {
            if (textMobile.Text == "ex) XXX-XXX-XXXX")
            {
                textMobile.Text = "";
                textMobile.ForeColor = Color.Black;
            }
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
}
