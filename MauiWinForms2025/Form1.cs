namespace MauiWinForms2025
{
    public partial class Form1 : Form
    {
        // Constructor : class y�klenirken ger�ekle�ecek olaylar� belirler.
        public Form1()
        {
            // Initialize component : Form �zerindeki bile�enlerin tasar�m�n� ve �zelliklerini ayarlar.
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
            MessageBox.Show("�u anki se�ili �ge : " + comboBox1.SelectedItem.ToString());
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba! butona t�kland�");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("checkbox'�n i�areti kald�r�l�yor");
            }
            else
            {
                MessageBox.Show("checkbox i�aretleniyor");
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("�u anda textbox'ta �u yaz�yor : " + textBox1.Text);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
