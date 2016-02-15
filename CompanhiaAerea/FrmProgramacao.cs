using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompanhiaAerea.DAO;

namespace CompanhiaAerea
{
    public partial class FrmProgramacao : Form
    {
        private static FrmProgramacao instance = null;

        private FrmProgramacao()
        {
            InitializeComponent();
        }

        public static FrmProgramacao getInstance()
        {
            if (instance == null)
            {
                instance = new FrmProgramacao();
            }
            return instance;
        }

        private void FrmProgramacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void FrmProgramacao_Load(object sender, EventArgs e)
        {
            ProgramacaoReport relProgramacao = new ProgramacaoReport();
            VoosDAO programacao = new VoosDAO();
            relProgramacao.SetDataSource(programacao.consulta());
            crvProgramacao.ReportSource = relProgramacao;
            this.crvProgramacao.RefreshReport();
        }

        
    }
}
