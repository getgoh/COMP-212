using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300910584_goh__ASS_3
{
    public partial class frmBaseball : Form
    {
        private BaseballEntities ctx = new BaseballEntities();

        public frmBaseball()
        {
            InitializeComponent();
            init();
        }

        // init
        private void init()
        {
            //ctx.Players
            //    .OrderBy(player => player.LastName)
            //    .ThenBy(player => player.FirstName)
            //    .Load();

            dgvBaseball.DataSource = ctx.Players.ToList();            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string lastName = txtSearch.Text.ToUpper();

            var query = ctx.Players
                .Where(a => a.LastName.ToUpper().Contains(lastName))
                //.Where(a => a.LastName.ToUpper().Equals(lastName))
                .ToList();

            dgvBaseball.DataSource = query;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            init();
        }
    }
}
