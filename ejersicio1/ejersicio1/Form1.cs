namespace ejersicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int incorrecto = Convert.ToInt32(textBox1.Text);
            int correcto = Convert.ToInt32(textBox2.Text);
            int blanco = Convert.ToInt32(textBox3.Text);

            int cuentaDePuntos = (correcto * 4) - (incorrecto - 1) + blanco;

            label4.Text = "Puntuacion : " + cuentaDePuntos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;

            label4.Text = "Puntuacion : ";

        }

    }
}
