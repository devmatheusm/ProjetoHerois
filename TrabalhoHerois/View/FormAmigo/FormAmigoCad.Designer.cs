namespace TrabalhoHerois.View.FormAmigo
{
    partial class FormAmigoCad
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
            this.tbHobby = new System.Windows.Forms.TextBox();
            this.lbHobbyAmigo = new System.Windows.Forms.Label();
            this.tbAtiPro = new System.Windows.Forms.TextBox();
            this.lbAtiviAmigo = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btUpload = new System.Windows.Forms.Button();
            this.lbFotoAmigo = new System.Windows.Forms.Label();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.lbNascAmigo = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmailAmigo = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNomeAmigo = new System.Windows.Forms.Label();
            this.lbCadVilao = new System.Windows.Forms.Label();
            this.bt_enviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHobby
            // 
            this.tbHobby.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbHobby.Location = new System.Drawing.Point(164, 249);
            this.tbHobby.Margin = new System.Windows.Forms.Padding(7, 15, 3, 25);
            this.tbHobby.Name = "tbHobby";
            this.tbHobby.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbHobby.Size = new System.Drawing.Size(135, 20);
            this.tbHobby.TabIndex = 5;
            this.tbHobby.Tag = "Pescar, Malhar,  Correr...";
            this.tbHobby.Text = "Pescar, Malhar,  Correr...";
            this.tbHobby.Enter += new System.EventHandler(this.tbHobby_Enter);
            this.tbHobby.Leave += new System.EventHandler(this.tbHobby_Leave);
            // 
            // lbHobbyAmigo
            // 
            this.lbHobbyAmigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHobbyAmigo.AutoSize = true;
            this.lbHobbyAmigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbHobbyAmigo.Location = new System.Drawing.Point(161, 221);
            this.lbHobbyAmigo.Name = "lbHobbyAmigo";
            this.lbHobbyAmigo.Size = new System.Drawing.Size(57, 13);
            this.lbHobbyAmigo.TabIndex = 68;
            this.lbHobbyAmigo.Text = "5. Hobby *";
            // 
            // tbAtiPro
            // 
            this.tbAtiPro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAtiPro.Location = new System.Drawing.Point(327, 176);
            this.tbAtiPro.Margin = new System.Windows.Forms.Padding(7, 15, 3, 25);
            this.tbAtiPro.Name = "tbAtiPro";
            this.tbAtiPro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAtiPro.Size = new System.Drawing.Size(182, 20);
            this.tbAtiPro.TabIndex = 4;
            this.tbAtiPro.Tag = "Jornalista, Delegado,  Cientista...";
            this.tbAtiPro.Text = "Jornalista, Delegado,  Cientista...";
            this.tbAtiPro.Enter += new System.EventHandler(this.tbAtiPro_Enter);
            this.tbAtiPro.Leave += new System.EventHandler(this.tbAtiPro_Leave);
            // 
            // lbAtiviAmigo
            // 
            this.lbAtiviAmigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAtiviAmigo.AutoSize = true;
            this.lbAtiviAmigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAtiviAmigo.Location = new System.Drawing.Point(324, 148);
            this.lbAtiviAmigo.Name = "lbAtiviAmigo";
            this.lbAtiviAmigo.Size = new System.Drawing.Size(125, 13);
            this.lbAtiviAmigo.TabIndex = 66;
            this.lbAtiviAmigo.Text = "4. Atividade profissional *";
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(411, 205);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(73, 73);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 65;
            this.pbFoto.TabStop = false;
            // 
            // btUpload
            // 
            this.btUpload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btUpload.FlatAppearance.BorderSize = 0;
            this.btUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpload.Image = global::TrabalhoHerois.Properties.Resources.uploadIcon;
            this.btUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUpload.Location = new System.Drawing.Point(327, 237);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(72, 32);
            this.btUpload.TabIndex = 64;
            this.btUpload.Text = "Image";
            this.btUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUpload.UseVisualStyleBackColor = false;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // lbFotoAmigo
            // 
            this.lbFotoAmigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFotoAmigo.AutoSize = true;
            this.lbFotoAmigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFotoAmigo.Location = new System.Drawing.Point(321, 216);
            this.lbFotoAmigo.Name = "lbFotoAmigo";
            this.lbFotoAmigo.Size = new System.Drawing.Size(87, 13);
            this.lbFotoAmigo.TabIndex = 63;
            this.lbFotoAmigo.Text = "8. Foto do Amigo";
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
            // lbNascAmigo
            // 
            this.lbNascAmigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNascAmigo.AutoSize = true;
            this.lbNascAmigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNascAmigo.Location = new System.Drawing.Point(101, 148);
            this.lbNascAmigo.Name = "lbNascAmigo";
            this.lbNascAmigo.Size = new System.Drawing.Size(81, 13);
            this.lbNascAmigo.TabIndex = 53;
            this.lbNascAmigo.Text = "2. Ano de Nasc";
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
            // lbEmailAmigo
            // 
            this.lbEmailAmigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEmailAmigo.AutoSize = true;
            this.lbEmailAmigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEmailAmigo.Location = new System.Drawing.Point(190, 148);
            this.lbEmailAmigo.Name = "lbEmailAmigo";
            this.lbEmailAmigo.Size = new System.Drawing.Size(51, 13);
            this.lbEmailAmigo.TabIndex = 51;
            this.lbEmailAmigo.Text = "3. Email *";
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNome.Location = new System.Drawing.Point(104, 103);
            this.tbNome.Margin = new System.Windows.Forms.Padding(0, 15, 0, 25);
            this.tbNome.Name = "tbNome";
            this.tbNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNome.Size = new System.Drawing.Size(405, 20);
            this.tbNome.TabIndex = 1;
            this.tbNome.Tag = "Nome Completo";
            this.tbNome.Text = "Nome Completo";
            this.tbNome.Enter += new System.EventHandler(this.tbNome_Enter);
            this.tbNome.Leave += new System.EventHandler(this.tbNome_Leave);
            // 
            // lbNomeAmigo
            // 
            this.lbNomeAmigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNomeAmigo.AutoSize = true;
            this.lbNomeAmigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNomeAmigo.Location = new System.Drawing.Point(101, 75);
            this.lbNomeAmigo.Name = "lbNomeAmigo";
            this.lbNomeAmigo.Size = new System.Drawing.Size(144, 13);
            this.lbNomeAmigo.TabIndex = 47;
            this.lbNomeAmigo.Text = "1. Nome do Amigo do Heroi *";
            // 
            // lbCadVilao
            // 
            this.lbCadVilao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCadVilao.AutoSize = true;
            this.lbCadVilao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadVilao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCadVilao.Location = new System.Drawing.Point(159, 20);
            this.lbCadVilao.Margin = new System.Windows.Forms.Padding(10);
            this.lbCadVilao.Name = "lbCadVilao";
            this.lbCadVilao.Size = new System.Drawing.Size(318, 29);
            this.lbCadVilao.TabIndex = 46;
            this.lbCadVilao.Text = "Cadastro do Amigo do Heroi";
            // 
            // bt_enviar
            // 
            this.bt_enviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_enviar.BackColor = System.Drawing.Color.Transparent;
            this.bt_enviar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_enviar.FlatAppearance.BorderSize = 0;
            this.bt_enviar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.bt_enviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bt_enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bt_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bt_enviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_enviar.Location = new System.Drawing.Point(263, 353);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.Size = new System.Drawing.Size(110, 31);
            this.bt_enviar.TabIndex = 70;
            this.bt_enviar.Text = "Enviar";
            this.bt_enviar.UseVisualStyleBackColor = false;
            this.bt_enviar.Click += new System.EventHandler(this.bt_enviar_Click);
            // 
            // FormAmigoCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.Add(this.bt_enviar);
            this.Controls.Add(this.tbHobby);
            this.Controls.Add(this.lbHobbyAmigo);
            this.Controls.Add(this.tbAtiPro);
            this.Controls.Add(this.lbAtiviAmigo);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.lbFotoAmigo);
            this.Controls.Add(this.dtpNasc);
            this.Controls.Add(this.lbNascAmigo);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmailAmigo);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNomeAmigo);
            this.Controls.Add(this.lbCadVilao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAmigoCad";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbHobby;
        private System.Windows.Forms.Label lbHobbyAmigo;
        private System.Windows.Forms.TextBox tbAtiPro;
        private System.Windows.Forms.Label lbAtiviAmigo;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.Label lbFotoAmigo;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.Label lbNascAmigo;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmailAmigo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNomeAmigo;
        private System.Windows.Forms.Label lbCadVilao;
        private System.Windows.Forms.Button bt_enviar;
    }
}