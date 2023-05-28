namespace TrabalhoHerois.View.FormAmigo
{
    partial class FormAmigoCon
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
            this.label1 = new System.Windows.Forms.Label();
            this.btPerIDAmigo = new System.Windows.Forms.Button();
            this.btConsGeralAmigo = new System.Windows.Forms.Button();
            this.dgvAmigo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbConIdAmigo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmigo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(173, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 49;
            this.label1.Text = "Consultar Amigo do Heroi";
            // 
            // btPerIDAmigo
            // 
            this.btPerIDAmigo.Location = new System.Drawing.Point(166, 0);
            this.btPerIDAmigo.Name = "btPerIDAmigo";
            this.btPerIDAmigo.Size = new System.Drawing.Size(80, 41);
            this.btPerIDAmigo.TabIndex = 51;
            this.btPerIDAmigo.Text = "CONSULTA POR ID";
            this.btPerIDAmigo.UseVisualStyleBackColor = true;
            this.btPerIDAmigo.Click += new System.EventHandler(this.btPerIDAmigo_Click);
            // 
            // btConsGeralAmigo
            // 
            this.btConsGeralAmigo.Location = new System.Drawing.Point(252, 0);
            this.btConsGeralAmigo.Name = "btConsGeralAmigo";
            this.btConsGeralAmigo.Size = new System.Drawing.Size(97, 41);
            this.btConsGeralAmigo.TabIndex = 52;
            this.btConsGeralAmigo.Text = "CONSULTA GERAL";
            this.btConsGeralAmigo.UseVisualStyleBackColor = true;
            this.btConsGeralAmigo.Click += new System.EventHandler(this.btConsGeralAmigo_Click);
            // 
            // dgvAmigo
            // 
            this.dgvAmigo.AllowUserToAddRows = false;
            this.dgvAmigo.AllowUserToDeleteRows = false;
            this.dgvAmigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAmigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAmigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmigo.Location = new System.Drawing.Point(3, 47);
            this.dgvAmigo.MultiSelect = false;
            this.dgvAmigo.Name = "dgvAmigo";
            this.dgvAmigo.ReadOnly = true;
            this.dgvAmigo.Size = new System.Drawing.Size(608, 274);
            this.dgvAmigo.TabIndex = 53;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbConIdAmigo);
            this.panel1.Controls.Add(this.btPerIDAmigo);
            this.panel1.Controls.Add(this.btConsGeralAmigo);
            this.panel1.Controls.Add(this.dgvAmigo);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 321);
            this.panel1.TabIndex = 54;
            // 
            // cbConIdAmigo
            // 
            this.cbConIdAmigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConIdAmigo.FormattingEnabled = true;
            this.cbConIdAmigo.Location = new System.Drawing.Point(3, 3);
            this.cbConIdAmigo.Name = "cbConIdAmigo";
            this.cbConIdAmigo.Size = new System.Drawing.Size(157, 21);
            this.cbConIdAmigo.TabIndex = 54;
            // 
            // FormAmigoCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAmigoCon";
            this.Text = "FormAmigoCon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmigo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPerIDAmigo;
        private System.Windows.Forms.Button btConsGeralAmigo;
        private System.Windows.Forms.DataGridView dgvAmigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbConIdAmigo;
    }
}