namespace MauiWinForms2025
{
    public partial class Form1 : Form
    {
        // Constructor : class yüklenirken gerçekleþecek olaylarý belirler.
        public Form1()
        {
            // Initialize component : Form üzerindeki bileþenlerin tasarýmýný ve özelliklerini ayarlar.
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba!");

            comboBox1.Items.Add("test1");
            comboBox1.Items.Add("test2");
            comboBox1.Items.Add("test3");
            comboBox1.Items.Add("test4");
            comboBox1.Items.Add("test5");
            comboBox1.SelectedIndex = 0;

            listBox1.Items.Add("listbox test 1");
            listBox1.Items.Add("listbox test 2");
            listBox1.Items.Add("listbox test 3");
            listBox1.Items.Add("listbox test 4");
            listBox1.Items.Add("listbox test 5");

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Þu anki seçili öge : " + comboBox1.SelectedItem.ToString());
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba! butona týklandý");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("checkbox'ýn iþareti kaldýrýlýyor");
            }
            else
            {
                MessageBox.Show("checkbox iþaretleniyor");
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Þu anda textbox'ta þu yazýyor : " + textBox1.Text);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
