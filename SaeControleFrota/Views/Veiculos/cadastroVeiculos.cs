using SaeControleFrota.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaeControleFrota
{
    public partial class cadastroVeiculos : Form
    {
        public cadastroVeiculos()
        {
            InitializeComponent();
        }

        private void adicionarNovoVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarVeiculo telaCadastro = new cadastrarVeiculo();
            telaCadastro.ShowDialog();
            CarregaGrid();
        }

        private void excluirVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Tem Certeza que deseja excluir esse veiculo?","Alerta",buttons,MessageBoxIcon.Exclamation);
            if (result==DialogResult.Yes)
            {
                if (VeiculoDataGridView.SelectedRows.Count > 0)
                {

                    DataGridViewRow linhaSelecionada = VeiculoDataGridView.SelectedRows[0];


                    string placaVeiculo = Convert.ToString(linhaSelecionada.Cells["placa"].Value);

                    using (ConnectionString context = new ConnectionString())
                    {
                        var veiculoParaExcluir = context.Veiculo.FirstOrDefault(v => v.placa.Equals(placaVeiculo));
                        if (veiculoParaExcluir != null)
                        {
                            context.Veiculo.Remove(veiculoParaExcluir);
                            context.SaveChanges();

                            CarregaGrid();
                        }
                    }
                }
            }
        }

        private void cadastroVeiculos_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void atualizarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from veiculo in context.Veiculo
                             select new
                             {
                                 Placa = veiculo.placa,
                                 Modelo = veiculo.modelo,
                                 Marca = veiculo.marca,
                                 Ano = veiculo.ano,
                                 Familia = veiculo.familia,
                                 ProprietarioSAE = veiculo.isProprietarioSae,
                                 InicioVigencia = veiculo.inicioVigencia,
                                 FimVigencia = veiculo.fimVigencia,
                                 Contrato = veiculo.numContrato,
                                 ValorLocacao = veiculo.valorLocacao,
                                 Proprietario = veiculo.proprietario,
                                 Observacao = veiculo.observacao
                             }).ToList();

                VeiculoDataGridView.DataSource = query;

                txtResultado.Visible = true;
                txtResultado.Text = "Registros encontrados: "+VeiculoDataGridView.RowCount;
            }
        }

        private void atualizarListaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void editarVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Tem Certeza que deseja editar esse veiculo?", "Alerta", buttons, MessageBoxIcon.Exclamation);
            if (result==DialogResult.Yes)
            {
                if (VeiculoDataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow linhaSelecionada = VeiculoDataGridView.SelectedRows[0];

                    string placaVeiculo = Convert.ToString(linhaSelecionada.Cells["placa"].Value);

                    using (ConnectionString context = new ConnectionString())
                    {
                        var veiculoParaEditar = context.Veiculo.FirstOrDefault(v => v.placa.Equals(placaVeiculo));
                        if (veiculoParaEditar != null)
                        {
                            editarVeiculo telaEditar = new editarVeiculo(veiculoParaEditar);
                            Veiculo aux = new Veiculo();
                            telaEditar.ShowDialog();
                            CarregaGrid();
                        }
                    }
                }
            }
        }
    }
}
