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
    public partial class FrmConsultas : Form
    {
        private static FrmConsultas instance = null;

        private FrmConsultas()
        {
            InitializeComponent();
        }

        public static FrmConsultas getInstance()
        {
            if (instance == null)
            {
                instance = new FrmConsultas();
            }
            return instance;
        }

        private void optCliente_CheckedChanged(object sender, EventArgs e)
        {
            grpCliente.Visible = true;
            grpPilotos.Visible = false;
            grpVoos.Visible = false;
            grpAeroportos.Visible = false;
            grpAviao.Visible = false;
            btnLimpar_Click(sender, e);
        }

        private void optPiloto_CheckedChanged(object sender, EventArgs e)
        {
            grpCliente.Visible = false;
            grpPilotos.Visible = true;
            grpVoos.Visible = false;
            grpAeroportos.Visible = false;
            grpAviao.Visible = false;
            btnLimpar_Click(sender, e);
        }

        private void optVoo_CheckedChanged(object sender, EventArgs e)
        {
            grpCliente.Visible = false;
            grpPilotos.Visible = false;
            grpVoos.Visible = true;
            grpAeroportos.Visible = false;
            grpAviao.Visible = false;
            btnLimpar_Click(sender, e);

        }

        private void optAeroporto_CheckedChanged(object sender, EventArgs e)
        {
            grpCliente.Visible = false;
            grpPilotos.Visible = false;
            grpVoos.Visible = false;
            grpAeroportos.Visible = true;
            grpAviao.Visible = false;
            btnLimpar_Click(sender, e);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCidade.Text = "";
            txtCidadeAeroporto.Text = "";
            txtCodigoAeroporto.Text = "";
            txtCodigoVoo.Text = "";
            txtCPF.Text = "";
            txtData.Text = "";
            txtDestino.Text = "";
            txtIdade.Text = "";
            txtNomePiloto.Text = "";
            txtNomeAeroporto.Text = "";
            txtNomeCliente.Text = "";
            txtOrigem.Text = "";
            txtCHT.Text = "";
            txtNumeroSerie.Text = "";
            txtModelo.Text = "";
        }

        private void optAviao_CheckedChanged(object sender, EventArgs e)
        {
            grpAviao.Visible = true;
            grpCliente.Visible = false;
            grpPilotos.Visible = false;
            grpVoos.Visible = false;
            grpAeroportos.Visible = false;
        }

        private void FrmConsultas_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (optVoo.Checked == true)
            {
                VoosDAO voo = new VoosDAO();
                DataTable voos = voo.consulta();
                foreach (DataRow dr in voos.Rows)
                {
                    txtData.Text = dr[2].ToString();
                    txtOrigem.Text = dr[3].ToString();
                    txtDestino.Text = dr[4].ToString();
                } 
            }

            if (optAviao.Checked == true)
            {
                AviaoDAO aviao = new AviaoDAO();
                DataTable avioes = aviao.consulta();
                foreach (DataRow dr in avioes.Rows)
                {
                    txtModelo.Text = dr[1].ToString();
                } 
            }

            if (optAeroporto.Checked == true)
            {
                AeroportoDAO aeroporto = new AeroportoDAO();
                DataTable aeroportos = aeroporto.consulta();
                foreach (DataRow dr in aeroportos.Rows)
                {
                    txtNomeAeroporto.Text = dr[1].ToString();
                    txtCidadeAeroporto.Text = dr[2].ToString();
                }
            }

            if (optPiloto.Checked == true)
            {
                PilotoDAO piloto = new PilotoDAO();
                DataTable pilotos = piloto.consulta();
                foreach (DataRow dr in pilotos.Rows)
                {
                    txtNomePiloto.Text = dr[1].ToString();
                    txtIdade.Text = dr[2].ToString();
                } 
            }

            if (optCliente.Checked == true)
            {
                ClienteDAO cliente = new ClienteDAO();
                DataTable clientes = cliente.consulta();
                foreach (DataRow dr in clientes.Rows)
                {
                    txtNomeCliente.Text = dr[1].ToString();
                    txtCidade.Text = dr[2].ToString();
                }
            }
        }

    

      
    }
}
