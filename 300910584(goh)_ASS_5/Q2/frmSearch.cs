using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class frmSearch : Form
    {
        int[] intValues = new int[10];
        double[] doubleValues = new double[10];
        string searchStr = "";

        Random rand;

        public frmSearch()
        {
            InitializeComponent();
            rand = new Random();

            generateInt();
            generateDouble();

            displayValues();
        }

        private void displayValues()
        {
            txtDisplay.Text = "int values: ";
            txtDisplay.Text += string.Join(", ", intValues) + Environment.NewLine + Environment.NewLine;

            txtDisplay.Text += "double values: ";
            txtDisplay.Text += string.Join(", ", doubleValues) + Environment.NewLine;
        }

        private void btnGenerateInt_Click(object sender, EventArgs e)
        {
            generateInt();
        }

        private void generateInt()
        {
            for (int x = 0; x < 10; x++)
            {
                intValues[x] = rand.Next(20);
            }
            displayValues();
        }

        private void btnGenerateDouble_Click(object sender, EventArgs e)
        {
            generateDouble();
        }

        private void generateDouble()
        {
            for (int x = 0; x < 10; x++)
            {
                doubleValues[x] = Math.Round(rand.NextDouble() * 10, 2);
            }
            displayValues();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchStr = txtSearch.Text.Trim();
            int index = Search<int>(int.Parse(searchStr), intValues);
            if (index == -1)
            {
                index = Search<double>(double.Parse(searchStr), doubleValues);
                if(index == -1)
                {
                    MessageBox.Show(searchStr + " not found in int or double array");
                }
                else
                {
                    MessageBox.Show(searchStr + " found in double array at index " + index);
                }
            }
            else
            {
                MessageBox.Show(searchStr + " found in int array at index " + index);                     
            }
        }

        private int Search<T>(T searchParam, T[] array) where T : IComparable<T>
        {
            int index = -1;
            int ctr = 0;

            // search through array
            foreach(var i in array)
            {
                if(searchParam.CompareTo(i) > 0)
                {
                    index = ctr;
                    break;
                }
                ctr++;
            }
            
            return index;
        }
    }
}
