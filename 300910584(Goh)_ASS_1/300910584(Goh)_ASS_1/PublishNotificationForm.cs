using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300910584_Goh__ASS_1
{
    public partial class PublishNotificationForm : Form
    {
        public PublishNotificationForm()
        {
            InitializeComponent();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            string notif = txtContent.Text;
            Global.MyPublisher.PublishMessage(notif);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
