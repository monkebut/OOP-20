namespace OOP_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "Ваше рівняння:";
                label5.Text = "Корінь рівняння:";

                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                label4.Text += $" {a}x = {b}";

                float result = 0;
                if(a != 0)
                {
                    result = b / a;
                    label5.Text += result;
                }
                else if(a == 0 && b == 0)
                {
                    label5.Text = "Рівняння має безліч розв'язків!";
                }
                else
                {
                    throw new DivideByZeroException();
                }
            }
            catch (FormatException) 
            {
                label5.Text = "Невірно введений формат данних!";
            }
            catch (DivideByZeroException)
            {
                label5.Text = "На нуль ділити не можна!";
            }
            finally
            {
                MessageBox.Show("     Програма закінчила свою роботу!\nЩоб продовжити, просто натисніть 'ОК'.");
            }
        }
    }
}
