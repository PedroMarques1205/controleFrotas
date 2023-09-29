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
    public partial class cadastrarLancamento : Form
    {
        public cadastrarLancamento()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void manCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (manCheckBox.Checked)
            {
                oleoCheckBox.Checked = false;
                OutrosCheckBox.Checked = false;
                ManGroupBox.Visible = true;
                trocaOleoGroupBox.Visible = false;
                outrosGroupBox.Visible = false;
            }
        }

        private void oleoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (oleoCheckBox.Checked)
            {
                trocaOleoGroupBox.Visible = true;
                manCheckBox.Checked = false;
                OutrosCheckBox.Checked = false;
                ManGroupBox.Visible = false;
                outrosGroupBox.Visible = false;
            }
        }

        private void OutrosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OutrosCheckBox.Checked)
            {
                outrosGroupBox.Visible = true;
                manCheckBox.Checked = false;
                oleoCheckBox.Checked = false;
                ManGroupBox.Visible = false;
                trocaOleoGroupBox.Visible = false;
            }
        }

        private void cadastrarLancamento_Load(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                foreach (Motorista item in context.Motorista)
                {
                    if (item.validadeCarteira > DateTime.Now)
                    {
                        txtMotorista.Items.Add(item.nome);
                    }
                }
                foreach (Veiculo item in context.Veiculo)
                {
                    placaDropDown.Items.Add(item.placa);
                }
            }
        }

        private bool TemCadastrado(LancamentoDiario lancamento)
        {
            using (ConnectionString context = new ConnectionString())
            {
                foreach (LancamentoDiario item in context.LancamentoDiario)
                {
                    if (item.Equals(lancamento))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private void btnCadastraVeiculo_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    LancamentoDiario lancamento = new LancamentoDiario();

                    lancamento.placa = placaDropDown.Text;
                    lancamento.kmRodados = Convert.ToDouble(txtKmRodados.Text);
                    lancamento.data = dataTimeLancamento.Value;
                    lancamento.horarioChegada = TimeSpan.Parse(txtHoraChegada.Text);
                    lancamento.horarioSaida = TimeSpan.Parse(txtHoraSaida.Text);

                    if (manCheckBox.Checked)
                    {
                        lancamento.idTipoAtividade = 1;
                        lancamento.nomeAtividade = "Manutencao";
                        lancamento.valorDiaria = Convert.ToDouble(txtValorDiaria.Text);
                        lancamento.motorista = txtMotorista.Text;
                        lancamento.valorManutencao = Convert.ToDouble(txtValorMan.Text);
                        if (IsSaeResponManCheckBox.Checked)
                        {
                            lancamento.isResponsabilidadeSae = true;
                        }
                        else
                        {
                            lancamento.isResponsabilidadeSae = false;
                        }
                        if (IsDescontoCheckBox.Checked)
                        {
                            lancamento.descontoDiarias = Convert.ToDouble(txtValorDesconto.Text);
                            lancamento.valorManutencao += Convert.ToDouble((lancamento.valorDiaria-lancamento.descontoDiarias)*30);
                        }
                        else
                        {
                            lancamento.descontoDiarias = 0;
                            lancamento.valorManutencao += Convert.ToDouble((lancamento.valorDiaria-lancamento.descontoDiarias)*30);
                        }
                    }
                    else if (oleoCheckBox.Checked)
                    {
                        lancamento.idTipoAtividade = 2;
                        lancamento.nomeAtividade = "Troca de oleo";
                        lancamento.motorista = txtMotorista.Text;
                        lancamento.valorLitro = Convert.ToDouble(txtValorLitro.Text);
                        lancamento.litrosOleoUsado = Convert.ToDouble(txtLitrosUsados.Text);
                        lancamento.valorTotalLitro = (lancamento.valorLitro*lancamento.litrosOleoUsado);
                        lancamento.valorManutencao = Convert.ToDouble(txtValorTrocaOleo.Text);
                        if (isResponSaeOleo.Checked)
                        {
                            lancamento.isResponsabilidadeSae = true;
                            lancamento.valorManutencao += Convert.ToDouble(lancamento.valorLitro*lancamento.litrosOleoUsado);
                        }
                        else
                        {
                            lancamento.isResponsabilidadeSae = false;
                            lancamento.descontoDiarias = Convert.ToDouble(txtValorDesconto.Text);
                            lancamento.valorManutencao += Convert.ToDouble(lancamento.valorLitro*lancamento.litrosOleoUsado);
                        }
                    }
                    else if (OutrosCheckBox.Checked)
                    {
                        lancamento.idTipoAtividade = 3;
                        lancamento.nomeAtividade = "Outros";
                        lancamento.motorista = txtMotorista.Text;
                        lancamento.valorManutencao = Convert.ToDouble(txtValorManOutros.Text);
                        if (isRespoSaeOutros.Checked)
                        {
                            lancamento.isResponsabilidadeSae = true;
                            lancamento.valorManutencao += Convert.ToDouble(txtValorArcadoSae.Text);
                        }
                        else
                        {
                            lancamento.isResponsabilidadeSae = false;
                        }
                    }
                    if (TemCadastrado(lancamento))
                    {
                        MessageBoxButtons button = MessageBoxButtons.OK;
                        MessageBox.Show("Já foi feito um lançamento com esses dados previamente", "Error", button, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        context.LancamentoDiario.Add(lancamento);
                        context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Lançamento Cadastrado com sucesso", "Cadastrado", buttons, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Erro ao realizar lançamento, certifiquese de que informou os dados corretamente", "Error", buttons, MessageBoxIcon.Error);
                }
            }
        }

        private void IsDescontoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsDescontoCheckBox.Checked)
            {
                label9.Visible = true;
                txtValorDesconto.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Tem Certeza que deseja cancelar o cadastro?", "Alerta", buttons, MessageBoxIcon.Warning);
            if (result==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMotorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtKmRodados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
