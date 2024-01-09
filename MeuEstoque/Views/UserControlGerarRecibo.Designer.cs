namespace MeuEstoque.Views
{
    partial class UserControlGerarRecibo
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            labelGerarRecibo = new Label();
            groupBoxPesquisar = new GroupBox();
            maskedTextBoxQuantidade = new MaskedTextBox();
            labelQunatidadeFornecida = new Label();
            buttonPesquisar = new Button();
            textBoxId = new TextBox();
            labelIdPesquisa = new Label();
            labelNome = new Label();
            labelDescricao = new Label();
            labelQuantidade = new Label();
            labelRecebeNome = new Label();
            labelRecebeDescricao = new Label();
            groupBoxInformacoes = new GroupBox();
            textBoxNomePagador = new TextBox();
            labelNomeResponsavel = new Label();
            groupBox1 = new GroupBox();
            textBoxRecebeMaterial = new TextBox();
            textBoxSecao = new TextBox();
            labelSecao = new Label();
            labelNomeRetirada = new Label();
            labelRecebeQuantidade = new Label();
            buttonGerarRecibo = new Button();
            labelRecebeId = new Label();
            groupBoxPesquisar.SuspendLayout();
            groupBoxInformacoes.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelGerarRecibo
            // 
            labelGerarRecibo.AutoSize = true;
            labelGerarRecibo.Location = new Point(152, 20);
            labelGerarRecibo.Name = "labelGerarRecibo";
            labelGerarRecibo.Size = new Size(280, 15);
            labelGerarRecibo.TabIndex = 0;
            labelGerarRecibo.Text = "Digite as informações necessaria para gerar o recibo";
            // 
            // groupBoxPesquisar
            // 
            groupBoxPesquisar.Anchor = AnchorStyles.None;
            groupBoxPesquisar.Controls.Add(maskedTextBoxQuantidade);
            groupBoxPesquisar.Controls.Add(labelQunatidadeFornecida);
            groupBoxPesquisar.Controls.Add(buttonPesquisar);
            groupBoxPesquisar.Controls.Add(textBoxId);
            groupBoxPesquisar.Controls.Add(labelIdPesquisa);
            groupBoxPesquisar.Location = new Point(85, 67);
            groupBoxPesquisar.Name = "groupBoxPesquisar";
            groupBoxPesquisar.Size = new Size(423, 101);
            groupBoxPesquisar.TabIndex = 1;
            groupBoxPesquisar.TabStop = false;
            groupBoxPesquisar.Text = "Digite o Id do material e quantidade que será fornecida";
            // 
            // maskedTextBoxQuantidade
            // 
            maskedTextBoxQuantidade.Location = new Point(189, 55);
            maskedTextBoxQuantidade.Mask = "999999";
            maskedTextBoxQuantidade.Name = "maskedTextBoxQuantidade";
            maskedTextBoxQuantidade.Size = new Size(41, 23);
            maskedTextBoxQuantidade.TabIndex = 10;
            maskedTextBoxQuantidade.ValidatingType = typeof(int);
            // 
            // labelQunatidadeFornecida
            // 
            labelQunatidadeFornecida.AutoSize = true;
            labelQunatidadeFornecida.Location = new Point(28, 58);
            labelQunatidadeFornecida.Name = "labelQunatidadeFornecida";
            labelQunatidadeFornecida.Size = new Size(155, 15);
            labelQunatidadeFornecida.TabIndex = 3;
            labelQunatidadeFornecida.Text = "Quantidade a ser fornecida: ";
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(296, 22);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(75, 23);
            buttonPesquisar.TabIndex = 2;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(77, 22);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(188, 23);
            textBoxId.TabIndex = 1;
            // 
            // labelIdPesquisa
            // 
            labelIdPesquisa.AutoSize = true;
            labelIdPesquisa.Location = new Point(28, 25);
            labelIdPesquisa.Name = "labelIdPesquisa";
            labelIdPesquisa.Size = new Size(20, 15);
            labelIdPesquisa.TabIndex = 0;
            labelIdPesquisa.Text = "Id:";
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.None;
            labelNome.AutoSize = true;
            labelNome.Location = new Point(85, 185);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(43, 15);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome:";
            // 
            // labelDescricao
            // 
            labelDescricao.Anchor = AnchorStyles.None;
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(85, 211);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(61, 15);
            labelDescricao.TabIndex = 4;
            labelDescricao.Text = "Descrição:";
            // 
            // labelQuantidade
            // 
            labelQuantidade.Anchor = AnchorStyles.None;
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(85, 238);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(75, 15);
            labelQuantidade.TabIndex = 5;
            labelQuantidade.Text = "Quantidade: ";
            // 
            // labelRecebeNome
            // 
            labelRecebeNome.Anchor = AnchorStyles.None;
            labelRecebeNome.AutoSize = true;
            labelRecebeNome.Location = new Point(134, 185);
            labelRecebeNome.Name = "labelRecebeNome";
            labelRecebeNome.Size = new Size(0, 15);
            labelRecebeNome.TabIndex = 6;
            // 
            // labelRecebeDescricao
            // 
            labelRecebeDescricao.Anchor = AnchorStyles.None;
            labelRecebeDescricao.AutoSize = true;
            labelRecebeDescricao.Location = new Point(152, 211);
            labelRecebeDescricao.Name = "labelRecebeDescricao";
            labelRecebeDescricao.Size = new Size(0, 15);
            labelRecebeDescricao.TabIndex = 7;
            // 
            // groupBoxInformacoes
            // 
            groupBoxInformacoes.Anchor = AnchorStyles.None;
            groupBoxInformacoes.Controls.Add(textBoxNomePagador);
            groupBoxInformacoes.Controls.Add(labelNomeResponsavel);
            groupBoxInformacoes.Location = new Point(85, 350);
            groupBoxInformacoes.Name = "groupBoxInformacoes";
            groupBoxInformacoes.Size = new Size(423, 59);
            groupBoxInformacoes.TabIndex = 3;
            groupBoxInformacoes.TabStop = false;
            groupBoxInformacoes.Text = "Responsável da Seção";
            // 
            // textBoxNomePagador
            // 
            textBoxNomePagador.Location = new Point(77, 22);
            textBoxNomePagador.Name = "textBoxNomePagador";
            textBoxNomePagador.Size = new Size(188, 23);
            textBoxNomePagador.TabIndex = 1;
            // 
            // labelNomeResponsavel
            // 
            labelNomeResponsavel.AutoSize = true;
            labelNomeResponsavel.Location = new Point(28, 25);
            labelNomeResponsavel.Name = "labelNomeResponsavel";
            labelNomeResponsavel.Size = new Size(43, 15);
            labelNomeResponsavel.TabIndex = 0;
            labelNomeResponsavel.Text = "Nome:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(textBoxRecebeMaterial);
            groupBox1.Controls.Add(textBoxSecao);
            groupBox1.Controls.Add(labelSecao);
            groupBox1.Controls.Add(labelNomeRetirada);
            groupBox1.Location = new Point(85, 265);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 79);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Responsável por retirar o material e seção";
            // 
            // textBoxRecebeMaterial
            // 
            textBoxRecebeMaterial.Location = new Point(77, 22);
            textBoxRecebeMaterial.Name = "textBoxRecebeMaterial";
            textBoxRecebeMaterial.Size = new Size(186, 23);
            textBoxRecebeMaterial.TabIndex = 4;
            // 
            // textBoxSecao
            // 
            textBoxSecao.Location = new Point(77, 51);
            textBoxSecao.Name = "textBoxSecao";
            textBoxSecao.Size = new Size(186, 23);
            textBoxSecao.TabIndex = 3;
            // 
            // labelSecao
            // 
            labelSecao.AutoSize = true;
            labelSecao.Location = new Point(28, 54);
            labelSecao.Name = "labelSecao";
            labelSecao.Size = new Size(41, 15);
            labelSecao.TabIndex = 2;
            labelSecao.Text = "Seção:";
            // 
            // labelNomeRetirada
            // 
            labelNomeRetirada.AutoSize = true;
            labelNomeRetirada.Location = new Point(28, 25);
            labelNomeRetirada.Name = "labelNomeRetirada";
            labelNomeRetirada.Size = new Size(43, 15);
            labelNomeRetirada.TabIndex = 0;
            labelNomeRetirada.Text = "Nome:";
            // 
            // labelRecebeQuantidade
            // 
            labelRecebeQuantidade.Anchor = AnchorStyles.None;
            labelRecebeQuantidade.AutoSize = true;
            labelRecebeQuantidade.Location = new Point(162, 238);
            labelRecebeQuantidade.Name = "labelRecebeQuantidade";
            labelRecebeQuantidade.Size = new Size(0, 15);
            labelRecebeQuantidade.TabIndex = 9;
            // 
            // buttonGerarRecibo
            // 
            buttonGerarRecibo.Location = new Point(253, 438);
            buttonGerarRecibo.Name = "buttonGerarRecibo";
            buttonGerarRecibo.Size = new Size(75, 23);
            buttonGerarRecibo.TabIndex = 10;
            buttonGerarRecibo.Text = "Gerar Recibo";
            buttonGerarRecibo.UseVisualStyleBackColor = true;
            buttonGerarRecibo.Click += buttonGerarRecibo_Click;
            // 
            // labelRecebeId
            // 
            labelRecebeId.Anchor = AnchorStyles.None;
            labelRecebeId.AutoSize = true;
            labelRecebeId.Location = new Point(280, 171);
            labelRecebeId.Name = "labelRecebeId";
            labelRecebeId.Size = new Size(0, 15);
            labelRecebeId.TabIndex = 5;
            // 
            // UserControlGerarRecibo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelRecebeId);
            Controls.Add(buttonGerarRecibo);
            Controls.Add(labelRecebeQuantidade);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxInformacoes);
            Controls.Add(labelRecebeDescricao);
            Controls.Add(labelRecebeNome);
            Controls.Add(labelQuantidade);
            Controls.Add(labelDescricao);
            Controls.Add(labelNome);
            Controls.Add(groupBoxPesquisar);
            Controls.Add(labelGerarRecibo);
            Name = "UserControlGerarRecibo";
            Size = new Size(589, 482);
            groupBoxPesquisar.ResumeLayout(false);
            groupBoxPesquisar.PerformLayout();
            groupBoxInformacoes.ResumeLayout(false);
            groupBoxInformacoes.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGerarRecibo;
        private GroupBox groupBoxPesquisar;
        private Button buttonPesquisar;
        private TextBox textBoxId;
        private Label labelIdPesquisa;
        private Label labelNome;
        private Label labelDescricao;
        private Label labelQuantidade;
        private Label labelRecebeNome;
        private Label labelRecebeDescricao;
        private GroupBox groupBoxInformacoes;
        private Button button1;
        private Label labelNomeResponsavel;
        private GroupBox groupBox1;
        private TextBox textBoxNomePagador;
        private Label labelNomeRetirada;
        private Label labelQunatidadeFornecida;
        private TextBox textBoxSecao;
        private Label labelSecao;
        private Label labelRecebeQuantidade;
        private TextBox textBoxRecebeMaterial;
        private Button buttonGerarRecibo;
        private Label labelRecebeId;
        private MaskedTextBox maskedTextBoxQuantidade;
    }
}
