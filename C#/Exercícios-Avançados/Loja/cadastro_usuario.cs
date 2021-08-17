using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.DTO;
using Loja.BLL;

namespace Loja
{
    public partial class cadastro_usuario : Form
    {
        string modo = ""; /*criação desta variável para registrar que o 
                           * usuário clicou o botão novo (para cadastrar novo usuário)*/
        int codUsuSelecionado = -1;
        public cadastro_usuario()
        {
            InitializeComponent();
        }

        private void cadastro_usuario_Load(object sender, EventArgs e)
        /*criando o metodo para atualizacao do cadastro do usuario logo 
         * ápos confirmação do cadastro, inserindo as informações direto no Grid*/
        {
            carregaGrid();
        }
        private void carregaGrid()
        {
            try
            {
                IList<Usuario_DTO> listUsuario_DTO = new List<Usuario_DTO>();
                listUsuario_DTO = new UsuarioBLL().cargaUsuario();

                //preencher os dados no Datagridview
                dataGridView1.DataSource = listUsuario_DTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //linha atual que estiver selecionada aparecerá nos campos acima do DataGrid
            int sel = dataGridView1.CurrentRow.Index;

            //valor de cada DataGrid será enviado para cada textbox
            codUsuSelecionado = Convert.ToInt32(dataGridView1["cod_usuario", sel].Value);
            txtNome.Text = Convert.ToString(dataGridView1["nome", sel].Value);
            txtLogin.Text = Convert.ToString(dataGridView1["login", sel].Value);
            txtEmail.Text = Convert.ToString(dataGridView1["email", sel].Value);
            txtSenha.Text = Convert.ToString(dataGridView1["senha", sel].Value);
            txtCadastro.Text = Convert.ToString(dataGridView1["cadastro", sel].Value);

            //condição se o cadastro for "A" deverá retornar como Ativo, senão Inativo

            if (Convert.ToString(dataGridView1["situacao", sel].Value) == "A")
            {
                cboSituacao.Text = "Ativo";
            }
            else
            {
                cboSituacao.Text = "Inativo";
            }
            //para o perfil 1=Administrador, 2=Operador, 3=Gerencial
            switch (Convert.ToString(dataGridView1["perfil", sel].Value))
            {
                case "1":
                    cboPerfil.Text = "Administrador";
                    break;
                case "2":
                    cboPerfil.Text = "Operador";
                    break;
                case "3":
                    cboPerfil.Text = "Gerencial";
                    break;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //criando o método para limpar os campos quando necessário
            limpar_campos();

            //a data será inserida automaticamente toda vez que limpar os dados
            txtCadastro.Text = Convert.ToString(System.DateTime.Now);

            //clicando no botão novo,o modo incluirá o registro novo.  
            modo = "novo";
        }
        private void limpar_campos()
        {
                txtNome.Text = "";
                txtLogin.Text = "";
                txtEmail.Text = "";
                txtSenha.Text = "";
                txtCadastro.Text = "";
                cboPerfil.Text = "";
                cboSituacao.Text = "";
        }
        
        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            /*iremos criar o vinculo do botão confirmar entre as informações inseridas
             * no botão novo e direcionar ao Loja.BLL, na classe Usuario_BLL, utilizando
             * o tratamento de erro*/
            if (modo == "novo")
            {

                try
                {
                    /*Criando o objeto USU, referenciado no Loja.DAL, na classe Usuario DAL
                     * que está vinculado as informações direcionadas ao Loja.BLL, na classe
                     * Usuario_BLL*/
                    Usuario_DTO USU = new Usuario_DTO();
                    USU.cod_usuario = codUsuSelecionado;
                    USU.nome = txtNome.Text;
                    USU.login = txtLogin.Text;
                    USU.email = txtEmail.Text;
                    USU.senha = txtSenha.Text;
                    USU.cadastro = System.DateTime.Now;
                    if (cboSituacao.Text == "Ativo")
                    {
                        USU.situacao = "A";
                    }
                    else
                    {
                        USU.situacao = "I";
                    }
                    switch (cboPerfil.Text)
                    {
                        case "Administrador":
                            USU.perfil = 1;
                            break;
                        case "Operador":
                            USU.perfil = 2;
                            break;
                        case "Gerencial":
                            USU.perfil = 3;
                            break;
                    }
                    int x = new UsuarioBLL().insereUsuario(USU);
                    if (x > 0)
                    {
                        MessageBox.Show(USU.nome + "foi cadastrado com sucesso!");
                    }

                    //Recarregar o GRID
                    carregaGrid();
                    modo = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado" + ex.Message);
                }
            }


            if (modo == "alterar")
            {

                /*Tratamento de Erros, exibe msg*/
                try
                {
                    Usuario_DTO USU = new Usuario_DTO();
                    USU.nome = txtNome.Text;
                    USU.login = txtLogin.Text;
                    USU.email = txtEmail.Text;
                    USU.senha = txtSenha.Text;
                    USU.cadastro = System.DateTime.Now;
                    USU.cod_usuario = codUsuSelecionado;
                    if (cboSituacao.Text == "Ativo")
                    {
                        USU.situacao = "A";
                    }
                    else
                    {
                        USU.situacao = "I";
                    }
                    switch (cboPerfil.Text)
                    {
                        case "Administrador":
                            USU.perfil = 1;
                            break;
                        case "Operador":
                            USU.perfil = 2;
                            break;
                        case "Gerencial":
                            USU.perfil = 3;
                            break;
                    }
                    int x = new UsuarioBLL().alteraUsuario(USU);
                    if (x > 0)
                    {
                        MessageBox.Show(USU.nome + " foi alterado com sucesso!");
                        modo = "";
                        limpar_campos();
                        //Recarregar o GRID
                        carregaGrid();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado" + ex.Message);
                }
            }

        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
           if (codUsuSelecionado < 0)
           {
           MessageBox.Show("Selecione um usuario antes de prosseguir");
           return;
           }
           
            modo = "alterar";

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
                if (codUsuSelecionado < 0)
                {
                    MessageBox.Show("Selecione um usuario antes");
                    return;
                }
                if (MessageBox.Show("tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Usuario_DTO USU = new Usuario_DTO();
                    USU.cod_usuario = codUsuSelecionado;
                    int x = new UsuarioBLL().deletaUsuario(USU);
                    if (x > 0)
                    {
                        MessageBox.Show("Excluido com Sucesso!");
                    }
                }

                /*Recarrega o Grid após os dados serem gravados*/
                carregaGrid();
                limpar_campos();
                codUsuSelecionado = -1;

        }
        
    }
}
