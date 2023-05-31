namespace TrabalhoHerois.View.FormVilao
{
    partial class FormVilaoCon
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
            this.btPerIDVilao = new System.Windows.Forms.Button();
            this.pnConsVilao = new System.Windows.Forms.Panel();
            this.cbConIdVilao = new System.Windows.Forms.ComboBox();
            this.btConsGeralVilao = new System.Windows.Forms.Button();
            this.dgvVilaoCon = new System.Windows.Forms.DataGridView();
            this.lbConsVilao = new System.Windows.Forms.Label();
            this.pnConsVilao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVilaoCon)).BeginInit();
            this.SuspendLayout();
            // 
            // btPerIDVilao
            // 
            this.btPerIDVilao.Location = new System.Drawing.Point(166, 0);
            this.btPerIDVilao.Name = "btPerIDVilao";
            this.btPerIDVilao.Size = new System.Drawing.Size(80, 41);
            this.btPerIDVilao.TabIndex = 51;
            this.btPerIDVilao.Text = "CONSULTA POR ID";
            this.btPerIDVilao.UseVisualStyleBackColor = true;
            this.btPerIDVilao.Click += new System.EventHandler(this.btPerIDVilao_Click);
            // 
            // pnConsVilao
            // 
            this.pnConsVilao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnConsVilao.Controls.Add(this.cbConIdVilao);
            this.pnConsVilao.Controls.Add(this.btConsGeralVilao);
            this.pnConsVilao.Controls.Add(this.btPerIDVilao);
            this.pnConsVilao.Controls.Add(this.dgvVilaoCon);
            this.pnConsVilao.Location = new System.Drawing.Point(12, 61);
            this.pnConsVilao.Name = "pnConsVilao";
            this.pnConsVilao.Size = new System.Drawing.Size(611, 321);
            this.pnConsVilao.TabIndex = 57;
            // 
            // cbConIdVilao
            // 
            this.cbConIdVilao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConIdVilao.FormattingEnabled = true;
            this.cbConIdVilao.Location = new System.Drawing.Point(3, 3);
            this.cbConIdVilao.Name = "cbConIdVilao";
            this.cbConIdVilao.Size = new System.Drawing.Size(157, 21);
            this.cbConIdVilao.TabIndex = 55;
            // 
            // btConsGeralVilao
            // 
            this.btConsGeralVilao.Location = new System.Drawing.Point(252, 0);
            this.btConsGeralVilao.Name = "btConsGeralVilao";
            this.btConsGeralVilao.Size = new System.Drawing.Size(97, 41);
            this.btConsGeralVilao.TabIndex = 52;
            this.btConsGeralVilao.Text = "CONSULTA GERAL";
            this.btConsGeralVilao.UseVisualStyleBackColor = true;
            this.btConsGeralVilao.Click += new System.EventHandler(this.btConsGeralVilao_Click);
            // 
            // dgvVilaoCon
            // 
            this.dgvVilaoCon.AllowUserToAddRows = false;
            this.dgvVilaoCon.AllowUserToDeleteRows = false;
            this.dgvVilaoCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVilaoCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVilaoCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVilaoCon.Location = new System.Drawing.Point(0, 47);
            this.dgvVilaoCon.MultiSelect = false;
            this.dgvVilaoCon.Name = "dgvVilaoCon";
            this.dgvVilaoCon.ReadOnly = true;
            this.dgvVilaoCon.Size = new System.Drawing.Size(611, 274);
            this.dgvVilaoCon.TabIndex = 53;
            // 
            // lbConsVilao
            // 
            this.lbConsVilao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbConsVilao.AutoSize = true;
            this.lbConsVilao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsVilao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbConsVilao.Location = new System.Drawing.Point(230, 19);
            this.lbConsVilao.Margin = new System.Windows.Forms.Padding(10);
            this.lbConsVilao.Name = "lbConsVilao";
            this.lbConsVilao.Size = new System.Drawing.Size(175, 29);
            this.lbConsVilao.TabIndex = 59;
            this.lbConsVilao.Text = "Consultar Vilão";
            // 
            // FormVilaoCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.Add(this.lbConsVilao);
            this.Controls.Add(this.pnConsVilao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVilaoCon";
            this.Text = "FormVilaoCon";
            this.pnConsVilao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVilaoCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btPerIDVilao;
        private System.Windows.Forms.Panel pnConsVilao;
        private System.Windows.Forms.Button btConsGeralVilao;
        private System.Windows.Forms.DataGridView dgvVilaoCon;
        private System.Windows.Forms.Label lbConsVilao;
        private System.Windows.Forms.ComboBox cbConIdVilao;
    }
}