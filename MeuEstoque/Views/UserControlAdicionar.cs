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
        public UserControlAdicionar()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            textBoxNome.Text = string.Empty;
            textBoxDescricao.Text = string.Empty;
            textBoxQuantidade.Text = string.Empty;
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            material.Nome = textBoxNome.Text;
            material.Descricao = textBoxDescricao.Text;
            material.Quantidade = Int32.Parse(textBoxQuantidade.Text);

            try
            {
                QueryDB queryDB = new QueryDB("Materiais");
                queryDB.Incluir(material);
            }
            catch(Exception ex)
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
