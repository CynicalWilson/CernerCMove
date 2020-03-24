namespace HyperionDCM
{
    partial class viewImagesFromSUID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewImagesFromSUID));
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.imageViewMRN = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.imageViewPatientName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageViewStudyUID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchSaveFilesLocally = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.viewDICOMHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeGRP6KTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.ViewImageDetailsProgressBar = new System.Windows.Forms.ProgressBar();
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ModalityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOP_UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIES_UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AA_OID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.materialContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModalityType,
            this.SOP_UID,
            this.SERIES_UID,
            this.AA_OID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(13, 139);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(664, 239);
            this.metroGrid1.TabIndex = 270;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGrid1.UseCustomBackColor = true;
            this.metroGrid1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroGrid1_MouseClick);
            // 
            // imageViewMRN
            // 
            this.imageViewMRN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imageViewMRN.BackColor = System.Drawing.Color.Silver;
            this.imageViewMRN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imageViewMRN.Enabled = false;
            this.imageViewMRN.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageViewMRN.ForeColor = System.Drawing.Color.Black;
            this.imageViewMRN.HintForeColor = System.Drawing.Color.Empty;
            this.imageViewMRN.HintText = "";
            this.imageViewMRN.isPassword = false;
            this.imageViewMRN.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.imageViewMRN.LineIdleColor = System.Drawing.Color.Black;
            this.imageViewMRN.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.imageViewMRN.LineThickness = 4;
            this.imageViewMRN.Location = new System.Drawing.Point(71, 66);
            this.imageViewMRN.Margin = new System.Windows.Forms.Padding(4);
            this.imageViewMRN.Name = "imageViewMRN";
            this.imageViewMRN.Size = new System.Drawing.Size(176, 29);
            this.imageViewMRN.TabIndex = 272;
            this.imageViewMRN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(13, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 21);
            this.label16.TabIndex = 271;
            this.label16.Text = "MRN:";
            // 
            // imageViewPatientName
            // 
            this.imageViewPatientName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imageViewPatientName.BackColor = System.Drawing.Color.Silver;
            this.imageViewPatientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imageViewPatientName.Enabled = false;
            this.imageViewPatientName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageViewPatientName.ForeColor = System.Drawing.Color.Black;
            this.imageViewPatientName.HintForeColor = System.Drawing.Color.Empty;
            this.imageViewPatientName.HintText = "";
            this.imageViewPatientName.isPassword = false;
            this.imageViewPatientName.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.imageViewPatientName.LineIdleColor = System.Drawing.Color.Black;
            this.imageViewPatientName.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.imageViewPatientName.LineThickness = 4;
            this.imageViewPatientName.Location = new System.Drawing.Point(379, 66);
            this.imageViewPatientName.Margin = new System.Windows.Forms.Padding(4);
            this.imageViewPatientName.Name = "imageViewPatientName";
            this.imageViewPatientName.Size = new System.Drawing.Size(298, 29);
            this.imageViewPatientName.TabIndex = 274;
            this.imageViewPatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(254, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 273;
            this.label1.Text = "PATIENT NAME:";
            // 
            // imageViewStudyUID
            // 
            this.imageViewStudyUID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imageViewStudyUID.BackColor = System.Drawing.Color.Silver;
            this.imageViewStudyUID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imageViewStudyUID.Enabled = false;
            this.imageViewStudyUID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageViewStudyUID.ForeColor = System.Drawing.Color.Black;
            this.imageViewStudyUID.HintForeColor = System.Drawing.Color.Empty;
            this.imageViewStudyUID.HintText = "";
            this.imageViewStudyUID.isPassword = false;
            this.imageViewStudyUID.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.imageViewStudyUID.LineIdleColor = System.Drawing.Color.Black;
            this.imageViewStudyUID.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.imageViewStudyUID.LineThickness = 4;
            this.imageViewStudyUID.Location = new System.Drawing.Point(111, 103);
            this.imageViewStudyUID.Margin = new System.Windows.Forms.Padding(4);
            this.imageViewStudyUID.Name = "imageViewStudyUID";
            this.imageViewStudyUID.Size = new System.Drawing.Size(566, 29);
            this.imageViewStudyUID.TabIndex = 278;
            this.imageViewStudyUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 277;
            this.label2.Text = "STUDY UID:";
            // 
            // searchSaveFilesLocally
            // 
            this.searchSaveFilesLocally.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchSaveFilesLocally.AutoSize = true;
            this.searchSaveFilesLocally.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchSaveFilesLocally.Depth = 0;
            this.searchSaveFilesLocally.Icon = null;
            this.searchSaveFilesLocally.Location = new System.Drawing.Point(614, 387);
            this.searchSaveFilesLocally.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchSaveFilesLocally.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchSaveFilesLocally.Name = "searchSaveFilesLocally";
            this.searchSaveFilesLocally.Primary = false;
            this.searchSaveFilesLocally.Size = new System.Drawing.Size(63, 36);
            this.searchSaveFilesLocally.TabIndex = 335;
            this.searchSaveFilesLocally.Text = "Close";
            this.searchSaveFilesLocally.UseVisualStyleBackColor = true;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDICOMHeaderToolStripMenuItem,
            this.removeGRP6KTagsToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(185, 48);
            // 
            // viewDICOMHeaderToolStripMenuItem
            // 
            this.viewDICOMHeaderToolStripMenuItem.Name = "viewDICOMHeaderToolStripMenuItem";
            this.viewDICOMHeaderToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.viewDICOMHeaderToolStripMenuItem.Text = "View DICOM Header";
            this.viewDICOMHeaderToolStripMenuItem.Click += new System.EventHandler(this.viewDICOMHeaderToolStripMenuItem_Click);
            // 
            // removeGRP6KTagsToolStripMenuItem
            // 
            this.removeGRP6KTagsToolStripMenuItem.Name = "removeGRP6KTagsToolStripMenuItem";
            this.removeGRP6KTagsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.removeGRP6KTagsToolStripMenuItem.Text = "Remove GRP 6K Tags";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(42, 405);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 21);
            this.label19.TabIndex = 339;
            this.label19.Text = "Successful!";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Location = new System.Drawing.Point(41, 379);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 21);
            this.label17.TabIndex = 337;
            this.label17.Text = "Successful!";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox10.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(17, 407);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(18, 16);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 340;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(17, 379);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 341;
            this.pictureBox7.TabStop = false;
            // 
            // ViewImageDetailsProgressBar
            // 
            this.ViewImageDetailsProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ViewImageDetailsProgressBar.Location = new System.Drawing.Point(192, 35);
            this.ViewImageDetailsProgressBar.MarqueeAnimationSpeed = 50;
            this.ViewImageDetailsProgressBar.Name = "ViewImageDetailsProgressBar";
            this.ViewImageDetailsProgressBar.Size = new System.Drawing.Size(66, 14);
            this.ViewImageDetailsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ViewImageDetailsProgressBar.TabIndex = 342;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 15;
            this.bunifuElipse5.TargetControl = this.materialContextMenuStrip1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.metroGrid1;
            // 
            // ModalityType
            // 
            this.ModalityType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModalityType.HeaderText = "Modality";
            this.ModalityType.Name = "ModalityType";
            this.ModalityType.ReadOnly = true;
            // 
            // SOP_UID
            // 
            this.SOP_UID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SOP_UID.HeaderText = "SOP UID";
            this.SOP_UID.Name = "SOP_UID";
            this.SOP_UID.ReadOnly = true;
            // 
            // SERIES_UID
            // 
            this.SERIES_UID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SERIES_UID.HeaderText = "Series UID";
            this.SERIES_UID.Name = "SERIES_UID";
            this.SERIES_UID.ReadOnly = true;
            // 
            // AA_OID
            // 
            this.AA_OID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AA_OID.DividerWidth = 1;
            this.AA_OID.HeaderText = "AA-ID";
            this.AA_OID.Name = "AA_OID";
            this.AA_OID.ReadOnly = true;
            // 
            // viewImagesFromSUID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(690, 428);
            this.Controls.Add(this.ViewImageDetailsProgressBar);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.searchSaveFilesLocally);
            this.Controls.Add(this.imageViewStudyUID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageViewPatientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageViewMRN);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.metroGrid1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "viewImagesFromSUID";
            this.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Viewing Image Details";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.materialContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox imageViewMRN;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuMaterialTextbox imageViewPatientName;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox imageViewStudyUID;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialFlatButton searchSaveFilesLocally;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewDICOMHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeGRP6KTagsToolStripMenuItem;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ProgressBar ViewImageDetailsProgressBar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModalityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOP_UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIES_UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AA_OID;
    }
}
