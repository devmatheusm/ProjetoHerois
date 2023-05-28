namespace TrabalhoHerois.View.FormHeroi
{
    partial class FormHeroiCon
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
            this.dgvHeroi = new System.Windows.Forms.DataGridView();
            this.btConsGeralHeroi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbConIdHeroi = new System.Windows.Forms.ComboBox();
            this.btPerIDHeroi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeroi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHeroi
            // 
            this.dgvHeroi.AllowUserToAddRows = false;
            this.dgvHeroi.AllowUserToDeleteRows = false;
            this.dgvHeroi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHeroi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHeroi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeroi.Location = new System.Drawing.Point(0, 47);
            this.dgvHeroi.MultiSelect = false;
            this.dgvHeroi.Name = "dgvHeroi";
            this.dgvHeroi.ReadOnly = true;
            this.dgvHeroi.Size = new System.Drawing.Size(608, 274);
            this.dgvHeroi.TabIndex = 53;
            // 
            // btConsGeralHeroi
            // 
            this.btConsGeralHeroi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btConsGeralHeroi.Location = new System.Drawing.Point(366, 0);
            this.btConsGeralHeroi.Name = "btConsGeralHeroi";
            this.btConsGeralHeroi.Size = new System.Drawing.Size(97, 41);
            this.btConsGeralHeroi.TabIndex = 52;
            this.btConsGeralHeroi.Text = "CONSULTA GERAL";
            this.btConsGeralHeroi.UseVisualStyleBackColor = true;
            this.btConsGeralHeroi.Click += new System.EventHandler(this.btConsGeralAmigo_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbConIdHeroi);
            this.panel1.Controls.Add(this.btPerIDHeroi);
            this.panel1.Controls.Add(this.btConsGeralHeroi);
            this.panel1.Controls.Add(this.dgvHeroi);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 321);
            this.panel1.TabIndex = 57;
            // 
            // cbConIdHeroi
            // 
            this.cbConIdHeroi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConIdHeroi.FormattingEnabled = true;
            this.cbConIdHeroi.Location = new System.Drawing.Point(3, 3);
            this.cbConIdHeroi.Name = "cbConIdHeroi";
            this.cbConIdHeroi.Size = new System.Drawing.Size(157, 21);
            this.cbConIdHeroi.TabIndex = 55;
            // 
            // btPerIDHeroi
            // 
            this.btPerIDHeroi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btPerIDHeroi.Location = new System.Drawing.Point(166, 0);
            this.btPerIDHeroi.Name = "btPerIDHeroi";
            this.btPerIDHeroi.Size = new System.Drawing.Size(80, 41);
            this.btPerIDHeroi.TabIndex = 51;
            this.btPerIDHeroi.Text = "CONSULTA POR ID";
            this.btPerIDHeroi.UseVisualStyleBackColor = true;
            this.btPerIDHeroi.Click += new System.EventHandler(this.btPerIDHeroi_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(227, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "Consultar Heroi";
            // 
            // FormHeroiCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHeroiCon";
            this.Text = "FormHeroiCon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeroi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHeroi;
        private System.Windows.Forms.Button btConsGeralHeroi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btPerIDHeroi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConIdHeroi;
    }
}