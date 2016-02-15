namespace CompanhiaAerea
{
    partial class FrmProgramacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvProgramacao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ProgramacaoReport1 = new CompanhiaAerea.ProgramacaoReport();
            this.SuspendLayout();
            // 
            // crvProgramacao
            // 
            this.crvProgramacao.ActiveViewIndex = 0;
            this.crvProgramacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProgramacao.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProgramacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProgramacao.Location = new System.Drawing.Point(0, 0);
            this.crvProgramacao.Name = "crvProgramacao";
            this.crvProgramacao.ReportSource = this.ProgramacaoReport1;
            this.crvProgramacao.Size = new System.Drawing.Size(377, 307);
            this.crvProgramacao.TabIndex = 0;
            // 
            // FrmProgramacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 307);
            this.Controls.Add(this.crvProgramacao);
            this.Name = "FrmProgramacao";
            this.Text = "Relatorio de Programação";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProgramacao_FormClosed);
            this.Load += new System.EventHandler(this.FrmProgramacao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProgramacao;
        private ProgramacaoReport ProgramacaoReport1;
    }
}