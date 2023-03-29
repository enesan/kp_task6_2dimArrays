namespace _2dimArrays
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InformationLabel = new System.Windows.Forms.Label();
            this.RowTextBox = new System.Windows.Forms.TextBox();
            this.ColumnTextBox = new System.Windows.Forms.TextBox();
            this.CreateAndFillOutAMatrix = new System.Windows.Forms.Button();
            this.MatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.MaximumArrayElementButton = new System.Windows.Forms.Button();
            this.SumOfTheFirstRowAndRandomColumnOfTheArrayButton = new System.Windows.Forms.Button();
            this.AllMinimumElementsOfTheArrayButton = new System.Windows.Forms.Button();
            this.AllElementsOfTheMainDiagonalButton = new System.Windows.Forms.Button();
            this.AllOddElementsOfTheArrayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InformationLabel
            // 
            this.InformationLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InformationLabel.Location = new System.Drawing.Point(27, 9);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(284, 41);
            this.InformationLabel.TabIndex = 3;
            this.InformationLabel.Text = "Введите количество строк и столбцов";
            this.InformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RowTextBox
            // 
            this.RowTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RowTextBox.Location = new System.Drawing.Point(27, 56);
            this.RowTextBox.Name = "RowTextBox";
            this.RowTextBox.Size = new System.Drawing.Size(137, 26);
            this.RowTextBox.TabIndex = 4;
            this.RowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColumnTextBox
            // 
            this.ColumnTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColumnTextBox.Location = new System.Drawing.Point(174, 56);
            this.ColumnTextBox.Name = "ColumnTextBox";
            this.ColumnTextBox.Size = new System.Drawing.Size(137, 26);
            this.ColumnTextBox.TabIndex = 5;
            this.ColumnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateAndFillOutAMatrix
            // 
            this.CreateAndFillOutAMatrix.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateAndFillOutAMatrix.Location = new System.Drawing.Point(27, 88);
            this.CreateAndFillOutAMatrix.Name = "CreateAndFillOutAMatrix";
            this.CreateAndFillOutAMatrix.Size = new System.Drawing.Size(284, 49);
            this.CreateAndFillOutAMatrix.TabIndex = 6;
            this.CreateAndFillOutAMatrix.Text = "Создать и заполнить матрицу";
            this.CreateAndFillOutAMatrix.UseVisualStyleBackColor = true;
            this.CreateAndFillOutAMatrix.Click += new System.EventHandler(this.CreateAndFillOutAMatrix_Click);
            // 
            // MatrixDataGridView
            // 
            this.MatrixDataGridView.AllowUserToAddRows = false;
            this.MatrixDataGridView.AllowUserToDeleteRows = false;
            this.MatrixDataGridView.AllowUserToResizeColumns = false;
            this.MatrixDataGridView.AllowUserToResizeRows = false;
            this.MatrixDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixDataGridView.ColumnHeadersVisible = false;
            this.MatrixDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MatrixDataGridView.Location = new System.Drawing.Point(12, 189);
            this.MatrixDataGridView.Name = "MatrixDataGridView";
            this.MatrixDataGridView.RowHeadersVisible = false;
            this.MatrixDataGridView.RowHeadersWidth = 20;
            this.MatrixDataGridView.RowTemplate.Height = 25;
            this.MatrixDataGridView.Size = new System.Drawing.Size(760, 360);
            this.MatrixDataGridView.TabIndex = 7;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(12, 145);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(760, 32);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "Результат";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaximumArrayElementButton
            // 
            this.MaximumArrayElementButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumArrayElementButton.Location = new System.Drawing.Point(317, 6);
            this.MaximumArrayElementButton.Name = "MaximumArrayElementButton";
            this.MaximumArrayElementButton.Size = new System.Drawing.Size(199, 44);
            this.MaximumArrayElementButton.TabIndex = 9;
            this.MaximumArrayElementButton.Text = "Вывести максимальный элемент массива";
            this.MaximumArrayElementButton.UseVisualStyleBackColor = true;
            this.MaximumArrayElementButton.Click += new System.EventHandler(this.MaximumArrayElementButton_Click);
            // 
            // SumOfTheFirstRowAndRandomColumnOfTheArrayButton
            // 
            this.SumOfTheFirstRowAndRandomColumnOfTheArrayButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SumOfTheFirstRowAndRandomColumnOfTheArrayButton.Location = new System.Drawing.Point(522, 6);
            this.SumOfTheFirstRowAndRandomColumnOfTheArrayButton.Name = "SumOfTheFirstRowAndRandomColumnOfTheArrayButton";
            this.SumOfTheFirstRowAndRandomColumnOfTheArrayButton.Size = new System.Drawing.Size(250, 44);
            this.SumOfTheFirstRowAndRandomColumnOfTheArrayButton.TabIndex = 10;
            this.SumOfTheFirstRowAndRandomColumnOfTheArrayButton.Text = "Вывести сумму первой строки массива и случайного столбца.";
            this.SumOfTheFirstRowAndRandomColumnOfTheArrayButton.UseVisualStyleBackColor = true;
            this.SumOfTheFirstRowAndRandomColumnOfTheArrayButton.Click += new System.EventHandler(this.SumOfTheFirstRowAndRandomColumnOfTheArrayButton_Click);
            // 
            // AllMinimumElementsOfTheArrayButton
            // 
            this.AllMinimumElementsOfTheArrayButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllMinimumElementsOfTheArrayButton.Location = new System.Drawing.Point(317, 107);
            this.AllMinimumElementsOfTheArrayButton.Name = "AllMinimumElementsOfTheArrayButton";
            this.AllMinimumElementsOfTheArrayButton.Size = new System.Drawing.Size(455, 30);
            this.AllMinimumElementsOfTheArrayButton.TabIndex = 13;
            this.AllMinimumElementsOfTheArrayButton.Text = "Вывести все минимальные элементы массива";
            this.AllMinimumElementsOfTheArrayButton.UseVisualStyleBackColor = true;
            this.AllMinimumElementsOfTheArrayButton.Click += new System.EventHandler(this.AllMinimumElementsOfTheArrayButton_Click);
            // 
            // AllElementsOfTheMainDiagonalButton
            // 
            this.AllElementsOfTheMainDiagonalButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllElementsOfTheMainDiagonalButton.Location = new System.Drawing.Point(544, 56);
            this.AllElementsOfTheMainDiagonalButton.Name = "AllElementsOfTheMainDiagonalButton";
            this.AllElementsOfTheMainDiagonalButton.Size = new System.Drawing.Size(228, 45);
            this.AllElementsOfTheMainDiagonalButton.TabIndex = 14;
            this.AllElementsOfTheMainDiagonalButton.Text = "Вывести все элементы главной диагонали";
            this.AllElementsOfTheMainDiagonalButton.UseVisualStyleBackColor = true;
            this.AllElementsOfTheMainDiagonalButton.Click += new System.EventHandler(this.AllElementsOfTheMainDiagonalButton_Click);
            // 
            // AllOddElementsOfTheArrayButton
            // 
            this.AllOddElementsOfTheArrayButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllOddElementsOfTheArrayButton.Location = new System.Drawing.Point(317, 56);
            this.AllOddElementsOfTheArrayButton.Name = "AllOddElementsOfTheArrayButton";
            this.AllOddElementsOfTheArrayButton.Size = new System.Drawing.Size(221, 45);
            this.AllOddElementsOfTheArrayButton.TabIndex = 15;
            this.AllOddElementsOfTheArrayButton.Text = "Вывести все нечетные элементы массива";
            this.AllOddElementsOfTheArrayButton.UseVisualStyleBackColor = true;
            this.AllOddElementsOfTheArrayButton.Click += new System.EventHandler(this.AllOddElementsOfTheArrayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.AllOddElementsOfTheArrayButton);
            this.Controls.Add(this.AllElementsOfTheMainDiagonalButton);
            this.Controls.Add(this.AllMinimumElementsOfTheArrayButton);
            this.Controls.Add(this.SumOfTheFirstRowAndRandomColumnOfTheArrayButton);
            this.Controls.Add(this.MaximumArrayElementButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.MatrixDataGridView);
            this.Controls.Add(this.CreateAndFillOutAMatrix);
            this.Controls.Add(this.ColumnTextBox);
            this.Controls.Add(this.RowTextBox);
            this.Controls.Add(this.InformationLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatrixDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label InformationLabel;
        private TextBox RowTextBox;
        private TextBox ColumnTextBox;
        private Button CreateAndFillOutAMatrix;
        private DataGridView MatrixDataGridView;
        private Label ResultLabel;
        private Button MaximumArrayElementButton;
        private Button SumOfTheFirstRowAndRandomColumnOfTheArrayButton;
        private Button AllMinimumElementsOfTheArrayButton;
        private Button AllElementsOfTheMainDiagonalButton;
        private Button AllOddElementsOfTheArrayButton;
    }
}