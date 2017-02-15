﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayQueryResult
{
    public partial class Form1 : Form
    {
        private BookExamples.BooksEntities ctx = new BookExamples.BooksEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctx.Titles.Load();
            titleBindingSource.DataSource = ctx.Titles.Local;

            cbQueries.SelectedIndex = 0;
        }

        private void cbQueries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
