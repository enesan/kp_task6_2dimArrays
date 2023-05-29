using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ООП_ДЗ_2
{
    class Matrix
    {
        int n;
        int m;
        int[,] matrix;

        public Matrix(int n ,int m) 
        {
                this.n = n;
                this.m = m;
                if (n < 0) this.n = -n;
                if (m < 0) this.m = -m;
                matrix= new int[this.n,this.m];
        }
        public void zapoln()
        {
            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(-5, 15); 
                }
            }
  
        }

        public void Visual(DataGridView dataGridView)
        {
            dataGridView.TopLeftHeaderCell.Value = "i j";          
            dataGridView.RowCount = matrix.GetLength(0);
            dataGridView.ColumnCount = matrix.GetLength(1);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                dataGridView.Rows[i].HeaderCell.Value = string.Format(i.ToString(), "0");

                for (int j = 0;j < matrix.GetLength(1); j++)
                {                    
                    dataGridView.Rows[i].Cells[j].Value = matrix[i, j];
                    dataGridView.Columns[j].HeaderText = $"{j}";
                }
            }
              

        }



        //Найти максимальный элемент массива
        public string max()
        {
            int max = -100;
            int x=0, y=0;
            for (int i=0;i< matrix.GetLength(0); i++)
            {
                for (int j =0;j< matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max) { max = matrix[i, j]; x = i; y = j; } 
                }
            }
            string s=$" = {max}, расположен А[{x},{y}];";

            return s ;
        }
        // Найти минимальный элемент массива
        public string min()
        {
            int min = 100;
            string s2="";
            int x=0, y=0;
            for (int i=0;i< matrix.GetLength(0); i++)
            {
                for (int j =0;j< matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min) { min = matrix[i, j]; x = i; y = j; }             
                }
            }

            for (int i=0;i< matrix.GetLength(0); i++)
            {
                for (int j =0;j< matrix.GetLength(1); j++)
                {
                    if ((matrix[i, j] == min )&& ((x != i) || (y != j))) s2 = s2 + $" {matrix[i, j]}, расположен А[{i},{j}]";
                }
            }
            
            string s = $" = {min}, расположен А[{x},{y}];" + s2;
            return s ;
        }
        //Вывести на экран все нечетные элементы массива.
        public string nechot()
        {
            string s= "";
            for (int i=0;i< matrix.GetLength(0); i++)
            {
                for (int j =0;j< matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0) s += $" { matrix[i, j]},";
                }
            }
            return s ;
        }
        //Вывести на экран все элементы главной диагонали.
        public string diognal()
        {
            string s= "";
            for (int i=0;i< matrix.GetLength(0); i++)
            {
                for (int j =0;j< matrix.GetLength(1); j++)
                {
                    if (i == j) s += $" { matrix[i, j]},";
                }
            }
            return s ;
        }
        //Найти сумму первой строки массива и случайного столбца.
        public string summ ()
        {
            int sum1=0,sum2=0;
            Random rand = new Random();
            int k = rand.Next(matrix.GetLength(1));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0;j< matrix.GetLength(1); j++)
                {
                    if (i==1) sum1 += matrix[i, j];
                    if (j == k) sum2 += matrix[i, j];
                }
            }
            string summa = $"сумма  1й строки = {sum1}; сумма  {k} столбца = {sum2};";
            return summa;
        }
           
       

    }
}
