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
            components = new System.ComponentModel.Container();
            textBox4 = new TextBox();
            memberBindingSource = new BindingSource(components);
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SDlbl = new Label();
            Emaillbl = new Label();
            LNlbl = new Label();
            FNlbl = new Label();
            ValiderBtn = new Button();
            CancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", memberBindingSource, "SubscriptionDate", true));
            textBox4.Location = new Point(259, 233);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 19;
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(Member);
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", memberBindingSource, "Email", true));
            textBox3.Location = new Point(259, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", memberBindingSource, "LastName", true));
            textBox2.Location = new Point(259, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", memberBindingSource, "FirstName", true));
            textBox1.Location = new Point(259, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // SDlbl
            // 
            SDlbl.AutoSize = true;
            SDlbl.Location = new Point(56, 233);
            SDlbl.Name = "SDlbl";
            SDlbl.Size = new Size(127, 20);
            SDlbl.TabIndex = 15;
            SDlbl.Text = "Subscribtion Date";
            // 
            // Emaillbl
            // 
            Emaillbl.AutoSize = true;
            Emaillbl.Location = new Point(56, 167);
            Emaillbl.Name = "Emaillbl";
            Emaillbl.Size = new Size(51, 20);
            Emaillbl.TabIndex = 14;
            Emaillbl.Text = "EMAIL";
            // 
            // LNlbl
            // 
            LNlbl.AutoSize = true;
            LNlbl.Location = new Point(57, 104);
            LNlbl.Name = "LNlbl";
            LNlbl.Size = new Size(79, 20);
            LNlbl.TabIndex = 13;
            LNlbl.Text = "Last Name";
            // 
            // FNlbl
            // 
            FNlbl.AutoSize = true;
            FNlbl.Location = new Point(56, 36);
            FNlbl.Name = "FNlbl";
            FNlbl.Size = new Size(80, 20);
            FNlbl.TabIndex = 12;
            FNlbl.Text = "First Name";
            // 
            // ValiderBtn
            // 
            ValiderBtn.DialogResult = DialogResult.OK;
            ValiderBtn.Location = new Point(681, 396);
            ValiderBtn.Name = "ValiderBtn";
            ValiderBtn.Size = new Size(94, 29);
            ValiderBtn.TabIndex = 20;
            ValiderBtn.Text = "Valider";
            ValiderBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            CancelBtn.DialogResult = DialogResult.Cancel;
            CancelBtn.Location = new Point(571, 396);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(94, 29);
            CancelBtn.TabIndex = 21;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // MemberDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(CancelBtn);
            Controls.Add(ValiderBtn);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(SDlbl);
            Controls.Add(Emaillbl);
            Controls.Add(LNlbl);
            Controls.Add(FNlbl);
            Name = "MemberDetailForm";
            Text = "MemberDetailForm";
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label SDlbl;
        private Label Emaillbl;
        private Label LNlbl;
        private Label FNlbl;
        private BindingSource memberBindingSource;
        private Button ValiderBtn;
        private Button CancelBtn;
    }
}