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
    public partial class editarMotorista : Form
    {
        public editarMotorista(Motorista motorista)
        {
            InitializeComponent();
            txtCpf.Text = motorista.cpf;
            txtNomeMotorista.Text = motorista.nome;
            txtValidade.Text = motorista.validadeCarteira.ToString();
            carteiraDropDown.Text = motorista.carteiraPossuida;
        }

        private void editarMotorista_Load(object sender, EventArgs e)
        {

        }

        private void txtValidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void carteiraDropDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCadastraVeiculo_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    Motorista motorista = context.Motorista
                        .FirstOrDefault(
                            x =>
                                x.cpf == txtCpf.Text
                        );

                    motorista.nome = txtNomeMotorista.Text;
                    motorista.cpf = txtCpf.Text;
                    motorista.validadeCarteira = DateTime.Parse(txtValidade.Text);
                    motorista.carteiraPossuida = carteiraDropDown.Text;

                    context.Entry<Motorista>(motorista).State = EntityState.Modified;
                    context.SaveChanges();

                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Motorista Editado com sucesso", "Cadastrado", buttons, MessageBoxIcon.Information);
                    this.Close();
                }
                catch
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Erro ao editar o Motorista, certifiquese de que informou os dados corretamente", "Error", buttons, MessageBoxIcon.Error);
                    this.Close();
                }

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
