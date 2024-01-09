using MeuEstoque.DataBase;
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
    public partial class UserControlRelatorioConsumo : UserControl
    {
        public UserControlRelatorioConsumo()
        {
            InitializeComponent();
        }

        private void UserControlRelatorioConsumo_Load(object sender, EventArgs e)
        {
            try
            {
                QueryDB queryDB = new QueryDB("Controle_Estoque");
                var table = queryDB.RelatorioDeSaídaDeMateriai();
                dataGridViewRelatorio.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
