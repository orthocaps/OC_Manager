namespace ocManager.UserControls
{
    partial class ucExplorer
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
            this.listbox_AllCases = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_SearchInTextbox = new System.Windows.Forms.TextBox();
            this.listView_Explorer = new System.Windows.Forms.ListView();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_LastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_FileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_FileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_SendScans = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_GetData = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_Back = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_OpenCaseFolder = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_EditCaseFolder = new Bunifu.Framework.UI.BunifuImageButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_DragDrop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_Assist = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.button_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_OpenCaseFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_EditCaseFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // listbox_AllCases
            // 
            this.listbox_AllCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_AllCases.FormattingEnabled = true;
            this.listbox_AllCases.ItemHeight = 20;
            this.listbox_AllCases.Location = new System.Drawing.Point(12, 55);
            this.listbox_AllCases.Name = "listbox_AllCases";
            this.listbox_AllCases.Size = new System.Drawing.Size(320, 524);
            this.listbox_AllCases.TabIndex = 1;
            this.listbox_AllCases.SelectedIndexChanged += new System.EventHandler(this.Listbox_AllCases_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // textbox_SearchInTextbox
            // 
            this.textbox_SearchInTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_SearchInTextbox.Location = new System.Drawing.Point(12, 29);
            this.textbox_SearchInTextbox.Name = "textbox_SearchInTextbox";
            this.textbox_SearchInTextbox.Size = new System.Drawing.Size(156, 22);
            this.textbox_SearchInTextbox.TabIndex = 0;
            this.textbox_SearchInTextbox.TextChanged += new System.EventHandler(this.Textbox_SearchInTextbox_TextChanged);
            // 
            // listView_Explorer
            // 
            this.listView_Explorer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name,
            this.columnHeader_LastModified,
            this.columnHeader_FileType,
            this.columnHeader_FileSize});
            this.listView_Explorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Explorer.Location = new System.Drawing.Point(366, 55);
            this.listView_Explorer.Name = "listView_Explorer";
            this.listView_Explorer.Size = new System.Drawing.Size(628, 524);
            this.listView_Explorer.TabIndex = 2;
            this.listView_Explorer.UseCompatibleStateImageBehavior = false;
            this.listView_Explorer.View = System.Windows.Forms.View.Details;
            this.listView_Explorer.DragLeave += new System.EventHandler(this.ListView_Explorer_DragLeave);
            this.listView_Explorer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView_Explorer_KeyDown);
            this.listView_Explorer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Explorer_MouseDoubleClick_1);
            this.listView_Explorer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListView_Explorer_MouseMove);
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 211;
            // 
            // columnHeader_LastModified
            // 
            this.columnHeader_LastModified.Text = "Last Modified";
            this.columnHeader_LastModified.Width = 133;
            // 
            // columnHeader_FileType
            // 
            this.columnHeader_FileType.Text = "Type";
            // 
            // columnHeader_FileSize
            // 
            this.columnHeader_FileSize.Text = "File Size";
            this.columnHeader_FileSize.Width = 108;
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(451, 32);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(429, 20);
            this.textBox_Path.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path:";
            // 
            // button_SendScans
            // 
            this.button_SendScans.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_SendScans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_SendScans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SendScans.BorderRadius = 0;
            this.button_SendScans.ButtonText = "Send Scans";
            this.button_SendScans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SendScans.DisabledColor = System.Drawing.Color.Gray;
            this.button_SendScans.Iconcolor = System.Drawing.Color.Transparent;
            this.button_SendScans.Iconimage = null;
            this.button_SendScans.Iconimage_right = null;
            this.button_SendScans.Iconimage_right_Selected = null;
            this.button_SendScans.Iconimage_Selected = null;
            this.button_SendScans.IconMarginLeft = 0;
            this.button_SendScans.IconMarginRight = 0;
            this.button_SendScans.IconRightVisible = true;
            this.button_SendScans.IconRightZoom = 0D;
            this.button_SendScans.IconVisible = true;
            this.button_SendScans.IconZoom = 70D;
            this.button_SendScans.IsTab = false;
            this.button_SendScans.Location = new System.Drawing.Point(1000, 55);
            this.button_SendScans.Name = "button_SendScans";
            this.button_SendScans.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_SendScans.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button_SendScans.OnHoverTextColor = System.Drawing.Color.White;
            this.button_SendScans.selected = false;
            this.button_SendScans.Size = new System.Drawing.Size(160, 44);
            this.button_SendScans.TabIndex = 8;
            this.button_SendScans.Text = "Send Scans";
            this.button_SendScans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_SendScans.Textcolor = System.Drawing.Color.White;
            this.button_SendScans.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SendScans.Click += new System.EventHandler(this.Button_SendScans_Click);
            // 
            // button_GetData
            // 
            this.button_GetData.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_GetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_GetData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_GetData.BorderRadius = 0;
            this.button_GetData.ButtonText = "Get Data";
            this.button_GetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_GetData.DisabledColor = System.Drawing.Color.Gray;
            this.button_GetData.Iconcolor = System.Drawing.Color.Transparent;
            this.button_GetData.Iconimage = null;
            this.button_GetData.Iconimage_right = null;
            this.button_GetData.Iconimage_right_Selected = null;
            this.button_GetData.Iconimage_Selected = null;
            this.button_GetData.IconMarginLeft = 0;
            this.button_GetData.IconMarginRight = 0;
            this.button_GetData.IconRightVisible = true;
            this.button_GetData.IconRightZoom = 0D;
            this.button_GetData.IconVisible = true;
            this.button_GetData.IconZoom = 70D;
            this.button_GetData.IsTab = false;
            this.button_GetData.Location = new System.Drawing.Point(1000, 105);
            this.button_GetData.Name = "button_GetData";
            this.button_GetData.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_GetData.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button_GetData.OnHoverTextColor = System.Drawing.Color.White;
            this.button_GetData.selected = false;
            this.button_GetData.Size = new System.Drawing.Size(160, 44);
            this.button_GetData.TabIndex = 9;
            this.button_GetData.Text = "Get Data";
            this.button_GetData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_GetData.Textcolor = System.Drawing.Color.White;
            this.button_GetData.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GetData.Click += new System.EventHandler(this.Button_GetData_Click);
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.button_Back.Image = global::ocManager.Properties.Resources.baseline_keyboard_backspace_black_48dp;
            this.button_Back.ImageActive = null;
            this.button_Back.Location = new System.Drawing.Point(366, 22);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(66, 27);
            this.button_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Back.TabIndex = 7;
            this.button_Back.TabStop = false;
            this.button_Back.Zoom = 50;
            this.button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // button_OpenCaseFolder
            // 
            this.button_OpenCaseFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.button_OpenCaseFolder.Image = global::ocManager.Properties.Resources.baseline_folder_black_48dp;
            this.button_OpenCaseFolder.ImageActive = null;
            this.button_OpenCaseFolder.Location = new System.Drawing.Point(237, 22);
            this.button_OpenCaseFolder.Name = "button_OpenCaseFolder";
            this.button_OpenCaseFolder.Size = new System.Drawing.Size(30, 30);
            this.button_OpenCaseFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_OpenCaseFolder.TabIndex = 5;
            this.button_OpenCaseFolder.TabStop = false;
            this.button_OpenCaseFolder.Zoom = 10;
            this.button_OpenCaseFolder.Click += new System.EventHandler(this.Button_OpenCaseFolder_Click);
            // 
            // button_EditCaseFolder
            // 
            this.button_EditCaseFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.button_EditCaseFolder.Image = global::ocManager.Properties.Resources.baseline_edit_black_48dp;
            this.button_EditCaseFolder.ImageActive = null;
            this.button_EditCaseFolder.Location = new System.Drawing.Point(201, 22);
            this.button_EditCaseFolder.Name = "button_EditCaseFolder";
            this.button_EditCaseFolder.Size = new System.Drawing.Size(30, 30);
            this.button_EditCaseFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_EditCaseFolder.TabIndex = 5;
            this.button_EditCaseFolder.TabStop = false;
            this.button_EditCaseFolder.Zoom = 10;
            this.button_EditCaseFolder.Click += new System.EventHandler(this.Button_EditCaseFolder_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // button_DragDrop
            // 
            this.button_DragDrop.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_DragDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_DragDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_DragDrop.BorderRadius = 0;
            this.button_DragDrop.ButtonText = "Drag Drop Files";
            this.button_DragDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DragDrop.DisabledColor = System.Drawing.Color.Gray;
            this.button_DragDrop.Iconcolor = System.Drawing.Color.Transparent;
            this.button_DragDrop.Iconimage = null;
            this.button_DragDrop.Iconimage_right = null;
            this.button_DragDrop.Iconimage_right_Selected = null;
            this.button_DragDrop.Iconimage_Selected = null;
            this.button_DragDrop.IconMarginLeft = 0;
            this.button_DragDrop.IconMarginRight = 0;
            this.button_DragDrop.IconRightVisible = true;
            this.button_DragDrop.IconRightZoom = 0D;
            this.button_DragDrop.IconVisible = true;
            this.button_DragDrop.IconZoom = 70D;
            this.button_DragDrop.IsTab = false;
            this.button_DragDrop.Location = new System.Drawing.Point(1000, 155);
            this.button_DragDrop.Name = "button_DragDrop";
            this.button_DragDrop.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_DragDrop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button_DragDrop.OnHoverTextColor = System.Drawing.Color.White;
            this.button_DragDrop.selected = false;
            this.button_DragDrop.Size = new System.Drawing.Size(160, 44);
            this.button_DragDrop.TabIndex = 9;
            this.button_DragDrop.Text = "Drag Drop Files";
            this.button_DragDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_DragDrop.Textcolor = System.Drawing.Color.White;
            this.button_DragDrop.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DragDrop.Click += new System.EventHandler(this.Button_DragDrop_Click);
            // 
            // button_Assist
            // 
            this.button_Assist.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_Assist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_Assist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Assist.BorderRadius = 0;
            this.button_Assist.ButtonText = "Start Assist";
            this.button_Assist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Assist.DisabledColor = System.Drawing.Color.Gray;
            this.button_Assist.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Assist.Iconimage = null;
            this.button_Assist.Iconimage_right = null;
            this.button_Assist.Iconimage_right_Selected = null;
            this.button_Assist.Iconimage_Selected = null;
            this.button_Assist.IconMarginLeft = 0;
            this.button_Assist.IconMarginRight = 0;
            this.button_Assist.IconRightVisible = true;
            this.button_Assist.IconRightZoom = 0D;
            this.button_Assist.IconVisible = true;
            this.button_Assist.IconZoom = 70D;
            this.button_Assist.IsTab = false;
            this.button_Assist.Location = new System.Drawing.Point(1000, 535);
            this.button_Assist.Name = "button_Assist";
            this.button_Assist.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.button_Assist.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button_Assist.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Assist.selected = false;
            this.button_Assist.Size = new System.Drawing.Size(160, 44);
            this.button_Assist.TabIndex = 10;
            this.button_Assist.Text = "Start Assist";
            this.button_Assist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Assist.Textcolor = System.Drawing.Color.White;
            this.button_Assist.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ucExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.button_Assist);
            this.Controls.Add(this.button_DragDrop);
            this.Controls.Add(this.button_GetData);
            this.Controls.Add(this.button_SendScans);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.button_OpenCaseFolder);
            this.Controls.Add(this.button_EditCaseFolder);
            this.Controls.Add(this.listView_Explorer);
            this.Controls.Add(this.textbox_SearchInTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_AllCases);
            this.Name = "ucExplorer";
            this.Size = new System.Drawing.Size(1264, 593);
            this.Load += new System.EventHandler(this.UcExplorer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.button_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_OpenCaseFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_EditCaseFolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_AllCases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_SearchInTextbox;
        private System.Windows.Forms.ListView listView_Explorer;
        private Bunifu.Framework.UI.BunifuImageButton button_EditCaseFolder;
        private Bunifu.Framework.UI.BunifuImageButton button_OpenCaseFolder;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_LastModified;
        private System.Windows.Forms.ColumnHeader columnHeader_FileType;
        private System.Windows.Forms.ColumnHeader columnHeader_FileSize;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton button_Back;
        private Bunifu.Framework.UI.BunifuFlatButton button_SendScans;
        private Bunifu.Framework.UI.BunifuFlatButton button_GetData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuFlatButton button_DragDrop;
        private Bunifu.Framework.UI.BunifuFlatButton button_Assist;
    }
}
