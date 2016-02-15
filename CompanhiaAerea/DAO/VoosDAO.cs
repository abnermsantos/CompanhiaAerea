using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using CompanhiaAerea.Bean;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace CompanhiaAerea.DAO
{
    class VoosDAO
    {
        private OdbcConnection conexao;

        public VoosDAO()
        {
            string connectionString = "driver={PostgreSQL ANSI}; server=localhost; port=5432; database=CompanhiaAerea; uid=postgres; pwd=1;";
            conexao = new OdbcConnection(connectionString);
        }

        public int inserir(Voos voo)
        {
            OdbcCommand comando;
            int result = 0;
            String comand = "INSERT INTO voo(codigo, data, origem, destino) VALUES(?, ?, ?, ?)";
            OdbcParameter codigo = new OdbcParameter("?", voo.Codigo);
            OdbcParameter data = new OdbcParameter("?", voo.Data);
            OdbcParameter origem = new OdbcParameter("?", voo.Origem);
            OdbcParameter destino = new OdbcParameter("?", voo.Destino);
            try
            {
                comando = new OdbcCommand(comand, conexao);
                comando.Connection.Open();
                comando.Parameters.Add(codigo);
                comando.Parameters.Add(data);
                comando.Parameters.Add(origem);
                comando.Parameters.Add(destino);
                result = comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }
            return result;
        }

        public DataTable consulta()
        {
            OdbcCommand comando;
            DataTable list = new DataTable();
            String comand = "SELECT * FROM voo";
            try
            {
                comando = new OdbcCommand(comand, conexao);
                comando.Connection.Open();
                OdbcDataAdapter da = new OdbcDataAdapter(comando);
                list.Clear();
                da.Fill(list);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }
            return list;
        }
    }
}
