namespace MeuEstoque.Views
{
    partial class UserControlAdicionar
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
            labelMansagem = new Label();
            labelNome = new Label();
            labelDescricao = new Label();
            labelQuantidade = new Label();
            textBoxNome = new TextBox();
            textBoxDescricao = new TextBox();
            buttonRegistrar = new Button();
            groupBoxItemNovo = new GroupBox();
            maskedTextBoxQuantidadeNovo = new MaskedTextBox();
            groupBoxPesquisar = new GroupBox();
            labelQntExistente = new Label();
            labelQntExiste = new Label();
            labelNomeExistente = new Label();
            buttonAdicionar = new Button();
            labelNomeMaterialExistente = new Label();
            maskedTextBoxQuantidadeExistente = new MaskedTextBox();
            labelQuantidadeExistente = new Label();
            buttonPesquisar = new Button();
            textBoxId = new TextBox();
            labelIdPesquisa = new Label();
            groupBoxItemNovo.SuspendLayout();
            groupBoxPesquisar.SuspendLayout();
            SuspendLayout();
            // 
            // labelMansagem
            // 
            labelMansagem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMansagem.AutoSize = true;
            labelMansagem.Location = new Point(241, 27);
            labelMansagem.Name = "labelMansagem";
            labelMansagem.Size = new Size(146, 15);
            labelMansagem.TabIndex = 0;
            labelMansagem.Text = "Adicionar Item ao Estoque";
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.None;
            labelNome.AutoSize = true;
            labelNome.Location = new Point(13, 48);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(46, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome: ";
            // 
            // labelDescricao
            // 
            labelDescricao.Anchor = AnchorStyles.None;
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(13, 86);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(64, 15);
            labelDescricao.TabIndex = 2;
            labelDescricao.Text = "Descrição: ";
            // 
            // labelQuantidade
            // 
            labelQuantidade.Anchor = AnchorStyles.None;
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(13, 121);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(75, 15);
            labelQuantidade.TabIndex = 3;
            labelQuantidade.Text = "Quantidade: ";
            // 
            // textBoxNome
            // 
            textBoxNome.Anchor = AnchorStyles.None;
            textBoxNome.Location = new Point(83, 40);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(220, 23);
            textBoxNome.TabIndex = 4;
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Anchor = AnchorStyles.None;
            textBoxDescricao.Location = new Point(83, 78);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(220, 23);
            textBoxDescricao.TabIndex = 5;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Anchor = AnchorStyles.None;
            buttonRegistrar.Location = new Point(137, 157);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(75, 23);
            buttonRegistrar.TabIndex = 7;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // groupBoxItemNovo
            // 
            groupBoxItemNovo.Anchor = AnchorStyles.None;
            groupBoxItemNovo.Controls.Add(maskedTextBoxQuantidadeNovo);
            groupBoxItemNovo.Controls.Add(textBoxNome);
            groupBoxItemNovo.Controls.Add(buttonRegistrar);
            groupBoxItemNovo.Controls.Add(labelNome);
            groupBoxItemNovo.Controls.Add(labelDescricao);
            groupBoxItemNovo.Controls.Add(textBoxDescricao);
            groupBoxItemNovo.Controls.Add(labelQuantidade);
            groupBoxItemNovo.Location = new Point(142, 263);
            groupBoxItemNovo.Name = "groupBoxItemNovo";
            groupBoxItemNovo.Size = new Size(349, 189);
            groupBoxItemNovo.TabIndex = 8;
            groupBoxItemNovo.TabStop = false;
            groupBoxItemNovo.Text = "Novo Item";
            // 
            // maskedTextBoxQuantidadeNovo
            // 
            maskedTextBoxQuantidadeNovo.Location = new Point(94, 118);
            maskedTextBoxQuantidadeNovo.Mask = "999999";
            maskedTextBoxQuantidadeNovo.Name = "maskedTextBoxQuantidadeNovo";
            maskedTextBoxQuantidadeNovo.Size = new Size(41, 23);
            maskedTextBoxQuantidadeNovo.TabIndex = 9;
            maskedTextBoxQuantidadeNovo.ValidatingType = typeof(int);
            // 
            // groupBoxPesquisar
            // 
            groupBoxPesquisar.Anchor = AnchorStyles.None;
            groupBoxPesquisar.Controls.Add(labelQntExistente);
            groupBoxPesquisar.Controls.Add(labelQntExiste);
            groupBoxPesquisar.Controls.Add(labelNomeExistente);
            groupBoxPesquisar.Controls.Add(buttonAdicionar);
            groupBoxPesquisar.Controls.Add(labelNomeMaterialExistente);
            groupBoxPesquisar.Controls.Add(maskedTextBoxQuantidadeExistente);
            groupBoxPesquisar.Controls.Add(labelQuantidadeExistente);
            groupBoxPesquisar.Controls.Add(buttonPesquisar);
            groupBoxPesquisar.Controls.Add(textBoxId);
            groupBoxPesquisar.Controls.Add(labelIdPesquisa);
            groupBoxPesquisar.Location = new Point(109, 57);
            groupBoxPesquisar.Name = "groupBoxPesquisar";
            groupBoxPesquisar.Size = new Size(423, 190);
            groupBoxPesquisar.TabIndex = 9;
            groupBoxPesquisar.TabStop = false;
            groupBoxPesquisar.Text = "Digite o Id do material";
            // 
            // labelQntExistente
            // 
            labelQntExistente.Anchor = AnchorStyles.None;
            labelQntExistente.AutoSize = true;
            labelQntExistente.Location = new Point(296, 81);
            labelQntExistente.Name = "labelQntExistente";
            labelQntExistente.Size = new Size(0, 15);
            labelQntExistente.TabIndex = 13;
            // 
            // labelQntExiste
            // 
            labelQntExiste.Anchor = AnchorStyles.None;
            labelQntExiste.AutoSize = true;
            labelQntExiste.Location = new Point(190, 81);
            labelQntExiste.Name = "labelQntExiste";
            labelQntExiste.Size = new Size(75, 15);
            labelQntExiste.TabIndex = 12;
            labelQntExiste.Text = "Quantidade: ";
            // 
            // labelNomeExistente
            // 
            labelNomeExistente.AutoSize = true;
            labelNomeExistente.Location = new Point(92, 81);
            labelNomeExistente.Name = "labelNomeExistente";
            labelNomeExistente.Size = new Size(0, 15);
            labelNomeExistente.TabIndex = 11;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(156, 150);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(75, 23);
            buttonAdicionar.TabIndex = 10;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // labelNomeMaterialExistente
            // 
            labelNomeMaterialExistente.AutoSize = true;
            labelNomeMaterialExistente.Location = new Point(28, 81);
            labelNomeMaterialExistente.Name = "labelNomeMaterialExistente";
            labelNomeMaterialExistente.Size = new Size(43, 15);
            labelNomeMaterialExistente.TabIndex = 9;
            labelNomeMaterialExistente.Text = "Nome:";
            // 
            // maskedTextBoxQuantidadeExistente
            // 
            maskedTextBoxQuantidadeExistente.Location = new Point(163, 116);
            maskedTextBoxQuantidadeExistente.Mask = "999999";
            maskedTextBoxQuantidadeExistente.Name = "maskedTextBoxQuantidadeExistente";
            maskedTextBoxQuantidadeExistente.Size = new Size(41, 23);
            maskedTextBoxQuantidadeExistente.TabIndex = 8;
            maskedTextBoxQuantidadeExistente.ValidatingType = typeof(int);
            // 
            // labelQuantidadeExistente
            // 
            labelQuantidadeExistente.Anchor = AnchorStyles.None;
            labelQuantidadeExistente.AutoSize = true;
            labelQuantidadeExistente.Location = new Point(28, 119);
            labelQuantidadeExistente.Name = "labelQuantidadeExistente";
            labelQuantidadeExistente.Size = new Size(129, 15);
            labelQuantidadeExistente.TabIndex = 7;
            labelQuantidadeExistente.Text = "Adicionar Quantidade: ";
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(296, 40);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(75, 23);
            buttonPesquisar.TabIndex = 2;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(77, 40);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(188, 23);
            textBoxId.TabIndex = 1;
            // 
            // labelIdPesquisa
            // 
            labelIdPesquisa.AutoSize = true;
            labelIdPesquisa.Location = new Point(28, 43);
            labelIdPesquisa.Name = "labelIdPesquisa";
            labelIdPesquisa.Size = new Size(20, 15);
            labelIdPesquisa.TabIndex = 0;
            labelIdPesquisa.Text = "Id:";
            // 
            // UserControlAdicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxPesquisar);
            Controls.Add(groupBoxItemNovo);
            Controls.Add(labelMansagem);
            Name = "UserControlAdicionar";
            Size = new Size(624, 455);
            groupBoxItemNovo.ResumeLayout(false);
            groupBoxItemNovo.PerformLayout();
            groupBoxPesquisar.ResumeLayout(false);
            groupBoxPesquisar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMansagem;
        private Label labelNome;
        private Label labelDescricao;
        private Label labelQuantidade;
        private TextBox textBoxNome;
        private TextBox textBoxDescricao;
        private Button buttonRegistrar;
        private GroupBox groupBoxItemNovo;
        private GroupBox groupBoxPesquisar;
        private Button buttonPesquisar;
        private TextBox textBoxId;
        private Label labelIdPesquisa;
        private MaskedTextBox maskedTextBoxQuantidadeExistente;
        private Label labelQuantidadeExistente;
        private MaskedTextBox maskedTextBoxQuantidadeNovo;
        private Button buttonAdicionar;
        private Label labelNomeMaterialExistente;
        private Label labelNomeExistente;
        private Label labelQntExistente;
        private Label labelQntExiste;
    }
}
