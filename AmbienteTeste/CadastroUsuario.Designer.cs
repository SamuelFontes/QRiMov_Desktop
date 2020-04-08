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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewPerfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewPerfil = new AmbienteTeste.viewPerfil();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lbUF = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskDtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.perfilTableAdapter = new AmbienteTeste.viewPerfilTableAdapters.perfilTableAdapter();
            this.tsFechar = new System.Windows.Forms.ToolStripButton();
            this.tsSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPerfil)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1010, 35);
            this.toolStrip1.TabIndex = 252;
            this.toolStrip1.Text = "toolStrip1";
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
            this.groupBox2.Size = new System.Drawing.Size(223, 117);
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
            this.dataGridViewTextBoxColumn1,
            this.id});
            this.dataGridView1.DataSource = this.perfilBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(217, 92);
            this.dataGridView1.TabIndex = 261;
            // 
            // id
            // 
            this.id.DataPropertyName = "int_id_prf";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "str_perfil_prf";
            this.dataGridViewTextBoxColumn1.HeaderText = "Perfil";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 213;
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
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(585, 250);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(92, 29);
            this.txtCep.TabIndex = 9;
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // txtUF
            // 
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.Location = new System.Drawing.Point(961, 318);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(32, 29);
            this.txtUF.TabIndex = 242;
            // 
            // lbUF
            // 
            this.lbUF.AutoSize = true;
            this.lbUF.BackColor = System.Drawing.Color.Transparent;
            this.lbUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUF.Location = new System.Drawing.Point(918, 321);
            this.lbUF.Name = "lbUF";
            this.lbUF.Size = new System.Drawing.Size(37, 24);
            this.lbUF.TabIndex = 241;
            this.lbUF.Text = "UF";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(770, 250);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(174, 29);
            this.txtBairro.TabIndex = 240;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.BackColor = System.Drawing.Color.Transparent;
            this.lbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.Location = new System.Drawing.Point(699, 253);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(65, 24);
            this.lbBairro.TabIndex = 239;
            this.lbBairro.Text = "Bairro";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(565, 319);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(52, 29);
            this.txtNumero.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(529, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 24);
            this.label10.TabIndex = 235;
            this.label10.Text = "nº";
            // 
            // txtCel
            // 
            this.txtCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCel.Location = new System.Drawing.Point(368, 253);
            this.txtCel.Mask = "(00)90000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(136, 29);
            this.txtCel.TabIndex = 8;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(114, 253);
            this.txtTel.Mask = "(00)0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(125, 29);
            this.txtTel.TabIndex = 7;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipio.Location = new System.Drawing.Point(746, 318);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(155, 29);
            this.txtMunicipio.TabIndex = 232;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Location = new System.Drawing.Point(129, 319);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(389, 29);
            this.txtLogradouro.TabIndex = 231;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(471, 185);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(331, 29);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(89, 184);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(282, 26);
            this.txtNome.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(283, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 24);
            this.label9.TabIndex = 228;
            this.label9.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 227;
            this.label8.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(528, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 226;
            this.label7.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(633, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 225;
            this.label6.Text = "Municipio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 24);
            this.label11.TabIndex = 224;
            this.label11.Text = "Endereço";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(398, 185);
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
            this.label13.Location = new System.Drawing.Point(16, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 24);
            this.label13.TabIndex = 222;
            this.label13.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 253;
            this.label1.Text = "CPF";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAtivo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(624, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 67);
            this.groupBox1.TabIndex = 255;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(860, 68);
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
            this.label2.Location = new System.Drawing.Point(766, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 256;
            this.label2.Text = "Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(860, 121);
            this.txtSenha.MaxLength = 60;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(131, 29);
            this.txtSenha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(777, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 258;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(816, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 24);
            this.label4.TabIndex = 260;
            this.label4.Text = "Data de nascimento";
            // 
            // maskDtNascimento
            // 
            this.maskDtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskDtNascimento.Location = new System.Drawing.Point(860, 196);
            this.maskDtNascimento.Mask = "00/00/0000";
            this.maskDtNascimento.Name = "maskDtNascimento";
            this.maskDtNascimento.Size = new System.Drawing.Size(98, 29);
            this.maskDtNascimento.TabIndex = 6;
            this.maskDtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // maskCPF
            // 
            this.maskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCPF.Location = new System.Drawing.Point(19, 124);
            this.maskCPF.Mask = "000,000,000-99";
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(136, 29);
            this.maskCPF.TabIndex = 1;
            // 
            // perfilTableAdapter
            // 
            this.perfilTableAdapter.ClearBeforeFill = true;
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
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 393);
            this.Controls.Add(this.maskCPF);
            this.Controls.Add(this.maskDtNascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.lbUF);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsFechar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lbUF;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskDtNascimento;
        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn strperfilprfDataGridViewTextBoxColumn;
        private viewPerfil viewPerfil;
        private System.Windows.Forms.BindingSource viewPerfilBindingSource;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private viewPerfilTableAdapters.perfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripButton tsSalvar;
    }
}