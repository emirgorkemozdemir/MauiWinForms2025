namespace MauiWinForms2025
{
    partial class Giris
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
            label2 = new Label();
            label1 = new Label();
            btnGiris = new Button();
            tboxSifre = new TextBox();
            tboxKullaniciAdi = new TextBox();
            btnGo = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 113);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 9;
            label2.Text = "Şifre Giriniz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 38);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 8;
            label1.Text = "Kullanıcı Adınızı Giriniz";
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(129, 177);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(113, 33);
            btnGiris.TabIndex = 7;
            btnGiris.Text = "Giris Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // tboxSifre
            // 
            tboxSifre.Location = new Point(66, 131);
            tboxSifre.Name = "tboxSifre";
            tboxSifre.PasswordChar = '*';
            tboxSifre.PlaceholderText = "Buraya şifre giriniz";
            tboxSifre.Size = new Size(241, 23);
            tboxSifre.TabIndex = 6;
            // 
            // tboxKullaniciAdi
            // 
            tboxKullaniciAdi.Location = new Point(66, 62);
            tboxKullaniciAdi.Name = "tboxKullaniciAdi";
            tboxKullaniciAdi.PlaceholderText = "Kullanıcı adı giriniz";
            tboxKullaniciAdi.Size = new Size(241, 23);
            tboxKullaniciAdi.TabIndex = 5;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(129, 231);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(113, 33);
            btnGo.TabIndex = 10;
            btnGo.Text = "Kayıt Sayfasına Git";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 294);
            Controls.Add(btnGo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGiris);
            Controls.Add(tboxSifre);
            Controls.Add(tboxKullaniciAdi);
            Name = "Giris";
            Text = "Giris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnGiris;
        private TextBox tboxSifre;
        private TextBox tboxKullaniciAdi;
        private Button btnGo;
    }
}