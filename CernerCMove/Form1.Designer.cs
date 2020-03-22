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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Connect = new System.Windows.Forms.TabPage();
            this.materialFlatButton11 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.utilityAET = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.Search_Send = new System.Windows.Forms.TabPage();
            this.searchPatientLevel = new MaterialSkin.Controls.MaterialCheckBox();
            this.searchStudyLevel = new MaterialSkin.Controls.MaterialCheckBox();
            this.searchSeriesLevel = new MaterialSkin.Controls.MaterialCheckBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.materialFlatButton10 = new MaterialSkin.Controls.MaterialFlatButton();
            this.searchSaveFilesLocally = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label19 = new System.Windows.Forms.Label();
            this.searchResultsProgress = new System.Windows.Forms.ProgressBar();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label17 = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModalityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STUDYDESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AA_OID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCAMMSelect = new MetroFramework.Controls.MetroComboBox();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSearchFailed = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.MWL = new System.Windows.Forms.TabPage();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.mwlDateSearchChecbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.mwlToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label31 = new System.Windows.Forms.Label();
            this.mwlFromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.mwlModalitySearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label30 = new System.Windows.Forms.Label();
            this.mwlSCPHost = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label28 = new System.Windows.Forms.Label();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton7 = new MaterialSkin.Controls.MaterialFlatButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label22 = new System.Windows.Forms.Label();
            this.materialFlatButton8 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label23 = new System.Windows.Forms.Label();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STUDYSUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODALITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDERSTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCHDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialFlatButton9 = new MaterialSkin.Controls.MaterialFlatButton();
            this.mwlSCPPort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.mwlSCPAET = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.mwlSearchButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.label27 = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.adhocSend = new System.Windows.Forms.TabPage();
            this.adhocSendFolderSelect = new MaterialSkin.Controls.MaterialFlatButton();
            this.adhocSendFolderPath = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialDivider7 = new MaterialSkin.Controls.MaterialDivider();
            this.label32 = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.materialFlatButton12 = new MaterialSkin.Controls.MaterialFlatButton();
            this.adhocSearchFileName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            this.label34 = new System.Windows.Forms.Label();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.adhocSendDropdown = new MetroFramework.Controls.MetroComboBox();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.adhocSendPort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.adhocSendAet = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label21 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.adhocSendLogWindow = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.adhocSendButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label33 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.label36 = new System.Windows.Forms.Label();
            this.adhocSendStoreSCULog = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabControl1.SuspendLayout();
            this.Connect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCAMMSourceDBCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Search_Send.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.materialContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchFailed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.MWL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.adhocSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(478, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "DCM";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.Connect);
            this.materialTabControl1.Controls.Add(this.Search_Send);
            this.materialTabControl1.Controls.Add(this.MWL);
            this.materialTabControl1.Controls.Add(this.adhocSend);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-2, 87);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(839, 548);
            this.materialTabControl1.TabIndex = 3;
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.SlateGray;
            this.Connect.Controls.Add(this.materialFlatButton11);
            this.Connect.Controls.Add(this.materialDivider3);
            this.Connect.Controls.Add(this.pictureBox8);
            this.Connect.Controls.Add(this.label20);
            this.Connect.Controls.Add(this.utilityAET);
            this.Connect.Controls.Add(this.targetTransferSyntax2);
            this.Connect.Controls.Add(this.sourceTransferSyntax1);
            this.Connect.Controls.Add(this.label11);
            this.Connect.Controls.Add(this.label10);
            this.Connect.Controls.Add(this.targetVerifyProgress);
            this.Connect.Controls.Add(this.sourceVerifyProgress);
            this.Connect.Controls.Add(this.connectLogWindowClear);
            this.Connect.Controls.Add(this.connectLogWindowOpen);
            this.Connect.Controls.Add(this.materialDivider1);
            this.Connect.Controls.Add(this.connectLogWindow);
            this.Connect.Controls.Add(this.targetVerifyBtn);
            this.Connect.Controls.Add(this.sourceVerifyBtn);
            this.Connect.Controls.Add(this.targetAET);
            this.Connect.Controls.Add(this.targetPort);
            this.Connect.Controls.Add(this.label6);
            this.Connect.Controls.Add(this.label7);
            this.Connect.Controls.Add(this.label8);
            this.Connect.Controls.Add(this.targetHostIP);
            this.Connect.Controls.Add(this.pictureBox4);
            this.Connect.Controls.Add(this.label4);
            this.Connect.Controls.Add(this.sourceAET);
            this.Connect.Controls.Add(this.sourcePort);
            this.Connect.Controls.Add(this.pictureBoxCAMMSourceDBCheck);
            this.Connect.Controls.Add(this.LabelCAMM6SourceDBCheckValue);
            this.Connect.Controls.Add(this.pictureBox2);
            this.Connect.Controls.Add(this.label9);
            this.Connect.Controls.Add(this.label5);
            this.Connect.Controls.Add(this.label3);
            this.Connect.Controls.Add(this.label2);
            this.Connect.Controls.Add(this.pictureBox3);
            this.Connect.Controls.Add(this.labelNonProdLB);
            this.Connect.Controls.Add(this.sourceHostIP);
            this.Connect.Location = new System.Drawing.Point(4, 22);
            this.Connect.Name = "Connect";
            this.Connect.Padding = new System.Windows.Forms.Padding(3);
            this.Connect.Size = new System.Drawing.Size(831, 522);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            // 
            // materialFlatButton11
            // 
            this.materialFlatButton11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialFlatButton11.AutoSize = true;
            this.materialFlatButton11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton11.Depth = 0;
            this.materialFlatButton11.Icon = null;
            this.materialFlatButton11.Location = new System.Drawing.Point(702, 68);
            this.materialFlatButton11.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton11.Name = "materialFlatButton11";
            this.materialFlatButton11.Primary = false;
            this.materialFlatButton11.Size = new System.Drawing.Size(109, 36);
            this.materialFlatButton11.TabIndex = 275;
            this.materialFlatButton11.Text = "Switch AETs";
            this.materialFlatButton11.UseVisualStyleBackColor = true;
            this.materialFlatButton11.Click += new System.EventHandler(this.materialFlatButton11_Click);
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
            this.connectLogWindowClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.connectLogWindowOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.connectLogWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectLogWindow.BackColor = System.Drawing.SystemColors.GrayText;
            this.connectLogWindow.BorderColor = System.Drawing.Color.SeaGreen;
            this.connectLogWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connectLogWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectLogWindow.ForeColor = System.Drawing.SystemColors.Window;
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
            this.label9.Size = new System.Drawing.Size(135, 21);
            this.label9.TabIndex = 221;
            this.label9.Text = "Target SCP Details";
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
            this.labelNonProdLB.Size = new System.Drawing.Size(141, 21);
            this.labelNonProdLB.TabIndex = 216;
            this.labelNonProdLB.Text = "Source SCP Details";
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
            // Search_Send
            // 
            this.Search_Send.BackColor = System.Drawing.Color.SlateGray;
            this.Search_Send.Controls.Add(this.searchPatientLevel);
            this.Search_Send.Controls.Add(this.searchStudyLevel);
            this.Search_Send.Controls.Add(this.searchSeriesLevel);
            this.Search_Send.Controls.Add(this.pictureBox10);
            this.Search_Send.Controls.Add(this.materialFlatButton10);
            this.Search_Send.Controls.Add(this.searchSaveFilesLocally);
            this.Search_Send.Controls.Add(this.materialFlatButton5);
            this.Search_Send.Controls.Add(this.materialFlatButton4);
            this.Search_Send.Controls.Add(this.label19);
            this.Search_Send.Controls.Add(this.searchResultsProgress);
            this.Search_Send.Controls.Add(this.materialFlatButton3);
            this.Search_Send.Controls.Add(this.label17);
            this.Search_Send.Controls.Add(this.metroGrid1);
            this.Search_Send.Controls.Add(this.searchCAMMSelect);
            this.Search_Send.Controls.Add(this.materialDivider2);
            this.Search_Send.Controls.Add(this.materialFlatButton2);
            this.Search_Send.Controls.Add(this.searchCAMMPort);
            this.Search_Send.Controls.Add(this.searchCAMMAET);
            this.Search_Send.Controls.Add(this.label15);
            this.Search_Send.Controls.Add(this.label16);
            this.Search_Send.Controls.Add(this.searchMrnAccProgress);
            this.Search_Send.Controls.Add(this.materialFlatButton1);
            this.Search_Send.Controls.Add(this.searchACCtxtbox);
            this.Search_Send.Controls.Add(this.label13);
            this.Search_Send.Controls.Add(this.label14);
            this.Search_Send.Controls.Add(this.searchMRNtxtbox);
            this.Search_Send.Controls.Add(this.label12);
            this.Search_Send.Controls.Add(this.label18);
            this.Search_Send.Controls.Add(this.pictureBox6);
            this.Search_Send.Controls.Add(this.pictureBox5);
            this.Search_Send.Controls.Add(this.pictureBoxSearchFailed);
            this.Search_Send.Controls.Add(this.pictureBox7);
            this.Search_Send.Location = new System.Drawing.Point(4, 22);
            this.Search_Send.Name = "Search_Send";
            this.Search_Send.Padding = new System.Windows.Forms.Padding(3);
            this.Search_Send.Size = new System.Drawing.Size(831, 522);
            this.Search_Send.TabIndex = 1;
            this.Search_Send.Text = "Search / Send";
            // 
            // searchPatientLevel
            // 
            this.searchPatientLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchPatientLevel.AutoSize = true;
            this.searchPatientLevel.Depth = 0;
            this.searchPatientLevel.Font = new System.Drawing.Font("Roboto", 10F);
            this.searchPatientLevel.Location = new System.Drawing.Point(450, 61);
            this.searchPatientLevel.Margin = new System.Windows.Forms.Padding(0);
            this.searchPatientLevel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.searchPatientLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchPatientLevel.Name = "searchPatientLevel";
            this.searchPatientLevel.Ripple = true;
            this.searchPatientLevel.Size = new System.Drawing.Size(101, 30);
            this.searchPatientLevel.TabIndex = 377;
            this.searchPatientLevel.Text = "Patient Q/R";
            this.searchPatientLevel.UseVisualStyleBackColor = true;
            this.searchPatientLevel.CheckedChanged += new System.EventHandler(this.searchPatientLevel_CheckedChanged);
            // 
            // searchStudyLevel
            // 
            this.searchStudyLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchStudyLevel.AutoSize = true;
            this.searchStudyLevel.Depth = 0;
            this.searchStudyLevel.Font = new System.Drawing.Font("Roboto", 10F);
            this.searchStudyLevel.Location = new System.Drawing.Point(580, 61);
            this.searchStudyLevel.Margin = new System.Windows.Forms.Padding(0);
            this.searchStudyLevel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.searchStudyLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchStudyLevel.Name = "searchStudyLevel";
            this.searchStudyLevel.Ripple = true;
            this.searchStudyLevel.Size = new System.Drawing.Size(92, 30);
            this.searchStudyLevel.TabIndex = 376;
            this.searchStudyLevel.Text = "Study Q/R";
            this.searchStudyLevel.UseVisualStyleBackColor = true;
            this.searchStudyLevel.CheckedChanged += new System.EventHandler(this.searchStudyLevel_CheckedChanged);
            // 
            // searchSeriesLevel
            // 
            this.searchSeriesLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchSeriesLevel.AutoSize = true;
            this.searchSeriesLevel.Depth = 0;
            this.searchSeriesLevel.Font = new System.Drawing.Font("Roboto", 10F);
            this.searchSeriesLevel.Location = new System.Drawing.Point(701, 61);
            this.searchSeriesLevel.Margin = new System.Windows.Forms.Padding(0);
            this.searchSeriesLevel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.searchSeriesLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchSeriesLevel.Name = "searchSeriesLevel";
            this.searchSeriesLevel.Ripple = true;
            this.searchSeriesLevel.Size = new System.Drawing.Size(95, 30);
            this.searchSeriesLevel.TabIndex = 375;
            this.searchSeriesLevel.Text = "Series Q/R";
            this.searchSeriesLevel.UseVisualStyleBackColor = true;
            this.searchSeriesLevel.CheckedChanged += new System.EventHandler(this.searchSeriesLevel_CheckedChanged);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox10.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(24, 464);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(18, 16);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 336;
            this.pictureBox10.TabStop = false;
            // 
            // materialFlatButton10
            // 
            this.materialFlatButton10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton10.AutoSize = true;
            this.materialFlatButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton10.Depth = 0;
            this.materialFlatButton10.Icon = null;
            this.materialFlatButton10.Location = new System.Drawing.Point(200, 485);
            this.materialFlatButton10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton10.Name = "materialFlatButton10";
            this.materialFlatButton10.Primary = false;
            this.materialFlatButton10.Size = new System.Drawing.Size(105, 36);
            this.materialFlatButton10.TabIndex = 335;
            this.materialFlatButton10.Text = "downloads";
            this.materialFlatButton10.UseVisualStyleBackColor = true;
            this.materialFlatButton10.Click += new System.EventHandler(this.materialFlatButton10_Click);
            // 
            // searchSaveFilesLocally
            // 
            this.searchSaveFilesLocally.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchSaveFilesLocally.AutoSize = true;
            this.searchSaveFilesLocally.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchSaveFilesLocally.Depth = 0;
            this.searchSaveFilesLocally.Icon = null;
            this.searchSaveFilesLocally.Location = new System.Drawing.Point(657, 484);
            this.searchSaveFilesLocally.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchSaveFilesLocally.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchSaveFilesLocally.Name = "searchSaveFilesLocally";
            this.searchSaveFilesLocally.Primary = false;
            this.searchSaveFilesLocally.Size = new System.Drawing.Size(101, 36);
            this.searchSaveFilesLocally.TabIndex = 334;
            this.searchSaveFilesLocally.Text = "Save Study";
            this.searchSaveFilesLocally.UseVisualStyleBackColor = true;
            this.searchSaveFilesLocally.Click += new System.EventHandler(this.searchSaveFilesLocally_Click);
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Icon = null;
            this.materialFlatButton5.Location = new System.Drawing.Point(436, 485);
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
            // materialFlatButton4
            // 
            this.materialFlatButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(311, 485);
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
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(49, 462);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 21);
            this.label19.TabIndex = 329;
            this.label19.Text = "Successful!";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchResultsProgress
            // 
            this.searchResultsProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchResultsProgress.Location = new System.Drawing.Point(769, 512);
            this.searchResultsProgress.MarqueeAnimationSpeed = 50;
            this.searchResultsProgress.Name = "searchResultsProgress";
            this.searchResultsProgress.Size = new System.Drawing.Size(51, 8);
            this.searchResultsProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.searchResultsProgress.TabIndex = 266;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(557, 485);
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
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Location = new System.Drawing.Point(48, 436);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
            this.metroGrid1.ContextMenuStrip = this.materialContextMenuStrip1;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(13, 135);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(812, 299);
            this.metroGrid1.TabIndex = 269;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGrid1.UseCustomBackColor = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.FillWeight = 90F;
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // pid
            // 
            this.pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pid.FillWeight = 90F;
            this.pid.HeaderText = "MRN/PID";
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            // 
            // accession
            // 
            this.accession.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accession.FillWeight = 90F;
            this.accession.HeaderText = "ACCESSION";
            this.accession.Name = "accession";
            this.accession.ReadOnly = true;
            // 
            // ModalityType
            // 
            this.ModalityType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModalityType.FillWeight = 90F;
            this.ModalityType.HeaderText = "Modality";
            this.ModalityType.Name = "ModalityType";
            this.ModalityType.ReadOnly = true;
            // 
            // STUDYDESC
            // 
            this.STUDYDESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STUDYDESC.FillWeight = 90F;
            this.STUDYDESC.HeaderText = "StudyDesc";
            this.STUDYDESC.Name = "STUDYDESC";
            this.STUDYDESC.ReadOnly = true;
            // 
            // DT
            // 
            this.DT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DT.FillWeight = 90F;
            this.DT.HeaderText = "StudyDT";
            this.DT.Name = "DT";
            this.DT.ReadOnly = true;
            // 
            // SUID
            // 
            this.SUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUID.FillWeight = 90F;
            this.SUID.HeaderText = "SUID";
            this.SUID.Name = "SUID";
            this.SUID.ReadOnly = true;
            // 
            // AA_OID
            // 
            this.AA_OID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AA_OID.HeaderText = "AA-ID";
            this.AA_OID.Name = "AA_OID";
            this.AA_OID.ReadOnly = true;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.sendToolStripMenuItem,
            this.downloadToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(129, 70);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sendToolStripMenuItem.Text = "Send";
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            // 
            // searchCAMMSelect
            // 
            this.searchCAMMSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchCAMMSelect.BackColor = System.Drawing.Color.SlateGray;
            this.searchCAMMSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchCAMMSelect.ForeColor = System.Drawing.SystemColors.Control;
            this.searchCAMMSelect.FormattingEnabled = true;
            this.searchCAMMSelect.ItemHeight = 23;
            this.searchCAMMSelect.Location = new System.Drawing.Point(137, 9);
            this.searchCAMMSelect.Name = "searchCAMMSelect";
            this.searchCAMMSelect.Size = new System.Drawing.Size(287, 29);
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
            this.materialDivider2.Location = new System.Drawing.Point(40, 52);
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
            this.materialFlatButton2.Location = new System.Drawing.Point(764, 484);
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
            this.searchMrnAccProgress.Location = new System.Drawing.Point(756, 116);
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
            this.materialFlatButton1.Location = new System.Drawing.Point(752, 90);
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
            this.searchACCtxtbox.Location = new System.Drawing.Point(481, 97);
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
            this.label13.Location = new System.Drawing.Point(46, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 21);
            this.label13.TabIndex = 255;
            this.label13.Text = "MRN / PID:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(431, 100);
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
            this.searchMRNtxtbox.Location = new System.Drawing.Point(137, 97);
            this.searchMRNtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchMRNtxtbox.Name = "searchMRNtxtbox";
            this.searchMRNtxtbox.Size = new System.Drawing.Size(287, 29);
            this.searchMRNtxtbox.TabIndex = 253;
            this.searchMRNtxtbox.Text = "008";
            this.searchMRNtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(46, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 21);
            this.label12.TabIndex = 251;
            this.label12.Text = "SCP HOST:";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.Location = new System.Drawing.Point(48, 435);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 21);
            this.label18.TabIndex = 274;
            this.label18.Text = "Successful!";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(15, 94);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 263;
            this.pictureBox6.TabStop = false;
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
            // pictureBoxSearchFailed
            // 
            this.pictureBoxSearchFailed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxSearchFailed.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearchFailed.Image")));
            this.pictureBoxSearchFailed.Location = new System.Drawing.Point(24, 438);
            this.pictureBoxSearchFailed.Name = "pictureBoxSearchFailed";
            this.pictureBoxSearchFailed.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxSearchFailed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearchFailed.TabIndex = 328;
            this.pictureBoxSearchFailed.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(24, 438);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 271;
            this.pictureBox7.TabStop = false;
            // 
            // MWL
            // 
            this.MWL.BackColor = System.Drawing.Color.SlateGray;
            this.MWL.Controls.Add(this.materialDivider4);
            this.MWL.Controls.Add(this.mwlDateSearchChecbox);
            this.MWL.Controls.Add(this.mwlToDatePicker);
            this.MWL.Controls.Add(this.label31);
            this.MWL.Controls.Add(this.mwlFromDatePicker);
            this.MWL.Controls.Add(this.mwlModalitySearch);
            this.MWL.Controls.Add(this.label30);
            this.MWL.Controls.Add(this.mwlSCPHost);
            this.MWL.Controls.Add(this.label28);
            this.MWL.Controls.Add(this.materialFlatButton6);
            this.MWL.Controls.Add(this.materialFlatButton7);
            this.MWL.Controls.Add(this.progressBar1);
            this.MWL.Controls.Add(this.label22);
            this.MWL.Controls.Add(this.materialFlatButton8);
            this.MWL.Controls.Add(this.label23);
            this.MWL.Controls.Add(this.metroGrid2);
            this.MWL.Controls.Add(this.materialFlatButton9);
            this.MWL.Controls.Add(this.mwlSCPPort);
            this.MWL.Controls.Add(this.mwlSCPAET);
            this.MWL.Controls.Add(this.label24);
            this.MWL.Controls.Add(this.label25);
            this.MWL.Controls.Add(this.progressBar2);
            this.MWL.Controls.Add(this.mwlSearchButton);
            this.MWL.Controls.Add(this.label27);
            this.MWL.Controls.Add(this.pictureBox15);
            this.MWL.Controls.Add(this.pictureBox11);
            this.MWL.Controls.Add(this.pictureBox12);
            this.MWL.Controls.Add(this.pictureBox13);
            this.MWL.Controls.Add(this.pictureBox14);
            this.MWL.Location = new System.Drawing.Point(4, 22);
            this.MWL.Name = "MWL";
            this.MWL.Size = new System.Drawing.Size(831, 522);
            this.MWL.TabIndex = 2;
            this.MWL.Text = "MWL";
            // 
            // materialDivider4
            // 
            this.materialDivider4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(40, 141);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(750, 2);
            this.materialDivider4.TabIndex = 375;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // mwlDateSearchChecbox
            // 
            this.mwlDateSearchChecbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mwlDateSearchChecbox.AutoSize = true;
            this.mwlDateSearchChecbox.Depth = 0;
            this.mwlDateSearchChecbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.mwlDateSearchChecbox.Location = new System.Drawing.Point(649, 56);
            this.mwlDateSearchChecbox.Margin = new System.Windows.Forms.Padding(0);
            this.mwlDateSearchChecbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mwlDateSearchChecbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.mwlDateSearchChecbox.Name = "mwlDateSearchChecbox";
            this.mwlDateSearchChecbox.Ripple = true;
            this.mwlDateSearchChecbox.Size = new System.Drawing.Size(26, 30);
            this.mwlDateSearchChecbox.TabIndex = 374;
            this.mwlDateSearchChecbox.UseVisualStyleBackColor = true;
            this.mwlDateSearchChecbox.CheckedChanged += new System.EventHandler(this.mwlDateSearchChecbox_CheckedChanged);
            // 
            // mwlToDatePicker
            // 
            this.mwlToDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mwlToDatePicker.Enabled = false;
            this.mwlToDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mwlToDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mwlToDatePicker.Location = new System.Drawing.Point(447, 56);
            this.mwlToDatePicker.Name = "mwlToDatePicker";
            this.mwlToDatePicker.Size = new System.Drawing.Size(181, 29);
            this.mwlToDatePicker.TabIndex = 376;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.Control;
            this.label31.Location = new System.Drawing.Point(368, 60);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 21);
            this.label31.TabIndex = 372;
            this.label31.Text = "TO DATE:";
            // 
            // mwlFromDatePicker
            // 
            this.mwlFromDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mwlFromDatePicker.Enabled = false;
            this.mwlFromDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mwlFromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mwlFromDatePicker.Location = new System.Drawing.Point(143, 56);
            this.mwlFromDatePicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.mwlFromDatePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.mwlFromDatePicker.Name = "mwlFromDatePicker";
            this.mwlFromDatePicker.Size = new System.Drawing.Size(218, 29);
            this.mwlFromDatePicker.TabIndex = 375;
            // 
            // mwlModalitySearch
            // 
            this.mwlModalitySearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mwlModalitySearch.BackColor = System.Drawing.Color.Azure;
            this.mwlModalitySearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mwlModalitySearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mwlModalitySearch.ForeColor = System.Drawing.Color.Black;
            this.mwlModalitySearch.HintForeColor = System.Drawing.Color.Empty;
            this.mwlModalitySearch.HintText = "";
            this.mwlModalitySearch.isPassword = false;
            this.mwlModalitySearch.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.mwlModalitySearch.LineIdleColor = System.Drawing.Color.Black;
            this.mwlModalitySearch.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.mwlModalitySearch.LineThickness = 4;
            this.mwlModalitySearch.Location = new System.Drawing.Point(143, 99);
            this.mwlModalitySearch.Margin = new System.Windows.Forms.Padding(4);
            this.mwlModalitySearch.Name = "mwlModalitySearch";
            this.mwlModalitySearch.Size = new System.Drawing.Size(88, 29);
            this.mwlModalitySearch.TabIndex = 373;
            this.mwlModalitySearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.Control;
            this.label30.Location = new System.Drawing.Point(50, 102);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(89, 21);
            this.label30.TabIndex = 369;
            this.label30.Text = "MODALITY:";
            // 
            // mwlSCPHost
            // 
            this.mwlSCPHost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mwlSCPHost.BackColor = System.Drawing.Color.Azure;
            this.mwlSCPHost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mwlSCPHost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mwlSCPHost.ForeColor = System.Drawing.Color.Black;
            this.mwlSCPHost.HintForeColor = System.Drawing.Color.Empty;
            this.mwlSCPHost.HintText = "";
            this.mwlSCPHost.isPassword = false;
            this.mwlSCPHost.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.mwlSCPHost.LineIdleColor = System.Drawing.Color.Black;
            this.mwlSCPHost.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.mwlSCPHost.LineThickness = 4;
            this.mwlSCPHost.Location = new System.Drawing.Point(143, 12);
            this.mwlSCPHost.Margin = new System.Windows.Forms.Padding(4);
            this.mwlSCPHost.Name = "mwlSCPHost";
            this.mwlSCPHost.Size = new System.Drawing.Size(218, 29);
            this.mwlSCPHost.TabIndex = 368;
            this.mwlSCPHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.Control;
            this.label28.Location = new System.Drawing.Point(49, 16);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(85, 21);
            this.label28.TabIndex = 367;
            this.label28.Text = "SCP HOST:";
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Icon = null;
            this.materialFlatButton6.Location = new System.Drawing.Point(546, 479);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(115, 36);
            this.materialFlatButton6.TabIndex = 360;
            this.materialFlatButton6.Text = "moveSCU Log";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton7
            // 
            this.materialFlatButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton7.AutoSize = true;
            this.materialFlatButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton7.Depth = 0;
            this.materialFlatButton7.Icon = null;
            this.materialFlatButton7.Location = new System.Drawing.Point(423, 479);
            this.materialFlatButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton7.Name = "materialFlatButton7";
            this.materialFlatButton7.Primary = false;
            this.materialFlatButton7.Size = new System.Drawing.Size(119, 36);
            this.materialFlatButton7.TabIndex = 359;
            this.materialFlatButton7.Text = "storeSCU Log";
            this.materialFlatButton7.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(765, 506);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(56, 8);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 348;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Control;
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.Location = new System.Drawing.Point(190, 462);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 21);
            this.label22.TabIndex = 355;
            this.label22.Text = "Successful!";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialFlatButton8
            // 
            this.materialFlatButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton8.AutoSize = true;
            this.materialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton8.Depth = 0;
            this.materialFlatButton8.Icon = null;
            this.materialFlatButton8.Location = new System.Drawing.Point(665, 479);
            this.materialFlatButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton8.Name = "materialFlatButton8";
            this.materialFlatButton8.Primary = false;
            this.materialFlatButton8.Size = new System.Drawing.Size(94, 36);
            this.materialFlatButton8.TabIndex = 354;
            this.materialFlatButton8.Text = "Searh Log";
            this.materialFlatButton8.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.Control;
            this.label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label23.Location = new System.Drawing.Point(42, 463);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 21);
            this.label23.TabIndex = 352;
            this.label23.Text = "Successful!";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToAddRows = false;
            this.metroGrid2.AllowUserToDeleteRows = false;
            this.metroGrid2.AllowUserToOrderColumns = true;
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.metroGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.STUDYSUID,
            this.MODALITY,
            this.ORDERSTATUS,
            this.SCHDATE});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid2.Location = new System.Drawing.Point(9, 152);
            this.metroGrid2.MultiSelect = false;
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.ReadOnly = true;
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(812, 302);
            this.metroGrid2.TabIndex = 351;
            this.metroGrid2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGrid2.UseCustomBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 90F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ACCESSION";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 90F;
            this.dataGridViewTextBoxColumn2.HeaderText = "INST. NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 90F;
            this.dataGridViewTextBoxColumn4.HeaderText = "STUDY DESC.";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.FillWeight = 90F;
            this.dataGridViewTextBoxColumn5.HeaderText = "PATIENT NAME";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.FillWeight = 90F;
            this.dataGridViewTextBoxColumn6.HeaderText = "MRN/PID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.FillWeight = 90F;
            this.dataGridViewTextBoxColumn7.HeaderText = "OTHER PID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // STUDYSUID
            // 
            this.STUDYSUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STUDYSUID.FillWeight = 90F;
            this.STUDYSUID.HeaderText = "STUDYSUID";
            this.STUDYSUID.Name = "STUDYSUID";
            this.STUDYSUID.ReadOnly = true;
            // 
            // MODALITY
            // 
            this.MODALITY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MODALITY.FillWeight = 90F;
            this.MODALITY.HeaderText = "MODALITY";
            this.MODALITY.Name = "MODALITY";
            this.MODALITY.ReadOnly = true;
            // 
            // ORDERSTATUS
            // 
            this.ORDERSTATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ORDERSTATUS.FillWeight = 90F;
            this.ORDERSTATUS.HeaderText = "ORDER STATUS";
            this.ORDERSTATUS.Name = "ORDERSTATUS";
            this.ORDERSTATUS.ReadOnly = true;
            // 
            // SCHDATE
            // 
            this.SCHDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SCHDATE.FillWeight = 90F;
            this.SCHDATE.HeaderText = "SCH. DATE";
            this.SCHDATE.Name = "SCHDATE";
            this.SCHDATE.ReadOnly = true;
            // 
            // materialFlatButton9
            // 
            this.materialFlatButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton9.AutoSize = true;
            this.materialFlatButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton9.Depth = 0;
            this.materialFlatButton9.Icon = null;
            this.materialFlatButton9.Location = new System.Drawing.Point(763, 478);
            this.materialFlatButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton9.Name = "materialFlatButton9";
            this.materialFlatButton9.Primary = false;
            this.materialFlatButton9.Size = new System.Drawing.Size(56, 36);
            this.materialFlatButton9.TabIndex = 347;
            this.materialFlatButton9.Text = "Send";
            this.materialFlatButton9.UseVisualStyleBackColor = true;
            // 
            // mwlSCPPort
            // 
            this.mwlSCPPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mwlSCPPort.BackColor = System.Drawing.Color.Azure;
            this.mwlSCPPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mwlSCPPort.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mwlSCPPort.ForeColor = System.Drawing.Color.Black;
            this.mwlSCPPort.HintForeColor = System.Drawing.Color.Empty;
            this.mwlSCPPort.HintText = "";
            this.mwlSCPPort.isPassword = false;
            this.mwlSCPPort.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.mwlSCPPort.LineIdleColor = System.Drawing.Color.Black;
            this.mwlSCPPort.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.mwlSCPPort.LineThickness = 4;
            this.mwlSCPPort.Location = new System.Drawing.Point(731, 11);
            this.mwlSCPPort.Margin = new System.Windows.Forms.Padding(4);
            this.mwlSCPPort.Name = "mwlSCPPort";
            this.mwlSCPPort.Size = new System.Drawing.Size(85, 29);
            this.mwlSCPPort.TabIndex = 3670;
            this.mwlSCPPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mwlSCPAET
            // 
            this.mwlSCPAET.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mwlSCPAET.BackColor = System.Drawing.Color.Azure;
            this.mwlSCPAET.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mwlSCPAET.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mwlSCPAET.ForeColor = System.Drawing.Color.Black;
            this.mwlSCPAET.HintForeColor = System.Drawing.Color.Empty;
            this.mwlSCPAET.HintText = "";
            this.mwlSCPAET.isPassword = false;
            this.mwlSCPAET.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.mwlSCPAET.LineIdleColor = System.Drawing.Color.Black;
            this.mwlSCPAET.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.mwlSCPAET.LineThickness = 4;
            this.mwlSCPAET.Location = new System.Drawing.Point(447, 11);
            this.mwlSCPAET.Margin = new System.Windows.Forms.Padding(4);
            this.mwlSCPAET.Name = "mwlSCPAET";
            this.mwlSCPAET.Size = new System.Drawing.Size(181, 29);
            this.mwlSCPAET.TabIndex = 369;
            this.mwlSCPAET.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.Control;
            this.label24.Location = new System.Drawing.Point(369, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 21);
            this.label24.TabIndex = 343;
            this.label24.Text = "SCP AET:";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.Control;
            this.label25.Location = new System.Drawing.Point(635, 14);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 21);
            this.label25.TabIndex = 342;
            this.label25.Text = "SCP PORT:";
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progressBar2.Location = new System.Drawing.Point(735, 119);
            this.progressBar2.MarqueeAnimationSpeed = 50;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(66, 8);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar2.TabIndex = 341;
            // 
            // mwlSearchButton
            // 
            this.mwlSearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mwlSearchButton.AutoSize = true;
            this.mwlSearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mwlSearchButton.Depth = 0;
            this.mwlSearchButton.Icon = null;
            this.mwlSearchButton.Location = new System.Drawing.Point(731, 93);
            this.mwlSearchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mwlSearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.mwlSearchButton.Name = "mwlSearchButton";
            this.mwlSearchButton.Primary = false;
            this.mwlSearchButton.Size = new System.Drawing.Size(73, 36);
            this.mwlSearchButton.TabIndex = 377;
            this.mwlSearchButton.Text = "Search";
            this.mwlSearchButton.UseVisualStyleBackColor = true;
            this.mwlSearchButton.Click += new System.EventHandler(this.mwlSearchButton_Click);
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.Control;
            this.label27.Location = new System.Drawing.Point(47, 60);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 21);
            this.label27.TabIndex = 337;
            this.label27.Text = "FROM DATE:";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(11, 53);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(32, 32);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 366;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(166, 465);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(20, 20);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 356;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(18, 465);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(20, 20);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 353;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(11, 97);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(32, 32);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 346;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(11, 11);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(32, 32);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 335;
            this.pictureBox14.TabStop = false;
            // 
            // adhocSend
            // 
            this.adhocSend.BackColor = System.Drawing.Color.SlateGray;
            this.adhocSend.Controls.Add(this.adhocSendStoreSCULog);
            this.adhocSend.Controls.Add(this.pictureBox21);
            this.adhocSend.Controls.Add(this.label36);
            this.adhocSend.Controls.Add(this.progressBar3);
            this.adhocSend.Controls.Add(this.label33);
            this.adhocSend.Controls.Add(this.label35);
            this.adhocSend.Controls.Add(this.pictureBox19);
            this.adhocSend.Controls.Add(this.pictureBox20);
            this.adhocSend.Controls.Add(this.adhocSendButton);
            this.adhocSend.Controls.Add(this.adhocSendLogWindow);
            this.adhocSend.Controls.Add(this.adhocSendFolderSelect);
            this.adhocSend.Controls.Add(this.adhocSendFolderPath);
            this.adhocSend.Controls.Add(this.materialDivider7);
            this.adhocSend.Controls.Add(this.label32);
            this.adhocSend.Controls.Add(this.pictureBox18);
            this.adhocSend.Controls.Add(this.materialFlatButton12);
            this.adhocSend.Controls.Add(this.adhocSearchFileName);
            this.adhocSend.Controls.Add(this.materialDivider6);
            this.adhocSend.Controls.Add(this.label34);
            this.adhocSend.Controls.Add(this.pictureBox17);
            this.adhocSend.Controls.Add(this.adhocSendDropdown);
            this.adhocSend.Controls.Add(this.materialDivider5);
            this.adhocSend.Controls.Add(this.adhocSendPort);
            this.adhocSend.Controls.Add(this.adhocSendAet);
            this.adhocSend.Controls.Add(this.label21);
            this.adhocSend.Controls.Add(this.label26);
            this.adhocSend.Controls.Add(this.label29);
            this.adhocSend.Controls.Add(this.pictureBox16);
            this.adhocSend.Location = new System.Drawing.Point(4, 22);
            this.adhocSend.Name = "adhocSend";
            this.adhocSend.Size = new System.Drawing.Size(831, 522);
            this.adhocSend.TabIndex = 3;
            this.adhocSend.Text = "Ad-Hoc Send";
            // 
            // adhocSendFolderSelect
            // 
            this.adhocSendFolderSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adhocSendFolderSelect.AutoSize = true;
            this.adhocSendFolderSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adhocSendFolderSelect.Depth = 0;
            this.adhocSendFolderSelect.Icon = null;
            this.adhocSendFolderSelect.Location = new System.Drawing.Point(744, 130);
            this.adhocSendFolderSelect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.adhocSendFolderSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.adhocSendFolderSelect.Name = "adhocSendFolderSelect";
            this.adhocSendFolderSelect.Primary = false;
            this.adhocSendFolderSelect.Size = new System.Drawing.Size(69, 36);
            this.adhocSendFolderSelect.TabIndex = 290;
            this.adhocSendFolderSelect.Text = "Select";
            this.adhocSendFolderSelect.UseVisualStyleBackColor = true;
            this.adhocSendFolderSelect.Click += new System.EventHandler(this.adhocSendFolderSelect_Click);
            // 
            // adhocSendFolderPath
            // 
            this.adhocSendFolderPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adhocSendFolderPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adhocSendFolderPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adhocSendFolderPath.Enabled = false;
            this.adhocSendFolderPath.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adhocSendFolderPath.ForeColor = System.Drawing.Color.White;
            this.adhocSendFolderPath.HintForeColor = System.Drawing.Color.Empty;
            this.adhocSendFolderPath.HintText = "Select Folder...";
            this.adhocSendFolderPath.isPassword = false;
            this.adhocSendFolderPath.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.adhocSendFolderPath.LineIdleColor = System.Drawing.Color.Black;
            this.adhocSendFolderPath.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.adhocSendFolderPath.LineThickness = 4;
            this.adhocSendFolderPath.Location = new System.Drawing.Point(148, 137);
            this.adhocSendFolderPath.Margin = new System.Windows.Forms.Padding(4);
            this.adhocSendFolderPath.Name = "adhocSendFolderPath";
            this.adhocSendFolderPath.Size = new System.Drawing.Size(588, 29);
            this.adhocSendFolderPath.TabIndex = 289;
            this.adhocSendFolderPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // materialDivider7
            // 
            this.materialDivider7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialDivider7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider7.Depth = 0;
            this.materialDivider7.Location = new System.Drawing.Point(35, 177);
            this.materialDivider7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider7.Name = "materialDivider7";
            this.materialDivider7.Size = new System.Drawing.Size(750, 2);
            this.materialDivider7.TabIndex = 288;
            this.materialDivider7.Text = "materialDivider7";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.Control;
            this.label32.Location = new System.Drawing.Point(50, 139);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(57, 21);
            this.label32.TabIndex = 286;
            this.label32.Text = "Folder:";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(10, 135);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(32, 32);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 287;
            this.pictureBox18.TabStop = false;
            // 
            // materialFlatButton12
            // 
            this.materialFlatButton12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialFlatButton12.AutoSize = true;
            this.materialFlatButton12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton12.Depth = 0;
            this.materialFlatButton12.Icon = null;
            this.materialFlatButton12.Location = new System.Drawing.Point(744, 69);
            this.materialFlatButton12.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton12.Name = "materialFlatButton12";
            this.materialFlatButton12.Primary = false;
            this.materialFlatButton12.Size = new System.Drawing.Size(69, 36);
            this.materialFlatButton12.TabIndex = 285;
            this.materialFlatButton12.Text = "Select";
            this.materialFlatButton12.UseVisualStyleBackColor = true;
            this.materialFlatButton12.Click += new System.EventHandler(this.adhocSendSelectFile_Click);
            // 
            // adhocSearchFileName
            // 
            this.adhocSearchFileName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adhocSearchFileName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adhocSearchFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adhocSearchFileName.Enabled = false;
            this.adhocSearchFileName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adhocSearchFileName.ForeColor = System.Drawing.Color.White;
            this.adhocSearchFileName.HintForeColor = System.Drawing.Color.Empty;
            this.adhocSearchFileName.HintText = "Select File...";
            this.adhocSearchFileName.isPassword = false;
            this.adhocSearchFileName.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.adhocSearchFileName.LineIdleColor = System.Drawing.Color.Black;
            this.adhocSearchFileName.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.adhocSearchFileName.LineThickness = 4;
            this.adhocSearchFileName.Location = new System.Drawing.Point(148, 76);
            this.adhocSearchFileName.Margin = new System.Windows.Forms.Padding(4);
            this.adhocSearchFileName.Name = "adhocSearchFileName";
            this.adhocSearchFileName.Size = new System.Drawing.Size(588, 29);
            this.adhocSearchFileName.TabIndex = 284;
            this.adhocSearchFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // materialDivider6
            // 
            this.materialDivider6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialDivider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider6.Depth = 0;
            this.materialDivider6.Location = new System.Drawing.Point(35, 116);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Size = new System.Drawing.Size(750, 2);
            this.materialDivider6.TabIndex = 283;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.Control;
            this.label34.Location = new System.Drawing.Point(50, 78);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(37, 21);
            this.label34.TabIndex = 277;
            this.label34.Text = "File:";
            // 
            // pictureBox17
            // 
            this.pictureBox17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(10, 74);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(32, 32);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 278;
            this.pictureBox17.TabStop = false;
            // 
            // adhocSendDropdown
            // 
            this.adhocSendDropdown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adhocSendDropdown.BackColor = System.Drawing.Color.SlateGray;
            this.adhocSendDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adhocSendDropdown.ForeColor = System.Drawing.SystemColors.Control;
            this.adhocSendDropdown.FormattingEnabled = true;
            this.adhocSendDropdown.ItemHeight = 23;
            this.adhocSendDropdown.Location = new System.Drawing.Point(148, 14);
            this.adhocSendDropdown.Name = "adhocSendDropdown";
            this.adhocSendDropdown.Size = new System.Drawing.Size(271, 29);
            this.adhocSendDropdown.Style = MetroFramework.MetroColorStyle.Silver;
            this.adhocSendDropdown.TabIndex = 276;
            this.adhocSendDropdown.UseCustomBackColor = true;
            this.adhocSendDropdown.UseSelectable = true;
            this.adhocSendDropdown.UseStyleColors = true;
            this.adhocSendDropdown.SelectedIndexChanged += new System.EventHandler(this.adhocSendDropdown_SelectedIndexChanged);
            // 
            // materialDivider5
            // 
            this.materialDivider5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(35, 57);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(750, 2);
            this.materialDivider5.TabIndex = 275;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // adhocSendPort
            // 
            this.adhocSendPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adhocSendPort.BackColor = System.Drawing.Color.Silver;
            this.adhocSendPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adhocSendPort.Enabled = false;
            this.adhocSendPort.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adhocSendPort.ForeColor = System.Drawing.Color.Black;
            this.adhocSendPort.HintForeColor = System.Drawing.Color.Empty;
            this.adhocSendPort.HintText = "";
            this.adhocSendPort.isPassword = false;
            this.adhocSendPort.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.adhocSendPort.LineIdleColor = System.Drawing.Color.Black;
            this.adhocSendPort.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.adhocSendPort.LineThickness = 4;
            this.adhocSendPort.Location = new System.Drawing.Point(711, 14);
            this.adhocSendPort.Margin = new System.Windows.Forms.Padding(4);
            this.adhocSendPort.Name = "adhocSendPort";
            this.adhocSendPort.Size = new System.Drawing.Size(102, 29);
            this.adhocSendPort.TabIndex = 274;
            this.adhocSendPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // adhocSendAet
            // 
            this.adhocSendAet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adhocSendAet.BackColor = System.Drawing.Color.Silver;
            this.adhocSendAet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adhocSendAet.Enabled = false;
            this.adhocSendAet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adhocSendAet.ForeColor = System.Drawing.Color.Black;
            this.adhocSendAet.HintForeColor = System.Drawing.Color.Empty;
            this.adhocSendAet.HintText = "";
            this.adhocSendAet.isPassword = false;
            this.adhocSendAet.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.adhocSendAet.LineIdleColor = System.Drawing.Color.Black;
            this.adhocSendAet.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.adhocSendAet.LineThickness = 4;
            this.adhocSendAet.Location = new System.Drawing.Point(476, 15);
            this.adhocSendAet.Margin = new System.Windows.Forms.Padding(4);
            this.adhocSendAet.Name = "adhocSendAet";
            this.adhocSendAet.Size = new System.Drawing.Size(171, 29);
            this.adhocSendAet.TabIndex = 273;
            this.adhocSendAet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.Control;
            this.label21.Location = new System.Drawing.Point(430, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 21);
            this.label21.TabIndex = 272;
            this.label21.Text = "AET:";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.Control;
            this.label26.Location = new System.Drawing.Point(653, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(51, 21);
            this.label26.TabIndex = 271;
            this.label26.Text = "PORT:";
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.Control;
            this.label29.Location = new System.Drawing.Point(50, 19);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(85, 21);
            this.label29.TabIndex = 269;
            this.label29.Text = "SCP HOST:";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(10, 15);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(32, 32);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 270;
            this.pictureBox16.TabStop = false;
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
            this.materialTabSelector1.Location = new System.Drawing.Point(-2, 58);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(839, 31);
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
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.metroGrid2;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(723, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 275;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // adhocSendLogWindow
            // 
            this.adhocSendLogWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adhocSendLogWindow.BackColor = System.Drawing.SystemColors.GrayText;
            this.adhocSendLogWindow.BorderColor = System.Drawing.Color.SeaGreen;
            this.adhocSendLogWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adhocSendLogWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adhocSendLogWindow.ForeColor = System.Drawing.SystemColors.Window;
            this.adhocSendLogWindow.Location = new System.Drawing.Point(18, 199);
            this.adhocSendLogWindow.Multiline = true;
            this.adhocSendLogWindow.Name = "adhocSendLogWindow";
            this.adhocSendLogWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.adhocSendLogWindow.Size = new System.Drawing.Size(795, 267);
            this.adhocSendLogWindow.TabIndex = 292;
            // 
            // adhocSendButton
            // 
            this.adhocSendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adhocSendButton.AutoSize = true;
            this.adhocSendButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adhocSendButton.Depth = 0;
            this.adhocSendButton.Icon = null;
            this.adhocSendButton.Location = new System.Drawing.Point(757, 475);
            this.adhocSendButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.adhocSendButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.adhocSendButton.Name = "adhocSendButton";
            this.adhocSendButton.Primary = false;
            this.adhocSendButton.Size = new System.Drawing.Size(56, 36);
            this.adhocSendButton.TabIndex = 293;
            this.adhocSendButton.Text = "Send";
            this.adhocSendButton.UseVisualStyleBackColor = true;
            this.adhocSendButton.Click += new System.EventHandler(this.adhocSendButton_Click);
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 15;
            this.bunifuElipse4.TargetControl = this.adhocSendLogWindow;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.Control;
            this.label33.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label33.Location = new System.Drawing.Point(194, 472);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(87, 21);
            this.label33.TabIndex = 359;
            this.label33.Text = "Successful!";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.SystemColors.Control;
            this.label35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label35.Location = new System.Drawing.Point(46, 473);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(87, 21);
            this.label35.TabIndex = 357;
            this.label35.Text = "Successful!";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(170, 475);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(20, 20);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 360;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(22, 475);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(20, 20);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox20.TabIndex = 358;
            this.pictureBox20.TabStop = false;
            // 
            // progressBar3
            // 
            this.progressBar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar3.Location = new System.Drawing.Point(757, 503);
            this.progressBar3.MarqueeAnimationSpeed = 50;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(56, 8);
            this.progressBar3.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar3.TabIndex = 361;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox21.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(22, 503);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(18, 16);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 363;
            this.pictureBox21.TabStop = false;
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.Control;
            this.label36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label36.Location = new System.Drawing.Point(47, 501);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(87, 21);
            this.label36.TabIndex = 362;
            this.label36.Text = "Successful!";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // adhocSendStoreSCULog
            // 
            this.adhocSendStoreSCULog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adhocSendStoreSCULog.AutoSize = true;
            this.adhocSendStoreSCULog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adhocSendStoreSCULog.Depth = 0;
            this.adhocSendStoreSCULog.Icon = null;
            this.adhocSendStoreSCULog.Location = new System.Drawing.Point(622, 475);
            this.adhocSendStoreSCULog.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.adhocSendStoreSCULog.MouseState = MaterialSkin.MouseState.HOVER;
            this.adhocSendStoreSCULog.Name = "adhocSendStoreSCULog";
            this.adhocSendStoreSCULog.Primary = false;
            this.adhocSendStoreSCULog.Size = new System.Drawing.Size(119, 36);
            this.adhocSendStoreSCULog.TabIndex = 364;
            this.adhocSendStoreSCULog.Text = "storeSCU Log";
            this.adhocSendStoreSCULog.UseVisualStyleBackColor = true;
            this.adhocSendStoreSCULog.Click += new System.EventHandler(this.adhocSendStoreSCULog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 641);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.labelVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(837, 641);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.materialTabControl1.ResumeLayout(false);
            this.Connect.ResumeLayout(false);
            this.Connect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCAMMSourceDBCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Search_Send.ResumeLayout(false);
            this.Search_Send.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.materialContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchFailed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.MWL.ResumeLayout(false);
            this.MWL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.adhocSend.ResumeLayout(false);
            this.adhocSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Connect;
        private System.Windows.Forms.TabPage Search_Send;
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
        private Label label19;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private Label label20;
        private Bunifu.Framework.UI.BunifuMaterialTextbox utilityAET;
        private PictureBox pictureBox8;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private TabPage MWL;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton7;
        private ProgressBar progressBar1;
        private PictureBox pictureBox11;
        private Label label22;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton8;
        private PictureBox pictureBox12;
        private Label label23;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton9;
        private PictureBox pictureBox13;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mwlSCPPort;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mwlSCPAET;
        private Label label24;
        private Label label25;
        private ProgressBar progressBar2;
        private MaterialSkin.Controls.MaterialFlatButton mwlSearchButton;
        private Label label27;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mwlSCPHost;
        private Label label28;
        private DateTimePicker mwlToDatePicker;
        private Label label31;
        private DateTimePicker mwlFromDatePicker;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mwlModalitySearch;
        private Label label30;
        private MaterialSkin.Controls.MaterialCheckBox mwlDateSearchChecbox;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private MaterialSkin.Controls.MaterialFlatButton searchSaveFilesLocally;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton10;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn pid;
        private DataGridViewTextBoxColumn accession;
        private DataGridViewTextBoxColumn ModalityType;
        private DataGridViewTextBoxColumn STUDYDESC;
        private DataGridViewTextBoxColumn DT;
        private DataGridViewTextBoxColumn SUID;
        private DataGridViewTextBoxColumn AA_OID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn STUDYSUID;
        private DataGridViewTextBoxColumn MODALITY;
        private DataGridViewTextBoxColumn ORDERSTATUS;
        private DataGridViewTextBoxColumn SCHDATE;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private MaterialSkin.Controls.MaterialCheckBox searchStudyLevel;
        private MaterialSkin.Controls.MaterialCheckBox searchSeriesLevel;
        private MaterialSkin.Controls.MaterialCheckBox searchPatientLevel;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem sendToolStripMenuItem;
        private ToolStripMenuItem downloadToolStripMenuItem;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton11;
        private TabPage adhocSend;
        private MetroFramework.Controls.MetroComboBox adhocSendDropdown;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adhocSendPort;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adhocSendAet;
        private Label label21;
        private Label label26;
        private Label label29;
        private PictureBox pictureBox16;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adhocSearchFileName;
        private MaterialSkin.Controls.MaterialDivider materialDivider6;
        private Label label34;
        private PictureBox pictureBox17;
        private OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton12;
        private MaterialSkin.Controls.MaterialFlatButton adhocSendFolderSelect;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adhocSendFolderPath;
        private MaterialSkin.Controls.MaterialDivider materialDivider7;
        private Label label32;
        private PictureBox pictureBox18;
        private FolderBrowserDialog folderBrowserDialog1;
        private MaterialSkin.Controls.MaterialFlatButton adhocSendButton;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox adhocSendLogWindow;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Label label33;
        private Label label35;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private ProgressBar progressBar3;
        private PictureBox pictureBox21;
        private Label label36;
        private MaterialSkin.Controls.MaterialFlatButton adhocSendStoreSCULog;
    }
}

