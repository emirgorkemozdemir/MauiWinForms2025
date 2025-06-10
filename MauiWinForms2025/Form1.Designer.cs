namespace MauiWinForms2025
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
            btnTest = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            comboBox1 = new ComboBox();
            linkLabel1 = new LinkLabel();
            listBox1 = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.BackColor = SystemColors.ActiveCaption;
            btnTest.Font = new Font("Segoe UI", 12F);
            btnTest.Location = new Point(12, 12);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(109, 50);
            btnTest.TabIndex = 0;
            btnTest.Text = "Deneme";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += btnTest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.WaitCursor;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(22, 81);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 1;
            label1.Text = "label test";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(336, 31);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(356, 93);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(499, 93);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(443, 31);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(545, 31);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(22, 262);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(356, 168);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(253, 109);
            listBox1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(25, 315);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(356, 304);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 11;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 395);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(listBox1);
            Controls.Add(linkLabel1);
            Controls.Add(comboBox1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(btnTest);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Maui";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTest;
        private Label label1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private ComboBox comboBox1;
        private LinkLabel linkLabel1;
        private ListBox listBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
    }
}
