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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            SubmitForm f = new SubmitForm();
            f.Show();
        }

        private void CaseBtn_Click(object sender, EventArgs e)
        {
            CasesForm f = new CasesForm();
            f.Show();
        }
    }
}
