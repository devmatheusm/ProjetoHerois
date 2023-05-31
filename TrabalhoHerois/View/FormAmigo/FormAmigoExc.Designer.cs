namespace TrabalhoHerois.View.FormAmigo
{
    partial class FormAmigoExc
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
            this.lbExcAmigo = new System.Windows.Forms.Label();
            this.clbAmigo = new System.Windows.Forms.CheckedListBox();
            this.btExcAmigo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbExcAmigo
            // 
            this.lbExcAmigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbExcAmigo.AutoSize = true;
            this.lbExcAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExcAmigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbExcAmigo.Location = new System.Drawing.Point(171, 19);
            this.lbExcAmigo.Margin = new System.Windows.Forms.Padding(10);
            this.lbExcAmigo.Name = "lbExcAmigo";
            this.lbExcAmigo.Size = new System.Drawing.Size(293, 29);
            this.lbExcAmigo.TabIndex = 48;
            this.lbExcAmigo.Text = "Excluir do Amigo do Heroi";
            // 
            // clbAmigo
            // 
            this.clbAmigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clbAmigo.FormattingEnabled = true;
            this.clbAmigo.Items.AddRange(new object[] {
            ""});
            this.clbAmigo.Location = new System.Drawing.Point(12, 61);
            this.clbAmigo.Name = "clbAmigo";
            this.clbAmigo.Size = new System.Drawing.Size(611, 244);
            this.clbAmigo.TabIndex = 49;
            // 
            // btExcAmigo
            // 
            this.btExcAmigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btExcAmigo.BackColor = System.Drawing.Color.White;
            this.btExcAmigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExcAmigo.Location = new System.Drawing.Point(259, 325);
            this.btExcAmigo.Name = "btExcAmigo";
            this.btExcAmigo.Size = new System.Drawing.Size(121, 63);
            this.btExcAmigo.TabIndex = 50;
            this.btExcAmigo.Tag = "EXCLUIR";
            this.btExcAmigo.Text = "EXCLUIR";
            this.btExcAmigo.UseVisualStyleBackColor = false;
            this.btExcAmigo.Click += new System.EventHandler(this.btExcVilao_Click);
            // 
            // FormAmigoExc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.Add(this.btExcAmigo);
            this.Controls.Add(this.clbAmigo);
            this.Controls.Add(this.lbExcAmigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAmigoExc";
            this.Text = "FormAmigoExc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbExcAmigo;
        private System.Windows.Forms.CheckedListBox clbAmigo;
        private System.Windows.Forms.Button btExcAmigo;
    }
}