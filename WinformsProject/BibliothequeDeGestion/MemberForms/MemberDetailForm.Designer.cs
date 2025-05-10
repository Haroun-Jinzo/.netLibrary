namespace BibliothequeDeGestion.MemberForms
{
    partial class MemberDetailForm
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
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            PupYearlbl = new Label();
            ISBNlbl = new Label();
            Authorlbl = new Label();
            Titlelbl = new Label();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(259, 233);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 19;
            textBox4.TextChanged += this.textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(259, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 18;
            textBox3.TextChanged += this.textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += this.textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // PupYearlbl
            // 
            PupYearlbl.AutoSize = true;
            PupYearlbl.Location = new Point(56, 233);
            PupYearlbl.Name = "PupYearlbl";
            PupYearlbl.Size = new Size(115, 20);
            PupYearlbl.TabIndex = 15;
            PupYearlbl.Text = "Publication year";
            PupYearlbl.Click += this.PupYearlbl_Click;
            // 
            // ISBNlbl
            // 
            ISBNlbl.AutoSize = true;
            ISBNlbl.Location = new Point(56, 167);
            ISBNlbl.Name = "ISBNlbl";
            ISBNlbl.Size = new Size(41, 20);
            ISBNlbl.TabIndex = 14;
            ISBNlbl.Text = "ISBN";
            ISBNlbl.Click += this.ISBNlbl_Click;
            // 
            // Authorlbl
            // 
            Authorlbl.AutoSize = true;
            Authorlbl.Location = new Point(56, 95);
            Authorlbl.Name = "Authorlbl";
            Authorlbl.Size = new Size(54, 20);
            Authorlbl.TabIndex = 13;
            Authorlbl.Text = "Author";
            Authorlbl.Click += this.Authorlbl_Click;
            // 
            // Titlelbl
            // 
            Titlelbl.AutoSize = true;
            Titlelbl.Location = new Point(56, 36);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(38, 20);
            Titlelbl.TabIndex = 12;
            Titlelbl.Text = "Title";
            Titlelbl.Click += this.Titlelbl_Click;
            // 
            // MemberDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(PupYearlbl);
            Controls.Add(ISBNlbl);
            Controls.Add(Authorlbl);
            Controls.Add(Titlelbl);
            Name = "MemberDetailForm";
            Text = "MemberDetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label PupYearlbl;
        private Label ISBNlbl;
        private Label Authorlbl;
        private Label Titlelbl;
    }
}