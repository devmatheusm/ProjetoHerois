namespace TrabalhoHerois.View.FormVilao
{
    partial class FormVilaoExc
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
            this.clbVilao = new System.Windows.Forms.CheckedListBox();
            this.btExcVilao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(228, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "Excluir do Vilão";
            // 
            // clbVilao
            // 
            this.clbVilao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clbVilao.FormattingEnabled = true;
            this.clbVilao.Items.AddRange(new object[] {
            ""});
            this.clbVilao.Location = new System.Drawing.Point(12, 61);
            this.clbVilao.Name = "clbVilao";
            this.clbVilao.Size = new System.Drawing.Size(611, 244);
            this.clbVilao.TabIndex = 52;
            // 
            // btExcVilao
            // 
            this.btExcVilao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btExcVilao.BackColor = System.Drawing.Color.White;
            this.btExcVilao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExcVilao.Location = new System.Drawing.Point(259, 325);
            this.btExcVilao.Name = "btExcVilao";
            this.btExcVilao.Size = new System.Drawing.Size(121, 63);
            this.btExcVilao.TabIndex = 53;
            this.btExcVilao.Tag = "EXCLUIR";
            this.btExcVilao.Text = "EXCLUIR";
            this.btExcVilao.UseVisualStyleBackColor = false;
            this.btExcVilao.Click += new System.EventHandler(this.btExcAmigo_Click);
            // 
            // FormVilaoExc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.Add(this.btExcVilao);
            this.Controls.Add(this.clbVilao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVilaoExc";
            this.Text = "FormVilaoExc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbVilao;
        private System.Windows.Forms.Button btExcVilao;
    }
}