namespace Calculator
{
    partial class Calculator
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
            lblAngka1 = new Label();
            lblAngka2 = new Label();
            label1 = new Label();
            txtAngka1 = new TextBox();
            txtAngka2 = new TextBox();
            txtHasil = new TextBox();
            btnPlus = new Button();
            btnKali = new Button();
            btnMinus = new Button();
            btnBagi = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // lblAngka1
            // 
            lblAngka1.AutoSize = true;
            lblAngka1.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAngka1.Location = new Point(88, 82);
            lblAngka1.Name = "lblAngka1";
            lblAngka1.Size = new Size(209, 32);
            lblAngka1.TabIndex = 1;
            lblAngka1.Text = "Angka Pertama : ";
            // 
            // lblAngka2
            // 
            lblAngka2.AutoSize = true;
            lblAngka2.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAngka2.Location = new Point(88, 134);
            lblAngka2.Name = "lblAngka2";
            lblAngka2.Size = new Size(187, 32);
            lblAngka2.TabIndex = 2;
            lblAngka2.Text = "Angka Kedua : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 185);
            label1.Name = "label1";
            label1.Size = new Size(91, 32);
            label1.TabIndex = 3;
            label1.Text = "Hasil : ";
            // 
            // txtAngka1
            // 
            txtAngka1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAngka1.Location = new Point(303, 81);
            txtAngka1.Name = "txtAngka1";
            txtAngka1.Size = new Size(349, 37);
            txtAngka1.TabIndex = 4;
            // 
            // txtAngka2
            // 
            txtAngka2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAngka2.Location = new Point(303, 129);
            txtAngka2.Name = "txtAngka2";
            txtAngka2.Size = new Size(349, 37);
            txtAngka2.TabIndex = 5;
            // 
            // txtHasil
            // 
            txtHasil.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtHasil.Location = new Point(303, 180);
            txtHasil.Name = "txtHasil";
            txtHasil.ReadOnly = true;
            txtHasil.Size = new Size(349, 37);
            txtHasil.TabIndex = 6;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.Location = new Point(249, 285);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(84, 80);
            btnPlus.TabIndex = 7;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnKali
            // 
            btnKali.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnKali.Location = new Point(339, 285);
            btnKali.Name = "btnKali";
            btnKali.Size = new Size(84, 80);
            btnKali.TabIndex = 8;
            btnKali.Text = "*";
            btnKali.UseVisualStyleBackColor = true;
            btnKali.Click += btnKali_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.Location = new Point(249, 371);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(84, 80);
            btnMinus.TabIndex = 9;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnBagi
            // 
            btnBagi.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBagi.Location = new Point(339, 371);
            btnBagi.Name = "btnBagi";
            btnBagi.Size = new Size(84, 80);
            btnBagi.TabIndex = 10;
            btnBagi.Text = "/";
            btnBagi.UseVisualStyleBackColor = true;
            btnBagi.Click += btnBagi_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(429, 285);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(84, 166);
            btnReset.TabIndex = 11;
            btnReset.Text = "CA";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 522);
            Controls.Add(btnReset);
            Controls.Add(btnBagi);
            Controls.Add(btnMinus);
            Controls.Add(btnKali);
            Controls.Add(btnPlus);
            Controls.Add(txtHasil);
            Controls.Add(txtAngka2);
            Controls.Add(txtAngka1);
            Controls.Add(label1);
            Controls.Add(lblAngka2);
            Controls.Add(lblAngka1);
            Name = "Calculator";
            Text = "Simple Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAngka1;
        private Label lblAngka2;
        private Label label1;
        private TextBox txtAngka1;
        private TextBox txtAngka2;
        private TextBox txtHasil;
        private Button btnPlus;
        private Button btnKali;
        private Button btnMinus;
        private Button btnBagi;
        private Button btnReset;
    }
}