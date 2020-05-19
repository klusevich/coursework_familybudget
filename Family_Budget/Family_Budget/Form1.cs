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
    public partial class Form1 : Form
    {
        private static int income, everyday, capital, major, irregular, entertainments;
        private static String month, nameOfPerson;

        public Form1()
        {
            InitializeComponent();
            nameTextBox.Select();
        }

        private void countBestButton_Click(object sender, EventArgs e)
        {
            if (incomeTextBox.Text.Trim() != "" && nameTextBox.Text.Trim() != "" && monthComboBox.Text.Trim() != "")
            {
                if (monthComboBox.SelectedIndex > -1)
                {
                    income = Convert.ToInt32(incomeTextBox.Text);
                    everyday = Convert.ToInt32(income * 0.6);
                    capital = Convert.ToInt32(income * 0.1);
                    major = Convert.ToInt32(income * 0.1);
                    irregular = Convert.ToInt32(income * 0.1);
                    entertainments = Convert.ToInt32(income * 0.1);
                    month = monthComboBox.Text;
                    nameOfPerson = nameTextBox.Text;

                    everydayTextBox.Text = everyday.ToString();
                    capitalTextBox.Text = capital.ToString();
                    majorTextBox.Text = major.ToString();
                    irregularTextBox.Text = irregular.ToString();
                    entertainmetsTextBox.Text = entertainments.ToString();

                    accountingButton.Visible = true;
                }
                else
                {
                    errorOccuring("Выберите корректное значение месяца!");
                }
            }
            else
            {
                errorOccuring("Заполните все поля!");
            }
        }

        private void accountingButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void incomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        public static int Everyday
        {
            get
            {
                return everyday;
            }
        }

        public static int Income
        {
            get
            {
                return income;
            }
        }

        public static int Capital
        {
            get
            {
                return capital;
            }
        }

        public static int Major
        {
            get
            {
                return major;
            }
        }

        public static int Entertainments
        {
            get
            {
                return entertainments;
            }
        }

        public static int Irregular
        {
            get
            {
                return irregular;
            }
        }

        public static String Month
        {
            get
            {
                return month;
            }
        }

        public static String NameOfPerson
        {
            get
            {
                return nameOfPerson;
            }
        }
    }
}
