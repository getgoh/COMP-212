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

namespace MyBaseForm
{
    public partial class CentennialBaseForm : Form
    {
        public CentennialBaseForm()
        {
            InitializeComponent();
        }

        public virtual void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            //ProcessStartInfo sInfo = new ProcessStartInfo("http://www.centennialcollege.ca");
            //Process.Start(sInfo);

            try
            {
                Process.Start("CHROME.EXE", "http://www.centennialcollege.ca");
            }
            catch
            {
                Process.Start("IEXPLORE.EXE", "http://www.centennialcollege.ca");
            }
        }
    }
}
