using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DTO
{
    public class Usuario_DTO

        /*Nesta classe teremos os atributos dos objetos. A classe estará
         * no modo publico para ficar acessível externamente e utilizaremos
         * as propriedades Get e Set para acesso do conteúdo.*/

    {
        public int cod_usuario { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public DateTime cadastro { get; set; }
        public string situacao { get; set; }
        public int perfil { get; set; }
    }
}
