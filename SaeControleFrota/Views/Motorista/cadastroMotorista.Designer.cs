namespace SaeControleFrota
{
    partial class cadastroMotorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroMotorista));
            this.MotoristaDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarNovoMotoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirMotoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarMotoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MotoristaDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MotoristaDataGridView
            // 
            this.MotoristaDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            this.MotoristaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MotoristaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MotoristaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MotoristaDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.MotoristaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.MotoristaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MotoristaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MotoristaDataGridView.ColumnHeadersHeight = 30;
            this.MotoristaDataGridView.GridColor = System.Drawing.Color.Gold;
            this.MotoristaDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MotoristaDataGridView.Location = new System.Drawing.Point(13, 56);
            this.MotoristaDataGridView.Name = "MotoristaDataGridView";
            this.MotoristaDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.MotoristaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MotoristaDataGridView.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.MotoristaDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.MotoristaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MotoristaDataGridView.Size = new System.Drawing.Size(775, 380);
            this.MotoristaDataGridView.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarNovoMotoristaToolStripMenuItem,
            this.excluirMotoristaToolStripMenuItem,
            this.editarMotoristaToolStripMenuItem,
            this.atualizarListaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarNovoMotoristaToolStripMenuItem
            // 
            this.adicionarNovoMotoristaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.adicionarNovoMotoristaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adicionarNovoMotoristaToolStripMenuItem.Image")));
            this.adicionarNovoMotoristaToolStripMenuItem.Name = "adicionarNovoMotoristaToolStripMenuItem";
            this.adicionarNovoMotoristaToolStripMenuItem.Size = new System.Drawing.Size(190, 21);
            this.adicionarNovoMotoristaToolStripMenuItem.Text = "Adicionar novo Motorista";
            this.adicionarNovoMotoristaToolStripMenuItem.Click += new System.EventHandler(this.adicionarNovoMotoristaToolStripMenuItem_Click);
            // 
            // excluirMotoristaToolStripMenuItem
            // 
            this.excluirMotoristaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.excluirMotoristaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excluirMotoristaToolStripMenuItem.Image")));
            this.excluirMotoristaToolStripMenuItem.Name = "excluirMotoristaToolStripMenuItem";
            this.excluirMotoristaToolStripMenuItem.Size = new System.Drawing.Size(137, 21);
            this.excluirMotoristaToolStripMenuItem.Text = "Excluir Motorista";
            this.excluirMotoristaToolStripMenuItem.Click += new System.EventHandler(this.excluirMotoristaToolStripMenuItem_Click);
            // 
            // editarMotoristaToolStripMenuItem
            // 
            this.editarMotoristaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.editarMotoristaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarMotoristaToolStripMenuItem.Image")));
            this.editarMotoristaToolStripMenuItem.Name = "editarMotoristaToolStripMenuItem";
            this.editarMotoristaToolStripMenuItem.Size = new System.Drawing.Size(134, 21);
            this.editarMotoristaToolStripMenuItem.Text = "Editar Motorista";
            this.editarMotoristaToolStripMenuItem.Click += new System.EventHandler(this.editarMotoristaToolStripMenuItem_Click);
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
            // cadastroMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MotoristaDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastroMotorista";
            this.Text = "cadastroMotorista";
            this.Load += new System.EventHandler(this.cadastroMotorista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MotoristaDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MotoristaDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarNovoMotoristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirMotoristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarMotoristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarListaToolStripMenuItem;
    }
}