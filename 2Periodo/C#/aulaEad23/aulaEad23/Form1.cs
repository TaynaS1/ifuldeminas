namespace aulaEad23
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double imc = peso / (altura * altura);
            lblResultado.Text = $"IMC Calculado:{imc:f2}";
            if (imc < 18.5)
            {
                txtObs.Text = "Abaixo do peso!";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                txtObs.Text = "Peso normal!";
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                txtObs.Text = "Acima do peso!";
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                txtObs.Text = "Obsidade nivel I!";
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                txtObs.Text = "Obsidade nivel II!";
            }
            else
            {
                txtObs.Text = "Obsidade nivel III";
            }
        }
    }
}
