using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompanhiaAerea.DAO;
using CompanhiaAerea.Bean;

namespace CompanhiaAerea
{
    public partial class FrmClientes : Form
    {
        private static FrmClientes instance = null;
        private ClienteDAO clienteDAO;

        private FrmClientes()
        {
            InitializeComponent();
            clienteDAO = new ClienteDAO();
        }

        public static FrmClientes getInstance()
        {
            if (instance == null)
            {
                instance = new FrmClientes();
            }
            return instance;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCidade.Text = "";
            txtCPF.Text = "";
            txtNome.Text = "";
        }

        private void FrmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCPF.Text;
            cliente.Cidade = txtCidade.Text;
            int ret = clienteDAO.inserir(cliente);
             
            if (ret > 0)
            {
                MessageBox.Show("Registro efetuado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro no cadastro!");
            }
        }
    }
}
