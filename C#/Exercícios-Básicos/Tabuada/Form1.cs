using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            lstTabuada.Items.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero, resultado, i; //declarando as variáveis como números inteiros
            i = 1;
            numero = int.Parse(txtNumero.Text); //conversão para inteiro
                while (i <= 10) /*condição enquanto i for menor ou igual a 10 
                                 * variável resultado realiza o cálculo de i 
                                 * multiplicado pelo número digitado.*/
                {
                resultado = i * numero;
                lstTabuada.Items.Add(String.Concat(numero, "*", i, "=", resultado));
                //listbox adiciona o item e concatena (numero*i=resultado)
                i = i + 1; //incremento
                }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
