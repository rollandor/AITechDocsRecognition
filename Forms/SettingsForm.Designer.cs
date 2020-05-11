namespace AITechDocsRecognition.Forms
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.imgBtnExit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.headerPanel.Controls.Add(this.imgBtnExit);
            this.headerPanel.Controls.Add(this.bunifuLabel1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(434, 38);
            this.headerPanel.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(10, 8);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(84, 21);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Настройки";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // imgBtnExit
            // 
            this.imgBtnExit.ActiveImage = null;
            this.imgBtnExit.AllowAnimations = true;
            this.imgBtnExit.AllowBuffering = false;
            this.imgBtnExit.AllowZooming = true;
            this.imgBtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBtnExit.BackColor = System.Drawing.Color.Transparent;
            this.imgBtnExit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgBtnExit.ErrorImage")));
            this.imgBtnExit.FadeWhenInactive = false;
            this.imgBtnExit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imgBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("imgBtnExit.Image")));
            this.imgBtnExit.ImageActive = null;
            this.imgBtnExit.ImageLocation = null;
            this.imgBtnExit.ImageMargin = -20;
            this.imgBtnExit.ImageSize = new System.Drawing.Size(58, 58);
            this.imgBtnExit.ImageZoomSize = new System.Drawing.Size(38, 38);
            this.imgBtnExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgBtnExit.InitialImage")));
            this.imgBtnExit.Location = new System.Drawing.Point(396, 0);
            this.imgBtnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgBtnExit.Name = "imgBtnExit";
            this.imgBtnExit.Rotation = 0;
            this.imgBtnExit.ShowActiveImage = true;
            this.imgBtnExit.ShowCursorChanges = true;
            this.imgBtnExit.ShowImageBorders = true;
            this.imgBtnExit.ShowSizeMarkers = false;
            this.imgBtnExit.Size = new System.Drawing.Size(38, 38);
            this.imgBtnExit.TabIndex = 3;
            this.imgBtnExit.ToolTipText = "Exit";
            this.imgBtnExit.WaitOnLoad = false;
            this.imgBtnExit.Zoom = -20;
            this.imgBtnExit.ZoomSpeed = 10;
            this.imgBtnExit.Click += new System.EventHandler(this.imgBtnExit_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuImageButton imgBtnExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}