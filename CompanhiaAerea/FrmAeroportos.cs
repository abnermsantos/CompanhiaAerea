using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompanhiaAerea.Bean;
using CompanhiaAerea.DAO;

namespace CompanhiaAerea
{
    public partial class FrmAeroportos : Form
    {
        private static FrmAeroportos instance = null;
        private AeroportoDAO aeroportoDAO;

        private FrmAeroportos()
        {
            InitializeComponent();
            aeroportoDAO = new AeroportoDAO();
        }

        public static FrmAeroportos getInstance()
        {
            if (instance == null)
            {
                instance = new FrmAeroportos();
            }
            return instance;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCidade.Text = "";
            txtCodigo.Text = "";
            txtNome.Text = "";
        }

        private void FrmAeroportos_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Aeroportos aeroporto = new Aeroportos();
            aeroporto.Nome = txtNome.Text;
            aeroporto.Cidade = txtCidade.Text;
            aeroporto.Codigo = txtCodigo.Text;
            int ret = aeroportoDAO.inserir(aeroporto);

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
