using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300910584_Goh__ASS_1
{
    public partial class SubscribeForm : Form
    {
        Publisher publisher;

        public SubscribeForm()
        {
            publisher = new Publisher();
            InitializeComponent();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {

            // get inputs
            string mobileNum = txtMobile.Text;
            string email = txtEmail.Text;                        

            // check if email checkbox is checked
            if(cbEmail.Checked)
            {
                // check if email format is valid
                if (!IsEmailValid(email))
                {
                    // if not valid, show error message
                    MessageBox.Show("Error: Email address format invalid. Please follow format 'abc@def.com'");
                }
                else
                {
                    // check if email exists
                    if (emailExist(email))
                    {
                        // if email exists, show error message
                        MessageBox.Show("Error: Email '" + email + "' already subscribed.");
                    }
                    else
                    {
                        // add email to collection
                        MessageBox.Show("Email '" + email + "' subscribed.");
                        Global.EmailList.Add(new SendViaEmail(email));
                    }
                }
            }

            // check if mobile checkbox is checked
            if (cbMobile.Checked)
            {
                // check if mobile format is valid (xxx-xxx-xxxx)
                if (!Regex.Match(mobileNum, @"^(\d{3})[ -]?(\d{3})[ -]?(\d{4})").Success)
                {
                    // if not valid, show error message
                    MessageBox.Show("Mobile number format invalid. Please follow format 'xxx-xxx-xxxx'");
                }
                else
                {
                    if (mobileExist(mobileNum))
                    {
                        // if mobile exists, show error message
                        MessageBox.Show("Error: Mobile '" + mobileNum + "' already subscribed.");
                    }
                    else
                    {
                        // add mobile to collection
                        MessageBox.Show("Mobile number '" + mobileNum + "' subscribed.");
                        Global.MobileList.Add(new SendViaMobile(mobileNum));
                    }
                }
            }

            /*
            // only continue if two checkers are valid
            if(emailValid && mobileValid)
            {
                if (cbEmail.Checked)
                {
                    // check if email exists
                    if (emailExist(email))
                    {
                        // if email exists, show message and set exist checker to true
                        MessageBox.Show("Email already exists.");
                        emailExists = true;
                    }
                }
                
                if (cbMobile.Checked)
                    if(mobileExist(mobileNum))
                    {
                        // if mobile exists, show message and set exist checker to true
                        MessageBox.Show("Mobile already exists.");
                        mobileExists = true;
                    }
            }

            // continue only if email and mobile do not exist in collection
            if ((emailValid && mobileValid) && (!emailExists && !mobileExists))
            {
                if (cbEmail.Checked)
                {
                    Global.EmailList.Add(new SendViaEmail(email));
                }

                if (cbMobile.Checked)
                {
                    Global.MobileList.Add(new SendViaMobile(mobileNum));
                }
            }
            */
        }

        // test to show collections content
        public void test()
        {
            string txt = "";
            foreach(SendViaEmail em in Global.EmailList)
            {
                txt += em.getEmailAddr() + Environment.NewLine;
            }
            foreach (SendViaMobile mob in Global.MobileList)
            {
                txt += mob.getMobile() + Environment.NewLine;
            }

            MessageBox.Show(txt);
        }

        // checker if email exists in collection
        public bool emailExist(string email)
        {
            foreach(SendViaEmail e in Global.EmailList)
            {
                if(e.getEmailAddr().Equals(email))
                {
                    return true;
                }
            }

            return false;
        }

        // checker if mobile exists in collection
        public bool mobileExist(string mobile)
        {
            foreach (SendViaMobile e in Global.MobileList)
            {
                if (e.getMobile().Equals(mobile))
                {
                    return true;
                }
            }

            return false;
        }

        // email format checker
        public bool IsEmailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string mobileNum = txtMobile.Text;

            // check if email checkbox is checked
            if (cbEmail.Checked)
            {
                // check if email format is valid
                if (!IsEmailValid(email))
                {
                    // if not valid, set checker to false
                    MessageBox.Show("Error: Email address format invalid. Please follow format 'abc@def.com'");
                }
                else
                {
                    // check if email exists
                    if (emailExist(email))
                    {
                        // if email exists, show message and set exist checker to true
                        MessageBox.Show("Error: Email '" + email + "' already subscribed.");
                        Global.MobileList.Remove(new SendViaMobile(email));
                    }
                    else
                    {
                        // add email to collection
                        MessageBox.Show("Error: Email '" + email + "' is not subscribed.");
                    }
                }
            }

            // check if mobile checkbox is checked
            if (cbMobile.Checked)
            {
                // check if mobile format is valid (xxx-xxx-xxxx)
                if (!Regex.Match(mobileNum, @"^(\d{3})[ -]?(\d{3})[ -]?(\d{4})").Success)
                {
                    // if not valid, set checker to false
                    MessageBox.Show("Mobile number format invalid. Please follow format 'xxx-xxx-xxxx'");
                }
                else
                {
                    if (mobileExist(mobileNum))
                    {
                        // if mobile exists, show message and set exist checker to true
                        MessageBox.Show("Error: Mobile '" + mobileNum + "' already subscribed.");
                        Global.MobileList.Remove(new SendViaMobile(mobileNum));
                    }
                    else
                    {
                        // add mobile to collection
                        MessageBox.Show("Error: Mobile number '" + mobileNum + "' is not subscribed.");
                    }
                }
            }
        }
    }


}
