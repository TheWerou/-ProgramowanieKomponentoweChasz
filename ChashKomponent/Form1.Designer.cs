namespace ChashKomponent
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.LogButton = new System.Windows.Forms.Button();
            this.LogMenu = new System.Windows.Forms.TextBox();
            this.pKpassword1 = new PKpasswordLib.PKpassword();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Podaj hasło";
            // 
            // LogButton
            // 
            this.LogButton.Location = new System.Drawing.Point(14, 169);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(314, 31);
            this.LogButton.TabIndex = 6;
            this.LogButton.Text = "Sprawdz haslo";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogMenu
            // 
            this.LogMenu.Location = new System.Drawing.Point(14, 11);
            this.LogMenu.Multiline = true;
            this.LogMenu.Name = "LogMenu";
            this.LogMenu.ReadOnly = true;
            this.LogMenu.Size = new System.Drawing.Size(314, 56);
            this.LogMenu.TabIndex = 7;
            // 
            // pKpassword1
            // 
            this.pKpassword1.Location = new System.Drawing.Point(143, 110);
            this.pKpassword1.Name = "pKpassword1";
            this.pKpassword1.Size = new System.Drawing.Size(185, 38);
            this.pKpassword1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 73);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(314, 31);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 214);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pKpassword1);
            this.Controls.Add(this.LogMenu);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public PKpasswordLib.PKpassword GetPKpassword()
        {
            return this.pKpassword1;
        }

        #endregion
        private PKpasswordLib.PKpassword pKpassword1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.TextBox LogMenu;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

