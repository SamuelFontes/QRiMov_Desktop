namespace AmbienteTeste
{
    partial class FluxoCaixa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FluxoCaixa));
            this.view_orgTableAdapter = new AmbienteTeste.viewImobiliariaTableAdapters.view_orgTableAdapter();
            this.vieworgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.viewFinancas = new AmbienteTeste.viewFinancas();
            this.viewFinancasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsFechar = new System.Windows.Forms.ToolStripButton();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtBusca = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.saldobancarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saldo_bancarioTableAdapter = new AmbienteTeste.viewFinancasTableAdapters.saldo_bancarioTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vieworgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFinancas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFinancasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saldobancarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // view_orgTableAdapter
            // 
            this.view_orgTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::AmbienteTeste.Properties.Resources.trash;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::AmbienteTeste.Properties.Resources.edit__1_;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // viewFinancas
            // 
            this.viewFinancas.DataSetName = "viewFinancas";
            this.viewFinancas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewFinancasBindingSource
            // 
            this.viewFinancasBindingSource.DataSource = this.viewFinancas;
            this.viewFinancasBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.parteDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.descriçãoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.saldobancarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 53);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 162;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFechar,
            this.btnAdicionar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtBusca,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.toolStrip1.Size = new System.Drawing.Size(800, 53);
            this.toolStrip1.TabIndex = 163;
            // 
            // tsFechar
            // 
            this.tsFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFechar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsFechar.ForeColor = System.Drawing.Color.White;
            this.tsFechar.Image = ((System.Drawing.Image)(resources.GetObject("tsFechar.Image")));
            this.tsFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFechar.Name = "tsFechar";
            this.tsFechar.Size = new System.Drawing.Size(60, 25);
            this.tsFechar.Text = "Fechar";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionar.Image = global::AmbienteTeste.Properties.Resources.add__1_;
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(23, 25);
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(164)))), ((int)(((byte)(32)))));
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(3, 1, 5, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(70, 25);
            this.toolStripLabel1.Text = "Pesquise";
            // 
            // txtBusca
            // 
            this.txtBusca.Margin = new System.Windows.Forms.Padding(1, 0, 5, 0);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(100, 28);
            this.txtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusca_KeyPress);
            this.txtBusca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyUp);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::AmbienteTeste.Properties.Resources.refresh_arrow;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // saldobancarioBindingSource
            // 
            this.saldobancarioBindingSource.DataMember = "saldo_bancario";
            this.saldobancarioBindingSource.DataSource = this.viewFinancas;
            // 
            // saldo_bancarioTableAdapter
            // 
            this.saldo_bancarioTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parteDataGridViewTextBoxColumn
            // 
            this.parteDataGridViewTextBoxColumn.DataPropertyName = "Parte";
            this.parteDataGridViewTextBoxColumn.HeaderText = "Parte";
            this.parteDataGridViewTextBoxColumn.Name = "parteDataGridViewTextBoxColumn";
            this.parteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriçãoDataGridViewTextBoxColumn
            // 
            this.descriçãoDataGridViewTextBoxColumn.DataPropertyName = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.Name = "descriçãoDataGridViewTextBoxColumn";
            this.descriçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FluxoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FluxoCaixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FluxoCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vieworgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFinancas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFinancasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saldobancarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private viewImobiliariaTableAdapters.view_orgTableAdapter view_orgTableAdapter;
        private System.Windows.Forms.BindingSource vieworgBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.BindingSource viewFinancasBindingSource;
        private viewFinancas viewFinancas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsFechar;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtBusca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource saldobancarioBindingSource;
        private viewFinancasTableAdapters.saldo_bancarioTableAdapter saldo_bancarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
    }
}