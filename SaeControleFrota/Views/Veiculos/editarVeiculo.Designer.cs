namespace SaeControleFrota
{
    partial class editarVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editarVeiculo));
            this.fimVigenciaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.inicioVigenciaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fimVigenciaTextBox
            // 
            this.fimVigenciaTextBox.Location = new System.Drawing.Point(426, 199);
            this.fimVigenciaTextBox.Mask = "00/00/0000";
            this.fimVigenciaTextBox.Name = "fimVigenciaTextBox";
            this.fimVigenciaTextBox.Size = new System.Drawing.Size(107, 20);
            this.fimVigenciaTextBox.TabIndex = 116;
            this.fimVigenciaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fimVigenciaTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // inicioVigenciaTextBox
            // 
            this.inicioVigenciaTextBox.Location = new System.Drawing.Point(10, 199);
            this.inicioVigenciaTextBox.Mask = "00/00/0000";
            this.inicioVigenciaTextBox.Name = "inicioVigenciaTextBox";
            this.inicioVigenciaTextBox.Size = new System.Drawing.Size(117, 20);
            this.inicioVigenciaTextBox.TabIndex = 115;
            this.inicioVigenciaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inicioVigenciaTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(553, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 244);
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // txtAnoVeiculo
            // 
            this.txtAnoVeiculo.Location = new System.Drawing.Point(432, 130);
            this.txtAnoVeiculo.MaxLength = 4;
            this.txtAnoVeiculo.Name = "txtAnoVeiculo";
            this.txtAnoVeiculo.Size = new System.Drawing.Size(104, 20);
            this.txtAnoVeiculo.TabIndex = 113;
            this.txtAnoVeiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoVeiculo_KeyPress);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label.Location = new System.Drawing.Point(429, 113);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(95, 17);
            this.label.TabIndex = 112;
            this.label.Text = "Ano do veiculo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(14, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 111;
            this.label9.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(17, 259);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(503, 146);
            this.txtObservacao.TabIndex = 110;
            this.txtObservacao.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomeTerceiro);
            this.groupBox1.Controls.Add(this.lableTerceiro);
            this.groupBox1.Controls.Add(this.terceiroCheckBox);
            this.groupBox1.Controls.Add(this.proprietarioSaeCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(542, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 128);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proprietário";
            // 
            // txtNomeTerceiro
            // 
            this.txtNomeTerceiro.Location = new System.Drawing.Point(20, 94);
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
            this.terceiroCheckBox.CheckedChanged += new System.EventHandler(this.terceiroCheckBox_CheckedChanged_1);
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
            // 
            // btnCadastraVeiculo
            // 
            this.btnCadastraVeiculo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastraVeiculo.CausesValidation = false;
            this.btnCadastraVeiculo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnCadastraVeiculo.Location = new System.Drawing.Point(675, 411);
            this.btnCadastraVeiculo.Name = "btnCadastraVeiculo";
            this.btnCadastraVeiculo.Size = new System.Drawing.Size(142, 44);
            this.btnCadastraVeiculo.TabIndex = 108;
            this.btnCadastraVeiculo.Text = "Editar";
            this.btnCadastraVeiculo.UseVisualStyleBackColor = false;
            this.btnCadastraVeiculo.Click += new System.EventHandler(this.btnCadastraVeiculo_Click_1);
            // 
            // txtValorLocacao
            // 
            this.txtValorLocacao.Location = new System.Drawing.Point(432, 64);
            this.txtValorLocacao.Name = "txtValorLocacao";
            this.txtValorLocacao.Size = new System.Drawing.Size(104, 20);
            this.txtValorLocacao.TabIndex = 107;
            this.txtValorLocacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorLocacao_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(429, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 106;
            this.label10.Text = "Valor Locação";
            // 
            // txtNcontrato
            // 
            this.txtNcontrato.Location = new System.Drawing.Point(309, 64);
            this.txtNcontrato.Name = "txtNcontrato";
            this.txtNcontrato.Size = new System.Drawing.Size(104, 20);
            this.txtNcontrato.TabIndex = 105;
            this.txtNcontrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNcontrato_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(306, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 104;
            this.label8.Text = "N° contrato";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(423, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 103;
            this.label7.Text = "Data fim vigência";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(7, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 102;
            this.label6.Text = "Data início vigência";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(246, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 100;
            this.label4.Text = "Familia";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(10, 130);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(157, 20);
            this.txtMarca.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(7, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 98;
            this.label5.Text = "Marca";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(130, 64);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(157, 20);
            this.txtModelo.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(127, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 96;
            this.label3.Text = "Modelo";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(10, 64);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = true;
            this.txtPlaca.Size = new System.Drawing.Size(104, 20);
            this.txtPlaca.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Placa";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(512, 411);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 44);
            this.btnCancelar.TabIndex = 117;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Location = new System.Drawing.Point(249, 130);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(121, 21);
            this.txtTipo.TabIndex = 118;
            this.txtTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipo_KeyPress);
            // 
            // editarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 462);
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
            this.Name = "editarVeiculo";
            this.Text = "editarVeiculo";
            this.Load += new System.EventHandler(this.editarVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lableTerceiro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.MaskedTextBox fimVigenciaTextBox;
        public System.Windows.Forms.MaskedTextBox inicioVigenciaTextBox;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtAnoVeiculo;
        public System.Windows.Forms.RichTextBox txtObservacao;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtNomeTerceiro;
        public System.Windows.Forms.CheckBox terceiroCheckBox;
        public System.Windows.Forms.CheckBox proprietarioSaeCheckBox;
        public System.Windows.Forms.Button btnCadastraVeiculo;
        public System.Windows.Forms.TextBox txtValorLocacao;
        public System.Windows.Forms.TextBox txtNcontrato;
        public System.Windows.Forms.TextBox txtMarca;
        public System.Windows.Forms.TextBox txtModelo;
        public System.Windows.Forms.TextBox txtPlaca;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox txtTipo;
    }
}