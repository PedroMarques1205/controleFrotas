namespace SaeControleFrota
{
    partial class cadastroVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroVeiculos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarNovoVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VeiculoDataGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtResultado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VeiculoDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarNovoVeiculoToolStripMenuItem,
            this.excluirVeiculoToolStripMenuItem,
            this.editarVeiculoToolStripMenuItem,
            this.atualizarListaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarNovoVeiculoToolStripMenuItem
            // 
            this.adicionarNovoVeiculoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.adicionarNovoVeiculoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adicionarNovoVeiculoToolStripMenuItem.Image")));
            this.adicionarNovoVeiculoToolStripMenuItem.Name = "adicionarNovoVeiculoToolStripMenuItem";
            this.adicionarNovoVeiculoToolStripMenuItem.Size = new System.Drawing.Size(174, 21);
            this.adicionarNovoVeiculoToolStripMenuItem.Text = "Adicionar novo Veiculo";
            this.adicionarNovoVeiculoToolStripMenuItem.Click += new System.EventHandler(this.adicionarNovoVeiculoToolStripMenuItem_Click);
            // 
            // excluirVeiculoToolStripMenuItem
            // 
            this.excluirVeiculoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.excluirVeiculoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excluirVeiculoToolStripMenuItem.Image")));
            this.excluirVeiculoToolStripMenuItem.Name = "excluirVeiculoToolStripMenuItem";
            this.excluirVeiculoToolStripMenuItem.Size = new System.Drawing.Size(121, 21);
            this.excluirVeiculoToolStripMenuItem.Text = "Excluir Veiculo";
            this.excluirVeiculoToolStripMenuItem.Click += new System.EventHandler(this.excluirVeiculoToolStripMenuItem_Click);
            // 
            // editarVeiculoToolStripMenuItem
            // 
            this.editarVeiculoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.editarVeiculoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarVeiculoToolStripMenuItem.Image")));
            this.editarVeiculoToolStripMenuItem.Name = "editarVeiculoToolStripMenuItem";
            this.editarVeiculoToolStripMenuItem.Size = new System.Drawing.Size(118, 21);
            this.editarVeiculoToolStripMenuItem.Text = "Editar Veiculo";
            this.editarVeiculoToolStripMenuItem.Click += new System.EventHandler(this.editarVeiculoToolStripMenuItem_Click);
            // 
            // atualizarListaToolStripMenuItem
            // 
            this.atualizarListaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.atualizarListaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("atualizarListaToolStripMenuItem.Image")));
            this.atualizarListaToolStripMenuItem.Name = "atualizarListaToolStripMenuItem";
            this.atualizarListaToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.atualizarListaToolStripMenuItem.Text = "Atualizar lista";
            this.atualizarListaToolStripMenuItem.Click += new System.EventHandler(this.atualizarListaToolStripMenuItem_Click_1);
            // 
            // VeiculoDataGridView
            // 
            this.VeiculoDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            this.VeiculoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.VeiculoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VeiculoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VeiculoDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.VeiculoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.VeiculoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VeiculoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.VeiculoDataGridView.ColumnHeadersHeight = 30;
            this.VeiculoDataGridView.GridColor = System.Drawing.Color.Gold;
            this.VeiculoDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VeiculoDataGridView.Location = new System.Drawing.Point(13, 42);
            this.VeiculoDataGridView.Name = "VeiculoDataGridView";
            this.VeiculoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.VeiculoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.VeiculoDataGridView.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.VeiculoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.VeiculoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VeiculoDataGridView.Size = new System.Drawing.Size(775, 380);
            this.VeiculoDataGridView.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtResultado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 68;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(139, 19);
            this.txtResultado.Text = "toolStripStatusLabel1";
            this.txtResultado.Visible = false;
            // 
            // cadastroVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.VeiculoDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "cadastroVeiculos";
            this.Text = "Veiculos Cadastros";
            this.Load += new System.EventHandler(this.cadastroVeiculos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VeiculoDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarNovoVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarVeiculoToolStripMenuItem;
        private System.Windows.Forms.DataGridView VeiculoDataGridView;
        private System.Windows.Forms.ToolStripMenuItem atualizarListaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtResultado;
    }
}