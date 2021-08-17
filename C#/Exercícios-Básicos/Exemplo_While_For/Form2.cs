using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_While_For
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int i; //declaração da variável tipo inteiro
            i = 2021; //atribuição do valor do ano de 2021

                while (i >= 1950) /*enquanto  o valor foi maior ou igual a 1950 
                                   * o contador fará o decremento.*/
            {
                cboAno.Items.Add(i); //itens são adicionados no contador
                i--;
            }
        }
    }
}
