namespace ocManager.TextsPanels
{
    partial class NoSubmission
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
            this.comboBox_Sex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar_Date = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Language = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Generate = new System.Windows.Forms.Button();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.button_MovetoClipboard = new System.Windows.Forms.Button();
            this.textBox_ClinicianName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_Sex
            // 
            this.comboBox_Sex.FormattingEnabled = true;
            this.comboBox_Sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_Sex.Location = new System.Drawing.Point(19, 95);
            this.comboBox_Sex.Name = "comboBox_Sex";
            this.comboBox_Sex.Size = new System.Drawing.Size(178, 21);
            this.comboBox_Sex.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sex";
            // 
            // monthCalendar_Date
            // 
            this.monthCalendar_Date.Location = new System.Drawing.Point(19, 182);
            this.monthCalendar_Date.MaxSelectionCount = 1;
            this.monthCalendar_Date.Name = "monthCalendar_Date";
            this.monthCalendar_Date.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // comboBox_Language
            // 
            this.comboBox_Language.FormattingEnabled = true;
            this.comboBox_Language.Items.AddRange(new object[] {
            "German",
            "English",
            "French"});
            this.comboBox_Language.Location = new System.Drawing.Point(19, 55);
            this.comboBox_Language.Name = "comboBox_Language";
            this.comboBox_Language.Size = new System.Drawing.Size(178, 21);
            this.comboBox_Language.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Language";
            // 
            // button_Generate
            // 
            this.button_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Generate.Location = new System.Drawing.Point(19, 357);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(178, 45);
            this.button_Generate.TabIndex = 6;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.Button_Generate_Click);
            // 
            // textBox_Output
            // 
            this.textBox_Output.Location = new System.Drawing.Point(203, 36);
            this.textBox_Output.Multiline = true;
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.Size = new System.Drawing.Size(651, 492);
            this.textBox_Output.TabIndex = 7;
            // 
            // button_MovetoClipboard
            // 
            this.button_MovetoClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MovetoClipboard.Location = new System.Drawing.Point(860, 246);
            this.button_MovetoClipboard.Name = "button_MovetoClipboard";
            this.button_MovetoClipboard.Size = new System.Drawing.Size(160, 57);
            this.button_MovetoClipboard.TabIndex = 8;
            this.button_MovetoClipboard.Text = "Copy to Clipboard";
            this.button_MovetoClipboard.UseVisualStyleBackColor = true;
            this.button_MovetoClipboard.Click += new System.EventHandler(this.Button_MovetoClipboard_Click);
            // 
            // textBox_ClinicianName
            // 
            this.textBox_ClinicianName.Location = new System.Drawing.Point(19, 135);
            this.textBox_ClinicianName.Name = "textBox_ClinicianName";
            this.textBox_ClinicianName.Size = new System.Drawing.Size(178, 20);
            this.textBox_ClinicianName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Clinician Name";
            // 
            // NoSubmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ClinicianName);
            this.Controls.Add(this.button_MovetoClipboard);
            this.Controls.Add(this.textBox_Output);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Language);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar_Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Sex);
            this.Name = "NoSubmission";
            this.Size = new System.Drawing.Size(1046, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Sex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Language;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.Button button_MovetoClipboard;
        private System.Windows.Forms.TextBox textBox_ClinicianName;
        private System.Windows.Forms.Label label4;
    }
}
