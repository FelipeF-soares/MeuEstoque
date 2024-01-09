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
    public partial class UserControlAdicionar : UserControl
    {
        private Material _materialAdicionar;
        public UserControlAdicionar()
        {
            InitializeComponent();
            buttonAdicionar.Enabled = false;
            buttonRegistrar.Enabled = false;

            textBoxNome.TextChanged += TextBox_TextCharged;
            textBoxDescricao.TextChanged += TextBox_TextCharged;
            maskedTextBoxQuantidadeNovo.TextChanged += TextBox_TextCharged;
        }

        private void TextBox_TextCharged(object sender, EventArgs e)
        {
            buttonRegistrar.Enabled = !string.IsNullOrEmpty(textBoxNome.Text) &&
                                      !string.IsNullOrEmpty(textBoxDescricao.Text) &&
                                      !string.IsNullOrEmpty(maskedTextBoxQuantidadeNovo.Text);
        }

        private void LimparCampos()
        {
            textBoxNome.Text = string.Empty;
            textBoxDescricao.Text = string.Empty;
            maskedTextBoxQuantidadeNovo.Text = string.Empty;
            maskedTextBoxQuantidadeExistente.Text = string.Empty;
            textBoxId.Text = string.Empty;
            labelQntExistente.Text = string.Empty;
            labelNomeExistente.Text = string.Empty;

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            material.Nome = textBoxNome.Text.ToUpper().Trim();
            material.Descricao = textBoxDescricao.Text.ToUpper().Trim();
            material.Quantidade = Int32.Parse(maskedTextBoxQuantidadeNovo.Text);

            try
            {
                QueryDB queryDB = new QueryDB("Materiais");
                queryDB.Incluir(material);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LimparCampos();
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            try
            {
                QueryDB queryDB = new QueryDB("Materiais");
                _materialAdicionar = queryDB.PesquisarPorId(id);
                labelNomeExistente.Text = _materialAdicionar.Nome;
                labelQntExistente.Text = _materialAdicionar.Quantidade.ToString();
                if (!_materialAdicionar.Equals(null))
                {
                    buttonAdicionar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                ControleEstoque controleEstoque = new ControleEstoque();
                int quantidade = Int32.Parse(maskedTextBoxQuantidadeExistente.Text);
                controleEstoque.AtualizarQuantidadeDeItem(_materialAdicionar, quantidade);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LimparCampos();
            }
        }

    }
}
