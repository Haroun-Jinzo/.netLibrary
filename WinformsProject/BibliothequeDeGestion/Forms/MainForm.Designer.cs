
namespace BibliothequeDeGestion.Forms
{
    partial class MainForm
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
            panel1 = new Panel();
            LoanBtn = new Button();
            MemberBtn = new Button();
            BookBtn = new Button();
            panel2 = new Panel();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(LoanBtn);
            panel1.Controls.Add(MemberBtn);
            panel1.Controls.Add(BookBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(194, 1013);
            panel1.TabIndex = 0;
            // 
            // LoanBtn
            // 
            LoanBtn.Location = new Point(18, 370);
            LoanBtn.Name = "LoanBtn";
            LoanBtn.Size = new Size(146, 40);
            LoanBtn.TabIndex = 2;
            LoanBtn.Text = "Loans";
            LoanBtn.UseVisualStyleBackColor = true;
            // 
            // MemberBtn
            // 
            MemberBtn.Location = new Point(18, 263);
            MemberBtn.Name = "MemberBtn";
            MemberBtn.Size = new Size(146, 41);
            MemberBtn.TabIndex = 1;
            MemberBtn.Text = "Members";
            MemberBtn.UseVisualStyleBackColor = true;
            MemberBtn.Click += onMembersBtn_click;
            // 
            // BookBtn
            // 
            BookBtn.Location = new Point(18, 158);
            BookBtn.Name = "BookBtn";
            BookBtn.Size = new Size(146, 43);
            BookBtn.TabIndex = 0;
            BookBtn.Text = "Books";
            BookBtn.UseVisualStyleBackColor = true;
            BookBtn.Click += onBookBtn_click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(204, 10);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(1);
            panel2.Size = new Size(1688, 131);
            panel2.TabIndex = 1;
            // 
            // pieChart1
            // 
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(247, 154);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = double.NaN;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(500, 500);
            pieChart1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1902, 1033);
            Controls.Add(pieChart1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainForm";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button LoanBtn;
        private Button MemberBtn;
        private Button BookBtn;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
    }
}