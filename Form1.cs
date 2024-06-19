namespace Calculadora1
{
    public partial class Form1 : Form
    {

        public Decimal Valor { get; set; }
        public Decimal Resultado { get; set; }

        private Operação OperaçãoSelecionada { get; set; }


        private enum Operação
        {
            Adição, 
            Subtração,
            Divisão,
            Multiplicação
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

       


      

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ",";
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

                            //Sinais//          
        //-------------------------------------------------//
        private void buttonVezes_Click(object sender, EventArgs e)
        {
            OperaçãoSelecionada = Operação.Multiplicação;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            OperaçãoSelecionada = Operação.Divisão;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }
        private void buttonMenos_Click(object sender, EventArgs e)
        {
            OperaçãoSelecionada = Operação.Subtração;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }
        int i = 10;

        private void buttonMais_Click(object sender, EventArgs e)
        {
            OperaçãoSelecionada = Operação.Adição;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }   
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            switch (OperaçãoSelecionada)
            {
                case Operação.Adição:
                    Resultado = Valor += Convert.ToDecimal(txtResultado.Text);
                    +=i;
                    break;

                case Operação.Subtração:
                    Resultado = Valor -= Convert.ToDecimal(txtResultado.Text);
                    break;

                case Operação.Multiplicação:
                    Resultado = Valor *= Convert.ToDecimal(txtResultado.Text);
                    break;

                case Operação.Divisão:
                    Resultado = Valor /= Convert.ToDecimal(txtResultado.Text);

                    break;

            }
            txtResultado.Text = Convert.ToString(Resultado);
        }
    }
}