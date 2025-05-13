using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliothequeDeGestion.BookForms;
using BibliothequeDeGestion.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BibliothequeDeGestion.Forms
{
    public partial class BookManagementForm : Form
    {
        private readonly LibraryContext _db = new();
        private BookDetaliForm _bookDetailForm;
        private IServiceProvider _serviceProvider;

        public BookManagementForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void BookManagementForm_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            var newBook = new Book();
            var dialogForm = new BookDetaliForm(newBook);
            var dialogResult = dialogForm.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                using (var repoBook = _serviceProvider.GetRequiredService<BookRepository>())
                {
                    repoBook.AddBook(newBook);
                }
            }
            ReloadData();
        }

        private void ReloadData()
        {
            using (var repoBook = _serviceProvider.GetRequiredService<BookRepository>())
            {
                bookBindingSource.DataSource = repoBook.GetAllBooks();
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            var book = bookBindingSource.Current as Book;
            if (book != null)
            {
                var dialogForm = new BookDetaliForm(book);
                var dialogResult = dialogForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    using (var repoBook = _serviceProvider.GetRequiredService<BookRepository>())
                    {
                        repoBook.UpdateBook(book);
                    }
                }
            }
            ReloadData();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            var book = bookBindingSource.Current as Book;
            if (book != null)
            {
                var dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette catégorie ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    using (var repoBook = _serviceProvider.GetRequiredService<BookRepository>())
                    {
                        repoBook.DeleteBook(book.Id);
                    }
                }
            }
            ReloadData();
        }
    }
}
