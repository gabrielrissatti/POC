using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace Poc2
{
    public class CargasDAO
    {
        private IConfiguration _configuracoes;
        public CargasDAO(IConfiguration config)
        {
            _configuracoes = config;
        }

        public Cargas Obter(string idcarga)
        {
            using (SqlConnection conexao = new SqlConnection(
                _configuracoes.GetConnectionString("ExemploJWT")))
            {
                return conexao.QueryFirstOrDefault<Cargas>(
                    "select idcarga, idparceiro, idmotorista, data, status, localizacao from carga_status where idcarga= @codigo order by idseq desc ",
                    new { codigo = idcarga });
            }
        }
    }
}
