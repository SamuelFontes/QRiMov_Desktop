namespace AmbienteTeste
{
    partial class AlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarSenha));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsFechar = new System.Windows.Forms.ToolStripButton();
            this.tsSalvar = new System.Windows.Forms.ToolStripButton();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirma = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirmar Nova Senha";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.BackgroundImage = global::AmbienteTeste.Properties.Resources.teste;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFechar,
            this.tsSalvar});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(418, 35);
            this.toolStrip1.TabIndex = 292;
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
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(218, 48);
            this.txtSenha.MaxLength = 15;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(180, 26);
            this.txtSenha.TabIndex = 293;
            // 
            // txtConfirma
            // 
            this.txtConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirma.Location = new System.Drawing.Point(218, 93);
            this.txtConfirma.MaxLength = 15;
            this.txtConfirma.Name = "txtConfirma";
            this.txtConfirma.PasswordChar = '*';
            this.txtConfirma.Size = new System.Drawing.Size(180, 26);
            this.txtConfirma.TabIndex = 294;
            // 
            // AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(418, 144);
            this.ControlBox = false;
            this.Controls.Add(this.txtConfirma);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlterarSenha";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarSenha";
            this.TopMost = true;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsFechar;
        private System.Windows.Forms.ToolStripButton tsSalvar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirma;
    }
}