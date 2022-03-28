namespace EgyszamjatekGUI
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_db = new System.Windows.Forms.Label();
            this.txt_nev = new System.Windows.Forms.TextBox();
            this.txt_tipp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Játékos hozzáadása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Játékos neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Játékos tippjei";
            // 
            // lbl_db
            // 
            this.lbl_db.AutoSize = true;
            this.lbl_db.Location = new System.Drawing.Point(292, 110);
            this.lbl_db.Name = "lbl_db";
            this.lbl_db.Size = new System.Drawing.Size(27, 13);
            this.lbl_db.TabIndex = 3;
            this.lbl_db.Text = "x db";
            // 
            // txt_nev
            // 
            this.txt_nev.Location = new System.Drawing.Point(160, 61);
            this.txt_nev.Name = "txt_nev";
            this.txt_nev.Size = new System.Drawing.Size(100, 20);
            this.txt_nev.TabIndex = 4;
            // 
            // txt_tipp
            // 
            this.txt_tipp.Location = new System.Drawing.Point(160, 110);
            this.txt_tipp.Name = "txt_tipp";
            this.txt_tipp.Size = new System.Drawing.Size(100, 20);
            this.txt_tipp.TabIndex = 5;
            this.txt_tipp.TextChanged += new System.EventHandler(this.Txt_tipp_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_tipp);
            this.Controls.Add(this.txt_nev);
            this.Controls.Add(this.lbl_db);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Egyszamjatek GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_db;
        private System.Windows.Forms.TextBox txt_nev;
        private System.Windows.Forms.TextBox txt_tipp;
    }
}

