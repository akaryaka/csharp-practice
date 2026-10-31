namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                this.Text = System.IO.Path.GetFileName(filename);
                richTextBox1.Text = System.IO.File.ReadAllText(filename);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new System.IO.MemoryStream();
            Stream filestream;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filestream = saveFileDialog1.OpenFile();
                memoryStream.Position = 0;
                richTextBox1.SaveFile(memoryStream, RichTextBoxStreamType.PlainText);
                memoryStream.WriteTo(filestream);
                filestream.Close();
            }
        }
    }
}
