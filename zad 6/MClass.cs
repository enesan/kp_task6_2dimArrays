using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_6
{
    internal class MClass
    {
        public int m, n;
        public int[,] a;

        public MClass(int m, int n)
        {
            this.m = m;
            this.n = n;
            this.a = new int[n, m];
        }
        public void MVisual(DataGridView dg)
        {

            dg.RowCount = n;
            dg.ColumnCount = m;


            for (int irow = 0; irow < n; irow++)
            {
                for (int icol = 0; icol < m; icol++)
                {
                    dg.Rows[irow].Cells[icol].Value = a[irow, icol];
                }
            }
        }
        public void MRand()
        {
            Random r = new Random();

            for (int irow = 0; irow < n; irow++)
            {
                for (int icol = 0; icol < m; icol++)
                {
                    a[irow, icol] = r.Next(-5, 15);
                }
            }
        }

        //1
        public string MMax()
        {
            int mx = -100;
            int m_mx = 0, n_mx = 0;
            for (int irow = 0; irow < n; irow++)
            {
                for (int icol = 0; icol < m; icol++)
                {
                    if (a[irow,icol] > mx)
                    { 
                        mx = a[irow,icol]; m_mx = icol; n_mx = irow;
                    }

                }
            }
            return $"Mаксимальный элемент массива = {mx}, расположен А[{n_mx},{m_mx}]";
        }

        //2
        public string MRandSum()
        {
            int row_sum = 0;
            for (int icol = 0; icol < m; icol++)
            {
                row_sum += a[0,icol];
            }

            Random rnd = new Random();
            int col_sum = 0;
            int r_col = rnd.Next(0, m);
            for (int irow = 0; irow < n; irow++)
            {
                col_sum += a[n-1, r_col];
            }
                return $"Cумма элементов 1-й строки = {row_sum}; сумма элементов {r_col} столбца = {col_sum}";
        }

        //3
        public string MOdd()
        {
            string str = "";
            for (int irow = 0; irow < n; irow++)
            {
                for (int icol = 0; icol < m; icol++)
                {
                    if (a[irow, icol] % 2 == 1 || a[irow, icol] % 2 == -1)
                    {
                        str += a[irow, icol] + "; ";
                    }

                }
            }
            return str;
        }

        //4
        public string MMainDiagonal()
        {
            string str = "";
            for (int irow = 0; irow < n; irow++)
            {
                for (int icol = 0; icol < m; icol++)
                {
                    if (irow == icol)
                    {
                        str += a[irow, icol] + "; ";
                    }

                }
            }
            return str;
        }

        //5
        public string MMin()
        {
            int mn = 1000;
            int m_mn = 0, n_mn = 0;
            for (int irow = 0; irow < n; irow++)
            {
                for (int icol = 0; icol < m; icol++)
                {
                    if (a[irow, icol] < mn)
                    {
                        mn = a[irow, icol]; m_mn = icol; n_mn = irow;
                    }

                }
            }
            
            int n_mn2, m_mn2; string _str = $"Минимальный элемент массива = {mn}, расположены "; bool flag = false;

            for (int irow = 0; irow < n; irow++)
            {
                for (int icol = 0; icol < m; icol++)
                {
                    if (a[irow, icol] == mn)
                    {
                        flag = true;
                         m_mn2 = icol; n_mn2 = irow;
                        _str += $"A[{n_mn2}, {m_mn2}] ";
                    }

                }
            }

            string str = $"Минимальный элемент массива = {mn}, расположен А[{n_mn},{m_mn}]";

            if (flag == true)
                return _str;
            else
                return str;
        }
    }
}


