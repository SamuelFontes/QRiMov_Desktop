namespace AmbienteTeste
{
    partial class ParentPesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentPesquisa));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblNome = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnApagar = new System.Windows.Forms.ToolStripButton();
            this.btnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.txtBusca = new System.Windows.Forms.ToolStripTextBox();
            this.dpCampo = new System.Windows.Forms.ToolStripDropDownButton();
            this.lblPesquisar = new System.Windows.Forms.ToolStripLabel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNome,
            this.toolStripSeparator5,
            this.btnAdicionar,
            this.btnEditar,
            this.btnApagar,
            this.btnPesquisar,
            this.txtBusca,
            this.dpCampo,
            this.lblPesquisar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 25, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(800, 48);
            this.toolStrip1.TabIndex = 164;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(113, 23);
            this.lblNome.Text = "Nome do form";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionar.Image = global::AmbienteTeste.Properties.Resources.add__1_;
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionar.Text = "Adicionar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::AmbienteTeste.Properties.Resources.edit__1_;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 23);
            this.btnEditar.Text = "Adicionar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnApagar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnApagar.Image = global::AmbienteTeste.Properties.Resources.trash;
            this.btnApagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(23, 23);
            this.btnApagar.Text = "Adicionar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPesquisar.Image = global::AmbienteTeste.Properties.Resources.magnifying_glass;
            this.btnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(23, 23);
            this.btnPesquisar.Text = "toolStripButton1";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtBusca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(100, 23);
            // 
            // dpCampo
            // 
            this.dpCampo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dpCampo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dpCampo.Image = ((System.Drawing.Image)(resources.GetObject("dpCampo.Image")));
            this.dpCampo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dpCampo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.dpCampo.Name = "dpCampo";
            this.dpCampo.Size = new System.Drawing.Size(160, 19);
            this.dpCampo.Text = "toolStripDropDownButton1";
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblPesquisar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(76, 23);
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 48);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(800, 402);
            this.dataGrid.TabIndex = 165;
            // 
            // ParentPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ParentPesquisa";
            this.Text = "ParentPesquisa";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel lblNome;
        public System.Windows.Forms.ToolStripTextBox txtBusca;
        public System.Windows.Forms.ToolStripButton btnPesquisar;
        public System.Windows.Forms.DataGridView dataGrid;
        public System.Windows.Forms.ToolStripLabel lblPesquisar;
        public System.Windows.Forms.ToolStripButton btnAdicionar;
        public System.Windows.Forms.ToolStripButton btnEditar;
        public System.Windows.Forms.ToolStripButton btnApagar;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripDropDownButton dpCampo;
    }
}