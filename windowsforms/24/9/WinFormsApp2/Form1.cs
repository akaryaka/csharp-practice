namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            int pol = 0;
            int otr = 0;
            int zer = 0;

            for (int i = 1; i <= n; i++)
            {
                int a = rnd.Next(-50,50);
                listBox1.Items.Add(a);
                if (a == 0) zer++;
                if (a > 0) pol++;
                if (a < 0) otr++;

            }
            label2.Text = "Положительных чисел: " + pol.ToString() + "\n Отрицательных чисел" + otr.ToString() + "\n Количество нулей" + zer.ToString();
        }
    }
}
