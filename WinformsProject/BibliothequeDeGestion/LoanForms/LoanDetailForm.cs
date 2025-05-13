using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace BibliothequeDeGestion.LoanForms
{
    public partial class LoanDetailForm : Form
    {
        public LoanDetailForm(Loan loan , IEnumerable<Member> members , IEnumerable<Book> books)
        {
            InitializeComponent();
            loanBindingSource.DataSource = loan;
            bookBindingSource.DataSource = books.Where(b => b.IsAvailable).ToList(); ; // Bind to available books
            memberBindingSource.DataSource = members.ToList();

            loan = (Loan)loanBindingSource.Current;
            if (loan.BookId != 0)
            {
                var bookExists = bookBindingSource.Cast<Book>().Any(b => b.Id == loan.BookId);
                if (!bookExists) comboBox1.SelectedIndex = -1;
            }
            if (loan.MemberId != 0)
            {
                var memberExists = memberBindingSource.Cast<Member>().Any(m => m.Id == loan.MemberId);
                if (!memberExists) Member.SelectedIndex = -1;
            }

            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = bookBindingSource; // Set DataSource FIRST

            Member.DisplayMember = "FirstName";
            Member.ValueMember = "Id";
            Member.DataSource = memberBindingSource; // Set DataSource FIRST

            // Step 3: Bind SelectedValue AFTER setting DataSource
            comboBox1.DataBindings.Add(
                "SelectedValue",
                loanBindingSource,
                "BookId",
                false,
                DataSourceUpdateMode.OnPropertyChanged // Or OnValidation
            );
            Member.DataBindings.Add(
                "SelectedValue",
                loanBindingSource,
                "MemberId",
                false,
                DataSourceUpdateMode.OnPropertyChanged
            );

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
