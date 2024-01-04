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
            textBoxQuantidade = new TextBox();
            buttonRegistrar = new Button();
            SuspendLayout();
            // 
            // labelMansagem
            // 
            labelMansagem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMansagem.AutoSize = true;
            labelMansagem.Location = new Point(213, 31);
            labelMansagem.Name = "labelMansagem";
            labelMansagem.Size = new Size(146, 15);
            labelMansagem.TabIndex = 0;
            labelMansagem.Text = "Adicionar Item ao Estoque";
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.None;
            labelNome.AutoSize = true;
            labelNome.Location = new Point(112, 115);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(46, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome: ";
            // 
            // labelDescricao
            // 
            labelDescricao.Anchor = AnchorStyles.None;
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(112, 164);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(64, 15);
            labelDescricao.TabIndex = 2;
            labelDescricao.Text = "Descrição: ";
            // 
            // labelQuantidade
            // 
            labelQuantidade.Anchor = AnchorStyles.None;
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(177, 210);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(75, 15);
            labelQuantidade.TabIndex = 3;
            labelQuantidade.Text = "Quantidade: ";
            // 
            // textBoxNome
            // 
            textBoxNome.Anchor = AnchorStyles.None;
            textBoxNome.Location = new Point(182, 107);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(220, 23);
            textBoxNome.TabIndex = 4;
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Anchor = AnchorStyles.None;
            textBoxDescricao.Location = new Point(182, 156);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(220, 23);
            textBoxDescricao.TabIndex = 5;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Anchor = AnchorStyles.None;
            textBoxQuantidade.Location = new Point(258, 207);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(144, 23);
            textBoxQuantidade.TabIndex = 6;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Anchor = AnchorStyles.None;
            buttonRegistrar.Location = new Point(231, 253);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(75, 23);
            buttonRegistrar.TabIndex = 7;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // UserControlAdicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonRegistrar);
            Controls.Add(textBoxQuantidade);
            Controls.Add(textBoxDescricao);
            Controls.Add(textBoxNome);
            Controls.Add(labelQuantidade);
            Controls.Add(labelDescricao);
            Controls.Add(labelNome);
            Controls.Add(labelMansagem);
            Name = "UserControlAdicionar";
            Size = new Size(556, 366);
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
        private TextBox textBoxQuantidade;
        private Button buttonRegistrar;
    }
}
