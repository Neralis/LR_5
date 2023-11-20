using System;
using System.Windows.Forms;

namespace LR_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из текстовых полей
                double roomLength = double.Parse(textBox1.Text);
                double roomWidth = double.Parse(textBox2.Text);
                double roomHeight = double.Parse(textBox3.Text);
                double windowLength = double.Parse(textBox4.Text);
                double windowHeight = double.Parse(textBox5.Text);
                int windowCount = int.Parse(textBox6.Text);
                double doorLength = double.Parse(textBox7.Text);
                double doorWidth = double.Parse(textBox8.Text);
                int doorCount = int.Parse(textBox9.Text);

                // Получаем выбранную ширину рулона
                double rollWidth = 0.0;
                if (radioButton1.Checked)
                    rollWidth = 0.8;
                else if (radioButton2.Checked)
                    rollWidth = 1.0;
                else if (radioButton3.Checked)
                    rollWidth = 1.2;

                // Вычисляем площадь стен
                double totalWallArea = 2 * (roomLength + roomWidth) * roomHeight - windowCount * windowLength * windowHeight - doorCount * doorLength * doorWidth;

                // Вычисляем количество рулонов
                double rollsNeeded = totalWallArea / (rollWidth * 10);

                // Выводим результат
                MessageBox.Show($"Необходимо {Math.Ceiling(rollsNeeded)} рулонов обоев.", "Расчет завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
