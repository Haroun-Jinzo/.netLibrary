namespace BibliothequeDeGestion.BookForms
{
    partial class BookDetaliForm
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
            Titlelbl = new Label();
            Authorlbl = new Label();
            ISBNlbl = new Label();
            PupYearlbl = new Label();
            textBox1 = new TextBox();
            BookBindingDataSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            isAvalibleBox = new CheckBox();
            ValiderBtn = new Button();
            CancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)BookBindingDataSource).BeginInit();
            SuspendLayout();
            // 
            // Titlelbl
            // 
            Titlelbl.AutoSize = true;
            Titlelbl.Location = new Point(47, 24);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(38, 20);
            Titlelbl.TabIndex = 2;
            Titlelbl.Text = "Title";
            // 
            // Authorlbl
            // 
            Authorlbl.AutoSize = true;
            Authorlbl.Location = new Point(47, 83);
            Authorlbl.Name = "Authorlbl";
            Authorlbl.Size = new Size(54, 20);
            Authorlbl.TabIndex = 3;
            Authorlbl.Text = "Author";
            // 
            // ISBNlbl
            // 
            ISBNlbl.AutoSize = true;
            ISBNlbl.Location = new Point(47, 155);
            ISBNlbl.Name = "ISBNlbl";
            ISBNlbl.Size = new Size(41, 20);
            ISBNlbl.TabIndex = 4;
            ISBNlbl.Text = "ISBN";
            // 
            // PupYearlbl
            // 
            PupYearlbl.AutoSize = true;
            PupYearlbl.Location = new Point(47, 221);
            PupYearlbl.Name = "PupYearlbl";
            PupYearlbl.Size = new Size(115, 20);
            PupYearlbl.TabIndex = 5;
            PupYearlbl.Text = "Publication year";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", BookBindingDataSource, "Title", true));
            textBox1.Location = new Point(250, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // BookBindingDataSource
            // 
            BookBindingDataSource.DataSource = typeof(Book);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", BookBindingDataSource, "Author", true));
            textBox2.Location = new Point(250, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", BookBindingDataSource, "ISBN", true));
            textBox3.Location = new Point(250, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", BookBindingDataSource, "PublicationYear", true));
            textBox4.Location = new Point(250, 221);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 11;
            // 
            // isAvalibleBox
            // 
            isAvalibleBox.AutoSize = true;
            isAvalibleBox.DataBindings.Add(new Binding("Checked", BookBindingDataSource, "IsAvailable", true));
            isAvalibleBox.Location = new Point(55, 298);
            isAvalibleBox.Name = "isAvalibleBox";
            isAvalibleBox.Size = new Size(107, 24);
            isAvalibleBox.TabIndex = 12;
            isAvalibleBox.Text = "is Available";
            isAvalibleBox.UseVisualStyleBackColor = true;
            isAvalibleBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ValiderBtn
            // 
            ValiderBtn.DialogResult = DialogResult.OK;
            ValiderBtn.Location = new Point(681, 391);
            ValiderBtn.Name = "ValiderBtn";
            ValiderBtn.Size = new Size(94, 29);
            ValiderBtn.TabIndex = 13;
            ValiderBtn.Text = "Valider";
            ValiderBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(570, 391);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(94, 29);
            CancelBtn.TabIndex = 14;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // BookDetaliForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelBtn);
            Controls.Add(ValiderBtn);
            Controls.Add(isAvalibleBox);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(PupYearlbl);
            Controls.Add(ISBNlbl);
            Controls.Add(Authorlbl);
            Controls.Add(Titlelbl);
            Name = "BookDetaliForm";
            Text = "BookDetaliForm";
            ((System.ComponentModel.ISupportInitialize)BookBindingDataSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label Titlelbl;
        private Label Authorlbl;
        private Label ISBNlbl;
        private Label PupYearlbl;
        private Label isAvailablelbl;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private CheckBox isAvalibleBox;
        private Button ValiderBtn;
        private Button CancelBtn;
        private BindingSource BookBindingDataSource;
    }
}