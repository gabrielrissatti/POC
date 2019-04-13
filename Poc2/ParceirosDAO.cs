using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace Poc2
{
    public class ParceirosDAO
    {
        private IConfiguration _configuracoes;
        public ParceirosDAO(IConfiguration config)
        {
            _configuracoes = config;
        }

        public Parceiros Obter(string idcodigo)
        {
            using (SqlConnection conexao = new SqlConnection(
                _configuracoes.GetConnectionString("ExemploJWT")))
            {
                return conexao.QueryFirstOrDefault<Parceiros>(
                    "SELECT " +
                        "codigo, " +
                        "descricao " +
                    "FROM parceiro " +
                    "WHERE codigo = @codigo ",
                    new { codigo = idcodigo });
            }
        }
    }
}
