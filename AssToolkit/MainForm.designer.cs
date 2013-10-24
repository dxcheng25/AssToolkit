namespace AssToolkit
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "srt",
            "简体中文&英文"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "srt",
            "繁体中文&英文"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "srt",
            "简体中文"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "srt",
            "繁体中文"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "srt",
            "英文"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "ass",
            "简体中文&英文"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "ass",
            "繁体中文&英文"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "ass",
            "简体中文"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "ass",
            "繁体中文"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("4");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("4");
            this.gbVersions = new System.Windows.Forms.GroupBox();
            this.rbChi = new System.Windows.Forms.RadioButton();
            this.rbChinEng = new System.Windows.Forms.RadioButton();
            this.lvVersionSelection = new System.Windows.Forms.ListView();
            this.chExtension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbAssFile = new System.Windows.Forms.GroupBox();
            this.lvASSFileSelection = new System.Windows.Forms.ListView();
            this.chFileIcon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.gbSrtOutputFolder = new System.Windows.Forms.GroupBox();
            this.btnSrtFdSelection = new System.Windows.Forms.Button();
            this.tbSrtOutputFolder = new System.Windows.Forms.TextBox();
            this.btnA2SStartProcessing = new System.Windows.Forms.Button();
            this.bgwA2SOutput = new System.ComponentModel.BackgroundWorker();
            this.fbdSelectDestDir = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpAss2Srt = new System.Windows.Forms.TabPage();
            this.tpSrt2Ass = new System.Windows.Forms.TabPage();
            this.gbEffCfg = new System.Windows.Forms.GroupBox();
            this.btnModifyEff = new System.Windows.Forms.Button();
            this.btnImportEffFiles = new System.Windows.Forms.Button();
            this.btnDelEff = new System.Windows.Forms.Button();
            this.btnAddEff = new System.Windows.Forms.Button();
            this.lbEffCfgSelection = new System.Windows.Forms.Label();
            this.cbEffCfg = new System.Windows.Forms.ComboBox();
            this.gbASSOutputFolder = new System.Windows.Forms.GroupBox();
            this.btnASSFolderSelection = new System.Windows.Forms.Button();
            this.tbASSOutputFolder = new System.Windows.Forms.TextBox();
            this.btnS2AStartProcessing = new System.Windows.Forms.Button();
            this.gbSrtFile = new System.Windows.Forms.GroupBox();
            this.lvSrtFileSelection = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bgwS2AOutput = new System.ComponentModel.BackgroundWorker();
            this.ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.gbVersions.SuspendLayout();
            this.gbAssFile.SuspendLayout();
            this.gbSrtOutputFolder.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpAss2Srt.SuspendLayout();
            this.tpSrt2Ass.SuspendLayout();
            this.gbEffCfg.SuspendLayout();
            this.gbASSOutputFolder.SuspendLayout();
            this.gbSrtFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVersions
            // 
            this.gbVersions.Controls.Add(this.rbChi);
            this.gbVersions.Controls.Add(this.rbChinEng);
            this.gbVersions.Controls.Add(this.lvVersionSelection);
            this.gbVersions.Location = new System.Drawing.Point(6, 204);
            this.gbVersions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbVersions.Name = "gbVersions";
            this.gbVersions.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbVersions.Size = new System.Drawing.Size(367, 161);
            this.gbVersions.TabIndex = 0;
            this.gbVersions.TabStop = false;
            this.gbVersions.Text = "输出版本";
            // 
            // rbChi
            // 
            this.rbChi.AutoSize = true;
            this.rbChi.Location = new System.Drawing.Point(89, 18);
            this.rbChi.Name = "rbChi";
            this.rbChi.Size = new System.Drawing.Size(74, 21);
            this.rbChi.TabIndex = 1;
            this.rbChi.TabStop = true;
            this.rbChi.Text = "中文单语";
            this.rbChi.UseVisualStyleBackColor = true;
            this.rbChi.CheckedChanged += new System.EventHandler(this.rbChi_CheckedChanged);
            // 
            // rbChinEng
            // 
            this.rbChinEng.AutoSize = true;
            this.rbChinEng.Location = new System.Drawing.Point(9, 18);
            this.rbChinEng.Name = "rbChinEng";
            this.rbChinEng.Size = new System.Drawing.Size(74, 21);
            this.rbChinEng.TabIndex = 1;
            this.rbChinEng.TabStop = true;
            this.rbChinEng.Text = "中英双语";
            this.rbChinEng.UseVisualStyleBackColor = true;
            this.rbChinEng.CheckedChanged += new System.EventHandler(this.rbChinEng_CheckedChanged);
            // 
            // lvVersionSelection
            // 
            this.lvVersionSelection.CheckBoxes = true;
            this.lvVersionSelection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chExtension,
            this.chLanguage});
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            listViewItem3.Checked = true;
            listViewItem3.StateImageIndex = 1;
            listViewItem4.Checked = true;
            listViewItem4.StateImageIndex = 1;
            listViewItem5.Checked = true;
            listViewItem5.StateImageIndex = 1;
            listViewItem5.Tag = "";
            listViewItem6.Checked = true;
            listViewItem6.StateImageIndex = 1;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.StateImageIndex = 0;
            this.lvVersionSelection.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.lvVersionSelection.Location = new System.Drawing.Point(6, 46);
            this.lvVersionSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvVersionSelection.Name = "lvVersionSelection";
            this.lvVersionSelection.Size = new System.Drawing.Size(355, 110);
            this.lvVersionSelection.TabIndex = 0;
            this.lvVersionSelection.UseCompatibleStateImageBehavior = false;
            this.lvVersionSelection.View = System.Windows.Forms.View.Details;
            // 
            // chExtension
            // 
            this.chExtension.Text = "文件类型";
            this.chExtension.Width = 92;
            // 
            // chLanguage
            // 
            this.chLanguage.Text = "字幕语言";
            this.chLanguage.Width = 133;
            // 
            // gbAssFile
            // 
            this.gbAssFile.Controls.Add(this.lvASSFileSelection);
            this.gbAssFile.Location = new System.Drawing.Point(6, 7);
            this.gbAssFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAssFile.Name = "gbAssFile";
            this.gbAssFile.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAssFile.Size = new System.Drawing.Size(367, 195);
            this.gbAssFile.TabIndex = 1;
            this.gbAssFile.TabStop = false;
            this.gbAssFile.Text = "ASS文件";
            // 
            // lvASSFileSelection
            // 
            this.lvASSFileSelection.AllowDrop = true;
            this.lvASSFileSelection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileIcon,
            this.chFileName});
            listViewItem10.StateImageIndex = 0;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.StateImageIndex = 0;
            listViewItem13.StateImageIndex = 0;
            this.lvASSFileSelection.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13});
            this.lvASSFileSelection.Location = new System.Drawing.Point(6, 15);
            this.lvASSFileSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvASSFileSelection.Name = "lvASSFileSelection";
            this.lvASSFileSelection.Size = new System.Drawing.Size(355, 174);
            this.lvASSFileSelection.StateImageList = this.ilIcons;
            this.lvASSFileSelection.TabIndex = 0;
            this.lvASSFileSelection.UseCompatibleStateImageBehavior = false;
            this.lvASSFileSelection.View = System.Windows.Forms.View.SmallIcon;
            this.lvASSFileSelection.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvASSFileSelection_DragDrop);
            this.lvASSFileSelection.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvASSFileSelection_DragEnter);
            // 
            // ilIcons
            // 
            this.ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcons.ImageStream")));
            this.ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIcons.Images.SetKeyName(0, "gzwjtb 026.png");
            // 
            // gbSrtOutputFolder
            // 
            this.gbSrtOutputFolder.Controls.Add(this.btnSrtFdSelection);
            this.gbSrtOutputFolder.Controls.Add(this.tbSrtOutputFolder);
            this.gbSrtOutputFolder.Location = new System.Drawing.Point(6, 368);
            this.gbSrtOutputFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSrtOutputFolder.Name = "gbSrtOutputFolder";
            this.gbSrtOutputFolder.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSrtOutputFolder.Size = new System.Drawing.Size(367, 51);
            this.gbSrtOutputFolder.TabIndex = 2;
            this.gbSrtOutputFolder.TabStop = false;
            this.gbSrtOutputFolder.Text = "输出根目录";
            // 
            // btnSrtFdSelection
            // 
            this.btnSrtFdSelection.Font = new System.Drawing.Font("Times New Roman", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrtFdSelection.Location = new System.Drawing.Point(337, 19);
            this.btnSrtFdSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSrtFdSelection.Name = "btnSrtFdSelection";
            this.btnSrtFdSelection.Size = new System.Drawing.Size(24, 23);
            this.btnSrtFdSelection.TabIndex = 1;
            this.btnSrtFdSelection.Text = "...";
            this.btnSrtFdSelection.UseVisualStyleBackColor = true;
            this.btnSrtFdSelection.Click += new System.EventHandler(this.btnSrtFdSelection_Click);
            // 
            // tbSrtOutputFolder
            // 
            this.tbSrtOutputFolder.BackColor = System.Drawing.SystemColors.Window;
            this.tbSrtOutputFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSrtOutputFolder.Location = new System.Drawing.Point(6, 19);
            this.tbSrtOutputFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSrtOutputFolder.Name = "tbSrtOutputFolder";
            this.tbSrtOutputFolder.ReadOnly = true;
            this.tbSrtOutputFolder.Size = new System.Drawing.Size(330, 23);
            this.tbSrtOutputFolder.TabIndex = 0;
            this.tbSrtOutputFolder.TabStop = false;
            // 
            // btnA2SStartProcessing
            // 
            this.btnA2SStartProcessing.Location = new System.Drawing.Point(268, 426);
            this.btnA2SStartProcessing.Name = "btnA2SStartProcessing";
            this.btnA2SStartProcessing.Size = new System.Drawing.Size(105, 23);
            this.btnA2SStartProcessing.TabIndex = 3;
            this.btnA2SStartProcessing.Text = "开始输出";
            this.btnA2SStartProcessing.UseVisualStyleBackColor = true;
            this.btnA2SStartProcessing.Click += new System.EventHandler(this.btnA2SStartProcessing_Click);
            // 
            // bgwA2SOutput
            // 
            this.bgwA2SOutput.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwA2SOutput_DoWork);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(383, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "ssStatusStrip";
            // 
            // ssProgressBar
            // 
            this.ssProgressBar.Name = "ssProgressBar";
            this.ssProgressBar.Size = new System.Drawing.Size(200, 16);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpAss2Srt);
            this.tabControl.Controls.Add(this.tpSrt2Ass);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(385, 485);
            this.tabControl.TabIndex = 6;
            // 
            // tpAss2Srt
            // 
            this.tpAss2Srt.Controls.Add(this.gbAssFile);
            this.tpAss2Srt.Controls.Add(this.gbVersions);
            this.tpAss2Srt.Controls.Add(this.gbSrtOutputFolder);
            this.tpAss2Srt.Controls.Add(this.btnA2SStartProcessing);
            this.tpAss2Srt.Location = new System.Drawing.Point(4, 26);
            this.tpAss2Srt.Name = "tpAss2Srt";
            this.tpAss2Srt.Padding = new System.Windows.Forms.Padding(3);
            this.tpAss2Srt.Size = new System.Drawing.Size(377, 455);
            this.tpAss2Srt.TabIndex = 0;
            this.tpAss2Srt.Text = "Ass->Srt";
            this.tpAss2Srt.UseVisualStyleBackColor = true;
            // 
            // tpSrt2Ass
            // 
            this.tpSrt2Ass.Controls.Add(this.gbEffCfg);
            this.tpSrt2Ass.Controls.Add(this.gbASSOutputFolder);
            this.tpSrt2Ass.Controls.Add(this.btnS2AStartProcessing);
            this.tpSrt2Ass.Controls.Add(this.gbSrtFile);
            this.tpSrt2Ass.Location = new System.Drawing.Point(4, 26);
            this.tpSrt2Ass.Name = "tpSrt2Ass";
            this.tpSrt2Ass.Padding = new System.Windows.Forms.Padding(3);
            this.tpSrt2Ass.Size = new System.Drawing.Size(377, 455);
            this.tpSrt2Ass.TabIndex = 1;
            this.tpSrt2Ass.Text = "Srt->Ass";
            this.tpSrt2Ass.UseVisualStyleBackColor = true;
            // 
            // gbEffCfg
            // 
            this.gbEffCfg.Controls.Add(this.btnModifyEff);
            this.gbEffCfg.Controls.Add(this.btnImportEffFiles);
            this.gbEffCfg.Controls.Add(this.btnDelEff);
            this.gbEffCfg.Controls.Add(this.btnAddEff);
            this.gbEffCfg.Controls.Add(this.lbEffCfgSelection);
            this.gbEffCfg.Controls.Add(this.cbEffCfg);
            this.gbEffCfg.Location = new System.Drawing.Point(6, 255);
            this.gbEffCfg.Name = "gbEffCfg";
            this.gbEffCfg.Size = new System.Drawing.Size(367, 104);
            this.gbEffCfg.TabIndex = 29;
            this.gbEffCfg.TabStop = false;
            this.gbEffCfg.Text = "特效";
            // 
            // btnModifyEff
            // 
            this.btnModifyEff.Location = new System.Drawing.Point(157, 70);
            this.btnModifyEff.Name = "btnModifyEff";
            this.btnModifyEff.Size = new System.Drawing.Size(78, 23);
            this.btnModifyEff.TabIndex = 4;
            this.btnModifyEff.Text = "修改该特效";
            this.btnModifyEff.UseVisualStyleBackColor = true;
            this.btnModifyEff.Click += new System.EventHandler(this.btnModifyEff_Click);
            // 
            // btnImportEffFiles
            // 
            this.btnImportEffFiles.Location = new System.Drawing.Point(83, 70);
            this.btnImportEffFiles.Name = "btnImportEffFiles";
            this.btnImportEffFiles.Size = new System.Drawing.Size(68, 23);
            this.btnImportEffFiles.TabIndex = 3;
            this.btnImportEffFiles.Text = "导入特效";
            this.btnImportEffFiles.UseVisualStyleBackColor = true;
            this.btnImportEffFiles.Click += new System.EventHandler(this.btnImportEffFiles_Click);
            // 
            // btnDelEff
            // 
            this.btnDelEff.Location = new System.Drawing.Point(241, 70);
            this.btnDelEff.Name = "btnDelEff";
            this.btnDelEff.Size = new System.Drawing.Size(78, 23);
            this.btnDelEff.TabIndex = 2;
            this.btnDelEff.Text = "删除该特效";
            this.btnDelEff.UseVisualStyleBackColor = true;
            this.btnDelEff.Click += new System.EventHandler(this.btnDelEff_Click);
            // 
            // btnAddEff
            // 
            this.btnAddEff.Location = new System.Drawing.Point(9, 70);
            this.btnAddEff.Name = "btnAddEff";
            this.btnAddEff.Size = new System.Drawing.Size(68, 23);
            this.btnAddEff.TabIndex = 2;
            this.btnAddEff.Text = "新增特效";
            this.btnAddEff.UseVisualStyleBackColor = true;
            this.btnAddEff.Click += new System.EventHandler(this.btnAddEff_Click);
            // 
            // lbEffCfgSelection
            // 
            this.lbEffCfgSelection.AutoSize = true;
            this.lbEffCfgSelection.Location = new System.Drawing.Point(6, 19);
            this.lbEffCfgSelection.Name = "lbEffCfgSelection";
            this.lbEffCfgSelection.Size = new System.Drawing.Size(56, 17);
            this.lbEffCfgSelection.TabIndex = 1;
            this.lbEffCfgSelection.Text = "选择特效";
            // 
            // cbEffCfg
            // 
            this.cbEffCfg.FormattingEnabled = true;
            this.cbEffCfg.Location = new System.Drawing.Point(9, 39);
            this.cbEffCfg.Name = "cbEffCfg";
            this.cbEffCfg.Size = new System.Drawing.Size(352, 25);
            this.cbEffCfg.TabIndex = 0;
            // 
            // gbASSOutputFolder
            // 
            this.gbASSOutputFolder.Controls.Add(this.btnASSFolderSelection);
            this.gbASSOutputFolder.Controls.Add(this.tbASSOutputFolder);
            this.gbASSOutputFolder.Location = new System.Drawing.Point(6, 364);
            this.gbASSOutputFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbASSOutputFolder.Name = "gbASSOutputFolder";
            this.gbASSOutputFolder.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbASSOutputFolder.Size = new System.Drawing.Size(367, 51);
            this.gbASSOutputFolder.TabIndex = 27;
            this.gbASSOutputFolder.TabStop = false;
            this.gbASSOutputFolder.Text = "输出根目录";
            // 
            // btnASSFolderSelection
            // 
            this.btnASSFolderSelection.Font = new System.Drawing.Font("Times New Roman", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnASSFolderSelection.Location = new System.Drawing.Point(337, 19);
            this.btnASSFolderSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnASSFolderSelection.Name = "btnASSFolderSelection";
            this.btnASSFolderSelection.Size = new System.Drawing.Size(24, 23);
            this.btnASSFolderSelection.TabIndex = 1;
            this.btnASSFolderSelection.Text = "...";
            this.btnASSFolderSelection.UseVisualStyleBackColor = true;
            this.btnASSFolderSelection.Click += new System.EventHandler(this.btnASSFolderSelection_Click);
            // 
            // tbASSOutputFolder
            // 
            this.tbASSOutputFolder.BackColor = System.Drawing.SystemColors.Window;
            this.tbASSOutputFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbASSOutputFolder.Location = new System.Drawing.Point(6, 19);
            this.tbASSOutputFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbASSOutputFolder.Name = "tbASSOutputFolder";
            this.tbASSOutputFolder.ReadOnly = true;
            this.tbASSOutputFolder.Size = new System.Drawing.Size(330, 23);
            this.tbASSOutputFolder.TabIndex = 0;
            this.tbASSOutputFolder.TabStop = false;
            // 
            // btnS2AStartProcessing
            // 
            this.btnS2AStartProcessing.Location = new System.Drawing.Point(268, 426);
            this.btnS2AStartProcessing.Name = "btnS2AStartProcessing";
            this.btnS2AStartProcessing.Size = new System.Drawing.Size(105, 23);
            this.btnS2AStartProcessing.TabIndex = 28;
            this.btnS2AStartProcessing.Text = "开始输出";
            this.btnS2AStartProcessing.UseVisualStyleBackColor = true;
            this.btnS2AStartProcessing.Click += new System.EventHandler(this.btnS2AStartProcessing_Click);
            // 
            // gbSrtFile
            // 
            this.gbSrtFile.Controls.Add(this.lvSrtFileSelection);
            this.gbSrtFile.Location = new System.Drawing.Point(6, 7);
            this.gbSrtFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSrtFile.Name = "gbSrtFile";
            this.gbSrtFile.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSrtFile.Size = new System.Drawing.Size(367, 249);
            this.gbSrtFile.TabIndex = 26;
            this.gbSrtFile.TabStop = false;
            this.gbSrtFile.Text = "SRT文件";
            // 
            // lvSrtFileSelection
            // 
            this.lvSrtFileSelection.AllowDrop = true;
            this.lvSrtFileSelection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            listViewItem14.StateImageIndex = 0;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.StateImageIndex = 0;
            listViewItem17.StateImageIndex = 0;
            this.lvSrtFileSelection.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17});
            this.lvSrtFileSelection.Location = new System.Drawing.Point(6, 15);
            this.lvSrtFileSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvSrtFileSelection.Name = "lvSrtFileSelection";
            this.lvSrtFileSelection.Size = new System.Drawing.Size(355, 226);
            this.lvSrtFileSelection.StateImageList = this.ilIcons;
            this.lvSrtFileSelection.TabIndex = 0;
            this.lvSrtFileSelection.UseCompatibleStateImageBehavior = false;
            this.lvSrtFileSelection.View = System.Windows.Forms.View.SmallIcon;
            this.lvSrtFileSelection.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvSrtFileSelection_DragDrop);
            this.lvSrtFileSelection.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvSrtFileSelection_DragEnter);
            // 
            // bgwS2AOutput
            // 
            this.bgwS2AOutput.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwS2AOutput_DoWork);
            // 
            // ofdSelectFile
            // 
            this.ofdSelectFile.FileName = "ofdSelectFile";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 507);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "ASSToolkit V1.5.1";
            this.gbVersions.ResumeLayout(false);
            this.gbVersions.PerformLayout();
            this.gbAssFile.ResumeLayout(false);
            this.gbSrtOutputFolder.ResumeLayout(false);
            this.gbSrtOutputFolder.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpAss2Srt.ResumeLayout(false);
            this.tpSrt2Ass.ResumeLayout(false);
            this.gbEffCfg.ResumeLayout(false);
            this.gbEffCfg.PerformLayout();
            this.gbASSOutputFolder.ResumeLayout(false);
            this.gbASSOutputFolder.PerformLayout();
            this.gbSrtFile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVersions;
        private System.Windows.Forms.ListView lvVersionSelection;
        private System.Windows.Forms.ColumnHeader chExtension;
        private System.Windows.Forms.ColumnHeader chLanguage;
        private System.Windows.Forms.GroupBox gbAssFile;
        private System.Windows.Forms.ListView lvASSFileSelection;
        private System.Windows.Forms.ColumnHeader chFileIcon;
        private System.Windows.Forms.ColumnHeader chFileName;
        private System.Windows.Forms.ImageList ilIcons;
        private System.Windows.Forms.GroupBox gbSrtOutputFolder;
        private System.Windows.Forms.TextBox tbSrtOutputFolder;
        private System.Windows.Forms.Button btnSrtFdSelection;
        private System.Windows.Forms.Button btnA2SStartProcessing;
        private System.ComponentModel.BackgroundWorker bgwA2SOutput;
        private System.Windows.Forms.FolderBrowserDialog fbdSelectDestDir;
        private System.Windows.Forms.RadioButton rbChi;
        private System.Windows.Forms.RadioButton rbChinEng;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ssProgressBar;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpAss2Srt;
        private System.Windows.Forms.TabPage tpSrt2Ass;
        private System.Windows.Forms.GroupBox gbSrtFile;
        private System.Windows.Forms.ListView lvSrtFileSelection;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox gbASSOutputFolder;
        private System.Windows.Forms.Button btnASSFolderSelection;
        private System.Windows.Forms.TextBox tbASSOutputFolder;
        private System.Windows.Forms.Button btnS2AStartProcessing;
        private System.Windows.Forms.GroupBox gbEffCfg;
        private System.Windows.Forms.Button btnDelEff;
        private System.Windows.Forms.Button btnAddEff;
        private System.Windows.Forms.Label lbEffCfgSelection;
        private System.Windows.Forms.ComboBox cbEffCfg;
        private System.Windows.Forms.Button btnImportEffFiles;
        private System.ComponentModel.BackgroundWorker bgwS2AOutput;
        private System.Windows.Forms.Button btnModifyEff;
        private System.Windows.Forms.OpenFileDialog ofdSelectFile;
    }
}

