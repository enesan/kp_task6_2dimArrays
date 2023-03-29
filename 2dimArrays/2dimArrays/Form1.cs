using System.Data.Common;
using System.Drawing.Drawing2D;

namespace _2dimArrays
{
    public partial class Form1 : Form
    {
        MyMatrix MainMatrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAndFillOutAMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                MainMatrix = new MyMatrix(Convert.ToInt32(RowTextBox.Text), Convert.ToInt32(ColumnTextBox.Text));
                MainMatrix.FillingAMatrixWithRandomNumbers(-5, 15);
                DisplayAMatrixInADataGrid();
            }
            catch
            {
                MessageBox.Show("Введены некорректные значения");
            }
        }

        private void DisplayAMatrixInADataGrid()
        {
            MatrixDataGridView.RowCount = MainMatrix.getRow();
            MatrixDataGridView.ColumnCount = MainMatrix.getColumn();
            for (int i = 0; i < MatrixDataGridView.RowCount; i++)
                for (int j = 0; j < MatrixDataGridView.ColumnCount; j++)
                    MatrixDataGridView.Rows[i].Cells[j].Value = MainMatrix[i, j];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MaximumArrayElementButton_Click(object sender, EventArgs e)
        {
            try
            {
                int row, colm, MaximalElementOfMatrix;
                MaximalElementOfMatrix = MainMatrix.FindingTheMaximalElementOfAMatrix(out row, out colm);
                row++;
                colm++;
                ResultLabel.Text = "Максимальный элемент массива - " + MaximalElementOfMatrix + ". Строка - " + row + ". Столбец - " + colm; ;
            }
            catch
            {
                MessageBox.Show("Матрица не создана");
            }
        }
        private void SumOfTheFirstRowAndRandomColumnOfTheArrayButton_Click(object sender, EventArgs e)
        {
            try
            {
                int SumOfTheFirstRow, SumOfTheRandomColumn, ColumnNumber;
                MainMatrix.SumOfTheFirstRowAndRandomColumnOfTheMatrix(out SumOfTheFirstRow, out SumOfTheRandomColumn, out ColumnNumber);
                ResultLabel.Text = "Сумма первой строки - " + SumOfTheFirstRow + ". Номер рандомного столбца - " + (int)(ColumnNumber + 1) + ". Сумма рандомного столбца - " + SumOfTheRandomColumn;
            }
            catch
            {
                MessageBox.Show("Матрица не создана");
            }
        }
        private void AllOddElementsOfTheArrayButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> AllOddElements = MainMatrix.FindAllOddElementsOfAMatrix();
                if (AllOddElements.Count != 0)
                {
                    string result = AllOddElements[0].ToString();
                    for (int i = 1; i < AllOddElements.Count; i++)
                        result += ", " + AllOddElements[i].ToString();
                    ResultLabel.Text = "Все нечетные элементы массива - " + result + ".";
                }
                else
                    ResultLabel.Text = "Нечетных элементов массива нет.";
            }
            catch
            {
                MessageBox.Show("Матрица не создана");
            }
        }
        private void AllElementsOfTheMainDiagonalButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> AllElementsOfTheMainDiagonal = MainMatrix.AllElementsOfTheMainDiagonalOfTheMatrix();
                string result = AllElementsOfTheMainDiagonal[0].ToString();
                for (int i = 1; i < AllElementsOfTheMainDiagonal.Count; i++)
                    result += ", " + AllElementsOfTheMainDiagonal[i].ToString();
                ResultLabel.Text = "Все элементы главной диагонали - " + result + ".";

            }
            catch
            {
                MessageBox.Show("Матрица не создана");
            }
        }
        private void AllMinimumElementsOfTheArrayButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> AllMinimumElementsOfTheMatrix = MainMatrix.AllMinimumElementsOfTheMatrix();
                string result = AllMinimumElementsOfTheMatrix[0] + " - минимальный элемент. Индексы элементов(строка, столбец): ";
                for (int i = 1; i < AllMinimumElementsOfTheMatrix.Count; i += 2)
                {
                    result += (int)(AllMinimumElementsOfTheMatrix[i] + 1) + ", " + (int)(AllMinimumElementsOfTheMatrix[i + 1] + 1) + "; ";
                }
                ResultLabel.Text = result;
            }
            catch
            {
                MessageBox.Show("Матрица не создана");
            }
        }


    }
}