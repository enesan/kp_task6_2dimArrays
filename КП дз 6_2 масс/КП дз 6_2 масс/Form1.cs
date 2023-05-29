namespace ООП_ДЗ_2
{
    public partial class Form1 : Form
    {
        Matrix Matrix1;


        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (Convert.ToInt32(textBox1.Text) >= 3 && Convert.ToInt32(textBox1.Text) <= 5)
                && (Convert.ToInt32(textBox2.Text) >= 3 && Convert.ToInt32(textBox2.Text) <= 5))
            {
                Matrix1 = new Matrix(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            }
            else { MessageBox.Show("Вы не ввели размер матрицы или значения не сответствуют условиб m и n от 3 до 5", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void buttonZapol_Click(object sender, EventArgs e)
        {
            Matrix1.zapoln();

        }

        private void buttonVisual_Click(object sender, EventArgs e)
        {
            Matrix1.Visual(dataGridView1);
        }

        private void Max_Click_1(object sender, EventArgs e)
        {
            labelMax.Text = Matrix1.max();
        }

        private void Summ_Click(object sender, EventArgs e)
        {
            labelSum.Text = Matrix1.summ();
        }

        private void buttonNechot_Click(object sender, EventArgs e)
        {
            label2.Text = Matrix1.nechot();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = Matrix1.diognal();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            label5.Text = Matrix1.min();
        }
    }
}