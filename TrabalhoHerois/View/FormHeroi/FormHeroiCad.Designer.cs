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
            this.label8 = new System.Windows.Forms.Label();
            this.tbApelido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbParceiro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPoder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPlaneta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cadVilao = new System.Windows.Forms.Label();
            this.tbAtiPro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGrupo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbFraco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
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
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(370, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "11. Foto do Heroi";
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
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(246, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "7. Apelido do Heroi *";
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
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(101, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "6. Parceiro Amoroso *";
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
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(439, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "5. Super Poder *";
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
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(324, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "4. Planeta de Origem *";
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(101, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "2. Ano de Nasc";
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(190, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "3. Email *";
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(101, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "1. Nome do Heroi *";
            // 
            // cadVilao
            // 
            this.cadVilao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cadVilao.AutoSize = true;
            this.cadVilao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadVilao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cadVilao.Location = new System.Drawing.Point(214, 20);
            this.cadVilao.Margin = new System.Windows.Forms.Padding(10);
            this.cadVilao.Name = "cadVilao";
            this.cadVilao.Size = new System.Drawing.Size(209, 29);
            this.cadVilao.TabIndex = 20;
            this.cadVilao.Text = "Cadastro do Heroi";
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
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(348, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "8. Atividade profissional *";
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
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(101, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "9. Grupo *";
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
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(246, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "10. Ponto Fraco *";
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
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbGrupo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbAtiPro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbApelido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbParceiro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPoder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPlaneta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNasc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cadVilao);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbApelido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbParceiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPoder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPlaneta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cadVilao;
        private System.Windows.Forms.TextBox tbAtiPro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbGrupo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbFraco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_enviar;
    }
}