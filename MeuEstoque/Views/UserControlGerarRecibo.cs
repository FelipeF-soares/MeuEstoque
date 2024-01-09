using MeuEstoque.DataBase;
using MeuEstoque.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuEstoque.Views
{
    public partial class UserControlGerarRecibo : UserControl
    {
        Material materialPago = new Material();
        public UserControlGerarRecibo()
        {
            InitializeComponent();
            buttonGerarRecibo.Enabled = false;
            maskedTextBoxQuantidade.TextChanged += TextBox_TextChanged;
            textBoxId.TextChanged += TextBox_TextChanged;
            textBoxNomePagador.TextChanged += TextBox_TextChanged;
            textBoxRecebeMaterial.TextChanged += TextBox_TextChanged;
            textBoxSecao.TextChanged += TextBox_TextChanged;
        }

        private void buttonGerarRecibo_Click(object sender, EventArgs e)
        {

            string nomePagador = textBoxNomePagador.Text.ToUpper().Trim();
            string nomeRecebedor = textBoxRecebeMaterial.Text.ToUpper().Trim();
            string secaoOrigem = "Telemática";
            string secaoDestino = textBoxSecao.Text.ToUpper().Trim();
            int quantidadeRetirada = Int32.Parse(maskedTextBoxQuantidade.Text);

            ControleEstoque controleEstoque = new ControleEstoque();
            try
            {
                bool sucesso = controleEstoque.ValidaERegistrar(nomePagador, nomeRecebedor, secaoOrigem, secaoDestino, materialPago, quantidadeRetirada);
                if (sucesso)
                {

                    MessageBox.Show("Saída De Material Registrada Com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao Registrar a Saída do material");
                }
                LimparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            try
            {
                QueryDB queryDB = new QueryDB("Materiais");
                materialPago = queryDB.PesquisarPorId(id);
                labelRecebeId.Text = materialPago.Id.ToString();
                labelRecebeNome.Text = materialPago.Nome;
                labelRecebeDescricao.Text = materialPago.Descricao;
                labelRecebeQuantidade.Text = materialPago.Quantidade.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimparFormulario()
        {
            labelRecebeId.Text = string.Empty;
            labelRecebeNome.Text = string.Empty;
            labelRecebeDescricao.Text = string.Empty;
            labelRecebeQuantidade.Text = string.Empty;
            textBoxId.Text = string.Empty;
            textBoxNomePagador.Text = string.Empty;
            textBoxRecebeMaterial.Text = string.Empty;
            textBoxSecao.Text = string.Empty;
            maskedTextBoxQuantidade.Text = string.Empty;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            buttonGerarRecibo.Enabled = !string.IsNullOrEmpty(textBoxId.Text) &&
                                        !string.IsNullOrEmpty(maskedTextBoxQuantidade.Text) &&
                                        !string.IsNullOrEmpty(textBoxNomePagador.Text) &&
                                        !string.IsNullOrEmpty(textBoxSecao.Text) &&
                                        !string.IsNullOrEmpty(textBoxRecebeMaterial.Text);
        }


    }
}
