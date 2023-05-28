namespace TrabalhoHerois.View.FormVilao
{
    partial class FormVilaoCad
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
            this.cadVilao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPlaneta = new System.Windows.Forms.TextBox();
            this.tbPoder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbParceiro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbApelido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btUpload = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.bt_enviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // cadVilao
            // 
            this.cadVilao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cadVilao.AutoSize = true;
            this.cadVilao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadVilao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cadVilao.Location = new System.Drawing.Point(218, 20);
            this.cadVilao.Margin = new System.Windows.Forms.Padding(10);
            this.cadVilao.Name = "cadVilao";
            this.cadVilao.Size = new System.Drawing.Size(204, 29);
            this.cadVilao.TabIndex = 0;
            this.cadVilao.Text = "Cadastro do Vilão";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(101, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Nome do Vilão *";
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(190, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "3. Email *";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbEmail.Location = new System.Drawing.Point(193, 176);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(6, 15, 0, 25);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEmail.Size = new System.Drawing.Size(340, 20);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Tag = "example@dominio.com";
            this.tbEmail.Text = "example@dominio.com";
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // dtpNasc
            // 
            this.dtpNasc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNasc.CustomFormat = "yyyy";
            this.dtpNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNasc.Location = new System.Drawing.Point(104, 176);
            this.dtpNasc.Margin = new System.Windows.Forms.Padding(3, 15, 3, 25);
            this.dtpNasc.Name = "dtpNasc";
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
            this.label3.TabIndex = 7;
            this.label3.Text = "2. Ano de Nasc";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(101, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "4. Planeta de Origem *";
            // 
            // tbPlaneta
            // 
            this.tbPlaneta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPlaneta.Location = new System.Drawing.Point(104, 249);
            this.tbPlaneta.Margin = new System.Windows.Forms.Padding(3, 15, 3, 25);
            this.tbPlaneta.Name = "tbPlaneta";
            this.tbPlaneta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPlaneta.Size = new System.Drawing.Size(136, 20);
            this.tbPlaneta.TabIndex = 4;
            this.tbPlaneta.Tag = "Terra, Jupiter, Marte...";
            this.tbPlaneta.Text = "Terra, Jupiter, Marte...";
            this.tbPlaneta.Enter += new System.EventHandler(this.tbPlaneta_Enter);
            this.tbPlaneta.Leave += new System.EventHandler(this.tbPlaneta_Leave);
            // 
            // tbPoder
            // 
            this.tbPoder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPoder.Location = new System.Drawing.Point(250, 249);
            this.tbPoder.Margin = new System.Windows.Forms.Padding(7, 15, 3, 25);
            this.tbPoder.Name = "tbPoder";
            this.tbPoder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPoder.Size = new System.Drawing.Size(136, 20);
            this.tbPoder.TabIndex = 5;
            this.tbPoder.Tag = "Voar, Super Força...";
            this.tbPoder.Text = "Voar, Super Força...";
            this.tbPoder.Enter += new System.EventHandler(this.tbPoder_Enter);
            this.tbPoder.Leave += new System.EventHandler(this.tbPoder_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(247, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "5. Super Poder *";
            // 
            // tbParceiro
            // 
            this.tbParceiro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbParceiro.Location = new System.Drawing.Point(398, 249);
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
            this.label6.Location = new System.Drawing.Point(395, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "6. Parceiro Amoroso *";
            // 
            // tbApelido
            // 
            this.tbApelido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbApelido.Location = new System.Drawing.Point(104, 322);
            this.tbApelido.Margin = new System.Windows.Forms.Padding(3, 15, 3, 25);
            this.tbApelido.Name = "tbApelido";
            this.tbApelido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbApelido.Size = new System.Drawing.Size(155, 20);
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
            this.label7.Location = new System.Drawing.Point(101, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "7. Apelido do Vilão *";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(370, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "8. Foto do Vilão";
            // 
            // btUpload
            // 
            this.btUpload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btUpload.BackColor = System.Drawing.Color.Purple;
            this.btUpload.FlatAppearance.BorderSize = 0;
            this.btUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpload.Image = global::TrabalhoHerois.Properties.Resources.uploadIcon;
            this.btUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUpload.Location = new System.Drawing.Point(376, 314);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(72, 32);
            this.btUpload.TabIndex = 8;
            this.btUpload.Text = "Image";
            this.btUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUpload.UseVisualStyleBackColor = false;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
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
            this.pbFoto.TabIndex = 19;
            this.pbFoto.TabStop = false;
            // 
            // bt_enviar
            // 
            this.bt_enviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_enviar.BackColor = System.Drawing.Color.Transparent;
            this.bt_enviar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_enviar.FlatAppearance.BorderSize = 0;
            this.bt_enviar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.bt_enviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.bt_enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(0)))), ((int)(((byte)(163)))));
            this.bt_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bt_enviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_enviar.Location = new System.Drawing.Point(263, 353);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.Size = new System.Drawing.Size(110, 31);
            this.bt_enviar.TabIndex = 20;
            this.bt_enviar.Text = "Enviar";
            this.bt_enviar.UseVisualStyleBackColor = false;
            this.bt_enviar.Click += new System.EventHandler(this.bt_enviar_Click);
            // 
            // FormVilaoCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.Add(this.bt_enviar);
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
            this.Name = "FormVilaoCad";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FormVilao";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cadVilao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPlaneta;
        private System.Windows.Forms.TextBox tbPoder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbParceiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbApelido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button bt_enviar;
    }
}