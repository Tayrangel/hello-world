using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Conectar o Form Secundário (Filho) Cadastro_Usuario, 
             * no Form Principal (Mãe) MDIParent1. */
            Form childform = new cadastro_usuario();
            childform.MdiParent = this;
            childform.Show();
        }
    }
}
