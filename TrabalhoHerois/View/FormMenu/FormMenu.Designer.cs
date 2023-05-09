namespace TrabalhoHerois.View.FormMenu
{
    partial class FormMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_friend = new System.Windows.Forms.Button();
            this.bt_hero = new System.Windows.Forms.Button();
            this.bt_villain = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_min = new System.Windows.Forms.Button();
            this.bt_max = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.painelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.painelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bt_friend);
            this.panel1.Controls.Add(this.bt_hero);
            this.panel1.Controls.Add(this.bt_villain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 450);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TrabalhoHerois.Properties.Resources.hero_header;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bt_friend
            // 
            this.bt_friend.BackColor = System.Drawing.Color.Black;
            this.bt_friend.FlatAppearance.BorderSize = 0;
            this.bt_friend.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.bt_friend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_friend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_friend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_friend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_friend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_friend.Location = new System.Drawing.Point(0, 103);
            this.bt_friend.Name = "bt_friend";
            this.bt_friend.Size = new System.Drawing.Size(165, 53);
            this.bt_friend.TabIndex = 2;
            this.bt_friend.Text = "AMIGO DO HEROI ";
            this.bt_friend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_friend.UseVisualStyleBackColor = false;
            this.bt_friend.Click += new System.EventHandler(this.bt_friend_Click);
            // 
            // bt_hero
            // 
            this.bt_hero.BackColor = System.Drawing.Color.Black;
            this.bt_hero.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_hero.FlatAppearance.BorderSize = 0;
            this.bt_hero.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.bt_hero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.bt_hero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.bt_hero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_hero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_hero.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_hero.Location = new System.Drawing.Point(0, 50);
            this.bt_hero.Name = "bt_hero";
            this.bt_hero.Size = new System.Drawing.Size(165, 53);
            this.bt_hero.TabIndex = 1;
            this.bt_hero.Text = "SUPER-HEROI";
            this.bt_hero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_hero.UseVisualStyleBackColor = false;
            this.bt_hero.Click += new System.EventHandler(this.bt_hero_Click);
            // 
            // bt_villain
            // 
            this.bt_villain.BackColor = System.Drawing.Color.Black;
            this.bt_villain.FlatAppearance.BorderSize = 0;
            this.bt_villain.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.bt_villain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.bt_villain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.bt_villain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_villain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_villain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_villain.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_villain.Location = new System.Drawing.Point(0, 156);
            this.bt_villain.Margin = new System.Windows.Forms.Padding(0);
            this.bt_villain.Name = "bt_villain";
            this.bt_villain.Size = new System.Drawing.Size(165, 53);
            this.bt_villain.TabIndex = 3;
            this.bt_villain.Text = "SUPER-VILÃO";
            this.bt_villain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_villain.UseVisualStyleBackColor = false;
            this.bt_villain.Click += new System.EventHandler(this.bt_villain_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.bt_min);
            this.panel2.Controls.Add(this.bt_max);
            this.panel2.Controls.Add(this.bt_close);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(165, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 50);
            this.panel2.TabIndex = 1;
            // 
            // bt_min
            // 
            this.bt_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_min.BackgroundImage = global::TrabalhoHerois.Properties.Resources.MiniIcon;
            this.bt_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_min.FlatAppearance.BorderSize = 0;
            this.bt_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_min.Location = new System.Drawing.Point(572, 0);
            this.bt_min.Name = "bt_min";
            this.bt_min.Size = new System.Drawing.Size(17, 17);
            this.bt_min.TabIndex = 2;
            this.bt_min.UseVisualStyleBackColor = true;
            this.bt_min.Click += new System.EventHandler(this.minForm);
            // 
            // bt_max
            // 
            this.bt_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_max.BackgroundImage = global::TrabalhoHerois.Properties.Resources.maximize;
            this.bt_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_max.FlatAppearance.BorderSize = 0;
            this.bt_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_max.Location = new System.Drawing.Point(595, 0);
            this.bt_max.Name = "bt_max";
            this.bt_max.Size = new System.Drawing.Size(17, 17);
            this.bt_max.TabIndex = 1;
            this.bt_max.UseVisualStyleBackColor = true;
            this.bt_max.Click += new System.EventHandler(this.maxForm);
            // 
            // bt_close
            // 
            this.bt_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_close.BackgroundImage = global::TrabalhoHerois.Properties.Resources.closeIcon2;
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_close.FlatAppearance.BorderSize = 0;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close.Location = new System.Drawing.Point(618, 0);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(17, 17);
            this.bt_close.TabIndex = 0;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.CloseForm);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackgroundImage = global::TrabalhoHerois.Properties.Resources.hero_header;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(635, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // painelMenu
            // 
            this.painelMenu.Controls.Add(this.button1);
            this.painelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelMenu.Location = new System.Drawing.Point(165, 50);
            this.painelMenu.Name = "painelMenu";
            this.painelMenu.Size = new System.Drawing.Size(635, 400);
            this.painelMenu.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.painelMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario DC";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.painelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_villain;
        private System.Windows.Forms.Button bt_friend;
        private System.Windows.Forms.Button bt_hero;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel painelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bt_min;
        private System.Windows.Forms.Button bt_max;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button button1;
    }
}

