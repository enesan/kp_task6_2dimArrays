namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.textBoxNUM1 = new System.Windows.Forms.TextBox();
            this.vopros1 = new System.Windows.Forms.Button();
            this.visualMATRIX = new System.Windows.Forms.Button();
            this.textBoxNUMIND1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSUMN = new System.Windows.Forms.TextBox();
            this.vopros2 = new System.Windows.Forms.Button();
            this.textBoxSUM1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vopros3 = new System.Windows.Forms.Button();
            this.textBoxNECH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vopros4 = new System.Windows.Forms.Button();
            this.textBoxDIAG = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxINDMIN = new System.Windows.Forms.TextBox();
            this.vopros5 = new System.Windows.Forms.Button();
            this.textBoxMIN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(400, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "столбцы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "строки";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(563, 30);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(108, 26);
            this.textBoxN.TabIndex = 3;
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(563, 71);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(108, 26);
            this.textBoxM.TabIndex = 4;
            // 
            // textBoxNUM1
            // 
            this.textBoxNUM1.Location = new System.Drawing.Point(680, 110);
            this.textBoxNUM1.Name = "textBoxNUM1";
            this.textBoxNUM1.Size = new System.Drawing.Size(108, 26);
            this.textBoxNUM1.TabIndex = 5;
            // 
            // vopros1
            // 
            this.vopros1.Location = new System.Drawing.Point(455, 110);
            this.vopros1.Name = "vopros1";
            this.vopros1.Size = new System.Drawing.Size(109, 60);
            this.vopros1.TabIndex = 9;
            this.vopros1.Text = "1 вопрос";
            this.vopros1.UseVisualStyleBackColor = true;
            this.vopros1.Click += new System.EventHandler(this.vopros1_Click);
            // 
            // visualMATRIX
            // 
            this.visualMATRIX.Location = new System.Drawing.Point(141, 355);
            this.visualMATRIX.Name = "visualMATRIX";
            this.visualMATRIX.Size = new System.Drawing.Size(175, 41);
            this.visualMATRIX.TabIndex = 13;
            this.visualMATRIX.Text = "вывести матрицу";
            this.visualMATRIX.UseVisualStyleBackColor = true;
            this.visualMATRIX.Click += new System.EventHandler(this.visualMATRIX_Click);
            // 
            // textBoxNUMIND1
            // 
            this.textBoxNUMIND1.Location = new System.Drawing.Point(680, 144);
            this.textBoxNUMIND1.Name = "textBoxNUMIND1";
            this.textBoxNUMIND1.Size = new System.Drawing.Size(108, 26);
            this.textBoxNUMIND1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "значение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "его индекс";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "сумма N стлб";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "сумма 1 стр";
            // 
            // textBoxSUMN
            // 
            this.textBoxSUMN.Location = new System.Drawing.Point(680, 208);
            this.textBoxSUMN.Name = "textBoxSUMN";
            this.textBoxSUMN.Size = new System.Drawing.Size(108, 26);
            this.textBoxSUMN.TabIndex = 19;
            // 
            // vopros2
            // 
            this.vopros2.Location = new System.Drawing.Point(455, 176);
            this.vopros2.Name = "vopros2";
            this.vopros2.Size = new System.Drawing.Size(109, 60);
            this.vopros2.TabIndex = 18;
            this.vopros2.Text = "2 вопрос";
            this.vopros2.UseVisualStyleBackColor = true;
            this.vopros2.Click += new System.EventHandler(this.vopros2_Click);
            // 
            // textBoxSUM1
            // 
            this.textBoxSUM1.Location = new System.Drawing.Point(680, 176);
            this.textBoxSUM1.Name = "textBoxSUM1";
            this.textBoxSUM1.Size = new System.Drawing.Size(108, 26);
            this.textBoxSUM1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(585, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "нечет эл";
            // 
            // vopros3
            // 
            this.vopros3.Location = new System.Drawing.Point(455, 243);
            this.vopros3.Name = "vopros3";
            this.vopros3.Size = new System.Drawing.Size(109, 60);
            this.vopros3.TabIndex = 23;
            this.vopros3.Text = "3 вопрос";
            this.vopros3.UseVisualStyleBackColor = true;
            this.vopros3.Click += new System.EventHandler(this.vopros3_Click);
            // 
            // textBoxNECH
            // 
            this.textBoxNECH.Location = new System.Drawing.Point(575, 277);
            this.textBoxNECH.Name = "textBoxNECH";
            this.textBoxNECH.Size = new System.Drawing.Size(213, 26);
            this.textBoxNECH.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "эл. глав. диаг";
            // 
            // vopros4
            // 
            this.vopros4.Location = new System.Drawing.Point(455, 310);
            this.vopros4.Name = "vopros4";
            this.vopros4.Size = new System.Drawing.Size(109, 60);
            this.vopros4.TabIndex = 27;
            this.vopros4.Text = "4 вопрос";
            this.vopros4.UseVisualStyleBackColor = true;
            this.vopros4.Click += new System.EventHandler(this.vopros4_Click);
            // 
            // textBoxDIAG
            // 
            this.textBoxDIAG.Location = new System.Drawing.Point(575, 333);
            this.textBoxDIAG.Name = "textBoxDIAG";
            this.textBoxDIAG.Size = new System.Drawing.Size(213, 26);
            this.textBoxDIAG.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(568, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "индекс(ы) этого эл.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(568, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "мин. эл";
            // 
            // textBoxINDMIN
            // 
            this.textBoxINDMIN.Location = new System.Drawing.Point(574, 439);
            this.textBoxINDMIN.Name = "textBoxINDMIN";
            this.textBoxINDMIN.Size = new System.Drawing.Size(214, 26);
            this.textBoxINDMIN.TabIndex = 31;
            // 
            // vopros5
            // 
            this.vopros5.Location = new System.Drawing.Point(455, 376);
            this.vopros5.Name = "vopros5";
            this.vopros5.Size = new System.Drawing.Size(109, 60);
            this.vopros5.TabIndex = 30;
            this.vopros5.Text = "5 вопрос";
            this.vopros5.UseVisualStyleBackColor = true;
            this.vopros5.Click += new System.EventHandler(this.vopros5_Click);
            // 
            // textBoxMIN
            // 
            this.textBoxMIN.Location = new System.Drawing.Point(680, 376);
            this.textBoxMIN.Name = "textBoxMIN";
            this.textBoxMIN.Size = new System.Drawing.Size(108, 26);
            this.textBoxMIN.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxINDMIN);
            this.Controls.Add(this.vopros5);
            this.Controls.Add(this.textBoxMIN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vopros4);
            this.Controls.Add(this.textBoxDIAG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vopros3);
            this.Controls.Add(this.textBoxNECH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSUMN);
            this.Controls.Add(this.vopros2);
            this.Controls.Add(this.textBoxSUM1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNUMIND1);
            this.Controls.Add(this.visualMATRIX);
            this.Controls.Add(this.vopros1);
            this.Controls.Add(this.textBoxNUM1);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.TextBox textBoxNUM1;
        private System.Windows.Forms.Button vopros1;
        private System.Windows.Forms.Button visualMATRIX;
        private System.Windows.Forms.TextBox textBoxNUMIND1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSUMN;
        private System.Windows.Forms.Button vopros2;
        private System.Windows.Forms.TextBox textBoxSUM1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button vopros3;
        private System.Windows.Forms.TextBox textBoxNECH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button vopros4;
        private System.Windows.Forms.TextBox textBoxDIAG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxINDMIN;
        private System.Windows.Forms.Button vopros5;
        private System.Windows.Forms.TextBox textBoxMIN;
    }
}

