namespace SaeControleFrota
{
    partial class Lancamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lancamentos));
            this.LancamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarNovoVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.LancamentoDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LancamentoDataGridView
            // 
            this.LancamentoDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            this.LancamentoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LancamentoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LancamentoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LancamentoDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.LancamentoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.LancamentoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LancamentoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LancamentoDataGridView.ColumnHeadersHeight = 30;
            this.LancamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LancamentoDataGridView.GridColor = System.Drawing.Color.Gold;
            this.LancamentoDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LancamentoDataGridView.Location = new System.Drawing.Point(13, 48);
            this.LancamentoDataGridView.Name = "LancamentoDataGridView";
            this.LancamentoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.LancamentoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.LancamentoDataGridView.RowHeadersWidth = 70;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.LancamentoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.LancamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LancamentoDataGridView.Size = new System.Drawing.Size(775, 376);
            this.LancamentoDataGridView.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarNovoVeiculoToolStripMenuItem,
            this.excluirVeiculoToolStripMenuItem,
            this.atualizarListaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarNovoVeiculoToolStripMenuItem
            // 
            this.adicionarNovoVeiculoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.adicionarNovoVeiculoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adicionarNovoVeiculoToolStripMenuItem.Image")));
            this.adicionarNovoVeiculoToolStripMenuItem.Name = "adicionarNovoVeiculoToolStripMenuItem";
            this.adicionarNovoVeiculoToolStripMenuItem.Size = new System.Drawing.Size(156, 21);
            this.adicionarNovoVeiculoToolStripMenuItem.Text = "Realizar lançamento";
            this.adicionarNovoVeiculoToolStripMenuItem.Click += new System.EventHandler(this.adicionarNovoVeiculoToolStripMenuItem_Click);
            // 
            // excluirVeiculoToolStripMenuItem
            // 
            this.excluirVeiculoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.excluirVeiculoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excluirVeiculoToolStripMenuItem.Image")));
            this.excluirVeiculoToolStripMenuItem.Name = "excluirVeiculoToolStripMenuItem";
            this.excluirVeiculoToolStripMenuItem.Size = new System.Drawing.Size(148, 21);
            this.excluirVeiculoToolStripMenuItem.Text = "Excluir lançamento";
            this.excluirVeiculoToolStripMenuItem.Click += new System.EventHandler(this.excluirVeiculoToolStripMenuItem_Click);
            // 
            // atualizarListaToolStripMenuItem
            // 
            this.atualizarListaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.atualizarListaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("atualizarListaToolStripMenuItem.Image")));
            this.atualizarListaToolStripMenuItem.Name = "atualizarListaToolStripMenuItem";
            this.atualizarListaToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.atualizarListaToolStripMenuItem.Text = "Atualizar lista";
            this.atualizarListaToolStripMenuItem.Click += new System.EventHandler(this.atualizarListaToolStripMenuItem_Click);
            // 
            // Lancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LancamentoDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lancamentos";
            this.Text = "Lancamentos";
            this.Load += new System.EventHandler(this.Lancamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LancamentoDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LancamentoDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarNovoVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarListaToolStripMenuItem;
    }
}