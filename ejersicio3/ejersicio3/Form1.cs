namespace ejersicio3
{
    public partial class Form1 : Form
    {
        int a�o = DateTime.Now.Year;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "A�o actual es : " + a�o;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int edad = a�o - Convert.ToInt32(textBox1.Text);

                if (edad >= 18)
                {
                    label3.Text = "Sos mayor de edad";
                }
                else
                {
                    label3.Text = "Sos menor de edad";
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("A�o no valido");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = string.Empty;
            textBox1.Text = string.Empty;
        }
    }
}
