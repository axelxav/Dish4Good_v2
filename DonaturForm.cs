using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Dish4Good_v2
{
    public partial class DonaturForm : Form
    {
        private int loggedInUserId;
        public DonaturForm(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        

        private void lblStatusKonfirmasiDonatur_Click(object sender, EventArgs e)
        {

        }
    }
}
