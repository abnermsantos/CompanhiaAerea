namespace CompanhiaAerea
{
    partial class FrmReservas
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
            this.components = new System.ComponentModel.Container();
            this.grpOperações = new System.Windows.Forms.GroupBox();
            this.optCadastrar = new System.Windows.Forms.RadioButton();
            this.optConsultar = new System.Windows.Forms.RadioButton();
            this.grpConsultar = new System.Windows.Forms.GroupBox();
            this.txtAssentoConsulta = new System.Windows.Forms.TextBox();
            this.txtCodVooConsulta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpfConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCadastrar = new System.Windows.Forms.GroupBox();
            this.cmbAssentoCadastro = new System.Windows.Forms.ComboBox();
            this.cmbVooCadastro = new System.Windows.Forms.ComboBox();
            this.txtCpfCadastro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.voosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voosDataSet = new CompanhiaAerea.VoosDataSet();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.voosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grpOperações.SuspendLayout();
            this.grpConsultar.SuspendLayout();
            this.grpCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOperações
            // 
            this.grpOperações.Controls.Add(this.optCadastrar);
            this.grpOperações.Controls.Add(this.optConsultar);
            this.grpOperações.Location = new System.Drawing.Point(12, 12);
            this.grpOperações.Name = "grpOperações";
            this.grpOperações.Size = new System.Drawing.Size(99, 113);
            this.grpOperações.TabIndex = 0;
            this.grpOperações.TabStop = false;
            this.grpOperações.Text = "Operações";
            // 
            // optCadastrar
            // 
            this.optCadastrar.AutoSize = true;
            this.optCadastrar.Location = new System.Drawing.Point(12, 61);
            this.optCadastrar.Name = "optCadastrar";
            this.optCadastrar.Size = new System.Drawing.Size(70, 17);
            this.optCadastrar.TabIndex = 1;
            this.optCadastrar.TabStop = true;
            this.optCadastrar.Text = "Cadastrar";
            this.optCadastrar.UseVisualStyleBackColor = true;
            this.optCadastrar.CheckedChanged += new System.EventHandler(this.optCadastrar_CheckedChanged);
            // 
            // optConsultar
            // 
            this.optConsultar.AutoSize = true;
            this.optConsultar.Location = new System.Drawing.Point(12, 27);
            this.optConsultar.Name = "optConsultar";
            this.optConsultar.Size = new System.Drawing.Size(72, 17);
            this.optConsultar.TabIndex = 0;
            this.optConsultar.TabStop = true;
            this.optConsultar.Text = "Consultar ";
            this.optConsultar.UseVisualStyleBackColor = true;
            this.optConsultar.CheckedChanged += new System.EventHandler(this.optConsultar_CheckedChanged);
            // 
            // grpConsultar
            // 
            this.grpConsultar.Controls.Add(this.txtAssentoConsulta);
            this.grpConsultar.Controls.Add(this.txtCodVooConsulta);
            this.grpConsultar.Controls.Add(this.label5);
            this.grpConsultar.Controls.Add(this.label2);
            this.grpConsultar.Controls.Add(this.txtCpfConsulta);
            this.grpConsultar.Controls.Add(this.label1);
            this.grpConsultar.Location = new System.Drawing.Point(126, 12);
            this.grpConsultar.Name = "grpConsultar";
            this.grpConsultar.Size = new System.Drawing.Size(300, 202);
            this.grpConsultar.TabIndex = 1;
            this.grpConsultar.TabStop = false;
            this.grpConsultar.Text = "Consultar Reserva";
            // 
            // txtAssentoConsulta
            // 
            this.txtAssentoConsulta.Enabled = false;
            this.txtAssentoConsulta.Location = new System.Drawing.Point(65, 93);
            this.txtAssentoConsulta.Name = "txtAssentoConsulta";
            this.txtAssentoConsulta.Size = new System.Drawing.Size(126, 20);
            this.txtAssentoConsulta.TabIndex = 9;
            // 
            // txtCodVooConsulta
            // 
            this.txtCodVooConsulta.Enabled = false;
            this.txtCodVooConsulta.Location = new System.Drawing.Point(65, 60);
            this.txtCodVooConsulta.Name = "txtCodVooConsulta";
            this.txtCodVooConsulta.Size = new System.Drawing.Size(126, 20);
            this.txtCodVooConsulta.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Assento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cod. Vôo";
            // 
            // txtCpfConsulta
            // 
            this.txtCpfConsulta.Location = new System.Drawing.Point(65, 26);
            this.txtCpfConsulta.Name = "txtCpfConsulta";
            this.txtCpfConsulta.Size = new System.Drawing.Size(126, 20);
            this.txtCpfConsulta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // grpCadastrar
            // 
            this.grpCadastrar.Controls.Add(this.cmbAssentoCadastro);
            this.grpCadastrar.Controls.Add(this.cmbVooCadastro);
            this.grpCadastrar.Controls.Add(this.txtCpfCadastro);
            this.grpCadastrar.Controls.Add(this.label9);
            this.grpCadastrar.Controls.Add(this.label8);
            this.grpCadastrar.Controls.Add(this.label6);
            this.grpCadastrar.Location = new System.Drawing.Point(126, 12);
            this.grpCadastrar.Name = "grpCadastrar";
            this.grpCadastrar.Size = new System.Drawing.Size(300, 202);
            this.grpCadastrar.TabIndex = 10;
            this.grpCadastrar.TabStop = false;
            this.grpCadastrar.Text = "Cadastrar Reserva";
            // 
            // cmbAssentoCadastro
            // 
            this.cmbAssentoCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssentoCadastro.FormattingEnabled = true;
            this.cmbAssentoCadastro.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cmbAssentoCadastro.Location = new System.Drawing.Point(63, 61);
            this.cmbAssentoCadastro.Name = "cmbAssentoCadastro";
            this.cmbAssentoCadastro.Size = new System.Drawing.Size(128, 21);
            this.cmbAssentoCadastro.TabIndex = 7;
            // 
            // cmbVooCadastro
            // 
            this.cmbVooCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVooCadastro.FormattingEnabled = true;
            this.cmbVooCadastro.Location = new System.Drawing.Point(63, 21);
            this.cmbVooCadastro.Name = "cmbVooCadastro";
            this.cmbVooCadastro.Size = new System.Drawing.Size(193, 21);
            this.cmbVooCadastro.TabIndex = 6;
            // 
            // txtCpfCadastro
            // 
            this.txtCpfCadastro.Location = new System.Drawing.Point(63, 98);
            this.txtCpfCadastro.Name = "txtCpfCadastro";
            this.txtCpfCadastro.Size = new System.Drawing.Size(128, 20);
            this.txtCpfCadastro.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Assento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Vôo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "CPF";
            // 
            // voosBindingSource
            // 
            this.voosBindingSource.DataMember = "Voos";
            this.voosBindingSource.DataSource = this.voosDataSetBindingSource;
            // 
            // voosDataSetBindingSource
            // 
            this.voosDataSetBindingSource.DataSource = this.voosDataSet;
            this.voosDataSetBindingSource.Position = 0;
            // 
            // voosDataSet
            // 
            this.voosDataSet.DataSetName = "VoosDataSet";
            this.voosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(21, 133);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(21, 162);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(21, 191);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(21, 133);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // voosBindingSource1
            // 
            this.voosBindingSource1.DataMember = "Voos";
            this.voosBindingSource1.DataSource = this.voosDataSetBindingSource;
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 227);
            this.Controls.Add(this.grpCadastrar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.grpConsultar);
            this.Controls.Add(this.grpOperações);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReservas";
            this.Text = "Reservas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmReservas_FormClosed);
            this.Load += new System.EventHandler(this.FrmReservas_Load);
            this.grpOperações.ResumeLayout(false);
            this.grpOperações.PerformLayout();
            this.grpConsultar.ResumeLayout(false);
            this.grpConsultar.PerformLayout();
            this.grpCadastrar.ResumeLayout(false);
            this.grpCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOperações;
        private System.Windows.Forms.RadioButton optCadastrar;
        private System.Windows.Forms.RadioButton optConsultar;
        private System.Windows.Forms.GroupBox grpConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAssentoConsulta;
        private System.Windows.Forms.TextBox txtCodVooConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpfConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grpCadastrar;
        private System.Windows.Forms.ComboBox cmbVooCadastro;
        private System.Windows.Forms.TextBox txtCpfCadastro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAssentoCadastro;
        private System.Windows.Forms.BindingSource voosDataSetBindingSource;
        private VoosDataSet voosDataSet;
        private System.Windows.Forms.BindingSource voosBindingSource;
        private System.Windows.Forms.BindingSource voosBindingSource1;
    }
}