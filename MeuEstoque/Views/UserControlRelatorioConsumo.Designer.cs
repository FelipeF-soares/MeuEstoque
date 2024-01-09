namespace MeuEstoque.Views
{
    partial class UserControlRelatorioConsumo
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
            dataGridViewRelatorio = new DataGridView();
            labelNomeSecao = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRelatorio).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRelatorio
            // 
            dataGridViewRelatorio.Anchor = AnchorStyles.None;
            dataGridViewRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRelatorio.Location = new Point(114, 139);
            dataGridViewRelatorio.Name = "dataGridViewRelatorio";
            dataGridViewRelatorio.RowTemplate.Height = 25;
            dataGridViewRelatorio.Size = new Size(490, 185);
            dataGridViewRelatorio.TabIndex = 0;
            // 
            // labelNomeSecao
            // 
            labelNomeSecao.Anchor = AnchorStyles.None;
            labelNomeSecao.AutoSize = true;
            labelNomeSecao.Location = new Point(270, 82);
            labelNomeSecao.Name = "labelNomeSecao";
            labelNomeSecao.Size = new Size(168, 15);
            labelNomeSecao.TabIndex = 1;
            labelNomeSecao.Text = "Relatório de Saída de Materiais";
            // 
            // UserControlRelatorioConsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelNomeSecao);
            Controls.Add(dataGridViewRelatorio);
            Name = "UserControlRelatorioConsumo";
            Size = new Size(730, 477);
            Load += UserControlRelatorioConsumo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRelatorio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRelatorio;
        private Label labelNomeSecao;
    }
}
