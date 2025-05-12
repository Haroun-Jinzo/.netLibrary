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
using Microsoft.Extensions.DependencyInjection;
using BibliothequeDeGestion.Repositories;
using BibliothequeDeGestion.BookForms;

namespace BibliothequeDeGestion.Forms
{
    public partial class MemberManagementForm : Form
    {

        private readonly LibraryContext _db = new LibraryContext();
        private IServiceProvider _serviceProvider;
        private MemberDetailForm _MemberDetailForm;

        public MemberManagementForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
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

        private void BookList_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void ReloadData()
        {
            using (var repoMember = _serviceProvider.GetRequiredService<MemberRepository>())
            {
                memberBindingSource.DataSource = repoMember.GetAllMembers();
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            var newMember = new Member();
            var dialogForm = new MemberDetailForm(newMember);
            var dialogResult = dialogForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                using (var repoMember = _serviceProvider.GetRequiredService<MemberRepository>())
                {
                    repoMember.AddMember(newMember);
                }
            }
            ReloadData();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            var member = memberBindingSource.Current as Member;
            if (member != null)
            {
                var dialogForm = new MemberDetailForm(member);
                var dialogResult = dialogForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    using (var repoMember = _serviceProvider.GetRequiredService<MemberRepository>())
                    {
                        repoMember.UpdateMember(member);
                    }
                }
            }
            ReloadData();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            var member = memberBindingSource.Current as Member;
            if (member != null)
            {
                var dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette catégorie ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    using (var repoMember = _serviceProvider.GetRequiredService<MemberRepository>())
                    {
                        repoMember.DeleteMember(member.Id);
                    }
                }
            }
            ReloadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
