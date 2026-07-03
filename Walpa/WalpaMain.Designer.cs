namespace Walpa
{
    partial class WalpaMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.LabelIconCount = new Walpa.TSCustomLabel();
            this.LabelIconCount_V = new Walpa.TSCustomLabel();
            this.PB_Color = new System.Windows.Forms.PictureBox();
            this.LabelSLocation = new Walpa.TSCustomLabel();
            this.LabelColor = new Walpa.TSCustomLabel();
            this.LabelSLocation_V = new Walpa.TSCustomLabel();
            this.BtnClearList = new Walpa.TSCustomButton();
            this.TLP_PictureBox = new System.Windows.Forms.TableLayoutPanel();
            this.PB_AfterPanel = new System.Windows.Forms.Panel();
            this.PB_After = new System.Windows.Forms.PictureBox();
            this.LabelAfter = new Walpa.TSCustomLabel();
            this.PB_BeforePanel = new System.Windows.Forms.Panel();
            this.PB_Before = new System.Windows.Forms.PictureBox();
            this.LabelBefore = new Walpa.TSCustomLabel();
            this.TLP_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSelect = new Walpa.TSCustomButton();
            this.BtnColorPicker = new Walpa.TSCustomButton();
            this.BtnConvert = new Walpa.TSCustomButton();
            this.BtnSaveLocation = new Walpa.TSCustomButton();
            this.PB_Back = new Walpa.TSCustomPanel();
            this.PB_Front = new Walpa.TSCustomPanel();
            this.ListIcons = new Walpa.TSCustomListBox();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HeaderMenu = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chineseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dutchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hindiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.japaneseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koreanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portugueseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turkishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkforUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackPanel.SuspendLayout();
            this.PanelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Color)).BeginInit();
            this.TLP_PictureBox.SuspendLayout();
            this.PB_AfterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_After)).BeginInit();
            this.PB_BeforePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Before)).BeginInit();
            this.TLP_Buttons.SuspendLayout();
            this.PB_Back.SuspendLayout();
            this.HeaderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.PanelStatus);
            this.BackPanel.Controls.Add(this.BtnClearList);
            this.BackPanel.Controls.Add(this.TLP_PictureBox);
            this.BackPanel.Controls.Add(this.TLP_Buttons);
            this.BackPanel.Controls.Add(this.PB_Back);
            this.BackPanel.Controls.Add(this.ListIcons);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 24);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(10);
            this.BackPanel.Size = new System.Drawing.Size(1008, 577);
            this.BackPanel.TabIndex = 1;
            // 
            // PanelStatus
            // 
            this.PanelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelStatus.BackColor = System.Drawing.Color.White;
            this.PanelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelStatus.Controls.Add(this.LabelIconCount);
            this.PanelStatus.Controls.Add(this.LabelIconCount_V);
            this.PanelStatus.Controls.Add(this.PB_Color);
            this.PanelStatus.Controls.Add(this.LabelSLocation);
            this.PanelStatus.Controls.Add(this.LabelColor);
            this.PanelStatus.Controls.Add(this.LabelSLocation_V);
            this.PanelStatus.Location = new System.Drawing.Point(373, 135);
            this.PanelStatus.Margin = new System.Windows.Forms.Padding(3, 0, 0, 10);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Padding = new System.Windows.Forms.Padding(10);
            this.PanelStatus.Size = new System.Drawing.Size(626, 320);
            this.PanelStatus.TabIndex = 2;
            // 
            // LabelIconCount
            // 
            this.LabelIconCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelIconCount.BackColor = System.Drawing.Color.Transparent;
            this.LabelIconCount.BorderRadius = 5;
            this.LabelIconCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.LabelIconCount.ForeColor = System.Drawing.Color.Black;
            this.LabelIconCount.Location = new System.Drawing.Point(13, 86);
            this.LabelIconCount.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.LabelIconCount.Name = "LabelIconCount";
            this.LabelIconCount.Size = new System.Drawing.Size(598, 27);
            this.LabelIconCount.TabIndex = 2;
            this.LabelIconCount.Text = "Simge Sayısı:";
            this.LabelIconCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelIconCount_V
            // 
            this.LabelIconCount_V.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelIconCount_V.BackColor = System.Drawing.Color.Transparent;
            this.LabelIconCount_V.BorderRadius = 5;
            this.LabelIconCount_V.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.LabelIconCount_V.ForeColor = System.Drawing.Color.Black;
            this.LabelIconCount_V.Location = new System.Drawing.Point(13, 121);
            this.LabelIconCount_V.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.LabelIconCount_V.Name = "LabelIconCount_V";
            this.LabelIconCount_V.Size = new System.Drawing.Size(598, 42);
            this.LabelIconCount_V.TabIndex = 3;
            this.LabelIconCount_V.Text = "Henüz içe aktarılmadı.";
            // 
            // PB_Color
            // 
            this.PB_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Color.Location = new System.Drawing.Point(17, 206);
            this.PB_Color.Name = "PB_Color";
            this.PB_Color.Size = new System.Drawing.Size(35, 35);
            this.PB_Color.TabIndex = 3;
            this.PB_Color.TabStop = false;
            this.PB_Color.Visible = false;
            // 
            // LabelSLocation
            // 
            this.LabelSLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSLocation.BackColor = System.Drawing.Color.Transparent;
            this.LabelSLocation.BorderRadius = 5;
            this.LabelSLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.LabelSLocation.ForeColor = System.Drawing.Color.Black;
            this.LabelSLocation.Location = new System.Drawing.Point(13, 13);
            this.LabelSLocation.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.LabelSLocation.Name = "LabelSLocation";
            this.LabelSLocation.Size = new System.Drawing.Size(598, 27);
            this.LabelSLocation.TabIndex = 0;
            this.LabelSLocation.Text = "Kaydedilecek Konum:";
            this.LabelSLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelColor
            // 
            this.LabelColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelColor.BackColor = System.Drawing.Color.Transparent;
            this.LabelColor.BorderRadius = 5;
            this.LabelColor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.LabelColor.ForeColor = System.Drawing.Color.Black;
            this.LabelColor.Location = new System.Drawing.Point(13, 171);
            this.LabelColor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.LabelColor.Name = "LabelColor";
            this.LabelColor.Size = new System.Drawing.Size(598, 27);
            this.LabelColor.TabIndex = 4;
            this.LabelColor.Text = "Seçilen Renk:";
            this.LabelColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelColor.Visible = false;
            // 
            // LabelSLocation_V
            // 
            this.LabelSLocation_V.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSLocation_V.BackColor = System.Drawing.Color.Transparent;
            this.LabelSLocation_V.BorderRadius = 5;
            this.LabelSLocation_V.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.LabelSLocation_V.ForeColor = System.Drawing.Color.Black;
            this.LabelSLocation_V.Location = new System.Drawing.Point(13, 48);
            this.LabelSLocation_V.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.LabelSLocation_V.Name = "LabelSLocation_V";
            this.LabelSLocation_V.Size = new System.Drawing.Size(598, 30);
            this.LabelSLocation_V.TabIndex = 1;
            this.LabelSLocation_V.Text = "Henüz seçilmedi";
            // 
            // BtnClearList
            // 
            this.BtnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnClearList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnClearList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnClearList.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnClearList.BorderRadius = 5;
            this.BtnClearList.BorderSize = 0;
            this.BtnClearList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearList.FlatAppearance.BorderSize = 0;
            this.BtnClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearList.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.BtnClearList.ForeColor = System.Drawing.Color.White;
            this.BtnClearList.Location = new System.Drawing.Point(10, 532);
            this.BtnClearList.Margin = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.BtnClearList.Name = "BtnClearList";
            this.BtnClearList.Size = new System.Drawing.Size(350, 35);
            this.BtnClearList.TabIndex = 5;
            this.BtnClearList.Text = "Listeyi Temizle";
            this.BtnClearList.TextColor = System.Drawing.Color.White;
            this.BtnClearList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClearList.UseVisualStyleBackColor = false;
            this.BtnClearList.Click += new System.EventHandler(this.BtnClearList_Click);
            // 
            // TLP_PictureBox
            // 
            this.TLP_PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP_PictureBox.ColumnCount = 2;
            this.TLP_PictureBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_PictureBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_PictureBox.Controls.Add(this.PB_AfterPanel, 1, 0);
            this.TLP_PictureBox.Controls.Add(this.PB_BeforePanel, 0, 0);
            this.TLP_PictureBox.Location = new System.Drawing.Point(373, 10);
            this.TLP_PictureBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TLP_PictureBox.Name = "TLP_PictureBox";
            this.TLP_PictureBox.RowCount = 1;
            this.TLP_PictureBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_PictureBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.TLP_PictureBox.Size = new System.Drawing.Size(626, 115);
            this.TLP_PictureBox.TabIndex = 1;
            // 
            // PB_AfterPanel
            // 
            this.PB_AfterPanel.Controls.Add(this.PB_After);
            this.PB_AfterPanel.Controls.Add(this.LabelAfter);
            this.PB_AfterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_AfterPanel.Location = new System.Drawing.Point(318, 0);
            this.PB_AfterPanel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.PB_AfterPanel.Name = "PB_AfterPanel";
            this.PB_AfterPanel.Size = new System.Drawing.Size(308, 115);
            this.PB_AfterPanel.TabIndex = 1;
            // 
            // PB_After
            // 
            this.PB_After.BackColor = System.Drawing.Color.White;
            this.PB_After.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_After.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PB_After.Location = new System.Drawing.Point(0, 29);
            this.PB_After.Margin = new System.Windows.Forms.Padding(0);
            this.PB_After.Name = "PB_After";
            this.PB_After.Padding = new System.Windows.Forms.Padding(10);
            this.PB_After.Size = new System.Drawing.Size(308, 86);
            this.PB_After.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_After.TabIndex = 1;
            this.PB_After.TabStop = false;
            // 
            // LabelAfter
            // 
            this.LabelAfter.AutoSize = true;
            this.LabelAfter.BackColor = System.Drawing.Color.Transparent;
            this.LabelAfter.BorderRadius = 5;
            this.LabelAfter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.LabelAfter.ForeColor = System.Drawing.Color.Black;
            this.LabelAfter.Location = new System.Drawing.Point(0, 0);
            this.LabelAfter.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelAfter.Name = "LabelAfter";
            this.LabelAfter.Size = new System.Drawing.Size(153, 19);
            this.LabelAfter.TabIndex = 0;
            this.LabelAfter.Text = "Dönüştürülecek Simge:";
            this.LabelAfter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PB_BeforePanel
            // 
            this.PB_BeforePanel.Controls.Add(this.PB_Before);
            this.PB_BeforePanel.Controls.Add(this.LabelBefore);
            this.PB_BeforePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_BeforePanel.Location = new System.Drawing.Point(0, 0);
            this.PB_BeforePanel.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.PB_BeforePanel.Name = "PB_BeforePanel";
            this.PB_BeforePanel.Size = new System.Drawing.Size(308, 115);
            this.PB_BeforePanel.TabIndex = 0;
            // 
            // PB_Before
            // 
            this.PB_Before.BackColor = System.Drawing.Color.White;
            this.PB_Before.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Before.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PB_Before.Location = new System.Drawing.Point(0, 29);
            this.PB_Before.Margin = new System.Windows.Forms.Padding(0);
            this.PB_Before.Name = "PB_Before";
            this.PB_Before.Padding = new System.Windows.Forms.Padding(10);
            this.PB_Before.Size = new System.Drawing.Size(308, 86);
            this.PB_Before.TabIndex = 0;
            this.PB_Before.TabStop = false;
            // 
            // LabelBefore
            // 
            this.LabelBefore.AutoSize = true;
            this.LabelBefore.BackColor = System.Drawing.Color.Transparent;
            this.LabelBefore.BorderRadius = 5;
            this.LabelBefore.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.LabelBefore.ForeColor = System.Drawing.Color.Black;
            this.LabelBefore.Location = new System.Drawing.Point(0, 0);
            this.LabelBefore.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelBefore.Name = "LabelBefore";
            this.LabelBefore.Size = new System.Drawing.Size(102, 19);
            this.LabelBefore.TabIndex = 0;
            this.LabelBefore.Text = "Orijinal Simge:";
            this.LabelBefore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TLP_Buttons
            // 
            this.TLP_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP_Buttons.ColumnCount = 2;
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Buttons.Controls.Add(this.BtnSelect, 0, 0);
            this.TLP_Buttons.Controls.Add(this.BtnColorPicker, 1, 0);
            this.TLP_Buttons.Controls.Add(this.BtnConvert, 1, 1);
            this.TLP_Buttons.Controls.Add(this.BtnSaveLocation, 0, 1);
            this.TLP_Buttons.Location = new System.Drawing.Point(373, 493);
            this.TLP_Buttons.Margin = new System.Windows.Forms.Padding(0);
            this.TLP_Buttons.Name = "TLP_Buttons";
            this.TLP_Buttons.RowCount = 2;
            this.TLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Buttons.Size = new System.Drawing.Size(626, 74);
            this.TLP_Buttons.TabIndex = 4;
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnSelect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnSelect.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnSelect.BorderRadius = 5;
            this.BtnSelect.BorderSize = 0;
            this.BtnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSelect.FlatAppearance.BorderSize = 0;
            this.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.BtnSelect.ForeColor = System.Drawing.Color.White;
            this.BtnSelect.Location = new System.Drawing.Point(0, 0);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(311, 35);
            this.BtnSelect.TabIndex = 0;
            this.BtnSelect.Text = "Dosya Seç";
            this.BtnSelect.TextColor = System.Drawing.Color.White;
            this.BtnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSelect.UseVisualStyleBackColor = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnColorPicker
            // 
            this.BtnColorPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnColorPicker.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnColorPicker.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnColorPicker.BorderRadius = 5;
            this.BtnColorPicker.BorderSize = 0;
            this.BtnColorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColorPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnColorPicker.FlatAppearance.BorderSize = 0;
            this.BtnColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColorPicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.BtnColorPicker.ForeColor = System.Drawing.Color.White;
            this.BtnColorPicker.Location = new System.Drawing.Point(315, 0);
            this.BtnColorPicker.Margin = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.BtnColorPicker.Name = "BtnColorPicker";
            this.BtnColorPicker.Size = new System.Drawing.Size(311, 35);
            this.BtnColorPicker.TabIndex = 1;
            this.BtnColorPicker.Text = "Renk Seç";
            this.BtnColorPicker.TextColor = System.Drawing.Color.White;
            this.BtnColorPicker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnColorPicker.UseVisualStyleBackColor = false;
            this.BtnColorPicker.Click += new System.EventHandler(this.BtnColorPicker_Click);
            // 
            // BtnConvert
            // 
            this.BtnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnConvert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnConvert.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnConvert.BorderRadius = 5;
            this.BtnConvert.BorderSize = 0;
            this.BtnConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConvert.FlatAppearance.BorderSize = 0;
            this.BtnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConvert.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.BtnConvert.ForeColor = System.Drawing.Color.White;
            this.BtnConvert.Location = new System.Drawing.Point(315, 39);
            this.BtnConvert.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(311, 35);
            this.BtnConvert.TabIndex = 3;
            this.BtnConvert.Text = "Dönüştür";
            this.BtnConvert.TextColor = System.Drawing.Color.White;
            this.BtnConvert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConvert.UseVisualStyleBackColor = false;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // BtnSaveLocation
            // 
            this.BtnSaveLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnSaveLocation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnSaveLocation.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnSaveLocation.BorderRadius = 5;
            this.BtnSaveLocation.BorderSize = 0;
            this.BtnSaveLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSaveLocation.FlatAppearance.BorderSize = 0;
            this.BtnSaveLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.BtnSaveLocation.ForeColor = System.Drawing.Color.White;
            this.BtnSaveLocation.Location = new System.Drawing.Point(0, 39);
            this.BtnSaveLocation.Margin = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.BtnSaveLocation.Name = "BtnSaveLocation";
            this.BtnSaveLocation.Size = new System.Drawing.Size(311, 35);
            this.BtnSaveLocation.TabIndex = 2;
            this.BtnSaveLocation.Text = "Kaydedilecek Konum";
            this.BtnSaveLocation.TextColor = System.Drawing.Color.White;
            this.BtnSaveLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSaveLocation.UseVisualStyleBackColor = false;
            this.BtnSaveLocation.Click += new System.EventHandler(this.BtnSaveLocation_Click);
            // 
            // PB_Back
            // 
            this.PB_Back.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Back.BackColor = System.Drawing.Color.White;
            this.PB_Back.BorderColor = System.Drawing.Color.DodgerBlue;
            this.PB_Back.BorderRadius = 3;
            this.PB_Back.BorderSize = 0;
            this.PB_Back.Controls.Add(this.PB_Front);
            this.PB_Back.Location = new System.Drawing.Point(373, 468);
            this.PB_Back.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.PB_Back.Name = "PB_Back";
            this.PB_Back.Size = new System.Drawing.Size(626, 15);
            this.PB_Back.TabIndex = 3;
            this.PB_Back.Visible = false;
            // 
            // PB_Front
            // 
            this.PB_Front.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PB_Front.BorderColor = System.Drawing.Color.DodgerBlue;
            this.PB_Front.BorderRadius = 0;
            this.PB_Front.BorderSize = 0;
            this.PB_Front.Dock = System.Windows.Forms.DockStyle.Left;
            this.PB_Front.Location = new System.Drawing.Point(0, 0);
            this.PB_Front.Name = "PB_Front";
            this.PB_Front.Size = new System.Drawing.Size(20, 15);
            this.PB_Front.TabIndex = 0;
            // 
            // ListIcons
            // 
            this.ListIcons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListIcons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListIcons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListIcons.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ListIcons.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.ListIcons.FormattingEnabled = true;
            this.ListIcons.HorizontalExtent = 10;
            this.ListIcons.HorizontalScrollbar = true;
            this.ListIcons.IntegralHeight = false;
            this.ListIcons.ItemHeight = 23;
            this.ListIcons.Location = new System.Drawing.Point(10, 10);
            this.ListIcons.Margin = new System.Windows.Forms.Padding(3, 3, 10, 10);
            this.ListIcons.Name = "ListIcons";
            this.ListIcons.SelectedBackColor = System.Drawing.Color.DodgerBlue;
            this.ListIcons.SelectedForeColor = System.Drawing.Color.White;
            this.ListIcons.Size = new System.Drawing.Size(350, 512);
            this.ListIcons.TabIndex = 0;
            this.ListIcons.SelectedIndexChanged += new System.EventHandler(this.ListIcons_SelectedIndexChanged);
            // 
            // MainToolTip
            // 
            this.MainToolTip.OwnerDraw = true;
            this.MainToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.MainToolTip_Draw);
            // 
            // HeaderMenu
            // 
            this.HeaderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.donateToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.HeaderMenu.Location = new System.Drawing.Point(0, 0);
            this.HeaderMenu.Name = "HeaderMenu";
            this.HeaderMenu.Size = new System.Drawing.Size(1008, 24);
            this.HeaderMenu.TabIndex = 0;
            this.HeaderMenu.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.startupToolStripMenuItem,
            this.listViewModeToolStripMenuItem,
            this.checkforUpdatesToolStripMenuItem});
            this.settingsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightThemeToolStripMenuItem,
            this.darkThemeToolStripMenuItem,
            this.systemThemeToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // lightThemeToolStripMenuItem
            // 
            this.lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            this.lightThemeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.lightThemeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.lightThemeToolStripMenuItem.Text = "Light Theme";
            this.lightThemeToolStripMenuItem.Click += new System.EventHandler(this.LightThemeToolStripMenuItem_Click);
            // 
            // darkThemeToolStripMenuItem
            // 
            this.darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            this.darkThemeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.darkThemeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.darkThemeToolStripMenuItem.Text = "Dark Theme";
            this.darkThemeToolStripMenuItem.Click += new System.EventHandler(this.DarkThemeToolStripMenuItem_Click);
            // 
            // systemThemeToolStripMenuItem
            // 
            this.systemThemeToolStripMenuItem.Name = "systemThemeToolStripMenuItem";
            this.systemThemeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.systemThemeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.systemThemeToolStripMenuItem.Text = "System Theme";
            this.systemThemeToolStripMenuItem.Click += new System.EventHandler(this.SystemThemeToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arabicToolStripMenuItem,
            this.chineseToolStripMenuItem,
            this.englishToolStripMenuItem,
            this.dutchToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.germanToolStripMenuItem,
            this.hindiToolStripMenuItem,
            this.italianToolStripMenuItem,
            this.japaneseToolStripMenuItem,
            this.koreanToolStripMenuItem,
            this.polishToolStripMenuItem,
            this.portugueseToolStripMenuItem,
            this.russianToolStripMenuItem,
            this.spanishToolStripMenuItem,
            this.turkishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // arabicToolStripMenuItem
            // 
            this.arabicToolStripMenuItem.Name = "arabicToolStripMenuItem";
            this.arabicToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.arabicToolStripMenuItem.Text = "Arabic";
            // 
            // chineseToolStripMenuItem
            // 
            this.chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
            this.chineseToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.chineseToolStripMenuItem.Text = "Chinese";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // dutchToolStripMenuItem
            // 
            this.dutchToolStripMenuItem.Name = "dutchToolStripMenuItem";
            this.dutchToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dutchToolStripMenuItem.Text = "Dutch";
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.frenchToolStripMenuItem.Text = "French";
            // 
            // germanToolStripMenuItem
            // 
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            this.germanToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.germanToolStripMenuItem.Text = "German";
            // 
            // hindiToolStripMenuItem
            // 
            this.hindiToolStripMenuItem.Name = "hindiToolStripMenuItem";
            this.hindiToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.hindiToolStripMenuItem.Text = "Hindi";
            // 
            // italianToolStripMenuItem
            // 
            this.italianToolStripMenuItem.Name = "italianToolStripMenuItem";
            this.italianToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.italianToolStripMenuItem.Text = "Italian";
            // 
            // japaneseToolStripMenuItem
            // 
            this.japaneseToolStripMenuItem.Name = "japaneseToolStripMenuItem";
            this.japaneseToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.japaneseToolStripMenuItem.Text = "Japanese";
            // 
            // koreanToolStripMenuItem
            // 
            this.koreanToolStripMenuItem.Name = "koreanToolStripMenuItem";
            this.koreanToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.koreanToolStripMenuItem.Text = "Korean";
            // 
            // polishToolStripMenuItem
            // 
            this.polishToolStripMenuItem.Name = "polishToolStripMenuItem";
            this.polishToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.polishToolStripMenuItem.Text = "Polish";
            // 
            // portugueseToolStripMenuItem
            // 
            this.portugueseToolStripMenuItem.Name = "portugueseToolStripMenuItem";
            this.portugueseToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.portugueseToolStripMenuItem.Text = "Portuguese";
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.russianToolStripMenuItem.Text = "Russian";
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.spanishToolStripMenuItem.Text = "Spanish";
            // 
            // turkishToolStripMenuItem
            // 
            this.turkishToolStripMenuItem.Name = "turkishToolStripMenuItem";
            this.turkishToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.turkishToolStripMenuItem.Text = "Turkish";
            // 
            // startupToolStripMenuItem
            // 
            this.startupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowedToolStripMenuItem,
            this.fullScreenToolStripMenuItem});
            this.startupToolStripMenuItem.Name = "startupToolStripMenuItem";
            this.startupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startupToolStripMenuItem.Text = "Startup Status";
            // 
            // windowedToolStripMenuItem
            // 
            this.windowedToolStripMenuItem.Name = "windowedToolStripMenuItem";
            this.windowedToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.windowedToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.windowedToolStripMenuItem.Text = "Windowed";
            this.windowedToolStripMenuItem.Click += new System.EventHandler(this.WindowedToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.fullScreenToolStripMenuItem.Text = "Full Screen";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.FullScreenToolStripMenuItem_Click);
            // 
            // listViewModeToolStripMenuItem
            // 
            this.listViewModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNameToolStripMenuItem,
            this.fullPathToolStripMenuItem});
            this.listViewModeToolStripMenuItem.Name = "listViewModeToolStripMenuItem";
            this.listViewModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listViewModeToolStripMenuItem.Text = "List View Mode";
            // 
            // fileNameToolStripMenuItem
            // 
            this.fileNameToolStripMenuItem.Name = "fileNameToolStripMenuItem";
            this.fileNameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.fileNameToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.fileNameToolStripMenuItem.Text = "File Name";
            this.fileNameToolStripMenuItem.Click += new System.EventHandler(this.FileNameToolStripMenuItem_Click);
            // 
            // fullPathToolStripMenuItem
            // 
            this.fullPathToolStripMenuItem.Name = "fullPathToolStripMenuItem";
            this.fullPathToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.fullPathToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.fullPathToolStripMenuItem.Text = "Full Path";
            this.fullPathToolStripMenuItem.Click += new System.EventHandler(this.FullPathToolStripMenuItem_Click);
            // 
            // checkforUpdatesToolStripMenuItem
            // 
            this.checkforUpdatesToolStripMenuItem.Name = "checkforUpdatesToolStripMenuItem";
            this.checkforUpdatesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.checkforUpdatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkforUpdatesToolStripMenuItem.Text = "Check Updates";
            this.checkforUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckforUpdatesToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.donateToolStripMenuItem.Text = "Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.DonateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // WalpaMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.HeaderMenu);
            this.DoubleBuffered = true;
            this.Icon = global::Walpa.Properties.Resources.WalpaLogo;
            this.KeyPreview = true;
            this.MainMenuStrip = this.HeaderMenu;
            this.MinimumSize = new System.Drawing.Size(1024, 640);
            this.Name = "WalpaMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Walpa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WalpaMain_FormClosing);
            this.Load += new System.EventHandler(this.WalpaMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.WalpaMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.WalpaMain_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WalpaMain_KeyDown);
            this.BackPanel.ResumeLayout(false);
            this.PanelStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Color)).EndInit();
            this.TLP_PictureBox.ResumeLayout(false);
            this.PB_AfterPanel.ResumeLayout(false);
            this.PB_AfterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_After)).EndInit();
            this.PB_BeforePanel.ResumeLayout(false);
            this.PB_BeforePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Before)).EndInit();
            this.TLP_Buttons.ResumeLayout(false);
            this.PB_Back.ResumeLayout(false);
            this.HeaderMenu.ResumeLayout(false);
            this.HeaderMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.PictureBox PB_After;
        private System.Windows.Forms.PictureBox PB_Before;
        private TSCustomButton BtnConvert;
        private TSCustomButton BtnSelect;
        private TSCustomListBox ListIcons;
        private TSCustomPanel PB_Back;
        private TSCustomPanel PB_Front;
        private TSCustomButton BtnSaveLocation;
        private TSCustomLabel LabelSLocation;
        private TSCustomLabel LabelSLocation_V;
        private TSCustomButton BtnColorPicker;
        private System.Windows.Forms.TableLayoutPanel TLP_Buttons;
        private System.Windows.Forms.TableLayoutPanel TLP_PictureBox;
        private TSCustomButton BtnClearList;
        private TSCustomLabel LabelColor;
        private System.Windows.Forms.PictureBox PB_Color;
        private System.Windows.Forms.Panel PanelStatus;
        private TSCustomLabel LabelAfter;
        private TSCustomLabel LabelBefore;
        private System.Windows.Forms.Panel PB_AfterPanel;
        private System.Windows.Forms.Panel PB_BeforePanel;
        private TSCustomLabel LabelIconCount;
        private TSCustomLabel LabelIconCount_V;
        private System.Windows.Forms.MenuStrip HeaderMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkforUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chineseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dutchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hindiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem japaneseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koreanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portugueseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turkishToolStripMenuItem;
    }
}

