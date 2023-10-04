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
    public partial class cadastroMotorista : Form
    {
        public cadastroMotorista()
        {
            InitializeComponent();
        }

        private void cadastroMotorista_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            txtResultado.Visible = true;
            txtResultado.Text = "Registros encontrados: "+MotoristaDataGridView.RowCount;
        }

        private void adicionarNovoMotoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarMotorista tela = new cadastrarMotorista();

            tela.ShowDialog();
            CarregaGrid();
        }

        private void CarregaGrid() 
        {
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from motorista in context.Motorista
                             select new
                             {
                                 Motorista = motorista.nome,
                                 CPF = motorista.cpf,
                                 Carteira = motorista.carteiraPossuida,
                                 ValidadeCarteira = motorista.validadeCarteira
                             }).ToList();

                MotoristaDataGridView.DataSource = query;
            }
        }

        private void excluirMotoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Tem Certeza que deseja excluir esse veiculo?", "Alerta", buttons, MessageBoxIcon.Exclamation);
            if (result==DialogResult.Yes)
            {
                if (MotoristaDataGridView.SelectedRows.Count > 0)
                {

                    DataGridViewRow linhaSelecionada = MotoristaDataGridView.SelectedRows[0];


                    string cpfMotorista = Convert.ToString(linhaSelecionada.Cells["CPF"].Value);

                    using (ConnectionString context = new ConnectionString())
                    {
                        var motoristaParaExcluir = context.Motorista.FirstOrDefault(v => v.cpf.Equals(cpfMotorista));
                        if (motoristaParaExcluir != null)
                        {
                            context.Motorista.Remove(motoristaParaExcluir);
                            context.SaveChanges();
                            CarregaGrid();
                        }
                    }
                }
            }
        }

        private void editarMotoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Tem Certeza que deseja editar esse Motorista?", "Alerta", buttons, MessageBoxIcon.Exclamation);
            if (result==DialogResult.Yes)
            {
                if (MotoristaDataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow linhaSelecionada = MotoristaDataGridView.SelectedRows[0];

                    string cpfMotorista = Convert.ToString(linhaSelecionada.Cells["CPF"].Value);

                    using (ConnectionString context = new ConnectionString())
                    {
                        var motoristaParaEditar = context.Motorista.FirstOrDefault(v => v.cpf.Equals(cpfMotorista));
                        if (motoristaParaEditar != null)
                        {
                            editarMotorista telaEditar = new editarMotorista(motoristaParaEditar);
                            telaEditar.ShowDialog();
                            CarregaGrid();
                        }
                    }
                }
            }
        }

        private void atualizarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
