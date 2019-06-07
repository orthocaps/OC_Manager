namespace ocManager.UserControls
{
    partial class ucTexts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_TextsContent = new System.Windows.Forms.Panel();
            this.listBox_TextsChoice = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // panel_TextsContent
            // 
            this.panel_TextsContent.Location = new System.Drawing.Point(215, 11);
            this.panel_TextsContent.Name = "panel_TextsContent";
            this.panel_TextsContent.Size = new System.Drawing.Size(1046, 570);
            this.panel_TextsContent.TabIndex = 3;
            // 
            // listBox_TextsChoice
            // 
            this.listBox_TextsChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_TextsChoice.FormattingEnabled = true;
            this.listBox_TextsChoice.ItemHeight = 20;
            this.listBox_TextsChoice.Items.AddRange(new object[] {
            "Report Text",
            "iSetup Text",
            "No Submisson",
            "Bad Impressions",
            "Impressions missing",
            "Attachment Request"});
            this.listBox_TextsChoice.Location = new System.Drawing.Point(3, 11);
            this.listBox_TextsChoice.Name = "listBox_TextsChoice";
            this.listBox_TextsChoice.Size = new System.Drawing.Size(206, 564);
            this.listBox_TextsChoice.TabIndex = 2;
            this.listBox_TextsChoice.SelectedIndexChanged += new System.EventHandler(this.ListBox_TextsChoice_SelectedIndexChanged_1);
            // 
            // ucTexts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_TextsContent);
            this.Controls.Add(this.listBox_TextsChoice);
            this.Name = "ucTexts";
            this.Size = new System.Drawing.Size(1264, 593);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_TextsContent;
        private System.Windows.Forms.ListBox listBox_TextsChoice;
    }
}
