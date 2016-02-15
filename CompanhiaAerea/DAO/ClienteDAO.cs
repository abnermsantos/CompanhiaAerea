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
    class ClienteDAO
    {
        private OdbcConnection conexao;

        public ClienteDAO()
        {
            string connectionString = "driver={PostgreSQL ANSI}; server=localhost; port=5432; database=CompanhiaAerea; uid=postgres; pwd=1;";
            conexao = new OdbcConnection(connectionString);
        }

        public int inserir(Cliente cliente)
        {
            OdbcCommand comando;
            int result = 0;
            String comand = "INSERT INTO cliente(nome, cpf, cidade) VALUES(?, ?, ?)";
            OdbcParameter nome = new OdbcParameter("?", cliente.Nome);
            OdbcParameter cpf = new OdbcParameter("?", cliente.Cpf);
            OdbcParameter cidade = new OdbcParameter("?", cliente.Cidade);
            try
            {
                comando = new OdbcCommand(comand, conexao);
                comando.Connection.Open();
                comando.Parameters.Add(nome);
                comando.Parameters.Add(cpf);
                comando.Parameters.Add(cidade);
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
            String comand = "SELECT * FROM cliente";
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
