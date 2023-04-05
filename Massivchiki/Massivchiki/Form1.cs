namespace Massivchiki
{
    public partial class Form1 : Form
    {
        int lines; int verticals;
        int[,] array;
        int temp, temp2, max_i, max_j, stolbec;
        int summa_stroki, summa_stolbca;

        public Form1()
        {
            InitializeComponent();
        }


        private void Sozdat_massiv_Click(object sender, EventArgs e)
        {
            lines = Convert.ToInt32(VvodStrok.Text);
            verticals = Convert.ToInt32(VvodStolbcov.Text);
            temp = -10; temp2 = 20; summa_stroki = 0; summa_stolbca = 0;
            array = new int[lines, verticals];
            nechetElementsLabel.Text = "Нечетные элементы:";
            mainDiagElementLabel.Text = "Элементы главной диагонали:";
            Random rnd = new Random();
            stolbec = rnd.Next(0, verticals);
            MassivGridView.RowCount = lines + 1;
            MassivGridView.ColumnCount = verticals + 1;
            for (int i = 0; i < lines; i++)
                for (int j = 0; j < verticals; j++)
                {
                    array[i, j] = rnd.Next(-5, 16);
                    if (array[i, j] > temp)
                    {
                        temp = array[i, j];
                        max_i = i;
                        max_j = j;
                    }
                    if (array[i, j] < temp2)
                    {
                        temp2 = array[i, j];
                    }
                    if (i == 0) summa_stroki += array[i, j];
                    if (j == stolbec) summa_stolbca += array[i, j];
                    if (array[i, j] % 2 == 1 || array[i, j] % 2 == -1)
                    {
                        nechetElementsLabel.Text += $" {array[i, j]}";
                    }
                    if (i == j)
                    {
                        mainDiagElementLabel.Text += $" {array[i, j]}";
                    }
                    MassivGridView.Rows[0].Cells[j + 1].Value = j; MassivGridView.Rows[i + 1].Cells[0].Value = i; MassivGridView.Rows[0].Cells[0].Value = "ij";
                    MassivGridView.Rows[0].DefaultCellStyle.BackColor = Color.DarkGray; MassivGridView.Columns[0].DefaultCellStyle.BackColor = Color.DarkGray;
                    MassivGridView.Rows[i + 1].Cells[j + 1].Value = array[i, j];
                }
            maxElementLabel.Text = $"Максимальный элемент массива = {temp}, расположен array[{max_i},{max_j}]";
            summaElementsLabel.Text = $"Сумма элементов 1й строки = {summa_stroki}, сумма элементов {stolbec + 1} столбца = {summa_stolbca}";
            minElementsLabel.Text = $"Минимальный элемент массива = {temp2}, расположен ";
            for (int i = 0; i < lines; i++)
                for (int j = 0; j < verticals; j++)
                {
                    if (array[i, j] == temp2) minElementsLabel.Text += $" array[{i},{j}]";
                }
        }
    }
}