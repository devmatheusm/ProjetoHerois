namespace TrabalhoHerois.View.FormAmigo
{
    partial class FormAmigoAtu
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
            this.cbAtuAmigo = new System.Windows.Forms.ComboBox();
            this.btAtuAmigo = new System.Windows.Forms.Button();
            this.dgvAtuAmigo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtuAmigo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAtuAmigo
            // 
            this.cbAtuAmigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtuAmigo.FormattingEnabled = true;
            this.cbAtuAmigo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbAtuAmigo.Location = new System.Drawing.Point(73, 71);
            this.cbAtuAmigo.Name = "cbAtuAmigo";
            this.cbAtuAmigo.Size = new System.Drawing.Size(261, 21);
            this.cbAtuAmigo.TabIndex = 55;
            this.cbAtuAmigo.SelectedIndexChanged += new System.EventHandler(this.cbAtuAmigo_SelectedIndexChanged);
            // 
            // btAtuAmigo
            // 
            this.btAtuAmigo.Location = new System.Drawing.Point(377, 60);
            this.btAtuAmigo.Name = "btAtuAmigo";
            this.btAtuAmigo.Size = new System.Drawing.Size(106, 41);
            this.btAtuAmigo.TabIndex = 54;
            this.btAtuAmigo.Text = "Atualizar";
            this.btAtuAmigo.UseVisualStyleBackColor = true;
            this.btAtuAmigo.Click += new System.EventHandler(this.btAtuAmigo_Click);
            // 
            // dgvAtuAmigo
            // 
            this.dgvAtuAmigo.AllowUserToAddRows = false;
            this.dgvAtuAmigo.AllowUserToDeleteRows = false;
            this.dgvAtuAmigo.AllowUserToOrderColumns = true;
            this.dgvAtuAmigo.AllowUserToResizeColumns = false;
            this.dgvAtuAmigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtuAmigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtuAmigo.Location = new System.Drawing.Point(12, 118);
            this.dgvAtuAmigo.Name = "dgvAtuAmigo";
            this.dgvAtuAmigo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAtuAmigo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAtuAmigo.Size = new System.Drawing.Size(611, 266);
            this.dgvAtuAmigo.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(110, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 29);
            this.label2.TabIndex = 56;
            this.label2.Text = "Atualizar Cadastro do Amigo do Heroi";
            // 
            // FormAmigoAtu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAtuAmigo);
            this.Controls.Add(this.btAtuAmigo);
            this.Controls.Add(this.dgvAtuAmigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAmigoAtu";
            this.Text = "FormAmigoAtu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtuAmigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAtuAmigo;
        private System.Windows.Forms.Button btAtuAmigo;
        private System.Windows.Forms.DataGridView dgvAtuAmigo;
        private System.Windows.Forms.Label label2;
    }
}