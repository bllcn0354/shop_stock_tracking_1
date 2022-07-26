using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace shop_stock_tracking
{
    public partial class Main : DevExpress.XtraBars.TabForm
    {
        public Main()
        {
            InitializeComponent();
        }

         Parametreler.settings_LocalDB prm = new Parametreler.settings_LocalDB();
        Siniflar.Genel  gnl = new Siniflar.Genel();
        //Siniflar.location_ lcl = new Siniflar.location_();


        int say1 = 0;
        bool dgr = false;


        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Main form = new Main();            
            form.TabFormControl.Pages.Clear();
            e.Form = form;              
            OpenFormCount++;
           
        }
        static int OpenFormCount = 1;

       
        private void tabFormControl1_Click(object sender, EventArgs e)
        {

        }
        
        Boolean loader_ = false;
        private void Main_Load(object sender, EventArgs e)
        {
            string sq = "";


            Formlar.frm_giris f = new Formlar.frm_giris();



           






            tmr_first_loader.Start();

           
            if (loader_)
            {
                try
                {
                    //prm.Reset();
                    if (prm.ilkmi)
                    {
                        gnl.Create_LocalDB(prm.localdb_, prm.database_);
                        gnl.Create_DataBase(prm.localdb_, prm.database_, "Turkish_100_CI_AS");


                        DataTable dt = new DataTable();
                        int loading_val = 0;
                        //tbl_parametreler////////////////////////////////////////////////////////
                        sq = "CREATE TABLE [dbo].[tbl_parametreler]( " +
                        " [p_kod][bigint] not NULL , [p_deger][bigint] not NULL , [p_aciklama][nvarchar](250)  NULL ); ";
                        gnl.SQL_Create_Table(prm.localdb_, prm.database_, sq);
                       


                        //////////////////////////////////////////////////////////////////////
                        ///

                                              
                           
                            
                          

                            

                            //tbl_stok////////////////////////////////////////////////////////////
                            sq = "CREATE TABLE [dbo].[tbl_stok]( " +
                            "[s_id][int] IDENTITY(1,1) NOT NULL CONSTRAINT PK_tbl_stok PRIMARY KEY (s_id) " +
                            ", [s_adi][nvarchar](500) not null , [s_birim][nvarchar](50) not null , [s_gel_fiyat][bigint] not null , [s_fiyat][bigint] not null , " +
                            "[s_ozel_fiyat1][bigint]  null , [s_ozel_fiyat2][bigint]  null , [s_ozel_fiyat3][bigint]  null ," +
                            " [s_gel_tar][nvarchar](10) not null , [s_gel_st][nvarchar](5) not null , [s_adet][bigint] not null , [s_barkod_no][bigint] not null " +
                            ", [s_marka][nvarchar](50) not null , [s_model][nvarchar](50) not null , [s_aciklama][nvarchar](500) null , [s_kul_id][int] not null ) ; ";
                            gnl.SQL_Create_Table(prm.localdb_, prm.database_, sq);

                            
                            
                            //////////////////////////////////////////////////////////////////////
                            ///
                            //tbl_personel////////////////////////////////////////////////////////
                            sq = "CREATE TABLE [dbo].[tbl_personel]( " +
                            "[p_id][int] IDENTITY(1,1) NOT NULL CONSTRAINT PK_tbl_personel PRIMARY KEY (p_id) " +
                            ", [p_adi][nvarchar](100) not null , [p_soyadi][nvarchar](100) not null, [p_turu][nvarchar](100) not null, [p_kul_adi][nvarchar](200)  null" +
                            ", [p_sifre][nvarchar](16)  null , [p_baslangic_tar][nvarchar](10) not null, [p_akpas][nvarchar](1) not null" +
                            ", [p_tcno][nvarchar](11) not null, [p_tel1][nvarchar](10) not null, [p_tel2][nvarchar](10) null, [p_ulke][int]  null " +
                            ", [p_il][int]  null , [p_ilce][int]  null , [p_adres1][nvarchar](500)  null , [p_adres2][nvarchar](500)  null  " +
                            ", [p_unvan][nvarchar](100) null  ) ; ";
                            gnl.SQL_Create_Table(prm.localdb_, prm.database_, sq);

                            string bu_gun = DateTime.Now.ToString("yyyy-MM-dd");                            

                            sq = "select p_kul_adi as kullanici_adi from tbl_personel where p_kul_adi='" + prm.default_kullanici_adi + "'";
                            gnl.SQL_Cek(sq, dt, prm.localdb_, prm.database_);
                            if (dt.Rows.Count <= 0)
                            {
                                sq = "insert into tbl_personel (p_adi,p_soyadi,p_turu,p_kul_adi,p_sifre,p_baslangic_tar,p_akpas,p_tcno,p_tel1) values ('" + prm.default_personel_adi + "' , '" + prm.default_personel_soyadi + "' , " +
                                "'" + prm.default_personel_turu + "' , '" + prm.default_kullanici_adi + "' , '" + prm.default_sifre + "' , '" + bu_gun + "' , 'a' , '0' , '" + prm.default_tel1 + "' )";

                                gnl.SQL_Yurut(sq, prm.localdb_, prm.database_);
                            }

                           
                            //////////////////////////////////////////////////////////////////////
                            ///
                            //lokasyonlar////////////////////////////////////////////////////////                       
                            StreamReader sr = new StreamReader("addresses");
                            sq = sr.ReadToEnd();
                            gnl.SQL_Create_Table(prm.localdb_, prm.database_, sq);


                            //////////////////////////////////////////////////////////////////////
                            ///                  
                            //tbl_barkod////////////////////////////////////////////////////////
                            sq = "CREATE TABLE [dbo].[tbl_barkod]( " +
                            "[b_id][int] IDENTITY(1,1) NOT NULL CONSTRAINT PK_tbl_barkod PRIMARY KEY (b_id) , [b_kod][nvarchar](13)  NOT NULL , [b_stok_kod][bigint] NULL , [b_stok_adi][nvarchar](500) NULL , " +
                            "[b_ol_tar][nvarchar](10) not null ); ";
                            gnl.SQL_Create_Table(prm.localdb_, prm.database_, sq);

                           
                            //////////////////////////////////////////////////////////////////////
                            ///             
                            //tbl_cari////////////////////////////////////////////////////////
                            sq = "CREATE TABLE [dbo].[tbl_cari]( " +
                            "[c_id][int] IDENTITY(1,1) NOT NULL CONSTRAINT PK_tbl_cari PRIMARY KEY (c_id) , [c_kod][nvarchar](500) not null , [c_adi][nvarchar](500) not null , [c_tur][nvarchar](100) not null , " +
                            "[c_tc_&_vergi_no][nvarchar](11) not null , [c_tar][nvarchar](10) not null , [c_tel1][nvarchar](11) NULL , [c_tel2][nvarchar](11) NULL , [c_tel3][nvarchar](11) NULL , " +
                            "[c_adres1][nvarchar](250) NULL , [c_adres2][nvarchar](250) NULL , [c_adres3][nvarchar](250) NULL , [c_ulke][bigint] NULL , [c_sehir][bigint] NULL , [c_ilce][bigint] NULL , [c_mahalle][bigint] NULL); ";
                            gnl.SQL_Create_Table(prm.localdb_, prm.database_, sq);

                           
                            //////////////////////////////////////////////////////////////////////
                            ///
                            //tbl_satrapor////////////////////////////////////////////////////////
                            sq = "CREATE TABLE [dbo].[tbl_satrapor]( " +
                            "[sat_id][int] IDENTITY(1,1) NOT NULL CONSTRAINT PK_tbl_satrapor PRIMARY KEY (sat_id) , [sat_stok_id][nvarchar](MAX) NOT NULL , [sat_cari_id][bigint] NOT NULL , " +
                            "[sat_maliyet][bigint] NOT NULL , [sat_tur][nvarchar](100) NOT NULL , [sat_tahsil_tar][nvarchar](10) NOT NULL , [sat_islem_tar][nvarchar](10) NOT NULL , " +
                            "[sat_aciklama][nvarchar](500) NULL    ); ";
                            gnl.SQL_Create_Table(prm.localdb_, prm.database_, sq);

                           
                            //////////////////////////////////////////////////////////////////////
                            ///
                            //tbl_alrapor////////////////////////////////////////////////////////
                            sq = "CREATE TABLE [dbo].[tbl_alrapor]( " +
                            "[al_id][int] IDENTITY(1,1) NOT NULL CONSTRAINT PK_tbl_alrapor PRIMARY KEY (al_id) , [al_alinan][nvarchar](MAX) NOT NULL , [al_cari_id][bigint] NOT NULL , " +
                            "[al_maliyet][bigint] NOT NULL , [al_tur][nvarchar](100) NOT NULL , [al_tahsil_tar][nvarchar](10) NOT NULL , [al_islem_tar][nvarchar](10) NOT NULL , " +
                            "[al_aciklama][nvarchar](500) NULL    ); ";
                            gnl.SQL_Create_Table(prm.localdb_, prm.database_, sq);

                           
                            //////////////////////////////////////////////////////////////////////
                            ///
                            //tbl_nakitgc////////////////////////////////////////////////////////
                            sq = "CREATE TABLE [dbo].[tbl_nakitgc]( " +
                            "[gc_id][int] IDENTITY(1,1) NOT NULL CONSTRAINT PK_tbl_nakitgc PRIMARY KEY (gc_id) , [gc_tur][nvarchar](1) NOT NULL , [gc_rapor_id][bigint] NULL , " +
                            "[gc_maliyet][bigint] NOT NULL , [gc_personel_id][bigint] NULL , " +
                            "[gc_cihaz_takip_id][bigint] NULL ); ";
                            gnl.SQL_Create_Table(prm.localdb_, prm.database_, sq);

                           
                            //////////////////////////////////////////////////////////////////////
                            ///
                            //tbl_cihaz_takip////////////////////////////////////////////////////////
                            sq = "CREATE TABLE [dbo].[tbl_cihaz_takip]( " +
                            "[ct_id][int] IDENTITY(1,1) NOT NULL CONSTRAINT PK_tbl_cihaz_takip PRIMARY KEY (ct_id) , [ct_adi][nvarchar](200) NOT NULL , [ct_serino][nvarchar](200) NULL , [ct_marka][nvarchar](200) NOT NULL , " +
                            "[ct_maliyet][bigint] NULL , [ct_islemtutari][bigint] NULL , [ct_sifre][nvarchar](500) NULL , [ct_cari_id][bigint] not NULL , [ct_per_id][bigint] not NULL , [ct_ariza][nvarchar](250) not NULL , " +
                            "[ct_durum][nvarchar](100) not NULL , [ct_aciklama][nvarchar](500) NULL , [ct_gel_tar][nvarchar](10) not NULL , [ct_bit_tar][nvarchar](10) NULL , " +
                            "[ct_serviseyollama_tar][nvarchar](10) NULL , [ct_teslim_tar][nvarchar](10) NULL ); ";
                            gnl.SQL_Create_Table(prm.localdb_, prm.database_, sq);

                           
                            //////////////////////////////////////////////////////////////////////
                            ///
                            //tbl_hizli_sat////////////////////////////////////////////////////////
                            sq = "CREATE TABLE [dbo].[tbl_hizli_sat]( " +
                            "[hs_id][int] IDENTITY(1,1) NOT NULL CONSTRAINT PK_tbl_hizli_sat PRIMARY KEY (hs_id) , [hs_stok_id][nvarchar](max) NOT NULL , [hs_maliyet][bigint] NOT NULL , [hs_odeme_turu][nvarchar](100) NOT NULL , " +
                            "[hs_personel_id][bigint] NOT NULL , [hs_tar][nvarchar](10) NOT NULL , [hs_saat][nvarchar](5) NOT NULL , [hs_aciklama][nvarchar](200) NULL ); ";
                            gnl.SQL_Create_Table(prm.localdb_, prm.database_, sq);

                            

                            //////////////////////////////////////////////////////////////////////
                            ///                           
                            //tbl_maliyetler////////////////////////////////////////////////////////
                            sq = "CREATE TABLE [dbo].[tbl_maliyetler]( " +
                            " [m_id][int] IDENTITY(1,1) NOT NULL CONSTRAINT PK_tbl_maliyetler PRIMARY KEY (m_id) , " +
                            " [m_tur][bigint] not NULL , [m_tutar][bigint] not NULL , " +
                            " [m_tekrarla][int] not NULL , [m_tekrarlama_araligi][bigint] NULL , [m_personel_id][bigint] not NULL , [m_islem_tar][nvarchar](10) not NULL  , [m_aciklama][nvarchar](250) NULL); ";
                            gnl.SQL_Create_Table(prm.localdb_, prm.database_, sq);


                           

                            //////////////////////////////////////////////////////////////////////




                            prm.ilkmi = false;
                            prm.Save();



                            //MessageBox.Show("Hoşgeldiniz", "SST", MessageBoxButtons.OK, MessageBoxIcon.Information );
                           
                    }


                   
                    //Formlar.frm_anasayfa frm = new Formlar.frm_anasayfa();
                    //frm.Dock = DockStyle.Fill;
                    //frm.FormBorderStyle = FormBorderStyle.None;
                    //frm.TopLevel = false;
                    //frm.AutoScaleMode = AutoScaleMode.Dpi;
                    //tabFormControl1.Pages[0].ContentContainer.Controls.Add(frm);                    
                    //frm.Show();


                    


                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                gnl.p_ = panelControl1;
                gnl.tfp_ = tabFormPage1;

                Hide();
                f.ShowDialog();
                Show();
            }









        }
       
        private void tmr_first_loader_Tick(object sender, EventArgs e)
        {
            say1++;
            if (say1>10 && dgr == false)
            {
                dgr = true;

                loader_ = true;
                
                Main_Load(this, e);

                

            }
            if (dgr==true)
            {
                tmr_first_loader.Stop();
            }

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabFormContentContainer1_Click_1(object sender, EventArgs e)
        {

        }
        bool son_sekme = false;
        private void tabFormControl1_PageCreated(object sender, PageCreatedEventArgs e)
        {

            if (son_sekme == false)
            {
                DevExpress.XtraEditors.PanelControl panel_ = new DevExpress.XtraEditors.PanelControl();
                panel_ = gnl.p_;


                e.Page.Text = "Anasayfa_new";
                panel_ = panelControl1;
                panel_.Dock = DockStyle.Fill;
                e.Page.ContentContainer.Controls.Add(panel_);
                panel_.Show();



                try
                {
                    foreach (TabFormPage item_ in tabFormControl1.Pages)
                    {
                        if (item_.Text == "Anasayfa")
                        {
                            item_.Dispose();
                        }
                    }
                }
                catch (Exception)
                {

                }

                e.Page.Text = "Anasayfa";
            }
            else
            {

            }

            


        }

        private void tabFormControl1_PageClosed(object sender, PageClosedEventArgs e)
        {
                     
        }

        private void tabFormControl1_ControlRemoved(object sender, ControlEventArgs e)
        {
         
        }

        private void tabFormControl1_PageClosing(object sender, PageClosingEventArgs e)
        {
          
        }

        private void tabFormControl1_MouseDown(object sender, MouseEventArgs e)
        {
            TabFormPageViewInfo info = tabFormControl1.ViewInfo.GetPageInfo(tabFormControl1.SelectedPage);
            bool SelectedPageCloseButtonPressed = info != null && info.CloseButtonState == ObjectState.Pressed && info.GetCloseButtonBounds().Contains(e.Location);
            if (SelectedPageCloseButtonPressed)
            {

                try
                {
                    foreach (TabFormPage item in tabFormControl1.Pages)
                    {
                        if (item.Text=="Anasayfa" || tabFormControl1.Pages.Count==1)
                        {
                            info.CloseButtonState = ObjectState.Disabled;
                        }
                    }
                }
                catch (Exception)
                {
                    info.CloseButtonState = ObjectState.Disabled;

                }
                        

             
               
            }





          
        }

        private void btn_stok_Click(object sender, EventArgs e)
        {
            DevExpress.XtraBars.TabFormPage formPage = new DevExpress.XtraBars.TabFormPage();            
            Formlar.frm_stok frm_Stok = new Formlar.frm_stok();
            formPage.Text = frm_Stok.Text;
            frm_Stok.Dock = DockStyle.Fill;
            frm_Stok.FormBorderStyle = FormBorderStyle.None;
            frm_Stok.TopLevel = false;
            tabFormControl1.Pages.Add(formPage);
            formPage.ContentContainer.Controls.Add(frm_Stok);            
            frm_Stok.Show();
            formPage.Visible = true;
            tabFormControl1.SelectedPage=formPage;

        }
    }
}
