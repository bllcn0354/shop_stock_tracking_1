using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_stock_tracking.Formlar
{
    public partial class frm_giris : Form
    {
        public frm_giris()
        {
            InitializeComponent();
        }
        Siniflar.Genel gnl = new Siniflar.Genel();       

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string sq = "";
            DataTable dt = new DataTable();

            sq = "select p_kul_adi , p_sifre from tbl_personel where p_kul_adi='" + txt_kuladi.Text + "' and p_sifre='" + txt_sifre.Text + "' ";
            gnl.SQL_Cek(sq, dt, gnl.prm.localdb_, gnl.prm.database_);

            for (int k = 0; k < dt.Rows.Count; k++)
            {
                gnl.datacek(dt, k, "p_kul_adi");
                if (gnl.gelen_deger == txt_kuladi.Text)
                {
                    for (int s = 0; s < dt.Rows.Count; s++)
                    {
                        gnl.datacek(dt, k, "p_sifre");
                        if (gnl.gelen_deger == txt_sifre.Text)
                        {                            
                            Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Şifre Hatalı", "SST", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Hatalı", "SST", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void frm_giris_Load(object sender, EventArgs e)
        {
          
        }

        public void pcb1_load()
        {
          
        }

        private void txt_sifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btn_giris.PerformClick();
            }
        }
    }
}
