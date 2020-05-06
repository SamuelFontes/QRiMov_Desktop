namespace AmbienteTeste
{
    partial class buscaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscaUsuario));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsFechar = new System.Windows.Forms.ToolStripButton();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtBusca = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewusuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.viewUsuarioDataSet = new AmbienteTeste.viewUsuarioDataSet();
            this.view_usuariosTableAdapter = new AmbienteTeste.viewUsuarioDataSetTableAdapters.view_usuariosTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.int_id_usr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strnomeusrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strloginusrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stremailmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strperfilprfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewusuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsuarioDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 30, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(800, 58);
            this.toolStrip1.TabIndex = 160;
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
            this.tsFechar.Click += new System.EventHandler(this.tsFechar_Click);
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
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.int_id_usr,
            this.strnomeusrDataGridViewTextBoxColumn,
            this.strloginusrDataGridViewTextBoxColumn,
            this.stremailmailDataGridViewTextBoxColumn,
            this.strperfilprfDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewusuariosBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 392);
            this.dataGridView1.TabIndex = 161;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick_1);
            // 
            // viewusuariosBindingSource1
            // 
            this.viewusuariosBindingSource1.DataMember = "view_usuarios";
            this.viewusuariosBindingSource1.DataSource = this.viewUsuarioDataSet;
            // 
            // viewUsuarioDataSet
            // 
            this.viewUsuarioDataSet.DataSetName = "viewUsuarioDataSet";
            this.viewUsuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_usuariosTableAdapter
            // 
            this.view_usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::AmbienteTeste.Properties.Resources.edit__1_;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::AmbienteTeste.Properties.Resources.trash;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // int_id_usr
            // 
            this.int_id_usr.DataPropertyName = "int_id_usr";
            this.int_id_usr.HeaderText = "ID";
            this.int_id_usr.Name = "int_id_usr";
            this.int_id_usr.ReadOnly = true;
            this.int_id_usr.Visible = false;
            this.int_id_usr.Width = 30;
            // 
            // strnomeusrDataGridViewTextBoxColumn
            // 
            this.strnomeusrDataGridViewTextBoxColumn.DataPropertyName = "str_nome_usr";
            this.strnomeusrDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.strnomeusrDataGridViewTextBoxColumn.Name = "strnomeusrDataGridViewTextBoxColumn";
            this.strnomeusrDataGridViewTextBoxColumn.ReadOnly = true;
            this.strnomeusrDataGridViewTextBoxColumn.Width = 130;
            // 
            // strloginusrDataGridViewTextBoxColumn
            // 
            this.strloginusrDataGridViewTextBoxColumn.DataPropertyName = "str_login_usr";
            this.strloginusrDataGridViewTextBoxColumn.HeaderText = "Login";
            this.strloginusrDataGridViewTextBoxColumn.Name = "strloginusrDataGridViewTextBoxColumn";
            this.strloginusrDataGridViewTextBoxColumn.ReadOnly = true;
            this.strloginusrDataGridViewTextBoxColumn.Width = 130;
            // 
            // stremailmailDataGridViewTextBoxColumn
            // 
            this.stremailmailDataGridViewTextBoxColumn.DataPropertyName = "str_email_mail";
            this.stremailmailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.stremailmailDataGridViewTextBoxColumn.Name = "stremailmailDataGridViewTextBoxColumn";
            this.stremailmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.stremailmailDataGridViewTextBoxColumn.Width = 250;
            // 
            // strperfilprfDataGridViewTextBoxColumn
            // 
            this.strperfilprfDataGridViewTextBoxColumn.DataPropertyName = "str_perfil_prf";
            this.strperfilprfDataGridViewTextBoxColumn.HeaderText = "Perfil";
            this.strperfilprfDataGridViewTextBoxColumn.Name = "strperfilprfDataGridViewTextBoxColumn";
            this.strperfilprfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buscaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "buscaUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "buscaUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.buscaUsuario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewusuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsuarioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsFechar;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtBusca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private viewUsuarioDataSet viewUsuarioDataSet;
        private System.Windows.Forms.BindingSource viewusuariosBindingSource1;
        private viewUsuarioDataSetTableAdapters.view_usuariosTableAdapter view_usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn strtelefonetelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strcelulartelDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn int_id_usr;
        private System.Windows.Forms.DataGridViewTextBoxColumn strnomeusrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strloginusrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stremailmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strperfilprfDataGridViewTextBoxColumn;
    }
}