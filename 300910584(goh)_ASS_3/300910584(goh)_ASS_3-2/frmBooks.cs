using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300910584_goh__ASS_3_2
{
    public partial class frmBooks : Form
    {
        private BooksEntities ctx = new BooksEntities();

        public frmBooks()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            
            //var query = from book in ctx.Titles
            //            orderby book.Title1
            //            select new
            //            {
            //                ISBN = book.ISBN,
            //                Title = book.Title1,
            //                Authors = book.Authors
                                      
            //            };

            //ctx.Titles.All(a => a.Authors = 

            //dgvBooks.DataSource = query.ToList();
            dgvBooks.DataSource = ctx.Titles.ToList();
            var bookz = from author in ctx.Authors
                        select new
                        {
                            Books = author.Titles
                        };
            //dgvBooks.DataSource = ctx.Authors.ToList();
            dgvBooks.DataSource = bookz.ToList();
        }
    }
}
