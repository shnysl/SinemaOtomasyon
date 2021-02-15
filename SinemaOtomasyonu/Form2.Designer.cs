namespace SinemaOtomasyonu
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAdSoyad = new System.Windows.Forms.TextBox();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbTCNo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rezervasyon Ekranı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "TC Kimlik Numarası :";
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Location = new System.Drawing.Point(187, 113);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(226, 26);
            this.tbAdSoyad.TabIndex = 4;
            this.tbAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAdSoyad_KeyPress);
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(455, 111);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(67, 24);
            this.rbKadin.TabIndex = 6;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(455, 158);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(68, 24);
            this.rbErkek.TabIndex = 7;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbTCNo
            // 
            this.tbTCNo.AsciiOnly = true;
            this.tbTCNo.BeepOnError = true;
            this.tbTCNo.Location = new System.Drawing.Point(186, 156);
            this.tbTCNo.Mask = "00000000000";
            this.tbTCNo.Name = "tbTCNo";
            this.tbTCNo.Size = new System.Drawing.Size(227, 26);
            this.tbTCNo.TabIndex = 10;
            this.tbTCNo.ValidatingType = typeof(int);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 256);
            this.Controls.Add(this.tbTCNo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbErkek);
            this.Controls.Add(this.rbKadin);
            this.Controls.Add(this.tbAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox tbAdSoyad;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.RadioButton rbKadin;
        public System.Windows.Forms.RadioButton rbErkek;
        public System.Windows.Forms.MaskedTextBox tbTCNo;
    }
}