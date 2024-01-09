using MeuEstoque.Views;

namespace MeuEstoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AdicionarTapPages(string name, string text, UserControl userControl)
        {
            TabPage tabPage = new TabPage();
            userControl.Dock = DockStyle.Fill;
            tabPage.Name = name;
            tabPage.Text = text;
            tabPage.Controls.Add(userControl);
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectTab(tabPage);
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();
            string name = "tabPageAdicionarItem";
            string text = "Adicionar Item Ao Estoque";
            UserControlAdicionar userControl = new UserControlAdicionar();
            AdicionarTapPages(name, text, userControl);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();
            string name = "tabPageBuscatItem";
            string text = "Buscar Item";
            UserControlPesquisar userControl = new UserControlPesquisar();
            AdicionarTapPages(name, text, userControl);
        }

        private void buttonGerarRecibo_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();
            string name = "tabPageGeraRecibo";
            string text = "Gerar Recibo";
            UserControlGerarRecibo userControl = new UserControlGerarRecibo();
            AdicionarTapPages(name, text, userControl);
        }

        private void buttonRelatorioConsumo_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();
            string name = "tabPageRelatorioSaida";
            string text = "Relatório De Controle de Saída";
            UserControlRelatorioConsumo userControl = new UserControlRelatorioConsumo();
            AdicionarTapPages(name,text, userControl);
        }
    }
}