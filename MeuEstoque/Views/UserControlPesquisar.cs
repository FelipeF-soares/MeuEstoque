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
    public partial class UserControlPesquisar : UserControl
    {
        public UserControlPesquisar()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            string id = textBoxId.Text;
            try
            {
                QueryDB queryDB = new QueryDB("Materiais");
                material = queryDB.PesquisarPorId(id);
                MessageBox.Show(material.Nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserControlPesquisar_Load(object sender, EventArgs e)
        {
            try
            {
                QueryDB queryDB = new QueryDB("Materiais");
                var table = queryDB.ListaMateriais();
                dataGridViewMateriais.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
