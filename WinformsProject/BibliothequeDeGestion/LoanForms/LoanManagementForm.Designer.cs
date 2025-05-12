namespace BibliothequeDeGestion.LoanForms
{
    partial class LoanManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ActualiserBtn = new Button();
            SupprimerBtn = new Button();
            AjouterBtn = new Button();
            ModifierBtn = new Button();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memberIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loanDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isReturnedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            bookDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loanBindingSource = new BindingSource(components);
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ActualiserBtn
            // 
            ActualiserBtn.Location = new Point(408, 38);
            ActualiserBtn.Margin = new Padding(3, 2, 3, 2);
            ActualiserBtn.Name = "ActualiserBtn";
            ActualiserBtn.Size = new Size(82, 22);
            ActualiserBtn.TabIndex = 8;
            ActualiserBtn.Text = "Actualiser";
            ActualiserBtn.UseVisualStyleBackColor = true;
            // 
            // SupprimerBtn
            // 
            SupprimerBtn.Location = new Point(287, 38);
            SupprimerBtn.Margin = new Padding(3, 2, 3, 2);
            SupprimerBtn.Name = "SupprimerBtn";
            SupprimerBtn.Size = new Size(82, 22);
            SupprimerBtn.TabIndex = 7;
            SupprimerBtn.Text = "Supprimer";
            SupprimerBtn.UseVisualStyleBackColor = true;
            SupprimerBtn.Click += Supprimer_Click;
            // 
            // AjouterBtn
            // 
            AjouterBtn.Location = new Point(31, 38);
            AjouterBtn.Margin = new Padding(3, 2, 3, 2);
            AjouterBtn.Name = "AjouterBtn";
            AjouterBtn.Size = new Size(82, 22);
            AjouterBtn.TabIndex = 5;
            AjouterBtn.Text = "Ajouter";
            AjouterBtn.UseVisualStyleBackColor = true;
            AjouterBtn.Click += Ajouter_Click;
            // 
            // ModifierBtn
            // 
            ModifierBtn.Location = new Point(165, 38);
            ModifierBtn.Margin = new Padding(3, 2, 3, 2);
            ModifierBtn.Name = "ModifierBtn";
            ModifierBtn.Size = new Size(82, 22);
            ModifierBtn.TabIndex = 6;
            ModifierBtn.Text = "Modifier";
            ModifierBtn.UseVisualStyleBackColor = true;
            ModifierBtn.Click += Modifier_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, bookIdDataGridViewTextBoxColumn, memberIdDataGridViewTextBoxColumn, loanDateDataGridViewTextBoxColumn, returnDateDataGridViewTextBoxColumn, isReturnedDataGridViewCheckBoxColumn, bookDataGridViewTextBoxColumn, memberDataGridViewTextBoxColumn });
            dataGridView1.DataSource = loanBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(170, 98);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(630, 352);
            dataGridView1.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
            bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            // 
            // memberIdDataGridViewTextBoxColumn
            // 
            memberIdDataGridViewTextBoxColumn.DataPropertyName = "MemberId";
            memberIdDataGridViewTextBoxColumn.HeaderText = "MemberId";
            memberIdDataGridViewTextBoxColumn.Name = "memberIdDataGridViewTextBoxColumn";
            // 
            // loanDateDataGridViewTextBoxColumn
            // 
            loanDateDataGridViewTextBoxColumn.DataPropertyName = "LoanDate";
            loanDateDataGridViewTextBoxColumn.HeaderText = "LoanDate";
            loanDateDataGridViewTextBoxColumn.Name = "loanDateDataGridViewTextBoxColumn";
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            // 
            // isReturnedDataGridViewCheckBoxColumn
            // 
            isReturnedDataGridViewCheckBoxColumn.DataPropertyName = "IsReturned";
            isReturnedDataGridViewCheckBoxColumn.HeaderText = "IsReturned";
            isReturnedDataGridViewCheckBoxColumn.Name = "isReturnedDataGridViewCheckBoxColumn";
            // 
            // bookDataGridViewTextBoxColumn
            // 
            bookDataGridViewTextBoxColumn.DataPropertyName = "Book";
            bookDataGridViewTextBoxColumn.HeaderText = "Book";
            bookDataGridViewTextBoxColumn.Name = "bookDataGridViewTextBoxColumn";
            // 
            // memberDataGridViewTextBoxColumn
            // 
            memberDataGridViewTextBoxColumn.DataPropertyName = "Member";
            memberDataGridViewTextBoxColumn.HeaderText = "Member";
            memberDataGridViewTextBoxColumn.Name = "memberDataGridViewTextBoxColumn";
            // 
            // loanBindingSource
            // 
            loanBindingSource.DataSource = typeof(Loan);
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(ActualiserBtn);
            panel2.Controls.Add(SupprimerBtn);
            panel2.Controls.Add(AjouterBtn);
            panel2.Controls.Add(ModifierBtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(170, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(1);
            panel2.Size = new Size(630, 98);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(170, 450);
            panel1.TabIndex = 5;
            // 
            // LoanManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoanManagementForm";
            Text = "LoanManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ActualiserBtn;
        private Button SupprimerBtn;
        private Button AjouterBtn;
        private Button ModifierBtn;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn memberIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loanDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isReturnedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn memberDataGridViewTextBoxColumn;
        private BindingSource loanBindingSource;
    }
}