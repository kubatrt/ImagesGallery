namespace ImagesGallery
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxDirectoryPath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelList = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.groupBoxGallery = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarPictureSize = new System.Windows.Forms.TrackBar();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.checkBoxGallery = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.labelMetaName = new System.Windows.Forms.Label();
            this.labelMetaPixelFormat = new System.Windows.Forms.Label();
            this.labelMetaHeight = new System.Windows.Forms.Label();
            this.labelMetaWidth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonRotateRight = new System.Windows.Forms.Button();
            this.buttonRotateLeft = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelList.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.groupBoxGallery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPictureSize)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(515, 540);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Resize += new System.EventHandler(this.flowLayoutPanel1_Resize);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(188, 208);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Reload all";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxDirectoryPath
            // 
            this.textBoxDirectoryPath.Location = new System.Drawing.Point(7, 35);
            this.textBoxDirectoryPath.Name = "textBoxDirectoryPath";
            this.textBoxDirectoryPath.Size = new System.Drawing.Size(256, 20);
            this.textBoxDirectoryPath.TabIndex = 2;
            this.textBoxDirectoryPath.Text = "D:\\Resources\\tekstury";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(6, 6);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(104, 23);
            this.buttonBrowse.TabIndex = 5;
            this.buttonBrowse.Text = "Przeglądaj...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(0, 0);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(270, 326);
            this.listBoxFiles.TabIndex = 6;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelList);
            this.splitContainer1.Panel1.Controls.Add(this.panelMenu);
            this.splitContainer1.Panel1MinSize = 270;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelContainer);
            this.splitContainer1.Size = new System.Drawing.Size(939, 596);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 8;
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.listBoxFiles);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(0, 270);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(270, 326);
            this.panelList.TabIndex = 9;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.groupBoxGallery);
            this.panelMenu.Controls.Add(this.checkBoxGallery);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.buttonClear);
            this.panelMenu.Controls.Add(this.buttonBrowse);
            this.panelMenu.Controls.Add(this.textBoxDirectoryPath);
            this.panelMenu.Controls.Add(this.buttonLoad);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(270, 270);
            this.panelMenu.TabIndex = 8;
            // 
            // groupBoxGallery
            // 
            this.groupBoxGallery.Controls.Add(this.label1);
            this.groupBoxGallery.Controls.Add(this.trackBarPictureSize);
            this.groupBoxGallery.Controls.Add(this.radioButton1);
            this.groupBoxGallery.Controls.Add(this.radioButton2);
            this.groupBoxGallery.Controls.Add(this.label2);
            this.groupBoxGallery.Controls.Add(this.radioButton3);
            this.groupBoxGallery.Controls.Add(this.radioButton4);
            this.groupBoxGallery.Enabled = false;
            this.groupBoxGallery.Location = new System.Drawing.Point(7, 84);
            this.groupBoxGallery.Name = "groupBoxGallery";
            this.groupBoxGallery.Size = new System.Drawing.Size(175, 176);
            this.groupBoxGallery.TabIndex = 14;
            this.groupBoxGallery.TabStop = false;
            this.groupBoxGallery.Text = "Galeria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rozmiar obrazków:";
            // 
            // trackBarPictureSize
            // 
            this.trackBarPictureSize.AutoSize = false;
            this.trackBarPictureSize.LargeChange = 1;
            this.trackBarPictureSize.Location = new System.Drawing.Point(9, 32);
            this.trackBarPictureSize.Maximum = 3;
            this.trackBarPictureSize.Name = "trackBarPictureSize";
            this.trackBarPictureSize.Size = new System.Drawing.Size(160, 20);
            this.trackBarPictureSize.TabIndex = 2;
            this.trackBarPictureSize.Value = 1;
            this.trackBarPictureSize.Scroll += new System.EventHandler(this.trackBarPictureSize_Scroll);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 126);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "rozciągnij";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 103);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "wyśrodkuj";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tryb wyświetlania obrazu:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 149);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "auto";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(13, 80);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(67, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.Text = "normalny";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // checkBoxGallery
            // 
            this.checkBoxGallery.AutoSize = true;
            this.checkBoxGallery.Location = new System.Drawing.Point(7, 61);
            this.checkBoxGallery.Name = "checkBoxGallery";
            this.checkBoxGallery.Size = new System.Drawing.Size(127, 17);
            this.checkBoxGallery.TabIndex = 13;
            this.checkBoxGallery.Text = "Pokaż podgląd galerii";
            this.checkBoxGallery.UseVisualStyleBackColor = true;
            this.checkBoxGallery.CheckedChanged += new System.EventHandler(this.checkBoxGallery_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "*.jpg,*.gif,*.png,*.bmp";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(188, 237);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelCenter);
            this.panelContainer.Controls.Add(this.panelRight);
            this.panelContainer.Controls.Add(this.panelBottom);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(665, 596);
            this.panelContainer.TabIndex = 2;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCenter.Controls.Add(this.flowLayoutPanel1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(515, 540);
            this.panelCenter.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelRight.Controls.Add(this.labelMetaName);
            this.panelRight.Controls.Add(this.labelMetaPixelFormat);
            this.panelRight.Controls.Add(this.labelMetaHeight);
            this.panelRight.Controls.Add(this.labelMetaWidth);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(515, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(150, 540);
            this.panelRight.TabIndex = 0;
            // 
            // labelMetaName
            // 
            this.labelMetaName.AutoSize = true;
            this.labelMetaName.Location = new System.Drawing.Point(6, 22);
            this.labelMetaName.Name = "labelMetaName";
            this.labelMetaName.Size = new System.Drawing.Size(43, 13);
            this.labelMetaName.TabIndex = 1;
            this.labelMetaName.Text = "Nazwa:";
            // 
            // labelMetaPixelFormat
            // 
            this.labelMetaPixelFormat.AutoSize = true;
            this.labelMetaPixelFormat.Location = new System.Drawing.Point(6, 62);
            this.labelMetaPixelFormat.Name = "labelMetaPixelFormat";
            this.labelMetaPixelFormat.Size = new System.Drawing.Size(42, 13);
            this.labelMetaPixelFormat.TabIndex = 1;
            this.labelMetaPixelFormat.Text = "Format:";
            // 
            // labelMetaHeight
            // 
            this.labelMetaHeight.AutoSize = true;
            this.labelMetaHeight.Location = new System.Drawing.Point(6, 48);
            this.labelMetaHeight.Name = "labelMetaHeight";
            this.labelMetaHeight.Size = new System.Drawing.Size(60, 13);
            this.labelMetaHeight.TabIndex = 1;
            this.labelMetaHeight.Text = "Wysokość:";
            // 
            // labelMetaWidth
            // 
            this.labelMetaWidth.AutoSize = true;
            this.labelMetaWidth.Location = new System.Drawing.Point(6, 35);
            this.labelMetaWidth.Name = "labelMetaWidth";
            this.labelMetaWidth.Size = new System.Drawing.Size(60, 13);
            this.labelMetaWidth.TabIndex = 1;
            this.labelMetaWidth.Text = "Szerokość:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "META";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelBottom.Controls.Add(this.buttonRotateRight);
            this.panelBottom.Controls.Add(this.buttonRotateLeft);
            this.panelBottom.Controls.Add(this.buttonNext);
            this.panelBottom.Controls.Add(this.buttonLast);
            this.panelBottom.Controls.Add(this.buttonFirst);
            this.panelBottom.Controls.Add(this.buttonPrev);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 540);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(665, 56);
            this.panelBottom.TabIndex = 1;
            // 
            // buttonRotateRight
            // 
            this.buttonRotateRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRotateRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRotateRight.BackgroundImage")));
            this.buttonRotateRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRotateRight.Location = new System.Drawing.Point(461, 5);
            this.buttonRotateRight.Name = "buttonRotateRight";
            this.buttonRotateRight.Size = new System.Drawing.Size(48, 48);
            this.buttonRotateRight.TabIndex = 3;
            this.buttonRotateRight.UseVisualStyleBackColor = true;
            this.buttonRotateRight.Click += new System.EventHandler(this.buttonRotateRight_Click);
            // 
            // buttonRotateLeft
            // 
            this.buttonRotateLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRotateLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRotateLeft.BackgroundImage")));
            this.buttonRotateLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRotateLeft.Location = new System.Drawing.Point(407, 5);
            this.buttonRotateLeft.Name = "buttonRotateLeft";
            this.buttonRotateLeft.Size = new System.Drawing.Size(48, 48);
            this.buttonRotateLeft.TabIndex = 2;
            this.buttonRotateLeft.UseVisualStyleBackColor = true;
            this.buttonRotateLeft.Click += new System.EventHandler(this.buttonRotateLeft_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNext.BackgroundImage")));
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNext.Location = new System.Drawing.Point(261, 5);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(48, 48);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLast.BackgroundImage")));
            this.buttonLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLast.Location = new System.Drawing.Point(315, 5);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(48, 48);
            this.buttonLast.TabIndex = 0;
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFirst.BackgroundImage")));
            this.buttonFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonFirst.Location = new System.Drawing.Point(153, 5);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(48, 48);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPrev.BackgroundImage")));
            this.buttonPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPrev.Location = new System.Drawing.Point(207, 5);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(48, 48);
            this.buttonPrev.TabIndex = 0;
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 596);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Images gallery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelList.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.groupBoxGallery.ResumeLayout(false);
            this.groupBoxGallery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPictureSize)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxDirectoryPath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TrackBar trackBarPictureSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxGallery;
        private System.Windows.Forms.CheckBox checkBoxGallery;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Button buttonRotateRight;
        private System.Windows.Forms.Button buttonRotateLeft;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Label labelMetaName;
        private System.Windows.Forms.Label labelMetaPixelFormat;
        private System.Windows.Forms.Label labelMetaHeight;
        private System.Windows.Forms.Label labelMetaWidth;
    }
}

