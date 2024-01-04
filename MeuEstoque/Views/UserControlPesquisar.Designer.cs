namespace MeuEstoque.Views
{
    partial class UserControlPesquisar
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
            groupBoxPesquisar = new GroupBox();
            buttonPesquisar = new Button();
            textBoxId = new TextBox();
            labelIdPesquisa = new Label();
            labelBuscar = new Label();
            dataGridViewMateriais = new DataGridView();
            groupBoxPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMateriais).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPesquisar
            // 
            groupBoxPesquisar.Anchor = AnchorStyles.None;
            groupBoxPesquisar.Controls.Add(buttonPesquisar);
            groupBoxPesquisar.Controls.Add(textBoxId);
            groupBoxPesquisar.Controls.Add(labelIdPesquisa);
            groupBoxPesquisar.Location = new Point(26, 70);
            groupBoxPesquisar.Name = "groupBoxPesquisar";
            groupBoxPesquisar.Size = new Size(423, 101);
            groupBoxPesquisar.TabIndex = 0;
            groupBoxPesquisar.TabStop = false;
            groupBoxPesquisar.Text = "Digite o Id do material";
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
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Location = new Point(149, 33);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(119, 15);
            labelBuscar.TabIndex = 1;
            labelBuscar.Text = "Buscar de Item por Id";
            // 
            // dataGridViewMateriais
            // 
            dataGridViewMateriais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMateriais.Dock = DockStyle.Bottom;
            dataGridViewMateriais.Location = new Point(0, 242);
            dataGridViewMateriais.Name = "dataGridViewMateriais";
            dataGridViewMateriais.RowTemplate.Height = 25;
            dataGridViewMateriais.Size = new Size(489, 150);
            dataGridViewMateriais.TabIndex = 2;
            // 
            // UserControlPesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewMateriais);
            Controls.Add(labelBuscar);
            Controls.Add(groupBoxPesquisar);
            Name = "UserControlPesquisar";
            Size = new Size(489, 392);
            Load += UserControlPesquisar_Load;
            groupBoxPesquisar.ResumeLayout(false);
            groupBoxPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMateriais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxPesquisar;
        private TextBox textBoxId;
        private Label labelIdPesquisa;
        private Label labelBuscar;
        private Button buttonPesquisar;
        private DataGridView dataGridViewMateriais;
    }
}
