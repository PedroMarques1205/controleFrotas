namespace SaeControleFrota
{
    partial class editarMotorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editarMotorista));
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeMotorista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.carteiraDropDown = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtValidade = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastraVeiculo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Location = new System.Drawing.Point(13, 61);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(84, 20);
            this.txtCpf.TabIndex = 157;
            // 
            // txtNomeMotorista
            // 
            this.txtNomeMotorista.Location = new System.Drawing.Point(205, 61);
            this.txtNomeMotorista.Name = "txtNomeMotorista";
            this.txtNomeMotorista.Size = new System.Drawing.Size(242, 20);
            this.txtNomeMotorista.TabIndex = 156;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(205, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 155;
            this.label1.Text = "Nome do Motorista";
            // 
            // carteiraDropDown
            // 
            this.carteiraDropDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.carteiraDropDown.FormattingEnabled = true;
            this.carteiraDropDown.Location = new System.Drawing.Point(236, 210);
            this.carteiraDropDown.MaxDropDownItems = 20;
            this.carteiraDropDown.Name = "carteiraDropDown";
            this.carteiraDropDown.Size = new System.Drawing.Size(144, 21);
            this.carteiraDropDown.TabIndex = 154;
            this.carteiraDropDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carteiraDropDown_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(110, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 44);
            this.btnCancelar.TabIndex = 153;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtValidade
            // 
            this.txtValidade.Location = new System.Drawing.Point(17, 210);
            this.txtValidade.Mask = "00/00/0000";
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.Size = new System.Drawing.Size(117, 20);
            this.txtValidade.TabIndex = 152;
            this.txtValidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValidade.ValidatingType = typeof(System.DateTime);
            this.txtValidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidade_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(453, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 452);
            this.pictureBox1.TabIndex = 151;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastraVeiculo
            // 
            this.btnCadastraVeiculo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastraVeiculo.CausesValidation = false;
            this.btnCadastraVeiculo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnCadastraVeiculo.Location = new System.Drawing.Point(300, 395);
            this.btnCadastraVeiculo.Name = "btnCadastraVeiculo";
            this.btnCadastraVeiculo.Size = new System.Drawing.Size(142, 44);
            this.btnCadastraVeiculo.TabIndex = 150;
            this.btnCadastraVeiculo.Text = "Editar";
            this.btnCadastraVeiculo.UseVisualStyleBackColor = false;
            this.btnCadastraVeiculo.Click += new System.EventHandler(this.btnCadastraVeiculo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(14, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 149;
            this.label6.Text = "Data início vigência";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(233, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 148;
            this.label4.Text = "Carteira de Motorista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 147;
            this.label2.Text = "CPF do Motorista";
            // 
            // editarMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNomeMotorista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carteiraDropDown);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtValidade);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCadastraVeiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editarMotorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editarMotorista";
            this.Load += new System.EventHandler(this.editarMotorista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.TextBox txtNomeMotorista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox carteiraDropDown;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox txtValidade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastraVeiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}