namespace ocManager.TextsPanels
{
    partial class ReportText
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_ReportDE = new System.Windows.Forms.TextBox();
            this.textBox_ReportEN = new System.Windows.Forms.TextBox();
            this.textBox_ReportFR = new System.Windows.Forms.TextBox();
            this.button_ReportDE_MovetoClipboard = new System.Windows.Forms.Button();
            this.button_ReportEN_MovetoClipboard = new System.Windows.Forms.Button();
            this.button_ReportFR_MovetoClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ReportDE
            // 
            this.textBox_ReportDE.Location = new System.Drawing.Point(3, 74);
            this.textBox_ReportDE.Multiline = true;
            this.textBox_ReportDE.Name = "textBox_ReportDE";
            this.textBox_ReportDE.Size = new System.Drawing.Size(732, 130);
            this.textBox_ReportDE.TabIndex = 0;
            // 
            // textBox_ReportEN
            // 
            this.textBox_ReportEN.Location = new System.Drawing.Point(3, 210);
            this.textBox_ReportEN.Multiline = true;
            this.textBox_ReportEN.Name = "textBox_ReportEN";
            this.textBox_ReportEN.Size = new System.Drawing.Size(732, 130);
            this.textBox_ReportEN.TabIndex = 1;
            // 
            // textBox_ReportFR
            // 
            this.textBox_ReportFR.Location = new System.Drawing.Point(3, 346);
            this.textBox_ReportFR.Multiline = true;
            this.textBox_ReportFR.Name = "textBox_ReportFR";
            this.textBox_ReportFR.Size = new System.Drawing.Size(732, 130);
            this.textBox_ReportFR.TabIndex = 2;
            // 
            // button_ReportDE_MovetoClipboard
            // 
            this.button_ReportDE_MovetoClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ReportDE_MovetoClipboard.Location = new System.Drawing.Point(741, 74);
            this.button_ReportDE_MovetoClipboard.Name = "button_ReportDE_MovetoClipboard";
            this.button_ReportDE_MovetoClipboard.Size = new System.Drawing.Size(302, 130);
            this.button_ReportDE_MovetoClipboard.TabIndex = 3;
            this.button_ReportDE_MovetoClipboard.Text = "Copy to Clipboard";
            this.button_ReportDE_MovetoClipboard.UseVisualStyleBackColor = true;
            this.button_ReportDE_MovetoClipboard.Click += new System.EventHandler(this.Button_ReportDE_MovetoClipboard_Click);
            // 
            // button_ReportEN_MovetoClipboard
            // 
            this.button_ReportEN_MovetoClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ReportEN_MovetoClipboard.Location = new System.Drawing.Point(741, 210);
            this.button_ReportEN_MovetoClipboard.Name = "button_ReportEN_MovetoClipboard";
            this.button_ReportEN_MovetoClipboard.Size = new System.Drawing.Size(302, 130);
            this.button_ReportEN_MovetoClipboard.TabIndex = 4;
            this.button_ReportEN_MovetoClipboard.Text = "Copy to Clipboard";
            this.button_ReportEN_MovetoClipboard.UseVisualStyleBackColor = true;
            this.button_ReportEN_MovetoClipboard.Click += new System.EventHandler(this.Button_ReportEN_MovetoClipboard_Click);
            // 
            // button_ReportFR_MovetoClipboard
            // 
            this.button_ReportFR_MovetoClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ReportFR_MovetoClipboard.Location = new System.Drawing.Point(741, 346);
            this.button_ReportFR_MovetoClipboard.Name = "button_ReportFR_MovetoClipboard";
            this.button_ReportFR_MovetoClipboard.Size = new System.Drawing.Size(302, 130);
            this.button_ReportFR_MovetoClipboard.TabIndex = 5;
            this.button_ReportFR_MovetoClipboard.Text = "Copy to Clipboard";
            this.button_ReportFR_MovetoClipboard.UseVisualStyleBackColor = true;
            this.button_ReportFR_MovetoClipboard.Click += new System.EventHandler(this.Button_ReportFR_MovetoClipboard_Click);
            // 
            // ReportText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_ReportFR_MovetoClipboard);
            this.Controls.Add(this.button_ReportEN_MovetoClipboard);
            this.Controls.Add(this.button_ReportDE_MovetoClipboard);
            this.Controls.Add(this.textBox_ReportFR);
            this.Controls.Add(this.textBox_ReportEN);
            this.Controls.Add(this.textBox_ReportDE);
            this.Name = "ReportText";
            this.Size = new System.Drawing.Size(1046, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ReportDE;
        private System.Windows.Forms.TextBox textBox_ReportEN;
        private System.Windows.Forms.TextBox textBox_ReportFR;
        private System.Windows.Forms.Button button_ReportDE_MovetoClipboard;
        private System.Windows.Forms.Button button_ReportEN_MovetoClipboard;
        private System.Windows.Forms.Button button_ReportFR_MovetoClipboard;
    }
}
