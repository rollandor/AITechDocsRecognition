namespace AITechDocsRecognition
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.headerPanel = new System.Windows.Forms.Panel();
            this.ImgBtnHelp = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImgBtnOpt = new Bunifu.UI.WinForms.BunifuImageButton();
            this.imgBtnExit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuImageButton3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton5 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton6 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton7 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton8 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.menuPanel.Controls.Add(this.bunifuPictureBox1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 38);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(299, 862);
            this.menuPanel.TabIndex = 1;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPictureBox1.BorderRadius = 50;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(299, 299);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.headerPanel.Controls.Add(this.ImgBtnHelp);
            this.headerPanel.Controls.Add(this.ImgBtnOpt);
            this.headerPanel.Controls.Add(this.imgBtnExit);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1200, 38);
            this.headerPanel.TabIndex = 0;
            // 
            // ImgBtnHelp
            // 
            this.ImgBtnHelp.ActiveImage = null;
            this.ImgBtnHelp.AllowAnimations = true;
            this.ImgBtnHelp.AllowBuffering = false;
            this.ImgBtnHelp.AllowZooming = true;
            this.ImgBtnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgBtnHelp.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ImgBtnHelp.BackColor = System.Drawing.Color.Transparent;
            this.ImgBtnHelp.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImgBtnHelp.ErrorImage")));
            this.ImgBtnHelp.FadeWhenInactive = false;
            this.ImgBtnHelp.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImgBtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("ImgBtnHelp.Image")));
            this.ImgBtnHelp.ImageActive = null;
            this.ImgBtnHelp.ImageLocation = null;
            this.ImgBtnHelp.ImageMargin = -10;
            this.ImgBtnHelp.ImageSize = new System.Drawing.Size(48, 48);
            this.ImgBtnHelp.ImageZoomSize = new System.Drawing.Size(38, 38);
            this.ImgBtnHelp.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgBtnHelp.InitialImage")));
            this.ImgBtnHelp.Location = new System.Drawing.Point(1072, 0);
            this.ImgBtnHelp.Name = "ImgBtnHelp";
            this.ImgBtnHelp.Rotation = 0;
            this.ImgBtnHelp.ShowActiveImage = true;
            this.ImgBtnHelp.ShowCursorChanges = true;
            this.ImgBtnHelp.ShowImageBorders = false;
            this.ImgBtnHelp.ShowSizeMarkers = false;
            this.ImgBtnHelp.Size = new System.Drawing.Size(38, 38);
            this.ImgBtnHelp.TabIndex = 4;
            this.ImgBtnHelp.ToolTipText = "Help";
            this.ImgBtnHelp.WaitOnLoad = false;
            this.ImgBtnHelp.Zoom = -10;
            this.ImgBtnHelp.ZoomSpeed = 10;
            this.ImgBtnHelp.Click += new System.EventHandler(this.ImgBtnHelp_Click);
            // 
            // ImgBtnOpt
            // 
            this.ImgBtnOpt.ActiveImage = null;
            this.ImgBtnOpt.AllowAnimations = true;
            this.ImgBtnOpt.AllowBuffering = false;
            this.ImgBtnOpt.AllowZooming = true;
            this.ImgBtnOpt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgBtnOpt.BackColor = System.Drawing.Color.Transparent;
            this.ImgBtnOpt.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImgBtnOpt.ErrorImage")));
            this.ImgBtnOpt.FadeWhenInactive = false;
            this.ImgBtnOpt.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImgBtnOpt.Image = ((System.Drawing.Image)(resources.GetObject("ImgBtnOpt.Image")));
            this.ImgBtnOpt.ImageActive = null;
            this.ImgBtnOpt.ImageLocation = null;
            this.ImgBtnOpt.ImageMargin = -10;
            this.ImgBtnOpt.ImageSize = new System.Drawing.Size(48, 48);
            this.ImgBtnOpt.ImageZoomSize = new System.Drawing.Size(38, 38);
            this.ImgBtnOpt.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgBtnOpt.InitialImage")));
            this.ImgBtnOpt.Location = new System.Drawing.Point(1116, 0);
            this.ImgBtnOpt.Name = "ImgBtnOpt";
            this.ImgBtnOpt.Rotation = 0;
            this.ImgBtnOpt.ShowActiveImage = true;
            this.ImgBtnOpt.ShowCursorChanges = true;
            this.ImgBtnOpt.ShowImageBorders = false;
            this.ImgBtnOpt.ShowSizeMarkers = false;
            this.ImgBtnOpt.Size = new System.Drawing.Size(38, 38);
            this.ImgBtnOpt.TabIndex = 3;
            this.ImgBtnOpt.ToolTipText = "Preferences";
            this.ImgBtnOpt.WaitOnLoad = false;
            this.ImgBtnOpt.Zoom = -10;
            this.ImgBtnOpt.ZoomSpeed = 10;
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
            this.imgBtnExit.Location = new System.Drawing.Point(1160, 0);
            this.imgBtnExit.Name = "imgBtnExit";
            this.imgBtnExit.Rotation = 0;
            this.imgBtnExit.ShowActiveImage = true;
            this.imgBtnExit.ShowCursorChanges = true;
            this.imgBtnExit.ShowImageBorders = true;
            this.imgBtnExit.ShowSizeMarkers = false;
            this.imgBtnExit.Size = new System.Drawing.Size(38, 38);
            this.imgBtnExit.TabIndex = 2;
            this.imgBtnExit.ToolTipText = "Exit";
            this.imgBtnExit.WaitOnLoad = false;
            this.imgBtnExit.Zoom = -20;
            this.imgBtnExit.ZoomSpeed = 10;
            this.imgBtnExit.Click += new System.EventHandler(this.imgBtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Location = new System.Drawing.Point(314, 738);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 150);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.bunifuImageButton3);
            this.flowLayoutPanel1.Controls.Add(this.bunifuImageButton4);
            this.flowLayoutPanel1.Controls.Add(this.bunifuImageButton5);
            this.flowLayoutPanel1.Controls.Add(this.bunifuImageButton6);
            this.flowLayoutPanel1.Controls.Add(this.bunifuImageButton7);
            this.flowLayoutPanel1.Controls.Add(this.bunifuImageButton8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(82, 16);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 4, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(714, 118);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.ActiveImage = null;
            this.bunifuImageButton3.AllowAnimations = true;
            this.bunifuImageButton3.AllowBuffering = false;
            this.bunifuImageButton3.AllowZooming = false;
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ErrorImage")));
            this.bunifuImageButton3.FadeWhenInactive = false;
            this.bunifuImageButton3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImageLocation = null;
            this.bunifuImageButton3.ImageMargin = 10;
            this.bunifuImageButton3.ImageSize = new System.Drawing.Size(116, 90);
            this.bunifuImageButton3.ImageZoomSize = new System.Drawing.Size(126, 100);
            this.bunifuImageButton3.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.InitialImage")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(8, 7);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Rotation = 0;
            this.bunifuImageButton3.ShowActiveImage = true;
            this.bunifuImageButton3.ShowCursorChanges = true;
            this.bunifuImageButton3.ShowImageBorders = true;
            this.bunifuImageButton3.ShowSizeMarkers = false;
            this.bunifuImageButton3.Size = new System.Drawing.Size(126, 100);
            this.bunifuImageButton3.TabIndex = 0;
            this.bunifuImageButton3.ToolTipText = "";
            this.bunifuImageButton3.WaitOnLoad = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.ZoomSpeed = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = null;
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowZooming = true;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = false;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = -15;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(108, 107);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(93, 92);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(789, 27);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = false;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(93, 92);
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.ToolTipText = "Next image";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = -15;
            this.bunifuImageButton2.ZoomSpeed = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = -15;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(108, 107);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(93, 92);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(-6, 27);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = false;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(93, 92);
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.ToolTipText = "Preview image";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = -15;
            this.bunifuImageButton1.ZoomSpeed = 10;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.ActiveImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.ActiveImage")));
            this.bunifuImageButton4.AllowAnimations = true;
            this.bunifuImageButton4.AllowBuffering = true;
            this.bunifuImageButton4.AllowZooming = false;
            this.bunifuImageButton4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.ErrorImage")));
            this.bunifuImageButton4.FadeWhenInactive = false;
            this.bunifuImageButton4.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.ImageActive")));
            this.bunifuImageButton4.ImageLocation = null;
            this.bunifuImageButton4.ImageMargin = 10;
            this.bunifuImageButton4.ImageSize = new System.Drawing.Size(116, 90);
            this.bunifuImageButton4.ImageZoomSize = new System.Drawing.Size(126, 100);
            this.bunifuImageButton4.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.InitialImage")));
            this.bunifuImageButton4.Location = new System.Drawing.Point(140, 7);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Rotation = 0;
            this.bunifuImageButton4.ShowActiveImage = false;
            this.bunifuImageButton4.ShowCursorChanges = true;
            this.bunifuImageButton4.ShowImageBorders = true;
            this.bunifuImageButton4.ShowSizeMarkers = false;
            this.bunifuImageButton4.Size = new System.Drawing.Size(126, 100);
            this.bunifuImageButton4.TabIndex = 1;
            this.bunifuImageButton4.ToolTipText = "";
            this.bunifuImageButton4.WaitOnLoad = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.ZoomSpeed = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.ActiveImage = null;
            this.bunifuImageButton5.AllowAnimations = true;
            this.bunifuImageButton5.AllowBuffering = false;
            this.bunifuImageButton5.AllowZooming = false;
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.ErrorImage")));
            this.bunifuImageButton5.FadeWhenInactive = false;
            this.bunifuImageButton5.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.ImageLocation = null;
            this.bunifuImageButton5.ImageMargin = 10;
            this.bunifuImageButton5.ImageSize = new System.Drawing.Size(116, 90);
            this.bunifuImageButton5.ImageZoomSize = new System.Drawing.Size(126, 100);
            this.bunifuImageButton5.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.InitialImage")));
            this.bunifuImageButton5.Location = new System.Drawing.Point(272, 7);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Rotation = 0;
            this.bunifuImageButton5.ShowActiveImage = true;
            this.bunifuImageButton5.ShowCursorChanges = true;
            this.bunifuImageButton5.ShowImageBorders = true;
            this.bunifuImageButton5.ShowSizeMarkers = false;
            this.bunifuImageButton5.Size = new System.Drawing.Size(126, 100);
            this.bunifuImageButton5.TabIndex = 2;
            this.bunifuImageButton5.ToolTipText = "";
            this.bunifuImageButton5.WaitOnLoad = false;
            this.bunifuImageButton5.Zoom = 10;
            this.bunifuImageButton5.ZoomSpeed = 10;
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.ActiveImage = null;
            this.bunifuImageButton6.AllowAnimations = true;
            this.bunifuImageButton6.AllowBuffering = false;
            this.bunifuImageButton6.AllowZooming = false;
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.ErrorImage")));
            this.bunifuImageButton6.FadeWhenInactive = false;
            this.bunifuImageButton6.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.ImageLocation = null;
            this.bunifuImageButton6.ImageMargin = 10;
            this.bunifuImageButton6.ImageSize = new System.Drawing.Size(116, 90);
            this.bunifuImageButton6.ImageZoomSize = new System.Drawing.Size(126, 100);
            this.bunifuImageButton6.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.InitialImage")));
            this.bunifuImageButton6.Location = new System.Drawing.Point(404, 7);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Rotation = 0;
            this.bunifuImageButton6.ShowActiveImage = true;
            this.bunifuImageButton6.ShowCursorChanges = true;
            this.bunifuImageButton6.ShowImageBorders = true;
            this.bunifuImageButton6.ShowSizeMarkers = false;
            this.bunifuImageButton6.Size = new System.Drawing.Size(126, 100);
            this.bunifuImageButton6.TabIndex = 3;
            this.bunifuImageButton6.ToolTipText = "";
            this.bunifuImageButton6.WaitOnLoad = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.ZoomSpeed = 10;
            // 
            // bunifuImageButton7
            // 
            this.bunifuImageButton7.ActiveImage = null;
            this.bunifuImageButton7.AllowAnimations = true;
            this.bunifuImageButton7.AllowBuffering = false;
            this.bunifuImageButton7.AllowZooming = false;
            this.bunifuImageButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton7.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.ErrorImage")));
            this.bunifuImageButton7.FadeWhenInactive = false;
            this.bunifuImageButton7.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.Image")));
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.ImageLocation = null;
            this.bunifuImageButton7.ImageMargin = 10;
            this.bunifuImageButton7.ImageSize = new System.Drawing.Size(116, 90);
            this.bunifuImageButton7.ImageZoomSize = new System.Drawing.Size(126, 100);
            this.bunifuImageButton7.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.InitialImage")));
            this.bunifuImageButton7.Location = new System.Drawing.Point(536, 7);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Rotation = 0;
            this.bunifuImageButton7.ShowActiveImage = true;
            this.bunifuImageButton7.ShowCursorChanges = true;
            this.bunifuImageButton7.ShowImageBorders = true;
            this.bunifuImageButton7.ShowSizeMarkers = false;
            this.bunifuImageButton7.Size = new System.Drawing.Size(126, 100);
            this.bunifuImageButton7.TabIndex = 4;
            this.bunifuImageButton7.ToolTipText = "";
            this.bunifuImageButton7.WaitOnLoad = false;
            this.bunifuImageButton7.Zoom = 10;
            this.bunifuImageButton7.ZoomSpeed = 10;
            // 
            // bunifuImageButton8
            // 
            this.bunifuImageButton8.ActiveImage = null;
            this.bunifuImageButton8.AllowAnimations = true;
            this.bunifuImageButton8.AllowBuffering = false;
            this.bunifuImageButton8.AllowZooming = false;
            this.bunifuImageButton8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton8.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton8.ErrorImage")));
            this.bunifuImageButton8.FadeWhenInactive = false;
            this.bunifuImageButton8.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton8.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton8.Image")));
            this.bunifuImageButton8.ImageActive = null;
            this.bunifuImageButton8.ImageLocation = null;
            this.bunifuImageButton8.ImageMargin = 10;
            this.bunifuImageButton8.ImageSize = new System.Drawing.Size(116, 90);
            this.bunifuImageButton8.ImageZoomSize = new System.Drawing.Size(126, 100);
            this.bunifuImageButton8.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton8.InitialImage")));
            this.bunifuImageButton8.Location = new System.Drawing.Point(668, 7);
            this.bunifuImageButton8.Name = "bunifuImageButton8";
            this.bunifuImageButton8.Rotation = 0;
            this.bunifuImageButton8.ShowActiveImage = true;
            this.bunifuImageButton8.ShowCursorChanges = true;
            this.bunifuImageButton8.ShowImageBorders = true;
            this.bunifuImageButton8.ShowSizeMarkers = false;
            this.bunifuImageButton8.Size = new System.Drawing.Size(126, 100);
            this.bunifuImageButton8.TabIndex = 5;
            this.bunifuImageButton8.ToolTipText = "";
            this.bunifuImageButton8.WaitOnLoad = false;
            this.bunifuImageButton8.Zoom = 10;
            this.bunifuImageButton8.ZoomSpeed = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel headerPanel;
        private Bunifu.UI.WinForms.BunifuImageButton ImgBtnHelp;
        private Bunifu.UI.WinForms.BunifuImageButton ImgBtnOpt;
        private Bunifu.UI.WinForms.BunifuImageButton imgBtnExit;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton3;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton4;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton5;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton6;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton7;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton8;
    }
}

