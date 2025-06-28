namespace MauiWinForms2025
{
    partial class Kategoriler
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            tboxKategoriAdi = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnDuzenle = new Button();
            tboxDuzenle = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(773, 229);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 282);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Kategori Ekle";
            // 
            // tboxKategoriAdi
            // 
            tboxKategoriAdi.Location = new Point(17, 312);
            tboxKategoriAdi.Name = "tboxKategoriAdi";
            tboxKategoriAdi.Size = new Size(136, 23);
            tboxKategoriAdi.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(17, 362);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(136, 23);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Kategori Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(259, 305);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(107, 46);
            btnSil.TabIndex = 4;
            btnSil.Text = "Kategoriyi Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(598, 362);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(136, 23);
            btnDuzenle.TabIndex = 7;
            btnDuzenle.Text = "Kategori Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // tboxDuzenle
            // 
            tboxDuzenle.Location = new Point(598, 312);
            tboxDuzenle.Name = "tboxDuzenle";
            tboxDuzenle.Size = new Size(136, 23);
            tboxDuzenle.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(598, 282);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 5;
            label2.Text = "Kategori Düzenle";
            // 
            // Kategoriler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDuzenle);
            Controls.Add(tboxDuzenle);
            Controls.Add(label2);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(tboxKategoriAdi);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Kategoriler";
            Text = "Kategoriler";
            Load += Kategoriler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox tboxKategoriAdi;
        private Button btnEkle;
        private Button btnSil;
        private Button btnDuzenle;
        private TextBox tboxDuzenle;
        private Label label2;
    }
}