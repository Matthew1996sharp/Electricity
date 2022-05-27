/* Программа "Электроэнергия" показывает, как одна функция 
 * может обрабатывать события разных, но однотипных компонентов.
 * В данном примере это поля ввода цены за кВт электроэнергии 
 * (предыдущее и текущее показания счётчика).
 * Обрабатываемое событие это событие отпускания клавиши KeyUp.
 * Функция обработки события KeyUp создается для поля PreviousBox,
 * а затем назначается как функция для обработки событий для полей CurrentBox и PriceBox.*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity
{
    public partial class ElectricityForm : Form
    {
        public ElectricityForm()
        {
            InitializeComponent();
        }

        //загрузка формы
        private void ElectricityForm_Load(object sender, EventArgs e)
        {
            // Блокируем кнопку "Вычислить".
            // Она становится доступной только тогда,
            // когда введены данные во все поля
            CalcButton.Enabled = false;
        }

        //нажатие клавиши в поле "Предыдущее показание счётчика"
        private void PreviousBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //контроль правильности вводимых данных
            if (!Char.IsDigit(e.KeyChar) 
                && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") 
                    && (PreviousBox.Text.IndexOf(",") == -1)))
                        e.Handled = true;
            }
            // Если нажата кнопка "Enter", фокусируемся
            // на поле ввода "Текущее показание счётчика"
            if (e.KeyChar.Equals((char)13)) CurrentBox.Focus();
        }

        private void CurrentBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //контроль правильности вводимых данных
            if (!Char.IsDigit(e.KeyChar) 
                && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") 
                    && (CurrentBox.Text.IndexOf(",") == -1)))
                    e.Handled = true;
            }
            // Если нажата кнопка "Enter", фокусируемся
            // на поле ввода "Цены за кВт электроэнергии"
            if (e.KeyChar.Equals((char)13)) PriceBox.Focus();
        }

        private void PriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) 
                && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") 
                    && (PriceBox.Text.IndexOf(",") == -1)))
                    e.Handled = true;
            }
        }

        // Обработка события отпускания клавиши для полей "Цена",
        // "Предыдущее показание счётчика" и "Текущее показание счётчика"
        private void PreviousBox_KeyUp(object sender, KeyEventArgs e)
        {
            if ((PreviousBox.Text.Length > 0)
                && (CurrentBox.Text.Length > 0)
                && (PriceBox.Text.Length > 0))
                CalcButton.Enabled = true;
            else CalcButton.Enabled = false;
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = "";

            try
            {
                float previous = Convert.ToSingle(PreviousBox.Text);
                float current = Convert.ToSingle(CurrentBox.Text);
                float price = Convert.ToSingle(PriceBox.Text);

                if (current >= previous)
                {
                    float total = (current - previous) * price;
                    OutputLabel.Text = "Сумма к оплате: " + total.ToString("C");
                }
                else
                {
                    MessageBox.Show("Ошибка исходных данных.\n" + 
                        "Текущее значение показания счётчика\n" + 
                        "меньше предыдущего.", "Электроэнергия", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception exc)
            {
                MessageBox.Show("Ошибка исходных данных.\n" +
                        "Исходные данные имеют неверный формат\n" +
                        exc.Message, "Электроэнергия",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
