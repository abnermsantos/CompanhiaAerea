using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CompanhiaAerea
{
    public partial class FrmPrincipal : Form
    {
        DialogResult result;

        public FrmPrincipal()
        {
            InitializeComponent();
            Thread objThread = new Thread(new ThreadStart(doSplash));
            objThread.Start();
            Thread.Sleep(1000);
            objThread.Abort();
        }

        private void doSplash()
        {
            FrmSplash sp = new FrmSplash();
            sp.ShowDialog();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultas consulta = FrmConsultas.getInstance();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            result = MessageBox.Show("Voce tem certeza que deseja sair?", "Sair do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReservas reservas = FrmReservas.getInstance();
            reservas.MdiParent = this;
            reservas.Show();
        }

        private void aeroportosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAeroportos aeroportos = FrmAeroportos.getInstance();
            aeroportos.MdiParent = this;
            aeroportos.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = FrmClientes.getInstance();
            clientes.MdiParent = this;
            clientes.Show();
            
        }

        private void pilotosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPilotos pilotos = FrmPilotos.getInstance();
            pilotos.MdiParent = this;
            pilotos.Show();
        }

        private void voosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVoos voos = FrmVoos.getInstance();
            voos.MdiParent = this;
            voos.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAviao aviao = FrmAviao.getInstance();
            aviao.MdiParent = this;
            aviao.Show();
        }

        private void programaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProgramacao programacao = FrmProgramacao.getInstance();
            programacao.MdiParent = this;
            programacao.Show();
        }

       
    }
}
