
namespace IMDBfetch
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fetchButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.JsonLabel = new System.Windows.Forms.Label();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.gamesLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.rawTabControl = new System.Windows.Forms.TabControl();
            this.searchTabPage = new System.Windows.Forms.TabPage();
            this.searchJsonTextBox = new System.Windows.Forms.TextBox();
            this.infolTabPage = new System.Windows.Forms.TabPage();
            this.infoJsonTextBox = new System.Windows.Forms.TextBox();
            this.errorTabPage = new System.Windows.Forms.TabPage();
            this.erroJsonlTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rawRadioButton = new System.Windows.Forms.RadioButton();
            this.descriptionRadioButton = new System.Windows.Forms.RadioButton();
            this.titleRadioButton = new System.Windows.Forms.RadioButton();
            this.idRadioButton = new System.Windows.Forms.RadioButton();
            this.descCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAPICallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPIKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAPICalsOnStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeReleasesPublicDomainIsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fetchedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fetchedCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.resultToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTableLayoutPanel.SuspendLayout();
            this.rawTabControl.SuspendLayout();
            this.searchTabPage.SuspendLayout();
            this.infolTabPage.SuspendLayout();
            this.errorTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.mainTableLayoutPanel2.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Open high-res directory";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainTableLayoutPanel.Controls.Add(this.fetchButton, 0, 4);
            this.mainTableLayoutPanel.Controls.Add(this.browseButton, 1, 3);
            this.mainTableLayoutPanel.Controls.Add(this.directoryLabel, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.JsonLabel, 0, 7);
            this.mainTableLayoutPanel.Controls.Add(this.directoryTextBox, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.gamesLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.searchTextBox, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.searchListBox, 0, 5);
            this.mainTableLayoutPanel.Controls.Add(this.rawTabControl, 0, 8);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 6);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 9;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(376, 464);
            this.mainTableLayoutPanel.TabIndex = 45;
            // 
            // fetchButton
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.fetchButton, 2);
            this.fetchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fetchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchButton.Location = new System.Drawing.Point(3, 103);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(370, 44);
            this.fetchButton.TabIndex = 5;
            this.fetchButton.Text = "&FETCH INFO";
            this.fetchButton.UseVisualStyleBackColor = true;
            this.fetchButton.Click += new System.EventHandler(this.OnFetchButtonClick);
            // 
            // browseButton
            // 
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseButton.Location = new System.Drawing.Point(301, 76);
            this.browseButton.Margin = new System.Windows.Forms.Padding(1);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(74, 23);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "&Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.OnBrowseButtonClick);
            // 
            // directoryLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.directoryLabel, 2);
            this.directoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directoryLabel.Location = new System.Drawing.Point(3, 50);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(370, 25);
            this.directoryLabel.TabIndex = 2;
            this.directoryLabel.Text = "&Directory:";
            this.directoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JsonLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.JsonLabel, 2);
            this.JsonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JsonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.JsonLabel.Location = new System.Drawing.Point(3, 336);
            this.JsonLabel.Name = "JsonLabel";
            this.JsonLabel.Size = new System.Drawing.Size(370, 20);
            this.JsonLabel.TabIndex = 7;
            this.JsonLabel.Text = "&JSON:";
            this.JsonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.AllowDrop = true;
            this.directoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryTextBox.Location = new System.Drawing.Point(1, 76);
            this.directoryTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(298, 20);
            this.directoryTextBox.TabIndex = 3;
            this.directoryTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDirectoryTextBoxDragDrop);
            this.directoryTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDirectoryTextBoxDragEnter);
            // 
            // gamesLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.gamesLabel, 2);
            this.gamesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesLabel.Location = new System.Drawing.Point(3, 0);
            this.gamesLabel.Name = "gamesLabel";
            this.gamesLabel.Size = new System.Drawing.Size(370, 25);
            this.gamesLabel.TabIndex = 0;
            this.gamesLabel.Text = "&Search:";
            this.gamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchTextBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.searchTextBox, 2);
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(3, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(370, 24);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchListBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.searchListBox, 2);
            this.searchListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchListBox.Location = new System.Drawing.Point(3, 153);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(370, 155);
            this.searchListBox.TabIndex = 6;
            this.searchListBox.SelectedIndexChanged += new System.EventHandler(this.OnSearchListBoxSelectedIndexChanged);
            // 
            // rawTabControl
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.rawTabControl, 2);
            this.rawTabControl.Controls.Add(this.searchTabPage);
            this.rawTabControl.Controls.Add(this.infolTabPage);
            this.rawTabControl.Controls.Add(this.errorTabPage);
            this.rawTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rawTabControl.Location = new System.Drawing.Point(3, 359);
            this.rawTabControl.Name = "rawTabControl";
            this.rawTabControl.SelectedIndex = 0;
            this.rawTabControl.Size = new System.Drawing.Size(370, 102);
            this.rawTabControl.TabIndex = 8;
            // 
            // searchTabPage
            // 
            this.searchTabPage.Controls.Add(this.searchJsonTextBox);
            this.searchTabPage.Location = new System.Drawing.Point(4, 22);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchTabPage.Size = new System.Drawing.Size(362, 76);
            this.searchTabPage.TabIndex = 0;
            this.searchTabPage.Text = "Search";
            this.searchTabPage.UseVisualStyleBackColor = true;
            // 
            // searchJsonTextBox
            // 
            this.searchJsonTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchJsonTextBox.Location = new System.Drawing.Point(3, 3);
            this.searchJsonTextBox.Multiline = true;
            this.searchJsonTextBox.Name = "searchJsonTextBox";
            this.searchJsonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.searchJsonTextBox.Size = new System.Drawing.Size(356, 70);
            this.searchJsonTextBox.TabIndex = 0;
            this.searchJsonTextBox.WordWrap = false;
            // 
            // infolTabPage
            // 
            this.infolTabPage.Controls.Add(this.infoJsonTextBox);
            this.infolTabPage.Location = new System.Drawing.Point(4, 22);
            this.infolTabPage.Name = "infolTabPage";
            this.infolTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.infolTabPage.Size = new System.Drawing.Size(362, 76);
            this.infolTabPage.TabIndex = 1;
            this.infolTabPage.Text = "Info";
            this.infolTabPage.UseVisualStyleBackColor = true;
            // 
            // infoJsonTextBox
            // 
            this.infoJsonTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoJsonTextBox.Location = new System.Drawing.Point(3, 3);
            this.infoJsonTextBox.Multiline = true;
            this.infoJsonTextBox.Name = "infoJsonTextBox";
            this.infoJsonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infoJsonTextBox.Size = new System.Drawing.Size(356, 70);
            this.infoJsonTextBox.TabIndex = 3;
            this.infoJsonTextBox.WordWrap = false;
            // 
            // errorTabPage
            // 
            this.errorTabPage.Controls.Add(this.erroJsonlTextBox);
            this.errorTabPage.Location = new System.Drawing.Point(4, 22);
            this.errorTabPage.Name = "errorTabPage";
            this.errorTabPage.Size = new System.Drawing.Size(362, 76);
            this.errorTabPage.TabIndex = 2;
            this.errorTabPage.Text = "Error";
            this.errorTabPage.UseVisualStyleBackColor = true;
            // 
            // erroJsonlTextBox
            // 
            this.erroJsonlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.erroJsonlTextBox.Location = new System.Drawing.Point(0, 0);
            this.erroJsonlTextBox.Multiline = true;
            this.erroJsonlTextBox.Name = "erroJsonlTextBox";
            this.erroJsonlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.erroJsonlTextBox.Size = new System.Drawing.Size(362, 76);
            this.erroJsonlTextBox.TabIndex = 0;
            this.erroJsonlTextBox.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.mainTableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.rawRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.descriptionRadioButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.titleRadioButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.idRadioButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.descCheckBox, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 311);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 25);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // rawRadioButton
            // 
            this.rawRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rawRadioButton.Location = new System.Drawing.Point(3, 3);
            this.rawRadioButton.Name = "rawRadioButton";
            this.rawRadioButton.Size = new System.Drawing.Size(69, 19);
            this.rawRadioButton.TabIndex = 1;
            this.rawRadioButton.TabStop = true;
            this.rawRadioButton.Text = "&Raw";
            this.rawRadioButton.UseVisualStyleBackColor = true;
            this.rawRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
            // 
            // descriptionRadioButton
            // 
            this.descriptionRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionRadioButton.Location = new System.Drawing.Point(78, 3);
            this.descriptionRadioButton.Name = "descriptionRadioButton";
            this.descriptionRadioButton.Size = new System.Drawing.Size(69, 19);
            this.descriptionRadioButton.TabIndex = 2;
            this.descriptionRadioButton.Text = "&Descr.";
            this.descriptionRadioButton.UseVisualStyleBackColor = true;
            this.descriptionRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
            // 
            // titleRadioButton
            // 
            this.titleRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleRadioButton.Location = new System.Drawing.Point(153, 3);
            this.titleRadioButton.Name = "titleRadioButton";
            this.titleRadioButton.Size = new System.Drawing.Size(69, 19);
            this.titleRadioButton.TabIndex = 3;
            this.titleRadioButton.TabStop = true;
            this.titleRadioButton.Text = "&Title";
            this.titleRadioButton.UseVisualStyleBackColor = true;
            this.titleRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
            // 
            // idRadioButton
            // 
            this.idRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idRadioButton.Location = new System.Drawing.Point(228, 3);
            this.idRadioButton.Name = "idRadioButton";
            this.idRadioButton.Size = new System.Drawing.Size(69, 19);
            this.idRadioButton.TabIndex = 4;
            this.idRadioButton.TabStop = true;
            this.idRadioButton.Text = "&ID";
            this.idRadioButton.UseVisualStyleBackColor = true;
            this.idRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
            // 
            // descCheckBox
            // 
            this.descCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descCheckBox.Location = new System.Drawing.Point(303, 3);
            this.descCheckBox.Name = "descCheckBox";
            this.descCheckBox.Size = new System.Drawing.Size(70, 19);
            this.descCheckBox.TabIndex = 5;
            this.descCheckBox.Text = "&DESC";
            this.descCheckBox.UseVisualStyleBackColor = true;
            this.descCheckBox.CheckedChanged += new System.EventHandler(this.OnDescCheckBoxCheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.infoRichTextBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.imagePictureBox, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.infoLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.imageLabel, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(385, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(376, 464);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoRichTextBox.Location = new System.Drawing.Point(3, 28);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.Size = new System.Drawing.Size(370, 201);
            this.infoRichTextBox.TabIndex = 10;
            this.infoRichTextBox.Text = "";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePictureBox.Location = new System.Drawing.Point(3, 260);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(370, 201);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 6;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnImagePictureBoxMouseMove);
            // 
            // infoLabel
            // 
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.infoLabel.Location = new System.Drawing.Point(3, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(370, 25);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "&Info:";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageLabel
            // 
            this.imageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.imageLabel.Location = new System.Drawing.Point(3, 232);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(370, 25);
            this.imageLabel.TabIndex = 11;
            this.imageLabel.Text = "&Image:";
            this.imageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainTableLayoutPanel2
            // 
            this.mainTableLayoutPanel2.ColumnCount = 2;
            this.mainTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.mainTableLayoutPanel2.Controls.Add(this.mainTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel2.Name = "mainTableLayoutPanel2";
            this.mainTableLayoutPanel2.RowCount = 1;
            this.mainTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel2.Size = new System.Drawing.Size(764, 470);
            this.mainTableLayoutPanel2.TabIndex = 50;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog.Title = "Save games file";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.minimizeToolStripMenuItem,
                                    this.fileToolStripMenuItem,
                                    this.toolsToolStripMenuItem,
                                    this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(764, 24);
            this.mainMenuStrip.TabIndex = 49;
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.minimizeToolStripMenuItem.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.newToolStripMenuItem,
                                    this.openToolStripMenuItem,
                                    this.toolStripSeparator,
                                    this.saveToolStripMenuItem,
                                    this.toolStripSeparator3,
                                    this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            this.toolStripSeparator.Visible = false;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.getAPICallsToolStripMenuItem,
                                    this.settingsToolStripMenuItem,
                                    this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // getAPICallsToolStripMenuItem
            // 
            this.getAPICallsToolStripMenuItem.Name = "getAPICallsToolStripMenuItem";
            this.getAPICallsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.getAPICallsToolStripMenuItem.Text = "&Get API calls";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.aPIKeyToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // aPIKeyToolStripMenuItem
            // 
            this.aPIKeyToolStripMenuItem.Name = "aPIKeyToolStripMenuItem";
            this.aPIKeyToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.aPIKeyToolStripMenuItem.Text = "&API key";
            this.aPIKeyToolStripMenuItem.Click += new System.EventHandler(this.OnAPIKeyToolStripMenuItemClick);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.alwaysOnTopToolStripMenuItem,
                                    this.setAPICalsOnStartToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
            // 
            // setAPICalsOnStartToolStripMenuItem
            // 
            this.setAPICalsOnStartToolStripMenuItem.Name = "setAPICalsOnStartToolStripMenuItem";
            this.setAPICalsOnStartToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.setAPICalsOnStartToolStripMenuItem.Text = "&Set API cals on start";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.freeReleasesPublicDomainIsToolStripMenuItem,
                                    this.originalThreadDonationCodercomToolStripMenuItem,
                                    this.sourceCodeGithubcomToolStripMenuItem,
                                    this.toolStripSeparator2,
                                    this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // freeReleasesPublicDomainIsToolStripMenuItem
            // 
            this.freeReleasesPublicDomainIsToolStripMenuItem.Name = "freeReleasesPublicDomainIsToolStripMenuItem";
            this.freeReleasesPublicDomainIsToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.freeReleasesPublicDomainIsToolStripMenuItem.Text = "&Free Releases @ PublicDomain.is";
            this.freeReleasesPublicDomainIsToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainIsToolStripMenuItemClick);
            // 
            // originalThreadDonationCodercomToolStripMenuItem
            // 
            this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
            this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
            this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
            this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
            // 
            // sourceCodeGithubcomToolStripMenuItem
            // 
            this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
            this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
            this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.sourceCodeGithubcomToolStripMenuItem.Text = "Source code @ Github.com";
            this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.toolStripStatusLabel2,
                                    this.toolStripStatusLabel3,
                                    this.toolStripStatusLabel4,
                                    this.fetchedToolStripStatusLabel,
                                    this.fetchedCountToolStripStatusLabel,
                                    this.toolStripStatusLabel1,
                                    this.resultToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 494);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(764, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 48;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(54, 17);
            this.toolStripStatusLabel2.Text = "API calls:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel3.Text = "?";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel4.Text = "/";
            // 
            // fetchedToolStripStatusLabel
            // 
            this.fetchedToolStripStatusLabel.Name = "fetchedToolStripStatusLabel";
            this.fetchedToolStripStatusLabel.Size = new System.Drawing.Size(52, 17);
            this.fetchedToolStripStatusLabel.Text = "Fetched:";
            // 
            // fetchedCountToolStripStatusLabel
            // 
            this.fetchedCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchedCountToolStripStatusLabel.Name = "fetchedCountToolStripStatusLabel";
            this.fetchedCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.fetchedCountToolStripStatusLabel.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "/";
            // 
            // resultToolStripStatusLabel
            // 
            this.resultToolStripStatusLabel.Name = "resultToolStripStatusLabel";
            this.resultToolStripStatusLabel.Size = new System.Drawing.Size(193, 17);
            this.resultToolStripStatusLabel.Text = "Waiting for a search term to fetch...";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog.Title = "Open games file";
            // 
            // MainForm
            // 
            this.AcceptButton = this.fetchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 516);
            this.Controls.Add(this.mainTableLayoutPanel2);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.mainStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IMDBfetch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormFormClosing);
            this.Load += new System.EventHandler(this.OnMainFormLoad);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.rawTabControl.ResumeLayout(false);
            this.searchTabPage.ResumeLayout(false);
            this.searchTabPage.PerformLayout();
            this.infolTabPage.ResumeLayout(false);
            this.infolTabPage.PerformLayout();
            this.errorTabPage.ResumeLayout(false);
            this.errorTabPage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.mainTableLayoutPanel2.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem setAPICalsOnStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAPICallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPIKeyToolStripMenuItem;
        private System.Windows.Forms.TextBox erroJsonlTextBox;
        private System.Windows.Forms.TabPage errorTabPage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel resultToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel fetchedCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel fetchedToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainIsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel2;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox descCheckBox;
        private System.Windows.Forms.RadioButton idRadioButton;
        private System.Windows.Forms.RadioButton titleRadioButton;
        private System.Windows.Forms.RadioButton descriptionRadioButton;
        private System.Windows.Forms.RadioButton rawRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox infoJsonTextBox;
        private System.Windows.Forms.TabPage infolTabPage;
        private System.Windows.Forms.TextBox searchJsonTextBox;
        private System.Windows.Forms.TabPage searchTabPage;
        private System.Windows.Forms.TabControl rawTabControl;
        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label gamesLabel;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Label JsonLabel;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button fetchButton;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}
