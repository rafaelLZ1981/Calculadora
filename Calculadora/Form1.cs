namespace Calculadora
{
    public partial class Form1 : Form

    {
        decimal n1, n2;
        string operacao = "";


        public Form1()
        {
            InitializeComponent();
            textResultado.Text = "0";

        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            textResultado.Text = "0";
            operacao = "";
            n1 = 0;
            n2 = 0;
            lblHistorico.Text = "";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            GerarStringTextResultado("1");

        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            GerarStringTextResultado("2");
        }
        public void GerarStringTextResultado(string textoAcrescentar)
        {
            if (textResultado.Text == "0" && textoAcrescentar != ",")
            {

                textResultado.Text = textoAcrescentar;
            }
            else
            {
                textResultado.Text += textoAcrescentar;
            }
            lblHistorico.Text += textoAcrescentar;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            GerarStringTextResultado("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            GerarStringTextResultado("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            GerarStringTextResultado("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            GerarStringTextResultado("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            GerarStringTextResultado("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            GerarStringTextResultado("8");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GerarStringTextResultado("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            GerarStringTextResultado("0");
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!textResultado.Text.Contains(","))
            {
                GerarStringTextResultado(",");
            }

        }
        public void calcularOperacao()
        {
            decimal resultado = 0;

            switch (operacao)
            {

                case "+":
                    resultado = n1 + n2;
                    break;
                case "-":
                    resultado = n1 - n2;
                    break;
                case "*":
                    resultado = n1 * n2;
                    break;
                case "/":
                    if (n2 != 0)
                        resultado = n1 / n2;
                    break;

            }
            textResultado.Text = resultado.ToString();
            lblHistorico.Text += "= " + resultado;
            operacao = "";

        }
        public void CriarOperacao(string operacaoParametro)
        {
            if (operacao != "")
            {

                n2 = Convert.ToDecimal(textResultado.Text);
                calcularOperacao();
            }

            operacao = operacaoParametro;
            n1 = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "0";

            lblHistorico.Text += " " + operacao + " ";

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            CriarOperacao("+");

        }

        private void btnDiferenca_Click(object sender, EventArgs e)
        {
            CriarOperacao("-");
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            CriarOperacao("*");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            CriarOperacao("/");
        }

        private void btnIqual_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDecimal(textResultado.Text);
            calcularOperacao();

        }

        private void btnTrocaSinal_Click(object sender, EventArgs e)
        {
            if (textResultado.Text.Contains("-"))
            {
                textResultado.Text = textResultado.Text.Remove(0, 1);
                lblHistorico.Text = "(" + lblHistorico.Text + ") * -1";

            }
            else
            {
                textResultado.Text = "-" + textResultado.Text;
                lblHistorico.Text = "(" + lblHistorico.Text + ") * -1";
            }

        }

        private void lblHistorico_Click(object sender, EventArgs e)
        {

        }
    }
}