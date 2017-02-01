using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUserControl
{
    public partial class LoginUserControl: UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        public String Username
        {
            get
            {
                return this.txtUsername.Text;
            }
        }

        public String Password
        {
            get
            {
                return this.txtPassword.Text;
            }
        }
    }
}
