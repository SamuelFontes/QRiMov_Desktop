namespace AmbienteTeste
{
    partial class AlteraImobiliaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlteraImobiliaria));
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.qtd = new System.Windows.Forms.Label();
            this.CmbPlano = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsFechar = new System.Windows.Forms.ToolStripButton();
            this.tsAlterar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lbUF = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.txtCreci = new System.Windows.Forms.TextBox();
            this.lbCreci = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.lbFantasia = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.maskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtInscMunicipal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInscEstadual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 24);
            this.label15.TabIndex = 222;
            this.label15.Text = "CNPJ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.qtd);
            this.groupBox4.Controls.Add(this.CmbPlano);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(419, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 221;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plano";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Qtd de imoveis";
            // 
            // qtd
            // 
            this.qtd.AutoSize = true;
            this.qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd.Location = new System.Drawing.Point(155, 65);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(0, 25);
            this.qtd.TabIndex = 1;
            // 
            // CmbPlano
            // 
            this.CmbPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPlano.FormattingEnabled = true;
            this.CmbPlano.Items.AddRange(new object[] {
            "Silver",
            "Gold",
            "Platinum",
            "Sem Plano"});
            this.CmbPlano.Location = new System.Drawing.Point(17, 25);
            this.CmbPlano.Name = "CmbPlano";
            this.CmbPlano.Size = new System.Drawing.Size(157, 28);
            this.CmbPlano.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFechar,
            this.tsAlterar,
            this.toolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1139, 35);
            this.toolStrip1.TabIndex = 220;
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
            // tsAlterar
            // 
            this.tsAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsAlterar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsAlterar.ForeColor = System.Drawing.Color.White;
            this.tsAlterar.Image = ((System.Drawing.Image)(resources.GetObject("tsAlterar.Image")));
            this.tsAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAlterar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.tsAlterar.Name = "tsAlterar";
            this.tsAlterar.Size = new System.Drawing.Size(61, 33);
            this.tsAlterar.Text = "Alterar";
            this.tsAlterar.Click += new System.EventHandler(this.tsSalvar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 32);
            this.toolStripButton1.Text = "Deletar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(69, 323);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(92, 29);
            this.txtCep.TabIndex = 199;
            // 
            // txtUF
            // 
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.Location = new System.Drawing.Point(380, 385);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(32, 29);
            this.txtUF.TabIndex = 216;
            // 
            // lbUF
            // 
            this.lbUF.AutoSize = true;
            this.lbUF.BackColor = System.Drawing.Color.Transparent;
            this.lbUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUF.Location = new System.Drawing.Point(337, 388);
            this.lbUF.Name = "lbUF";
            this.lbUF.Size = new System.Drawing.Size(37, 24);
            this.lbUF.TabIndex = 215;
            this.lbUF.Text = "UF";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(892, 324);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(174, 29);
            this.txtBairro.TabIndex = 214;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.BackColor = System.Drawing.Color.Transparent;
            this.lbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.Location = new System.Drawing.Point(821, 326);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(65, 24);
            this.lbBairro.TabIndex = 213;
            this.lbBairro.Text = "Bairro";
            // 
            // txtCreci
            // 
            this.txtCreci.Enabled = false;
            this.txtCreci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreci.Location = new System.Drawing.Point(506, 267);
            this.txtCreci.Name = "txtCreci";
            this.txtCreci.Size = new System.Drawing.Size(113, 26);
            this.txtCreci.TabIndex = 195;
            // 
            // lbCreci
            // 
            this.lbCreci.AutoSize = true;
            this.lbCreci.BackColor = System.Drawing.Color.Transparent;
            this.lbCreci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreci.Location = new System.Drawing.Point(441, 267);
            this.lbCreci.Name = "lbCreci";
            this.lbCreci.Size = new System.Drawing.Size(59, 24);
            this.lbCreci.TabIndex = 212;
            this.lbCreci.Text = "Creci";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFantasia.Location = new System.Drawing.Point(643, 192);
            this.txtFantasia.MaxLength = 60;
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(463, 26);
            this.txtFantasia.TabIndex = 192;
            // 
            // lbFantasia
            // 
            this.lbFantasia.AutoSize = true;
            this.lbFantasia.BackColor = System.Drawing.Color.Transparent;
            this.lbFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFantasia.Location = new System.Drawing.Point(487, 194);
            this.lbFantasia.Name = "lbFantasia";
            this.lbFantasia.Size = new System.Drawing.Size(150, 24);
            this.lbFantasia.TabIndex = 211;
            this.lbFantasia.Text = "Nome Fantasia";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(738, 324);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(52, 29);
            this.txtNumero.TabIndex = 200;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(702, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 24);
            this.label10.TabIndex = 210;
            this.label10.Text = "nº";
            // 
            // txtCel
            // 
            this.txtCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCel.Location = new System.Drawing.Point(970, 264);
            this.txtCel.Mask = "(00)90000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(136, 29);
            this.txtCel.TabIndex = 198;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(738, 264);
            this.txtTel.Mask = "(00)0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(125, 29);
            this.txtTel.TabIndex = 197;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipio.Location = new System.Drawing.Point(125, 384);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(175, 29);
            this.txtMunicipio.TabIndex = 209;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Location = new System.Drawing.Point(302, 324);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(389, 29);
            this.txtLogradouro.TabIndex = 208;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(85, 264);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(331, 29);
            this.txtEmail.TabIndex = 196;
            // 
            // txtRazao
            // 
            this.txtRazao.Enabled = false;
            this.txtRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazao.Location = new System.Drawing.Point(154, 192);
            this.txtRazao.MaxLength = 60;
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(309, 26);
            this.txtRazao.TabIndex = 191;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(888, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 24);
            this.label9.TabIndex = 207;
            this.label9.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(639, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 206;
            this.label8.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 205;
            this.label7.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 204;
            this.label6.Text = "Municipio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(189, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 24);
            this.label11.TabIndex = 203;
            this.label11.Text = "Endereço";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 24);
            this.label12.TabIndex = 202;
            this.label12.Text = "E-mail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 24);
            this.label13.TabIndex = 201;
            this.label13.Text = "Razão social";
            // 
            // maskCNPJ
            // 
            this.maskCNPJ.Enabled = false;
            this.maskCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCNPJ.Location = new System.Drawing.Point(12, 126);
            this.maskCNPJ.Mask = "99,999,999/9999-99";
            this.maskCNPJ.Name = "maskCNPJ";
            this.maskCNPJ.Size = new System.Drawing.Size(169, 29);
            this.maskCNPJ.TabIndex = 190;
            // 
            // txtInscMunicipal
            // 
            this.txtInscMunicipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscMunicipal.Location = new System.Drawing.Point(977, 384);
            this.txtInscMunicipal.Name = "txtInscMunicipal";
            this.txtInscMunicipal.Size = new System.Drawing.Size(130, 26);
            this.txtInscMunicipal.TabIndex = 224;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 226;
            this.label1.Text = "Inscrição Estadual";
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscEstadual.Location = new System.Drawing.Point(626, 384);
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(120, 26);
            this.txtInscEstadual.TabIndex = 223;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(776, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 24);
            this.label5.TabIndex = 225;
            this.label5.Text = "Inscrição Municipal";
            // 
            // AlteraImobiliaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 431);
            this.Controls.Add(this.txtInscMunicipal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInscEstadual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskCNPJ);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.lbUF);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.txtCreci);
            this.Controls.Add(this.lbCreci);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(this.lbFantasia);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRazao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlteraImobiliaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlteraImobiliaria";
            this.Load += new System.EventHandler(this.AlteraImobiliaria_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label qtd;
        private System.Windows.Forms.ComboBox CmbPlano;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsFechar;
        private System.Windows.Forms.ToolStripButton tsAlterar;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lbUF;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox txtCreci;
        private System.Windows.Forms.Label lbCreci;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.Label lbFantasia;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox maskCNPJ;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox txtInscMunicipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInscEstadual;
        private System.Windows.Forms.Label label5;
    }
}