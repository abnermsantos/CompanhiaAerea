namespace CompanhiaAerea
{
    partial class FrmConsultas
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
            this.optCliente = new System.Windows.Forms.RadioButton();
            this.optPiloto = new System.Windows.Forms.RadioButton();
            this.optVoo = new System.Windows.Forms.RadioButton();
            this.optAeroporto = new System.Windows.Forms.RadioButton();
            this.grpCategoria = new System.Windows.Forms.GroupBox();
            this.optAviao = new System.Windows.Forms.RadioButton();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpPilotos = new System.Windows.Forms.GroupBox();
            this.txtNomePiloto = new System.Windows.Forms.TextBox();
            this.txtCHT = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpVoos = new System.Windows.Forms.GroupBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtCodigoVoo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpAeroportos = new System.Windows.Forms.GroupBox();
            this.txtCidadeAeroporto = new System.Windows.Forms.TextBox();
            this.txtNomeAeroporto = new System.Windows.Forms.TextBox();
            this.txtCodigoAeroporto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grpAviao = new System.Windows.Forms.GroupBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grpCategoria.SuspendLayout();
            this.grpCliente.SuspendLayout();
            this.grpPilotos.SuspendLayout();
            this.grpVoos.SuspendLayout();
            this.grpAeroportos.SuspendLayout();
            this.grpAviao.SuspendLayout();
            this.SuspendLayout();
            // 
            // optCliente
            // 
            this.optCliente.AutoSize = true;
            this.optCliente.Location = new System.Drawing.Point(6, 19);
            this.optCliente.Name = "optCliente";
            this.optCliente.Size = new System.Drawing.Size(62, 17);
            this.optCliente.TabIndex = 0;
            this.optCliente.TabStop = true;
            this.optCliente.Text = "Clientes";
            this.optCliente.UseVisualStyleBackColor = true;
            this.optCliente.CheckedChanged += new System.EventHandler(this.optCliente_CheckedChanged);
            // 
            // optPiloto
            // 
            this.optPiloto.AutoSize = true;
            this.optPiloto.Location = new System.Drawing.Point(6, 42);
            this.optPiloto.Name = "optPiloto";
            this.optPiloto.Size = new System.Drawing.Size(56, 17);
            this.optPiloto.TabIndex = 1;
            this.optPiloto.TabStop = true;
            this.optPiloto.Text = "Pilotos";
            this.optPiloto.UseVisualStyleBackColor = true;
            this.optPiloto.CheckedChanged += new System.EventHandler(this.optPiloto_CheckedChanged);
            // 
            // optVoo
            // 
            this.optVoo.AutoSize = true;
            this.optVoo.Location = new System.Drawing.Point(6, 65);
            this.optVoo.Name = "optVoo";
            this.optVoo.Size = new System.Drawing.Size(49, 17);
            this.optVoo.TabIndex = 2;
            this.optVoo.TabStop = true;
            this.optVoo.Text = "Voos";
            this.optVoo.UseVisualStyleBackColor = true;
            this.optVoo.CheckedChanged += new System.EventHandler(this.optVoo_CheckedChanged);
            // 
            // optAeroporto
            // 
            this.optAeroporto.AutoSize = true;
            this.optAeroporto.Location = new System.Drawing.Point(6, 88);
            this.optAeroporto.Name = "optAeroporto";
            this.optAeroporto.Size = new System.Drawing.Size(76, 17);
            this.optAeroporto.TabIndex = 3;
            this.optAeroporto.TabStop = true;
            this.optAeroporto.Text = "Aeroportos";
            this.optAeroporto.UseVisualStyleBackColor = true;
            this.optAeroporto.CheckedChanged += new System.EventHandler(this.optAeroporto_CheckedChanged);
            // 
            // grpCategoria
            // 
            this.grpCategoria.Controls.Add(this.optAviao);
            this.grpCategoria.Controls.Add(this.optCliente);
            this.grpCategoria.Controls.Add(this.optAeroporto);
            this.grpCategoria.Controls.Add(this.optPiloto);
            this.grpCategoria.Controls.Add(this.optVoo);
            this.grpCategoria.Location = new System.Drawing.Point(12, 12);
            this.grpCategoria.Name = "grpCategoria";
            this.grpCategoria.Size = new System.Drawing.Size(102, 135);
            this.grpCategoria.TabIndex = 4;
            this.grpCategoria.TabStop = false;
            this.grpCategoria.Text = "Categoria";
            // 
            // optAviao
            // 
            this.optAviao.AutoSize = true;
            this.optAviao.Location = new System.Drawing.Point(6, 113);
            this.optAviao.Name = "optAviao";
            this.optAviao.Size = new System.Drawing.Size(52, 17);
            this.optAviao.TabIndex = 4;
            this.optAviao.TabStop = true;
            this.optAviao.Text = "Aviao";
            this.optAviao.UseVisualStyleBackColor = true;
            this.optAviao.CheckedChanged += new System.EventHandler(this.optAviao_CheckedChanged);
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.txtCidade);
            this.grpCliente.Controls.Add(this.label2);
            this.grpCliente.Controls.Add(this.txtCPF);
            this.grpCliente.Controls.Add(this.label1);
            this.grpCliente.Controls.Add(this.txtNomeCliente);
            this.grpCliente.Controls.Add(this.lblNome);
            this.grpCliente.Location = new System.Drawing.Point(131, 12);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(327, 242);
            this.grpCliente.TabIndex = 5;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Clientes";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(59, 107);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(262, 20);
            this.txtCidade.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cidade";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(59, 18);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(151, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(59, 58);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(262, 20);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 154);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 193);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 231);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grpPilotos
            // 
            this.grpPilotos.Controls.Add(this.txtNomePiloto);
            this.grpPilotos.Controls.Add(this.txtCHT);
            this.grpPilotos.Controls.Add(this.txtIdade);
            this.grpPilotos.Controls.Add(this.label6);
            this.grpPilotos.Controls.Add(this.label5);
            this.grpPilotos.Controls.Add(this.label4);
            this.grpPilotos.Location = new System.Drawing.Point(131, 12);
            this.grpPilotos.Name = "grpPilotos";
            this.grpPilotos.Size = new System.Drawing.Size(327, 242);
            this.grpPilotos.TabIndex = 9;
            this.grpPilotos.TabStop = false;
            this.grpPilotos.Text = "Pilotos";
            // 
            // txtNomePiloto
            // 
            this.txtNomePiloto.Enabled = false;
            this.txtNomePiloto.Location = new System.Drawing.Point(73, 58);
            this.txtNomePiloto.Name = "txtNomePiloto";
            this.txtNomePiloto.Size = new System.Drawing.Size(235, 20);
            this.txtNomePiloto.TabIndex = 5;
            // 
            // txtCHT
            // 
            this.txtCHT.Location = new System.Drawing.Point(73, 16);
            this.txtCHT.Name = "txtCHT";
            this.txtCHT.Size = new System.Drawing.Size(137, 20);
            this.txtCHT.TabIndex = 4;
            // 
            // txtIdade
            // 
            this.txtIdade.Enabled = false;
            this.txtIdade.Location = new System.Drawing.Point(73, 107);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(137, 20);
            this.txtIdade.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "CHT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome";
            // 
            // grpVoos
            // 
            this.grpVoos.Controls.Add(this.txtDestino);
            this.grpVoos.Controls.Add(this.txtOrigem);
            this.grpVoos.Controls.Add(this.txtData);
            this.grpVoos.Controls.Add(this.txtCodigoVoo);
            this.grpVoos.Controls.Add(this.label10);
            this.grpVoos.Controls.Add(this.label9);
            this.grpVoos.Controls.Add(this.label8);
            this.grpVoos.Controls.Add(this.label7);
            this.grpVoos.Location = new System.Drawing.Point(131, 12);
            this.grpVoos.Name = "grpVoos";
            this.grpVoos.Size = new System.Drawing.Size(327, 242);
            this.grpVoos.TabIndex = 10;
            this.grpVoos.TabStop = false;
            this.grpVoos.Text = "Voos";
            // 
            // txtDestino
            // 
            this.txtDestino.Enabled = false;
            this.txtDestino.Location = new System.Drawing.Point(77, 160);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(244, 20);
            this.txtDestino.TabIndex = 7;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Enabled = false;
            this.txtOrigem.Location = new System.Drawing.Point(77, 107);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(244, 20);
            this.txtOrigem.TabIndex = 6;
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(77, 58);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 5;
            // 
            // txtCodigoVoo
            // 
            this.txtCodigoVoo.Location = new System.Drawing.Point(77, 16);
            this.txtCodigoVoo.Name = "txtCodigoVoo";
            this.txtCodigoVoo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoVoo.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Destino";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Origem";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Codigo";
            // 
            // grpAeroportos
            // 
            this.grpAeroportos.Controls.Add(this.txtCidadeAeroporto);
            this.grpAeroportos.Controls.Add(this.txtNomeAeroporto);
            this.grpAeroportos.Controls.Add(this.txtCodigoAeroporto);
            this.grpAeroportos.Controls.Add(this.label13);
            this.grpAeroportos.Controls.Add(this.label12);
            this.grpAeroportos.Controls.Add(this.label11);
            this.grpAeroportos.Location = new System.Drawing.Point(131, 12);
            this.grpAeroportos.Name = "grpAeroportos";
            this.grpAeroportos.Size = new System.Drawing.Size(327, 242);
            this.grpAeroportos.TabIndex = 11;
            this.grpAeroportos.TabStop = false;
            this.grpAeroportos.Text = "Aeroportos";
            // 
            // txtCidadeAeroporto
            // 
            this.txtCidadeAeroporto.Enabled = false;
            this.txtCidadeAeroporto.Location = new System.Drawing.Point(62, 107);
            this.txtCidadeAeroporto.Name = "txtCidadeAeroporto";
            this.txtCidadeAeroporto.Size = new System.Drawing.Size(244, 20);
            this.txtCidadeAeroporto.TabIndex = 5;
            // 
            // txtNomeAeroporto
            // 
            this.txtNomeAeroporto.Enabled = false;
            this.txtNomeAeroporto.Location = new System.Drawing.Point(62, 58);
            this.txtNomeAeroporto.Name = "txtNomeAeroporto";
            this.txtNomeAeroporto.Size = new System.Drawing.Size(244, 20);
            this.txtNomeAeroporto.TabIndex = 4;
            // 
            // txtCodigoAeroporto
            // 
            this.txtCodigoAeroporto.Location = new System.Drawing.Point(62, 16);
            this.txtCodigoAeroporto.Name = "txtCodigoAeroporto";
            this.txtCodigoAeroporto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoAeroporto.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Cidade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nome";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Codigo";
            // 
            // grpAviao
            // 
            this.grpAviao.Controls.Add(this.txtModelo);
            this.grpAviao.Controls.Add(this.txtNumeroSerie);
            this.grpAviao.Controls.Add(this.label15);
            this.grpAviao.Controls.Add(this.label14);
            this.grpAviao.Location = new System.Drawing.Point(131, 12);
            this.grpAviao.Name = "grpAviao";
            this.grpAviao.Size = new System.Drawing.Size(327, 242);
            this.grpAviao.TabIndex = 6;
            this.grpAviao.TabStop = false;
            this.grpAviao.Text = "Aviao";
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(76, 68);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(156, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.Location = new System.Drawing.Point(76, 21);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroSerie.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Modelo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nº Serie";
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 264);
            this.Controls.Add(this.grpAviao);
            this.Controls.Add(this.grpAeroportos);
            this.Controls.Add(this.grpVoos);
            this.Controls.Add(this.grpPilotos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.grpCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultas";
            this.Text = "Consultas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConsultas_FormClosed);
            this.grpCategoria.ResumeLayout(false);
            this.grpCategoria.PerformLayout();
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpPilotos.ResumeLayout(false);
            this.grpPilotos.PerformLayout();
            this.grpVoos.ResumeLayout(false);
            this.grpVoos.PerformLayout();
            this.grpAeroportos.ResumeLayout(false);
            this.grpAeroportos.PerformLayout();
            this.grpAviao.ResumeLayout(false);
            this.grpAviao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton optCliente;
        private System.Windows.Forms.RadioButton optPiloto;
        private System.Windows.Forms.RadioButton optVoo;
        private System.Windows.Forms.RadioButton optAeroporto;
        private System.Windows.Forms.GroupBox grpCategoria;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPilotos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomePiloto;
        private System.Windows.Forms.TextBox txtCHT;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpVoos;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtCodigoVoo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpAeroportos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNomeAeroporto;
        private System.Windows.Forms.TextBox txtCodigoAeroporto;
        private System.Windows.Forms.TextBox txtCidadeAeroporto;
        private System.Windows.Forms.RadioButton optAviao;
        private System.Windows.Forms.GroupBox grpAviao;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}