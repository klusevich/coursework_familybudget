using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_Budget
{
    public partial class Form2 : Form
    {
        private static String category;
        private static int sum, checkEveryday, checkCapital, checkMajor, checkIrregular, checkEntertainments;
        private static StringBuilder stringBuilder = new StringBuilder();

        public Form2()
        {
            InitializeComponent();
            countedExpensesRichTextBox.Text = "Повседневные расходы: " + Form1.Everyday + "\r\n" + "Накопления: " + Form1.Capital + "\r\n" + "Крупные покупки: " + Form1.Major + "\r\n" + "Нерегулярные расходы: " + Form1.Irregular + "\r\n" + "Развлечения: " + Form1.Entertainments + "\r\n";
        }

        

        private void addButton_Click(object sender, EventArgs e)
        {
            if (categoryComboBox.Text.Trim() != "" && sumTextBox.Text.Trim() != "")
            {
                if (categoryComboBox.SelectedIndex > -1)
                {
                    category = categoryComboBox.Text;
                    sum = Convert.ToInt32(sumTextBox.Text);

                    switch(category)
                    {
                        case "Повседневные расходы":
                            checkEveryday += sum;

                            if(checkEveryday > Form1.Everyday)
                            {
                                countedExpensesRichTextBox.Select(countedExpensesRichTextBox.Text.IndexOf("Повседневные расходы: " + Form1.Everyday), ("Повседневные расходы: " + Form1.Everyday).Length);
                                countedExpensesRichTextBox.SelectionColor = Color.Red;
                                warningOccuring("Вы превысили повседневные расходы!");
                            }

                            stringBuilder.Append(Form1.NameOfPerson + ", " + Form1.Month + ", " + category + ", " + sum + "\r\n");
                            inputExpensesTextBox.Text = stringBuilder.ToString();
                            break;

                        case "Сбережения":
                            checkCapital += sum;

                            if (checkCapital > Form1.Capital)
                            {
                                countedExpensesRichTextBox.Select(countedExpensesRichTextBox.Text.IndexOf("Накопления: " + Form1.Capital), ("Накопления: " + Form1.Capital).Length);
                                countedExpensesRichTextBox.SelectionColor = Color.Red;
                                warningOccuring("Вы превысили расходы на сбережения!");
                            }

                            stringBuilder.Append(Form1.NameOfPerson + ", " + Form1.Month + ", " + category + ", " + sum + "\r\n");
                            inputExpensesTextBox.Text = stringBuilder.ToString();
                            break;

                        case "Крупные покупки":
                            checkMajor += sum;

                            if (checkMajor > Form1.Major)
                            {
                                countedExpensesRichTextBox.Select(countedExpensesRichTextBox.Text.IndexOf("Крупные покупки: " + Form1.Major), ("Крупные покупки: " + Form1.Major).Length);
                                countedExpensesRichTextBox.SelectionColor = Color.Red;
                                warningOccuring("Вы превысили расходы на крупные покупки!");
                            }

                            stringBuilder.Append(Form1.NameOfPerson + ", " + Form1.Month + ", " + category + ", " + sum + "\r\n");
                            inputExpensesTextBox.Text = stringBuilder.ToString();
                            break;

                        case "Нерегулярные расходы":
                            checkIrregular += sum;

                            if (checkIrregular > Form1.Irregular)
                            {
                                countedExpensesRichTextBox.Select(countedExpensesRichTextBox.Text.IndexOf("Нерегулярные расходы: " + Form1.Irregular), ("Нерегулярные расходы: " + Form1.Irregular).Length);
                                countedExpensesRichTextBox.SelectionColor = Color.Red;
                                warningOccuring("Вы превысили нерегулярные расходы!");
                            }

                            stringBuilder.Append(Form1.NameOfPerson + ", " + Form1.Month + ", " + category + ", " + sum + "\r\n");
                            inputExpensesTextBox.Text = stringBuilder.ToString();
                            break;

                        case "Развлечения":
                            checkEntertainments += sum;

                            if (checkEntertainments > Form1.Entertainments)
                            {
                                countedExpensesRichTextBox.Select(countedExpensesRichTextBox.Text.IndexOf("Развлечения: " + Form1.Entertainments), ("Развлечения: " + Form1.Entertainments).Length);
                                countedExpensesRichTextBox.SelectionColor = Color.Red;
                                warningOccuring("Вы превысили расходы на развлечения!");
                            }

                            stringBuilder.Append(Form1.NameOfPerson + ", " + Form1.Month + ", " + category + ", " + sum + "\r\n");
                            inputExpensesTextBox.Text = stringBuilder.ToString();
                            break;

                        default:
                            errorOccuring("Выберите корректное значение категории расхода!");
                            break;
                    }
                }
                else
                {
                    errorOccuring("Выберите корректное значение категории расхода!");
                }
            }
            else
            {
                errorOccuring("Заполните все поля!");
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Планирование бюджета по методу 60-10-10-10-10\r\n60% от вашего дохода отправляем на повседневные расходы,\r\n10 % — на сбережения,\r\n10 % — на крупные покупки(автомобиль, ремонт квартиры и прочее).Эти суммы могут идти также на погашение долгов,\r\n10 % — на нерегулярные расходы.Что к ним относится — те расходы, которые возникают время от времени(сломался автомобиль, заболел зуб, пригласили на день рождения и так далее),\r\n10 % — на развлечения.", "Помощь");
        }

        private void sumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[0-9]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void errorOccuring(String message)
        {
            MessageBox.Show(message, "Ошибка");
        }

        private void warningOccuring(String message)
        {
            MessageBox.Show(message, "Предупреждение");
        }
    }
}
