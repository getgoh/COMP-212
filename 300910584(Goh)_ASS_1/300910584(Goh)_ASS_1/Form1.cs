using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300910584_Goh__ASS_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnManage_Click(object sender, EventArgs e)
        {
            SubscribeForm form = new SubscribeForm();
            form.Show();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            PublishNotificationForm form = new PublishNotificationForm();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
