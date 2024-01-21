namespace grafyy
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wszerz = new System.Windows.Forms.CheckBox();
            this.wglab = new System.Windows.Forms.CheckBox();
            this.szukanie = new System.Windows.Forms.Button();
            this.Wynik = new System.Windows.Forms.ListBox();
            this.pierwszy = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(824, 472);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj początkowy wierzchołek";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wybierz algorytm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // wszerz
            // 
            this.wszerz.AutoSize = true;
            this.wszerz.Location = new System.Drawing.Point(616, 101);
            this.wszerz.Name = "wszerz";
            this.wszerz.Size = new System.Drawing.Size(134, 17);
            this.wszerz.TabIndex = 3;
            this.wszerz.Text = "Przeszukiwanie wszerz";
            this.wszerz.UseVisualStyleBackColor = true;
            // 
            // wglab
            // 
            this.wglab.AutoSize = true;
            this.wglab.Location = new System.Drawing.Point(616, 125);
            this.wglab.Name = "wglab";
            this.wglab.Size = new System.Drawing.Size(135, 17);
            this.wglab.TabIndex = 4;
            this.wglab.Text = "Przeszukiwanie w głąb";
            this.wglab.UseVisualStyleBackColor = true;
            // 
            // szukanie
            // 
            this.szukanie.Location = new System.Drawing.Point(647, 157);
            this.szukanie.Name = "szukanie";
            this.szukanie.Size = new System.Drawing.Size(75, 23);
            this.szukanie.TabIndex = 5;
            this.szukanie.Text = "Przeszukaj";
            this.szukanie.UseVisualStyleBackColor = true;
            this.szukanie.Click += new System.EventHandler(this.szukanie_Click);
            // 
            // Wynik
            // 
            this.Wynik.FormattingEnabled = true;
            this.Wynik.Location = new System.Drawing.Point(616, 197);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(134, 95);
            this.Wynik.TabIndex = 6;
            // 
            // pierwszy
            // 
            this.pierwszy.Location = new System.Drawing.Point(638, 36);
            this.pierwszy.Name = "pierwszy";
            this.pierwszy.Size = new System.Drawing.Size(100, 20);
            this.pierwszy.TabIndex = 7;
            this.pierwszy.TextChanged += new System.EventHandler(this.pierwszy_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "CzyscGraf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "CzyscWynik";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 472);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pierwszy);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.szukanie);
            this.Controls.Add(this.wglab);
            this.Controls.Add(this.wszerz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox wszerz;
        private System.Windows.Forms.CheckBox wglab;
        private System.Windows.Forms.Button szukanie;
        private System.Windows.Forms.ListBox Wynik;
        private System.Windows.Forms.TextBox pierwszy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

