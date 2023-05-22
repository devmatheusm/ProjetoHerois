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
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(164, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 29);
            this.label1.TabIndex = 53;
            this.label1.Text = "Atualizar Cadastro do Heroi";
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
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAtuHeroi;
    }
}