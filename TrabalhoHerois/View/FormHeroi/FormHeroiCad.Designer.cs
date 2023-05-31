namespace TrabalhoHerois.View.FormHeroi
{
    partial class FormHeroiCad
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
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btUpload = new System.Windows.Forms.Button();
            this.lbFotoHeroi = new System.Windows.Forms.Label();
            this.tbApelido = new System.Windows.Forms.TextBox();
            this.lbApelidoHeroi = new System.Windows.Forms.Label();
            this.tbParceiro = new System.Windows.Forms.TextBox();
            this.lbParcHeroi = new System.Windows.Forms.Label();
            this.tbPoder = new System.Windows.Forms.TextBox();
            this.lbPoderHeroi = new System.Windows.Forms.Label();
            this.tbPlaneta = new System.Windows.Forms.TextBox();
            this.lbPlanetaHeroi = new System.Windows.Forms.Label();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.lbNascHeroi = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmailHeroi = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNomeHeroi = new System.Windows.Forms.Label();
            this.lbCadVilao = new System.Windows.Forms.Label();
            this.tbAtiPro = new System.Windows.Forms.TextBox();
            this.lbAtiviHeroi = new System.Windows.Forms.Label();
            this.tbGrupo = new System.Windows.Forms.TextBox();
            this.lbGrupoHeroi = new System.Windows.Forms.Label();
            this.tbFraco = new System.Windows.Forms.TextBox();
            this.lbFracoHeroi = new System.Windows.Forms.Label();
            this.bt_enviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(460, 282);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(73, 73);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 39;
            this.pbFoto.TabStop = false;
            // 
            // btUpload
            // 
            this.btUpload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btUpload.BackColor = System.Drawing.Color.RoyalBlue;
            this.btUpload.FlatAppearance.BorderSize = 0;
            this.btUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpload.Image = global::TrabalhoHerois.Properties.Resources.uploadIcon;
            this.btUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUpload.Location = new System.Drawing.Point(376, 314);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(72, 32);
            this.btUpload.TabIndex = 11;
            this.btUpload.Text = "Image";
            this.btUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUpload.UseVisualStyleBackColor = false;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // lbFotoHeroi
            // 
            this.lbFotoHeroi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFotoHeroi.AutoSize = true;
            this.lbFotoHeroi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFotoHeroi.Location = new System.Drawing.Point(370, 293);
            this.lbFotoHeroi.Name = "lbFotoHeroi";
            this.lbFotoHeroi.Size = new System.Drawing.Size(89, 13);
            this.lbFotoHeroi.TabIndex = 37;
            this.lbFotoHeroi.Text = "11. Foto do Heroi";
            // 
            // tbApelido
            // 
            this.tbApelido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbApelido.Location = new System.Drawing.Point(249, 249);
            this.tbApelido.Margin = new System.Windows.Forms.Padding(7, 15, 3, 25);
            this.tbApelido.Name = "tbApelido";
            this.tbApelido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbApelido.Size = new System.Drawing.Size(92, 20);
            this.tbApelido.TabIndex = 7;
            this.tbApelido.Tag = "Apelido";
            this.tbApelido.Text = "Apelido";
            this.tbApelido.Enter += new System.EventHandler(this.tbApelido_Enter);
            this.tbApelido.Leave += new System.EventHandler(this.tbApelido_Leave);
            // 
            // lbApelidoHeroi
            // 
            this.lbApelidoHeroi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbApelidoHeroi.AutoSize = true;
            this.lbApelidoHeroi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbApelidoHeroi.Location = new System.Drawing.Point(246, 221);
            this.lbApelidoHeroi.Name = "lbApelidoHeroi";
            this.lbApelidoHeroi.Size = new System.Drawing.Size(104, 13);
            this.lbApelidoHeroi.TabIndex = 35;
            this.lbApelidoHeroi.Text = "7. Apelido do Heroi *";
            // 
            // tbParceiro
            // 
            this.tbParceiro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbParceiro.Location = new System.Drawing.Point(104, 249);
            this.tbParceiro.Margin = new System.Windows.Forms.Padding(7, 15, 3, 25);
            this.tbParceiro.Name = "tbParceiro";
            this.tbParceiro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbParceiro.Size = new System.Drawing.Size(135, 20);
            this.tbParceiro.TabIndex = 6;
            this.tbParceiro.Tag = "Nome do parceiro";
            this.tbParceiro.Text = "Nome do parceiro";
            this.tbParceiro.Enter += new System.EventHandler(this.tbParceiro_Enter);
            this.tbParceiro.Leave += new System.EventHandler(this.tbParceiro_Leave);
            // 
            // lbParcHeroi
            // 
            this.lbParcHeroi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbParcHeroi.AutoSize = true;
            this.lbParcHeroi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbParcHeroi.Location = new System.Drawing.Point(101, 221);
            this.lbParcHeroi.Name = "lbParcHeroi";
            this.lbParcHeroi.Size = new System.Drawing.Size(109, 13);
            this.lbParcHeroi.TabIndex = 33;
            this.lbParcHeroi.Text = "6. Parceiro Amoroso *";
            // 
            // tbPoder
            // 
            this.tbPoder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPoder.Location = new System.Drawing.Point(442, 176);
            this.tbPoder.Margin = new System.Windows.Forms.Padding(7, 15, 3, 25);
            this.tbPoder.Name = "tbPoder";
            this.tbPoder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPoder.Size = new System.Drawing.Size(91, 20);
            this.tbPoder.TabIndex = 5;
            this.tbPoder.Tag = "Voar, Super For...";
            this.tbPoder.Text = "Voar, Super For...";
            this.tbPoder.Enter += new System.EventHandler(this.tbPoder_Enter);
            this.tbPoder.Leave += new System.EventHandler(this.tbPoder_Leave);
            // 
            // lbPoderHeroi
            // 
            this.lbPoderHeroi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPoderHeroi.AutoSize = true;
            this.lbPoderHeroi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPoderHeroi.Location = new System.Drawing.Point(439, 148);
            this.lbPoderHeroi.Name = "lbPoderHeroi";
            this.lbPoderHeroi.Size = new System.Drawing.Size(85, 13);
            this.lbPoderHeroi.TabIndex = 31;
            this.lbPoderHeroi.Text = "5. Super Poder *";
            // 
            // tbPlaneta
            // 
            this.tbPlaneta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPlaneta.Location = new System.Drawing.Point(327, 176);
            this.tbPlaneta.Margin = new System.Windows.Forms.Padding(7, 15, 3, 25);
            this.tbPlaneta.Name = "tbPlaneta";
            this.tbPlaneta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPlaneta.Size = new System.Drawing.Size(105, 20);
            this.tbPlaneta.TabIndex = 4;
            this.tbPlaneta.Tag = "Terra, Jupiter, Mart...";
            this.tbPlaneta.Text = "Terra, Jupiter, Mart...";
            this.tbPlaneta.Enter += new System.EventHandler(this.tbPlaneta_Enter);
            this.tbPlaneta.Leave += new System.EventHandler(this.tbPlaneta_Leave);
            // 
            // lbPlanetaHeroi
            // 
            this.lbPlanetaHeroi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPlanetaHeroi.AutoSize = true;
            this.lbPlanetaHeroi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPlanetaHeroi.Location = new System.Drawing.Point(324, 148);
            this.lbPlanetaHeroi.Name = "lbPlanetaHeroi";
            this.lbPlanetaHeroi.Size = new System.Drawing.Size(113, 13);
            this.lbPlanetaHeroi.TabIndex = 29;
            this.lbPlanetaHeroi.Text = "4. Planeta de Origem *";
            // 
            // dtpNasc
            // 
            this.dtpNasc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNasc.CustomFormat = "yyyy";
            this.dtpNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNasc.Location = new System.Drawing.Point(104, 176);
            this.dtpNasc.Margin = new System.Windows.Forms.Padding(3, 15, 3, 25);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.ShowUpDown = true;
            this.dtpNasc.Size = new System.Drawing.Size(78, 20);
            this.dtpNasc.TabIndex = 2;
            // 
            // lbNascHeroi
            // 
            this.lbNascHeroi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNascHeroi.AutoSize = true;
            this.lbNascHeroi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNascHeroi.Location = new System.Drawing.Point(101, 148);
            this.lbNascHeroi.Name = "lbNascHeroi";
            this.lbNascHeroi.Size = new System.Drawing.Size(81, 13);
            this.lbNascHeroi.TabIndex = 27;
            this.lbNascHeroi.Text = "2. Ano de Nasc";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbEmail.Location = new System.Drawing.Point(193, 176);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(7, 15, 3, 25);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEmail.Size = new System.Drawing.Size(124, 20);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Tag = "example@dominio.com";
            this.tbEmail.Text = "example@dominio.com";
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // lbEmailHeroi
            // 
            this.lbEmailHeroi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEmailHeroi.AutoSize = true;
            this.lbEmailHeroi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEmailHeroi.Location = new System.Drawing.Point(190, 148);
            this.lbEmailHeroi.Name = "lbEmailHeroi";
            this.lbEmailHeroi.Size = new System.Drawing.Size(51, 13);
            this.lbEmailHeroi.TabIndex = 25;
            this.lbEmailHeroi.Text = "3. Email *";
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNome.Location = new System.Drawing.Point(104, 103);
            this.tbNome.Margin = new System.Windows.Forms.Padding(0, 15, 0, 25);
            this.tbNome.Name = "tbNome";
            this.tbNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNome.Size = new System.Drawing.Size(429, 20);
            this.tbNome.TabIndex = 1;
            this.tbNome.Tag = "Nome Completo";
            this.tbNome.Text = "Nome Completo";
            this.tbNome.Enter += new System.EventHandler(this.tbNome_Enter);
            this.tbNome.Leave += new System.EventHandler(this.tbNome_Leave);
            // 
            // lbNomeHeroi
            // 
            this.lbNomeHeroi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNomeHeroi.AutoSize = true;
            this.lbNomeHeroi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNomeHeroi.Location = new System.Drawing.Point(101, 75);
            this.lbNomeHeroi.Name = "lbNomeHeroi";
            this.lbNomeHeroi.Size = new System.Drawing.Size(97, 13);
            this.lbNomeHeroi.TabIndex = 21;
            this.lbNomeHeroi.Text = "1. Nome do Heroi *";
            // 
            // lbCadVilao
            // 
            this.lbCadVilao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCadVilao.AutoSize = true;
            this.lbCadVilao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadVilao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCadVilao.Location = new System.Drawing.Point(214, 20);
            this.lbCadVilao.Margin = new System.Windows.Forms.Padding(10);
            this.lbCadVilao.Name = "lbCadVilao";
            this.lbCadVilao.Size = new System.Drawing.Size(209, 29);
            this.lbCadVilao.TabIndex = 20;
            this.lbCadVilao.Text = "Cadastro do Heroi";
            // 
            // tbAtiPro
            // 
            this.tbAtiPro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAtiPro.Location = new System.Drawing.Point(351, 249);
            this.tbAtiPro.Margin = new System.Windows.Forms.Padding(7, 15, 3, 25);
            this.tbAtiPro.Name = "tbAtiPro";
            this.tbAtiPro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAtiPro.Size = new System.Drawing.Size(182, 20);
            this.tbAtiPro.TabIndex = 8;
            this.tbAtiPro.Tag = "Salvar Pessoas, Cidades, Planetas...";
            this.tbAtiPro.Text = "Salvar Pessoas, Cidades, Planetas...";
            this.tbAtiPro.Enter += new System.EventHandler(this.tbAtiPro_Enter);
            this.tbAtiPro.Leave += new System.EventHandler(this.tbAtiPro_Leave);
            // 
            // lbAtiviHeroi
            // 
            this.lbAtiviHeroi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAtiviHeroi.AutoSize = true;
            this.lbAtiviHeroi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAtiviHeroi.Location = new System.Drawing.Point(348, 221);
            this.lbAtiviHeroi.Name = "lbAtiviHeroi";
            this.lbAtiviHeroi.Size = new System.Drawing.Size(125, 13);
            this.lbAtiviHeroi.TabIndex = 40;
            this.lbAtiviHeroi.Text = "8. Atividade profissional *";
            // 
            // tbGrupo
            // 
            this.tbGrupo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbGrupo.Location = new System.Drawing.Point(104, 321);
            this.tbGrupo.Margin = new System.Windows.Forms.Padding(7, 15, 3, 25);
            this.tbGrupo.Name = "tbGrupo";
            this.tbGrupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGrupo.Size = new System.Drawing.Size(135, 20);
            this.tbGrupo.TabIndex = 9;
            this.tbGrupo.Tag = "Liga da Justiça, Vingad...";
            this.tbGrupo.Text = "Liga da Justiça, Vingad...";
            this.tbGrupo.Enter += new System.EventHandler(this.tbGrupo_Enter);
            this.tbGrupo.Leave += new System.EventHandler(this.tbGrupo_Leave);
            // 
            // lbGrupoHeroi
            // 
            this.lbGrupoHeroi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbGrupoHeroi.AutoSize = true;
            this.lbGrupoHeroi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbGrupoHeroi.Location = new System.Drawing.Point(101, 293);
            this.lbGrupoHeroi.Name = "lbGrupoHeroi";
            this.lbGrupoHeroi.Size = new System.Drawing.Size(55, 13);
            this.lbGrupoHeroi.TabIndex = 42;
            this.lbGrupoHeroi.Text = "9. Grupo *";
            // 
            // tbFraco
            // 
            this.tbFraco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFraco.Location = new System.Drawing.Point(249, 321);
            this.tbFraco.Margin = new System.Windows.Forms.Padding(7, 15, 3, 25);
            this.tbFraco.Name = "tbFraco";
            this.tbFraco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbFraco.Size = new System.Drawing.Size(100, 20);
            this.tbFraco.TabIndex = 10;
            this.tbFraco.Tag = "Kryptonita, Fogo...";
            this.tbFraco.Text = "Kryptonita, Fogo...";
            this.tbFraco.Enter += new System.EventHandler(this.tbFraco_Enter);
            this.tbFraco.Leave += new System.EventHandler(this.tbFraco_Leave);
            // 
            // lbFracoHeroi
            // 
            this.lbFracoHeroi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFracoHeroi.AutoSize = true;
            this.lbFracoHeroi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFracoHeroi.Location = new System.Drawing.Point(246, 293);
            this.lbFracoHeroi.Name = "lbFracoHeroi";
            this.lbFracoHeroi.Size = new System.Drawing.Size(90, 13);
            this.lbFracoHeroi.TabIndex = 44;
            this.lbFracoHeroi.Text = "10. Ponto Fraco *";
            // 
            // bt_enviar
            // 
            this.bt_enviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_enviar.BackColor = System.Drawing.Color.Transparent;
            this.bt_enviar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_enviar.FlatAppearance.BorderSize = 0;
            this.bt_enviar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.bt_enviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.bt_enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))));
            this.bt_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bt_enviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_enviar.Location = new System.Drawing.Point(263, 353);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.Size = new System.Drawing.Size(110, 31);
            this.bt_enviar.TabIndex = 46;
            this.bt_enviar.Text = "Enviar";
            this.bt_enviar.UseVisualStyleBackColor = false;
            this.bt_enviar.Click += new System.EventHandler(this.bt_enviar_Click);
            // 
            // FormHeroiCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.Add(this.bt_enviar);
            this.Controls.Add(this.tbFraco);
            this.Controls.Add(this.lbFracoHeroi);
            this.Controls.Add(this.tbGrupo);
            this.Controls.Add(this.lbGrupoHeroi);
            this.Controls.Add(this.tbAtiPro);
            this.Controls.Add(this.lbAtiviHeroi);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.lbFotoHeroi);
            this.Controls.Add(this.tbApelido);
            this.Controls.Add(this.lbApelidoHeroi);
            this.Controls.Add(this.tbParceiro);
            this.Controls.Add(this.lbParcHeroi);
            this.Controls.Add(this.tbPoder);
            this.Controls.Add(this.lbPoderHeroi);
            this.Controls.Add(this.tbPlaneta);
            this.Controls.Add(this.lbPlanetaHeroi);
            this.Controls.Add(this.dtpNasc);
            this.Controls.Add(this.lbNascHeroi);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmailHeroi);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNomeHeroi);
            this.Controls.Add(this.lbCadVilao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHeroiCad";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "FormHeroi";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.Label lbFotoHeroi;
        private System.Windows.Forms.TextBox tbApelido;
        private System.Windows.Forms.Label lbApelidoHeroi;
        private System.Windows.Forms.TextBox tbParceiro;
        private System.Windows.Forms.Label lbParcHeroi;
        private System.Windows.Forms.TextBox tbPoder;
        private System.Windows.Forms.Label lbPoderHeroi;
        private System.Windows.Forms.TextBox tbPlaneta;
        private System.Windows.Forms.Label lbPlanetaHeroi;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.Label lbNascHeroi;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmailHeroi;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNomeHeroi;
        private System.Windows.Forms.Label lbCadVilao;
        private System.Windows.Forms.TextBox tbAtiPro;
        private System.Windows.Forms.Label lbAtiviHeroi;
        private System.Windows.Forms.TextBox tbGrupo;
        private System.Windows.Forms.Label lbGrupoHeroi;
        private System.Windows.Forms.TextBox tbFraco;
        private System.Windows.Forms.Label lbFracoHeroi;
        private System.Windows.Forms.Button bt_enviar;
    }
}