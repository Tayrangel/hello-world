using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DTO;

namespace Loja.DAL
{
    public class UsuarioDAL
    {
        // crianção do método cargaUsuario

        public IList<Usuario_DTO> cargaUsuario()
        {
            try
            {
                /*conexão com o banco de dados, selecionando todos os dados da tabela
                 * tb_usuarios*/
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT*FROM tb_usuarios";
                CM.Connection = CON;

                SqlDataReader ER;
                IList<Usuario_DTO> listusuarioDTO = new List<Usuario_DTO>();

                CON.Open();
                ER = CM.ExecuteReader();
                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        Usuario_DTO usu = new Usuario_DTO();

                        /*nome dos atributos criados no DTO será enviado para a lista
                         * possibilitando uma lista com vários usuários*/
                        usu.cod_usuario = Convert.ToInt32(ER["cod_usuario"]);
                        usu.nome = Convert.ToString(ER["nome"]);
                        usu.login = Convert.ToString(ER["login"]);
                        usu.email = Convert.ToString(ER["email"]);
                        usu.senha = Convert.ToString(ER["senha"]);
                        usu.cadastro = Convert.ToDateTime(ER["cadastro"]);
                        usu.situacao = Convert.ToString(ER["situacao"]);
                        usu.perfil = Convert.ToInt32(ER["perfil"]);

                        listusuarioDTO.Add(usu);

                    }
                }
                return listusuarioDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int insereUsuario(Usuario_DTO USU)
        {
            try
            {
                /*conexão do banco de dados, inserindo na tb_usuario os valores
                cadastrados e confirmados nos botões. */
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO tb_usuarios (nome, login, email, senha, cadastro, situacao, perfil)"+
                    "VALUES (@nome, @login, @email, @senha, @cadastro, @situacao, @perfil)";
                // os parametros irão substituir os campos
                CM.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = USU.nome;
                CM.Parameters.Add("login", System.Data.SqlDbType.VarChar).Value = USU.login;
                CM.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = USU.email;
                CM.Parameters.Add("senha", System.Data.SqlDbType.VarChar).Value = USU.senha;
                CM.Parameters.Add("cadastro", System.Data.SqlDbType.DateTime).Value = USU.cadastro;
                CM.Parameters.Add("situacao", System.Data.SqlDbType.NVarChar).Value = USU.situacao;
                CM.Parameters.Add("perfil", System.Data.SqlDbType.Int).Value = USU.perfil;

                CM.Connection = CON;

                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int alteraUsuario(Usuario_DTO USU)
        {
            try
            {
                /*conexão do banco de dados, alterando na tb_usuario os valores
                quando clicar no botão alterar. */
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "UPDATE tb_usuarios SET " +
                    "nome=@nome, login=@login, email=@email, senha=@senha, " +
                    "cadastro=@cadastro, situacao=@situacao, perfil=@perfil " +
                    "WHERE cod_usuario =@cod_usuario";
                // os parametros irão substituir os campos
                CM.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = USU.nome;
                CM.Parameters.Add("login", System.Data.SqlDbType.VarChar).Value = USU.login;
                CM.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = USU.email;
                CM.Parameters.Add("senha", System.Data.SqlDbType.VarChar).Value = USU.senha;
                CM.Parameters.Add("cadastro", System.Data.SqlDbType.DateTime).Value = USU.cadastro;
                CM.Parameters.Add("situacao", System.Data.SqlDbType.NVarChar).Value = USU.situacao;
                CM.Parameters.Add("perfil", System.Data.SqlDbType.Int).Value = USU.perfil;
                CM.Parameters.Add("cod_usuario",System.Data.SqlDbType.Int).Value = USU.cod_usuario;

                CM.Connection = CON;

                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int deletaUsuario(Usuario_DTO USU)
        {
            try
            {
                /*conexão do banco de dados, excluindo na tb_usuario os valores
                quando clicar no botão alterar. */
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "DELETE tb_usuarios WHERE cod_usuario=@cod_usuario";

                // os parametros irão substituir os campos
                CM.Parameters.Add("cod_usuario", System.Data.SqlDbType.VarChar).Value = USU.cod_usuario;

                CM.Connection = CON;

                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
