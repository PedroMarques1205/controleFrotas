using SaeControleFrota.DAO;
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
    public partial class cadastroTipoVeiculo : Form
    {
        public cadastroTipoVeiculo()
        {
            InitializeComponent();
        }

        private void cadastroTipoVeiculo_Load(object sender, EventArgs e)
        {
            carregaGrid();
            txtResultado.Visible = true;
            txtResultado.Text = "Registros encontrados: "+tipoVeiculoDataGridView.RowCount;
        }

        private void carregaGrid() 
        {
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from tipo in context.TipoVeiculo
                             select new
                             {
                                 Tipo = tipo.nomeTipo,
                                 Numero_de_rodas = tipo.numRodas,
                                 Capacidade_de_passageiros = tipo.capacidadePassageiros,
                                 Carteira_do_tipo = tipo.carteiraNecessaria
                             }).ToList();

                tipoVeiculoDataGridView.DataSource = query;
            }
        }

        private void adicionarTipoVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarTipoVeiculo tela = new cadastrarTipoVeiculo();
            tela.ShowDialog();
            carregaGrid();
        }

        private void excluirTipoVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Tem Certeza que deseja excluir esse veiculo?", "Alerta", buttons, MessageBoxIcon.Exclamation);
            if (result==DialogResult.Yes)
            {
                if (tipoVeiculoDataGridView.SelectedRows.Count > 0)
                {

                    DataGridViewRow linhaSelecionada = tipoVeiculoDataGridView.SelectedRows[0];


                    string nomeTipo = Convert.ToString(linhaSelecionada.Cells["Tipo"].Value);

                    using (ConnectionString context = new ConnectionString())
                    {
                        var veiculoParaExcluir = context.TipoVeiculo.FirstOrDefault(v => v.nomeTipo.Equals(nomeTipo));
                        if (veiculoParaExcluir != null)
                        {
                            context.TipoVeiculo.Remove(veiculoParaExcluir);
                            context.SaveChanges();

                            carregaGrid();
                        }
                    }
                }
            }
        }

        private void editarTipoVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Tem Certeza que deseja editar esse veiculo?", "Alerta", buttons, MessageBoxIcon.Exclamation);
            if (result==DialogResult.Yes)
            {
                if (tipoVeiculoDataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow linhaSelecionada = tipoVeiculoDataGridView.SelectedRows[0];

                    string tipoVeiculo = Convert.ToString(linhaSelecionada.Cells["Tipo"].Value);

                    using (ConnectionString context = new ConnectionString())
                    {
                        var veiculoParaEditar = context.TipoVeiculo.FirstOrDefault(t => t.nomeTipo.Equals(tipoVeiculo));
                        if (veiculoParaEditar != null)
                        {
                            editarTipoVeiculo telaEditar = new editarTipoVeiculo(veiculoParaEditar);
                            Veiculo aux = new Veiculo();
                            telaEditar.ShowDialog();
                            carregaGrid();
                        }
                    }
                }
            }
        }

        private void atualizarListaTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carregaGrid();
        }
    }
}
