using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
// TS Modules
using static Walpa.TSModules;

namespace Walpa{
    public partial class WalpaMain : Form{
        public WalpaMain(){
            InitializeComponent();
            // LANGUAGE SET MODES
            // ==================
            arabicToolStripMenuItem.Tag = "ar";
            chineseToolStripMenuItem.Tag = "zh";
            englishToolStripMenuItem.Tag = "en";
            dutchToolStripMenuItem.Tag = "nl";
            frenchToolStripMenuItem.Tag = "fr";
            germanToolStripMenuItem.Tag = "de";
            hindiToolStripMenuItem.Tag = "hi";
            italianToolStripMenuItem.Tag = "it";
            japaneseToolStripMenuItem.Tag = "ja";
            koreanToolStripMenuItem.Tag = "ko";
            polishToolStripMenuItem.Tag = "pl";
            portugueseToolStripMenuItem.Tag = "pt";
            russianToolStripMenuItem.Tag = "ru";
            spanishToolStripMenuItem.Tag = "es";
            turkishToolStripMenuItem.Tag = "tr";
            // LANGUAGE SET EVENTS
            // ==================
            arabicToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            chineseToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            englishToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            dutchToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            frenchToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            germanToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            hindiToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            italianToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            japaneseToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            koreanToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            polishToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            portugueseToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            russianToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            spanishToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            turkishToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            //
            SystemEvents.UserPreferenceChanged += (s, e) => TSUseSystemTheme();
            //
            PB_Before.SizeMode = PictureBoxSizeMode.Zoom;
            PB_After.SizeMode = PictureBoxSizeMode.Zoom;
        }
        // GLOBAL VARIABLES
        // ======================================================================================================
        public static string lang, lang_path;
        public static int theme, themeSystem, startup_status, listview_status;
        // UI COLORS
        // ======================================================================================================
        static readonly List<Color> header_colors = new List<Color>() { Color.Transparent, Color.Transparent, Color.Transparent };
        // HEADER SETTINGS
        // ======================================================================================================
        private class HeaderMenuColors : ToolStripProfessionalRenderer{
            public HeaderMenuColors() : base(new HeaderColors()) { }
            protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e) { e.ArrowColor = header_colors[1]; base.OnRenderArrow(e); }
            protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e){
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                float dpiScale = g.DpiX / 96f;
                Rectangle rect = e.ImageRectangle;
                using (Pen anti_alias_pen = new Pen(header_colors[2], 2.2f * dpiScale)){
                    anti_alias_pen.StartCap = LineCap.Round;
                    anti_alias_pen.EndCap = LineCap.Round;
                    anti_alias_pen.LineJoin = LineJoin.Round;
                    PointF p1 = new PointF(rect.Left + rect.Width * 0.18f, rect.Top + rect.Height * 0.52f);
                    PointF p2 = new PointF(rect.Left + rect.Width * 0.38f, rect.Top + rect.Height * 0.72f);
                    PointF p3 = new PointF(rect.Left + rect.Width * 0.78f, rect.Top + rect.Height * 0.28f);
                    g.DrawLines(anti_alias_pen, new[] { p1, p2, p3 });
                }
            }
        }
        private class HeaderColors : ProfessionalColorTable{
            public override Color MenuItemSelected => header_colors[0];
            public override Color ToolStripDropDownBackground => header_colors[0];
            public override Color ImageMarginGradientBegin => header_colors[0];
            public override Color ImageMarginGradientEnd => header_colors[0];
            public override Color ImageMarginGradientMiddle => header_colors[0];
            public override Color MenuItemSelectedGradientBegin => header_colors[0];
            public override Color MenuItemSelectedGradientEnd => header_colors[0];
            public override Color MenuItemPressedGradientBegin => header_colors[0];
            public override Color MenuItemPressedGradientMiddle => header_colors[0];
            public override Color MenuItemPressedGradientEnd => header_colors[0];
            public override Color MenuItemBorder => header_colors[0];
            public override Color CheckBackground => header_colors[0];
            public override Color ButtonSelectedBorder => header_colors[0];
            public override Color CheckSelectedBackground => header_colors[0];
            public override Color CheckPressedBackground => header_colors[0];
            public override Color MenuBorder => header_colors[0];
            public override Color SeparatorLight => header_colors[1];
            public override Color SeparatorDark => header_colors[1];
        }
        // LOAD SOFTWARE SETTINGS
        // ======================================================================================================
        private void RunSoftwareEngine(){
            // DOUBLE BUFFER TABLE LAYOUT PANEL
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, TLP_Buttons, new object[] { true });
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, TLP_PictureBox, new object[] { true });
            // THEME - LANG - STARTUP MODE PRELOADER
            // ======================================================================================================
            TSSettingsModule software_read_settings = new TSSettingsModule(ts_sf);
            //
            int theme_mode = int.TryParse(software_read_settings.TSReadSettings(ts_settings_container, "ThemeStatus"), out int the_status) && (the_status == 0 || the_status == 1 || the_status == 2) ? the_status : 1;
            if (theme_mode == 2) { themeSystem = 2; Theme_engine(TSThemeModeHelper.GetSystemTheme(2)); } else Theme_engine(theme_mode);
            darkThemeToolStripMenuItem.Checked = theme_mode == 0;
            lightThemeToolStripMenuItem.Checked = theme_mode == 1;
            systemThemeToolStripMenuItem.Checked = theme_mode == 2;
            //
            string lang_mode = software_read_settings.TSReadSettings(ts_settings_container, "LanguageStatus");
            var languageFiles = new Dictionary<string, (object langResource, ToolStripMenuItem menuItem, bool fileExists)>{
                { "ar", (ts_lang_ar, arabicToolStripMenuItem, File.Exists(ts_lang_ar)) },
                { "zh", (ts_lang_zh, chineseToolStripMenuItem, File.Exists(ts_lang_zh)) },
                { "en", (ts_lang_en, englishToolStripMenuItem, File.Exists(ts_lang_en)) },
                { "nl", (ts_lang_nl, dutchToolStripMenuItem, File.Exists(ts_lang_nl)) },
                { "fr", (ts_lang_fr, frenchToolStripMenuItem, File.Exists(ts_lang_fr)) },
                { "de", (ts_lang_de, germanToolStripMenuItem, File.Exists(ts_lang_de)) },
                { "hi", (ts_lang_hi, hindiToolStripMenuItem, File.Exists(ts_lang_hi)) },
                { "it", (ts_lang_it, italianToolStripMenuItem, File.Exists(ts_lang_it)) },
                { "ja", (ts_lang_ja, japaneseToolStripMenuItem, File.Exists(ts_lang_ja)) },
                { "ko", (ts_lang_ko, koreanToolStripMenuItem, File.Exists(ts_lang_ko)) },
                { "pl", (ts_lang_pl, polishToolStripMenuItem, File.Exists(ts_lang_pl)) },
                { "pt", (ts_lang_pt, portugueseToolStripMenuItem, File.Exists(ts_lang_pt)) },
                { "ru", (ts_lang_ru, russianToolStripMenuItem, File.Exists(ts_lang_ru)) },
                { "es", (ts_lang_es, spanishToolStripMenuItem, File.Exists(ts_lang_es)) },
                { "tr", (ts_lang_tr, turkishToolStripMenuItem, File.Exists(ts_lang_tr)) },
            };
            foreach (var langLoader in languageFiles) { langLoader.Value.menuItem.Enabled = langLoader.Value.fileExists; }
            var (langResource, selectedMenuItem, _) = languageFiles.ContainsKey(lang_mode) ? languageFiles[lang_mode] : languageFiles["en"];
            Lang_engine(Convert.ToString(langResource), lang_mode);
            selectedMenuItem.Checked = true;
            //
            string startup_mode = software_read_settings.TSReadSettings(ts_settings_container, "StartupStatus");
            startup_status = int.TryParse(startup_mode, out int str_status) && (str_status == 0 || str_status == 1) ? str_status : 0;
            WindowState = startup_status == 1 ? FormWindowState.Maximized : FormWindowState.Normal;
            windowedToolStripMenuItem.Checked = startup_status == 0;
            fullScreenToolStripMenuItem.Checked = startup_status == 1;
            //
            string listview_mode = software_read_settings.TSReadSettings(ts_settings_container, "ListViewStatus");
            listview_status = int.TryParse(listview_mode, out int lvm_status) && (lvm_status == 0 || lvm_status == 1) ? lvm_status : 0;
            fileNameToolStripMenuItem.Checked = listview_status == 0;
            fullPathToolStripMenuItem.Checked = listview_status == 1;
        }
        // MAIN TOOLTIP SETTINGS
        // ======================================================================================================
        private void MainToolTip_Draw(object sender, DrawToolTipEventArgs e){ e.DrawBackground(); e.DrawBorder(); e.DrawText(); }
        // LOAD
        // ======================================================================================================
        private void WalpaMain_Load(object sender, EventArgs e){
            Text = TS_VersionEngine.TS_SoftwareVersion(0);
            HeaderMenu.Cursor = Cursors.Hand;
            // LOAD MODULE PRELOAD
            RunSoftwareEngine();
            //
            Task softwareUpdateCheck = Task.Run(() => Software_update_check(0));
        }
        // MODULE
        // ======================================================================================================
        public class TS_FileItem{
            public string FileName { get; set; }
            public string FullPath { get; set; }
            private bool _showFullPath = false;
            public void SetDisplayMode(bool showFullPath){
                _showFullPath = showFullPath;
            }
            public override string ToString(){
                return _showFullPath ? FullPath : FileName;
            }
        }
        // FIELDS
        // ======================================================================================================
        private Color _selectedColor = Color.Black;
        private bool _isColorSelected = false;
        private string _saveDirectory = string.Empty;
        private bool _isProcessing = false;
        private readonly string[] _supportedExtensions = { ".png", ".jpg", ".jpeg", ".bmp", ".tiff", ".tif" };
        private const string _filterString = "|*.png;*.jpg;*.jpeg;*.bmp;*.tiff;*.tif";
        // IMAGE PREVIEW ADD PADDING
        // ======================================================================================================
        private Image AddPaddingToImage(Image originalImage, int padding = 15){
            if (originalImage == null) return null;
            int newWidth = originalImage.Width + (padding * 2);
            int newHeight = originalImage.Height + (padding * 2);
            Bitmap paddedImage = new Bitmap(newWidth, newHeight, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(paddedImage)){
                g.Clear(Color.Transparent);
                g.DrawImage(originalImage, padding, padding);
            }
            return paddedImage;
        }
        // IMAGE LOADER
        // ======================================================================================================
        private void LoadImageToPictureBox(PictureBox pictureBox, Image image){
            if (pictureBox.Image != null){
                var oldImage = pictureBox.Image;
                pictureBox.Image = null;
                oldImage.Dispose();
            }
            pictureBox.Image = image;
        }
        // IMAGE PROCESSOR
        // ======================================================================================================
        private Image LoadImageFromFile(string filePath){
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (var temp = Image.FromStream(fs)){
                return new Bitmap(temp);
            }
        }
        // REFRESH LIST VIEW MODE
        // ======================================================================================================
        private void RefreshListViewDisplay(){
            bool showFullPath = (listview_status == 1);
            foreach (TS_FileItem item in ListIcons.Items){
                item.SetDisplayMode(showFullPath);
            }
            ListIcons.Invalidate(); // or ListIcons.Refresh();
            ListIcons.UpdateHorizontalExtent();
        }
        // ADD FILES TO LIST
        // ======================================================================================================
        private void AddFilesToList(string[] items){
            bool showFullPath = (listview_status == 1);
            foreach (string item in items){
                if (Directory.Exists(item)){
                    try { AddFilesToList(Directory.GetFiles(item, "*.*", SearchOption.AllDirectories)); }
                    catch { continue; }
                }else if (File.Exists(item)){
                    string ext = Path.GetExtension(item).ToLower();
                    if (_supportedExtensions.Contains(ext)){
                        if (!ListIcons.Items.Cast<TS_FileItem>().Any(x => x.FullPath == item)){
                            var newItem = new TS_FileItem{
                                FileName = Path.GetFileName(item),
                                FullPath = item
                            };
                            newItem.SetDisplayMode(showFullPath);
                            ListIcons.Items.Add(newItem);
                        }
                    }
                }
            }
            ListIcons.UpdateHorizontalExtent();
            UpdateItemCount();
        }
        // UPDATE TOTAL FILE SIZE
        // ======================================================================================================
        private long GetTotalFileSize(){
            long totalSize = 0;
            foreach (TS_FileItem item in ListIcons.Items){
                try{
                    if (File.Exists(item.FullPath)){
                        FileInfo fileInfo = new FileInfo(item.FullPath);
                        totalSize += fileInfo.Length;
                    }
                }catch{
                    continue;
                }
            }
            return totalSize;
        }
        // UPDATE ITEM COUNT
        // ======================================================================================================
        private void UpdateItemCount(){
            TSGetLangs software_lang = new TSGetLangs(lang_path);
            if (ListIcons.Items.Count > 0){
                LabelIconCount_V.Text = string.Format(software_lang.TSReadLangs("WalpaMain", "wm_icon_count"), ListIcons.Items.Count, "\n", TS_FormatSize(GetTotalFileSize()));
            }else{
                LabelIconCount_V.Text = software_lang.TSReadLangs("WalpaMain", "wm_icon_not_yet");
            }
        }
        // BUTTON SELECT
        // ======================================================================================================
        private void BtnSelect_Click(object sender, EventArgs e){
            using (OpenFileDialog ofd = new OpenFileDialog()){
                TSGetLangs software_lang = new TSGetLangs(lang_path);
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofd.Filter = string.Format(software_lang.TSReadLangs("WalpaMain", "wm_filter_image"), _filterString);
                ofd.Title = string.Format(software_lang.TSReadLangs("WalpaMain", "wm_filter_title"), Application.ProductName);
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK){
                    AddFilesToList(ofd.FileNames);
                }
            }
        }
        // DRAG & DROP
        // ======================================================================================================
        private void WalpaMain_DragEnter(object sender, DragEventArgs e){
            if (_isProcessing){
                e.Effect = DragDropEffects.None;
                return;
            }
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }
        private void WalpaMain_DragDrop(object sender, DragEventArgs e){
            if (_isProcessing){
                return;
            }
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            AddFilesToList(droppedFiles);
        }
        // CLEAR SELECTION - COPY & PASTE SUPPORT
        // ======================================================================================================
        private void WalpaMain_KeyDown(object sender, KeyEventArgs e){
            // CLEAR SELECTION
            if (e.KeyCode == Keys.Escape){
                ResetAllPreviews();
                e.Handled = true;
                return;
            }
            // PASTE ALGORITHM
            if (e.Control && e.KeyCode == Keys.V){
                if (_isProcessing){
                    e.Handled = true;
                    return;
                }
                try{
                    IDataObject clipboardData = Clipboard.GetDataObject();
                    if (clipboardData != null){
                        if (clipboardData.GetDataPresent(DataFormats.FileDrop)){
                            string[] files = (string[])clipboardData.GetData(DataFormats.FileDrop);
                            if (files != null && files.Length > 0){
                                AddFilesToList(files);
                            }
                        }else if (clipboardData.GetDataPresent(DataFormats.Text)){
                            string text = (string)clipboardData.GetData(DataFormats.Text);
                            if (!string.IsNullOrEmpty(text)){
                                string[] lines = text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                                var validPaths = lines.Select(l => l.Trim()).Where(p => File.Exists(p) || Directory.Exists(p)).ToArray();
                                if (validPaths.Length > 0){
                                    AddFilesToList(validPaths);
                                }
                            }
                        }
                    }
                }catch (Exception){ }
                e.Handled = true;
            }
        }
        // SAVE LOCATION
        // ======================================================================================================
        private void BtnSaveLocation_Click(object sender, EventArgs e){
            using (FolderBrowserDialog fbd = new FolderBrowserDialog()){
                TSGetLangs software_lang = new TSGetLangs(lang_path);
                fbd.Description = software_lang.TSReadLangs("WalpaMain", "wm_filter_save_tag");
                fbd.ShowNewFolderButton = true;
                fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (fbd.ShowDialog() == DialogResult.OK){
                    _saveDirectory = fbd.SelectedPath;
                    LabelSLocation_V.Text = _saveDirectory;
                }
            }
        }
        // COLOR PICKER
        // ======================================================================================================
        private void BtnColorPicker_Click(object sender, EventArgs e){
            using (WalpaColorPicker pickerModule = new WalpaColorPicker()){
                if (pickerModule.ShowDialog() == DialogResult.OK){
                    _selectedColor = pickerModule.SelectedColor;
                    PB_Color.BackColor = _selectedColor;
                    LabelColor.Visible = true;
                    PB_Color.Visible = true;
                    _isColorSelected = true;
                    if (ListIcons.SelectedItem is TS_FileItem selectedItem){
                        UpdateAfterImage(selectedItem.FullPath);
                    }
                }else{
                    _isColorSelected = false;
                    PB_Color.BackColor = Color.Transparent;
                    ClearAfterIfNoColor();
                }
            }
        }
        // UPDATE AFTER IMAGE
        // ======================================================================================================
        private void UpdateAfterImage(string filePath){
            try{
                using (var originalImage = LoadImageFromFile(filePath))
                using (var processedImage = WalpaImageModule.TS_CI_Engine(originalImage, _selectedColor)){
                    LoadImageToPictureBox(PB_After, AddPaddingToImage(processedImage));
                }
            }catch (Exception){
                LoadImageToPictureBox(PB_After, null);
            }
        }
        // LIST SELECTION CHANGED
        // ======================================================================================================
        private void ListIcons_SelectedIndexChanged(object sender, EventArgs e){
            if (ListIcons.SelectedItem is TS_FileItem selectedItem){
                try{
                    LoadImageToPictureBox(PB_Before, null);
                    LoadImageToPictureBox(PB_After, null);
                    using (var originalImage = LoadImageFromFile(selectedItem.FullPath)){
                        LoadImageToPictureBox(PB_Before, AddPaddingToImage(originalImage));
                        if (_isColorSelected){
                            using (var processedImage = WalpaImageModule.TS_CI_Engine(originalImage, _selectedColor)){
                                LoadImageToPictureBox(PB_After, AddPaddingToImage(processedImage));
                            }
                        }
                    }
                }catch (Exception){
                    LoadImageToPictureBox(PB_Before, null);
                    LoadImageToPictureBox(PB_After, null);
                }
            }else{
                LoadImageToPictureBox(PB_Before, null);
                LoadImageToPictureBox(PB_After, null);
            }
        }
        // BUTTON CONVERT
        // ======================================================================================================
        private async void BtnConvert_Click(object sender, EventArgs e){
            TSGetLangs software_lang = new TSGetLangs(lang_path);
            //
            if (ListIcons.Items.Count == 0){
                TS_MessageBoxEngine.TS_MessageBox(this, 2, software_lang.TSReadLangs("WalpaMain", "wm_warning_list_zero"));
                return;
            }
            if (!_isColorSelected){
                TS_MessageBoxEngine.TS_MessageBox(this, 2, software_lang.TSReadLangs("WalpaMain", "wm_warning_color"));
                return;
            }
            if (string.IsNullOrEmpty(_saveDirectory) || !Directory.Exists(_saveDirectory)){
                TS_MessageBoxEngine.TS_MessageBox(this, 2, software_lang.TSReadLangs("WalpaMain", "wm_warning_save_directory"));
                return;
            }
            //
            DialogResult query_start = TS_MessageBoxEngine.TS_MessageBox(this, 10, software_lang.TSReadLangs("WalpaMain", "wm_process_query"));
            if (query_start == DialogResult.Yes){
                _isProcessing = true;
                //
                PB_Back.Visible = true;
                PB_Front.Visible = true;
                PB_Front.Width = 0;
                //
                BtnClearList.Enabled = false;
                BtnSelect.Enabled = false;
                BtnColorPicker.Enabled = false;
                BtnSaveLocation.Enabled = false;
                BtnConvert.Enabled = false;
                //
                string originalTitle = this.Text;
                //
                int totalFiles = ListIcons.Items.Count;
                int currentFile = 0;
                //
                bool hasError = false;
                //
                string process_title = software_lang.TSReadLangs("WalpaMain", "wm_process_running");
                //
                foreach (TS_FileItem item in ListIcons.Items){
                    string filePath = item.FullPath;
                    if (!File.Exists(filePath)) continue;
                    //
                    currentFile++;
                    int percentage = (currentFile * 100) / totalFiles;
                    //
                    this.BeginInvoke((MethodInvoker)delegate {
                        this.Text = string.Format(process_title, Application.ProductName, $"{percentage}%", currentFile, totalFiles);
                        int targetWidth = (PB_Back.Width * percentage) / 100;
                        PB_Front.Width = Math.Min(targetWidth, PB_Back.Width);
                    });
                    //
                    try{
                        using (var originalImage = LoadImageFromFile(filePath))
                        using (var processedImage = await Task.Run(() => WalpaImageModule.TS_CI_Engine(originalImage, _selectedColor))){
                            LoadImageToPictureBox(PB_Before, AddPaddingToImage(originalImage));
                            LoadImageToPictureBox(PB_After, AddPaddingToImage(processedImage));
                            //
                            string fileNameOnly = Path.GetFileNameWithoutExtension(filePath);
                            string savePath = Path.Combine(_saveDirectory, fileNameOnly + ".png");
                            //
                            int counter = 1;
                            while (File.Exists(savePath)){
                                savePath = Path.Combine(_saveDirectory, $"{fileNameOnly}_{counter}.png");
                                counter++;
                            }
                            //
                            await Task.Run(() => processedImage.Save(savePath, ImageFormat.Png));
                        }
                    }catch (Exception ex){
                        Debug.WriteLine($"File could not be processed: {filePath} - Error: {ex.Message}");
                        hasError = true;
                    }
                }
                //
                _isProcessing = false;
                //
                this.Text = originalTitle;
                //
                BtnClearList.Enabled = true;
                BtnSelect.Enabled = true;
                BtnColorPicker.Enabled = true;
                BtnSaveLocation.Enabled = true;
                BtnConvert.Enabled = true;
                //
                string __tempory_savedDirectory = _saveDirectory;
                //
                ResetToDefaults();
                //
                if (!hasError){
                    DialogResult query_folder_open = TS_MessageBoxEngine.TS_MessageBox(this, 5, string.Format(software_lang.TSReadLangs("WalpaMain", "wm_success_convert"), totalFiles, __tempory_savedDirectory, "\n\n"));
                    if (query_folder_open == DialogResult.Yes){
                        if (Directory.Exists(__tempory_savedDirectory)){
                            Process.Start("explorer.exe", __tempory_savedDirectory);
                        }
                    }
                }else{
                    TS_MessageBoxEngine.TS_MessageBox(this, 3, string.Format(software_lang.TSReadLangs("WalpaMain", "wm_failed_convert"), "\n\n", $"{currentFile - 1}", totalFiles));
                }
            }
        }
        // BUTTON CLEAR LIST
        // ======================================================================================================
        private void BtnClearList_Click(object sender, EventArgs e){
            ListIcons.Items.Clear();
            ResetAllPreviews();
            UpdateItemCount();
        }
        // RESET TO DEFAULTS
        // ======================================================================================================
        private void ResetToDefaults(){
            TSGetLangs software_lang = new TSGetLangs(lang_path);
            //
            _isProcessing = false;
            //
            _selectedColor = Color.Black;
            _isColorSelected = false;
            _saveDirectory = string.Empty;
            //
            LabelSLocation_V.Text = software_lang.TSReadLangs("WalpaMain", "wm_label_save_location_null");
            PB_Color.BackColor = Color.Transparent;
            //
            LabelColor.Visible = false;
            PB_Color.Visible = false;
            //
            ListIcons.Items.Clear();
            ResetAllPreviews();
            UpdateItemCount();
            //
            PB_Front.Width = 0;
            PB_Back.Visible = false;
            PB_Front.Visible = false;
        }
        // CLEAR AFTER IF NO COLOR SELECTED
        // ======================================================================================================
        private void ClearAfterIfNoColor(){
            if (!_isColorSelected){
                LoadImageToPictureBox(PB_After, null);
            }
        }
        // RESET ALL PREVIEWS
        // ======================================================================================================
        private void ResetAllPreviews(){
            LoadImageToPictureBox(PB_Before, null);
            LoadImageToPictureBox(PB_After, null);
            ListIcons.SelectedIndex = -1;
        }
        // ======================================================================================================
        // THEME SETTINGS
        private ToolStripMenuItem selected_theme = null;
        private void Select_theme_active(object target_theme){
            if (target_theme == null)
                return;
            ToolStripMenuItem clicked_theme = (ToolStripMenuItem)target_theme;
            if (selected_theme == clicked_theme)
                return;
            Select_theme_deactive();
            selected_theme = clicked_theme;
            selected_theme.Checked = true;
        }
        private void Select_theme_deactive(){
            foreach (ToolStripMenuItem theme in themeToolStripMenuItem.DropDownItems){
                theme.Checked = false;
            }
        }
        private void SystemThemeToolStripMenuItem_Click(object sender, EventArgs e){
            themeSystem = 2; Theme_engine(TSThemeModeHelper.GetSystemTheme(2)); SaveTheme(2); Select_theme_active(sender);
        }
        private void LightThemeToolStripMenuItem_Click(object sender, EventArgs e){
            themeSystem = 0; Theme_engine(1); SaveTheme(1); Select_theme_active(sender);
        }
        private void DarkThemeToolStripMenuItem_Click(object sender, EventArgs e){
            themeSystem = 0; Theme_engine(0); SaveTheme(0); Select_theme_active(sender);
        }
        private void TSUseSystemTheme() { if (themeSystem == 2) Theme_engine(TSThemeModeHelper.GetSystemTheme(2)); }
        private void SaveTheme(int ts){
            // SAVE CURRENT THEME
            try{
                TSSettingsModule software_setting_save = new TSSettingsModule(ts_sf);
                software_setting_save.TSWriteSettings(ts_settings_container, "ThemeStatus", Convert.ToString(ts));
            }catch (Exception) { }
        }
        private void Theme_engine(int ts){
            try{
                theme = ts;
                //
                TSThemeModeHelper.SetThemeMode(ts == 0);
                TSThemeModeHelper.InitializeThemeForForm(this);
                //
                if (theme == 1){
                    TSImageRenderer(settingsToolStripMenuItem, Properties.Resources.tm_settings_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(themeToolStripMenuItem, Properties.Resources.tm_theme_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(languageToolStripMenuItem, Properties.Resources.tm_language_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(startupToolStripMenuItem, Properties.Resources.tm_startup_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(listViewModeToolStripMenuItem, Properties.Resources.tm_listview_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(checkforUpdatesToolStripMenuItem, Properties.Resources.tm_update_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(donateToolStripMenuItem, Properties.Resources.tm_donate_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(aboutToolStripMenuItem, Properties.Resources.tm_about_light, 0, ContentAlignment.MiddleRight);
                    //
                    TSImageRenderer(BtnClearList, Properties.Resources.ct_clean_light, 17, ContentAlignment.MiddleRight);
                    TSImageRenderer(BtnSelect, Properties.Resources.ct_file_light, 17, ContentAlignment.MiddleRight);
                    TSImageRenderer(BtnColorPicker, Properties.Resources.ct_color_light, 17, ContentAlignment.MiddleRight);
                    TSImageRenderer(BtnSaveLocation, Properties.Resources.ct_save_light, 17, ContentAlignment.MiddleRight);
                    TSImageRenderer(BtnConvert, Properties.Resources.ct_convert_light, 15, ContentAlignment.MiddleRight);
                }else if (theme == 0){
                    TSImageRenderer(settingsToolStripMenuItem, Properties.Resources.tm_settings_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(themeToolStripMenuItem, Properties.Resources.tm_theme_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(languageToolStripMenuItem, Properties.Resources.tm_language_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(startupToolStripMenuItem, Properties.Resources.tm_startup_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(listViewModeToolStripMenuItem, Properties.Resources.tm_listview_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(checkforUpdatesToolStripMenuItem, Properties.Resources.tm_update_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(donateToolStripMenuItem, Properties.Resources.tm_donate_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(aboutToolStripMenuItem, Properties.Resources.tm_about_dark, 0, ContentAlignment.MiddleRight);
                    //
                    TSImageRenderer(BtnClearList, Properties.Resources.ct_clean_dark, 17, ContentAlignment.MiddleRight);
                    TSImageRenderer(BtnSelect, Properties.Resources.ct_file_dark, 17, ContentAlignment.MiddleRight);
                    TSImageRenderer(BtnColorPicker, Properties.Resources.ct_color_dark, 17, ContentAlignment.MiddleRight);
                    TSImageRenderer(BtnSaveLocation, Properties.Resources.ct_save_dark, 17, ContentAlignment.MiddleRight);
                    TSImageRenderer(BtnConvert, Properties.Resources.ct_convert_dark, 15, ContentAlignment.MiddleRight);
                }
                header_colors[0] = TS_ThemeEngine.ColorMode(theme, "TSBT_BGColor2");
                header_colors[1] = TS_ThemeEngine.ColorMode(theme, "TSBT_LabelColor1");
                header_colors[2] = TS_ThemeEngine.ColorMode(theme, "TSBT_AccentColor");
                HeaderMenu.Renderer = new HeaderMenuColors();
                // TOOLTIP
                MainToolTip.ForeColor = TS_ThemeEngine.ColorMode(theme, "TSBT_LabelColor1");
                MainToolTip.BackColor = TS_ThemeEngine.ColorMode(theme, "TSBT_BGColor");
                // HEADER MENU
                var bg = TS_ThemeEngine.ColorMode(theme, "TSBT_BGColor");
                var fg = TS_ThemeEngine.ColorMode(theme, "TSBT_LabelColor1");
                HeaderMenu.ForeColor = fg;
                HeaderMenu.BackColor = bg;
                SetMenuStripColors(HeaderMenu, bg, fg);
                // CONTENT BG
                BackColor = TS_ThemeEngine.ColorMode(theme, "TSBT_BGColor");
                //
                foreach (Control control_items in BackPanel.Controls){
                    if (control_items is TSCustomListBox ui_list){
                        ui_list.BackColor = TS_ThemeEngine.ColorMode(theme, "TSBT_BGColor2");
                        ui_list.ForeColor = TS_ThemeEngine.ColorMode(theme, "TSBT_LabelColor1");
                        ui_list.SelectedBackColor = TS_ThemeEngine.ColorMode(theme, "TSBT_AccentColor");
                        ui_list.SelectedForeColor = TS_ThemeEngine.ColorMode(theme, "DynamicThemeActiveBtnBGColor");
                    }
                }
                //
                var allPictureBox = PB_BeforePanel.Controls.Cast<Control>().Concat(PB_AfterPanel.Controls.Cast<Control>());
                foreach (Control control_items in allPictureBox){
                    if (control_items is PictureBox ui_picture_box){
                        ui_picture_box.BackColor = TS_ThemeEngine.ColorMode(theme, "TSBT_BGColor2");
                    }
                    if (control_items is TSCustomLabel ui_label){
                        ui_label.ForeColor = TS_ThemeEngine.ColorMode(theme, "TSBT_LabelColor1");
                    }
                }
                //
                PanelStatus.BackColor = TS_ThemeEngine.ColorMode(theme, "TSBT_BGColor2");
                foreach (Control control_items in PanelStatus.Controls){
                    if (control_items is TSCustomLabel ui_label){
                        ui_label.ForeColor = TS_ThemeEngine.ColorMode(theme, "TSBT_LabelColor1");
                    }
                }
                //
                var allButtons = BackPanel.Controls.Cast<Control>().Concat(TLP_Buttons.Controls.Cast<Control>());
                foreach (Control control_items in allButtons){
                    if (control_items is TSCustomButton ui_button){
                        ui_button.ForeColor = TS_ThemeEngine.ColorMode(theme, "DynamicThemeActiveBtnBGColor");
                        ui_button.BackColor = TS_ThemeEngine.ColorMode(theme, "TSBT_AccentColor");
                        ui_button.FlatAppearance.BorderColor = TS_ThemeEngine.ColorMode(theme, "TSBT_AccentColor");
                        ui_button.FlatAppearance.MouseDownBackColor = TS_ThemeEngine.ColorMode(theme, "TSBT_AccentColor");
                        ui_button.FlatAppearance.MouseOverBackColor = TS_ThemeEngine.ColorMode(theme, "AccentColorHover");
                    }
                }
                //
                LabelSLocation_V.ForeColor = TS_ThemeEngine.ColorMode(theme, "TSBT_AccentColor");
                LabelIconCount_V.ForeColor = TS_ThemeEngine.ColorMode(theme, "TSBT_AccentColor");
                PB_Front.BackColor = TS_ThemeEngine.ColorMode(theme, "TSBT_AccentColor");
                // OTHER PAGE PRELOADER
                SoftwareOtherPage_Preloader();
            }catch (Exception) { }
        }
        private void SetMenuStripColors(MenuStrip menuStrip, Color bgColor, Color fgColor){
            if (menuStrip == null) return;
            foreach (ToolStripItem item in menuStrip.Items){
                if (item is ToolStripMenuItem menuItem){
                    SetMenuItemColors(menuItem, bgColor, fgColor);
                }
            }
        }
        private void SetMenuItemColors(ToolStripMenuItem menuItem, Color bgColor, Color fgColor){
            if (menuItem == null) return;
            menuItem.BackColor = bgColor;
            menuItem.ForeColor = fgColor;
            foreach (ToolStripItem item in menuItem.DropDownItems){
                if (item is ToolStripMenuItem subMenuItem){
                    SetMenuItemColors(subMenuItem, bgColor, fgColor);
                }
            }
        }
        private void SetContextMenuColors(ContextMenuStrip contextMenu, Color bgColor, Color fgColor){
            if (contextMenu == null) return;
            foreach (ToolStripItem item in contextMenu.Items){
                if (item is ToolStripMenuItem menuItem){
                    SetMenuItemColors(menuItem, bgColor, fgColor);
                }
            }
        }
        // LANGUAGES SETTINGS
        // ======================================================================================================
        private ToolStripMenuItem selected_lang = null;
        private void Select_lang_active(object target_lang){
            if (target_lang == null)
                return;
            ToolStripMenuItem clicked_lang = (ToolStripMenuItem)target_lang;
            if (selected_lang == clicked_lang)
                return;
            Select_lang_deactive();
            selected_lang = clicked_lang;
            selected_lang.Checked = true;
        }
        private void Select_lang_deactive(){
            foreach (ToolStripMenuItem disabled_lang in languageToolStripMenuItem.DropDownItems){
                disabled_lang.Checked = false;
            }
        }
        private void LanguageToolStripMenuItem_Click(object sender, EventArgs e){
            if (sender is ToolStripMenuItem menuItem && menuItem.Tag is string langCode){
                if (lang != langCode && AllLanguageFiles.ContainsKey(langCode)){
                    Lang_preload(AllLanguageFiles[langCode], langCode);
                    Select_lang_active(sender);
                }
            }
        }
        private void Lang_preload(string lang_type, string lang_code){
            Lang_engine(lang_type, lang_code);
            try{
                TSSettingsModule software_setting_save = new TSSettingsModule(ts_sf);
                software_setting_save.TSWriteSettings(ts_settings_container, "LanguageStatus", lang_code);
            }catch (Exception){ }
            // LANG CHANGE NOTIFICATION
            // TSGetLangs software_lang = new TSGetLangs(lang_path);
            // DialogResult lang_change_message = TS_MessageBoxEngine.TS_MessageBox(this, 5, string.Format(software_lang.TSReadLangs("LangChange", "lang_change_notification"), "\n\n", "\n\n"));
            // if (lang_change_message == DialogResult.Yes) { Application.Restart(); }
        }
        private void Lang_engine(string lang_type, string lang_code){
            try{
                lang_path = lang_type;
                lang = lang_code;
                // GLOBAL ENGINE
                TSGetLangs software_lang = new TSGetLangs(lang_path);
                // SETTINGS
                settingsToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_settings");
                // THEMES
                themeToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_theme");
                lightThemeToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderThemes", "theme_light");
                darkThemeToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderThemes", "theme_dark");
                systemThemeToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderThemes", "theme_system");
                // LANGS
                languageToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_language");
                arabicToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_ar");
                chineseToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_zh");
                englishToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_en");
                dutchToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_nl");
                frenchToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_fr");
                germanToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_de");
                hindiToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_hi");
                italianToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_it");
                japaneseToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_ja");
                koreanToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_ko");
                polishToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_pl");
                portugueseToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_pt");
                russianToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_ru");
                spanishToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_es");
                turkishToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_tr");
                // STARTUP MODE
                startupToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_start");
                windowedToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderViewMode", "header_view_mode_windowed");
                fullScreenToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderViewMode", "header_view_mode_full_screen");
                // LIST VIEW MODE
                listViewModeToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_listview");
                fileNameToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderListViewMode", "header_list_view_mode_file_name");
                fullPathToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderListViewMode", "header_list_view_mode_full_path");
                // UPDATE CHECK
                checkforUpdatesToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_update");
                // DONATE
                donateToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_donate");
                // ABOUT
                aboutToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_about");
                // MAIN
                LabelBefore.Text = software_lang.TSReadLangs("WalpaMain", "wm_label_pb_before");
                LabelAfter.Text = software_lang.TSReadLangs("WalpaMain", "wm_label_pb_after");
                LabelSLocation.Text = software_lang.TSReadLangs("WalpaMain", "wm_label_save_location");
                LabelIconCount.Text = software_lang.TSReadLangs("WalpaMain", "wm_icon_count_title");
                LabelColor.Text = software_lang.TSReadLangs("WalpaMain", "wm_label_select_color");
                //
                BtnClearList.Text = " " + software_lang.TSReadLangs("WalpaMain", "wm_btn_clear_list");
                BtnSelect.Text = " " + software_lang.TSReadLangs("WalpaMain", "wm_btn_file_select");
                BtnColorPicker.Text = " " + software_lang.TSReadLangs("WalpaMain", "wm_btn_color_select");
                BtnSaveLocation.Text = " " + software_lang.TSReadLangs("WalpaMain", "wm_btn_save_location_select");
                BtnConvert.Text = " " + software_lang.TSReadLangs("WalpaMain", "wm_btn_convert");
                //
                if (string.IsNullOrEmpty(_saveDirectory)){
                    LabelSLocation_V.Text = software_lang.TSReadLangs("WalpaMain", "wm_label_save_location_null");
                }
                UpdateItemCount();
                // OTHER PAGE PRELOADER
                SoftwareOtherPage_Preloader();
            }catch (Exception) { }
        }
        private void SoftwareOtherPage_Preloader(){
            // SOFTWARE ABOUT
            try{
                WalpaAbout software_about = new WalpaAbout();
                string software_about_name = "walpa_about";
                software_about.Name = software_about_name;
                if (Application.OpenForms[software_about_name] != null){
                    software_about = (WalpaAbout)Application.OpenForms[software_about_name];
                    software_about.About_Preloader();
                }
            }catch (Exception) { }
        }
        // STARTUP SETINGS
        // ======================================================================================================
        private ToolStripMenuItem selected_startup_mode = null;
        private void Select_startup_mode_active(object target_startup_mode){
            if (target_startup_mode == null)
                return;
            ToolStripMenuItem clicked_startup_mode = (ToolStripMenuItem)target_startup_mode;
            if (selected_startup_mode == clicked_startup_mode)
                return;
            Select_startup_mode_deactive();
            selected_startup_mode = clicked_startup_mode;
            selected_startup_mode.Checked = true;
        }
        private void Select_startup_mode_deactive(){
            foreach (ToolStripMenuItem disabled_startup in startupToolStripMenuItem.DropDownItems){
                disabled_startup.Checked = false;
            }
        }
        private void WindowedToolStripMenuItem_Click(object sender, EventArgs e){
            if (startup_status != 0){ startup_status = 0; Startup_mode_settings("0"); Select_startup_mode_active(sender); }
        }
        private void FullScreenToolStripMenuItem_Click(object sender, EventArgs e){
            if (startup_status != 1){ startup_status = 1; Startup_mode_settings("1"); Select_startup_mode_active(sender); }
        }
        private void Startup_mode_settings(string get_startup_value){
            try{
                TSSettingsModule software_setting_save = new TSSettingsModule(ts_sf);
                software_setting_save.TSWriteSettings(ts_settings_container, "StartupStatus", get_startup_value);
            }catch (Exception) { }
        }
        // LIST VIEW SETINGS
        // ======================================================================================================
        private ToolStripMenuItem selected_listview_mode = null;
        private void Select_listview_mode_active(object target_listview_mode){
            if (target_listview_mode == null)
                return;
            ToolStripMenuItem clicked_listview_mode = (ToolStripMenuItem)target_listview_mode;
            if (selected_listview_mode == clicked_listview_mode)
                return;
            Select_listview_mode_deactive();
            selected_listview_mode = clicked_listview_mode;
            selected_listview_mode.Checked = true;
        }
        private void Select_listview_mode_deactive(){
            foreach (ToolStripMenuItem disabled_listview in listViewModeToolStripMenuItem.DropDownItems){
                disabled_listview.Checked = false;
            }
        }
        private void FileNameToolStripMenuItem_Click(object sender, EventArgs e){
            if (listview_status != 0){ listview_status = 0; Listview_mode_settings("0"); Select_listview_mode_active(sender); RefreshListViewDisplay(); }
        }
        private void FullPathToolStripMenuItem_Click(object sender, EventArgs e){
            if (listview_status != 1){ listview_status = 1; Listview_mode_settings("1"); Select_listview_mode_active(sender); RefreshListViewDisplay(); }
        }
        private void Listview_mode_settings(string get_listview_value){
            try{
                TSSettingsModule software_setting_save = new TSSettingsModule(ts_sf);
                software_setting_save.TSWriteSettings(ts_settings_container, "ListViewStatus", get_listview_value);
            }catch (Exception){ }
        }
        // UPDATE CHECK ENGINE
        // ======================================================================================================
        private void CheckforUpdatesToolStripMenuItem_Click(object sender, EventArgs e){
            Task.Run(() => Software_update_check(1));
        }
        public async void Software_update_check(int _check_update_ui){
            try{
                TSGetLangs software_lang = new TSGetLangs(lang_path);
                SetUpdateMenuEnabled(false);
                if (!await IsNetworkAvailable()){
                    if (_check_update_ui == 1){
                        TS_MessageBoxEngine.TS_MessageBox(this, 2, string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_not_connection"), "\n\n"), string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_title"), Application.ProductName));
                    }
                    return;
                }
                using (HttpClientHandler handler = new HttpClientHandler()){
                    handler.UseProxy = false;
                    using (HttpClient httpClient = new HttpClient(handler)){
                        httpClient.Timeout = TimeSpan.FromSeconds(15);
                        httpClient.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue { NoCache = true, NoStore = true, MustRevalidate = true };
                        httpClient.DefaultRequestHeaders.Pragma.ParseAdd("no-cache");
                        string versionUrl = TS_LinkSystem.github_link_lv;
                        versionUrl += (versionUrl.Contains("?") ? "&" : "?") + "_ts=" + DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                        string response = await httpClient.GetStringAsync(versionUrl);
                        string firstLine = response.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None)[0];
                        string client_version_raw = TS_VersionParser.ParseUINormalize(Application.ProductVersion);
                        string last_version_raw = TS_VersionParser.ParseUINormalize(firstLine.Split(new[] { '=' }, 2)[1].Trim());
                        Version client_ver = Version.Parse(client_version_raw);
                        Version last_ver = Version.Parse(last_version_raw);
                        if (client_ver < last_ver){
                            DialogResult info_update = TS_MessageBoxEngine.TS_MessageBox(this, 5, string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_available"), Application.ProductName, "\n\n", client_version_raw, "\n", last_version_raw, "\n\n"), string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_title"), Application.ProductName));
                            if (info_update == DialogResult.Yes){
                                try{
                                    string updaterPath = Path.Combine(Application.StartupPath, Program.updater_exe_name);
                                    if (File.Exists(updaterPath)){
                                        string procName = Path.GetFileNameWithoutExtension(updaterPath);
                                        bool isRunning = Process.GetProcessesByName(procName).Length > 0;
                                        if (!isRunning){
                                            Process.Start(new ProcessStartInfo(updaterPath) { UseShellExecute = true, Arguments = $"-app={Application.ProductName}" });
                                        }else{
                                            TS_MessageBoxEngine.TS_MessageBox(this, 1, software_lang.TSReadLangs("SoftwareUpdate", "su_ts_updater_c_running"), string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_title"), Application.ProductName));
                                        }
                                        Application.Exit();
                                        return;
                                    }else{
                                        TS_MessageBoxEngine.TS_MessageBox(this, 2, string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_ts_updater_not_available"), Program.updater_exe_name), string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_title"), Application.ProductName));
                                        Process.Start(new ProcessStartInfo(TS_LinkSystem.github_link_lr) { UseShellExecute = true });
                                        Application.Exit();
                                        return;
                                    }
                                }catch (Exception ex){
                                    Debug.WriteLine(ex, $"{Program.updater_exe_name} launch block.");
                                }
                            }
                        }else if (_check_update_ui == 1){
                            string update_msg = client_ver == last_ver ? string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_not_available"), Application.ProductName, "\n", client_version_raw) : string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_newer"), "\n\n", $"v{client_version_raw}");
                            TS_MessageBoxEngine.TS_MessageBox(this, 1, update_msg, string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_title"), Application.ProductName));
                        }
                    }
                }
            }catch (Exception ex){
                Debug.WriteLine(ex, "Software_update_check()");
                TSGetLangs software_lang = new TSGetLangs(lang_path);
                TS_MessageBoxEngine.TS_MessageBox(this, 3, string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_error"), "\n\n", ex.Message), string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_title"), Application.ProductName));
            }finally{
                SetUpdateMenuEnabled(true);
            }
        }
        private void SetUpdateMenuEnabled(bool enabled){
            if (InvokeRequired){
                BeginInvoke(new Action(() => checkforUpdatesToolStripMenuItem.Enabled = enabled));
            }else{
                checkforUpdatesToolStripMenuItem.Enabled = enabled;
            }
        }
        // TS TOOL LAUNCHER MODULE
        // ======================================================================================================
        private void TSToolLauncher<T>(string formName, string langKey) where T : Form, new(){
            try{
                TSGetLangs software_lang = new TSGetLangs(lang_path);
                T tool = new T { Name = formName };
                if (Application.OpenForms[formName] == null){
                    tool.Show();
                }else{
                    if (Application.OpenForms[formName].WindowState == FormWindowState.Minimized){
                        Application.OpenForms[formName].WindowState = FormWindowState.Normal;
                    }
                    string public_message = string.Format(software_lang.TSReadLangs("HeaderHelp", "header_help_info_notification"), software_lang.TSReadLangs("HeaderMenu", langKey));
                    TS_MessageBoxEngine.TS_MessageBox(this, 1, public_message);
                    Application.OpenForms[formName].Activate();
                }
            }catch (Exception){ }
        }
        // DONATE LINK
        // ======================================================================================================
        private void DonateToolStripMenuItem_Click(object sender, EventArgs e){
            try{
                Process.Start(new ProcessStartInfo(TS_LinkSystem.ts_donate) { UseShellExecute = true });
            }catch (Exception){ }
        }
        // ABOUT PAGE
        // ======================================================================================================
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e){
            TSToolLauncher<WalpaAbout>("walpa_about", "header_menu_about");
        }
        // EXIT
        // ======================================================================================================
        private void WalpaMain_FormClosing(object sender, FormClosingEventArgs e){
            Application.Exit();
        }
    }
}