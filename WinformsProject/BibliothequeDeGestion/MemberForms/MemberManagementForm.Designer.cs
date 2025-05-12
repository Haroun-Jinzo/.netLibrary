namespace BibliothequeDeGestion.Forms
{
    partial class MemberManagementForm
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
            panel2 = new Panel();
            ActualiserBtn = new Button();
            SupprimerBtn = new Button();
            AjouterBtn = new Button();
            ModifierBtn = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subscriptionDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memberBindingSource = new BindingSource(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(ActualiserBtn);
            panel2.Controls.Add(SupprimerBtn);
            panel2.Controls.Add(AjouterBtn);
            panel2.Controls.Add(ModifierBtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(194, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(1);
            panel2.Size = new Size(606, 131);
            panel2.TabIndex = 3;
            // 
            // ActualiserBtn
            // 
            ActualiserBtn.Location = new Point(466, 50);
            ActualiserBtn.Name = "ActualiserBtn";
            ActualiserBtn.Size = new Size(94, 29);
            ActualiserBtn.TabIndex = 8;
            ActualiserBtn.Text = "Actualiser";
            ActualiserBtn.UseVisualStyleBackColor = true;
            ActualiserBtn.Click += BookList_Load;
            // 
            // SupprimerBtn
            // 
            SupprimerBtn.Location = new Point(328, 50);
            SupprimerBtn.Name = "SupprimerBtn";
            SupprimerBtn.Size = new Size(94, 29);
            SupprimerBtn.TabIndex = 7;
            SupprimerBtn.Text = "Supprimer";
            SupprimerBtn.UseVisualStyleBackColor = true;
            SupprimerBtn.Click += Supprimer_Click;
            // 
            // AjouterBtn
            // 
            AjouterBtn.Location = new Point(35, 50);
            AjouterBtn.Name = "AjouterBtn";
            AjouterBtn.Size = new Size(94, 29);
            AjouterBtn.TabIndex = 5;
            AjouterBtn.Text = "Ajouter";
            AjouterBtn.UseVisualStyleBackColor = true;
            AjouterBtn.Click += Ajouter_Click;
            // 
            // ModifierBtn
            // 
            ModifierBtn.Location = new Point(189, 50);
            ModifierBtn.Name = "ModifierBtn";
            ModifierBtn.Size = new Size(94, 29);
            ModifierBtn.TabIndex = 6;
            ModifierBtn.Text = "Modifier";
            ModifierBtn.UseVisualStyleBackColor = true;
            ModifierBtn.Click += Modifier_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(194, 450);
            panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, subscriptionDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = memberBindingSource;
            dataGridView1.Location = new Point(194, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(606, 188);
            dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // subscriptionDateDataGridViewTextBoxColumn
            // 
            subscriptionDateDataGridViewTextBoxColumn.DataPropertyName = "SubscriptionDate";
            subscriptionDateDataGridViewTextBoxColumn.HeaderText = "SubscriptionDate";
            subscriptionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            subscriptionDateDataGridViewTextBoxColumn.Name = "subscriptionDateDataGridViewTextBoxColumn";
            subscriptionDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(Member);
            // 
            // MemberManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MemberManagementForm";
            Text = "MemberManagementForm";
            Load += MemberManagementForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subscriptionDateDataGridViewTextBoxColumn;
        private BindingSource memberBindingSource;
        private Button ActualiserBtn;
        private Button SupprimerBtn;
        private Button AjouterBtn;
        private Button ModifierBtn;
    }
}