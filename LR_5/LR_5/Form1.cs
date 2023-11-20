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
            // Initialization code can go here if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double P = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text) * double.Parse(textBox3.Text)) -
                       (double.Parse(textBox4.Text) * double.Parse(textBox5.Text) * double.Parse(textBox6.Text) -
                        (double.Parse(textBox7.Text) * double.Parse(textBox8.Text) * double.Parse(textBox9.Text)));

            // Declare and initialize count outside the switch statement
            double count = 0;

            RadioButton rdbtn = GetCheckedRadioButton(); // Call the method to get the checked radio button

            if (rdbtn != null)
            {
                string currentButton = rdbtn.Name;

                switch (currentButton)
                {
                    case "radioButton1":
                        count = Math.Ceiling(P / (10 * 0.8)); // Округляем в большую сторону
                        break;
                    case "radioButton2":
                        count = Math.Ceiling(P / (10 * 1));
                        break;
                    case "radioButton3":
                        count = Math.Ceiling(P / (10 * 1.2));
                        break;
                    default:
                        // Handle other cases if needed
                        break;
                }

                // Now you can use the 'count' variable as needed
                // For example, you might want to display it in a label or perform other actions.
                MessageBox.Show($"Нужно рулонов: {count}");
            }
            else
            {
                // Handle the case where no radio button is checked
                MessageBox.Show("Выберите ширину рулона");
            }
        }

        private RadioButton GetCheckedRadioButton()
        {
            foreach (Control control in Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton;
                }
            }
            return null;
        }
    }
}
