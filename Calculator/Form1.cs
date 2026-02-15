namespace WinFormsApp2
{
    public partial class Calculater : Form
    {
        public Calculater()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Button_0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";//добавление в textBox1 записи при нажатии на кнопки
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //метод работат таким образом, что в массив добавляется на один меньше с каждыи нажатиаем на кнопку 

            char[] c = new char[textBox1.Text.Length - 1];//массив для добавления элемнтов строки длиной с длину Text - 1
            textBox1.Text.CopyTo(0, c, 0, c.Length);//копирование текста в массив CopyTo(с какого элемента, в какой массив, с какой позиции будет копироваться из массива юникода, длина массива)
            textBox1.Text = new string(c);//преобразование массива в строку 


        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Contains("+"))

                {
                    string[] s = textBox1.Text.Split("+");

                    double x = Convert.ToInt32(s[0]);
                    double y = Convert.ToInt32(s[1]);

                    double z = x + y;
                    textBox1.Text = z.ToString();
                }

                else if (textBox1.Text.Contains("-"))
                {
                    string[] s = textBox1.Text.Split("-");

                    double x = Convert.ToInt32(s[0]);
                    double y = Convert.ToInt32(s[1]);

                    double z = x - y;
                    textBox1.Text = z.ToString();
                }

                else if (textBox1.Text.Contains("*"))
                {
                    string[] s = textBox1.Text.Split("*");

                    double x = Convert.ToInt32(s[0]);
                    double y = Convert.ToInt32(s[1]);

                    double z = x * y;

                    textBox1.Text = z.ToString();

                }

                else if (textBox1.Text.Contains("/"))
                {
                    string[] s = textBox1.Text.Split("/");

                    double x = Convert.ToInt32(s[0]);
                    double y = Convert.ToInt32(s[1]);

                    double z = x / y;

                    if (y != 0)
                        textBox1.Text = z.ToString();
                    else textBox1.Text = "На 0 делить нельзя!";
                }
                else { textBox1.Text = textBox1.Text.Trim(); }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неверный ввод. Ошибка: {ex.Message}");

            }

        }


    }
}
