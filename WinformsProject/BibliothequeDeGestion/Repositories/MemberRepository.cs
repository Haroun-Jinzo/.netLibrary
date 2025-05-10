using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeDeGestion.Repositories
{
    internal class MemberRepository : IDisposable
    {
        private readonly LibraryContext _context;

        public MemberRepository(LibraryContext context)
        {
            _context = context;
        }

        public IEnumerable<Member> GetAllBooks()
        {
            return _context.Members.ToList();
        }

        public Member GetBookById(int id)
        {
            return _context.Members.Find(id);
        }

        public void AddBook(Member member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();
        }

        public void UpdateBook(Member member)
        {
            _context.Members.Update(member);
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var member = _context.Members.Find(id);
            if (member != null)
            {
                _context.Members.Remove(member);
                _context.SaveChanges();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
