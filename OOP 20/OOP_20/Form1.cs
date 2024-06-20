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
                label4.Text = "���� �������:";
                label5.Text = "����� �������:";

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
                    label5.Text = "г������ �� ����� ����'����!";
                }
                else
                {
                    throw new DivideByZeroException();
                }
            }
            catch (FormatException) 
            {
                label5.Text = "������ �������� ������ ������!";
            }
            catch (DivideByZeroException)
            {
                label5.Text = "�� ���� ����� �� �����!";
            }
            finally
            {
                MessageBox.Show("     �������� �������� ���� ������!\n��� ����������, ������ �������� '��'.");
            }
        }
    }
}
