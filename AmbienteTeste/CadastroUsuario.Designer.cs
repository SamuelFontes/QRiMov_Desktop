namespace AmbienteTeste
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsFechar = new System.Windows.Forms.ToolStripButton();
            this.tsSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewPerfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewPerfil = new AmbienteTeste.viewPerfil();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.perfilTableAdapter = new AmbienteTeste.viewPerfilTableAdapters.perfilTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.viewPerfilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.perfilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iNTIDPRFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTRDESCRICAOPRFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFechar,
            this.tsSalvar,
            this.toolStripSeparator1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(565, 35);
            this.toolStrip1.TabIndex = 252;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsFechar
            // 
            this.tsFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFechar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsFechar.ForeColor = System.Drawing.Color.White;
            this.tsFechar.Image = ((System.Drawing.Image)(resources.GetObject("tsFechar.Image")));
            this.tsFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFechar.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.tsFechar.Name = "tsFechar";
            this.tsFechar.Size = new System.Drawing.Size(72, 32);
            this.tsFechar.Text = "Fechar";
            this.tsFechar.Click += new System.EventHandler(this.tsFechar_Click);
            // 
            // tsSalvar
            // 
            this.tsSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSalvar.ForeColor = System.Drawing.Color.White;
            this.tsSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsSalvar.Image")));
            this.tsSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSalvar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.tsSalvar.Name = "tsSalvar";
            this.tsSalvar.Size = new System.Drawing.Size(57, 33);
            this.tsSalvar.Text = "Salvar";
            this.tsSalvar.Click += new System.EventHandler(this.tsSalvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(244, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 117);
            this.groupBox2.TabIndex = 251;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perfis";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNTIDPRFDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.sTRDESCRICAOPRFDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.perfilBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(303, 92);
            this.dataGridView1.TabIndex = 261;
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataMember = "perfil";
            this.perfilBindingSource.DataSource = this.viewPerfilBindingSource;
            // 
            // viewPerfilBindingSource
            // 
            this.viewPerfilBindingSource.DataSource = this.viewPerfil;
            this.viewPerfilBindingSource.Position = 0;
            // 
            // viewPerfil
            // 
            this.viewPerfil.DataSetName = "viewPerfil";
            this.viewPerfil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(86, 193);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(467, 29);
            this.txtEmail.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(86, 161);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(467, 26);
            this.txtNome.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 24);
            this.label12.TabIndex = 223;
            this.label12.Text = "E-mail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 24);
            this.label13.TabIndex = 222;
            this.label13.Text = "Nome";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(107, 76);
            this.txtUsuario.MaxLength = 60;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(131, 29);
            this.txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 256;
            this.label2.Text = "Usuário";
            // 
            // perfilTableAdapter
            // 
            this.perfilTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 258;
            this.label3.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(107, 111);
            this.txtSenha.MaxLength = 60;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(131, 29);
            this.txtSenha.TabIndex = 3;
            // 
            // viewPerfilBindingSource1
            // 
            this.viewPerfilBindingSource1.DataSource = this.viewPerfil;
            this.viewPerfilBindingSource1.Position = 0;
            // 
            // perfilBindingSource1
            // 
            this.perfilBindingSource1.DataMember = "perfil";
            this.perfilBindingSource1.DataSource = this.viewPerfilBindingSource1;
            // 
            // iNTIDPRFDataGridViewTextBoxColumn
            // 
            this.iNTIDPRFDataGridViewTextBoxColumn.DataPropertyName = "INT_ID_PRF";
            this.iNTIDPRFDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iNTIDPRFDataGridViewTextBoxColumn.Name = "iNTIDPRFDataGridViewTextBoxColumn";
            this.iNTIDPRFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "STR_PERFIL_PRF";
            this.dataGridViewTextBoxColumn2.HeaderText = "Perfil";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // sTRDESCRICAOPRFDataGridViewTextBoxColumn
            // 
            this.sTRDESCRICAOPRFDataGridViewTextBoxColumn.DataPropertyName = "STR_DESCRICAO_PRF";
            this.sTRDESCRICAOPRFDataGridViewTextBoxColumn.HeaderText = "Permissões";
            this.sTRDESCRICAOPRFDataGridViewTextBoxColumn.Name = "sTRDESCRICAOPRFDataGridViewTextBoxColumn";
            this.sTRDESCRICAOPRFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 237);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroUsuario";
            this.Load += new System.EventHandler(this.CadastroUsuario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsFechar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn strperfilprfDataGridViewTextBoxColumn;
        private viewPerfil viewPerfil;
        private System.Windows.Forms.BindingSource viewPerfilBindingSource;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private viewPerfilTableAdapters.perfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripButton tsSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNTIDPRFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTRDESCRICAOPRFDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource perfilBindingSource1;
        private System.Windows.Forms.BindingSource viewPerfilBindingSource1;
    }
}