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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbConIdVilao = new System.Windows.Forms.ComboBox();
            this.btConsGeralVilao = new System.Windows.Forms.Button();
            this.dgvVilaoCon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbConIdVilao);
            this.panel1.Controls.Add(this.btConsGeralVilao);
            this.panel1.Controls.Add(this.btPerIDVilao);
            this.panel1.Controls.Add(this.dgvVilaoCon);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 321);
            this.panel1.TabIndex = 57;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(230, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "Consultar Vilão";
            // 
            // FormVilaoCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVilaoCon";
            this.Text = "FormVilaoCon";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVilaoCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btPerIDVilao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btConsGeralVilao;
        private System.Windows.Forms.DataGridView dgvVilaoCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConIdVilao;
    }
}