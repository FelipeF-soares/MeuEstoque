namespace MeuEstoque
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            buttonRelatorioConsumo = new Button();
            buttonGerarRecibo = new Button();
            buttonBuscar = new Button();
            buttonAdicionar = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            tabControl = new TabControl();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(buttonRelatorioConsumo);
            panelMenu.Controls.Add(buttonGerarRecibo);
            panelMenu.Controls.Add(buttonBuscar);
            panelMenu.Controls.Add(buttonAdicionar);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(204, 495);
            panelMenu.TabIndex = 0;
            // 
            // buttonRelatorioConsumo
            // 
            buttonRelatorioConsumo.Location = new Point(26, 330);
            buttonRelatorioConsumo.Name = "buttonRelatorioConsumo";
            buttonRelatorioConsumo.Size = new Size(153, 58);
            buttonRelatorioConsumo.TabIndex = 4;
            buttonRelatorioConsumo.Text = "Gerar Relatorio De Consumo";
            buttonRelatorioConsumo.UseVisualStyleBackColor = true;
            buttonRelatorioConsumo.Click += buttonRelatorioConsumo_Click;
            // 
            // buttonGerarRecibo
            // 
            buttonGerarRecibo.Location = new Point(26, 266);
            buttonGerarRecibo.Name = "buttonGerarRecibo";
            buttonGerarRecibo.Size = new Size(153, 58);
            buttonGerarRecibo.TabIndex = 3;
            buttonGerarRecibo.Text = "Gerar Recibo";
            buttonGerarRecibo.UseVisualStyleBackColor = true;
            buttonGerarRecibo.Click += buttonGerarRecibo_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(26, 202);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(153, 58);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Buscar Item";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(26, 138);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(153, 58);
            buttonAdicionar.TabIndex = 1;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.ControlDark;
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(204, 105);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl
            // 
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(204, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(620, 495);
            tabControl.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 495);
            Controls.Add(tabControl);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle De Estoque";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button buttonAdicionar;
        private Panel panelLogo;
        private TabControl tabControl;
        private Button buttonBuscar;
        private Button buttonGerarRecibo;
        private Button buttonRelatorioConsumo;
        private PictureBox pictureBox1;
    }
}