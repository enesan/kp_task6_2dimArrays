namespace Massivchiki
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
            Sozdat_massiv = new Button();
            VvodStrok = new TextBox();
            VvodStolbcov = new TextBox();
            label1 = new Label();
            label2 = new Label();
            MassivGridView = new DataGridView();
            maxElementLabel = new Label();
            minElementsLabel = new Label();
            mainDiagElementLabel = new Label();
            nechetElementsLabel = new Label();
            summaElementsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)MassivGridView).BeginInit();
            SuspendLayout();
            // 
            // Sozdat_massiv
            // 
            Sozdat_massiv.BackColor = SystemColors.GradientActiveCaption;
            Sozdat_massiv.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Sozdat_massiv.Location = new Point(42, 121);
            Sozdat_massiv.Name = "Sozdat_massiv";
            Sozdat_massiv.Size = new Size(223, 52);
            Sozdat_massiv.TabIndex = 1;
            Sozdat_massiv.Text = "Массив на экран";
            Sozdat_massiv.UseVisualStyleBackColor = false;
            Sozdat_massiv.Click += Sozdat_massiv_Click;
            // 
            // VvodStrok
            // 
            VvodStrok.Font = new Font("Myanmar Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            VvodStrok.Location = new Point(12, 35);
            VvodStrok.Multiline = true;
            VvodStrok.Name = "VvodStrok";
            VvodStrok.Size = new Size(104, 29);
            VvodStrok.TabIndex = 2;
            VvodStrok.TextAlign = HorizontalAlignment.Center;
            // 
            // VvodStolbcov
            // 
            VvodStolbcov.Font = new Font("Myanmar Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            VvodStolbcov.Location = new Point(12, 70);
            VvodStolbcov.Multiline = true;
            VvodStolbcov.Name = "VvodStolbcov";
            VvodStolbcov.Size = new Size(104, 29);
            VvodStolbcov.TabIndex = 3;
            VvodStolbcov.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(122, 39);
            label1.Name = "label1";
            label1.Size = new Size(162, 29);
            label1.TabIndex = 4;
            label1.Text = "Количество строк";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(122, 74);
            label2.Name = "label2";
            label2.Size = new Size(194, 29);
            label2.TabIndex = 5;
            label2.Text = "Количество столбцов";
            // 
            // MassivGridView
            // 
            MassivGridView.AllowUserToOrderColumns = true;
            MassivGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MassivGridView.Location = new Point(322, 12);
            MassivGridView.Name = "MassivGridView";
            MassivGridView.RowTemplate.Height = 25;
            MassivGridView.Size = new Size(466, 173);
            MassivGridView.TabIndex = 6;
            // 
            // maxElementLabel
            // 
            maxElementLabel.AutoSize = true;
            maxElementLabel.BackColor = SystemColors.ControlDark;
            maxElementLabel.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maxElementLabel.Location = new Point(12, 197);
            maxElementLabel.Name = "maxElementLabel";
            maxElementLabel.Size = new Size(0, 29);
            maxElementLabel.TabIndex = 7;
            // 
            // minElementsLabel
            // 
            minElementsLabel.AutoSize = true;
            minElementsLabel.BackColor = SystemColors.ControlDark;
            minElementsLabel.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            minElementsLabel.Location = new Point(12, 353);
            minElementsLabel.Name = "minElementsLabel";
            minElementsLabel.Size = new Size(0, 29);
            minElementsLabel.TabIndex = 8;
            // 
            // mainDiagElementLabel
            // 
            mainDiagElementLabel.AutoSize = true;
            mainDiagElementLabel.BackColor = SystemColors.ControlDark;
            mainDiagElementLabel.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mainDiagElementLabel.Location = new Point(12, 315);
            mainDiagElementLabel.Name = "mainDiagElementLabel";
            mainDiagElementLabel.Size = new Size(0, 29);
            mainDiagElementLabel.TabIndex = 9;
            // 
            // nechetElementsLabel
            // 
            nechetElementsLabel.AutoSize = true;
            nechetElementsLabel.BackColor = SystemColors.ControlDark;
            nechetElementsLabel.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nechetElementsLabel.Location = new Point(12, 275);
            nechetElementsLabel.Name = "nechetElementsLabel";
            nechetElementsLabel.Size = new Size(0, 29);
            nechetElementsLabel.TabIndex = 10;
            // 
            // summaElementsLabel
            // 
            summaElementsLabel.AutoSize = true;
            summaElementsLabel.BackColor = SystemColors.ControlDark;
            summaElementsLabel.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            summaElementsLabel.Location = new Point(12, 236);
            summaElementsLabel.Name = "summaElementsLabel";
            summaElementsLabel.Size = new Size(0, 29);
            summaElementsLabel.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(summaElementsLabel);
            Controls.Add(nechetElementsLabel);
            Controls.Add(mainDiagElementLabel);
            Controls.Add(minElementsLabel);
            Controls.Add(maxElementLabel);
            Controls.Add(MassivGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(VvodStolbcov);
            Controls.Add(VvodStrok);
            Controls.Add(Sozdat_massiv);
            Name = "Form1";
            Text = "Массивы";
            ((System.ComponentModel.ISupportInitialize)MassivGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Sozdat_massiv;
        private TextBox VvodStrok;
        private TextBox VvodStolbcov;
        private Label label1;
        private Label label2;
        private DataGridView MassivGridView;
        private Label maxElementLabel;
        private Label minElementsLabel;
        private Label mainDiagElementLabel;
        private Label nechetElementsLabel;
        private Label summaElementsLabel;
    }
}