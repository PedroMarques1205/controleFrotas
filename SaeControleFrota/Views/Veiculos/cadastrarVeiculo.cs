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
    public partial class cadastrarVeiculo : Form
    {
        public cadastrarVeiculo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCadastraVeiculo_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    Veiculo veiculo = new Veiculo();

                    veiculo.placa = txtPlaca.Text;
                    veiculo.familia= txtTipo.Text;
                    veiculo.marca = txtMarca.Text;
                    veiculo.modelo = txtModelo.Text;
                    veiculo.numContrato = Convert.ToInt32(txtNcontrato.Text);
                    veiculo.valorLocacao = Convert.ToDouble(txtValorLocacao.Text);
                    veiculo.ano = Convert.ToInt32(txtAnoVeiculo.Text);
                    veiculo.observacao = txtObservacao.Text;
                    veiculo.inicioVigencia = DateTime.Parse(inicioVigenciaTextBox.Text);
                    veiculo.fimVigencia = DateTime.Parse(fimVigenciaTextBox.Text);
                    if (proprietarioSaeCheckBox.Checked)
                    {
                        veiculo.isProprietarioSae = true;
                        veiculo.proprietario = "SAE towers";
                    }
                    else
                    {
                        veiculo.isProprietarioSae = false;
                        veiculo.proprietario = txtNomeTerceiro.Text;
                    }
                    if (TemCadastrado(veiculo))
                    {
                        MessageBoxButtons button = MessageBoxButtons.OK;
                        MessageBox.Show("Já existe um veículo com essa placa cadastrada", "Error", button, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        context.Veiculo.Add(veiculo);
                        context.SaveChanges();

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Veiculo Cadastrado com sucesso", "Cadastrado", buttons, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Erro ao Cadastrar veiculo, certifiquese de que informou os dados corretamente", "Error", buttons, MessageBoxIcon.Error);
                }
            }
        }

        private bool TemCadastrado(Veiculo veiculo)
        {
            using (ConnectionString context = new ConnectionString())
            {
                foreach (Veiculo item in context.Veiculo)
                {
                    if (item.placa.Equals(veiculo.placa))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        private void proprietarioSaeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            terceiroCheckBox.Checked = false;
        }

        private void terceiroCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (terceiroCheckBox.Checked)
            {
                proprietarioSaeCheckBox.Checked = false;
                lableTerceiro.Visible = true;
                txtNomeTerceiro.Visible = true;
            }
            else if (!terceiroCheckBox.Checked)
            {
                lableTerceiro.Visible = false;
                txtNomeTerceiro.Visible = false;
            }
        }

        private void txtValorLocacao_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNcontrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtAnoVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
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

        private void cadastrarVeiculo_Load(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                foreach (TipoVeiculo item in context.TipoVeiculo)
                {
                    txtTipo.Items.Add(item.nomeTipo);
                }
            }
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fimVigenciaTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void inicioVigenciaTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtAnoVeiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtObservacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtValorLocacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtNcontrato_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
