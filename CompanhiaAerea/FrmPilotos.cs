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
    public partial class FrmPilotos : Form
    {
        private static FrmPilotos instance = null;
        private PilotoDAO pilotoDAO;

        private FrmPilotos()
        {
            InitializeComponent();
            pilotoDAO = new PilotoDAO();
        }

        public static FrmPilotos getInstance()
        {
            if (instance == null)
            {
                instance = new FrmPilotos();
            }
            return instance;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCHT.Text = "";
            txtNascimento.Text = "";
            txtNome.Text = "";
        }

        private void FrmPilotos_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Piloto piloto = new Piloto();
            piloto.Nome = txtNome.Text;
            piloto.Cht = txtCHT.Text;
            piloto.DataNasc = txtNascimento.Text;
            int ret = pilotoDAO.inserir(piloto);

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
