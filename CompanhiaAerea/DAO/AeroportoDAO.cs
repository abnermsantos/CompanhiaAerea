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
    class AeroportoDAO
    {
        private OdbcConnection conexao;

        public AeroportoDAO()
        {
            string connectionString = "driver={PostgreSQL ANSI}; server=localhost; port=5432; database=CompanhiaAerea; uid=postgres; pwd=1;";
            conexao = new OdbcConnection(connectionString);
        }

        public int inserir(Aeroportos aeroporto)
        {
            OdbcCommand comando;
            int result = 0;
            String comand = "INSERT INTO aeroporto(nome, cidade, codigo) VALUES(?, ?, ?)";
            OdbcParameter nome = new OdbcParameter("?", aeroporto.Nome);
            OdbcParameter cidade = new OdbcParameter("?", aeroporto.Cidade);
            OdbcParameter codigo = new OdbcParameter("?", aeroporto.Codigo);
            try
            {
                comando = new OdbcCommand(comand, conexao);
                comando.Connection.Open();
                comando.Parameters.Add(nome);
                comando.Parameters.Add(cidade);
                comando.Parameters.Add(codigo);
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
            String comand = "SELECT * FROM aeroporto";
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
