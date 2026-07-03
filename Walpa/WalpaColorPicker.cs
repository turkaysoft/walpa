using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
// TS Modules
using static Walpa.TSModules;

namespace Walpa{
    public partial class WalpaColorPicker : Form{
        private bool _isUpdating = false;
        private bool _colorSelected = false;
        public Color SelectedColor { get; private set; } = Color.White;
        public WalpaColorPicker(){
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }
        // PRE-LOAD
        // ======================================================================================================
        public void Walpa_Color_Picker_Preloader(){
            try{
                TSThemeModeHelper.InitializeThemeForForm(this);
                //
                BackColor = TS_ThemeEngine.ColorMode(WalpaMain.theme, "TSBT_BGColor");
                //
                foreach (Control control_items in this.Controls){
                    if (control_items is TSCustomLabel ui_label){
                        ui_label.ForeColor = TS_ThemeEngine.ColorMode(WalpaMain.theme, "TSBT_LabelColor1");
                    }
                    if (control_items is TextBox ui_textbox){
                        ui_textbox.BackColor = TS_ThemeEngine.ColorMode(WalpaMain.theme, "TSBT_BGColor2");
                        ui_textbox.ForeColor = TS_ThemeEngine.ColorMode(WalpaMain.theme, "TSBT_LabelColor1");
                    }
                    if (control_items is TSCustomButton ui_button){
                        ui_button.ForeColor = TS_ThemeEngine.ColorMode(WalpaMain.theme, "DynamicThemeActiveBtnBGColor");
                        ui_button.BackColor = TS_ThemeEngine.ColorMode(WalpaMain.theme, "TSBT_AccentColor");
                        ui_button.FlatAppearance.BorderColor = TS_ThemeEngine.ColorMode(WalpaMain.theme, "TSBT_AccentColor");
                        ui_button.FlatAppearance.MouseDownBackColor = TS_ThemeEngine.ColorMode(WalpaMain.theme, "TSBT_AccentColor");
                        ui_button.FlatAppearance.MouseOverBackColor = TS_ThemeEngine.ColorMode(WalpaMain.theme, "AccentColorHover");
                    }
                }
                //
                TSImageRenderer(BtnSave, WalpaMain.theme == 1 ? Properties.Resources.ct_confirm_light : Properties.Resources.ct_confirm_dark, 17, ContentAlignment.MiddleRight);
                // ======================================================================================================
                // TEXTS
                TSGetLangs software_lang = new TSGetLangs(WalpaMain.lang_path);
                Text = string.Format(software_lang.TSReadLangs("WalpaColorPicker", "wcp_title"), Application.ProductName);
                LabelPreMade.Text = software_lang.TSReadLangs("WalpaColorPicker", "wcp_label_premade");
                LabelColorPicker.Text = software_lang.TSReadLangs("WalpaColorPicker", "wcp_label_color_picker");
                LabelManual.Text = software_lang.TSReadLangs("WalpaColorPicker", "wcp_label_manual");
                LabelPreview.Text = software_lang.TSReadLangs("WalpaColorPicker", "wcp_label_preview");
                BtnSave.Text = " " + software_lang.TSReadLangs("WalpaColorPicker", "wcp_button_select");
            }catch (Exception){ }
        }
        // LOAD
        // ======================================================================================================
        private void WalpaColorPicker_Load(object sender, EventArgs e){
            Walpa_Color_Picker_Preloader();
            _colorSelected = false;
        }
        // RENDER RGB SELECTOR
        // ======================================================================================================
        private void PnlGradient_Paint(object sender, PaintEventArgs e){
            Graphics graphics = e.Graphics;
            Rectangle rect = pnlGradient.ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0) return;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (LinearGradientBrush rainbowBrush = new LinearGradientBrush(rect, Color.Red, Color.Red, 0f)){
                ColorBlend cb = new ColorBlend{
                    Positions = new float[] { 0f, 0.17f, 0.33f, 0.5f, 0.67f, 0.83f, 1f },
                    Colors = new Color[] { Color.Red, Color.Yellow, Color.Green, Color.Cyan, Color.Blue, Color.Magenta, Color.Red }
                };
                rainbowBrush.InterpolationColors = cb;
                graphics.FillRectangle(rainbowBrush, rect);
            }
            using (LinearGradientBrush vBrush = new LinearGradientBrush(rect, Color.White, Color.Black, 90f)){
                ColorBlend cbVertical = new ColorBlend{
                    Positions = new float[] { 0f, 0.5f, 1f },
                    Colors = new Color[] {
                        Color.FromArgb(180, Color.White),
                        Color.FromArgb(0, Color.Black),
                        Color.FromArgb(200, Color.Black)
                    }
                };
                vBrush.InterpolationColors = cbVertical;
                graphics.FillRectangle(vBrush, rect);
            }
        }
        // UPDATE UI
        // ======================================================================================================
        private void UpdateUI(Color getColor, Control triggerElement){
            _isUpdating = true;
            _colorSelected = true;
            PB_Preview.BackColor = getColor;
            if (triggerElement != txtHex){
                txtHex.Text = string.Format("#{0:X2}{1:X2}{2:X2}", getColor.R, getColor.G, getColor.B);
            }
            if (triggerElement != txtR) txtR.Text = getColor.R.ToString();
            if (triggerElement != txtG) txtG.Text = getColor.G.ToString();
            if (triggerElement != txtB) txtB.Text = getColor.B.ToString();
            _isUpdating = false;
        }
        // DYNAMIC CURSOR COLOR SELECTOR
        // ======================================================================================================
        private void PnlGradient_SelectColor(object sender, MouseEventArgs e){
            if (e.Button == MouseButtons.Left){
                int x = Math.Max(0, Math.Min(e.X, pnlGradient.Width - 1));
                int y = Math.Max(0, Math.Min(e.Y, pnlGradient.Height - 1));
                double hue = (double)x / pnlGradient.Width * 360.0;
                double yRatio = (double)y / pnlGradient.Height;
                Color basicColor = ColorFromHue(hue);
                Color finalColor;
                if (yRatio < 0.5){
                    double factor = yRatio * 2;
                    int r = (int)(255 - (255 - basicColor.R) * factor);
                    int g = (int)(255 - (255 - basicColor.G) * factor);
                    int b = (int)(255 - (255 - basicColor.B) * factor);
                    finalColor = Color.FromArgb(r, g, b);
                }else{
                    double factor = 1.0 - ((yRatio - 0.5) * 2);
                    factor = Math.Max(0, factor * 0.85);
                    int r = (int)(basicColor.R * factor);
                    int g = (int)(basicColor.G * factor);
                    int b = (int)(basicColor.B * factor);
                    finalColor = Color.FromArgb(r, g, b);
                }
                UpdateUI(finalColor, null);
            }
        }
        private Color ColorFromHue(double hue){
            double hi = Math.Floor(hue / 60.0) % 6;
            double f = (hue / 60.0) - Math.Floor(hue / 60.0);
            int v = 255;
            int p = 0;
            int q = (int)(255 * (1 - f));
            int t = (int)(255 * f);
            if (hi == 0) return Color.FromArgb(v, t, p);
            if (hi == 1) return Color.FromArgb(q, v, p);
            if (hi == 2) return Color.FromArgb(p, v, t);
            if (hi == 3) return Color.FromArgb(p, q, v);
            if (hi == 4) return Color.FromArgb(t, p, v);
            return Color.FromArgb(v, p, q);
        }
        // PRE MADE COLORS SELECTOR
        // ======================================================================================================
        private void PreMadeColors_Click(object sender, EventArgs e) {
            if (sender is Control clickedBox){
                UpdateUI(clickedBox.BackColor, null);
            }
        }
        // HEX TEXT SELECTOR
        // ======================================================================================================
        private void TxtHex_TextChanged(object sender, EventArgs e){
            if (_isUpdating) return;
            try{
                string hex = txtHex.Text.Trim();
                if (string.IsNullOrEmpty(hex)) return;
                if (!hex.StartsWith("#")){
                    _isUpdating = true;
                    txtHex.Text = "#" + hex;
                    txtHex.SelectionStart = txtHex.Text.Length;
                    _isUpdating = false;
                    hex = txtHex.Text;
                }
                if (hex.Length == 7){
                    UpdateUI(ColorTranslator.FromHtml(hex), txtHex);
                }
            }catch{ }
        }
        // RGX TEXT SELECTOR
        // ======================================================================================================
        private void RGB_TextChanged(object sender, EventArgs e){
            if (_isUpdating) return;
            if (!(sender is TextBox activeBox)) return;
            try{
                if (int.TryParse(activeBox.Text, out int number)){
                    if (number > 255){
                        _isUpdating = true;
                        activeBox.Text = "255";
                        activeBox.SelectionStart = activeBox.Text.Length;
                        _isUpdating = false;
                    }
                }
                string rText = string.IsNullOrEmpty(txtR.Text) ? "0" : txtR.Text;
                string gText = string.IsNullOrEmpty(txtG.Text) ? "0" : txtG.Text;
                string bText = string.IsNullOrEmpty(txtB.Text) ? "0" : txtB.Text;
                if (int.TryParse(rText, out int r) && int.TryParse(gText, out int g) && int.TryParse(bText, out int b)){
                    if (r >= 0 && r <= 255 && g >= 0 && g <= 255 && b >= 0 && b <= 255){
                        UpdateUI(Color.FromArgb(r, g, b), activeBox);
                    }
                }
            }catch{ }
        }
        // RGB KEYPRESS
        // ======================================================================================================
        private void RGB_KeyPress(object sender, KeyPressEventArgs e){
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)){
                e.Handled = true;
            }
        }
        // SAVE AND APPLY MAIN FORM
        // ======================================================================================================
        private void BtnSave_Click(object sender, EventArgs e){
            if (!_colorSelected){
                TSGetLangs software_lang = new TSGetLangs(WalpaMain.lang_path);
                TS_MessageBoxEngine.TS_MessageBox(this, 2, software_lang.TSReadLangs("WalpaColorPicker", "wcp_alert_select"));
                return;
            }
            SelectedColor = PB_Preview.BackColor;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        // DISPOSE
        // ======================================================================================================
        protected override void OnFormClosed(FormClosedEventArgs e){ base.OnFormClosed(e); }
    }
}