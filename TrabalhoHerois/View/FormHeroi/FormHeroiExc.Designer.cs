namespace TrabalhoHerois.View.FormHeroi
{
    partial class FormHeroiExc
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
            this.clbHeroi = new System.Windows.Forms.CheckedListBox();
            this.btExcAmigo = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "Excluir do Heroi";
            // 
            // clbHeroi
            // 
            this.clbHeroi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clbHeroi.FormattingEnabled = true;
            this.clbHeroi.Items.AddRange(new object[] {
            ""});
            this.clbHeroi.Location = new System.Drawing.Point(12, 61);
            this.clbHeroi.Name = "clbHeroi";
            this.clbHeroi.Size = new System.Drawing.Size(611, 244);
            this.clbHeroi.TabIndex = 53;
            // 
            // btExcAmigo
            // 
            this.btExcAmigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btExcAmigo.BackColor = System.Drawing.Color.White;
            this.btExcAmigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExcAmigo.Location = new System.Drawing.Point(259, 325);
            this.btExcAmigo.Name = "btExcAmigo";
            this.btExcAmigo.Size = new System.Drawing.Size(121, 63);
            this.btExcAmigo.TabIndex = 54;
            this.btExcAmigo.Tag = "EXCLUIR";
            this.btExcAmigo.Text = "EXCLUIR";
            this.btExcAmigo.UseVisualStyleBackColor = false;
            this.btExcAmigo.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHeroiExc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.Add(this.btExcAmigo);
            this.Controls.Add(this.clbHeroi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHeroiExc";
            this.Tag = "";
            this.Text = "FormHeroiExc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbHeroi;
        private System.Windows.Forms.Button btExcAmigo;
    }
}