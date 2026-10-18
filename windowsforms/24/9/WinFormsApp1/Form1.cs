namespace WinFormsApp1
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
            double y;
            listBox1.Items.Add(String.Format("{0,5}{1,20}", "x", "y"));
            listBox1.Items.Add("-----------------------------------");
            for (double x = 0; x <= 2; x += 0.2)
            {
                y = Math.Sin(x);
                listBox1.Items.Add(String.Format("\r\n{0,-5:F1} {1,20:F2} ", x, y));
            }
        }
    }
}
