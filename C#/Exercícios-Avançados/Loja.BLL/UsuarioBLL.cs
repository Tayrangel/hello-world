using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DAL;
using Loja.DTO;

namespace Loja.BLL
{
    public class UsuarioBLL
    {
        /*Método cargaUsuario, retornara uma lista de atributos do objeto
         * do usuario_DTO, neste caso entrará no Banco de Dados e busca
         * todos os usuários. Usaremos try e catch para tratamento de erros e
         * retorna para a camada view. Posteriormente, o método cargaUsuario 
         * será criado no Loja.DAL. */

        public IList<Usuario_DTO> cargaUsuario()
        {
            try
            {
                return new UsuarioDAL().cargaUsuario();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int insereUsuario(Usuario_DTO USU) //criação do vinculo com o botão Confirmar
        {
            try
            {
                return new UsuarioDAL().insereUsuario(USU); //vinculando ao Loja.DAL(UsuarioDAL)
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int alteraUsuario(Usuario_DTO USU)//criando o vinculo do botão alterar
        {
            try
            {
                return new UsuarioDAL().alteraUsuario(USU); //vinculando ao LojaDal
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int deletaUsuario(Usuario_DTO USU)//criando o vinculo do botão deletar
        {
            try
            {
                return new UsuarioDAL().deletaUsuario(USU); //vinculando ao LojaDal
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
