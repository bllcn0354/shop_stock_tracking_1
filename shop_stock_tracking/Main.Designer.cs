
namespace shop_stock_tracking
{
    partial class Main
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
            bool isDesignMode = DesignMode;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            if (--OpenFormCount == 0 && !isDesignMode)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.tmr_first_loader = new System.Windows.Forms.Timer(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grp_menu = new DevExpress.XtraEditors.GroupControl();
            this.btn_stok = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cari = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ayarlar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_satis = new DevExpress.XtraEditors.SimpleButton();
            this.btn_raporlar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_personel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_muhasebe = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pcb_destek = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pcb_youtube = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_menu)).BeginInit();
            this.grp_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_destek)).BeginInit();
            this.pcb_destek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_youtube.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            resources.ApplyResources(this.tabFormControl1, "tabFormControl1");
            this.tabFormControl1.Manager = this.tabFormDefaultManager1;
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.PageCreated += new DevExpress.XtraBars.PageCreatedEventHandler(this.tabFormControl1_PageCreated);
            this.tabFormControl1.PageClosing += new DevExpress.XtraBars.PageClosingEventHandler(this.tabFormControl1_PageClosing);
            this.tabFormControl1.PageClosed += new DevExpress.XtraBars.PageClosedEventHandler(this.tabFormControl1_PageClosed);
            this.tabFormControl1.OuterFormCreating += new DevExpress.XtraBars.OuterFormCreatingEventHandler(this.OnOuterFormCreating);
            this.tabFormControl1.Click += new System.EventHandler(this.tabFormControl1_Click);
            this.tabFormControl1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tabFormControl1_ControlRemoved);
            this.tabFormControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabFormControl1_MouseDown);
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.DockingEnabled = false;
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.Manager = null;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.Manager = null;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.Manager = null;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.Manager = null;
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            resources.ApplyResources(this.tabFormPage1, "tabFormPage1");
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabFormContentContainer1.Appearance.Options.UseBackColor = true;
            this.tabFormContentContainer1.Controls.Add(this.panelControl1);
            resources.ApplyResources(this.tabFormContentContainer1, "tabFormContentContainer1");
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            // 
            // tmr_first_loader
            // 
            this.tmr_first_loader.Tick += new System.EventHandler(this.tmr_first_loader_Tick);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.grp_menu);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.pcb_destek);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // grp_menu
            // 
            this.grp_menu.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.grp_menu.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this.grp_menu, "grp_menu");
            this.grp_menu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.grp_menu.Controls.Add(this.btn_stok);
            this.grp_menu.Controls.Add(this.btn_cari);
            this.grp_menu.Controls.Add(this.btn_ayarlar);
            this.grp_menu.Controls.Add(this.btn_satis);
            this.grp_menu.Controls.Add(this.btn_raporlar);
            this.grp_menu.Controls.Add(this.btn_personel);
            this.grp_menu.Controls.Add(this.btn_muhasebe);
            this.grp_menu.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.grp_menu.Name = "grp_menu";
            // 
            // btn_stok
            // 
            resources.ApplyResources(this.btn_stok, "btn_stok");
            this.btn_stok.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_stok.Appearance.Options.UseForeColor = true;
            this.btn_stok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stok.ImageOptions.Image = global::shop_stock_tracking.Properties.Resources.pcb_stok1;
            this.btn_stok.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_stok.Name = "btn_stok";
            this.btn_stok.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_stok.Click += new System.EventHandler(this.btn_stok_Click);
            // 
            // btn_cari
            // 
            resources.ApplyResources(this.btn_cari, "btn_cari");
            this.btn_cari.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_cari.Appearance.Options.UseForeColor = true;
            this.btn_cari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cari.ImageOptions.Image = global::shop_stock_tracking.Properties.Resources.pcb_cari1;
            this.btn_cari.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            // 
            // btn_ayarlar
            // 
            resources.ApplyResources(this.btn_ayarlar, "btn_ayarlar");
            this.btn_ayarlar.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_ayarlar.Appearance.Options.UseForeColor = true;
            this.btn_ayarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ayarlar.ImageOptions.Image = global::shop_stock_tracking.Properties.Resources.pcb_ayarlar1;
            this.btn_ayarlar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_ayarlar.Name = "btn_ayarlar";
            this.btn_ayarlar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            // 
            // btn_satis
            // 
            resources.ApplyResources(this.btn_satis, "btn_satis");
            this.btn_satis.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_satis.Appearance.Options.UseForeColor = true;
            this.btn_satis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_satis.ImageOptions.Image = global::shop_stock_tracking.Properties.Resources.pcb_satis_22;
            this.btn_satis.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_satis.Name = "btn_satis";
            this.btn_satis.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            // 
            // btn_raporlar
            // 
            resources.ApplyResources(this.btn_raporlar, "btn_raporlar");
            this.btn_raporlar.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_raporlar.Appearance.Options.UseForeColor = true;
            this.btn_raporlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_raporlar.ImageOptions.Image = global::shop_stock_tracking.Properties.Resources.pcb_raporlar1;
            this.btn_raporlar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_raporlar.Name = "btn_raporlar";
            this.btn_raporlar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            // 
            // btn_personel
            // 
            resources.ApplyResources(this.btn_personel, "btn_personel");
            this.btn_personel.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_personel.Appearance.Options.UseForeColor = true;
            this.btn_personel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_personel.ImageOptions.Image = global::shop_stock_tracking.Properties.Resources.pcb_personel1;
            this.btn_personel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_personel.Name = "btn_personel";
            this.btn_personel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            // 
            // btn_muhasebe
            // 
            resources.ApplyResources(this.btn_muhasebe, "btn_muhasebe");
            this.btn_muhasebe.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_muhasebe.Appearance.Options.UseForeColor = true;
            this.btn_muhasebe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_muhasebe.ImageOptions.Image = global::shop_stock_tracking.Properties.Resources.pcb_muhasebe1;
            this.btn_muhasebe.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_muhasebe.Name = "btn_muhasebe";
            this.btn_muhasebe.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.simpleButton5);
            this.panelControl2.Controls.Add(this.simpleButton4);
            this.panelControl2.Controls.Add(this.simpleButton3);
            this.panelControl2.Controls.Add(this.simpleButton2);
            this.panelControl2.Controls.Add(this.simpleButton1);
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Name = "panelControl2";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.simpleButton5.Appearance.Options.UseForeColor = true;
            this.simpleButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton5.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton5.ImageOptions.SvgImage = global::shop_stock_tracking.Properties.Resources.menu;
            resources.ApplyResources(this.simpleButton5, "simpleButton5");
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.simpleButton4.Appearance.Options.UseForeColor = true;
            this.simpleButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton4.ImageOptions.SvgImage = global::shop_stock_tracking.Properties.Resources.calculatenow;
            resources.ApplyResources(this.simpleButton4, "simpleButton4");
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton3.ImageOptions.SvgImage = global::shop_stock_tracking.Properties.Resources.date_time;
            resources.ApplyResources(this.simpleButton3, "simpleButton3");
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.ImageOptions.SvgImage = global::shop_stock_tracking.Properties.Resources.officeslim;
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.ImageOptions.SvgImage = global::shop_stock_tracking.Properties.Resources.bo_document;
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            // 
            // pcb_destek
            // 
            this.pcb_destek.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pcb_destek.Appearance.Options.UseBackColor = true;
            this.pcb_destek.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcb_destek.Controls.Add(this.pictureEdit2);
            this.pcb_destek.Controls.Add(this.pcb_youtube);
            resources.ApplyResources(this.pcb_destek, "pcb_destek");
            this.pcb_destek.Name = "pcb_destek";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureEdit2, "pictureEdit2");
            this.pictureEdit2.EditValue = global::shop_stock_tracking.Properties.Resources.pcb_destek;
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // pcb_youtube
            // 
            this.pcb_youtube.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pcb_youtube, "pcb_youtube");
            this.pcb_youtube.EditValue = global::shop_stock_tracking.Properties.Resources.pcb_youtube;
            this.pcb_youtube.Name = "pcb_youtube";
            this.pcb_youtube.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pcb_youtube.Properties.Appearance.Options.UseBackColor = true;
            this.pcb_youtube.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcb_youtube.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcb_youtube.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // Main
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.IconOptions.SvgImage = global::shop_stock_tracking.Properties.Resources.bo_user;
            this.Name = "Main";
            this.TabFormControl = this.tabFormControl1;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grp_menu)).EndInit();
            this.grp_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_destek)).EndInit();
            this.pcb_destek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_youtube.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Timer tmr_first_loader;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        public DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl grp_menu;
        private DevExpress.XtraEditors.SimpleButton btn_stok;
        private DevExpress.XtraEditors.SimpleButton btn_cari;
        private DevExpress.XtraEditors.SimpleButton btn_ayarlar;
        private DevExpress.XtraEditors.SimpleButton btn_satis;
        private DevExpress.XtraEditors.SimpleButton btn_raporlar;
        private DevExpress.XtraEditors.SimpleButton btn_personel;
        private DevExpress.XtraEditors.SimpleButton btn_muhasebe;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl pcb_destek;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pcb_youtube;
    }
}

