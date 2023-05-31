namespace TrabalhoHerois.View.FormHeroi
{
    partial class FormHeroiAtu
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
            this.cbAtuHeroi = new System.Windows.Forms.ComboBox();
            this.btAtuHeroi = new System.Windows.Forms.Button();
            this.lbAtuHeroi = new System.Windows.Forms.Label();
            this.dgvAtuHeroi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtuHeroi)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAtuHeroi
            // 
            this.cbAtuHeroi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtuHeroi.FormattingEnabled = true;
            this.cbAtuHeroi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbAtuHeroi.Location = new System.Drawing.Point(73, 71);
            this.cbAtuHeroi.Name = "cbAtuHeroi";
            this.cbAtuHeroi.Size = new System.Drawing.Size(261, 21);
            this.cbAtuHeroi.TabIndex = 55;
            this.cbAtuHeroi.SelectedIndexChanged += new System.EventHandler(this.cbAtuHeroi_SelectedIndexChanged);
            // 
            // btAtuHeroi
            // 
            this.btAtuHeroi.Location = new System.Drawing.Point(377, 60);
            this.btAtuHeroi.Name = "btAtuHeroi";
            this.btAtuHeroi.Size = new System.Drawing.Size(106, 41);
            this.btAtuHeroi.TabIndex = 54;
            this.btAtuHeroi.Text = "Atualizar";
            this.btAtuHeroi.UseVisualStyleBackColor = true;
            this.btAtuHeroi.Click += new System.EventHandler(this.btAtuHeroi_Click);
            // 
            // lbAtuHeroi
            // 
            this.lbAtuHeroi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAtuHeroi.AutoSize = true;
            this.lbAtuHeroi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtuHeroi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAtuHeroi.Location = new System.Drawing.Point(164, 16);
            this.lbAtuHeroi.Margin = new System.Windows.Forms.Padding(10);
            this.lbAtuHeroi.Name = "lbAtuHeroi";
            this.lbAtuHeroi.Size = new System.Drawing.Size(306, 29);
            this.lbAtuHeroi.TabIndex = 53;
            this.lbAtuHeroi.Text = "Atualizar Cadastro do Heroi";
            // 
            // dgvAtuHeroi
            // 
            this.dgvAtuHeroi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtuHeroi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtuHeroi.Location = new System.Drawing.Point(12, 118);
            this.dgvAtuHeroi.Name = "dgvAtuHeroi";
            this.dgvAtuHeroi.Size = new System.Drawing.Size(611, 266);
            this.dgvAtuHeroi.TabIndex = 52;
            // 
            // FormHeroiAtu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.Add(this.cbAtuHeroi);
            this.Controls.Add(this.btAtuHeroi);
            this.Controls.Add(this.lbAtuHeroi);
            this.Controls.Add(this.dgvAtuHeroi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHeroiAtu";
            this.Text = "FormHeroiAtu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtuHeroi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAtuHeroi;
        private System.Windows.Forms.Button btAtuHeroi;
        private System.Windows.Forms.Label lbAtuHeroi;
        private System.Windows.Forms.DataGridView dgvAtuHeroi;
    }
}