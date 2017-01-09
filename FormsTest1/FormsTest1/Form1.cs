using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
        

        private void label1_LocationChanged(object sender, EventArgs e)
        {
            label1.Text = "X = " + label1.Location.X + ", Y = " + label1.Location.Y;
        }

        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            label1.Location = Cursor.Position;
        }

        private void label1_DragOver(object sender, DragEventArgs e)
        {
            label1.Location = Cursor.Position;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            label1.Text = "W = " + Form1.ActiveForm.Width + ", H = " + Form1.ActiveForm.Height;
        }
    }
}
