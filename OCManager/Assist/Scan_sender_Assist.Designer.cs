namespace ocManager.Assist
{
    partial class Scan_sender_Assist
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
            this.label_CaseID = new System.Windows.Forms.Label();
            this.label_ScanAssist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_CaseID
            // 
            this.label_CaseID.AutoSize = true;
            this.label_CaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CaseID.Location = new System.Drawing.Point(266, 9);
            this.label_CaseID.Name = "label_CaseID";
            this.label_CaseID.Size = new System.Drawing.Size(59, 20);
            this.label_CaseID.TabIndex = 0;
            this.label_CaseID.Text = "01234";
            // 
            // label_ScanAssist
            // 
            this.label_ScanAssist.AutoSize = true;
            this.label_ScanAssist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ScanAssist.Location = new System.Drawing.Point(12, 9);
            this.label_ScanAssist.Name = "label_ScanAssist";
            this.label_ScanAssist.Size = new System.Drawing.Size(104, 20);
            this.label_ScanAssist.TabIndex = 1;
            this.label_ScanAssist.Text = "Scan Assist";
            // 
            // Scan_sender_Assist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.label_ScanAssist);
            this.Controls.Add(this.label_CaseID);
            this.Name = "Scan_sender_Assist";
            this.ShowIcon = false;
            this.Text = "Scan sender Assist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CaseID;
        private System.Windows.Forms.Label label_ScanAssist;
    }
}