using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexao.Domimio.Entidades
{
    public class Conexao : Entity
    {
        public string stringConexao {  get; private set; }
        public string senha { get; private set; }
        public string banco { get; private set; }
        public DateTime dataCadastro { get; set; }

        public Conexao(string _stringConexao, string _senha, string _banco)
        {
            stringConexao = _stringConexao;
            senha = _senha;
            banco = _banco;
            dataCadastro = DateTime.Now;    
        }
    }
}
