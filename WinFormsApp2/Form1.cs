using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int[,] arr = new int[5, 5];


        public Form1()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            label1.Text = max.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = r.Next(10);
                }
            }

            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[0, i];
            }
            int N = r.Next(5);
            for (int k = 0; k < 5; k++)
            {
                sum = sum + arr[k, N];
            }
            label2.Text = string.Format("Сумма = {0}, случайный столбец = {1}", sum, N + 1, 5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string string_1 = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] % 2 != 0)
                    {
                        string_1 = string_1 + string.Format("{0} ", arr[i, j]);
                    }
                }
            }
            label3.Text = string_1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string string_2 = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        string_2 = string_2 + string.Format("{0} ", arr[i, j]);
                    }
                }
            }
            label4.Text = string_2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int min = 1000000000;
            int counter = 0;
            string string_3="";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] == min)
                    {
                        counter++;
                        string_3 = string_3 + string.Format("Значение элемента : {0}, индексы: {1}, {2} \n", arr[i,j], i,j);
                    }
                }
            }
            label5.Text = string_3;
        }
    }
}