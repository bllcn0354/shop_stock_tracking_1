using DevExpress.XtraGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_stock_tracking.Siniflar
{
    class Genel
    {

        //public Main _main = new Main();
        //public Formlar.frm_anasayfa _Anasayfa = new Formlar.frm_anasayfa();
        //public Formlar.frm_giris _Giris = new Formlar.frm_giris();
        //public bool acilis = false;


        public DevExpress.XtraEditors.PanelControl p_ = new DevExpress.XtraEditors.PanelControl();
        public DevExpress.XtraBars.TabFormPage tfp_ = new DevExpress.XtraBars.TabFormPage();



        //public static string  DataBase_  = "Deneme_DB1_Test";
        //public static string LocalHost_ = "HCK1";


        public string local_host;
        public string data_base;
        public Parametreler.settings_LocalDB prm = new Parametreler.settings_LocalDB();


        public SqlConnection Con_ilk = new SqlConnection("Data Source=(localdb)\\" + Parametreler.settings_LocalDB.Default.localdb_ + ";");
        public SqlConnection Con = new SqlConnection("Data Source=(localdb)\\" + Parametreler.settings_LocalDB.Default.localdb_ + ";Integrated Security=SSPI;Initial Catalog=" + Parametreler.settings_LocalDB.Default.database_ + "");
        public int loaderdeger = 0;



        public void frmac(Form F1, Form MdiParent_)
        {
            F1.MdiParent = MdiParent_;
            F1.Show();
        }

        /// <summary>
        /// Burada programın kullanacağı tablolar oluşturuluyor
        /// </summary>
        public void SQL_Create_Table(string lcl, string db, string sq)
        {

            // buraya oluşturulacak tabloalr yazılacak
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=(localdb)\\" + lcl + ";Integrated Security=SSPI;Initial Catalog=" + db + "");
                //string SQ = "CREATE TABLE [dbo].[tbl_deneme12345]( " +
                //"[adi][nvarchar](50) NULL, [soyadi] [nvarchar](50) NULL ) ";                
                cn.Close();
                cn.Open();
                SqlCommand cmd = new SqlCommand(sq);
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message.ToString(), "SST", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Burada Local DB Oluşturuluyor
        /// </summary>
        public void Create_LocalDB(string lclhost, string db)
        {
            try
            {
                string strCmdText;
                strCmdText = "/C sqllocaldb create " + lclhost + "";
                Process.Start("CMD.exe", strCmdText);
                strCmdText = "/C sqllocaldb start " + lclhost + "";
                Process.Start("CMD.exe", strCmdText);


                //Parametreler.settings_LocalDB.Default.local_db = lclhost;
                //Parametreler.settings_LocalDB.Default.database = db;
                //Parametreler.settings_LocalDB.Default.Save();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message.ToString(), "SST", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Burada programın veri tabanı oluşturuluyor
        /// Türkçe: Turkish_100_CI_AS
        /// İngilizce: bir şey yazmayınca default o oluyor
        /// </summary>
        public void Create_DataBase(string lcl, string db, string dil)
        {



            try
            {
                SqlConnection cn = new SqlConnection("Data Source=(localdb)\\" + lcl + ";");
                string SQ = "CREATE DATABASE " + db + "  COLLATE " + dil + "";
                cn.Close();
                cn.Open();
                SqlCommand cmd = new SqlCommand(SQ);
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message.ToString(), "SST", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Burası İnsert İnto yapar
        /// </summary>       
        /// <param name="con_">SQL Connection</param>
        /// <param name="SQ">SQL String</param>
        public void SQL_Yurut(string SQ, string lcl, string db)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=(localdb)\\" + lcl + ";Integrated Security=SSPI;Initial Catalog=" + db + "");
                cn.Close();
                cn.Open();
                SqlCommand cmd = new SqlCommand(SQ);
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata : " + ex.Message.ToString(), "SST", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        public void SQL_Cek(string SQ, DataTable DT_, string lcl, string db)
        {

            try
            {
                local_host = lcl;
                data_base = db;
                SqlConnection cn = new SqlConnection("Data Source=(localdb)\\" + lcl + ";Integrated Security=SSPI;Initial Catalog=" + db + "");
                cn.Close();
                cn.Open();
                SqlCommand cmd = new SqlCommand(SQ);
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                DT_.Load(dr);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata : " + ex.Message.ToString(), "SST", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
          
        }


        /// <summary>
        /// burası datagridi değiştirir sütun isim değiştirme
        /// </summary>
        /// <param name="header">datagrid hangisi</param>
        /// <param name="eski">eski değer</param>
        /// <param name="yeni">atanacak değer</param>
        /// <param name="goster">gözüküp gözükmeyeceği</param>
        /// <param name="saltoku">değişebilir mi</param>
        /// <param name="sira">sıra</param>
        /// <param name="sortmode">sıralama modu</param>

        public void sutisdeg(DevExpress.XtraGrid.Views.Grid.GridView header, string yeni, string eski, int sira, Boolean goster, int sortmode, Font f)
        {
            try
            {
                header.Columns[eski].SortMode = (ColumnSortMode)sortmode;
                //header.Columns[eski].GroupIndex = sira;     guruplandırıyor bakılacak
                header.Columns[eski].VisibleIndex = sira;
                if (goster == false)
                {
                    header.Columns[eski].Visible = false;
                }
                else
                {
                    header.Columns[eski].Visible = true;
                }

                header.Columns[eski].Caption = yeni;
               
            }
            catch (Exception)
            {

            }


        }


        public string gelen_deger = "";
        public void  datacek(DataTable dt_ , int str , string stn ) 
        {
          gelen_deger = dt_.Rows[str][stn].ToString();
        }


    }
}
