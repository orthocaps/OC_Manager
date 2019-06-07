namespace ocManager
{
    partial class MainView
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
            this.panel_Menue = new System.Windows.Forms.Panel();
            this.Button_Task = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_OpenLog = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_Settings = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_ActualPointer = new System.Windows.Forms.Panel();
            this.button_OpenTexts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_OpenTools = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_OpenExplorer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_Status = new System.Windows.Forms.Panel();
            this.Label_Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.panel_Menue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_OpenLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Settings)).BeginInit();
            this.panel_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menue
            // 
            this.panel_Menue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.panel_Menue.Controls.Add(this.Button_Task);
            this.panel_Menue.Controls.Add(this.button_OpenLog);
            this.panel_Menue.Controls.Add(this.button_Settings);
            this.panel_Menue.Controls.Add(this.panel_ActualPointer);
            this.panel_Menue.Controls.Add(this.button_OpenTexts);
            this.panel_Menue.Controls.Add(this.button_OpenTools);
            this.panel_Menue.Controls.Add(this.button_OpenExplorer);
            this.panel_Menue.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Menue.Location = new System.Drawing.Point(0, 0);
            this.panel_Menue.Name = "panel_Menue";
            this.panel_Menue.Size = new System.Drawing.Size(1264, 60);
            this.panel_Menue.TabIndex = 0;
            // 
            // Button_Task
            // 
            this.Button_Task.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.Button_Task.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Task.BorderRadius = 0;
            this.Button_Task.ButtonText = "Tasks";
            this.Button_Task.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Task.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Task.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Task.Iconimage = global::ocManager.Properties.Resources.baseline_list_white_48dp;
            this.Button_Task.Iconimage_right = null;
            this.Button_Task.Iconimage_right_Selected = null;
            this.Button_Task.Iconimage_Selected = null;
            this.Button_Task.IconMarginLeft = 0;
            this.Button_Task.IconMarginRight = 0;
            this.Button_Task.IconRightVisible = true;
            this.Button_Task.IconRightZoom = 0D;
            this.Button_Task.IconVisible = true;
            this.Button_Task.IconZoom = 70D;
            this.Button_Task.IsTab = false;
            this.Button_Task.Location = new System.Drawing.Point(601, 0);
            this.Button_Task.Name = "Button_Task";
            this.Button_Task.Normalcolor = System.Drawing.Color.Empty;
            this.Button_Task.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.Button_Task.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Task.selected = false;
            this.Button_Task.Size = new System.Drawing.Size(160, 44);
            this.Button_Task.TabIndex = 2;
            this.Button_Task.Text = "Tasks";
            this.Button_Task.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Task.Textcolor = System.Drawing.Color.White;
            this.Button_Task.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Task.Click += new System.EventHandler(this.Button_Task_Click);
            // 
            // button_OpenLog
            // 
            this.button_OpenLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.button_OpenLog.Image = global::ocManager.Properties.Resources.baseline_rate_review_white_48dp;
            this.button_OpenLog.ImageActive = null;
            this.button_OpenLog.Location = new System.Drawing.Point(1136, 12);
            this.button_OpenLog.Name = "button_OpenLog";
            this.button_OpenLog.Size = new System.Drawing.Size(40, 40);
            this.button_OpenLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_OpenLog.TabIndex = 1;
            this.button_OpenLog.TabStop = false;
            this.button_OpenLog.Zoom = 10;
            this.button_OpenLog.Click += new System.EventHandler(this.Button_OpenLog_Click);
            // 
            // button_Settings
            // 
            this.button_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.button_Settings.Image = global::ocManager.Properties.Resources.baseline_settings_white_48dp;
            this.button_Settings.ImageActive = null;
            this.button_Settings.Location = new System.Drawing.Point(1201, 12);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(40, 40);
            this.button_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Settings.TabIndex = 1;
            this.button_Settings.TabStop = false;
            this.button_Settings.Zoom = 10;
            // 
            // panel_ActualPointer
            // 
            this.panel_ActualPointer.BackColor = System.Drawing.Color.White;
            this.panel_ActualPointer.Location = new System.Drawing.Point(12, 49);
            this.panel_ActualPointer.Name = "panel_ActualPointer";
            this.panel_ActualPointer.Size = new System.Drawing.Size(160, 5);
            this.panel_ActualPointer.TabIndex = 0;
            // 
            // button_OpenTexts
            // 
            this.button_OpenTexts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_OpenTexts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_OpenTexts.BorderRadius = 0;
            this.button_OpenTexts.ButtonText = "Texts";
            this.button_OpenTexts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OpenTexts.DisabledColor = System.Drawing.Color.Gray;
            this.button_OpenTexts.Iconcolor = System.Drawing.Color.Transparent;
            this.button_OpenTexts.Iconimage = global::ocManager.Properties.Resources.baseline_subject_white_48dp;
            this.button_OpenTexts.Iconimage_right = null;
            this.button_OpenTexts.Iconimage_right_Selected = null;
            this.button_OpenTexts.Iconimage_Selected = null;
            this.button_OpenTexts.IconMarginLeft = 0;
            this.button_OpenTexts.IconMarginRight = 0;
            this.button_OpenTexts.IconRightVisible = true;
            this.button_OpenTexts.IconRightZoom = 0D;
            this.button_OpenTexts.IconVisible = true;
            this.button_OpenTexts.IconZoom = 70D;
            this.button_OpenTexts.IsTab = false;
            this.button_OpenTexts.Location = new System.Drawing.Point(205, 0);
            this.button_OpenTexts.Name = "button_OpenTexts";
            this.button_OpenTexts.Normalcolor = System.Drawing.Color.Empty;
            this.button_OpenTexts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_OpenTexts.OnHoverTextColor = System.Drawing.Color.White;
            this.button_OpenTexts.selected = false;
            this.button_OpenTexts.Size = new System.Drawing.Size(160, 44);
            this.button_OpenTexts.TabIndex = 0;
            this.button_OpenTexts.Text = "Texts";
            this.button_OpenTexts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_OpenTexts.Textcolor = System.Drawing.Color.White;
            this.button_OpenTexts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OpenTexts.Click += new System.EventHandler(this.Button_OpenTexts_Click);
            // 
            // button_OpenTools
            // 
            this.button_OpenTools.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_OpenTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_OpenTools.BorderRadius = 0;
            this.button_OpenTools.ButtonText = "Tools";
            this.button_OpenTools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OpenTools.DisabledColor = System.Drawing.Color.Gray;
            this.button_OpenTools.Iconcolor = System.Drawing.Color.Transparent;
            this.button_OpenTools.Iconimage = global::ocManager.Properties.Resources.baseline_build_white_48dp;
            this.button_OpenTools.Iconimage_right = null;
            this.button_OpenTools.Iconimage_right_Selected = null;
            this.button_OpenTools.Iconimage_Selected = null;
            this.button_OpenTools.IconMarginLeft = 0;
            this.button_OpenTools.IconMarginRight = 0;
            this.button_OpenTools.IconRightVisible = true;
            this.button_OpenTools.IconRightZoom = 0D;
            this.button_OpenTools.IconVisible = true;
            this.button_OpenTools.IconZoom = 70D;
            this.button_OpenTools.IsTab = false;
            this.button_OpenTools.Location = new System.Drawing.Point(397, 0);
            this.button_OpenTools.Name = "button_OpenTools";
            this.button_OpenTools.Normalcolor = System.Drawing.Color.Empty;
            this.button_OpenTools.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_OpenTools.OnHoverTextColor = System.Drawing.Color.White;
            this.button_OpenTools.selected = false;
            this.button_OpenTools.Size = new System.Drawing.Size(160, 44);
            this.button_OpenTools.TabIndex = 0;
            this.button_OpenTools.Text = "Tools";
            this.button_OpenTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_OpenTools.Textcolor = System.Drawing.Color.White;
            this.button_OpenTools.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OpenTools.Click += new System.EventHandler(this.Button_OpenTools_Click);
            // 
            // button_OpenExplorer
            // 
            this.button_OpenExplorer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_OpenExplorer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_OpenExplorer.BorderRadius = 0;
            this.button_OpenExplorer.ButtonText = "Explorer";
            this.button_OpenExplorer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OpenExplorer.DisabledColor = System.Drawing.Color.Gray;
            this.button_OpenExplorer.Iconcolor = System.Drawing.Color.Transparent;
            this.button_OpenExplorer.Iconimage = global::ocManager.Properties.Resources.baseline_explore_white_48dp;
            this.button_OpenExplorer.Iconimage_right = null;
            this.button_OpenExplorer.Iconimage_right_Selected = null;
            this.button_OpenExplorer.Iconimage_Selected = null;
            this.button_OpenExplorer.IconMarginLeft = 0;
            this.button_OpenExplorer.IconMarginRight = 0;
            this.button_OpenExplorer.IconRightVisible = true;
            this.button_OpenExplorer.IconRightZoom = 0D;
            this.button_OpenExplorer.IconVisible = true;
            this.button_OpenExplorer.IconZoom = 70D;
            this.button_OpenExplorer.IsTab = false;
            this.button_OpenExplorer.Location = new System.Drawing.Point(12, 0);
            this.button_OpenExplorer.Name = "button_OpenExplorer";
            this.button_OpenExplorer.Normalcolor = System.Drawing.Color.Empty;
            this.button_OpenExplorer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_OpenExplorer.OnHoverTextColor = System.Drawing.Color.White;
            this.button_OpenExplorer.selected = false;
            this.button_OpenExplorer.Size = new System.Drawing.Size(160, 44);
            this.button_OpenExplorer.TabIndex = 0;
            this.button_OpenExplorer.Text = "Explorer";
            this.button_OpenExplorer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_OpenExplorer.Textcolor = System.Drawing.Color.White;
            this.button_OpenExplorer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OpenExplorer.Click += new System.EventHandler(this.Button_OpenExplorer_Click);
            // 
            // panel_Status
            // 
            this.panel_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.panel_Status.Controls.Add(this.Label_Status);
            this.panel_Status.Controls.Add(this.label1);
            this.panel_Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Status.Location = new System.Drawing.Point(0, 653);
            this.panel_Status.Name = "panel_Status";
            this.panel_Status.Size = new System.Drawing.Size(1264, 28);
            this.panel_Status.TabIndex = 1;
            // 
            // Label_Status
            // 
            this.Label_Status.AutoSize = true;
            this.Label_Status.ForeColor = System.Drawing.Color.White;
            this.Label_Status.Location = new System.Drawing.Point(1081, 6);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(0, 13);
            this.Label_Status.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1035, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // panel_Content
            // 
            this.panel_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(0, 60);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1264, 593);
            this.panel_Content.TabIndex = 2;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.panel_Status);
            this.Controls.Add(this.panel_Menue);
            this.Name = "MainView";
            this.ShowIcon = false;
            this.Text = "Orthocaps Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.panel_Menue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_OpenLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Settings)).EndInit();
            this.panel_Status.ResumeLayout(false);
            this.panel_Status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menue;
        private System.Windows.Forms.Panel panel_Status;
        private System.Windows.Forms.Panel panel_Content;
        private Bunifu.Framework.UI.BunifuFlatButton button_OpenExplorer;
        private System.Windows.Forms.Panel panel_ActualPointer;
        private Bunifu.Framework.UI.BunifuFlatButton button_OpenTools;
        private Bunifu.Framework.UI.BunifuFlatButton button_OpenTexts;
        private System.Windows.Forms.Label Label_Status;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton button_Settings;
        private Bunifu.Framework.UI.BunifuImageButton button_OpenLog;
        private Bunifu.Framework.UI.BunifuFlatButton Button_Task;
    }
}

