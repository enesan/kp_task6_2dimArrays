namespace WinFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.xBox = new System.Windows.Forms.TextBox();
            this.yBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.task1 = new System.Windows.Forms.Label();
            this.task2 = new System.Windows.Forms.Label();
            this.task3 = new System.Windows.Forms.Label();
            this.task4 = new System.Windows.Forms.Label();
            this.task5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(526, 81);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(32, 6);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(50, 23);
            this.xBox.TabIndex = 2;
            this.xBox.TextChanged += new System.EventHandler(this.xBox_TextChanged);
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(32, 35);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(50, 23);
            this.yBox.TabIndex = 3;
            this.yBox.TextChanged += new System.EventHandler(this.yBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // task1
            // 
            this.task1.AutoSize = true;
            this.task1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.task1.Location = new System.Drawing.Point(12, 99);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(0, 21);
            this.task1.TabIndex = 6;
            // 
            // task2
            // 
            this.task2.AutoSize = true;
            this.task2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.task2.Location = new System.Drawing.Point(12, 120);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(0, 21);
            this.task2.TabIndex = 7;
            // 
            // task3
            // 
            this.task3.AutoSize = true;
            this.task3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.task3.Location = new System.Drawing.Point(12, 141);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(0, 21);
            this.task3.TabIndex = 8;
            // 
            // task4
            // 
            this.task4.AutoSize = true;
            this.task4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.task4.Location = new System.Drawing.Point(12, 162);
            this.task4.Name = "task4";
            this.task4.Size = new System.Drawing.Size(0, 21);
            this.task4.TabIndex = 9;
            // 
            // task5
            // 
            this.task5.AutoSize = true;
            this.task5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.task5.Location = new System.Drawing.Point(12, 183);
            this.task5.Name = "task5";
            this.task5.Size = new System.Drawing.Size(0, 21);
            this.task5.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 212);
            this.Controls.Add(this.task5);
            this.Controls.Add(this.task4);
            this.Controls.Add(this.task3);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.task1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Переводчик";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox xBox;
        private TextBox yBox;
        private Label label1;
        private Label label2;
        private Label task1;
        private Label task2;
        private Label task3;
        private Label task4;
        private Label task5;
    }
}