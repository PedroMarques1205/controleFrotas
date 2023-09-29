using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaeControleFrota
{
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cadastroVeiculos telaVeiculos = new cadastroVeiculos();

            telaVeiculos.WindowState= System.Windows.Forms.FormWindowState.Maximized;

            telaVeiculos.MdiParent = this;
            telaVeiculos.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Lancamentos lancamentos = new Lancamentos();
            lancamentos.WindowState =System.Windows.Forms.FormWindowState.Maximized;

            lancamentos.MdiParent = this;
            lancamentos.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            relatorioMensal tela = new relatorioMensal();
            tela.WindowState =System.Windows.Forms.FormWindowState.Maximized;

            tela.MdiParent = this;
            tela.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            cadastroTipoVeiculo tela = new cadastroTipoVeiculo();
            tela.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            tela.MdiParent = this;
            tela.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            cadastroMotorista tela = new cadastroMotorista();
            tela.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            tela.MdiParent = this;
            tela.Show();
        }
    }
}
