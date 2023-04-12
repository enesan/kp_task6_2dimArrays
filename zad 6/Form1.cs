using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        MClass ob;


        private void Form1_Load(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            ////int n = Convert.ToInt32(tb1.Text);
            ////int m = Convert.ToInt32(tb2.Text);
            //int n = 3; int m = 4;
            //int[,] a = new int[n, m];
            //dg1.RowCount = n;
            //dg1.ColumnCount = m;

            //for (int i = 0; i > n; i++)
            //{
            //    for (int j = 0; j > m; j++)
            //    {
            //        a[i, j] = rnd.Next();
            //        dg1.Rows[i].Cells[j].Value = a[i, j];
            //    }
            //}
        }
        
        private void b_create_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tb1.Text);
            int m = Convert.ToInt32(tb2.Text);
            ob = new MClass(n,m);

            ob.MRand();
            ob.MVisual(dg1);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ob.MMax();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = ob.MRandSum();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = ob.MOdd();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = ob.MMainDiagonal();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = ob.MMin();
        }
    }
        
    
}
