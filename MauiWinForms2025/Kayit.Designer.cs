namespace MauiWinForms2025
{
    partial class Kayit
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
            tboxKullaniciAdi = new TextBox();
            tboxSifre = new TextBox();
            btnKayit = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tboxKullaniciAdi
            // 
            tboxKullaniciAdi.Location = new Point(67, 65);
            tboxKullaniciAdi.Name = "tboxKullaniciAdi";
            tboxKullaniciAdi.PlaceholderText = "Kullanıcı adı giriniz";
            tboxKullaniciAdi.Size = new Size(241, 23);
            tboxKullaniciAdi.TabIndex = 0;
            // 
            // tboxSifre
            // 
            tboxSifre.Location = new Point(67, 134);
            tboxSifre.Name = "tboxSifre";
            tboxSifre.PasswordChar = '*';
            tboxSifre.PlaceholderText = "Buraya şifre giriniz";
            tboxSifre.Size = new Size(241, 23);
            tboxSifre.TabIndex = 1;
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(136, 205);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(113, 33);
            btnKayit.TabIndex = 2;
            btnKayit.Text = "Kayit Ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 41);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adınızı Giriniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 116);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Şifre Giriniz";
            // 
            // Kayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 291);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKayit);
            Controls.Add(tboxSifre);
            Controls.Add(tboxKullaniciAdi);
            Name = "Kayit";
            Text = "Kayit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxKullaniciAdi;
        private TextBox tboxSifre;
        private Button btnKayit;
        private Label label1;
        private Label label2;
    }
}