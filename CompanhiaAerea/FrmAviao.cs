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
    public partial class FrmAviao : Form
    {
        private static FrmAviao instance = null;
        private AviaoDAO aviaoDAO;

        private FrmAviao()
        {
            InitializeComponent();
            aviaoDAO = new AviaoDAO();
        }

        public static FrmAviao getInstance()
        {
            if (instance == null)
            {
                instance = new FrmAviao();
            }
            return instance;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtModelo.Text = "";
            txtNumeroSerie.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAviao_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Aviao aviao = new Aviao();
            aviao.NumeroSerie = txtNumeroSerie.Text;
            aviao.Modelo = txtModelo.Text;
            int ret = aviaoDAO.inserir(aviao);

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
