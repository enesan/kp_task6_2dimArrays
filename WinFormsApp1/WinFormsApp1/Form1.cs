using System.Text.Json.Nodes;
using System;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        const String errorMessage = "*Мат на Финском*";
        Random rand;
        public Form1()
        {
            InitializeComponent();
            rand = new Random(DateTime.Now.Microsecond);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            var x = Convert.ToInt32(xBox.Text);
            var y = Convert.ToInt32(yBox.Text);
            if (x < 0 || y < 0)
            {
                MessageBox.Show(errorMessage);
                return;
            }
            dataGridView1.RowCount = y;
            dataGridView1.ColumnCount = x;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[j, i].Value = rand.Next(0, 255);
                }
            }
            Recalculate();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, errorMessage);
            //}
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Convert.ToInt32(dataGridView1[e.ColumnIndex, e.RowIndex].Value);
            }
            catch
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = 0;
                MessageBox.Show(errorMessage);
            }
            Recalculate();
        }

        void Recalculate()
        {
            FindAndSetMax();
            MakeAndSetTask2();
            MakeAndSetTask3();
            MakeAndSetTask4();
            FindAndSetMin();
        }

        void FindAndSetMin()
        {
            var min = int.MaxValue;
            var x = 0;
            var y = 0;
            var isFind = false;
            var isSingle = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    var val = Convert.ToInt32(dataGridView1[j, i].Value);
                    if (val < min)
                    {
                        min = val;
                        x = j;
                        y = i;
                        isFind = true;
                        isSingle = true;
                    } else if (val == min)
                    {
                        isSingle = false;
                    }
                }
            }
            if (isFind)
            {
                task5.Text = $"Минимальный эллемент матрицы = {min}, расположен A[{y},{x}], единственный {isSingle};";
            }
            else
            {
                task5.Text = errorMessage;
            }
        }
        void MakeAndSetTask4()
        {
            var elements = new List<int>();
            var poss = 0; 
            while (true)
            {
                if (poss < dataGridView1.RowCount && poss < dataGridView1.ColumnCount){
                    elements.Add(Convert.ToInt32(dataGridView1[poss, poss].Value));
                    poss++;
                }
                else
                {
                    break;
                }
            }
            task4.Text = $"Главная диагональ: {{{string.Join(",", elements)}}}";
        }
        void MakeAndSetTask3()
        {
            var elements = new List<int>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    var val = Convert.ToInt32(dataGridView1[j, i].Value);
                    if (val%2!=0)
                    {
                        elements.Add(val);
                    }
                }
            }
            task3.Text = $"Нечетные: {{{string.Join(",",elements)}}}";
        }
        void MakeAndSetTask2()
        {
            var n = rand.Next(0, dataGridView1.ColumnCount - 1);
            var xSum = 0;
            var ySum = 0;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                xSum += Convert.ToInt32(dataGridView1[i, 0].Value);
            }
            for (int y = 0; y < dataGridView1.RowCount; y++)
            {
                ySum += Convert.ToInt32(dataGridView1[n, y].Value);
            }
            task2.Text = $"Сумма эл-мн первой строки: {xSum}, Сумма эл-мн {n}-ого столбца: {ySum}";
        }
        void FindAndSetMax()
        {
            var max = int.MinValue;
            var x = 0;
            var y = 0;
            var isFind = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    var val = Convert.ToInt32(dataGridView1[j, i].Value);
                    if (val > max)
                    {
                        max = val;
                        x = j;
                        y = i;
                        isFind = true;
                    }
                }
            }
            if (isFind)
            {
                task1.Text = $"Максимальный эллемент матрицы = {max}, расположен A[{y},{x}];";
            }
            else
            {
                task1.Text = errorMessage;
            }
        }

        private void yBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void xBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}