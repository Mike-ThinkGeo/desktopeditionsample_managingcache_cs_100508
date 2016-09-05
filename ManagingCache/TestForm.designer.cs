namespace ManagingCache
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.ImageListToolbar = new System.Windows.Forms.ImageList(this.components);
            this.winformsMap1 = new ThinkGeo.MapSuite.DesktopEdition.WinformsMap();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelScreen = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelWorld = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.radioButtonSnapUp = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(603, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ImageListToolbar
            // 
            this.ImageListToolbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListToolbar.ImageStream")));
            this.ImageListToolbar.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListToolbar.Images.SetKeyName(0, "");
            this.ImageListToolbar.Images.SetKeyName(1, "");
            this.ImageListToolbar.Images.SetKeyName(2, "");
            this.ImageListToolbar.Images.SetKeyName(3, "");
            this.ImageListToolbar.Images.SetKeyName(4, "");
            this.ImageListToolbar.Images.SetKeyName(5, "");
            this.ImageListToolbar.Images.SetKeyName(6, "");
            this.ImageListToolbar.Images.SetKeyName(7, "");
            this.ImageListToolbar.Images.SetKeyName(8, "");
            this.ImageListToolbar.Images.SetKeyName(9, "");
            this.ImageListToolbar.Images.SetKeyName(10, "");
            this.ImageListToolbar.Images.SetKeyName(11, "");
            this.ImageListToolbar.Images.SetKeyName(12, "");
            this.ImageListToolbar.Images.SetKeyName(13, "");
            this.ImageListToolbar.Images.SetKeyName(14, "");
            this.ImageListToolbar.Images.SetKeyName(15, "");
            this.ImageListToolbar.Images.SetKeyName(16, "");
            this.ImageListToolbar.Images.SetKeyName(17, "");
            this.ImageListToolbar.Images.SetKeyName(18, "");
            this.ImageListToolbar.Images.SetKeyName(19, "");
            this.ImageListToolbar.Images.SetKeyName(20, "");
            this.ImageListToolbar.Images.SetKeyName(21, "");
            this.ImageListToolbar.Images.SetKeyName(22, "");
            this.ImageListToolbar.Images.SetKeyName(23, "");
            this.ImageListToolbar.Images.SetKeyName(24, "");
            this.ImageListToolbar.Images.SetKeyName(25, "");
            this.ImageListToolbar.Images.SetKeyName(26, "");
            this.ImageListToolbar.Images.SetKeyName(27, "");
            this.ImageListToolbar.Images.SetKeyName(28, "");
            this.ImageListToolbar.Images.SetKeyName(29, "");
            this.ImageListToolbar.Images.SetKeyName(30, "");
            this.ImageListToolbar.Images.SetKeyName(31, "tool_icon_color_picker.png");
            this.ImageListToolbar.Images.SetKeyName(32, "btn_layer_up.png");
            this.ImageListToolbar.Images.SetKeyName(33, "btn_layer_down.png");
            // 
            // winformsMap1
            // 
            this.winformsMap1.BackColor = System.Drawing.Color.White;
            this.winformsMap1.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default;
            this.winformsMap1.CurrentScale = 590591790;
            this.winformsMap1.DrawingQuality = ThinkGeo.MapSuite.Core.DrawingQuality.Default;
            this.winformsMap1.Location = new System.Drawing.Point(12, 12);
            this.winformsMap1.MapFocusMode = ThinkGeo.MapSuite.DesktopEdition.MapFocusMode.Default;
            this.winformsMap1.MapResizeMode = ThinkGeo.MapSuite.Core.MapResizeMode.PreserveScale;
            this.winformsMap1.MapUnit = ThinkGeo.MapSuite.Core.GeographyUnit.DecimalDegree;
            this.winformsMap1.MaximumScale = 80000000000000;
            this.winformsMap1.MinimumScale = 200;
            this.winformsMap1.Name = "winformsMap1";
            this.winformsMap1.Size = new System.Drawing.Size(666, 407);
            this.winformsMap1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.winformsMap1.TabIndex = 2;
            this.winformsMap1.Text = "winformsMap1";
            this.winformsMap1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.winformsMap1.ThreadingMode = ThinkGeo.MapSuite.DesktopEdition.MapThreadingMode.Default;
            this.winformsMap1.ZoomLevelSnapping = ThinkGeo.MapSuite.DesktopEdition.ZoomLevelSnappingMode.Default;
            this.winformsMap1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.winformsMap1_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelScreen,
            this.toolStripStatusLabelWorld});
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(916, 22);
            this.statusStrip1.TabIndex = 46;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelScreen
            // 
            this.toolStripStatusLabelScreen.AutoSize = false;
            this.toolStripStatusLabelScreen.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabelScreen.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabelScreen.Name = "toolStripStatusLabelScreen";
            this.toolStripStatusLabelScreen.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabelScreen.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabelWorld
            // 
            this.toolStripStatusLabelWorld.AutoSize = false;
            this.toolStripStatusLabelWorld.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabelWorld.Name = "toolStripStatusLabelWorld";
            this.toolStripStatusLabelWorld.Size = new System.Drawing.Size(188, 17);
            this.toolStripStatusLabelWorld.Text = "toolStripStatusLabel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSnapUp);
            this.groupBox1.Controls.Add(this.radioButtonNone);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(696, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 96);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zoom Snapping Modes";
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNone.Location = new System.Drawing.Point(19, 62);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(51, 17);
            this.radioButtonNone.TabIndex = 0;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            this.radioButtonNone.CheckedChanged += new System.EventHandler(this.radioButtonNone_CheckedChanged);
            // 
            // radioButtonSnapUp
            // 
            this.radioButtonSnapUp.AutoSize = true;
            this.radioButtonSnapUp.Checked = true;
            this.radioButtonSnapUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSnapUp.Location = new System.Drawing.Point(19, 28);
            this.radioButtonSnapUp.Name = "radioButtonSnapUp";
            this.radioButtonSnapUp.Size = new System.Drawing.Size(67, 17);
            this.radioButtonSnapUp.TabIndex = 1;
            this.radioButtonSnapUp.TabStop = true;
            this.radioButtonSnapUp.Text = "Snap Up";
            this.radioButtonSnapUp.UseVisualStyleBackColor = true;
            this.radioButtonSnapUp.CheckedChanged += new System.EventHandler(this.radioButtonSnapUp_CheckedChanged);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.winformsMap1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Community Project-Managing Cache";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.ImageList ImageListToolbar;
        private ThinkGeo.MapSuite.DesktopEdition.WinformsMap winformsMap1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelScreen;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelWorld;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSnapUp;
        private System.Windows.Forms.RadioButton radioButtonNone;
    }
}

