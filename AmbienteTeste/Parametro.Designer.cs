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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.strperfilprfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewPerfil = new AmbienteTeste.viewPerfil();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNomeDeletar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbUsuario = new System.Windows.Forms.CheckBox();
            this.cbImobiliaria = new System.Windows.Forms.CheckBox();
            this.cbFinanceiro = new System.Windows.Forms.CheckBox();
            this.cbCliFor = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.perfilTableAdapter = new AmbienteTeste.viewPerfilTableAdapters.perfilTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfil)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(452, 28);
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
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(404, 527);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perfil";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtNomeDeletar);
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(23, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(373, 247);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Deletar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strperfilprfDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.perfilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(330, 85);
            this.dataGridView1.TabIndex = 76;
            // 
            // strperfilprfDataGridViewTextBoxColumn
            // 
            this.strperfilprfDataGridViewTextBoxColumn.DataPropertyName = "str_perfil_prf";
            this.strperfilprfDataGridViewTextBoxColumn.HeaderText = "Perfil";
            this.strperfilprfDataGridViewTextBoxColumn.Name = "strperfilprfDataGridViewTextBoxColumn";
            this.strperfilprfDataGridViewTextBoxColumn.ReadOnly = true;
            this.strperfilprfDataGridViewTextBoxColumn.Width = 327;
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
            this.button2.Location = new System.Drawing.Point(257, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 42);
            this.button2.TabIndex = 75;
            this.button2.Text = "Deletar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(27, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 24);
            this.label13.TabIndex = 72;
            this.label13.Text = "Nome";
            // 
            // txtNomeDeletar
            // 
            this.txtNomeDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDeletar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNomeDeletar.Location = new System.Drawing.Point(95, 161);
            this.txtNomeDeletar.MaxLength = 60;
            this.txtNomeDeletar.Name = "txtNomeDeletar";
            this.txtNomeDeletar.Size = new System.Drawing.Size(266, 26);
            this.txtNomeDeletar.TabIndex = 71;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.btnSalvar);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtNome);
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(31, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 229);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Novo";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbUsuario);
            this.groupBox5.Controls.Add(this.cbImobiliaria);
            this.groupBox5.Controls.Add(this.cbFinanceiro);
            this.groupBox5.Controls.Add(this.cbCliFor);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox5.Location = new System.Drawing.Point(23, 78);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 129);
            this.groupBox5.TabIndex = 79;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Permissões";
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
            this.btnSalvar.Location = new System.Drawing.Point(249, 154);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 42);
            this.btnSalvar.TabIndex = 75;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(19, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 72;
            this.label6.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNome.Location = new System.Drawing.Point(87, 34);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(266, 26);
            this.txtNome.TabIndex = 71;
            // 
            // perfilTableAdapter
            // 
            this.perfilTableAdapter.ClearBeforeFill = true;
            // 
            // Parametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(452, 596);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfil)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNomeDeletar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbUsuario;
        private System.Windows.Forms.CheckBox cbImobiliaria;
        private System.Windows.Forms.CheckBox cbFinanceiro;
        private System.Windows.Forms.CheckBox cbCliFor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private viewPerfil viewPerfil;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private viewPerfilTableAdapters.perfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn strperfilprfDataGridViewTextBoxColumn;
    }
}