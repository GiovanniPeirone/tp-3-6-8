namespace ejersicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tarifasPorHora = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);

            label3.Text = tarifasPorHora.ToString();
        }
    }
}
