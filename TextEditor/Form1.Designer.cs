namespace TextEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtOutput = new TextBox();
            panel1 = new Panel();
            lblOutput = new Label();
            lblCodingPlace = new Label();
            panel2 = new Panel();
            btnRun = new Button();
            txtCode = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.Black;
            txtOutput.Dock = DockStyle.Right;
            txtOutput.Enabled = false;
            txtOutput.Font = new Font("Monotype Koufi", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 178);
            txtOutput.ForeColor = Color.DimGray;
            txtOutput.Location = new Point(942, 100);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.RightToLeft = RightToLeft.No;
            txtOutput.Size = new Size(430, 539);
            txtOutput.TabIndex = 1;
            txtOutput.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblOutput);
            panel1.Controls.Add(lblCodingPlace);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1372, 100);
            panel1.TabIndex = 3;
            // 
            // lblOutput
            // 
            lblOutput.Dock = DockStyle.Left;
            lblOutput.Font = new Font("Monotype Koufi", 26.2499962F, FontStyle.Bold);
            lblOutput.Location = new Point(0, 0);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(430, 100);
            lblOutput.TabIndex = 1;
            lblOutput.Text = "النتيجة";
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodingPlace
            // 
            lblCodingPlace.Dock = DockStyle.Right;
            lblCodingPlace.Font = new Font("Monotype Koufi", 26.2499962F, FontStyle.Bold);
            lblCodingPlace.Location = new Point(507, 0);
            lblCodingPlace.Name = "lblCodingPlace";
            lblCodingPlace.Size = new Size(865, 100);
            lblCodingPlace.TabIndex = 0;
            lblCodingPlace.Text = "الكود";
            lblCodingPlace.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRun);
            panel2.Controls.Add(txtCode);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(942, 539);
            panel2.TabIndex = 4;
            // 
            // btnRun
            // 
            btnRun.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRun.FlatStyle = FlatStyle.Flat;
            btnRun.Location = new Point(846, 6);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(84, 34);
            btnRun.TabIndex = 3;
            btnRun.Text = "تشغيل";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // txtCode
            // 
            txtCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCode.AutoCompleteCustomSource.AddRange(new string[] { "لو", "اذا", "إذا", "طالما", "بينما", "كرر", "دالة", "ارجع", "أرجع", "اطبع" });
            txtCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCode.BackColor = Color.Black;
            txtCode.Font = new Font("Monotype Koufi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            txtCode.ForeColor = Color.OliveDrab;
            txtCode.Location = new Point(9, 46);
            txtCode.Multiline = true;
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "اكتب كودك";
            txtCode.ScrollBars = ScrollBars.Vertical;
            txtCode.Size = new Size(930, 481);
            txtCode.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1372, 639);
            Controls.Add(panel2);
            Controls.Add(txtOutput);
            Controls.Add(panel1);
            Font = new Font("Monotype Koufi", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 178);
            ForeColor = Color.OliveDrab;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "ضاد";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtOutput;
        private Panel panel1;
        private Label lblCodingPlace;
        private Label lblOutput;
        private Panel panel2;
        private Button btnRun;
        private TextBox txtCode;
    }
}
