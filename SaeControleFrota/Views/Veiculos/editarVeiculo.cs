using SaeControleFrota.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaeControleFrota
{
    public partial class editarVeiculo : Form
    {
        public editarVeiculo(Veiculo veiculoEditar)
        {
            InitializeComponent();
            txtAnoVeiculo.Text = Convert.ToString(veiculoEditar.ano);
            txtTipo.Text = Convert.ToString(veiculoEditar.familia);
            txtMarca.Text = Convert.ToString(veiculoEditar.marca);
            txtModelo.Text = Convert.ToString(veiculoEditar.modelo);
            txtNcontrato.Text = Convert.ToString(veiculoEditar.numContrato);
            txtNomeTerceiro.Text = Convert.ToString(veiculoEditar.proprietario);
            txtObservacao.Text = Convert.ToString(veiculoEditar.observacao);
            txtPlaca.Text = Convert.ToString(veiculoEditar.placa);
            txtValorLocacao.Text = Convert.ToString(veiculoEditar.valorLocacao);
            inicioVigenciaTextBox.Text = Convert.ToString(veiculoEditar.inicioVigencia);
            fimVigenciaTextBox.Text = Convert.ToString(veiculoEditar.fimVigencia);
            this.StartPosition = FormStartPosition.CenterScreen;
            if (veiculoEditar.isProprietarioSae!=null)
            {
                this.proprietarioSaeCheckBox.Checked = true;
            }
            else 
            {
                this.terceiroCheckBox.Checked = true;
            }
        }

        private void proprietarioSaeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            terceiroCheckBox.Checked = false;
        }

        private void terceiroCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            proprietarioSaeCheckBox.Checked = false;
            lableTerceiro.Visible = true;
            txtNomeTerceiro.Visible = true;
        }

        private void btnCadastraVeiculo_Click_1(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    Veiculo veiculo = context.Veiculo
                        .FirstOrDefault(
                            x => 
                                x.placa == txtPlaca.Text
                        );
                    
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

                    context.Entry<Veiculo>(veiculo).State = EntityState.Modified;
                    context.SaveChanges();
                    
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Veiculo Editado com sucesso", "Cadastrado", buttons, MessageBoxIcon.Information);
                    this.Close();   
                }
                catch
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Erro ao Cadastrar veiculo, certifiquese de que informou os dados corretamente", "Error", buttons, MessageBoxIcon.Error);
                    this.Close();
                }
                
            }
        }

        private void terceiroCheckBox_CheckedChanged_1(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Tem Certeza que deseja cancelar as alterações?", "Alerta", buttons, MessageBoxIcon.Warning);
            if (result==DialogResult.Yes)
            {
                this.Close();
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

        private void txtAnoVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
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

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void editarVeiculo_Load(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                foreach (TipoVeiculo item in context.TipoVeiculo)
                {
                    txtTipo.Items.Add(item.nomeTipo);
                }
            }
        }
    }
}
