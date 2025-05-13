namespace BibliothequeDeGestion.LoanForms
{
    partial class LoanDetailForm
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
            SDlbl = new Label();
            Emaillbl = new Label();
            LNlbl = new Label();
            FNlbl = new Label();
            Cancelbl = new Button();
            Validlbl = new Button();
            label1 = new Label();
            isReturned = new CheckBox();
            loanBindingSource = new BindingSource(components);
            ReturnDate = new DateTimePicker();
            Member = new ComboBox();
            memberBindingSource = new BindingSource(components);
            comboBox1 = new ComboBox();
            bookBindingSource = new BindingSource(components);
            LoanDate = new DateTimePicker();
            sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // SDlbl
            // 
            SDlbl.AutoSize = true;
            SDlbl.Location = new Point(62, 253);
            SDlbl.Name = "SDlbl";
            SDlbl.Size = new Size(88, 20);
            SDlbl.TabIndex = 23;
            SDlbl.Text = "Return Date";
            // 
            // Emaillbl
            // 
            Emaillbl.AutoSize = true;
            Emaillbl.Location = new Point(62, 187);
            Emaillbl.Name = "Emaillbl";
            Emaillbl.Size = new Size(77, 20);
            Emaillbl.TabIndex = 22;
            Emaillbl.Text = "Loan Date";
            // 
            // LNlbl
            // 
            LNlbl.AutoSize = true;
            LNlbl.Location = new Point(63, 124);
            LNlbl.Name = "LNlbl";
            LNlbl.Size = new Size(65, 20);
            LNlbl.TabIndex = 21;
            LNlbl.Text = "Member";
            // 
            // FNlbl
            // 
            FNlbl.AutoSize = true;
            FNlbl.Location = new Point(62, 56);
            FNlbl.Name = "FNlbl";
            FNlbl.Size = new Size(43, 20);
            FNlbl.TabIndex = 20;
            FNlbl.Text = "Book";
            FNlbl.Click += FNlbl_Click;
            // 
            // Cancelbl
            // 
            Cancelbl.DialogResult = DialogResult.Cancel;
            Cancelbl.Location = new Point(576, 501);
            Cancelbl.Name = "Cancelbl";
            Cancelbl.Size = new Size(131, 52);
            Cancelbl.TabIndex = 29;
            Cancelbl.Text = "Cancel";
            Cancelbl.UseVisualStyleBackColor = true;
            // 
            // Validlbl
            // 
            Validlbl.DialogResult = DialogResult.OK;
            Validlbl.Location = new Point(752, 501);
            Validlbl.Name = "Validlbl";
            Validlbl.Size = new Size(123, 52);
            Validlbl.TabIndex = 28;
            Validlbl.Text = "Valider";
            Validlbl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 325);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 30;
            label1.Text = "isReturned";
            label1.Click += label1_Click;
            // 
            // isReturned
            // 
            isReturned.AutoSize = true;
            isReturned.DataBindings.Add(new Binding("CheckState", loanBindingSource, "IsReturned", true));
            isReturned.Location = new Point(309, 327);
            isReturned.Margin = new Padding(3, 4, 3, 4);
            isReturned.Name = "isReturned";
            isReturned.Size = new Size(18, 17);
            isReturned.TabIndex = 32;
            isReturned.UseVisualStyleBackColor = true;
            // 
            // loanBindingSource
            // 
            loanBindingSource.DataSource = typeof(Loan);
            // 
            // ReturnDate
            // 
            ReturnDate.DataBindings.Add(new Binding("DataContext", loanBindingSource, "ReturnDate", true));
            ReturnDate.DataBindings.Add(new Binding("Value", loanBindingSource, "ReturnDate", true));
            ReturnDate.Location = new Point(265, 253);
            ReturnDate.Margin = new Padding(3, 4, 3, 4);
            ReturnDate.Name = "ReturnDate";
            ReturnDate.Size = new Size(228, 27);
            ReturnDate.TabIndex = 33;
            // 
            // Member
            // 
            Member.DataSource = memberBindingSource;
            Member.DisplayMember = "FirstName";
            Member.FormattingEnabled = true;
            Member.Location = new Point(265, 120);
            Member.Margin = new Padding(3, 4, 3, 4);
            Member.Name = "Member";
            Member.Size = new Size(151, 28);
            Member.TabIndex = 38;
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(Member);
            // 
            // comboBox1
            // 
            comboBox1.DataSource = bookBindingSource;
            comboBox1.DisplayMember = "Title";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(265, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 39;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // LoanDate
            // 
            LoanDate.DataBindings.Add(new Binding("DataContext", loanBindingSource, "LoanDate", true));
            LoanDate.DataBindings.Add(new Binding("Value", loanBindingSource, "LoanDate", true));
            LoanDate.Location = new Point(265, 187);
            LoanDate.Margin = new Padding(3, 4, 3, 4);
            LoanDate.Name = "LoanDate";
            LoanDate.Size = new Size(228, 27);
            LoanDate.TabIndex = 34;
            // 
            // sqlConnection1
            // 
            sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // LoanDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(comboBox1);
            Controls.Add(Member);
            Controls.Add(LoanDate);
            Controls.Add(ReturnDate);
            Controls.Add(isReturned);
            Controls.Add(label1);
            Controls.Add(Cancelbl);
            Controls.Add(Validlbl);
            Controls.Add(SDlbl);
            Controls.Add(Emaillbl);
            Controls.Add(LNlbl);
            Controls.Add(FNlbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoanDetailForm";
            Text = "LoanDetailForm";
            Load += LoanDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label SDlbl;
        private Label Emaillbl;
        private Label LNlbl;
        private Label FNlbl;
        private Button Cancelbl;
        private Button Validlbl;
        private Label label1;
        private CheckBox isReturned;
        private DateTimePicker ReturnDate;
        private ComboBox Member;
        private BindingSource loanBindingSource;
        private BindingSource memberBindingSource;
        private ComboBox comboBox1;
        private BindingSource bookBindingSource;
        private DateTimePicker LoanDate;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
    }
}