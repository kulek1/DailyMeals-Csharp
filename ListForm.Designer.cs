namespace ProjektnaPO
{
    partial class ListForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.PosilkiCOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kcalCOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proteinCOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carboCOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fatCOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PosilkiCOL,
            this.kcalCOL,
            this.proteinCOL,
            this.carboCOL,
            this.fatCOL});
            this.listView1.GridLines = true;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(39, 121);
            this.listView1.MaximumSize = new System.Drawing.Size(1015, 363);
            this.listView1.MinimumSize = new System.Drawing.Size(1015, 363);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1015, 363);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // PosilkiCOL
            // 
            this.PosilkiCOL.Text = "Nazwa posiłku";
            this.PosilkiCOL.Width = 150;
            // 
            // kcalCOL
            // 
            this.kcalCOL.Text = "Ilość kalorii";
            this.kcalCOL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kcalCOL.Width = 80;
            // 
            // proteinCOL
            // 
            this.proteinCOL.Text = "Białko";
            this.proteinCOL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // carboCOL
            // 
            this.carboCOL.Text = "Węglowodany";
            this.carboCOL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.carboCOL.Width = 80;
            // 
            // fatCOL
            // 
            this.fatCOL.Text = "Tłuszcze";
            this.fatCOL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista zapisanych posiłków";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(738, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Usuń wszystkie posiłki";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1120, 700);
            this.MinimumSize = new System.Drawing.Size(1120, 700);
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.Shown += new System.EventHandler(this.Lista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PosilkiCOL;
        private System.Windows.Forms.ColumnHeader kcalCOL;
        private System.Windows.Forms.ColumnHeader proteinCOL;
        private System.Windows.Forms.ColumnHeader carboCOL;
        private System.Windows.Forms.ColumnHeader fatCOL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}