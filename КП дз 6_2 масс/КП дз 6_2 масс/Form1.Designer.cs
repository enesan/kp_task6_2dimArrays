namespace ООП_ДЗ_2
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            buttonZapol = new Button();
            dataGridView1 = new DataGridView();
            buttonVisual = new Button();
            buttonNechot = new Button();
            Max = new Button();
            Summ = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            labelMax = new Label();
            labelSum = new Label();
            label2 = new Label();
            button2 = new Button();
            label4 = new Label();
            buttonMin = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(529, -1);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(214, 44);
            button1.TabIndex = 0;
            button1.Text = "Создать матрицу ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(54, 39);
            textBox1.TabIndex = 1;
            textBox1.Text = "3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 4);
            label1.Name = "label1";
            label1.Size = new Size(275, 38);
            label1.TabIndex = 2;
            label1.Text = "размер матрицы n=";
            // 
            // buttonZapol
            // 
            buttonZapol.Location = new Point(771, -1);
            buttonZapol.Name = "buttonZapol";
            buttonZapol.Size = new Size(298, 43);
            buttonZapol.TabIndex = 3;
            buttonZapol.Text = "Заполнить случайно";
            buttonZapol.UseVisualStyleBackColor = true;
            buttonZapol.Click += buttonZapol_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(672, 396);
            dataGridView1.TabIndex = 4;
            
            // 
            // buttonVisual
            // 
            buttonVisual.Location = new Point(1101, -1);
            buttonVisual.Name = "buttonVisual";
            buttonVisual.Size = new Size(298, 43);
            buttonVisual.TabIndex = 5;
            buttonVisual.Text = "Визуализация матрицы";
            buttonVisual.UseVisualStyleBackColor = true;
            buttonVisual.Click += buttonVisual_Click;
            // 
            // buttonNechot
            // 
            buttonNechot.Location = new Point(714, 63);
            buttonNechot.Name = "buttonNechot";
            buttonNechot.Size = new Size(523, 43);
            buttonNechot.TabIndex = 6;
            buttonNechot.Text = "Вывести на экран все нечетные элементы ";
            buttonNechot.UseVisualStyleBackColor = true;
            buttonNechot.Click += buttonNechot_Click;
            // 
            // Max
            // 
            Max.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Max.Location = new Point(714, 357);
            Max.Name = "Max";
            Max.RightToLeft = RightToLeft.Yes;
            Max.Size = new Size(268, 61);
            Max.TabIndex = 8;
            Max.Text = "максимальный элемент";
            Max.UseVisualStyleBackColor = true;
            Max.Click += Max_Click_1;
            // 
            // Summ
            // 
            Summ.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Summ.Location = new Point(706, 190);
            Summ.Name = "Summ";
            Summ.RightToLeft = RightToLeft.Yes;
            Summ.Size = new Size(603, 58);
            Summ.TabIndex = 10;
            Summ.Text = "Найти сумму первой строки массива и случайного столбца ";
            Summ.UseVisualStyleBackColor = true;
            Summ.Click += Summ_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(366, 4);
            label3.Name = "label3";
            label3.Size = new Size(60, 38);
            label3.TabIndex = 14;
            label3.Text = "m=";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(432, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(54, 39);
            textBox2.TabIndex = 15;
            textBox2.Text = "3";
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.BackColor = SystemColors.ButtonHighlight;
            labelMax.Location = new Point(1015, 370);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(0, 32);
            labelMax.TabIndex = 17;
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.BackColor = SystemColors.ButtonHighlight;
            labelSum.ForeColor = SystemColors.ControlText;
            labelSum.Location = new Point(714, 251);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(0, 32);
            labelSum.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(714, 125);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 19;
            // 
            // button2
            // 
            button2.Location = new Point(703, 450);
            button2.Name = "button2";
            button2.Size = new Size(629, 43);
            button2.TabIndex = 20;
            button2.Text = "Вывести на экран все элементы главной диагонали.";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(1353, 455);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 21;
            // 
            // buttonMin
            // 
            buttonMin.Location = new Point(71, 554);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(629, 43);
            buttonMin.TabIndex = 22;
            buttonMin.Text = "Найти минимальный(ые) элемент(ы)";
            buttonMin.UseVisualStyleBackColor = true;
            buttonMin.Click += buttonMin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(714, 559);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1759, 707);
            Controls.Add(label5);
            Controls.Add(buttonMin);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(labelSum);
            Controls.Add(labelMax);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(Summ);
            Controls.Add(Max);
            Controls.Add(buttonNechot);
            Controls.Add(buttonVisual);
            Controls.Add(dataGridView1);
            Controls.Add(buttonZapol);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button buttonZapol;
        private DataGridView dataGridView1;
        private Button buttonVisual;
        private Button buttonNechot;
        private Button Max;
        private Button Summ;
        private Label label3;
        private TextBox textBox2;
        private Label labelMax;
        private Label labelSum;
        private Label label2;
        private Button button2;
        private Label label4;
        private Button buttonMin;
        private Label label5;
    }
}