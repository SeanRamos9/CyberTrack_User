using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberTrack_User
{
    public partial class MainForm_User : Form
    {
        public MainForm_User()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            SubmitReport_User f = new SubmitReport_User();
            f.Show();
        }

        private void CaseBtn_Click(object sender, EventArgs e)
        {
            AllCases_User f = new AllCases_User();
            f.Show();
        }
    }
}
