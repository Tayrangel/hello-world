using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cboSemana.Text)
            /* o conteúdo da combobox será analisado e de acordo com
             * a opção escolhida, aparecerá uma determinada mensagem.
             * O break serve para sair de determinado comando, neste exemplo
             * em execuçãp. */
            {
                case "Domingo":
                    MessageBox.Show("Domingo é o primeiro dia da semana", "Mensagem", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Segunda":
                    MessageBox.Show("Segunda é o segundo dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Terça":
                    MessageBox.Show("Terça é o terceiro dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quarta":
                    MessageBox.Show("Quarta é o quarto dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quinta":
                    MessageBox.Show("Quinta é o quinto dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Sexta":
                    MessageBox.Show("Sexta é o sexto dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Sábado":
                    MessageBox.Show("Sábado é o sétimo dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            //Declara o objeto novo tipo form e chama em seguida através do método Show.
            novo.Show();
            //fecha o formulário atual;
            this.Visible = false;
        }
    }
}
