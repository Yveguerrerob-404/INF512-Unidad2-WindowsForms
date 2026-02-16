namespace Calculadora_Propinas
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertimos el texto de los cuadros a números
                double cuenta = double.Parse(textBox1.Text);
                double porcentaje = double.Parse(textBox2.Text);

                // Calculamos la propina y el total
                double propina = cuenta * (porcentaje / 100);
                double total = cuenta + propina;

                // Mostramos el resultado en la etiqueta
                label3.Text = "Total a pagar: $" + total.ToString("N2");
            }
            catch
            {
                // Si el usuario deja algo vacío o pone letras, avisamos
                MessageBox.Show("Por favor, ingresa solo números válidos.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
