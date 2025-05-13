using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliothequeDeGestion.MemberForms;
using BibliothequeDeGestion.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BibliothequeDeGestion.LoanForms
{
    public partial class LoanManagementForm : Form
    {
        private readonly LibraryContext _db = new LibraryContext();
        private IServiceProvider _serviceProvider;

        public LoanManagementForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            LoadLoans();
        }
        private void Ajouter_Click(object sender, EventArgs e)
        {

            var newLoan = new Loan();

            var dialogForm = new LoanDetailForm(newLoan, getMembers(), getBooks());
            var dialogResult = dialogForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                using (var repoLoan = _serviceProvider.GetRequiredService<LoanRepository>())
                {
                    repoLoan.AddLoan(newLoan);
                }
            }
            ReloadData();
        }


        private IEnumerable<Member> getMembers()
        {
            using (var repoMember = _serviceProvider.GetRequiredService<MemberRepository>())
            {
                return repoMember.GetAllMembers();
            }
        }

        private IEnumerable<Book> getBooks()
        {
            using (var repoBook = _serviceProvider.GetRequiredService<BookRepository>())
            {
                return repoBook.GetAllBooks();
            }
        }

        private void ReloadData()
        {
            using (var repoLoan = _serviceProvider.GetRequiredService<LoanRepository>())
            {
                loanBindingSource.DataSource = repoLoan.GetAllLoans();
            }
        }
        private void Modifier_Click(object sender, EventArgs e)
        {
            var loan = loanBindingSource.Current as Loan;
            if (loan != null)
            {
                var dialogForm = new LoanDetailForm(loan, getMembers(), getBooks());
                var dialogResult = dialogForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    using (var repoLoan = _serviceProvider.GetRequiredService<LoanRepository>())
                    {
                        repoLoan.UpdateLoan(loan);
                    }
                }
            }
            ReloadData();
        }
        private void Supprimer_Click(object sender, EventArgs e)
        {
            var loan = loanBindingSource.Current as Loan;
            if (loan != null)
            {
                var dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette catégorie ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    using (var repoLoan = _serviceProvider.GetRequiredService<LoanRepository>())
                    {
                        repoLoan.DeleteLoan(loan.Id);
                    }
                }
            }
            ReloadData();
        }
        private void LoadLoans()
        {
            //dgvLoans.DataSource = _db.Loans.ToList();
        }

        private void LoanManagementForm_Load(object sender, EventArgs e)
        {
            ReloadData();
        }
    }
}
