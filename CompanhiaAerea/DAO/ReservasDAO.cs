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
    class ReservasDAO
    {
        private OdbcConnection conexao;

        public ReservasDAO()
        {
            string connectionString = "driver={PostgreSQL ANSI}; server=localhost; port=5432; database=CompanhiaAerea; uid=postgres; pwd=1;";
            conexao = new OdbcConnection(connectionString);
        }

        public int inserir(Reservas reserva)
        {
            OdbcCommand comando;
            int result = 0;
            String comand = "INSERT INTO reserva(voo, assento, cpf_cliente) VALUES(?, ?, ?)";
            OdbcParameter voo = new OdbcParameter("?", reserva.Voo);
            OdbcParameter assento = new OdbcParameter("?", reserva.Assento);
            OdbcParameter cpf = new OdbcParameter("?", reserva.Cpf_cliente);
            try
            {
                comando = new OdbcCommand(comand, conexao);
                comando.Connection.Open();
                comando.Parameters.Add(voo);
                comando.Parameters.Add(assento);
                comando.Parameters.Add(cpf);
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
            String comand = "SELECT * FROM reserva";
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
