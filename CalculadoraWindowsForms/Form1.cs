using System;
using System.Windows.Forms;

namespace CalculadoraWindowsForms
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        double numero1;
        double numero2;
        double resultado;
        char operador;
        private void btn1_Click(object sender, EventArgs e)
        {
            txtTelaResultado.Text += "1"; // usando o += e pra manter o 1 na tela. Se não usarmos ele ira subustituir o numero. 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTelaResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTelaResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTelaResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTelaResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTelaResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTelaResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTelaResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTelaResultado.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTelaResultado.Text += "0";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtTelaResultado.Text += ".";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtTelaResultado.Text += ",";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            
            numero2 = Convert.ToDouble(txtTelaResultado.Text);

            switch (operador)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case 'X':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    resultado = numero1 / numero2;
                    break;
            }
            lblCalculo.Text += numero2;
            txtTelaResultado.Text = resultado.ToString();

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtTelaResultado.Text);
            txtTelaResultado.Text += "-";
            operador = '-';
            lblCalculo.Text = txtTelaResultado.Text;
            lblCalculo.Visible = true;
            txtTelaResultado.Clear();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtTelaResultado.Text);
            txtTelaResultado.Text += "+";
            operador = '+';
            lblCalculo.Text = txtTelaResultado.Text;
            lblCalculo.Visible = true;
            txtTelaResultado.Clear();
           
            
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtTelaResultado.Text);
            txtTelaResultado.Text += "X";
            operador = 'X';
            lblCalculo.Text = txtTelaResultado.Text;
            lblCalculo.Visible = true;
            txtTelaResultado.Clear();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtTelaResultado.Text);
            txtTelaResultado.Text += "/";
            operador = '/';
            lblCalculo.Text = txtTelaResultado.Text;
            lblCalculo.Visible = true;
            txtTelaResultado.Clear();
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            txtTelaResultado.Clear();
            lblCalculo.Text = string.Empty;
            
            //txtTelaResultado.Text = "0";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if(txtTelaResultado.Text != string.Empty)
            {
                txtTelaResultado.Text = txtTelaResultado.Text.Remove(txtTelaResultado.Text.Length - 1);
            }
            
            lblCalculo.Text = lblCalculo.Text.Remove(lblCalculo.Text.Length - 1);
        }
    }
}
