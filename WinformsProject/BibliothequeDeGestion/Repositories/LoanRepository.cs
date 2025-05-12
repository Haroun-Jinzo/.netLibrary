using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeDeGestion.Repositories
{
    internal class LoanRepository : IDisposable
    {
        private readonly LibraryContext _context;

        public LoanRepository(LibraryContext context)
        {
            _context = context;
        }

        public IEnumerable<Loan> GetAllLoans()
        {
            return _context.Loans.ToList();
        }

        public Loan GetLoanById(int id)
        {
            return _context.Loans.Find(id);
        }

        public void AddLoan(Loan loan)
        {
            _context.Loans.Add(loan);
            _context.SaveChanges();
        }

        public void UpdateLoan(Loan loan)
        {
            _context.Loans.Update(loan);
            _context.SaveChanges();
        }

        public void DeleteLoan(int id)
        {
            var loan = _context.Loans.Find(id);
            if (loan != null)
            {
                _context.Loans.Remove(loan);
                _context.SaveChanges();
            }
        }

        public void Dispose()
        {
          //  throw new NotImplementedException();
        }
    }
}
