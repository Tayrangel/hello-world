using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++) /*usado a opção insert snippet. 
                                              * Criou uma variável, que está sendo 
                                              * inicializada com 0 e 
                                              * incremento de 1 em 1.*/
            {
                //MessageBox.Show ("O valor do contador é:" + i);
                Console.WriteLine("O valor do contador é:" + i);
                //Writeline é o comando que pula linha.
            }
        }
    }
}
