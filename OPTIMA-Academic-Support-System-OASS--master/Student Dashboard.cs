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
    public partial class Student_Dashboard : Form
    {
        public Student_Dashboard()
        {
            InitializeComponent();
        }

        private void btnRequestTutoring_Click(object sender, EventArgs e)
        {
            Request_Page request_page = new Request_Page();

            this.Hide();

            request_page.ShowDialog();

            this.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Student_Dashboard student_dashboard = new Student_Dashboard();

            this.Hide();

            student_dashboard.ShowDialog();

            this.Show();
        }
    }
}
