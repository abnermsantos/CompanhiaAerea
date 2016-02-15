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
    public partial class FrmVoos : Form
    {
        private static FrmVoos instance = null;
        private VoosDAO voosDAO;

        private FrmVoos()
        {
            InitializeComponent();
            voosDAO = new VoosDAO();
        }

        public static FrmVoos getInstance()
        {
            if (instance == null)
            {
                instance = new FrmVoos();
            }
            return instance;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtData.Text = "";
            txtDestino.Text = "";
            txtOrigem.Text = "";
        }

        private void FrmVoos_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Voos voos = new Voos();
            voos.Codigo = txtCodigo.Text;
            voos.Data = txtData.Text;
            voos.Origem = txtOrigem.Text;
            voos.Destino = txtDestino.Text;
            int ret = voosDAO.inserir(voos);

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
