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
    class PilotoDAO
    {
        private OdbcConnection conexao;

        public PilotoDAO()
        {
            string connectionString = "driver={PostgreSQL ANSI}; server=localhost; port=5432; database=CompanhiaAerea; uid=postgres; pwd=1;";
            conexao = new OdbcConnection(connectionString);
        }

        public int inserir(Piloto piloto)
        {
            OdbcCommand comando;
            int result = 0;
            String comand = "INSERT INTO piloto(nome, cht, dataNasc) VALUES(?, ?, ?)";
            OdbcParameter nome = new OdbcParameter("?", piloto.Nome);
            OdbcParameter cht = new OdbcParameter("?", piloto.Cht);
            OdbcParameter dataNasc = new OdbcParameter("?", piloto.DataNasc);
            try
            {
                comando = new OdbcCommand(comand, conexao);
                comando.Connection.Open();
                comando.Parameters.Add(nome);
                comando.Parameters.Add(cht);
                comando.Parameters.Add(dataNasc);
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
            String comand = "SELECT * FROM piloto";
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
