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
    public partial class cadastrarMotorista : Form
    {
        public cadastrarMotorista()
        {
            InitializeComponent();
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

        private void cadastrarMotorista_Load(object sender, EventArgs e)
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

        private void txtValidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private bool TemCadastrado(Motorista motorista)
        {
            using (ConnectionString context = new ConnectionString())
            {
                foreach (Motorista item in context.Motorista)
                {
                    if (item.cpf.Equals(motorista.cpf))
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
                    Motorista motorista = new Motorista();

                    motorista.validadeCarteira = DateTime.Parse(txtValidade.Text);
                    motorista.carteiraPossuida = carteiraDropDown.Text;
                    motorista.cpf = txtCpf.Text;
                    motorista.nome = txtNomeMotorista.Text;

                    if (TemCadastrado(motorista))
                    {
                        MessageBoxButtons button = MessageBoxButtons.OK;
                        MessageBox.Show("Já existe um motorista com esse CPF cadastrado", "Error", button, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        context.Motorista.Add(motorista);
                        context.SaveChanges();

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Veiculo Cadastrado com sucesso", "Cadastrado", buttons, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Erro ao Cadastrar motorista, certifiquese de que informou os dados corretamente", "Error", buttons, MessageBoxIcon.Error);
                }
            }
        }
    }
}
