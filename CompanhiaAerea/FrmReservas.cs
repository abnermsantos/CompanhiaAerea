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
    public partial class FrmReservas : Form
    {
        private static FrmReservas instance = null;
        private ReservasDAO reservasDAO;

        private FrmReservas()
        {
            InitializeComponent();
            reservasDAO = new ReservasDAO();
        }

        public static FrmReservas getInstance()
        {
            if (instance == null)
            {
                instance = new FrmReservas();
            }
            return instance;
        }

        private void optConsultar_CheckedChanged(object sender, EventArgs e)
        {
            if (optConsultar.Checked)
            {
                grpConsultar.Visible = true;
                grpCadastrar.Visible = false;
                btnCadastrar.Visible = false;
                btnConsultar.Visible = true;
                btnLimpar_Click(sender, e);
            }
        }

        private void optCadastrar_CheckedChanged(object sender, EventArgs e)
        {
            if (optCadastrar.Checked)
            {
                grpCadastrar.Visible = true;
                grpConsultar.Visible = false;
                btnConsultar.Visible = false;
                btnCadastrar.Visible = true;
                btnLimpar_Click(sender, e);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAssentoConsulta.Text = "";
            txtCodVooConsulta.Text = "";
            txtCpfConsulta.Text = "";
            txtCpfCadastro.Text = "";
            cmbAssentoCadastro.Text = "";
            cmbVooCadastro.Text = "";
        }

        private void FrmReservas_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void FrmReservas_Load(object sender, EventArgs e)
        {
            VoosDAO voo = new VoosDAO();
            DataTable voos = voo.consulta();
           
            foreach (DataRow dr in voos.Rows)
            {
                DateTime dataAtual = DateTime.Today;
                DateTime data = (DateTime) dr[2];
                if (DateTime.Compare(data, dataAtual) > 0)
                {
                    cmbVooCadastro.Items.Add(dr[0].ToString());
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Reservas reserva = new Reservas();
            reserva.Voo = cmbVooCadastro.Text;
            reserva.Assento = cmbAssentoCadastro.Text;
            reserva.Cpf_cliente = txtCpfCadastro.Text;
            int ret = reservasDAO.inserir(reserva);

            if (ret > 0)
            {
                MessageBox.Show("Registro efetuado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro no cadastro!");
            }
            btnLimpar_Click(sender, e);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ReservasDAO reserva = new ReservasDAO();
            DataTable reservas = reserva.consulta();
            foreach (DataRow dr in reservas.Rows)
            {
                txtCodVooConsulta.Text = dr[0].ToString();
                txtAssentoConsulta.Text = dr[1].ToString();
            }
        }
    }
}
