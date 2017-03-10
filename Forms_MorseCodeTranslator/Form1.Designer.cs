using System.ComponentModel;

namespace MorseCodeTranslator
{
    partial class Morsecode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Morsecode));
            this.lbl_ApplicationName = new System.Windows.Forms.Label();
            this.tbx_EnterText = new System.Windows.Forms.TextBox();
            this.btn_SubmitText = new System.Windows.Forms.Button();
            this.tbx_Morsecode = new System.Windows.Forms.TextBox();
            this.btn_Clipboard = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu_FontSize = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu_FontSize10 = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu_FontSize12 = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu_FontSize14 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.MorseCode_Logo = new System.Windows.Forms.PictureBox();
            this.pbr_PlayProgression = new System.Windows.Forms.ProgressBar();
            this.bgw_playMorseCode = new System.ComponentModel.BackgroundWorker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStartAsyncOperation = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbl_AuthorName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MorseCode_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ApplicationName
            // 
            this.lbl_ApplicationName.AutoSize = true;
            this.lbl_ApplicationName.Location = new System.Drawing.Point(25, 24);
            this.lbl_ApplicationName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_ApplicationName.Name = "lbl_ApplicationName";
            this.lbl_ApplicationName.Size = new System.Drawing.Size(253, 18);
            this.lbl_ApplicationName.TabIndex = 1;
            this.lbl_ApplicationName.Text = "Text to Morse Code Translator";
            // 
            // tbx_EnterText
            // 
            this.tbx_EnterText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbx_EnterText.Location = new System.Drawing.Point(20, 94);
            this.tbx_EnterText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbx_EnterText.Name = "tbx_EnterText";
            this.tbx_EnterText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_EnterText.Size = new System.Drawing.Size(451, 27);
            this.tbx_EnterText.TabIndex = 3;
            this.tbx_EnterText.Text = "Enter text you want to translate to morse code";
            this.tbx_EnterText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_SubmitText
            // 
            this.btn_SubmitText.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_SubmitText.FlatAppearance.BorderSize = 0;
            this.btn_SubmitText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SubmitText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubmitText.ForeColor = System.Drawing.Color.Azure;
            this.btn_SubmitText.Location = new System.Drawing.Point(20, 131);
            this.btn_SubmitText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_SubmitText.Name = "btn_SubmitText";
            this.btn_SubmitText.Size = new System.Drawing.Size(451, 30);
            this.btn_SubmitText.TabIndex = 4;
            this.btn_SubmitText.Text = "Submit";
            this.btn_SubmitText.UseVisualStyleBackColor = false;
            this.btn_SubmitText.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbx_Morsecode
            // 
            this.tbx_Morsecode.Location = new System.Drawing.Point(20, 171);
            this.tbx_Morsecode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbx_Morsecode.Multiline = true;
            this.tbx_Morsecode.Name = "tbx_Morsecode";
            this.tbx_Morsecode.ReadOnly = true;
            this.tbx_Morsecode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Morsecode.Size = new System.Drawing.Size(451, 66);
            this.tbx_Morsecode.TabIndex = 6;
            this.tbx_Morsecode.Text = "Note: Space(s) entered above show up as an / divider in the morse code.";
            // 
            // btn_Clipboard
            // 
            this.btn_Clipboard.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Clipboard.FlatAppearance.BorderSize = 0;
            this.btn_Clipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clipboard.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clipboard.ForeColor = System.Drawing.Color.Azure;
            this.btn_Clipboard.Location = new System.Drawing.Point(247, 308);
            this.btn_Clipboard.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Clipboard.Name = "btn_Clipboard";
            this.btn_Clipboard.Size = new System.Drawing.Size(224, 30);
            this.btn_Clipboard.TabIndex = 9;
            this.btn_Clipboard.Text = "To Clipboard";
            this.btn_Clipboard.UseVisualStyleBackColor = false;
            this.btn_Clipboard.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Options,
            this.menu_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 361);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(492, 40);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_Options
            // 
            this.menu_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenu_FontSize});
            this.menu_Options.ForeColor = System.Drawing.Color.Azure;
            this.menu_Options.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.menu_Options.Name = "menu_Options";
            this.menu_Options.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.menu_Options.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.menu_Options.Size = new System.Drawing.Size(72, 28);
            this.menu_Options.Text = "Options";
            // 
            // subMenu_FontSize
            // 
            this.subMenu_FontSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenu_FontSize10,
            this.subMenu_FontSize12,
            this.subMenu_FontSize14});
            this.subMenu_FontSize.Name = "subMenu_FontSize";
            this.subMenu_FontSize.Size = new System.Drawing.Size(161, 22);
            this.subMenu_FontSize.Text = "Set font size";
            // 
            // subMenu_FontSize10
            // 
            this.subMenu_FontSize10.Name = "subMenu_FontSize10";
            this.subMenu_FontSize10.Size = new System.Drawing.Size(189, 22);
            this.subMenu_FontSize10.Text = "Small";
            this.subMenu_FontSize10.Click += new System.EventHandler(this.size10ToolStripMenuItem_Click);
            // 
            // subMenu_FontSize12
            // 
            this.subMenu_FontSize12.Name = "subMenu_FontSize12";
            this.subMenu_FontSize12.Size = new System.Drawing.Size(189, 22);
            this.subMenu_FontSize12.Text = "Medium (Default)";
            this.subMenu_FontSize12.Click += new System.EventHandler(this.size12ToolStripMenuItem_Click);
            // 
            // subMenu_FontSize14
            // 
            this.subMenu_FontSize14.Name = "subMenu_FontSize14";
            this.subMenu_FontSize14.Size = new System.Drawing.Size(189, 22);
            this.subMenu_FontSize14.Text = "Large";
            this.subMenu_FontSize14.Click += new System.EventHandler(this.size14ToolStripMenuItem_Click);
            // 
            // menu_About
            // 
            this.menu_About.ForeColor = System.Drawing.Color.Azure;
            this.menu_About.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.menu_About.Name = "menu_About";
            this.menu_About.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.menu_About.ShowShortcutKeys = false;
            this.menu_About.Size = new System.Drawing.Size(106, 28);
            this.menu_About.Text = "© Shinobyte";
            this.menu_About.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MorseCode_Logo
            // 
            this.MorseCode_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.MorseCode_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MorseCode_Logo.Image = global::MorseCodeTranslator.Properties.Resources.morseCode;
            this.MorseCode_Logo.Location = new System.Drawing.Point(400, -1);
            this.MorseCode_Logo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MorseCode_Logo.Name = "MorseCode_Logo";
            this.MorseCode_Logo.Size = new System.Drawing.Size(85, 89);
            this.MorseCode_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MorseCode_Logo.TabIndex = 8;
            this.MorseCode_Logo.TabStop = false;
            // 
            // pbr_PlayProgression
            // 
            this.pbr_PlayProgression.Location = new System.Drawing.Point(20, 268);
            this.pbr_PlayProgression.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbr_PlayProgression.Name = "pbr_PlayProgression";
            this.pbr_PlayProgression.Size = new System.Drawing.Size(451, 30);
            this.pbr_PlayProgression.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbr_PlayProgression.TabIndex = 13;
            // 
            // bgw_playMorseCode
            // 
            this.bgw_playMorseCode.WorkerReportsProgress = true;
            this.bgw_playMorseCode.WorkerSupportsCancellation = true;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Azure;
            this.lblStatus.Location = new System.Drawing.Point(20, 240);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(451, 25);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnStartAsyncOperation
            // 
            this.btnStartAsyncOperation.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStartAsyncOperation.FlatAppearance.BorderSize = 0;
            this.btnStartAsyncOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAsyncOperation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAsyncOperation.ForeColor = System.Drawing.Color.Azure;
            this.btnStartAsyncOperation.Location = new System.Drawing.Point(20, 308);
            this.btnStartAsyncOperation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnStartAsyncOperation.Name = "btnStartAsyncOperation";
            this.btnStartAsyncOperation.Size = new System.Drawing.Size(75, 30);
            this.btnStartAsyncOperation.TabIndex = 15;
            this.btnStartAsyncOperation.Text = "Play";
            this.btnStartAsyncOperation.UseVisualStyleBackColor = false;
            this.btnStartAsyncOperation.Click += new System.EventHandler(this.btnStartAsyncOperation_Click_2);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Azure;
            this.btnCancel.Location = new System.Drawing.Point(105, 308);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 30);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Stop";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // lbl_AuthorName
            // 
            this.lbl_AuthorName.AutoSize = true;
            this.lbl_AuthorName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AuthorName.Location = new System.Drawing.Point(25, 49);
            this.lbl_AuthorName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_AuthorName.Name = "lbl_AuthorName";
            this.lbl_AuthorName.Size = new System.Drawing.Size(224, 18);
            this.lbl_AuthorName.TabIndex = 2;
            this.lbl_AuthorName.Text = "Author: Alex van der Waal";
            // 
            // Morsecode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(492, 401);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStartAsyncOperation);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbr_PlayProgression);
            this.Controls.Add(this.btn_Clipboard);
            this.Controls.Add(this.MorseCode_Logo);
            this.Controls.Add(this.tbx_Morsecode);
            this.Controls.Add(this.btn_SubmitText);
            this.Controls.Add(this.tbx_EnterText);
            this.Controls.Add(this.lbl_AuthorName);
            this.Controls.Add(this.lbl_ApplicationName);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Morsecode";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Text to Morse Code Translator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MorseCode_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

         #endregion
        private System.Windows.Forms.Label lbl_ApplicationName;
        private System.Windows.Forms.TextBox tbx_EnterText;
        private System.Windows.Forms.Button btn_SubmitText;
        private System.Windows.Forms.TextBox tbx_Morsecode;
        private System.Windows.Forms.PictureBox MorseCode_Logo;
        private System.Windows.Forms.Button btn_Clipboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_About;
        private System.Windows.Forms.ToolStripMenuItem menu_Options;
        private System.Windows.Forms.ToolStripMenuItem subMenu_FontSize;
        private System.Windows.Forms.ToolStripMenuItem subMenu_FontSize10;
        private System.Windows.Forms.ToolStripMenuItem subMenu_FontSize12;
        private System.Windows.Forms.ToolStripMenuItem subMenu_FontSize14;
        public System.Windows.Forms.ProgressBar pbr_PlayProgression;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnStartAsyncOperation;
        private System.Windows.Forms.Button btnCancel;
        public BackgroundWorker bgw_playMorseCode;
        private System.Windows.Forms.Label lbl_AuthorName;
    }
}

