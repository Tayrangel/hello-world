using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Catina
{
    public partial class Form1 : Form
    {
        //declaração de 3 arrays para armazenar 6 produtos com código e valor
        string[] produtos = new string[6];
        string[] codigo = new string[6];
        double[] valor = new double[6];
        double soma;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 3) /*inicia a condição, o usuário digita 
                                          * um código de 5 digitos, length retorna
                                          a quantidade de caracter*/
            {
                int indice = 0;
                for (int prod = 1; prod < codigo.Length; prod++) /*faça enquanto
                                                               * o prod for menor ou
                                                               * igual a quantidade
                                                               * de itens do array*/
                {
                    if (txtCodigo.Text == codigo[prod])
                    {
                        indice = prod;
                    }
                }
                    if (indice == 0) /*se foi encontrado o produto retorna as informações
                                      * de acordo com o indice, caso contrário, informa
                                      * a mensagem de produto não encontrado*/
                    {
                        MessageBox.Show("Produto não encontrado");
                    }
                    else
                    {
                        lstCaixa.Items.Add(txtCodigo.Text + "--" + produtos[indice] +
                        "-- R$" + valor[indice]); /*conteúdo adicionado a listbox
                                                 concatena as inforamções*/
                        soma = soma + valor[indice];
                        label3.Text = ("Valor Total R$" + soma);
                        //pctImage.ImageLocation = "c:/imagens/" + codigo[indice] + "jpg.";

                        txtCodigo.Text = ""; /*após o conteúdo ser inserido na listbox 
                                      * o textbox será limpo*/
                        txtCodigo.Focus(); /*o focus posiciona o cursor para o textbox 
                                    * para a nova digitação*/
                    }
                
            
            }
        }

        private void lstCaixa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarArray(); // ao entrar no form load será chamado o método
            soma = 0;
        }    
             private void carregarArray() /* criação do método para ser chamado quando
                                          * necessário, evitando repetir o código
                                          * várias vezes*/
             {
               //codigo, produtos e valores referente os arrays que foram declarados.
                codigo[1] = "001";
                codigo[2] = "002";
                codigo[3] = "003";
                codigo[4] = "004";
                codigo[5] = "005";
                
                produtos[1] = "Pastel";
                produtos[2] = "Coxinha";
                produtos[3] = "Hot Dog";
                produtos[4] = "Chocolate";
                produtos[5] = "Suco";

                valor[1] = 6.00;
                valor[2] = 5.00;
                valor[3] = 12.00;
                valor[4] = 3.5;
                valor[5] = 8.00;

             }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pctImage_Click(object sender, EventArgs e)
        {

        }

    
    }
}
