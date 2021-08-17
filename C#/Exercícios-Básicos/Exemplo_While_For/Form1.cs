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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i; //Declaração da variável do tipo inteiro
            for (i = 2021; i >= 1950; i--) /*Laço for, atribuindo ao contador o 
                                              * ano de 2021 até 1950, com decremento.*/
            {
                cboAno.Items.Add(i); //os itens são adicionados no contador.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2(); //declara o objeto novo tipo form
            novo.Show(); //chama novo objeto 
            this.Visible = false; //fecha o formulário atual

        }
    }
}
