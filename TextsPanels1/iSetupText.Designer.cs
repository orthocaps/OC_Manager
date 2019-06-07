namespace ocManager.TextsPanels
{
    partial class iSetupText
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Language = new System.Windows.Forms.ComboBox();
            this.textBox_OKStages = new System.Windows.Forms.TextBox();
            this.textBox_UKStages = new System.Windows.Forms.TextBox();
            this.checkBox_Stripping = new System.Windows.Forms.CheckBox();
            this.checkBox_KLIIGZ = new System.Windows.Forms.CheckBox();
            this.checkBox_KLIIIGZ = new System.Windows.Forms.CheckBox();
            this.checkBox_Crowding = new System.Windows.Forms.CheckBox();
            this.checkBox_Spacing = new System.Windows.Forms.CheckBox();
            this.textBox_Ouput = new System.Windows.Forms.TextBox();
            this.button_MovetoClipboard = new System.Windows.Forms.Button();
            this.button_Generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "OK Stages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "UK Stages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Language";
            // 
            // comboBox_Language
            // 
            this.comboBox_Language.FormattingEnabled = true;
            this.comboBox_Language.Items.AddRange(new object[] {
            "German",
            "English",
            "French"});
            this.comboBox_Language.Location = new System.Drawing.Point(6, 29);
            this.comboBox_Language.Name = "comboBox_Language";
            this.comboBox_Language.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Language.TabIndex = 8;
            // 
            // textBox_OKStages
            // 
            this.textBox_OKStages.Location = new System.Drawing.Point(6, 73);
            this.textBox_OKStages.Name = "textBox_OKStages";
            this.textBox_OKStages.Size = new System.Drawing.Size(121, 20);
            this.textBox_OKStages.TabIndex = 9;
            // 
            // textBox_UKStages
            // 
            this.textBox_UKStages.Location = new System.Drawing.Point(7, 116);
            this.textBox_UKStages.Name = "textBox_UKStages";
            this.textBox_UKStages.Size = new System.Drawing.Size(120, 20);
            this.textBox_UKStages.TabIndex = 10;
            // 
            // checkBox_Stripping
            // 
            this.checkBox_Stripping.AutoSize = true;
            this.checkBox_Stripping.Location = new System.Drawing.Point(7, 142);
            this.checkBox_Stripping.Name = "checkBox_Stripping";
            this.checkBox_Stripping.Size = new System.Drawing.Size(67, 17);
            this.checkBox_Stripping.TabIndex = 11;
            this.checkBox_Stripping.Text = "Stripping";
            this.checkBox_Stripping.UseVisualStyleBackColor = true;
            // 
            // checkBox_KLIIGZ
            // 
            this.checkBox_KLIIGZ.AutoSize = true;
            this.checkBox_KLIIGZ.Location = new System.Drawing.Point(7, 166);
            this.checkBox_KLIIGZ.Name = "checkBox_KLIIGZ";
            this.checkBox_KLIIGZ.Size = new System.Drawing.Size(66, 17);
            this.checkBox_KLIIGZ.TabIndex = 12;
            this.checkBox_KLIIGZ.Text = "KL II GZ";
            this.checkBox_KLIIGZ.UseVisualStyleBackColor = true;
            // 
            // checkBox_KLIIIGZ
            // 
            this.checkBox_KLIIIGZ.AutoSize = true;
            this.checkBox_KLIIIGZ.Location = new System.Drawing.Point(7, 190);
            this.checkBox_KLIIIGZ.Name = "checkBox_KLIIIGZ";
            this.checkBox_KLIIIGZ.Size = new System.Drawing.Size(69, 17);
            this.checkBox_KLIIIGZ.TabIndex = 13;
            this.checkBox_KLIIIGZ.Text = "KL III GZ";
            this.checkBox_KLIIIGZ.UseVisualStyleBackColor = true;
            // 
            // checkBox_Crowding
            // 
            this.checkBox_Crowding.AutoSize = true;
            this.checkBox_Crowding.Location = new System.Drawing.Point(7, 214);
            this.checkBox_Crowding.Name = "checkBox_Crowding";
            this.checkBox_Crowding.Size = new System.Drawing.Size(70, 17);
            this.checkBox_Crowding.TabIndex = 14;
            this.checkBox_Crowding.Text = "Crowding";
            this.checkBox_Crowding.UseVisualStyleBackColor = true;
            // 
            // checkBox_Spacing
            // 
            this.checkBox_Spacing.AutoSize = true;
            this.checkBox_Spacing.Location = new System.Drawing.Point(7, 238);
            this.checkBox_Spacing.Name = "checkBox_Spacing";
            this.checkBox_Spacing.Size = new System.Drawing.Size(65, 17);
            this.checkBox_Spacing.TabIndex = 15;
            this.checkBox_Spacing.Text = "Spacing";
            this.checkBox_Spacing.UseVisualStyleBackColor = true;
            // 
            // textBox_Ouput
            // 
            this.textBox_Ouput.Location = new System.Drawing.Point(144, 29);
            this.textBox_Ouput.Multiline = true;
            this.textBox_Ouput.Name = "textBox_Ouput";
            this.textBox_Ouput.Size = new System.Drawing.Size(742, 516);
            this.textBox_Ouput.TabIndex = 16;
            // 
            // button_MovetoClipboard
            // 
            this.button_MovetoClipboard.Location = new System.Drawing.Point(893, 279);
            this.button_MovetoClipboard.Name = "button_MovetoClipboard";
            this.button_MovetoClipboard.Size = new System.Drawing.Size(134, 32);
            this.button_MovetoClipboard.TabIndex = 17;
            this.button_MovetoClipboard.Text = "Move to Clipboard";
            this.button_MovetoClipboard.UseVisualStyleBackColor = true;
            this.button_MovetoClipboard.Click += new System.EventHandler(this.Button_MovetoClipboard_Click);
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(7, 261);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(75, 23);
            this.button_Generate.TabIndex = 18;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.Button_Generate_Click);
            // 
            // iSetupText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.button_MovetoClipboard);
            this.Controls.Add(this.textBox_Ouput);
            this.Controls.Add(this.checkBox_Spacing);
            this.Controls.Add(this.checkBox_Crowding);
            this.Controls.Add(this.checkBox_KLIIIGZ);
            this.Controls.Add(this.checkBox_KLIIGZ);
            this.Controls.Add(this.checkBox_Stripping);
            this.Controls.Add(this.textBox_UKStages);
            this.Controls.Add(this.textBox_OKStages);
            this.Controls.Add(this.comboBox_Language);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "iSetupText";
            this.Size = new System.Drawing.Size(1046, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Language;
        private System.Windows.Forms.TextBox textBox_OKStages;
        private System.Windows.Forms.TextBox textBox_UKStages;
        private System.Windows.Forms.CheckBox checkBox_Stripping;
        private System.Windows.Forms.CheckBox checkBox_KLIIGZ;
        private System.Windows.Forms.CheckBox checkBox_KLIIIGZ;
        private System.Windows.Forms.CheckBox checkBox_Crowding;
        private System.Windows.Forms.CheckBox checkBox_Spacing;
        private System.Windows.Forms.TextBox textBox_Ouput;
        private System.Windows.Forms.Button button_MovetoClipboard;
        private System.Windows.Forms.Button button_Generate;
    }
}
