using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliothequeDeGestion.Forms
{
    public partial class MemberManagementForm : Form
    {

        private readonly LibraryContext _db = new LibraryContext();

        public MemberManagementForm()
        {
            InitializeComponent();
            LoadMembers();
        }

        private void MemberManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadMembers()
        {
            //dgvMembers.DataSource = _db.Members.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*_db.Members.Add(new Member
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text
            });
            _db.SaveChanges();
            LoadMembers();*/
        }
    }
}
