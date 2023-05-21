using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        myMatryx fstMatrix = new myMatryx(1,1);
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vopros1_Click(object sender, EventArgs e)
        {
            textBoxNUM1.Text = fstMatrix.maxNum();
            textBoxNUMIND1.Text = fstMatrix.maxNum_index();
        }

        private void vopros2_Click(object sender, EventArgs e)
        {
            textBoxSUM1.Text = fstMatrix.sum1strow();
            textBoxSUMN.Text = fstMatrix.sumNrow();
        }

        private void vopros3_Click(object sender, EventArgs e)
        {
            textBoxNECH.Text = fstMatrix.nechet();
        }

        private void vopros4_Click(object sender, EventArgs e)
        {
            textBoxDIAG.Text = fstMatrix.glavdiag();
        }

        private void visualMATRIX_Click(object sender, EventArgs e)
        {
            fstMatrix = new myMatryx(Convert.ToInt32(textBoxN.Text), Convert.ToInt32(textBoxM.Text));
            fstMatrix.randomMatrix();
            fstMatrix.Visualize(dataGridView1);
        }

        private void vopros5_Click(object sender, EventArgs e)
        {
            textBoxMIN.Text = fstMatrix.min_el();
            textBoxINDMIN.Text = fstMatrix.min_el_ind();
        }
    }
}
