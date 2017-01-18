using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFormat
{
    public partial class Form1 : Form
    {
        ToolStripMenuItem curritem;

        public Form1()
        {
            InitializeComponent();

            curritem = blackToolStripMenuItem;
            processColor(blackToolStripMenuItem);
        }

        private void processColor(ToolStripMenuItem t)
        {
            curritem.Checked = false;
            curritem = t;
            curritem.Checked = true;
        }
        

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processColor(blackToolStripMenuItem);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processColor(redToolStripMenuItem);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processColor(blueToolStripMenuItem);
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processColor(yellowToolStripMenuItem);
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processColor(greenToolStripMenuItem);

            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button.Equals(MouseButtons.Right))
            {
                ColorDialog dlg = new ColorDialog();
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    lblSample.ForeColor = dlg.Color;
                }
            }
            else if (e.Button.Equals(MouseButtons.Left))
            {
                FontDialog dlg = new FontDialog();
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    lblSample.Font = dlg.Font;
                }
            }
        }
    }
}
