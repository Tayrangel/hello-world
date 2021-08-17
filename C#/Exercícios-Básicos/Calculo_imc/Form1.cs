using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double peso, altura, imc; //declaração de variáveis
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);
            /* textbox recebe conteudo da variável imc = resultado do calculo
             * definição de utilização de duas casas decimais*/
            txtImc.Text = imc.ToString("0.00");
            /* condições de acordo com o resultado dos cálculos, serão exibidas mensagens, 
             * configurações das messagebox (mensagem, botões e ícones),
             * como são várias temos um encadeamento de ifs*/
            if (imc < 18.49)
                MessageBox.Show("Situação: Você está abaixo do peso!", "Cálculo de IMC", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 24.99)
                MessageBox.Show("Situação: Você está com peso ideal!", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 29.99)
                MessageBox.Show("Situação: Você está acima do peso!", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 34.99)
                MessageBox.Show("Situação: Você está com obesidade tipo I!", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (imc < 39.99)
                MessageBox.Show("Situação: Você está com obesidade tipo II!", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("Situação: Você está com obesidade tipo III!", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtImc.Text = "";
        }
    }
}
