using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliothequeDeGestion.LoanForms
{
    public partial class LoanDetailForm : Form
    {
        public LoanDetailForm(Loan loan , IEnumerable<Member> member , IEnumerable<Book> book)
        {
            InitializeComponent();
            loanBindingSource.DataSource = loan;
            bookBindingSource.DataSource = book;
            memberBindingSource.DataSource = member;
        }

        private void FNlbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoanDetailForm_Load(object sender, EventArgs e)
        {

        }

    }
}
