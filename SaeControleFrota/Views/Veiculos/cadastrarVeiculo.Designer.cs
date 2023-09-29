namespace SaeControleFrota
{
    partial class cadastrarVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrarVeiculo));
            this.txtAnoVeiculo = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomeTerceiro = new System.Windows.Forms.TextBox();
            this.lableTerceiro = new System.Windows.Forms.Label();
            this.terceiroCheckBox = new System.Windows.Forms.CheckBox();
            this.proprietarioSaeCheckBox = new System.Windows.Forms.CheckBox();
            this.btnCadastraVeiculo = new System.Windows.Forms.Button();
            this.txtValorLocacao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNcontrato = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inicioVigenciaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fimVigenciaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnoVeiculo
            // 
            this.txtAnoVeiculo.Location = new System.Drawing.Point(434, 105);
            this.txtAnoVeiculo.MaxLength = 4;
            this.txtAnoVeiculo.Name = "txtAnoVeiculo";
            this.txtAnoVeiculo.Size = new System.Drawing.Size(104, 20);
            this.txtAnoVeiculo.TabIndex = 90;
            this.txtAnoVeiculo.TextChanged += new System.EventHandler(this.txtAnoVeiculo_TextChanged);
            this.txtAnoVeiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoVeiculo_KeyPress);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label.Location = new System.Drawing.Point(431, 88);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(95, 17);
            this.label.TabIndex = 89;
            this.label.Text = "Ano do veiculo";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(16, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 88;
            this.label9.Text = "Observação";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(19, 234);
            this.txtObservacao.MaxLength = 2000;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(503, 146);
            this.txtObservacao.TabIndex = 87;
            this.txtObservacao.Text = "";
            this.txtObservacao.TextChanged += new System.EventHandler(this.txtObservacao_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomeTerceiro);
            this.groupBox1.Controls.Add(this.lableTerceiro);
            this.groupBox1.Controls.Add(this.terceiroCheckBox);
            this.groupBox1.Controls.Add(this.proprietarioSaeCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(544, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 128);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proprietário";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNomeTerceiro
            // 
            this.txtNomeTerceiro.Location = new System.Drawing.Point(20, 94);
            this.txtNomeTerceiro.MaxLength = 40;
            this.txtNomeTerceiro.Name = "txtNomeTerceiro";
            this.txtNomeTerceiro.Size = new System.Drawing.Size(249, 23);
            this.txtNomeTerceiro.TabIndex = 34;
            this.txtNomeTerceiro.Visible = false;
            // 
            // lableTerceiro
            // 
            this.lableTerceiro.AutoSize = true;
            this.lableTerceiro.Location = new System.Drawing.Point(19, 77);
            this.lableTerceiro.Name = "lableTerceiro";
            this.lableTerceiro.Size = new System.Drawing.Size(93, 17);
            this.lableTerceiro.TabIndex = 33;
            this.lableTerceiro.Text = "Nome terceiro";
            this.lableTerceiro.Visible = false;
            // 
            // terceiroCheckBox
            // 
            this.terceiroCheckBox.AutoSize = true;
            this.terceiroCheckBox.Location = new System.Drawing.Point(20, 53);
            this.terceiroCheckBox.Name = "terceiroCheckBox";
            this.terceiroCheckBox.Size = new System.Drawing.Size(75, 21);
            this.terceiroCheckBox.TabIndex = 1;
            this.terceiroCheckBox.Text = "Terceiro";
            this.terceiroCheckBox.UseVisualStyleBackColor = true;
            this.terceiroCheckBox.CheckedChanged += new System.EventHandler(this.terceiroCheckBox_CheckedChanged);
            // 
            // proprietarioSaeCheckBox
            // 
            this.proprietarioSaeCheckBox.AutoSize = true;
            this.proprietarioSaeCheckBox.Location = new System.Drawing.Point(20, 26);
            this.proprietarioSaeCheckBox.Name = "proprietarioSaeCheckBox";
            this.proprietarioSaeCheckBox.Size = new System.Drawing.Size(92, 21);
            this.proprietarioSaeCheckBox.TabIndex = 0;
            this.proprietarioSaeCheckBox.Text = "SAE towers";
            this.proprietarioSaeCheckBox.UseVisualStyleBackColor = true;
            this.proprietarioSaeCheckBox.CheckedChanged += new System.EventHandler(this.proprietarioSaeCheckBox_CheckedChanged);
            // 
            // btnCadastraVeiculo
            // 
            this.btnCadastraVeiculo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastraVeiculo.CausesValidation = false;
            this.btnCadastraVeiculo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnCadastraVeiculo.Location = new System.Drawing.Point(677, 386);
            this.btnCadastraVeiculo.Name = "btnCadastraVeiculo";
            this.btnCadastraVeiculo.Size = new System.Drawing.Size(142, 44);
            this.btnCadastraVeiculo.TabIndex = 85;
            this.btnCadastraVeiculo.Text = "Cadastrar";
            this.btnCadastraVeiculo.UseVisualStyleBackColor = false;
            this.btnCadastraVeiculo.Click += new System.EventHandler(this.btnCadastraVeiculo_Click);
            // 
            // txtValorLocacao
            // 
            this.txtValorLocacao.Location = new System.Drawing.Point(434, 39);
            this.txtValorLocacao.Name = "txtValorLocacao";
            this.txtValorLocacao.Size = new System.Drawing.Size(104, 20);
            this.txtValorLocacao.TabIndex = 76;
            this.txtValorLocacao.TextChanged += new System.EventHandler(this.txtValorLocacao_TextChanged);
            this.txtValorLocacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorLocacao_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(431, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 75;
            this.label10.Text = "Valor Locação";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtNcontrato
            // 
            this.txtNcontrato.Location = new System.Drawing.Point(311, 39);
            this.txtNcontrato.Name = "txtNcontrato";
            this.txtNcontrato.Size = new System.Drawing.Size(104, 20);
            this.txtNcontrato.TabIndex = 74;
            this.txtNcontrato.TextChanged += new System.EventHandler(this.txtNcontrato_TextChanged);
            this.txtNcontrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNcontrato_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(308, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 73;
            this.label8.Text = "N° contrato";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(425, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 72;
            this.label7.Text = "Data fim vigência";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(9, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 70;
            this.label6.Text = "Data início vigência";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(248, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Tipo Veículo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(12, 105);
            this.txtMarca.MaxLength = 40;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(157, 20);
            this.txtMarca.TabIndex = 66;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(9, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Marca";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(132, 39);
            this.txtModelo.MaxLength = 40;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(157, 20);
            this.txtModelo.TabIndex = 64;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(129, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Modelo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(12, 39);
            this.txtPlaca.MaxLength = 20;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(104, 20);
            this.txtPlaca.TabIndex = 62;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Placa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(544, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 244);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // inicioVigenciaTextBox
            // 
            this.inicioVigenciaTextBox.Location = new System.Drawing.Point(12, 174);
            this.inicioVigenciaTextBox.Mask = "00/00/0000";
            this.inicioVigenciaTextBox.Name = "inicioVigenciaTextBox";
            this.inicioVigenciaTextBox.Size = new System.Drawing.Size(117, 20);
            this.inicioVigenciaTextBox.TabIndex = 92;
            this.inicioVigenciaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inicioVigenciaTextBox.ValidatingType = typeof(System.DateTime);
            this.inicioVigenciaTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.inicioVigenciaTextBox_MaskInputRejected);
            // 
            // fimVigenciaTextBox
            // 
            this.fimVigenciaTextBox.Location = new System.Drawing.Point(428, 174);
            this.fimVigenciaTextBox.Mask = "00/00/0000";
            this.fimVigenciaTextBox.Name = "fimVigenciaTextBox";
            this.fimVigenciaTextBox.Size = new System.Drawing.Size(107, 20);
            this.fimVigenciaTextBox.TabIndex = 93;
            this.fimVigenciaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fimVigenciaTextBox.ValidatingType = typeof(System.DateTime);
            this.fimVigenciaTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.fimVigenciaTextBox_MaskInputRejected);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(514, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 44);
            this.btnCancelar.TabIndex = 118;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Location = new System.Drawing.Point(251, 105);
            this.txtTipo.MaxDropDownItems = 20;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(121, 21);
            this.txtTipo.TabIndex = 119;
            this.txtTipo.SelectedIndexChanged += new System.EventHandler(this.txtTipo_SelectedIndexChanged);
            this.txtTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipo_KeyPress);
            // 
            // cadastrarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(831, 444);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.fimVigenciaTextBox);
            this.Controls.Add(this.inicioVigenciaTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtAnoVeiculo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastraVeiculo);
            this.Controls.Add(this.txtValorLocacao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNcontrato);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastrarVeiculo";
            this.Text = "cadastrarVeiculo";
            this.Load += new System.EventHandler(this.cadastrarVeiculo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAnoVeiculo;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtObservacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomeTerceiro;
        private System.Windows.Forms.Label lableTerceiro;
        private System.Windows.Forms.CheckBox terceiroCheckBox;
        private System.Windows.Forms.CheckBox proprietarioSaeCheckBox;
        private System.Windows.Forms.Button btnCadastraVeiculo;
        private System.Windows.Forms.TextBox txtValorLocacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNcontrato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox inicioVigenciaTextBox;
        private System.Windows.Forms.MaskedTextBox fimVigenciaTextBox;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox txtTipo;
    }
}