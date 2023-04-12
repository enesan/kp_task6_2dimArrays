using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace дз6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int[,] ob;
        int row, col;

        private void create_arr_Click(object sender, EventArgs e)
        {
            ob = Get_array(row, col);
            My_Visual(dataGridView);
        }

        private void max_num_Click(object sender, EventArgs e)
        {
            int max = 0, i_max = 0, j_max = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (ob[i, j] > max) 
                    { 
                        max = ob[i, j]; 
                        i_max = i; 
                        j_max = j;
                    }
                }
            }
            label_max.Text = $"{max}, индексы [{i_max},{j_max}]";
        }

        private async void sum_1row_Click(object sender, EventArgs e)
        {
            int sum_row = 0;
            for (int i = 0; i < row; i++)
            {
                sum_row += ob[0, i];
            }
            label_sum1.Text = Convert.ToString(sum_row);
        }

        private void sum_Ncol_Click(object sender, EventArgs e)
        {
            int Ncol = rnd.Next(col);
            int sum_col = 0;
            for (int i = 0; i < row; i++)
            {
                sum_col += ob[i, Ncol];
            }
            label_sum2.Text = Convert.ToString(sum_col);
        }

        private void get_evens_Click(object sender, EventArgs e)
        {
            label_evens.Text = "";
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (ob[i, j] %2 != 0)
                    {
                        label_evens.Text += " " + Convert.ToString(ob[i, j]);
                    }
                }
            }
        }

        private void main_diag_nums_Click(object sender, EventArgs e)
        {
            label_main_diag.Text = "";
            for (int i = 0; i < row; i++)
            {
                label_main_diag.Text += " " + Convert.ToString(ob[i,i]);
            }
        }

        private void get_mins_Click(object sender, EventArgs e)
        {
            int min = 15;
            string indexes = "";
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (ob[i, j] < min)
                    {
                        min = ob[i, j];
                        indexes = $"[{i}, {j}]";
                    }
                    else if (ob[i, j] == min)
                    {
                        indexes += $", [{i}, {j}]";
                    }
                }
            }
            label_min.Text = $"{min} индекс(ы) {indexes}";
        }

        private int[,] Get_array(int row, int col)
        {
            int[,] arr = new int[row, col]; 
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = rnd.Next(-5, 14);
                }
            }
            return arr;
        }

        private void textRow_TextChanged(object sender, EventArgs e)
        {
            row = Convert.ToInt32(textRow.Text);
        }

        private void textCol_TextChanged(object sender, EventArgs e)
        {
            col = Convert.ToInt32(textCol.Text);
        }

        private void My_Visual(DataGridView dg)
        {
            dg.ColumnCount = col;
            dg.RowCount = row;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dg.Rows[i].Cells[j].Value = ob[i, j];
                }
            }
        }
    }

}
