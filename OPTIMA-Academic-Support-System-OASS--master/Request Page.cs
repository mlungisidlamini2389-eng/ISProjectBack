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
    public partial class Request_Page : Form
    {
        public Request_Page()
        {
            InitializeComponent();
        }

        private void btnCancelRequest_Click(object sender, EventArgs e)
        {
            Student_Dashboard student_dashboard = new Student_Dashboard();

            this.Hide();

            student_dashboard.ShowDialog();

            this.Show();
        }

        private void cmbProgrammeOfStudy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCourseCode.Items.Clear();

            if (cmbProgrammeOfStudy.SelectedItem == null)
            {
                return;
            }

            string programme = cmbProgrammeOfStudy.SelectedItem.ToString();

            if (programme == "Bachelor of Science")
            {
                cmbCourseCode.Items.Add("COMS1015A");
                cmbCourseCode.Items.Add("COMS1016A");
                cmbCourseCode.Items.Add("COMS1017A");
                cmbCourseCode.Items.Add("COMS1018A");
                cmbCourseCode.Items.Add("COMS2002A");
                cmbCourseCode.Items.Add("COMS2004A");
                cmbCourseCode.Items.Add("COMS2013A");
                cmbCourseCode.Items.Add("COMS2014A");
                cmbCourseCode.Items.Add("COMS2015A");
                cmbCourseCode.Items.Add("COMS3003A");
                cmbCourseCode.Items.Add("COMS3005A");
                cmbCourseCode.Items.Add("COMS3006A");
                cmbCourseCode.Items.Add("COMS3007A");
                cmbCourseCode.Items.Add("COMS3008A");
                cmbCourseCode.Items.Add("COMS3009A");
                cmbCourseCode.Items.Add("COMS3010A");
                cmbCourseCode.Items.Add("COMS3011A");
                cmbCourseCode.Items.Add("INFO1003A");
                cmbCourseCode.Items.Add("INFO1004A");
                cmbCourseCode.Items.Add("INFO2000A");
                cmbCourseCode.Items.Add("INFO2001A");
                cmbCourseCode.Items.Add("INFO3002A");
                cmbCourseCode.Items.Add("INFO3003A");
                cmbCourseCode.Items.Add("MATH1034A");
                cmbCourseCode.Items.Add("MATH1036A");
                cmbCourseCode.Items.Add("MATH2001A");
                cmbCourseCode.Items.Add("MATH2007A");
                cmbCourseCode.Items.Add("MATH2015A");
                cmbCourseCode.Items.Add("MATH2016A");
                cmbCourseCode.Items.Add("MATH2019A");
                cmbCourseCode.Items.Add("STAT2012A");
                cmbCourseCode.Items.Add("APPM1026A");
                cmbCourseCode.Items.Add("APPM1028A");
                cmbCourseCode.Items.Add("APPM1030A");
                cmbCourseCode.Items.Add("APPM2021A");
                cmbCourseCode.Items.Add("APPM2023A");
                cmbCourseCode.Items.Add("APPM2025A");




            }
            else if (programme == "Bachelor of Commerce in Information Systems")
            {
                cmbCourseCode.Items.Add("ACCN1006A");
                cmbCourseCode.Items.Add("APPM1004A");
                cmbCourseCode.Items.Add("BUSE2002A");
                cmbCourseCode.Items.Add("BUSE2006A");
                cmbCourseCode.Items.Add("BUSE2008A");
                cmbCourseCode.Items.Add("BUSE2012A");
                cmbCourseCode.Items.Add("BUSE2020A");
                cmbCourseCode.Items.Add("BUSE2022A");
                cmbCourseCode.Items.Add("BUSE2024A");
                cmbCourseCode.Items.Add("BUSE2025A");
                cmbCourseCode.Items.Add("BUSE2026A");
                cmbCourseCode.Items.Add("BUSE2027A");
                cmbCourseCode.Items.Add("BUSE3003A");
                cmbCourseCode.Items.Add("BUSE3016A");
                cmbCourseCode.Items.Add("BUSE3018A");
                cmbCourseCode.Items.Add("BUSE3020A");
                cmbCourseCode.Items.Add("BUSE3022A");
                cmbCourseCode.Items.Add("BUSE3024A");
                cmbCourseCode.Items.Add("BUSE3025A");
                cmbCourseCode.Items.Add("BUSE3028A");
                cmbCourseCode.Items.Add("BUSE3030A");
                cmbCourseCode.Items.Add("BUSE3032A");
                cmbCourseCode.Items.Add("BUSE3034A");
                cmbCourseCode.Items.Add("ECON1012A");
                cmbCourseCode.Items.Add("ECON1014A");
                cmbCourseCode.Items.Add("ECON1016A");
                cmbCourseCode.Items.Add("ECON1018A");
                cmbCourseCode.Items.Add("ECON2000A");
                cmbCourseCode.Items.Add("ECON2001A");
                cmbCourseCode.Items.Add("ECON3015A");
                cmbCourseCode.Items.Add("ECON3016A");
                cmbCourseCode.Items.Add("ECON3018A");
                cmbCourseCode.Items.Add("ECON3019A");
                cmbCourseCode.Items.Add("ECON3021A");
                cmbCourseCode.Items.Add("ECON3023A");
                cmbCourseCode.Items.Add("FINE2000A");
                cmbCourseCode.Items.Add("FINE2010A");
                cmbCourseCode.Items.Add("FINE3018A");
                cmbCourseCode.Items.Add("FINE3019A");
                cmbCourseCode.Items.Add("FINE3020A");
                cmbCourseCode.Items.Add("FINE3021A");
                cmbCourseCode.Items.Add("INFO1000A");
                cmbCourseCode.Items.Add("INFO1003A");
                cmbCourseCode.Items.Add("INFO2000A");
                cmbCourseCode.Items.Add("INFO2001A");
                cmbCourseCode.Items.Add("INFO3002A");
                cmbCourseCode.Items.Add("INFO3003A");
                cmbCourseCode.Items.Add("STAT1000A");
            }
        }
    }
}
