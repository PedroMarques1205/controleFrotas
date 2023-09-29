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
    public partial class editarTipoVeiculo : Form
    {
        public editarTipoVeiculo(TipoVeiculo tipoVeiculo)
        {
            InitializeComponent();
            txtNomeTipo.Text = tipoVeiculo.nomeTipo;
            txtNpassageiros.Text = Convert.ToString(tipoVeiculo.capacidadePassageiros);
            txtNumRodas.Text = Convert.ToString(tipoVeiculo.numRodas);
            carteiraDropDown.Text = tipoVeiculo.carteiraNecessaria;
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

        private void btnCadastraVeiculo_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    TipoVeiculo Tipoveiculo = context.TipoVeiculo
                        .FirstOrDefault(
                            x =>
                                x.nomeTipo == txtNomeTipo.Text
                        );

                    Tipoveiculo.nomeTipo = txtNomeTipo.Text;
                    Tipoveiculo.carteiraNecessaria = carteiraDropDown.Text;
                    Tipoveiculo.numRodas = Convert.ToInt32(txtNumRodas.Text);
                    Tipoveiculo.capacidadePassageiros = Convert.ToInt32(txtNpassageiros.Text);

                    context.Entry<TipoVeiculo>(Tipoveiculo).State = EntityState.Modified;
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

        private void editarTipoVeiculo_Load(object sender, EventArgs e)
        {
            carteiraDropDown.Items.Add("A");
            carteiraDropDown.Items.Add("B");
            carteiraDropDown.Items.Add("C");
            carteiraDropDown.Items.Add("D");
            carteiraDropDown.Items.Add("E");
        }

        private void carteiraDropDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNumRodas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNpassageiros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
