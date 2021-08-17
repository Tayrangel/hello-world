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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            switch (cboOpcao.Text)
            /*De acordo com o final da placa escolhido no combobox
             * será exibida uma mensagem informativa.*/
            {
                case "1 ou 2":
                    lblRes.Text = "Seu rodízio é segunda-feira!";
                        break;
                case "3 ou 4":
                    lblRes.Text = "Seu rodízio é terça-feira!";
                        break;
                case "5 ou 6":
                    lblRes.Text = "Seu rodízio é quarta-feira!";
                        break;
                case "7 ou 8":
                    lblRes.Text = "Seu rodízio é quinta-feira!";
                        break;
                case "9 ou 0":
                    lblRes.Text = "Seu rodízio é sexta-feira!";
                        break;
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1(); //apresenta o formulário e chama em seguida
            novo.Show(); //fecha o formulário atual
            this.Visible = false;        
        }
    }
}
