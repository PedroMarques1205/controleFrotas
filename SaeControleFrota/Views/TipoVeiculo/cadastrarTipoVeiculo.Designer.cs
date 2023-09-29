namespace SaeControleFrota
{
    partial class cadastrarTipoVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrarTipoVeiculo));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastraVeiculo = new System.Windows.Forms.Button();
            this.txtNpassageiros = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumRodas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.carteiraDropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(9, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 44);
            this.btnCancelar.TabIndex = 142;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(437, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 459);
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastraVeiculo
            // 
            this.btnCadastraVeiculo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastraVeiculo.CausesValidation = false;
            this.btnCadastraVeiculo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnCadastraVeiculo.Location = new System.Drawing.Point(280, 393);
            this.btnCadastraVeiculo.Name = "btnCadastraVeiculo";
            this.btnCadastraVeiculo.Size = new System.Drawing.Size(142, 44);
            this.btnCadastraVeiculo.TabIndex = 133;
            this.btnCadastraVeiculo.Text = "Cadastrar";
            this.btnCadastraVeiculo.UseVisualStyleBackColor = false;
            this.btnCadastraVeiculo.Click += new System.EventHandler(this.btnCadastraVeiculo_Click);
            // 
            // txtNpassageiros
            // 
            this.txtNpassageiros.Location = new System.Drawing.Point(233, 187);
            this.txtNpassageiros.MaxLength = 2;
            this.txtNpassageiros.Name = "txtNpassageiros";
            this.txtNpassageiros.Size = new System.Drawing.Size(63, 20);
            this.txtNpassageiros.TabIndex = 130;
            this.txtNpassageiros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNpassageiros_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(230, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 17);
            this.label8.TabIndex = 129;
            this.label8.Text = "Capacidade total de passageiros";
            // 
            // txtNumRodas
            // 
            this.txtNumRodas.Location = new System.Drawing.Point(9, 187);
            this.txtNumRodas.MaxLength = 2;
            this.txtNumRodas.Name = "txtNumRodas";
            this.txtNumRodas.Size = new System.Drawing.Size(63, 20);
            this.txtNumRodas.TabIndex = 123;
            this.txtNumRodas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumRodas_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(6, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 122;
            this.label3.Text = "Num de rodas";
            // 
            // txtNomeTipo
            // 
            this.txtNomeTipo.Location = new System.Drawing.Point(9, 55);
            this.txtNomeTipo.MaxLength = 200;
            this.txtNomeTipo.Name = "txtNomeTipo";
            this.txtNomeTipo.Size = new System.Drawing.Size(160, 20);
            this.txtNomeTipo.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 120;
            this.label2.Text = "Nome do tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(247, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 143;
            this.label1.Text = "Tipo de carteira";
            // 
            // carteiraDropDown
            // 
            this.carteiraDropDown.FormattingEnabled = true;
            this.carteiraDropDown.Location = new System.Drawing.Point(250, 55);
            this.carteiraDropDown.Name = "carteiraDropDown";
            this.carteiraDropDown.Size = new System.Drawing.Size(121, 21);
            this.carteiraDropDown.TabIndex = 144;
            this.carteiraDropDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carteiraDropDown_KeyPress);
            // 
            // cadastrarTipoVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 449);
            this.Controls.Add(this.carteiraDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCadastraVeiculo);
            this.Controls.Add(this.txtNpassageiros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumRodas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeTipo);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "cadastrarTipoVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastrarTipoVeiculo";
            this.Load += new System.EventHandler(this.cadastrarTipoVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastraVeiculo;
        private System.Windows.Forms.TextBox txtNpassageiros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumRodas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox carteiraDropDown;
    }
}