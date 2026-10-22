using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPTIMA_Academic_Support_System_OASS_
{
    public partial class Create_Account : Form
    {
        public Create_Account()
        {
            InitializeComponent();
        }

        private void btnBackToHomePage_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();

            this.Hide();

            homePage.ShowDialog();

            this.Show();
        }
    }
}
