using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVetor_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[4]; //declarar e instanciar o vetor
            vetor[0] = 7; //atribuição de valores de acordo com cada índice
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;
            int valor = vetor[1]; //declarar a variável valor para acessar o vetor
            System.Array.Sort(vetor); //esta classe ordena o vetor
            for (int index = 0; index < 4; index++) //percorre o vetor em cada índice
            MessageBox.Show(vetor[index].ToString(), "Array"); /*para index menor que 4
                                                                * ele exibe mensagem com
                                                                * o vetor na messagebox.*/

        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            string[] semana = new string[7]; //declarar e instanciar o valor
            semana[0] = "Domingo"; //atribuir valores de acordo com cada índice
            semana[1] = "Segunda";
            semana[2] = "Terça";
            semana[3] = "Quarta";
            semana[4] = "Quinta";
            semana[5] = "Sexta";
            semana[6] = "Sábado";

            //string valor = semana[1]; //declara a variável valor para acessar o vetor
            for (int index = 0; index < 7; index++) //comando percorre o índice e mostra mensagem
                MessageBox.Show(semana[index].ToString(), "array"); 


        }
    }
}
