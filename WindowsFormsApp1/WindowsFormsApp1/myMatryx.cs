using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class myMatryx
    {
        int n, m;
        int[,] mass;
        int max = 0, i_max = 0, j_max = 0;
        Random r = new Random();
        int min = 99;
        string indexes = "";
        public myMatryx(int n, int m)
        {
            this.n = n;
            this.m = m;
            mass = new int[n, m];
            
        }
        public void randomMatrix()
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    mass[i, j] = r.Next(-5, 15);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (mass[i, j] > max)
                    {
                        max = mass[i, j];
                        i_max = i;
                        j_max = j;
                    }
                    if (mass[i, j] < min)
                    {
                        min = mass[i, j];
                        indexes = $"[{i}, {j}]";
                    }
                    else if (mass[i, j] == min)
                    {
                        indexes += $", [{i}, {j}]";
                    }
                }
        }
        public void Visualize(DataGridView dataGridView)
        {
            dataGridView.RowCount = n;
            dataGridView.ColumnCount = m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = mass[i, j];
                }
            }
        }
        public string maxNum()
        {
            return max.ToString();
        }
        public string maxNum_index()
        {
            return "A[" + i_max.ToString() + ", " + j_max.ToString() + "]";
        }
        public string sum1strow()
        {
            int sum_row = 0;
            for (int i = 0; i < n; i++)
                sum_row += mass[0, i];
            return sum_row.ToString();
        }
        public string sumNrow()
        {
            int rndNcol = r.Next(m);
            int sum_col = 0;
            for (int i = 0; i < n; i++)
            {
                sum_col += mass[i, rndNcol];
            }
            return sum_col.ToString();
        }
        public string nechet()
        {
            string otvet = "";
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (mass[i, j] % 2 != 0)
                        otvet += Convert.ToString(mass[i, j]) + ", ";
            return otvet;
        }
        public string glavdiag()
        {
            string otvet = "";
            for (int i = 0; i < n; i++)
                otvet += Convert.ToString(mass[i, i]) + ", ";
            return otvet;
        }
        public string min_el()
        {
            return min.ToString();
        }
        public string min_el_ind()
        {
            return indexes;
        }
    }
}
