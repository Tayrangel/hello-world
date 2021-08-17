using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tratamento_Erros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e) //criação da classe calcular
        {
            int num1, num2, resultado; //criação das variaveis como inteiros
            
            try /* tratamento de erro, try é a condição que deve ser executada, trabalha 
                 * juntamente com o catch que é o tratamento, caso o usuário não respeite
                 * a primeira condição*/
            { //iniciando o método
                num1 = int.Parse(txtNum1.Text); /*tranformar os números em texto, com o auxilio
                                                 * do parse que é uma conversão de números
                                                 * inteiros em sinal 32bits*/
                num2 = int.Parse(txtNum2.Text);
                resultado = num1 + num2; 
                txtResultado.Text = resultado.ToString();
            }
            
            catch(Exception) /*catch é o tratamento de erro utilizado quando a pessoa não 
                              * respeita as condições impostas no método */

            {
                MessageBox.Show("Digite valores numéricos", "Erro") ; /* quando ocorrer o erro será
                                                                       * digitada a mensagem que está na
                                                                       * primeira "" e a caixa de mensagem
                                                                       * chamará erro, descrita na segunda "" */
            }
            finally
            {
                MessageBox.Show("Aperte Ok, para sair!");
                Close();
            }
        }
    }
}
