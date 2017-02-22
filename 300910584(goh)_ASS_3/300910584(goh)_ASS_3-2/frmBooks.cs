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
            cbQuery.SelectedIndex = 0;
        }

        private void cbQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOutput.Clear();
            switch (cbQuery.SelectedIndex)
            {
                case 0:
                    var qry = from author in ctx.Authors
                          from book in author.Titles
                          orderby book.Title1, author.LastName, author.FirstName
                          select new
                          {
                              Title = book.Title1,
                              Author = author.FirstName + " " + author.LastName
                          };

                    txtOutput.AppendText("Titles and authors, sorted by title:\r\n");

                    foreach (var q in qry)
                    {
                        txtOutput.AppendText("Title: " + q.Title + "\r\nAuthor: " + q.Author + "\r\n\r\n");
                    }

                    break;
                case 1:
                    var qry2 = from author in ctx.Authors
                              from book in author.Titles
                              orderby book.Title1
                              select new
                              {
                                  Title = book.Title1,
                                  Author = author.FirstName + " " + author.LastName
                              };

                    txtOutput.AppendText("\n\nTitles and authors, sorted by title, then by author last and first name:\r\n");

                    foreach (var q in qry2)
                    {
                        txtOutput.AppendText("Title: " + q.Title + "\r\nAuthor: " + q.Author + "\r\n\r\n");
                    }

                    break;
                case 2:
                    var qry3 =
                        from book in ctx.Titles
                        orderby book.Title1
                        select new
                        {
                            Title = book.Title1,
                            Authors =
                                from author in book.Authors
                                orderby author.LastName
                                select author.FirstName + " " + author.LastName
                        };


                    txtOutput.AppendText("Authors grouped by title:\n");

                    foreach (var q in qry3)
                    {
                        txtOutput.AppendText("Title: " + q.Title + "\r\nAuthors: ");
                        foreach(var a in q.Authors)
                        {
                            txtOutput.AppendText(a + ", ");
                        }
                        txtOutput.Text.Trim();
                        txtOutput.Text.Trim(',');
                        txtOutput.AppendText("\r\n\r\n");
                    }

                    break;
                default:
                    break;
            }
        }
    }
}
