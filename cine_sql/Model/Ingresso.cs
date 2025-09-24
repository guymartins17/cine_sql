using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_sql.Model
{
    public class Ingresso
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdSessao { get; set; }
        public int QtdIngresso { get; set; }

        public DataTable Listar()
        {
            string comando = "SELECT * FROM view_ingressos";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool Cadastrar()
        {
            string comando = "INSERT INTO ingressos (id_usuario, id_sessao, qtd_ingresso) VALUES " +
                "(@id_usuario, @id_sessao, @qtd_ingresso)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_usuario", IdUsuario);
            cmd.Parameters.AddWithValue("@id_sessao", IdSessao);
            cmd.Parameters.AddWithValue("@qtd_ingresso", QtdIngresso);

            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}
