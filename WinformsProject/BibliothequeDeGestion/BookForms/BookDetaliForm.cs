using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliothequeDeGestion.BookForms
{
    public partial class BookDetaliForm : Form
    {
        public BookDetaliForm(Book book)
        {
            InitializeComponent();
            BookBindingDataSource.DataSource = book;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
