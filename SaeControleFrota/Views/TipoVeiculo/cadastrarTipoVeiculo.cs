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
    public partial class cadastrarTipoVeiculo : Form
    {
        public cadastrarTipoVeiculo()
        {
            InitializeComponent();
        }

        private void cadastrarTipoVeiculo_Load(object sender, EventArgs e)
        {
            carteiraDropDown.Items.Add("A");
            carteiraDropDown.Items.Add("B");
            carteiraDropDown.Items.Add("C");
            carteiraDropDown.Items.Add("D");
            carteiraDropDown.Items.Add("E");
        }

        private void btnCadastraVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConnectionString context = new ConnectionString())
                {
                    TipoVeiculo tipoVeiculo = new TipoVeiculo();

                    tipoVeiculo.nomeTipo = txtNomeTipo.Text;
                    tipoVeiculo.carteiraNecessaria = carteiraDropDown.Text;
                    tipoVeiculo.capacidadePassageiros = Convert.ToInt32(txtNpassageiros.Text);
                    tipoVeiculo.numRodas = Convert.ToInt32(txtNumRodas.Text);

                    if (TemCadastrado(tipoVeiculo))
                    {
                        MessageBoxButtons button = MessageBoxButtons.OK;
                        MessageBox.Show("Já existe um tipo de veículo com essa nome cadastrado", "Error", button, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        context.TipoVeiculo.Add(tipoVeiculo);
                        context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Tipo Cadastrado com sucesso", "Cadastrado", buttons, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Erro ao Cadastrar veiculo, certifiquese de que informou os dados corretamente", "Error", buttons, MessageBoxIcon.Error);
            }
        }

        private bool TemCadastrado(TipoVeiculo tipoVeiculo)
        {
            using (ConnectionString context = new ConnectionString())
            {
                foreach (TipoVeiculo item in context.TipoVeiculo)
                {
                    if (item.nomeTipo.Equals(tipoVeiculo.nomeTipo))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private void carteiraDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void carteiraDropDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNpassageiros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNumRodas_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
