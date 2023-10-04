using SaeControleFrota.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaeControleFrota
{
    public partial class Lancamentos : Form
    {
        public Lancamentos()
        {
            InitializeComponent();
        }

        private void adicionarNovoVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarLancamento telaLancamento = new cadastrarLancamento();
            telaLancamento.ShowDialog();

            atualizaLista();
        }

        private void Lancamentos_Load(object sender, EventArgs e)
        {
            atualizaLista();
            txtResultado.Visible = true;
            txtResultado.Text = "Registros encontrados: "+LancamentoDataGridView.RowCount;

        }

        private void atualizaLista()
        {
            using (ConnectionString context = new ConnectionString())
            {
                List<Lancamentos> lancamentos = new List<Lancamentos>();

                var query = (from lancamento in context.LancamentoDiario
                             select new
                             {
                                 Placa = lancamento.placa,
                                 Motorista = lancamento.motorista,
                                 DataLancamento = lancamento.data,
                                 HorarioChegada = lancamento.horarioChegada,
                                 HorarioSaida = lancamento.horarioSaida,
                                 KmRodados = lancamento.kmRodados,
                                 NomeAtividade = lancamento.nomeAtividade,
                                 IsResponsabilidadeSae = lancamento.isResponsabilidadeSae,
                                 DescontoDiarias = lancamento.descontoDiarias,
                                 ValorManutencao = lancamento.valorManutencao,
                                 LitrosOleoUsado = lancamento.litrosOleoUsado,
                                 ValorLitro = lancamento.valorLitro,
                                 ValorTotalLitro = lancamento.valorTotalLitro,
                                 ValorDiaria = lancamento.valorDiaria
                             }).ToList();


                LancamentoDataGridView.DataSource = query;
            }
        }

        private void excluirVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Tem Certeza que deseja excluir esse veiculo?", "Alerta", buttons, MessageBoxIcon.Exclamation);
            if (result==DialogResult.Yes)
            {
                if (LancamentoDataGridView.SelectedRows.Count > 0)
                {

                    DataGridViewRow linhaSelecionada = LancamentoDataGridView.SelectedRows[0];


                    string placaVeiculo = Convert.ToString(linhaSelecionada.Cells["placa"].Value);

                    using (ConnectionString context = new ConnectionString())
                    {
                        LancamentoDiario veiculoParaExcluir = context.LancamentoDiario.FirstOrDefault(l => l.placa.Equals(placaVeiculo));
                        if (veiculoParaExcluir != null)
                        {
                            context.LancamentoDiario.Remove(veiculoParaExcluir);
                            context.SaveChanges();
                            atualizaLista();
                        }
                    }
                }
            }
        }

        private void atualizarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atualizaLista();
        }
    }
}
