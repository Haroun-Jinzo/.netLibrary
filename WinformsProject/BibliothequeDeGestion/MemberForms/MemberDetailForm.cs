using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliothequeDeGestion.MemberForms
{
    public partial class MemberDetailForm : Form
    {
        public MemberDetailForm(Member member)
        {
            InitializeComponent();
            memberBindingSource.DataSource = member;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
