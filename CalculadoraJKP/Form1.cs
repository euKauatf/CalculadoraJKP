using CalculadoraJKP.Utilitarios;

namespace CalculadoraJKP
{
    public partial class Form1 : Form
    {
        double? numero1;
        double? numero2;
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtResult.Text += ".";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (numero1 == null)
            {
                numero1 = Convert.ToDouble(txtResult.Text);
                txtResult.Text = "";
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {

        }
    }
}
