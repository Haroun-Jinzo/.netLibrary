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
            LoanDate = new DateTimePicker();
            Book = new ComboBox();
            bookBindingSource1 = new BindingSource(components);
            bookBindingSource = new BindingSource(components);
            Member = new ComboBox();
            memberBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            SuspendLayout();
            // 
            // SDlbl
            // 
            SDlbl.AutoSize = true;
            SDlbl.Location = new Point(54, 190);
            SDlbl.Name = "SDlbl";
            SDlbl.Size = new Size(69, 15);
            SDlbl.TabIndex = 23;
            SDlbl.Text = "Return Date";
            // 
            // Emaillbl
            // 
            Emaillbl.AutoSize = true;
            Emaillbl.Location = new Point(54, 140);
            Emaillbl.Name = "Emaillbl";
            Emaillbl.Size = new Size(60, 15);
            Emaillbl.TabIndex = 22;
            Emaillbl.Text = "Loan Date";
            // 
            // LNlbl
            // 
            LNlbl.AutoSize = true;
            LNlbl.Location = new Point(55, 93);
            LNlbl.Name = "LNlbl";
            LNlbl.Size = new Size(52, 15);
            LNlbl.TabIndex = 21;
            LNlbl.Text = "Member";
            // 
            // FNlbl
            // 
            FNlbl.AutoSize = true;
            FNlbl.Location = new Point(54, 42);
            FNlbl.Name = "FNlbl";
            FNlbl.Size = new Size(34, 15);
            FNlbl.TabIndex = 20;
            FNlbl.Text = "Book";
            FNlbl.Click += FNlbl_Click;
            // 
            // Cancelbl
            // 
            Cancelbl.DialogResult = DialogResult.Cancel;
            Cancelbl.Location = new Point(504, 376);
            Cancelbl.Margin = new Padding(3, 2, 3, 2);
            Cancelbl.Name = "Cancelbl";
            Cancelbl.Size = new Size(115, 39);
            Cancelbl.TabIndex = 29;
            Cancelbl.Text = "Cancel";
            Cancelbl.UseVisualStyleBackColor = true;
            // 
            // Validlbl
            // 
            Validlbl.DialogResult = DialogResult.OK;
            Validlbl.Location = new Point(658, 376);
            Validlbl.Margin = new Padding(3, 2, 3, 2);
            Validlbl.Name = "Validlbl";
            Validlbl.Size = new Size(108, 39);
            Validlbl.TabIndex = 28;
            Validlbl.Text = "Valider";
            Validlbl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 244);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 30;
            label1.Text = "isReturned";
            label1.Click += label1_Click;
            // 
            // isReturned
            // 
            isReturned.AutoSize = true;
            isReturned.DataBindings.Add(new Binding("CheckState", loanBindingSource, "IsReturned", true));
            isReturned.Location = new Point(270, 245);
            isReturned.Name = "isReturned";
            isReturned.Size = new Size(15, 14);
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
            ReturnDate.Location = new Point(232, 190);
            ReturnDate.Name = "ReturnDate";
            ReturnDate.Size = new Size(200, 23);
            ReturnDate.TabIndex = 33;
            // 
            // LoanDate
            // 
            LoanDate.DataBindings.Add(new Binding("DataContext", loanBindingSource, "LoanDate", true));
            LoanDate.Location = new Point(232, 140);
            LoanDate.Name = "LoanDate";
            LoanDate.Size = new Size(200, 23);
            LoanDate.TabIndex = 34;
            // 
            // Book
            // 
            Book.DataBindings.Add(new Binding("SelectedValue", loanBindingSource, "Book", true));
            Book.DataSource = bookBindingSource;
            Book.DisplayMember = "Title";
            Book.FormattingEnabled = true;
            Book.Location = new Point(232, 39);
            Book.Name = "Book";
            Book.Size = new Size(121, 23);
            Book.TabIndex = 37;
            // 
            // bookBindingSource1
            // 
            bookBindingSource1.DataSource = typeof(Book);
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // Member
            // 
            Member.DataBindings.Add(new Binding("SelectedValue", loanBindingSource, "Member", true));
            Member.DataSource = memberBindingSource;
            Member.DisplayMember = "FirstName";
            Member.FormattingEnabled = true;
            Member.Location = new Point(232, 90);
            Member.Name = "Member";
            Member.Size = new Size(121, 23);
            Member.TabIndex = 38;
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(Member);
            // 
            // LoanDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Member);
            Controls.Add(Book);
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
            Name = "LoanDetailForm";
            Text = "LoanDetailForm";
            Load += LoanDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
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
        private DateTimePicker LoanDate;
        private ComboBox Book;
        private ComboBox Member;
        private BindingSource loanBindingSource;
        private BindingSource bookBindingSource;
        private BindingSource memberBindingSource;
        private BindingSource bookBindingSource1;
    }
}