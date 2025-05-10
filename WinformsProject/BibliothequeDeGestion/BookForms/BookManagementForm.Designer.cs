namespace BibliothequeDeGestion.Forms
{
    partial class BookManagementForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            ActualiserBtn = new Button();
            SupprimerBtn = new Button();
            ModifierBtn = new Button();
            AjouterBtn = new Button();
            panel1 = new Panel();
            bookBindingSource = new BindingSource(components);
            bookDataGrid = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            publicationYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isAvailableDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookDataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(ActualiserBtn);
            panel2.Controls.Add(SupprimerBtn);
            panel2.Controls.Add(ModifierBtn);
            panel2.Controls.Add(AjouterBtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(194, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(1);
            panel2.Size = new Size(606, 81);
            panel2.TabIndex = 3;
            // 
            // ActualiserBtn
            // 
            ActualiserBtn.Location = new Point(477, 26);
            ActualiserBtn.Name = "ActualiserBtn";
            ActualiserBtn.Size = new Size(94, 29);
            ActualiserBtn.TabIndex = 3;
            ActualiserBtn.Text = "Actualiser";
            ActualiserBtn.UseVisualStyleBackColor = true;
            ActualiserBtn.Click += BookList_Load;
            // 
            // SupprimerBtn
            // 
            SupprimerBtn.Location = new Point(339, 26);
            SupprimerBtn.Name = "SupprimerBtn";
            SupprimerBtn.Size = new Size(94, 29);
            SupprimerBtn.TabIndex = 2;
            SupprimerBtn.Text = "Supprimer";
            SupprimerBtn.UseVisualStyleBackColor = true;
            SupprimerBtn.Click += Supprimer_Click;
            // 
            // ModifierBtn
            // 
            ModifierBtn.Location = new Point(200, 26);
            ModifierBtn.Name = "ModifierBtn";
            ModifierBtn.Size = new Size(94, 29);
            ModifierBtn.TabIndex = 1;
            ModifierBtn.Text = "Modifier";
            ModifierBtn.UseVisualStyleBackColor = true;
            ModifierBtn.Click += Modifier_Click;
            // 
            // AjouterBtn
            // 
            AjouterBtn.Location = new Point(46, 26);
            AjouterBtn.Name = "AjouterBtn";
            AjouterBtn.Size = new Size(94, 29);
            AjouterBtn.TabIndex = 0;
            AjouterBtn.Text = "Ajouter";
            AjouterBtn.UseVisualStyleBackColor = true;
            AjouterBtn.Click += Ajouter_Click;
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
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // bookDataGrid
            // 
            bookDataGrid.AutoGenerateColumns = false;
            bookDataGrid.BorderStyle = BorderStyle.None;
            bookDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Cyan;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            bookDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            bookDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookDataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, authorDataGridViewTextBoxColumn, iSBNDataGridViewTextBoxColumn, publicationYearDataGridViewTextBoxColumn, isAvailableDataGridViewCheckBoxColumn });
            bookDataGrid.DataSource = bookBindingSource;
            bookDataGrid.Dock = DockStyle.Fill;
            bookDataGrid.EnableHeadersVisualStyles = false;
            bookDataGrid.Location = new Point(194, 81);
            bookDataGrid.Margin = new Padding(0);
            bookDataGrid.Name = "bookDataGrid";
            bookDataGrid.RowHeadersWidth = 51;
            bookDataGrid.Size = new Size(606, 369);
            bookDataGrid.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 40;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 85;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            authorDataGridViewTextBoxColumn.HeaderText = "Author";
            authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            authorDataGridViewTextBoxColumn.Width = 85;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            iSBNDataGridViewTextBoxColumn.Width = 95;
            // 
            // publicationYearDataGridViewTextBoxColumn
            // 
            publicationYearDataGridViewTextBoxColumn.DataPropertyName = "PublicationYear";
            publicationYearDataGridViewTextBoxColumn.HeaderText = "PublicationYear";
            publicationYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            publicationYearDataGridViewTextBoxColumn.Name = "publicationYearDataGridViewTextBoxColumn";
            publicationYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // isAvailableDataGridViewCheckBoxColumn
            // 
            isAvailableDataGridViewCheckBoxColumn.DataPropertyName = "IsAvailable";
            isAvailableDataGridViewCheckBoxColumn.HeaderText = "IsAvailable";
            isAvailableDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isAvailableDataGridViewCheckBoxColumn.Name = "isAvailableDataGridViewCheckBoxColumn";
            isAvailableDataGridViewCheckBoxColumn.ReadOnly = true;
            isAvailableDataGridViewCheckBoxColumn.Width = 125;
            // 
            // BookManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bookDataGrid);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "BookManagementForm";
            Text = "BookManagementForm";
            Load += BookManagementForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private BindingSource bookBindingSource;
        private DataGridView bookDataGrid;
        private Button ActualiserBtn;
        private Button SupprimerBtn;
        private Button ModifierBtn;
        private Button AjouterBtn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publicationYearDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAvailableDataGridViewCheckBoxColumn;
    }
}