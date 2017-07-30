namespace ProjektnaPO
{
    partial class Profil
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.proteinlabel = new System.Windows.Forms.Label();
            this.carbslebel = new System.Windows.Forms.Label();
            this.fatlabel = new System.Windows.Forms.Label();
            this.numericUpDownKCAL = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPROTEIN = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCARBS = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFAT = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPROTEIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCARBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFAT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calories (kcal)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // proteinlabel
            // 
            this.proteinlabel.AutoSize = true;
            this.proteinlabel.Location = new System.Drawing.Point(191, 171);
            this.proteinlabel.Name = "proteinlabel";
            this.proteinlabel.Size = new System.Drawing.Size(90, 29);
            this.proteinlabel.TabIndex = 3;
            this.proteinlabel.Text = "Protein";
            this.proteinlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // carbslebel
            // 
            this.carbslebel.AutoSize = true;
            this.carbslebel.Location = new System.Drawing.Point(191, 286);
            this.carbslebel.Name = "carbslebel";
            this.carbslebel.Size = new System.Drawing.Size(77, 29);
            this.carbslebel.TabIndex = 5;
            this.carbslebel.Text = "Carbs";
            // 
            // fatlabel
            // 
            this.fatlabel.AutoSize = true;
            this.fatlabel.Location = new System.Drawing.Point(209, 383);
            this.fatlabel.Name = "fatlabel";
            this.fatlabel.Size = new System.Drawing.Size(59, 29);
            this.fatlabel.TabIndex = 7;
            this.fatlabel.Text = "Fats";
            // 
            // numericUpDownKCAL
            // 
            this.numericUpDownKCAL.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownKCAL.Location = new System.Drawing.Point(164, 110);
            this.numericUpDownKCAL.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownKCAL.Name = "numericUpDownKCAL";
            this.numericUpDownKCAL.Size = new System.Drawing.Size(160, 35);
            this.numericUpDownKCAL.TabIndex = 9;
            this.numericUpDownKCAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownKCAL.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDownPROTEIN
            // 
            this.numericUpDownPROTEIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericUpDownPROTEIN.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPROTEIN.Location = new System.Drawing.Point(185, 218);
            this.numericUpDownPROTEIN.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownPROTEIN.Name = "numericUpDownPROTEIN";
            this.numericUpDownPROTEIN.Size = new System.Drawing.Size(120, 35);
            this.numericUpDownPROTEIN.TabIndex = 10;
            this.numericUpDownPROTEIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownCARBS
            // 
            this.numericUpDownCARBS.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCARBS.Location = new System.Drawing.Point(185, 328);
            this.numericUpDownCARBS.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownCARBS.Name = "numericUpDownCARBS";
            this.numericUpDownCARBS.Size = new System.Drawing.Size(120, 35);
            this.numericUpDownCARBS.TabIndex = 11;
            this.numericUpDownCARBS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownFAT
            // 
            this.numericUpDownFAT.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownFAT.Location = new System.Drawing.Point(185, 428);
            this.numericUpDownFAT.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownFAT.Name = "numericUpDownFAT";
            this.numericUpDownFAT.Size = new System.Drawing.Size(120, 35);
            this.numericUpDownFAT.TabIndex = 12;
            this.numericUpDownFAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 637);
            this.Controls.Add(this.numericUpDownFAT);
            this.Controls.Add(this.numericUpDownCARBS);
            this.Controls.Add(this.numericUpDownPROTEIN);
            this.Controls.Add(this.numericUpDownKCAL);
            this.Controls.Add(this.fatlabel);
            this.Controls.Add(this.carbslebel);
            this.Controls.Add(this.proteinlabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Profil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPROTEIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCARBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFAT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label proteinlabel;
        private System.Windows.Forms.Label carbslebel;
        private System.Windows.Forms.Label fatlabel;
        private System.Windows.Forms.NumericUpDown numericUpDownKCAL;
        private System.Windows.Forms.NumericUpDown numericUpDownPROTEIN;
        private System.Windows.Forms.NumericUpDown numericUpDownCARBS;
        private System.Windows.Forms.NumericUpDown numericUpDownFAT;
    }
}