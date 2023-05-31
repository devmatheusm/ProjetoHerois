namespace TrabalhoHerois.View.FormVilao
{
    partial class FormVilaoAtu
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
            this.cbAtuVilao = new System.Windows.Forms.ComboBox();
            this.btAtuVilao = new System.Windows.Forms.Button();
            this.lbAtuVilao = new System.Windows.Forms.Label();
            this.dgvAtuVilao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtuVilao)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAtuVilao
            // 
            this.cbAtuVilao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtuVilao.FormattingEnabled = true;
            this.cbAtuVilao.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbAtuVilao.Location = new System.Drawing.Point(73, 71);
            this.cbAtuVilao.Name = "cbAtuVilao";
            this.cbAtuVilao.Size = new System.Drawing.Size(261, 21);
            this.cbAtuVilao.TabIndex = 55;
            this.cbAtuVilao.SelectedIndexChanged += new System.EventHandler(this.cbAtuVilao_SelectedIndexChanged);
            // 
            // btAtuVilao
            // 
            this.btAtuVilao.Location = new System.Drawing.Point(377, 60);
            this.btAtuVilao.Name = "btAtuVilao";
            this.btAtuVilao.Size = new System.Drawing.Size(106, 41);
            this.btAtuVilao.TabIndex = 54;
            this.btAtuVilao.Text = "Atualizar";
            this.btAtuVilao.UseVisualStyleBackColor = true;
            this.btAtuVilao.Click += new System.EventHandler(this.btAtuVilao_Click);
            // 
            // lbAtuVilao
            // 
            this.lbAtuVilao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAtuVilao.AutoSize = true;
            this.lbAtuVilao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtuVilao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAtuVilao.Location = new System.Drawing.Point(164, 16);
            this.lbAtuVilao.Margin = new System.Windows.Forms.Padding(10);
            this.lbAtuVilao.Name = "lbAtuVilao";
            this.lbAtuVilao.Size = new System.Drawing.Size(301, 29);
            this.lbAtuVilao.TabIndex = 53;
            this.lbAtuVilao.Text = "Atualizar Cadastro do Vilao";
            // 
            // dgvAtuVilao
            // 
            this.dgvAtuVilao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtuVilao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtuVilao.Location = new System.Drawing.Point(12, 118);
            this.dgvAtuVilao.Name = "dgvAtuVilao";
            this.dgvAtuVilao.Size = new System.Drawing.Size(611, 266);
            this.dgvAtuVilao.TabIndex = 52;
            // 
            // FormVilaoAtu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.Add(this.cbAtuVilao);
            this.Controls.Add(this.btAtuVilao);
            this.Controls.Add(this.lbAtuVilao);
            this.Controls.Add(this.dgvAtuVilao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVilaoAtu";
            this.Text = "FormAtu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtuVilao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAtuVilao;
        private System.Windows.Forms.Button btAtuVilao;
        private System.Windows.Forms.Label lbAtuVilao;
        private System.Windows.Forms.DataGridView dgvAtuVilao;
    }
}