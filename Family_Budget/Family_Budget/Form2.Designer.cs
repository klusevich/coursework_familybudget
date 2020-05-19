namespace Family_Budget
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputExpensesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countedExpensesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // inputExpensesTextBox
            // 
            this.inputExpensesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputExpensesTextBox.Location = new System.Drawing.Point(12, 70);
            this.inputExpensesTextBox.Multiline = true;
            this.inputExpensesTextBox.Name = "inputExpensesTextBox";
            this.inputExpensesTextBox.ReadOnly = true;
            this.inputExpensesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputExpensesTextBox.Size = new System.Drawing.Size(295, 186);
            this.inputExpensesTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ваши расходы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(547, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Просчитанные расходы:";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(364, 237);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(132, 41);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.Location = new System.Drawing.Point(364, 284);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(132, 41);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "Помощь";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(361, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Категория расхода:";
            // 
            // sumTextBox
            // 
            this.sumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumTextBox.Location = new System.Drawing.Point(364, 70);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(119, 21);
            this.sumTextBox.TabIndex = 11;
            this.sumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sumTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(361, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Сумма расхода(руб):";
            // 
            // countedExpensesRichTextBox
            // 
            this.countedExpensesRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countedExpensesRichTextBox.Location = new System.Drawing.Point(550, 72);
            this.countedExpensesRichTextBox.Name = "countedExpensesRichTextBox";
            this.countedExpensesRichTextBox.Size = new System.Drawing.Size(238, 184);
            this.countedExpensesRichTextBox.TabIndex = 13;
            this.countedExpensesRichTextBox.Text = "";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Повседневные расходы",
            "Сбережения",
            "Крупные покупки",
            "Нерегулярные расходы",
            "Развлечения"});
            this.categoryComboBox.Location = new System.Drawing.Point(341, 117);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(155, 23);
            this.categoryComboBox.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.countedExpensesRichTextBox);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputExpensesTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Учет расходов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputExpensesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox countedExpensesRichTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
    }
}