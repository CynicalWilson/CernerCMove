using System.Windows.Forms;

namespace CernerCMove
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageConnect = new System.Windows.Forms.TabPage();
            this.targetTransferSyntax2 = new MetroFramework.Controls.MetroComboBox();
            this.sourceTransferSyntax1 = new MetroFramework.Controls.MetroComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.targetVerifyProgress = new System.Windows.Forms.ProgressBar();
            this.sourceVerifyProgress = new System.Windows.Forms.ProgressBar();
            this.connectLogWindowClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.connectLogWindowOpen = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.connectLogWindow = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.targetVerifyBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.sourceVerifyBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.targetAET = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.targetPort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.targetHostIP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sourceAET = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sourcePort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBoxCAMMSourceDBCheck = new System.Windows.Forms.PictureBox();
            this.LabelCAMM6SourceDBCheckValue = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelNonProdLB = new System.Windows.Forms.Label();
            this.sourceHostIP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.searchResultsProgress = new System.Windows.Forms.ProgressBar();
            this.pictureBoxSearchFailed = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.searchCAMMSelect = new MetroFramework.Controls.MetroComboBox();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.searchCAMMPort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.searchCAMMAET = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.searchMrnAccProgress = new System.Windows.Forms.ProgressBar();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.searchACCtxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.searchMRNtxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.utilityAET = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.saveDCMFilesLocallyCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModalityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STUDYDESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AA_OID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPageConnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCAMMSourceDBCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchFailed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelVersion.Location = new System.Drawing.Point(6, 5);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(35, 13);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CernerCMove.Properties.Resources.CernerAppLogo;
            this.pictureBox1.Location = new System.Drawing.Point(313, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(360, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CernerCMove";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPageConnect);
            this.materialTabControl1.Controls.Add(this.tabPageSearch);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-2, 87);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(839, 548);
            this.materialTabControl1.TabIndex = 3;
            // 
            // tabPageConnect
            // 
            this.tabPageConnect.BackColor = System.Drawing.Color.SlateGray;
            this.tabPageConnect.Controls.Add(this.saveDCMFilesLocallyCheckBox);
            this.tabPageConnect.Controls.Add(this.materialDivider3);
            this.tabPageConnect.Controls.Add(this.pictureBox8);
            this.tabPageConnect.Controls.Add(this.label20);
            this.tabPageConnect.Controls.Add(this.utilityAET);
            this.tabPageConnect.Controls.Add(this.targetTransferSyntax2);
            this.tabPageConnect.Controls.Add(this.sourceTransferSyntax1);
            this.tabPageConnect.Controls.Add(this.label11);
            this.tabPageConnect.Controls.Add(this.label10);
            this.tabPageConnect.Controls.Add(this.targetVerifyProgress);
            this.tabPageConnect.Controls.Add(this.sourceVerifyProgress);
            this.tabPageConnect.Controls.Add(this.connectLogWindowClear);
            this.tabPageConnect.Controls.Add(this.connectLogWindowOpen);
            this.tabPageConnect.Controls.Add(this.materialDivider1);
            this.tabPageConnect.Controls.Add(this.connectLogWindow);
            this.tabPageConnect.Controls.Add(this.targetVerifyBtn);
            this.tabPageConnect.Controls.Add(this.sourceVerifyBtn);
            this.tabPageConnect.Controls.Add(this.targetAET);
            this.tabPageConnect.Controls.Add(this.targetPort);
            this.tabPageConnect.Controls.Add(this.label6);
            this.tabPageConnect.Controls.Add(this.label7);
            this.tabPageConnect.Controls.Add(this.label8);
            this.tabPageConnect.Controls.Add(this.targetHostIP);
            this.tabPageConnect.Controls.Add(this.pictureBox4);
            this.tabPageConnect.Controls.Add(this.label4);
            this.tabPageConnect.Controls.Add(this.sourceAET);
            this.tabPageConnect.Controls.Add(this.sourcePort);
            this.tabPageConnect.Controls.Add(this.pictureBoxCAMMSourceDBCheck);
            this.tabPageConnect.Controls.Add(this.LabelCAMM6SourceDBCheckValue);
            this.tabPageConnect.Controls.Add(this.pictureBox2);
            this.tabPageConnect.Controls.Add(this.label9);
            this.tabPageConnect.Controls.Add(this.label5);
            this.tabPageConnect.Controls.Add(this.label3);
            this.tabPageConnect.Controls.Add(this.label2);
            this.tabPageConnect.Controls.Add(this.pictureBox3);
            this.tabPageConnect.Controls.Add(this.labelNonProdLB);
            this.tabPageConnect.Controls.Add(this.sourceHostIP);
            this.tabPageConnect.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnect.Name = "tabPageConnect";
            this.tabPageConnect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnect.Size = new System.Drawing.Size(831, 522);
            this.tabPageConnect.TabIndex = 0;
            this.tabPageConnect.Text = "Connect";
            // 
            // targetTransferSyntax2
            // 
            this.targetTransferSyntax2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.targetTransferSyntax2.BackColor = System.Drawing.Color.SlateGray;
            this.targetTransferSyntax2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.targetTransferSyntax2.ForeColor = System.Drawing.Color.White;
            this.targetTransferSyntax2.FormattingEnabled = true;
            this.targetTransferSyntax2.ItemHeight = 23;
            this.targetTransferSyntax2.Items.AddRange(new object[] {
            "Implicit Little",
            "Explicit Little"});
            this.targetTransferSyntax2.Location = new System.Drawing.Point(594, 245);
            this.targetTransferSyntax2.Name = "targetTransferSyntax2";
            this.targetTransferSyntax2.Size = new System.Drawing.Size(143, 29);
            this.targetTransferSyntax2.Style = MetroFramework.MetroColorStyle.Silver;
            this.targetTransferSyntax2.TabIndex = 270;
            this.targetTransferSyntax2.UseCustomBackColor = true;
            this.targetTransferSyntax2.UseSelectable = true;
            // 
            // sourceTransferSyntax1
            // 
            this.sourceTransferSyntax1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sourceTransferSyntax1.BackColor = System.Drawing.Color.SlateGray;
            this.sourceTransferSyntax1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sourceTransferSyntax1.ForeColor = System.Drawing.Color.White;
            this.sourceTransferSyntax1.FormattingEnabled = true;
            this.sourceTransferSyntax1.ItemHeight = 23;
            this.sourceTransferSyntax1.Items.AddRange(new object[] {
            "Implicit Little",
            "Explicit Little"});
            this.sourceTransferSyntax1.Location = new System.Drawing.Point(594, 135);
            this.sourceTransferSyntax1.Name = "sourceTransferSyntax1";
            this.sourceTransferSyntax1.Size = new System.Drawing.Size(143, 29);
            this.sourceTransferSyntax1.Style = MetroFramework.MetroColorStyle.Silver;
            this.sourceTransferSyntax1.TabIndex = 269;
            this.sourceTransferSyntax1.UseCustomBackColor = true;
            this.sourceTransferSyntax1.UseSelectable = true;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(594, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 21);
            this.label11.TabIndex = 250;
            this.label11.Text = "Transfer Syntax";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(594, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 21);
            this.label10.TabIndex = 249;
            this.label10.Text = "Transfer Syntax";
            // 
            // targetVerifyProgress
            // 
            this.targetVerifyProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.targetVerifyProgress.Location = new System.Drawing.Point(744, 267);
            this.targetVerifyProgress.MarqueeAnimationSpeed = 50;
            this.targetVerifyProgress.Name = "targetVerifyProgress";
            this.targetVerifyProgress.Size = new System.Drawing.Size(66, 8);
            this.targetVerifyProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.targetVerifyProgress.TabIndex = 246;
            // 
            // sourceVerifyProgress
            // 
            this.sourceVerifyProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sourceVerifyProgress.Location = new System.Drawing.Point(744, 157);
            this.sourceVerifyProgress.MarqueeAnimationSpeed = 50;
            this.sourceVerifyProgress.Name = "sourceVerifyProgress";
            this.sourceVerifyProgress.Size = new System.Drawing.Size(66, 8);
            this.sourceVerifyProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.sourceVerifyProgress.TabIndex = 245;
            // 
            // connectLogWindowClear
            // 
            this.connectLogWindowClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.connectLogWindowClear.AutoSize = true;
            this.connectLogWindowClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectLogWindowClear.Depth = 0;
            this.connectLogWindowClear.Icon = null;
            this.connectLogWindowClear.Location = new System.Drawing.Point(678, 493);
            this.connectLogWindowClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.connectLogWindowClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectLogWindowClear.Name = "connectLogWindowClear";
            this.connectLogWindowClear.Primary = false;
            this.connectLogWindowClear.Size = new System.Drawing.Size(63, 36);
            this.connectLogWindowClear.TabIndex = 244;
            this.connectLogWindowClear.Text = "Clear";
            this.connectLogWindowClear.UseVisualStyleBackColor = true;
            this.connectLogWindowClear.Click += new System.EventHandler(this.connectLogWindowClear_Click);
            // 
            // connectLogWindowOpen
            // 
            this.connectLogWindowOpen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.connectLogWindowOpen.AutoSize = true;
            this.connectLogWindowOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectLogWindowOpen.Depth = 0;
            this.connectLogWindowOpen.Icon = null;
            this.connectLogWindowOpen.Location = new System.Drawing.Point(749, 493);
            this.connectLogWindowOpen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.connectLogWindowOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectLogWindowOpen.Name = "connectLogWindowOpen";
            this.connectLogWindowOpen.Primary = false;
            this.connectLogWindowOpen.Size = new System.Drawing.Size(57, 36);
            this.connectLogWindowOpen.TabIndex = 243;
            this.connectLogWindowOpen.Text = "Open";
            this.connectLogWindowOpen.UseVisualStyleBackColor = true;
            this.connectLogWindowOpen.Click += new System.EventHandler(this.connectLogWindowOpen_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(38, 290);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(750, 2);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // connectLogWindow
            // 
            this.connectLogWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectLogWindow.BorderColor = System.Drawing.Color.SeaGreen;
            this.connectLogWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectLogWindow.Location = new System.Drawing.Point(15, 304);
            this.connectLogWindow.Multiline = true;
            this.connectLogWindow.Name = "connectLogWindow";
            this.connectLogWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.connectLogWindow.Size = new System.Drawing.Size(795, 180);
            this.connectLogWindow.TabIndex = 10;
            // 
            // targetVerifyBtn
            // 
            this.targetVerifyBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.targetVerifyBtn.AutoSize = true;
            this.targetVerifyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.targetVerifyBtn.Depth = 0;
            this.targetVerifyBtn.Icon = null;
            this.targetVerifyBtn.Location = new System.Drawing.Point(744, 239);
            this.targetVerifyBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.targetVerifyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.targetVerifyBtn.Name = "targetVerifyBtn";
            this.targetVerifyBtn.Primary = false;
            this.targetVerifyBtn.Size = new System.Drawing.Size(66, 36);
            this.targetVerifyBtn.TabIndex = 9;
            this.targetVerifyBtn.Text = "Verify";
            this.targetVerifyBtn.UseVisualStyleBackColor = true;
            this.targetVerifyBtn.Click += new System.EventHandler(this.targetVerifyBtn_Click);
            // 
            // sourceVerifyBtn
            // 
            this.sourceVerifyBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sourceVerifyBtn.AutoSize = true;
            this.sourceVerifyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sourceVerifyBtn.Depth = 0;
            this.sourceVerifyBtn.Icon = null;
            this.sourceVerifyBtn.Location = new System.Drawing.Point(744, 131);
            this.sourceVerifyBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sourceVerifyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.sourceVerifyBtn.Name = "sourceVerifyBtn";
            this.sourceVerifyBtn.Primary = false;
            this.sourceVerifyBtn.Size = new System.Drawing.Size(66, 36);
            this.sourceVerifyBtn.TabIndex = 4;
            this.sourceVerifyBtn.Text = "Verify";
            this.sourceVerifyBtn.UseVisualStyleBackColor = true;
            this.sourceVerifyBtn.Click += new System.EventHandler(this.sourceVerifyBtn_Click);
            // 
            // targetAET
            // 
            this.targetAET.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.targetAET.BackColor = System.Drawing.Color.Azure;
            this.targetAET.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.targetAET.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetAET.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.targetAET.HintForeColor = System.Drawing.Color.Empty;
            this.targetAET.HintText = "";
            this.targetAET.isPassword = false;
            this.targetAET.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.targetAET.LineIdleColor = System.Drawing.Color.Black;
            this.targetAET.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.targetAET.LineThickness = 4;
            this.targetAET.Location = new System.Drawing.Point(302, 246);
            this.targetAET.Margin = new System.Windows.Forms.Padding(4);
            this.targetAET.Name = "targetAET";
            this.targetAET.Size = new System.Drawing.Size(178, 32);
            this.targetAET.TabIndex = 6;
            this.targetAET.Text = "CLEAR1";
            this.targetAET.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // targetPort
            // 
            this.targetPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.targetPort.BackColor = System.Drawing.Color.Azure;
            this.targetPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.targetPort.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.targetPort.HintForeColor = System.Drawing.Color.Empty;
            this.targetPort.HintText = "";
            this.targetPort.isPassword = false;
            this.targetPort.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.targetPort.LineIdleColor = System.Drawing.Color.Black;
            this.targetPort.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.targetPort.LineThickness = 4;
            this.targetPort.Location = new System.Drawing.Point(488, 246);
            this.targetPort.Margin = new System.Windows.Forms.Padding(4);
            this.targetPort.Name = "targetPort";
            this.targetPort.Size = new System.Drawing.Size(95, 32);
            this.targetPort.TabIndex = 7;
            this.targetPort.Text = "108";
            this.targetPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(484, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 21);
            this.label6.TabIndex = 237;
            this.label6.Text = "Port";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(30, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 236;
            this.label7.Text = "Hostname/IP";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(299, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 21);
            this.label8.TabIndex = 235;
            this.label8.Text = "AET";
            // 
            // targetHostIP
            // 
            this.targetHostIP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.targetHostIP.BackColor = System.Drawing.Color.Azure;
            this.targetHostIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.targetHostIP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetHostIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.targetHostIP.HintForeColor = System.Drawing.Color.Empty;
            this.targetHostIP.HintText = "";
            this.targetHostIP.isPassword = false;
            this.targetHostIP.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.targetHostIP.LineIdleColor = System.Drawing.Color.Black;
            this.targetHostIP.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.targetHostIP.LineThickness = 4;
            this.targetHostIP.Location = new System.Drawing.Point(34, 246);
            this.targetHostIP.Margin = new System.Windows.Forms.Padding(4);
            this.targetHostIP.Name = "targetHostIP";
            this.targetHostIP.Size = new System.Drawing.Size(256, 32);
            this.targetHostIP.TabIndex = 5;
            this.targetHostIP.Text = "192.168.1.65";
            this.targetHostIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(237, 186);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 233;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(263, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 232;
            this.label4.Text = "Successful!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sourceAET
            // 
            this.sourceAET.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sourceAET.BackColor = System.Drawing.Color.Azure;
            this.sourceAET.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sourceAET.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceAET.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sourceAET.HintForeColor = System.Drawing.Color.Empty;
            this.sourceAET.HintText = "";
            this.sourceAET.isPassword = false;
            this.sourceAET.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.sourceAET.LineIdleColor = System.Drawing.Color.Black;
            this.sourceAET.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.sourceAET.LineThickness = 4;
            this.sourceAET.Location = new System.Drawing.Point(300, 136);
            this.sourceAET.Margin = new System.Windows.Forms.Padding(4);
            this.sourceAET.Name = "sourceAET";
            this.sourceAET.Size = new System.Drawing.Size(178, 32);
            this.sourceAET.TabIndex = 1;
            this.sourceAET.Text = "MZX-CAMM";
            this.sourceAET.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sourcePort
            // 
            this.sourcePort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sourcePort.BackColor = System.Drawing.Color.Azure;
            this.sourcePort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sourcePort.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourcePort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sourcePort.HintForeColor = System.Drawing.Color.Empty;
            this.sourcePort.HintText = "";
            this.sourcePort.isPassword = false;
            this.sourcePort.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.sourcePort.LineIdleColor = System.Drawing.Color.Black;
            this.sourcePort.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.sourcePort.LineThickness = 4;
            this.sourcePort.Location = new System.Drawing.Point(490, 136);
            this.sourcePort.Margin = new System.Windows.Forms.Padding(4);
            this.sourcePort.Name = "sourcePort";
            this.sourcePort.Size = new System.Drawing.Size(95, 32);
            this.sourcePort.TabIndex = 2;
            this.sourcePort.Text = "4444";
            this.sourcePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBoxCAMMSourceDBCheck
            // 
            this.pictureBoxCAMMSourceDBCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxCAMMSourceDBCheck.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCAMMSourceDBCheck.Image")));
            this.pictureBoxCAMMSourceDBCheck.Location = new System.Drawing.Point(237, 75);
            this.pictureBoxCAMMSourceDBCheck.Name = "pictureBoxCAMMSourceDBCheck";
            this.pictureBoxCAMMSourceDBCheck.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCAMMSourceDBCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCAMMSourceDBCheck.TabIndex = 227;
            this.pictureBoxCAMMSourceDBCheck.TabStop = false;
            // 
            // LabelCAMM6SourceDBCheckValue
            // 
            this.LabelCAMM6SourceDBCheckValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelCAMM6SourceDBCheckValue.AutoSize = true;
            this.LabelCAMM6SourceDBCheckValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCAMM6SourceDBCheckValue.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelCAMM6SourceDBCheckValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelCAMM6SourceDBCheckValue.Location = new System.Drawing.Point(263, 75);
            this.LabelCAMM6SourceDBCheckValue.Name = "LabelCAMM6SourceDBCheckValue";
            this.LabelCAMM6SourceDBCheckValue.Size = new System.Drawing.Size(87, 21);
            this.LabelCAMM6SourceDBCheckValue.TabIndex = 226;
            this.LabelCAMM6SourceDBCheckValue.Text = "Successful!";
            this.LabelCAMM6SourceDBCheckValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 222;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(46, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 21);
            this.label9.TabIndex = 221;
            this.label9.Text = "Target CAMM Details";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(486, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 220;
            this.label5.Text = "Port";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(34, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 219;
            this.label3.Text = "Hostname/IP";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(296, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 218;
            this.label2.Text = "AET";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 217;
            this.pictureBox3.TabStop = false;
            // 
            // labelNonProdLB
            // 
            this.labelNonProdLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNonProdLB.AutoSize = true;
            this.labelNonProdLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNonProdLB.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNonProdLB.Location = new System.Drawing.Point(46, 74);
            this.labelNonProdLB.Name = "labelNonProdLB";
            this.labelNonProdLB.Size = new System.Drawing.Size(161, 21);
            this.labelNonProdLB.TabIndex = 216;
            this.labelNonProdLB.Text = "Source CAMM Details";
            // 
            // sourceHostIP
            // 
            this.sourceHostIP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sourceHostIP.BackColor = System.Drawing.Color.Azure;
            this.sourceHostIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sourceHostIP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceHostIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sourceHostIP.HintForeColor = System.Drawing.Color.Empty;
            this.sourceHostIP.HintText = "";
            this.sourceHostIP.isPassword = false;
            this.sourceHostIP.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.sourceHostIP.LineIdleColor = System.Drawing.Color.Black;
            this.sourceHostIP.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.sourceHostIP.LineThickness = 4;
            this.sourceHostIP.Location = new System.Drawing.Point(38, 136);
            this.sourceHostIP.Margin = new System.Windows.Forms.Padding(4);
            this.sourceHostIP.Name = "sourceHostIP";
            this.sourceHostIP.Size = new System.Drawing.Size(256, 32);
            this.sourceHostIP.TabIndex = 0;
            this.sourceHostIP.Text = "192.168.1.4";
            this.sourceHostIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.BackColor = System.Drawing.Color.SlateGray;
            this.tabPageSearch.Controls.Add(this.materialFlatButton5);
            this.tabPageSearch.Controls.Add(this.materialFlatButton4);
            this.tabPageSearch.Controls.Add(this.pictureBox9);
            this.tabPageSearch.Controls.Add(this.label19);
            this.tabPageSearch.Controls.Add(this.searchResultsProgress);
            this.tabPageSearch.Controls.Add(this.pictureBoxSearchFailed);
            this.tabPageSearch.Controls.Add(this.label18);
            this.tabPageSearch.Controls.Add(this.materialFlatButton3);
            this.tabPageSearch.Controls.Add(this.pictureBox7);
            this.tabPageSearch.Controls.Add(this.label17);
            this.tabPageSearch.Controls.Add(this.metroGrid1);
            this.tabPageSearch.Controls.Add(this.searchCAMMSelect);
            this.tabPageSearch.Controls.Add(this.materialDivider2);
            this.tabPageSearch.Controls.Add(this.materialFlatButton2);
            this.tabPageSearch.Controls.Add(this.pictureBox6);
            this.tabPageSearch.Controls.Add(this.searchCAMMPort);
            this.tabPageSearch.Controls.Add(this.searchCAMMAET);
            this.tabPageSearch.Controls.Add(this.label15);
            this.tabPageSearch.Controls.Add(this.label16);
            this.tabPageSearch.Controls.Add(this.searchMrnAccProgress);
            this.tabPageSearch.Controls.Add(this.materialFlatButton1);
            this.tabPageSearch.Controls.Add(this.searchACCtxtbox);
            this.tabPageSearch.Controls.Add(this.label13);
            this.tabPageSearch.Controls.Add(this.label14);
            this.tabPageSearch.Controls.Add(this.searchMRNtxtbox);
            this.tabPageSearch.Controls.Add(this.pictureBox5);
            this.tabPageSearch.Controls.Add(this.label12);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(831, 522);
            this.tabPageSearch.TabIndex = 1;
            this.tabPageSearch.Text = "Search / Send";
            // 
            // searchResultsProgress
            // 
            this.searchResultsProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchResultsProgress.Location = new System.Drawing.Point(769, 507);
            this.searchResultsProgress.MarqueeAnimationSpeed = 50;
            this.searchResultsProgress.Name = "searchResultsProgress";
            this.searchResultsProgress.Size = new System.Drawing.Size(56, 8);
            this.searchResultsProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.searchResultsProgress.TabIndex = 266;
            // 
            // pictureBoxSearchFailed
            // 
            this.pictureBoxSearchFailed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxSearchFailed.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearchFailed.Image")));
            this.pictureBoxSearchFailed.Location = new System.Drawing.Point(170, 466);
            this.pictureBoxSearchFailed.Name = "pictureBoxSearchFailed";
            this.pictureBoxSearchFailed.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxSearchFailed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearchFailed.TabIndex = 328;
            this.pictureBoxSearchFailed.TabStop = false;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.Location = new System.Drawing.Point(194, 463);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 21);
            this.label18.TabIndex = 274;
            this.label18.Text = "Successful!";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(669, 480);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(94, 36);
            this.materialFlatButton3.TabIndex = 272;
            this.materialFlatButton3.Text = "Searh Log";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(22, 466);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 271;
            this.pictureBox7.TabStop = false;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Location = new System.Drawing.Point(46, 464);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 21);
            this.label17.TabIndex = 270;
            this.label17.Text = "Successful!";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.name,
            this.pid,
            this.accession,
            this.ModalityType,
            this.STUDYDESC,
            this.DT,
            this.SUID,
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
            this.metroGrid1.Location = new System.Drawing.Point(13, 128);
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
            this.metroGrid1.Size = new System.Drawing.Size(812, 327);
            this.metroGrid1.TabIndex = 269;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGrid1.UseCustomBackColor = true;
            // 
            // searchCAMMSelect
            // 
            this.searchCAMMSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchCAMMSelect.BackColor = System.Drawing.Color.SlateGray;
            this.searchCAMMSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchCAMMSelect.ForeColor = System.Drawing.SystemColors.Control;
            this.searchCAMMSelect.FormattingEnabled = true;
            this.searchCAMMSelect.ItemHeight = 23;
            this.searchCAMMSelect.Location = new System.Drawing.Point(110, 9);
            this.searchCAMMSelect.Name = "searchCAMMSelect";
            this.searchCAMMSelect.Size = new System.Drawing.Size(314, 29);
            this.searchCAMMSelect.Style = MetroFramework.MetroColorStyle.Silver;
            this.searchCAMMSelect.TabIndex = 268;
            this.searchCAMMSelect.UseCustomBackColor = true;
            this.searchCAMMSelect.UseSelectable = true;
            this.searchCAMMSelect.UseStyleColors = true;
            this.searchCAMMSelect.SelectedIndexChanged += new System.EventHandler(this.searchCAMMSelect_SelectedIndexChanged);
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(40, 56);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(750, 2);
            this.materialDivider2.TabIndex = 267;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(767, 479);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(56, 36);
            this.materialFlatButton2.TabIndex = 265;
            this.materialFlatButton2.Text = "Send";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(15, 78);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 263;
            this.pictureBox6.TabStop = false;
            // 
            // searchCAMMPort
            // 
            this.searchCAMMPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchCAMMPort.BackColor = System.Drawing.Color.Silver;
            this.searchCAMMPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchCAMMPort.Enabled = false;
            this.searchCAMMPort.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCAMMPort.ForeColor = System.Drawing.Color.Black;
            this.searchCAMMPort.HintForeColor = System.Drawing.Color.Empty;
            this.searchCAMMPort.HintText = "";
            this.searchCAMMPort.isPassword = false;
            this.searchCAMMPort.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.searchCAMMPort.LineIdleColor = System.Drawing.Color.Black;
            this.searchCAMMPort.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.searchCAMMPort.LineThickness = 4;
            this.searchCAMMPort.Location = new System.Drawing.Point(716, 10);
            this.searchCAMMPort.Margin = new System.Windows.Forms.Padding(4);
            this.searchCAMMPort.Name = "searchCAMMPort";
            this.searchCAMMPort.Size = new System.Drawing.Size(102, 29);
            this.searchCAMMPort.TabIndex = 262;
            this.searchCAMMPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // searchCAMMAET
            // 
            this.searchCAMMAET.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchCAMMAET.BackColor = System.Drawing.Color.Silver;
            this.searchCAMMAET.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchCAMMAET.Enabled = false;
            this.searchCAMMAET.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCAMMAET.ForeColor = System.Drawing.Color.Black;
            this.searchCAMMAET.HintForeColor = System.Drawing.Color.Empty;
            this.searchCAMMAET.HintText = "";
            this.searchCAMMAET.isPassword = false;
            this.searchCAMMAET.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.searchCAMMAET.LineIdleColor = System.Drawing.Color.Black;
            this.searchCAMMAET.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.searchCAMMAET.LineThickness = 4;
            this.searchCAMMAET.Location = new System.Drawing.Point(481, 10);
            this.searchCAMMAET.Margin = new System.Windows.Forms.Padding(4);
            this.searchCAMMAET.Name = "searchCAMMAET";
            this.searchCAMMAET.Size = new System.Drawing.Size(171, 29);
            this.searchCAMMAET.TabIndex = 261;
            this.searchCAMMAET.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(435, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 21);
            this.label15.TabIndex = 260;
            this.label15.Text = "AET:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(658, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 21);
            this.label16.TabIndex = 259;
            this.label16.Text = "PORT:";
            // 
            // searchMrnAccProgress
            // 
            this.searchMrnAccProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchMrnAccProgress.Location = new System.Drawing.Point(756, 100);
            this.searchMrnAccProgress.MarqueeAnimationSpeed = 50;
            this.searchMrnAccProgress.Name = "searchMrnAccProgress";
            this.searchMrnAccProgress.Size = new System.Drawing.Size(66, 8);
            this.searchMrnAccProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.searchMrnAccProgress.TabIndex = 258;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(752, 74);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(73, 36);
            this.materialFlatButton1.TabIndex = 257;
            this.materialFlatButton1.Text = "Search";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // searchACCtxtbox
            // 
            this.searchACCtxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchACCtxtbox.BackColor = System.Drawing.Color.Azure;
            this.searchACCtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchACCtxtbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchACCtxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchACCtxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.searchACCtxtbox.HintText = "";
            this.searchACCtxtbox.isPassword = false;
            this.searchACCtxtbox.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.searchACCtxtbox.LineIdleColor = System.Drawing.Color.Black;
            this.searchACCtxtbox.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.searchACCtxtbox.LineThickness = 4;
            this.searchACCtxtbox.Location = new System.Drawing.Point(481, 81);
            this.searchACCtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchACCtxtbox.Name = "searchACCtxtbox";
            this.searchACCtxtbox.Size = new System.Drawing.Size(261, 29);
            this.searchACCtxtbox.TabIndex = 256;
            this.searchACCtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(46, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 21);
            this.label13.TabIndex = 255;
            this.label13.Text = "MRN:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(431, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 21);
            this.label14.TabIndex = 254;
            this.label14.Text = "ACC:";
            // 
            // searchMRNtxtbox
            // 
            this.searchMRNtxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchMRNtxtbox.BackColor = System.Drawing.Color.Azure;
            this.searchMRNtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchMRNtxtbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMRNtxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchMRNtxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.searchMRNtxtbox.HintText = "";
            this.searchMRNtxtbox.isPassword = false;
            this.searchMRNtxtbox.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.searchMRNtxtbox.LineIdleColor = System.Drawing.Color.Black;
            this.searchMRNtxtbox.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.searchMRNtxtbox.LineThickness = 4;
            this.searchMRNtxtbox.Location = new System.Drawing.Point(110, 81);
            this.searchMRNtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchMRNtxtbox.Name = "searchMRNtxtbox";
            this.searchMRNtxtbox.Size = new System.Drawing.Size(314, 29);
            this.searchMRNtxtbox.TabIndex = 253;
            this.searchMRNtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(15, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 252;
            this.pictureBox5.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(46, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 21);
            this.label12.TabIndex = 251;
            this.label12.Text = "CAMM:";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabSelector1.Location = new System.Drawing.Point(-2, 52);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(839, 37);
            this.materialTabSelector1.TabIndex = 4;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.connectLogWindow;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.metroGrid1;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(46, 490);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 21);
            this.label19.TabIndex = 329;
            this.label19.Text = "Successful!";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(19, 492);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(25, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 331;
            this.pictureBox9.TabStop = false;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(427, 480);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(119, 36);
            this.materialFlatButton4.TabIndex = 332;
            this.materialFlatButton4.Text = "storeSCU Log";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Icon = null;
            this.materialFlatButton5.Location = new System.Drawing.Point(550, 480);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(115, 36);
            this.materialFlatButton5.TabIndex = 333;
            this.materialFlatButton5.Text = "moveSCU Log";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            this.materialFlatButton5.Click += new System.EventHandler(this.materialFlatButton5_Click);
            // 
            // utilityAET
            // 
            this.utilityAET.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.utilityAET.BackColor = System.Drawing.Color.Azure;
            this.utilityAET.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.utilityAET.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilityAET.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.utilityAET.HintForeColor = System.Drawing.Color.Empty;
            this.utilityAET.HintText = "";
            this.utilityAET.isPassword = false;
            this.utilityAET.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.utilityAET.LineIdleColor = System.Drawing.Color.Black;
            this.utilityAET.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.utilityAET.LineThickness = 4;
            this.utilityAET.Location = new System.Drawing.Point(144, 18);
            this.utilityAET.Margin = new System.Windows.Forms.Padding(4);
            this.utilityAET.Name = "utilityAET";
            this.utilityAET.Size = new System.Drawing.Size(336, 29);
            this.utilityAET.TabIndex = 271;
            this.utilityAET.Text = "CERNERDCM";
            this.utilityAET.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(46, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 21);
            this.label20.TabIndex = 272;
            this.label20.Text = "Calling AET:";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(16, 16);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 273;
            this.pictureBox8.TabStop = false;
            // 
            // materialDivider3
            // 
            this.materialDivider3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(40, 61);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(750, 2);
            this.materialDivider3.TabIndex = 274;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // saveDCMFilesLocallyCheckBox
            // 
            this.saveDCMFilesLocallyCheckBox.AutoSize = true;
            this.saveDCMFilesLocallyCheckBox.Depth = 0;
            this.saveDCMFilesLocallyCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.saveDCMFilesLocallyCheckBox.Location = new System.Drawing.Point(490, 16);
            this.saveDCMFilesLocallyCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.saveDCMFilesLocallyCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.saveDCMFilesLocallyCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveDCMFilesLocallyCheckBox.Name = "saveDCMFilesLocallyCheckBox";
            this.saveDCMFilesLocallyCheckBox.Ripple = true;
            this.saveDCMFilesLocallyCheckBox.Size = new System.Drawing.Size(136, 30);
            this.saveDCMFilesLocallyCheckBox.TabIndex = 276;
            this.saveDCMFilesLocallyCheckBox.Text = "Create DCM Files";
            this.saveDCMFilesLocallyCheckBox.UseVisualStyleBackColor = true;
            this.saveDCMFilesLocallyCheckBox.CheckedChanged += new System.EventHandler(this.saveDCMFilesLocallyCheckBox_CheckedChanged);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.FillWeight = 80F;
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // pid
            // 
            this.pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pid.FillWeight = 80F;
            this.pid.HeaderText = "MRN/PID";
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            // 
            // accession
            // 
            this.accession.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accession.FillWeight = 80F;
            this.accession.HeaderText = "ACCESSION";
            this.accession.Name = "accession";
            this.accession.ReadOnly = true;
            // 
            // ModalityType
            // 
            this.ModalityType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModalityType.FillWeight = 80F;
            this.ModalityType.HeaderText = "Modality";
            this.ModalityType.Name = "ModalityType";
            this.ModalityType.ReadOnly = true;
            // 
            // STUDYDESC
            // 
            this.STUDYDESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STUDYDESC.FillWeight = 80F;
            this.STUDYDESC.HeaderText = "StudyDesc";
            this.STUDYDESC.Name = "STUDYDESC";
            this.STUDYDESC.ReadOnly = true;
            // 
            // DT
            // 
            this.DT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DT.FillWeight = 80F;
            this.DT.HeaderText = "StudyDT";
            this.DT.Name = "DT";
            this.DT.ReadOnly = true;
            // 
            // SUID
            // 
            this.SUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUID.FillWeight = 80F;
            this.SUID.HeaderText = "SUID";
            this.SUID.Name = "SUID";
            this.SUID.ReadOnly = true;
            // 
            // AA_OID
            // 
            this.AA_OID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AA_OID.HeaderText = "AA-ID";
            this.AA_OID.Name = "AA_OID";
            this.AA_OID.ReadOnly = true;
            this.AA_OID.Width = 74;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 641);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(837, 641);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageConnect.ResumeLayout(false);
            this.tabPageConnect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCAMMSourceDBCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchFailed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageConnect;
        private System.Windows.Forms.TabPage tabPageSearch;
        public MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sourceHostIP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sourceAET;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sourcePort;
        private System.Windows.Forms.PictureBox pictureBoxCAMMSourceDBCheck;
        private System.Windows.Forms.Label LabelCAMM6SourceDBCheckValue;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelNonProdLB;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialFlatButton targetVerifyBtn;
        private MaterialSkin.Controls.MaterialFlatButton sourceVerifyBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox targetAET;
        private Bunifu.Framework.UI.BunifuMaterialTextbox targetPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox targetHostIP;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox connectLogWindow;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialFlatButton connectLogWindowOpen;
        private MaterialSkin.Controls.MaterialFlatButton connectLogWindowClear;
        private System.Windows.Forms.ProgressBar sourceVerifyProgress;
        private System.Windows.Forms.ProgressBar targetVerifyProgress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar searchMrnAccProgress;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchACCtxtbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchMRNtxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchCAMMPort;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchCAMMAET;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ProgressBar searchResultsProgress;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MetroFramework.Controls.MetroComboBox searchCAMMSelect;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private PictureBox pictureBox7;
        private Label label17;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private Label label18;
        private PictureBox pictureBoxSearchFailed;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private MetroFramework.Controls.MetroComboBox targetTransferSyntax2;
        private MetroFramework.Controls.MetroComboBox sourceTransferSyntax1;
        private PictureBox pictureBox9;
        private Label label19;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private Label label20;
        private Bunifu.Framework.UI.BunifuMaterialTextbox utilityAET;
        private PictureBox pictureBox8;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialCheckBox saveDCMFilesLocallyCheckBox;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn pid;
        private DataGridViewTextBoxColumn accession;
        private DataGridViewTextBoxColumn ModalityType;
        private DataGridViewTextBoxColumn STUDYDESC;
        private DataGridViewTextBoxColumn DT;
        private DataGridViewTextBoxColumn SUID;
        private DataGridViewTextBoxColumn AA_OID;
    }
}

