
namespace shop_stock_tracking.Formlar
{
    partial class frm_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_giris));
            this.lbl_sifremiunuttum = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_giris = new DevExpress.XtraEditors.SimpleButton();
            this.pBC1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.cb_dil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pcb_logo = new System.Windows.Forms.PictureBox();
            this.txt_kuladi = new DevExpress.XtraEditors.TextEdit();
            this.txt_sifre = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pBC1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_dil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kuladi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_sifremiunuttum
            // 
            this.lbl_sifremiunuttum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sifremiunuttum.Location = new System.Drawing.Point(165, 305);
            this.lbl_sifremiunuttum.Name = "lbl_sifremiunuttum";
            this.lbl_sifremiunuttum.Size = new System.Drawing.Size(76, 13);
            this.lbl_sifremiunuttum.TabIndex = 5;
            this.lbl_sifremiunuttum.Text = "Şifremi Unuttum";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(276, -1);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(23, 22);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_giris.ImageOptions.SvgImage")));
            this.btn_giris.Location = new System.Drawing.Point(165, 266);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 33);
            this.btn_giris.TabIndex = 3;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pBC1
            // 
            this.pBC1.Location = new System.Drawing.Point(85, 190);
            this.pBC1.Name = "pBC1";
            this.pBC1.Properties.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.pBC1.Properties.Appearance.BackColor2 = System.Drawing.Color.LightCyan;
            this.pBC1.Properties.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.pBC1.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.pBC1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.pBC1.Properties.NullText = "Yükleniyor...";
            this.pBC1.Properties.ShowTitle = true;
            this.pBC1.Size = new System.Drawing.Size(121, 18);
            this.pBC1.TabIndex = 9;
            this.pBC1.Visible = false;
            // 
            // cb_dil
            // 
            this.cb_dil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_dil.EditValue = "Dil";
            this.cb_dil.Location = new System.Drawing.Point(53, 267);
            this.cb_dil.Name = "cb_dil";
            this.cb_dil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_dil.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cb_dil.Size = new System.Drawing.Size(75, 20);
            this.cb_dil.TabIndex = 4;
            // 
            // pcb_logo
            // 
            this.pcb_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcb_logo.Image = global::shop_stock_tracking.Properties.Resources.HCK_Software_Logo;
            this.pcb_logo.Location = new System.Drawing.Point(53, 33);
            this.pcb_logo.Name = "pcb_logo";
            this.pcb_logo.Size = new System.Drawing.Size(187, 150);
            this.pcb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_logo.TabIndex = 3;
            this.pcb_logo.TabStop = false;
            // 
            // txt_kuladi
            // 
            this.txt_kuladi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_kuladi.Location = new System.Drawing.Point(53, 214);
            this.txt_kuladi.Name = "txt_kuladi";
            this.txt_kuladi.Properties.NullText = "Kullanıcı Adı";
            this.txt_kuladi.Size = new System.Drawing.Size(187, 20);
            this.txt_kuladi.TabIndex = 1;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_sifre.Location = new System.Drawing.Point(53, 240);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Properties.NullText = "Şifre";
            this.txt_sifre.Properties.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(187, 20);
            this.txt_sifre.TabIndex = 2;
            this.txt_sifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sifre_KeyDown);
            // 
            // frm_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(299, 333);
            this.Controls.Add(this.pBC1);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cb_dil);
            this.Controls.Add(this.lbl_sifremiunuttum);
            this.Controls.Add(this.pcb_logo);
            this.Controls.Add(this.txt_kuladi);
            this.Controls.Add(this.txt_sifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_giris";
            this.Load += new System.EventHandler(this.frm_giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBC1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_dil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kuladi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_sifre;
        private DevExpress.XtraEditors.TextEdit txt_kuladi;
        private System.Windows.Forms.PictureBox pcb_logo;
        private DevExpress.XtraEditors.LabelControl lbl_sifremiunuttum;
        private DevExpress.XtraEditors.ComboBoxEdit cb_dil;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_giris;
        public DevExpress.XtraEditors.ProgressBarControl pBC1;
    }
}