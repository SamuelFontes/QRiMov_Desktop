namespace AmbienteTeste
{
    partial class AlteraUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlteraUsuario));
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsFechar = new System.Windows.Forms.ToolStripButton();
            this.tsSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.txtCadastro = new System.Windows.Forms.TextBox();
            this.viewPerfil = new AmbienteTeste.viewPerfil();
            this.viewPerfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.perfilTableAdapter = new AmbienteTeste.viewPerfilTableAdapters.perfilTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskCPF
            // 
            this.maskCPF.Enabled = false;
            this.maskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCPF.Location = new System.Drawing.Point(12, 139);
            this.maskCPF.Mask = "000,000,000-99";
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(136, 29);
            this.maskCPF.TabIndex = 261;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(809, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 290;
            this.label4.Text = "Data de Cadastro";
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(853, 136);
            this.txtSenha.MaxLength = 60;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(131, 29);
            this.txtSenha.TabIndex = 263;
            this.txtSenha.Text = "abcdef";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(770, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 289;
            this.label3.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(853, 83);
            this.txtUsuario.MaxLength = 60;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(131, 29);
            this.txtUsuario.TabIndex = 262;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(759, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 288;
            this.label2.Text = "Usuário";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAtivo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(617, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 67);
            this.groupBox1.TabIndex = 287;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.Location = new System.Drawing.Point(31, 29);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(63, 24);
            this.cbAtivo.TabIndex = 254;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 286;
            this.label1.Text = "CPF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(270, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 117);
            this.groupBox2.TabIndex = 285;
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
            this.id,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.perfilBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(204, 92);
            this.dataGridView1.TabIndex = 262;
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataMember = "perfil";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(578, 265);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(92, 29);
            this.txtCep.TabIndex = 269;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(763, 265);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(174, 29);
            this.txtBairro.TabIndex = 282;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.BackColor = System.Drawing.Color.Transparent;
            this.lbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.Location = new System.Drawing.Point(692, 268);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(65, 24);
            this.lbBairro.TabIndex = 281;
            this.lbBairro.Text = "Bairro";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(558, 334);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(52, 29);
            this.txtNumero.TabIndex = 270;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(522, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 24);
            this.label10.TabIndex = 280;
            this.label10.Text = "nº";
            // 
            // txtCel
            // 
            this.txtCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCel.Location = new System.Drawing.Point(361, 268);
            this.txtCel.Mask = "(00)90000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(136, 29);
            this.txtCel.TabIndex = 268;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(107, 268);
            this.txtTel.Mask = "(00)0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(125, 29);
            this.txtTel.TabIndex = 267;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipio.Location = new System.Drawing.Point(763, 333);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(174, 29);
            this.txtMunicipio.TabIndex = 279;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Location = new System.Drawing.Point(122, 334);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(389, 29);
            this.txtLogradouro.TabIndex = 278;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(464, 200);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(331, 29);
            this.txtEmail.TabIndex = 265;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(82, 199);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(282, 26);
            this.txtNome.TabIndex = 264;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 24);
            this.label9.TabIndex = 277;
            this.label9.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 276;
            this.label8.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(521, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 275;
            this.label7.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(656, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 274;
            this.label6.Text = "Municipio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 24);
            this.label11.TabIndex = 273;
            this.label11.Text = "Endereço";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(391, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 24);
            this.label12.TabIndex = 272;
            this.label12.Text = "E-mail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 24);
            this.label13.TabIndex = 271;
            this.label13.Text = "Nome";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFechar,
            this.tsSalvar,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1022, 35);
            this.toolStrip1.TabIndex = 291;
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
            this.tsSalvar.Size = new System.Drawing.Size(61, 33);
            this.tsSalvar.Text = "Alterar";
            this.tsSalvar.Click += new System.EventHandler(this.tsSalvar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 32);
            this.toolStripButton1.Text = "Deletar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(108, 32);
            this.toolStripButton2.Text = "Alterar Senha";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // txtCadastro
            // 
            this.txtCadastro.Enabled = false;
            this.txtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastro.Location = new System.Drawing.Point(850, 211);
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(87, 29);
            this.txtCadastro.TabIndex = 292;
            // 
            // viewPerfil
            // 
            this.viewPerfil.DataSetName = "viewPerfil";
            this.viewPerfil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewPerfilBindingSource
            // 
            this.viewPerfilBindingSource.DataSource = this.viewPerfil;
            this.viewPerfilBindingSource.Position = 0;
            // 
            // perfilBindingSource1
            // 
            this.perfilBindingSource1.DataMember = "perfil";
            this.perfilBindingSource1.DataSource = this.viewPerfilBindingSource;
            // 
            // perfilTableAdapter
            // 
            this.perfilTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "int_id_prf";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "str_perfil_prf";
            this.dataGridViewTextBoxColumn1.HeaderText = "Perfil";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // AlteraUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 401);
            this.Controls.Add(this.txtCadastro);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.maskCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlteraUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeletaUsuario";
            this.Load += new System.EventHandler(this.AlteraUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsFechar;
        private System.Windows.Forms.ToolStripButton tsSalvar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private System.Windows.Forms.TextBox txtCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn strperfilprfDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewPerfilBindingSource;
        private viewPerfil viewPerfil;
        private System.Windows.Forms.BindingSource perfilBindingSource1;
        private viewPerfilTableAdapters.perfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}