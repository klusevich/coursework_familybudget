namespace Family_Budget
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
            this.accountingButton = new System.Windows.Forms.Button();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countBestButton = new System.Windows.Forms.Button();
            this.everydayTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.capitalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.majorTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.irregularTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.entertainmetsTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accountingButton
            // 
            this.accountingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountingButton.Location = new System.Drawing.Point(275, 354);
            this.accountingButton.Name = "accountingButton";
            this.accountingButton.Size = new System.Drawing.Size(226, 42);
            this.accountingButton.TabIndex = 6;
            this.accountingButton.Text = "Перейти к учету";
            this.accountingButton.UseVisualStyleBackColor = true;
            this.accountingButton.Visible = false;
            this.accountingButton.Click += new System.EventHandler(this.accountingButton_Click);
            // 
            // monthComboBox
            // 
            this.monthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "январь",
            "февраль",
            "март",
            "апрель",
            "май",
            "июнь",
            "июль",
            "август",
            "сентябрь",
            "октябрь",
            "ноябрь",
            "декабрь"});
            this.monthComboBox.Location = new System.Drawing.Point(338, 60);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 23);
            this.monthComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(94, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(97, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(109, 21);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeTextBox.Location = new System.Drawing.Point(563, 60);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(194, 21);
            this.incomeTextBox.TabIndex = 3;
            this.incomeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.incomeTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(335, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Месяц учета:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(560, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Суммарный доход за месяц(руб):";
            // 
            // countBestButton
            // 
            this.countBestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countBestButton.Location = new System.Drawing.Point(275, 306);
            this.countBestButton.Name = "countBestButton";
            this.countBestButton.Size = new System.Drawing.Size(226, 42);
            this.countBestButton.TabIndex = 4;
            this.countBestButton.Text = "Рассчитать идеальное распределение средств\r\n";
            this.countBestButton.UseVisualStyleBackColor = true;
            this.countBestButton.Click += new System.EventHandler(this.countBestButton_Click);
            // 
            // everydayTextBox
            // 
            this.everydayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.everydayTextBox.Location = new System.Drawing.Point(97, 179);
            this.everydayTextBox.Name = "everydayTextBox";
            this.everydayTextBox.ReadOnly = true;
            this.everydayTextBox.Size = new System.Drawing.Size(143, 21);
            this.everydayTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(94, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Повседневные расходы:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(263, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Категории распределения средств(руб)";
            // 
            // capitalTextBox
            // 
            this.capitalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capitalTextBox.Location = new System.Drawing.Point(338, 179);
            this.capitalTextBox.Name = "capitalTextBox";
            this.capitalTextBox.ReadOnly = true;
            this.capitalTextBox.Size = new System.Drawing.Size(133, 21);
            this.capitalTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(335, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Сбережения:";
            // 
            // majorTextBox
            // 
            this.majorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.majorTextBox.Location = new System.Drawing.Point(563, 179);
            this.majorTextBox.Name = "majorTextBox";
            this.majorTextBox.ReadOnly = true;
            this.majorTextBox.Size = new System.Drawing.Size(143, 21);
            this.majorTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(560, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "Крупные покупки\r\n:";
            // 
            // irregularTextBox
            // 
            this.irregularTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.irregularTextBox.Location = new System.Drawing.Point(215, 251);
            this.irregularTextBox.Name = "irregularTextBox";
            this.irregularTextBox.ReadOnly = true;
            this.irregularTextBox.Size = new System.Drawing.Size(140, 21);
            this.irregularTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(212, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Нерегулярные расходы:";
            // 
            // entertainmetsTextBox
            // 
            this.entertainmetsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entertainmetsTextBox.Location = new System.Drawing.Point(445, 251);
            this.entertainmetsTextBox.Name = "entertainmetsTextBox";
            this.entertainmetsTextBox.ReadOnly = true;
            this.entertainmetsTextBox.Size = new System.Drawing.Size(139, 21);
            this.entertainmetsTextBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(442, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Развлечения:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.entertainmetsTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.irregularTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.majorTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.capitalTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.everydayTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.countBestButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.incomeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.accountingButton);
            this.Name = "Form1";
            this.Text = "Семейный бюджет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accountingButton;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox incomeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button countBestButton;
        private System.Windows.Forms.TextBox everydayTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox capitalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox majorTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox irregularTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox entertainmetsTextBox;
        private System.Windows.Forms.Label label9;
    }
}

