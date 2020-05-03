namespace AmbienteTeste
{
    partial class Parametro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parametro));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewPerfil = new AmbienteTeste.viewPerfil();
            this.button2 = new System.Windows.Forms.Button();
            this.perfilTableAdapter = new AmbienteTeste.viewPerfilTableAdapters.perfilTableAdapter();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbUsuario = new System.Windows.Forms.CheckBox();
            this.cbImobiliaria = new System.Windows.Forms.CheckBox();
            this.cbFinanceiro = new System.Windows.Forms.CheckBox();
            this.cbCliFor = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.iNTIDPRFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTRDESCRICAOPRFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfil)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1168, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 25);
            this.toolStripButton1.Text = "Fechar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNTIDPRFDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.sTRDESCRICAOPRFDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.perfilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(412, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(654, 154);
            this.dataGridView1.TabIndex = 76;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataMember = "perfil";
            this.perfilBindingSource.DataSource = this.viewPerfil;
            // 
            // viewPerfil
            // 
            this.viewPerfil.DataSetName = "viewPerfil";
            this.viewPerfil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(412, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 42);
            this.button2.TabIndex = 75;
            this.button2.Text = "Deletar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // perfilTableAdapter
            // 
            this.perfilTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbUsuario);
            this.groupBox5.Controls.Add(this.cbImobiliaria);
            this.groupBox5.Controls.Add(this.cbFinanceiro);
            this.groupBox5.Controls.Add(this.cbCliFor);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox5.Location = new System.Drawing.Point(60, 153);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 129);
            this.groupBox5.TabIndex = 83;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Permissões";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // cbUsuario
            // 
            this.cbUsuario.AutoSize = true;
            this.cbUsuario.Location = new System.Drawing.Point(18, 94);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(93, 28);
            this.cbUsuario.TabIndex = 3;
            this.cbUsuario.Text = "Usuário";
            this.cbUsuario.UseVisualStyleBackColor = true;
            // 
            // cbImobiliaria
            // 
            this.cbImobiliaria.AutoSize = true;
            this.cbImobiliaria.Location = new System.Drawing.Point(18, 71);
            this.cbImobiliaria.Name = "cbImobiliaria";
            this.cbImobiliaria.Size = new System.Drawing.Size(113, 28);
            this.cbImobiliaria.TabIndex = 2;
            this.cbImobiliaria.Text = "Imobiliária";
            this.cbImobiliaria.UseVisualStyleBackColor = true;
            // 
            // cbFinanceiro
            // 
            this.cbFinanceiro.AutoSize = true;
            this.cbFinanceiro.Location = new System.Drawing.Point(18, 48);
            this.cbFinanceiro.Name = "cbFinanceiro";
            this.cbFinanceiro.Size = new System.Drawing.Size(119, 28);
            this.cbFinanceiro.TabIndex = 1;
            this.cbFinanceiro.Text = "Financeiro";
            this.cbFinanceiro.UseVisualStyleBackColor = true;
            // 
            // cbCliFor
            // 
            this.cbCliFor.AutoSize = true;
            this.cbCliFor.Location = new System.Drawing.Point(18, 24);
            this.cbCliFor.Name = "cbCliFor";
            this.cbCliFor.Size = new System.Drawing.Size(192, 28);
            this.cbCliFor.TabIndex = 0;
            this.cbCliFor.Text = "Cliente/Fornecedor";
            this.cbCliFor.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Location = new System.Drawing.Point(286, 229);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 42);
            this.btnSalvar.TabIndex = 82;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(56, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNome.Location = new System.Drawing.Point(124, 109);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(266, 26);
            this.txtNome.TabIndex = 80;
            // 
            // iNTIDPRFDataGridViewTextBoxColumn
            // 
            this.iNTIDPRFDataGridViewTextBoxColumn.DataPropertyName = "INT_ID_PRF";
            this.iNTIDPRFDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iNTIDPRFDataGridViewTextBoxColumn.Name = "iNTIDPRFDataGridViewTextBoxColumn";
            this.iNTIDPRFDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNTIDPRFDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "STR_PERFIL_PRF";
            this.dataGridViewTextBoxColumn1.HeaderText = "PERFIL";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sTRDESCRICAOPRFDataGridViewTextBoxColumn
            // 
            this.sTRDESCRICAOPRFDataGridViewTextBoxColumn.DataPropertyName = "STR_DESCRICAO_PRF";
            this.sTRDESCRICAOPRFDataGridViewTextBoxColumn.HeaderText = "PERMISSÕES";
            this.sTRDESCRICAOPRFDataGridViewTextBoxColumn.Name = "sTRDESCRICAOPRFDataGridViewTextBoxColumn";
            this.sTRDESCRICAOPRFDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTRDESCRICAOPRFDataGridViewTextBoxColumn.Width = 400;
            // 
            // Parametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1168, 596);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Parametro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametro";
            this.Load += new System.EventHandler(this.Parametro_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfil)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private viewPerfil viewPerfil;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private viewPerfilTableAdapters.perfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbUsuario;
        private System.Windows.Forms.CheckBox cbImobiliaria;
        private System.Windows.Forms.CheckBox cbFinanceiro;
        private System.Windows.Forms.CheckBox cbCliFor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn strperfilprfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNTIDPRFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTRDESCRICAOPRFDataGridViewTextBoxColumn;
    }
}